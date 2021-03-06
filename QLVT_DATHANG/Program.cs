using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;



namespace QLVT_DATHANG
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=MINHCHIENPC;Initial Catalog=QLVT_DATHANG;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";

        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT_DATHANG";
        public static String remotelogin = "htkn";
        public static String remotepassword = "12345";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static string group = "";    //role




        public static bool flagCloseFormNV;
        public static bool flagCloseFormVT;
        public static bool flagCloseFormKho;
        public static bool flagCloseFormTaoTaiKhoan;

        public static int mChinhanh = 0;
        public static int maNVChuyenCN;



        public static frmMain mainForm;
        public static NhanVienForm nhanVienForm;
        public static VatTuForm vatTuForm;
        public static KhoForm khoForm;
        public static ThemTaiKhoanForm themTaiKhoanForm;
        public static LoginForm loginForm;

        public static SubForm.NVTrungIncurredForm nVTrungIncurredForm;
        public static SubForm.DDHSubForm dDHSubForm;
        public static SubForm.CTDDHSubForm cTDDHSubForm;
        public static SubForm.PhieuNhapSubForm phieuNhapSubForm;
        public static SubForm.CTPNSubForm cTPNSubForm;
        public static SubForm.PhieuXuatSubForm phieuXuatSubForm;
        public static SubForm.CTPXSubForm CTPXSubForm;
        public static SubForm.NhanVienSubForm nhanVienSubForm;



        public static int manv = 0;         // lưu lại mã nhân viên

        public static BindingSource bds_dspm = new BindingSource();  // lưu lại danh sách phân mảnh


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); 
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gửi từ RAISERROR trong SQL Server qua
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());

        }
    }
}