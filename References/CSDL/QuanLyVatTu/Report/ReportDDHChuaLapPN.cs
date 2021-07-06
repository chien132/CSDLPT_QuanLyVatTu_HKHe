using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;

namespace QuanLyVatTu.Report
{
    public partial class ReportDDHChuaLapPN : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDDHChuaLapPN()
        {
            InitializeComponent();
        }

        private void ReportDDHChuaLapPN_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DDHChuaLapPNAdapter.Connection.ConnectionString = Program.connectionString;
            BindingSource bdsCN = Program.bindingSourceChiNhanh;
            lbChiNhanh.Text = (((DataRowView)bdsCN[bdsCN.Position])["description"].ToString());
            DDHChuaLapPNAdapter.Fill(this.qlvtDataSet1.SP_DanhSachDDHChuaLapPN);
        }
    }
}
