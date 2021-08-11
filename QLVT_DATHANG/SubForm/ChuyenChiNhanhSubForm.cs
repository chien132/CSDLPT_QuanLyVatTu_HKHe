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

namespace QLVT_DATHANG.SubForm
{
    public partial class ChuyenChiNhanhSubForm : DevExpress.XtraEditors.XtraForm
    {
        public ChuyenChiNhanhSubForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           
           // int positionNV = nhanVienBindingSource.Find("MANV", mANVNumericUpDown.Value);
            //int trangthaixoaNV = int.Parse(((DataRowView)nhanVienBindingSource[positionNV])["TrangThaiXoa"].ToString());
            //if (trangthaixoaNV == 1)
            //{
            //    MessageBox.Show("Nhân Viên này đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (mANVNumericUpDown.Value == Program.manv)
            //{
            //    MessageBox.Show("Tài khoản Nhân Viên đang được đăng nhập không thể chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //DialogResult resultDR = MessageBox.Show("Bạn có chắc muốn chuyển nhân viên này?", "Xác nhận",
            //    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (resultDR == DialogResult.OK)
            //{
            //    position = nhanVienBindingSource.Position;
            //    int MANVCurrent = 0;
            //    int MANVNew = 0;
            //    try
            //    {
            //        MANVCurrent = int.Parse(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString());
            //        MANVNew = newMANV();
            //        if (MANVNew == -1) return;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Lỗi khi Parse Int!\n" + ex.Message, "Notification",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    string query = "DECLARE	@result int " +
            //                   "EXEC @result = SP_ChuyenCN @p1, @p2 " +
            //                   "SELECT 'result' = @result";



            //    using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
            //    {
            //        sqlConnection.Open();
            //        SqlCommand sqlCommand1 = new SqlCommand(query, sqlConnection);
            //        sqlCommand1.CommandType = CommandType.Text;
            //        SqlDataReader dataReader = null;

            //        sqlCommand1.Parameters.AddWithValue("@p1", MANVCurrent);
            //        sqlCommand1.Parameters.AddWithValue("@p2", MANVNew);



            //        try
            //        {
            //            dataReader = sqlCommand1.ExecuteReader();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            dataReader.Close();
            //            return;
            //        }
            //        dataReader.Read();
            //        int result = int.Parse(dataReader.GetValue(0).ToString());
            //        dataReader.Close();

            //        if (result == -2)         //Trường hợp 1: Kiểm tra thấy bên chi nhánh kia có ít nhất 1 NV giống nhau về họ tên, ngày sinh
            //        {
            //            Program.maNVChuyenCN = MANVCurrent;
            //            Program.nVTrungIncurredForm = new SubForm.NVTrungIncurredForm();
            //            Program.nVTrungIncurredForm.Show();
            //            Program.mainForm.Enabled = false;
            //        }
            //        else if (result == -1)    //Trường hợp thất bại
            //        {
            //            MessageBox.Show("Chuyển Chi nhánh thất bại! Dữ liệu đã được Roolback!", "Notification",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //        else if (result == -3)
            //        {
            //            MessageBox.Show("Xóa Login không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //        else if (result == -4)
            //        {
            //            MessageBox.Show("Xóa User không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //        else if (result == 0)     //Trường hợp thành công khi bên Chi nhánh kia nhân viên chưa từng chuyển chi nhánh
            //        {
            //            MessageBox.Show("Chuyển chi nhánh thành công. Với Mã Nhân Viên mới là: " + MANVNew, "Notification",
            //                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);  //Cập nhật xong Refresh lại 
            //        nhanVienBindingSource.Position = position;                  //Cho con trỏ chuột về vị trí trước đó

            //    }

            //    }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChuyenChiNhanhSubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainForm.Enabled = true;
            Program.mainForm.Focus();
        }
    }
}