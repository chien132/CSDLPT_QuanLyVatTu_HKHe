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

namespace QLVT_DATHANG
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            Program.loginForm = this;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void reset()
        {
            tb_dang_nhap.Text = "";
            tb_mat_khau.Text = "";
            cb_chi_nhanh.SelectedIndex = 0;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DSPhanManh.Get_Subscribes' table. You can move, or remove it, as needed.
            this.get_SubscribesTableAdapter.Fill(this.qLVT_DATHANGDataSet_DSPhanManh.Get_Subscribes);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_dang_nhap.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống");
                tb_dang_nhap.Focus();
                return;
            }
            else if (tb_mat_khau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
                tb_mat_khau.Focus();
                return;
            }
            Program.mlogin = tb_dang_nhap.Text.Trim();
            Program.password = tb_mat_khau.Text.Trim();
            Program.servername = cb_chi_nhanh.SelectedValue.ToString();

            if (Program.KetNoi() == 0) return;


            //Program.mChinhanh = cb_chi_nhanh.SelectedIndex;
            //Console.WriteLine(Program.mChinhanh);
            Program.bds_dspm = get_SubscribesBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
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

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Form frm = this.CheckExists(typeof(frmMain));
            if (frm != null) frm.Activate();
            else
            {
                this.Hide();
                //frmMain f = new frmMain();
                Program.mainForm = new frmMain();
                Program.mainForm.Show();
               // NhanVienForm f = new NhanVienForm();
                //f.Show();
            }

            Program.myReader.Close();
            Program.conn.Close();
        }

        private void Exit(object sender, EventArgs e)
        {
            //this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}