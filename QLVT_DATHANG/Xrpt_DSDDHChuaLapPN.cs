using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT_DATHANG
{
    public partial class Xrpt_DSDDHChuaLapPN : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSDDHChuaLapPN()
        {
            InitializeComponent();
            this.qlvT_DATHANGDataSet1.EnforceConstraints = false;
        }

        private void Xrpt_DSDDHChuaLapPN_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sP_DanhSachDDHChuaLapPNTableAdapter.Connection.ConnectionString = Program.connstr;
            BindingSource bdsCN = Program.bds_dspm;
            lbChiNhanh.Text = (((DataRowView)bdsCN[bdsCN.Position])["TENCN"].ToString());
            sP_DanhSachDDHChuaLapPNTableAdapter.Fill(this.qlvT_DATHANGDataSet1.SP_DanhSachDDHChuaLapPN);
        }
    }
}
