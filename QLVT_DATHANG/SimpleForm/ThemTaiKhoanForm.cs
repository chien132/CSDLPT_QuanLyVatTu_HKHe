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

namespace QLVT_DATHANG
{
    public partial class ThemTaiKhoanForm : DevExpress.XtraEditors.XtraForm
    {
        public ThemTaiKhoanForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoatTTK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Program.nhanVienSubForm = new SubForm.NhanVienSubForm();
            Program.nhanVienSubForm.Show();
            Program.mainForm.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkValidate(tbTenDN, "Login name is not empty!")) return;
            if (!checkValidate(tbMatKhau, "Password is not empty!")) return;
            if (!checkValidate(tbNhanVien, "User is not empty!")) return;
            if (!(rbCongTy.Checked || rbChiNhanh.Checked || rbUser.Checked))
            {
                MessageBox.Show("Role is not empty!!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbTenDN.Text.Contains(" "))
            {
                MessageBox.Show("Login name không được chứa khoảng trắng!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", tbNhanVien.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "MANV");
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataReader.Read();
            int resultCheckMANV = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            if (resultCheckMANV != 1)
            {
                MessageBox.Show("Mã NV không tồn tại ở Chi Nhánh hiện tại vui lòng kiểm tra lại!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTenDN.Focus();
                return;
            }

            query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckLogin @p1, @p2 " +
                           "SELECT 'result' = @result";
            sqlCommand = new SqlCommand(query, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", tbTenDN.Text);
            sqlCommand.Parameters.AddWithValue("@p2", tbNhanVien.Text);
            dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataReader.Read();
            int resultCheckLogin = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();

            if (resultCheckLogin == 1)
            {
                MessageBox.Show("Login name bị trùng. Vui lòng chọn tên login khác!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTenDN.Focus();
                return;
            }
            else if (resultCheckLogin == 2)
            {
                MessageBox.Show("User bị trùng. Vui lòng chọn nhân viên khác!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonNV.Focus();
                return;
            }
            else
            {
                String role = rbCongTy.Checked ? "CONGTY" : (rbChiNhanh.Checked ? "CHINHANH" : "USER");
                query = "DECLARE @result int " +
                           "EXEC @result = SP_TAOLOGIN @p1, @p2, @p3, @p4 " +
                           "SELECT 'result' = @result";
                sqlCommand = new SqlCommand(query, Program.conn);
                sqlCommand.Parameters.AddWithValue("@p1", tbTenDN.Text);
                sqlCommand.Parameters.AddWithValue("@p2", tbMatKhau.Text);
                sqlCommand.Parameters.AddWithValue("@p3", tbNhanVien.Text);
                sqlCommand.Parameters.AddWithValue("@p4", role);
                try
                {
                    dataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                if (result == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công!", "Notification",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbTenDN.Clear();
                    tbMatKhau.Clear();
                    tbNhanVien.Clear();
                    rbCongTy.Checked = rbChiNhanh.Checked = rbUser.Checked = false;
                    tbTenDN.Focus();
                }
            }
        }

        private void ThemTaiKhoanForm_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "CONGTY")
            {
                rbChiNhanh.Enabled = rbUser.Enabled = false;
            }
            else if (Program.mGroup == "CHINHANH")
            {
                rbCongTy.Enabled = false;
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            tbMatKhau.UseSystemPasswordChar = (cbShow.Checked) ? false : true;
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

        private void ThemTaiKhoanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool checkNonEmpty = !tbTenDN.Text.Equals("") || !tbMatKhau.Text.Equals("") || !tbNhanVien.Text.Equals("");
            bool checkNonCheck = rbCongTy.Checked || rbChiNhanh.Checked || rbUser.Checked;
            Program.flagCloseFormTaoTaiKhoan = (checkNonEmpty || checkNonCheck) ? false : true;

            if (Program.flagCloseFormTaoTaiKhoan == false)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu Form Tài Khoản vẫn chưa lưu! \nBạn có chắn chắn muốn thoát?", "Thông báo",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else if (dr == DialogResult.Yes)
                {
                    Program.flagCloseFormTaoTaiKhoan = true;
                }
            }
        }
    }
}