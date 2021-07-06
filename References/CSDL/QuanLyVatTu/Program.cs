using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using QuanLyVatTu.SubForm;
using QuanLyVatTu.Report;

namespace QuanLyVatTu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        public static string loginName = "";        // login password phần LoginForm
        public static string password = "";     
        public static SqlConnection connection;     //Connection global giúp FormMain sử dụng connection từ LoginForm
        public static FormMain formMain;
        public static FormNhanVien formNhanVien;
        public static FormVatTu FormVatTu;
        public static FormKho FormKho;
        public static FormTaoTaiKhoan FormTaoTaiKhoan;
        public static FormChiTietNhapXuat FormChiTietNhapXuat;
        public static FormHoatDongNhanVien FormHoatDongNhanVien;
        public static FormTongHopNhapXuat FormTongHopNhapXuat;
        public static SubFormNhanVien SubFormNhanVien;
        public static SubFormDDH SubFormDDH;
        public static SubFormCTDDH SubFormCTDDH;
        public static SubFormPhieuNhap SubFormPhieuNhap;
        public static SubFormCTPN SubFormCTPN;
        public static SubFormPhieuXuat SubFormPhieuXuat;
        public static SubFormCTPX SubFormCTPX;
        public static LoginForm loginForm;
        public static PopupFormNVTrung PopupFormNVTrung;
        public static BindingSource bindingSourceChiNhanh;  //Để khi đăng nhập vào biết Login từ Chi nhánh nào
        public static string server = "";
        public static string loginHienTai = "";
        public static string passwordHienTai = "";
        public static string connectionString = "";
        public static string remoteLogin = "HTKN";          //remote Default là vầy. Sử dụng khi đã vào 1 server con 
        public static string remotePassword = "123456";     //và muốn kết nối quá server con khác thông quá HTKN =))
        public static string group = "";    //Để khi vào các form con biết đang ở quyền nào
        public static int manv = 0;         //Để khi vào các form con biết mã nv là gì

        public static int maNVChuyenCN;

        public static bool flagCloseFormNV;
        public static bool flagCloseFormVT;
        public static bool flagCloseFormKho;
        public static bool flagCloseFormTaoTaiKhoan;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            loginForm = new LoginForm();
            Application.Run(loginForm);
        }
    }
}
