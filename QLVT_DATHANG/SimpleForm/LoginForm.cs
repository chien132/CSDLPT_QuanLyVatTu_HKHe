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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();

        private void layDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cbChiNhanh.DataSource = dt;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối CSDL gốc.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

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
            tbLogin.Text = "";
            tbPassword.Text = "";
            cbChiNhanh.SelectedIndex = 0;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DSPhanManh.Get_Subscribes' table. You can move, or remove it, as needed.
            //this.get_SubscribesTableAdapter.Fill(this.qLVT_DATHANGDataSet_DSPhanManh.Get_Subscribes);
            if (KetNoi_CSDLGOC() == 0) return;
            layDSPM("SELECT * FROM Get_Subscribes");
            //cb_chi_nhanh.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống");
                tbLogin.Focus();
                return;
            }
            else if (tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
                tbPassword.Focus();
                return;
            }
            Program.mlogin = tbLogin.Text.Trim();
            Program.password = tbPassword.Text.Trim();
            Program.servername = cbChiNhanh.SelectedValue.ToString();

            if (Program.KetNoi() == 0) return;


            Program.mChinhanh = cbChiNhanh.SelectedIndex;
            Console.WriteLine(Program.mChinhanh);

            //Program.bds_dspm = get_SubscribesBindingSource;
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

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogin.PerformClick();
            }
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogin.PerformClick();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogin.PerformClick();
            }
        }
    }
}