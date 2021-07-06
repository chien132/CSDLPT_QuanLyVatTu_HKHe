using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QuanLyVatTu.SubForm
{
    public partial class SubFormCTPN : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormCTPN()
        {
            InitializeComponent();
        }
        private void SubFormCTPN_Load(object sender, EventArgs e)
        {
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;

            this.cTDDHTableAdapter.Fill(this.qLVTDataSet.CTDDH);
            this.cTPNTableAdapter.Fill(this.qLVTDataSet.CTPN);

            this.CTDDH_BDS.DataSource = Program.formNhanVien.getCTDatHangBDS();
            this.CTPN_BDS.DataSource = Program.formNhanVien.getCTPhieuNhapBDS();
        }
        private void SubFormCTPN_Shown(object sender, EventArgs e)
        {
            this.CTPN_BDS.AddNew();
            BindingSource tempPN = Program.formNhanVien.getPhieuNhapBDS();
            if(tempPN.Position != -1 && CTDDH_BDS.Position != -1)
            {
                tbMaPN.Text = ((DataRowView)tempPN[tempPN.Position])["MAPN"].ToString().Trim();
                tbMaVT.Text = ((DataRowView)CTDDH_BDS[CTDDH_BDS.Position])["MAVT"].ToString().Trim();
                nuSoLuong.Maximum = int.Parse(gvCTDDH.GetRowCellValue(CTDDH_BDS.Position, "SOLUONG").ToString().Trim());
                nuSoLuong.Value = nuSoLuong.Minimum;
                nuDonGia.Value = 0;
                ((DataRowView)CTPN_BDS[CTPN_BDS.Position])["SOLUONG"] = nuSoLuong.Minimum;
                ((DataRowView)CTPN_BDS[CTPN_BDS.Position])["DONGIA"] = 0;
            }           
        }
        private void SubFormCTPN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) CTPN_BDS.CancelEdit();
            Program.formMain.Enabled = true;
        }
        private void gvCTDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (CTDDH_BDS.Position != -1) //Trường hợp không có dữ liệu
            {
                tbMaVT.Text = gvCTDDH.GetRowCellValue(CTDDH_BDS.Position, "MAVT").ToString().Trim();
                nuSoLuong.Maximum = int.Parse(gvCTDDH.GetRowCellValue(CTDDH_BDS.Position, "SOLUONG").ToString().Trim());
            }
        }
        private bool checkValidate(TextBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaPN, "Mã Phiếu Nhập is not empty!")) return;
            if (!checkValidate(tbMaVT, "Mã VT is not empty!")) return;
            //Kiểm tra trùng CTPN
            int positionMaVT = CTPN_BDS.Find("MAVT", tbMaVT.Text);
            if (positionMaVT != -1 && (positionMaVT != CTPN_BDS.Position))
            {
                MessageBox.Show("Chi tiết Đơn Đặt Hàng này đã được lập Chi Tiết Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //Lưu lại MAVT và SOLUONG để khi EndEdit không bị mất dữ liệu vì con trỏ về đầu
                    string maVT = tbMaVT.Text;
                    int soLuong = int.Parse(nuSoLuong.Value.ToString());    

                    this.CTPN_BDS.EndEdit();
                    this.cTPNTableAdapter.Update(Program.formNhanVien.getDataSet().CTPN);
                    string query = "DECLARE	@result int " +
                           "EXEC @result = SP_UpdateVatTu @p1, @p2, @p3 " +
                           "SELECT 'result' = @result";
                    SqlCommand sqlCommand = new SqlCommand(query, Program.connection);                  
                    sqlCommand.Parameters.AddWithValue("@p1", maVT);
                    sqlCommand.Parameters.AddWithValue("@p2", soLuong);
                    sqlCommand.Parameters.AddWithValue("@p3", "INCREASE");

                    SqlDataReader dataReader = null;
                    try
                    {
                        dataReader = sqlCommand.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật Vật Tư vào Database!\n" + ex.Message, "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataReader.Close();
                        return;
                    }
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 0)
                    {
                        MessageBox.Show("Lỗi khi cập nhật Vật Tư vào Database!\n", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        query = "DECLARE @result int " +
                               "EXEC @result = SP_UpdateVatTu @p1, @p2, @p3 " +
                               "SELECT 'result' = @result";
                        sqlCommand = new SqlCommand(query, Program.connection);
                        sqlCommand.Parameters.AddWithValue("@p1", maVT);
                        sqlCommand.Parameters.AddWithValue("@p2", soLuong);
                        sqlCommand.Parameters.AddWithValue("@p3", "DECREASE");
                        try
                        {
                            dataReader = sqlCommand.ExecuteReader();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi Rollback dữ liệu. Vui lòng truy suất Database kiểm tra lại!\n" + ex.Message, "Notification",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dataReader.Close();
                            return;
                        }
                        return;
                    }
                    flagSuccess = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}