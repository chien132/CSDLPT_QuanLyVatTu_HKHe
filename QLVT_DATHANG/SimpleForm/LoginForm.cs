using System;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DSPhanManh.Get_Subscribes' table. You can move, or remove it, as needed.
            this.get_SubscribesTableAdapter.Fill(this.qLVT_DATHANGDataSet_DSPhanManh.Get_Subscribes);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_dang_nhap.Text.Trim() == "") {
                MessageBox.Show("Tên đăng nhập không được bỏ trống");
                tb_dang_nhap.Focus();
                return;
            }
            else if( tb_mat_khau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
                tb_mat_khau.Focus();
                return;
            }
            Program.mlogin = tb_dang_nhap.Text.Trim();
            Program.password = tb_mat_khau.Text.Trim();
            Program.servername = cb_chi_nhanh.SelectedValue.ToString();

            if (Program.KetNoi() == 0) return;

            Program.bds_dspm = get_SubscribesBindingSource;

            String strLenh = "EXEC SP_THONGTINDANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn không có quyền truy cập dữ liệu");
                return;
            }

            Form frm = this.CheckExists(typeof(frmMain));
            if (frm != null) frm.Activate();
            else
            {
                this.Hide();
                frmMain f = new frmMain();
                f.Show();
            }

            Program.myReader.Close();
            Program.conn.Close();
        }

        private void Exit(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}