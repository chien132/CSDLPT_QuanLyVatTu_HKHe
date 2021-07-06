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
    public partial class SubFormPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        //Cờ đánh dấu đã thêm thành công thì khi Closing cho EndEdit không thì CancelEdit
        private bool flagSuccess = false;
        public SubFormPhieuXuat()
        {
            InitializeComponent();
        }
        private void SubFormPhieuXuat_Load(object sender, EventArgs e)
        {
            this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;

            this.khoTableAdapter.Fill(this.qLVTDataSet.Kho);        
            this.nhanVienTableAdapter.Fill(this.qLVTDataSet.NhanVien);      
            this.phieuXuatTableAdapter.Fill(this.qLVTDataSet.PhieuXuat);

            this.phieuXuatBDS.DataSource = Program.formNhanVien.getPhieuXuatBDS();
        }
        private void SubFormPhieuXuat_Shown(object sender, EventArgs e)
        {
            this.phieuXuatBDS.AddNew();
            ((DataRowView)phieuXuatBDS[phieuXuatBDS.Position])["MANV"] = Program.manv;
            ((DataRowView)phieuXuatBDS[phieuXuatBDS.Position])["NGAY"] = DateTime.Today;
            tbMaKho.Text = ((DataRowView)khoBDS[khoBDS.Position])["MAKHO"].ToString().Trim();
        }
        private void SubFormPhieuXuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagSuccess == false) phieuXuatBDS.CancelEdit();
            Program.formMain.Enabled = true;
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
        private void gvKho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (khoBDS.Position != -1) //Trường hợp không có dữ liệu
            {
                tbMaKho.Text = gvKho.GetRowCellValue(khoBDS.Position, "MAKHO").ToString().Trim();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbMaPX, "Mã Phiếu Xuất is not empty!")) return;
            if (!checkValidate(tbKhachHang, "Họ tên Khách Hàng is not empty!")) return;
            if (!checkValidate(tbMaKho, "Mã Kho is not empty!")) return;
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", tbMaPX.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "MAPX");
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
                return;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            int positionMaPX = phieuXuatBDS.Find("MAPX", tbMaPX.Text);
            int postionCurrent = phieuXuatBDS.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MAPX đang nhập đúng băng vị trí đang đứng
            if (result == 1 && (positionMaPX != postionCurrent))
            {
                MessageBox.Show("Mã Phiếu Xuất đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã Phiếu Xuất đã tồn tại ở Chi Nhánh khác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        this.phieuXuatBDS.EndEdit();
                        this.phieuXuatTableAdapter.Update(Program.formNhanVien.getDataSet().PhieuXuat);
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
}