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
    public partial class SubFormCTPX : DevExpress.XtraEditors.XtraForm
    {
        private bool flagSuccess = false;
        public SubFormCTPX()
        {
            InitializeComponent();
        }
        private void SubFormCTPX_Load(object sender, EventArgs e)
        {
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;

            this.vattuTableAdapter.Fill(this.qLVTDataSet.Vattu);          
            this.cTPXTableAdapter.Fill(this.qLVTDataSet.CTPX);

            this.cTPX_BDS.DataSource = Program.formNhanVien.getCTPhieuXuatBDS();

        }
        private void SubFormCTPX_Shown(object sender, EventArgs e)
        {
            this.cTPX_BDS.AddNew();
            BindingSource tempPX = Program.formNhanVien.getPhieuXuatBDS();
            if (tempPX.Position != -1 && vatTuBDS.Position != -1)
            {
                tbMaPX.Text = ((DataRowView)tempPX[tempPX.Position])["MAPX"].ToString().Trim();
                tbMaVT.Text = ((DataRowView)vatTuBDS[vatTuBDS.Position])["MAVT"].ToString().Trim();
                nuSoLuong.Maximum = int.Parse(gvVatTu.GetRowCellValue(vatTuBDS.Position, "SOLUONGTON").ToString().Trim());
                nuSoLuong.Value = nuSoLuong.Minimum;
                nuDonGia.Value = 0;
                ((DataRowView)cTPX_BDS[cTPX_BDS.Position])["SOLUONG"] = nuSoLuong.Minimum;
                ((DataRowView)cTPX_BDS[cTPX_BDS.Position])["DONGIA"] = 0;
            }
        }
        private void SubFormCTPX_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) cTPX_BDS.CancelEdit();
            Program.formMain.Enabled = true;
        }
        private void gvVatTu_Click(object sender, EventArgs e)
        {
            if (vatTuBDS.Position != -1) //Trường hợp không có dữ liệu
            {
                int soluong = int.Parse(gvVatTu.GetRowCellValue(vatTuBDS.Position, "SOLUONGTON").ToString().Trim());
                if(soluong <= 0)
                {
                    MessageBox.Show("Vật Tư không còn hàng. Vui lòng kiểm tra lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    nuSoLuong.Maximum = int.Parse(gvVatTu.GetRowCellValue(vatTuBDS.Position, "SOLUONGTON").ToString().Trim());
                    nuSoLuong.Minimum = 1;
                    tbMaVT.Text = gvVatTu.GetRowCellValue(vatTuBDS.Position, "MAVT").ToString().Trim();
                }
                
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
            if (!checkValidate(tbMaPX, "Mã Phiếu Xuất is not empty!")) return;
            if (!checkValidate(tbMaVT, "Mã VT is not empty!")) return;
            if (nuSoLuong.Value == 0)    //Trường hợp khi vừa Load vật tư số lượng tồn còn 0
            {
                MessageBox.Show("Số lượng phải > 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Kiểm tra trùng CTPN
            int positionMaVT = cTPX_BDS.Find("MAVT", tbMaVT.Text);
            if (positionMaVT != -1 && (positionMaVT != cTPX_BDS.Position))
            {
                MessageBox.Show("Trùng Mã số PX & Mã VT của chi tiết PX khác!", "Thông báo",
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

                    this.cTPX_BDS.EndEdit();
                    this.cTPXTableAdapter.Update(Program.formNhanVien.getDataSet().CTPX);
                    string query = "DECLARE	@result int " +
                           "EXEC @result = SP_UpdateVatTu @p1, @p2, @p3 " +
                           "SELECT 'result' = @result";
                    SqlCommand sqlCommand = new SqlCommand(query, Program.connection);

                    sqlCommand.Parameters.AddWithValue("@p1", maVT);
                    sqlCommand.Parameters.AddWithValue("@p2", soLuong);
                    sqlCommand.Parameters.AddWithValue("@p3", "DECREASE");
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