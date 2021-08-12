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

namespace QLVT_DATHANG.SubForm
{
    public partial class CTPNSubForm : DevExpress.XtraEditors.XtraForm
    {
        private bool isSuccess = false;
        public CTPNSubForm()
        {
            InitializeComponent();
        }

        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cTDDHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void CTPNSubForm_Load(object sender, EventArgs e)
        {
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;

            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);

            this.cTDDHBindingSource.DataSource = Program.nhanVienForm.getCTDatHangBDS();
            this.cTPNBindingSource.DataSource = Program.nhanVienForm.getCTPhieuNhapBDS();

        }

        private void CTPNSubForm_Shown(object sender, EventArgs e)
        {
            this.cTPNBindingSource.AddNew();
            BindingSource tempPN = Program.nhanVienForm.getPhieuNhapBDS();
            if (tempPN.Position != -1 && cTDDHBindingSource.Position != -1)
            {
                tbMaPN.Text = ((DataRowView)tempPN[tempPN.Position])["MAPN"].ToString().Trim();
                tbMaVT.Text = ((DataRowView)cTDDHBindingSource[cTDDHBindingSource.Position])["MAVT"].ToString().Trim();
                nuSoLuong.Maximum = int.Parse(gvCTDDH.GetRowCellValue(cTDDHBindingSource.Position, "SOLUONG").ToString().Trim());
                nuSoLuong.Value = nuSoLuong.Minimum;
                nuDonGia.Value = 0;
                ((DataRowView)cTPNBindingSource[cTPNBindingSource.Position])["SOLUONG"] = nuSoLuong.Minimum;
                ((DataRowView)cTPNBindingSource[cTPNBindingSource.Position])["DONGIA"] = 0;
            }
        }


        private void CTPNSubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSuccess) cTPNBindingSource.CancelEdit();
            Program.mainForm.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaPN, "Mã Phiếu Nhập không được trống!")) return;
            if (!checkValidate(tbMaVT, "Mã VT không được trống!")) return;
            //Kiểm tra trùng CTPN
            int positionMaVT = cTPNBindingSource.Find("MAVT", tbMaVT.Text);
            if (positionMaVT != -1 && (positionMaVT != cTPNBindingSource.Position))
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

                    this.cTPNBindingSource.EndEdit();
                    this.cTPNTableAdapter.Update(Program.nhanVienForm.getDataSet().CTPN);
                    string query = "DECLARE	@result int EXEC @result = SP_UpdateVatTu " + maVT + ", " + soLuong + ", INCREASE SELECT 'result' = @result";

                    SqlDataReader dataReader = Program.ExecSqlDataReader(query);
                    if (dataReader == null) return;
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 0)
                    {
                        MessageBox.Show("Lỗi khi cập nhật Vật Tư vào Database!\n", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        query = "DECLARE @result int EXEC @result = SP_UpdateVatTu " + maVT + ", " + soLuong + ", DECREASE SELECT 'result' = @result";
                        dataReader = Program.ExecSqlDataReader(query);

                        return;
                    }
                    isSuccess = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvCTDDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (cTDDHBindingSource.Position != -1) //Trường hợp không có dữ liệu
            {
                tbMaVT.Text = gvCTDDH.GetRowCellValue(cTDDHBindingSource.Position, "MAVT").ToString().Trim();
                nuSoLuong.Maximum = int.Parse(gvCTDDH.GetRowCellValue(cTDDHBindingSource.Position, "SOLUONG").ToString().Trim());
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
    }
}