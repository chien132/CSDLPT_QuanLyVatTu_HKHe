using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.SubForm
{
    public partial class HDNVPicker : Form
    {
        public HDNVPicker()
        {
            InitializeComponent();
        }

        private void HDNVPicker_Load(object sender, EventArgs e)
        {
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            
            this.cbChiNhanh.DataSource = Program.bds_dspm; //DataSource của cbChiNhanh tham chiếu đến bindingSource ở LoginForm
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";
            Console.WriteLine(cbChiNhanh.SelectedValue);
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (Program.hoatDongNVSubForm != null) 
            {
                Program.hoatDongNVSubForm.tbMANV.Text = ((DataRowView)nhanVienBindingSource.Current)["MANV"].ToString();
            }
            this.Close();
        }

        private void HDNVPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.hoatDongNVSubForm.Enabled = true;
        }
    }
}
