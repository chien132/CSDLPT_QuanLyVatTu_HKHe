using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyVatTu.Report
{
    public partial class ReportTongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime ngayBD;
        private DateTime ngayKT;
        public ReportTongHopNhapXuat(DateTime ngayBD, DateTime ngayKT)
        {
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            InitializeComponent();
        }

        private void ReportTongHopNhapXuat_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            THNhapXuatTableAdapter.Connection.ConnectionString = Program.connectionString;

            String query = "EXEC SP_TongHopNhapXuat @p1, @p2";
            SqlCommand sqlCommand = new SqlCommand(query, Program.connection);
            sqlCommand.Parameters.AddWithValue("@p1", this.ngayBD);
            sqlCommand.Parameters.AddWithValue("@p2", this.ngayKT);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            this.DataSource = dataTable;    //Lưu ý DataSource, DataMember, DataAdapter bên Design phải để None

            if (Program.group == "CONGTY")
            {
                lbChiNhanh.Text = "CN1:Hà Nội - CN2:TPHCM";
            }
            else
            {
                BindingSource bdsCN = Program.bindingSourceChiNhanh;
                lbChiNhanh.Text = (((DataRowView)bdsCN[bdsCN.Position])["description"].ToString());
            }
            lbTuNgay.Text = ngayBD.ToString("dd/MM/yyyy");
            lbDenNgay.Text = ngayKT.ToString("dd/MM/yyyy");
        }
    }
}
