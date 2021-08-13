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
    public partial class NVTrungIncurredForm : DevExpress.XtraEditors.XtraForm
    {
        public NVTrungIncurredForm()
        {
            InitializeComponent();
        }

        private void NVTrungIncurredForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainForm.Enabled = true;
        }

        private void NVTrungIncurredForm_Load(object sender, EventArgs e)
        {
            /*
             * Trước khi đổ dữ liệu cần cập nhập Connection của Adapter điều này xảy ra khi
             * Trường hợp này xảy ra khi đăng nhập từ 1 Nhân viên ở CN2 và cần GrowTable dữ liệu cũng của CN2
            */
            this.sP_ListNVTrungChuyenChiNhanhTableAdapter.Connection.ConnectionString = Program.connstr;
            try
            {
                this.sP_ListNVTrungChuyenChiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.SP_ListNVTrungChuyenChiNhanh, Program.maNVChuyenCN);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int newMANV = NhanVienForm.taoMaNVMoi();
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_NewMaNVChuyenCN @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", Program.maNVChuyenCN);
            sqlCommand.Parameters.AddWithValue("@p2", newMANV);
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
            if (result == -1)       //Trường hợp thất bại
            {
                MessageBox.Show("Chuyển Chi nhánh thất bại! Dữ liệu đã được Roolback!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
            }
            else if (result == 0)   //Trường hợp thành công khi bên Chi nhánh kia nhân viên chưa từng chuyển chi nhánh
            {
                MessageBox.Show("Chuyển chi nhánh thành công. Với Mã Nhân Viên mới là: " + newMANV, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoaLogin();         //Đồng thời xóa Login(nếu có)
                this.Close();
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(((DataRowView)sP_ListNVTrungChuyenChiNhanhBindingSource.Current)["MANV"].ToString());
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_UpdateChuyenCN @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", Program.maNVChuyenCN);
            sqlCommand.Parameters.AddWithValue("@p2", manv);
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
            if (result == 1)
            {
                MessageBox.Show("Nhân viên đã chuyển về chi nhánh cũ với Mã Nhân Viên cũ là: " + manv, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoaLogin();         //Đồng thời xóa Login(nếu có)    
                this.Close();
            }
            else
            {
                MessageBox.Show("Chuyển Chi nhánh thất bại! Dữ liệu đã được Roolback!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
            }
        }
        private void xoaLogin()
        {
            string query = "DECLARE	@result int " +
                          "EXEC @result = SP_XoaLogin @p1 " +
                          "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", Program.maNVChuyenCN);
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
            if (result == 1)
            {
                MessageBox.Show("Xóa Login không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Xóa User không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataReader.Close();
                return;
            }
        }
    }
}