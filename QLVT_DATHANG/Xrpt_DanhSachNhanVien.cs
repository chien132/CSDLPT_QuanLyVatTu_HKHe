using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class Xrpt_DanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void Xrpt_DanhSachNhanVien_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sP_DanhSachNhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;
            BindingSource bdsCN = Program.bds_dspm;
            lbChiNhanh.Text = (((DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString());
            sP_DanhSachNhanVienTableAdapter1.Fill(this.qlvT_DATHANGDataSet1.SP_DanhSachNhanVien);
        }
    }
}
