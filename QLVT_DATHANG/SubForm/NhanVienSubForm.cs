using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLVT_DATHANG.SubForm
{
    public partial class NhanVienSubForm : DevExpress.XtraEditors.XtraForm
    {
        public NhanVienSubForm()
        {
            InitializeComponent();
        }

        private void NhanVienSubForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DSNVChuaCoTK' table. You can move, or remove it, as needed.
            this.dSNVChuaCoTKTableAdapter.Fill(this.qLVT_DATHANGDataSet.DSNVChuaCoTK);
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            //if (Program.mGroup == "CHINHANH" || Program.group == "USER")
            //{
                cbChiNhanh.Visible = false;
                label1.Visible = false;
            //}
            /*
             * Trước khi đổ dữ liệu cần cập nhập Connection của Adapter điều này xảy ra khi
             * Trường hợp này xảy ra khi đăng nhập từ 1 Nhân viên ở CN2 và cần GrowTable dữ liệu cũng của CN2
            */
            this.dSNVChuaCoTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNVChuaCoTKTableAdapter.Fill(this.qLVT_DATHANGDataSet.DSNVChuaCoTK);
            this.cbChiNhanh.DataSource = Program.bds_dspm; //DataSource của cbChiNhanh tham chiếu đến bindingSource ở LoginForm
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            Console.WriteLine(cbChiNhanh.SelectedValue);

        }



        private void NhanVienSubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainForm.Enabled = true;
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbChiNhanh.ValueMember != "")   //Xử lý trường hợp Event autorun khi vừa khởi chạy project
            {
                if (this.cbChiNhanh.SelectedValue != null && Program.servername != this.cbChiNhanh.SelectedValue.ToString()) //Khi enable FormNhanVien thì value = null nên lỗi
                {
                    Program.servername = this.cbChiNhanh.SelectedValue.ToString();
                    if (Program.mloginDN != Program.remotelogin) //Why?
                    {
                        Program.mloginDN = Program.remotelogin;
                        Program.passwordDN = Program.remotepassword;
                    }
                    else
                    {
                        Program.mloginDN = Program.mlogin;
                        Program.passwordDN = Program.password;
                    }
                    try
                    {
                        Program.connstr = "Server=" + Program.servername + ";"
                                        + "database=QLVT_DATHANG;"
                                        + "User id=" + Program.mloginDN + ";"
                                        + "Password=" + Program.passwordDN;
                        Program.conn = new SqlConnection(Program.connstr);
                        Program.conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kết nối Server thất bại! " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    this.dSNVChuaCoTKTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSNVChuaCoTKTableAdapter.Fill(this.qLVT_DATHANGDataSet.DSNVChuaCoTK);
                }
            }
        }

        private void nhanVienGridControl_DoubleClick(object sender, EventArgs e)
        {
            confirm();
        }

        private void confirm()
        {
            if (Program.themTaiKhoanForm != null)    //Thỏa điều kiện Form Tạo TK đang mở => có đối tượng => mới set được value
            {
                Program.themTaiKhoanForm.tbNhanVien.Text = ((DataRowView)dSNVChuaCoTKBindingSource.Current)["MANV"].ToString();
            }

            //if (Program.FormHoatDongNhanVien != null) //Thỏa điều kiện Form Báo cáo Hoạt động NV đang mở => có đối tượng => mới set được value
            //{
            //    Program.FormHoatDongNhanVien.tbMANV.Text = ((DataRowView)nhanVienBindingSource.Current)["MANV"].ToString();
            //}
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            confirm();

        }

        private void dSNVChuaCoTKGridControl_DoubleClick(object sender, EventArgs e)
        {
            confirm();
        }
    }
}