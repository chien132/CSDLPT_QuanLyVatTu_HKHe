using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;

namespace QuanLyVatTu.Report
{
    public partial class ReportDSNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSNhanVien()
        {
            InitializeComponent();
        }

        private void ReportDSNhanVien_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DSNV_TableAdapter.Connection.ConnectionString = Program.connectionString;
            BindingSource bdsCN = Program.bindingSourceChiNhanh;
            lbChiNhanh.Text = (((DataRowView)bdsCN[bdsCN.Position])["description"].ToString());
            DSNV_TableAdapter.Fill(this.QLVTDataSet.SP_DanhSachNhanVien);
        }
    }
}
