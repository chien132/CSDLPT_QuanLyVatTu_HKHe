using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace QLVT_DATHANG
{
    public partial class Xrpt_HoatDongNV : DevExpress.XtraReports.UI.XtraReport
    {
        private int manv;
        private DateTime ngayBD;
        private DateTime ngayKT;
        private String role;
        public Xrpt_HoatDongNV()
        {
            InitializeComponent();
        }

        public Xrpt_HoatDongNV(int manv, DateTime ngayBD, DateTime ngayKT, String role)
        {
            this.manv = manv;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.role = role;
            InitializeComponent();
        }

        private void Xrpt_HoatDongNV_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sP_HoatDongNhanVienTableAdapter1.Connection.ConnectionString = Program.connstr;

            String query = "EXEC SP_HoatDongNhanVien @p1, @p2, @p3, @p4";
            SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", this.manv);
            sqlCommand.Parameters.AddWithValue("@p2", this.ngayBD);
            sqlCommand.Parameters.AddWithValue("@p3", this.ngayKT);
            sqlCommand.Parameters.AddWithValue("@p4", this.role);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            this.DataSource = dataTable;    //Lưu ý DataSource, DataMember, DataAdapter bên Design phải để None

            lbMaNV.Text = SubForm.HoatDongNVSubForm.manv.ToString();
            lbHoTen.Text = SubForm.HoatDongNVSubForm.name;
            lbNgaysinh.Text = DateTime.Parse(SubForm.HoatDongNVSubForm.dateOfBirth).ToString("dd/MM/yyyy");
            lbDiaChi.Text = SubForm.HoatDongNVSubForm.address;
            lbLuong.Text = SubForm.HoatDongNVSubForm.salary.ToString("#,#");
            lbCN.Text = SubForm.HoatDongNVSubForm.macn;
            lbBangKeChungTu.Text = "BẢNG KÊ CHỨNG TỪ PHIẾU ";
            lbBangKeChungTu.Text += (this.role == "NHAP") ? "NHẬP" : "XUẤT";
            tableCell3.Text = (this.role == "NHAP") ? "Mã PN" : "Mã PX";
            lbTuNgay.Text = ngayBD.ToString("dd/MM/yyyy");
            lbDenNgay.Text = ngayKT.ToString("dd/MM/yyyy");
        }
    }
}
