using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;

namespace QLVT_DATHANG
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
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


        private void FormMain_Load(object sender, EventArgs e)
        {
            string query = "EXEC SP_THONGTINDANGNHAP " + Program.mlogin;

            using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
            {
                SqlDataReader dataReader = null;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                
                try
                {
                     dataReader = sqlCommand.ExecuteReader();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lấy thông tin đăng nhập! \n" + ex.Message, "Notification", MessageBoxButtons.OK);

                }

                //sqlCommand.CommandType = CommandType.Text;
                //sqlCommand.CommandTimeout = 600;      //mặc định 3p cái nay set 10p

                dataReader.Read();
                Program.manv = int.Parse(dataReader.GetValue(0).ToString());
                sslMaNhanVien.Text = "Mã nhân viên: " + Program.manv;
                sslTen.Text = "Họ tên: " + dataReader.GetValue(1).ToString();
                Program.group = dataReader.GetValue(2).ToString();    //Đưa về global cho các subForm
                sslNhom.Text = "Nhóm: " + Program.group;
                dataReader.Close();

                if (Program.group == "USER")
                {
                    ribbonPageGroup10.Visible = false;   //Ẩn nút Tạo tài khoản
                }
                if (Program.group == "CHINHANH" || Program.group == "USER")
                {
                    ribbonPageGroup14.Visible = false;
                }


            }
        }



        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             * Để chặn tắt formMain các cờ subForm phải có ít nhất 1 cái false
             * Và subForm phải có thì mới xử lý trường hợp này (tránh TH vừa login bấm đăng xuất thì vào TH này)
            */
            bool formNV = Program.flagCloseFormNV == false && Program.nhanVienForm != null && Program.nhanVienForm.Visible == true;
            if (formNV)
            {
                e.Cancel = true;
                return;
            }
            LoginForm loginForm1 = new LoginForm();
            loginForm1.Visible= true;
        }


        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }


        private void barbtnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form form = this.CheckExists(typeof(NhanVienForm));
            if (form != null) form.Activate();
            else
            {
                Program.nhanVienForm = new NhanVienForm();
                Program.nhanVienForm.MdiParent = this;
                Program.nhanVienForm.Show();

             
            }
        }

        private void btnVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {

        }


        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnThemTK_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}