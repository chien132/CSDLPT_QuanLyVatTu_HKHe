using DevExpress.XtraReports.UI;
using QuanLyVatTu.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyVatTu
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
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
            string query = "EXEC SP_LOGIN " + Program.loginName;
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            //sqlCommand.CommandType = CommandType.Text;
            //sqlCommand.CommandTimeout = 600;      //mặc định 3p cái nay set 10p
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            Program.manv = int.Parse(dataReader.GetValue(0).ToString());
            sslMANV.Text = "Mã NV: " + Program.manv;
            sslTEN.Text = "Họ và tên: " + dataReader.GetValue(1).ToString();
            Program.group = dataReader.GetValue(2).ToString();    //Đưa về global cho các subForm
            sslNHOM.Text = "Nhóm: " + Program.group;
            dataReader.Close();

            if (Program.group == "USER")
            {
                ribbonPageGroup5.Visible = false;   //Ẩn nút Tạo tài khoản
            }
            if(Program.group == "CHINHANH" || Program.group == "USER")
            {
                ribbonPageGroup8.Visible = false;
            }
        }

        private void barbtnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormNhanVien));
            if (form != null) form.Activate();
            else
            {
                Program.formNhanVien = new FormNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }

        }

        private void barbtnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormVatTu));
            if (form != null) form.Activate();
            else
            {
                Program.FormVatTu = new FormVatTu();
                Program.FormVatTu.MdiParent = this;
                Program.FormVatTu.Show();
            }
        }

        private void barbtnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormKho));
            if (form != null) form.Activate();
            else
            {
                Program.FormKho = new FormKho();
                Program.FormKho.MdiParent = this;
                Program.FormKho.Show();
            }
        }

        private void barbtnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (form != null) form.Activate();
            else
            {
                Program.FormTaoTaiKhoan = new FormTaoTaiKhoan();
                Program.FormTaoTaiKhoan.MdiParent = this;
                Program.FormTaoTaiKhoan.Show();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
             * Để chặn tắt formMain các cờ subForm ít nhất phải 1 cái false
             * Và subForm phải có thì mới xử lý trường hợp này (tránh TH vừa login bấm đăng xuất thì vào conditon này)
            */
            bool formNV = Program.flagCloseFormNV == false && Program.formNhanVien != null && Program.formNhanVien.Visible == true;
            bool formVT = Program.flagCloseFormVT == false && Program.FormVatTu != null && Program.FormVatTu.Visible == true;
            bool formKho = Program.flagCloseFormKho == false && Program.FormKho != null && Program.FormKho.Visible == true;
            bool formTaoTaiKhoan = Program.flagCloseFormTaoTaiKhoan == false && Program.FormTaoTaiKhoan != null && Program.FormTaoTaiKhoan.Visible == true;
            if (formNV || formVT || formKho || formTaoTaiKhoan)
            {
                e.Cancel = true;
                return;
            }
            Program.loginForm.Visible = true;
        }

        private void barbtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btDSNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDSNhanVien reportDSNhanVien = new ReportDSNhanVien();
            ReportPrintTool rpt = new ReportPrintTool(reportDSNhanVien);
            reportDSNhanVien.ShowPreviewDialog();
        }

        private void btnDSVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDSVatTu reportDSVatTu = new ReportDSVatTu();
            ReportPrintTool rpt = new ReportPrintTool(reportDSVatTu);
            reportDSVatTu.ShowPreviewDialog();
        }

        private void btnCN1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.loginForm.cbChiNhanh.SelectedIndex = 0;
            btnCN.Caption = "Chi Nhánh - Hà Nội";
            changeConnectionString();
        }

        private void btnCN2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.loginForm.cbChiNhanh.SelectedIndex = 1;
            btnCN.Caption = "Chi Nhánh - TPHCM";
            changeConnectionString();
        }
        private void btnCTNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FormChiTietNhapXuat = new FormChiTietNhapXuat();
            Program.FormChiTietNhapXuat.Show();
            Program.formMain.Enabled = false;
        }

        private void btnDDHChuaLapPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportDDHChuaLapPN reportDDHChuaLapPN = new ReportDDHChuaLapPN();
            ReportPrintTool rpt = new ReportPrintTool(reportDDHChuaLapPN);
            reportDDHChuaLapPN.ShowPreviewDialog();
        }

        private void btnHoatDongNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FormHoatDongNhanVien = new FormHoatDongNhanVien();
            Program.FormHoatDongNhanVien.Show();
            Program.formMain.Enabled = false;
        }

        private void btnTongHopNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FormTongHopNhapXuat = new FormTongHopNhapXuat();
            Program.FormTongHopNhapXuat.Show();
            Program.formMain.Enabled = false;
        }

        private void changeConnectionString()
        {
            if (Program.loginForm.cbChiNhanh.SelectedValue != null && Program.server != Program.loginForm.cbChiNhanh.SelectedValue.ToString()) //Khi enable FormNhanVien thì value = null nên lỗi
            {
                Program.server = Program.loginForm.cbChiNhanh.SelectedValue.ToString();
                if (Program.loginHienTai != Program.remoteLogin) //Why?
                {
                    Program.loginHienTai = Program.remoteLogin;
                    Program.passwordHienTai = Program.remotePassword;
                }
                else
                {
                    Program.loginHienTai = Program.loginName;
                    Program.passwordHienTai = Program.password;
                }
                try
                {
                    Program.connectionString = "Server=" + Program.server + ";"
                                    + "database=QLVT;"
                                    + "User id=" + Program.loginHienTai + ";"
                                    + "Password=" + Program.passwordHienTai;
                    Program.connection = new SqlConnection(Program.connectionString);
                    Program.connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối Server thất bại! " + ex.Message, "Notification", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }    
    }
}
