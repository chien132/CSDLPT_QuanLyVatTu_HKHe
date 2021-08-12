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
    public partial class PhieuNhapSubForm : DevExpress.XtraEditors.XtraForm
    {
        private bool isSuccess = false;
        public PhieuNhapSubForm()
        {
            InitializeComponent();
        }


        private void PhieuNhapSubForm_Load(object sender, EventArgs e)
        {
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            this.phieuNhapBindingSource.DataSource = Program.nhanVienForm.getPhieuNhapBDS();

        }
        private void PhieuNhapSubForm_Shown(object sender, EventArgs e)
        {
            this.phieuNhapBindingSource.AddNew();
            BindingSource tempDDH = Program.nhanVienForm.getDatHangBDS();
            tbMaSoDDH.Text = ((DataRowView)tempDDH[tempDDH.Position])["MasoDDH"].ToString().Trim();
            ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["MANV"] = Program.manv;
            ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["NGAY"] = DateTime.Today;
            ((DataRowView)phieuNhapBindingSource[phieuNhapBindingSource.Position])["MAKHO"] = getDataRow(tempDDH, "MAKHO");

        }
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuNhapSubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSuccess == false) phieuNhapBindingSource.CancelEdit();
            Program.mainForm.Enabled = true;
        }

        private bool checkValidate(TextEdit tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkValidate(mAPNTextEdit, "Mã Phiếu Nhập không được trống!")) return;
            string query = "DECLARE	@result int EXEC @result = SP_CheckID " + mAPNTextEdit.Text + ", MAPN SELECT 'result' = @result";

            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            if (dataReader == null) return;

            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            int positionMaPN = phieuNhapBindingSource.Find("MAPN", mAPNTextEdit.Text);
            int postionCurrent = phieuNhapBindingSource.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
            if (result == 1 && (positionMaPN != postionCurrent))
            {
                MessageBox.Show("Mã Phiếu Nhập đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã Phiếu Nhập đã tồn tại ở Chi Nhánh khác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        this.phieuNhapBindingSource.EndEdit();
                        this.phieuNhapTableAdapter.Update(Program.nhanVienForm.getDataSet().PhieuNhap);
                        isSuccess = true;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private string getDataRow(BindingSource bds, string column)
        {
            return ((DataRowView)bds[bds.Position])[column].ToString().Trim();
        }
    }

}
