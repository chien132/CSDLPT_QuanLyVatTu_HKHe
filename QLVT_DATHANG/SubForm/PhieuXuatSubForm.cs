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
    public partial class PhieuXuatSubForm : DevExpress.XtraEditors.XtraForm
    {
        private bool isSuccess = false;
        public PhieuXuatSubForm()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void PhieuXuatSubForm_Load(object sender, EventArgs e)
        {
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;

            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            //this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);

            this.phieuXuatBindingSource = Program.nhanVienForm.getPhieuXuatBDS();
        }

        private void PhieuXuatSubForm_Shown(object sender, EventArgs e)
        {
            this.phieuXuatBindingSource.AddNew();
            ((DataRowView)phieuXuatBindingSource[phieuXuatBindingSource.Position])["MANV"] = Program.manv;
            ((DataRowView)phieuXuatBindingSource[phieuXuatBindingSource.Position])["NGAY"] = DateTime.Today;
            mAKHOTextEdit.Text = ((DataRowView)khoBindingSource[khoBindingSource.Position])["MAKHO"].ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuXuatSubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSuccess) phieuXuatBindingSource.CancelEdit();
            Program.mainForm.Enabled = true;

        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuXuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mAPXTextEdit.Text = mAPXTextEdit.Text.ToString().Trim();
            hOTENKHTextEdit.Text = hOTENKHTextEdit.Text.ToString().Trim();

            if (!checkValidate(mAPXTextEdit, "Mã Phiếu Xuất không được trống!")) return;
            if (!checkValidate(hOTENKHTextEdit, "Họ tên Khách Hàng không được trống!")) return;
            if (!checkValidate(mAKHOTextEdit, "Mã Kho không được trống!")) return;

            string query = "DECLARE	@result int EXEC @result = SP_CheckID " + mAPXTextEdit.Text + ", MAPX SELECT 'result' = @result";

            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            if (dataReader == null) return;
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            int positionMaPX = phieuXuatBindingSource.Find("MAPX", mAPXTextEdit.Text);
            int postionCurrent = phieuXuatBindingSource.Position;
            //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MAPX đang nhập đúng băng vị trí đang đứng
            if (result == 1 && (positionMaPX != postionCurrent))
            {
                MessageBox.Show("Mã Phiếu Xuất đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (result == 2)
            {
                MessageBox.Show("Mã Phiếu Xuất đã tồn tại ở Chi Nhánh khác!", "Thông báo",
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
                        this.phieuXuatBindingSource.EndEdit();
                        this.phieuXuatTableAdapter.Update(Program.nhanVienForm.getDataSet().PhieuXuat);
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


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (khoBindingSource.Position != -1) //Trường hợp không có dữ liệu
            {
                mAKHOTextEdit.Text = gvKho.GetRowCellValue(khoBindingSource.Position, "MAKHO").ToString().Trim();
            }
        }
    }
}