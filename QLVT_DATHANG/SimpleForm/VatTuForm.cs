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

namespace QLVT_DATHANG
{
    public partial class VatTuForm : DevExpress.XtraEditors.XtraForm
    {
        private bool dangThem = false;
        private int position;
        public VatTuForm()
        {
            InitializeComponent();
        }



        private void VatTuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.ChiNhanh' table. You can move, or remove it, as needed.

            this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);


            if (Program.group == "CONGTY")
            {
                btnThem.Links[0].Visible = btnXoa.Links[0].Visible = btnLuu.Links[0].Visible = false;
                btnUndo.Links[0].Visible = false;
            }
            //Mặc định vừa vào groupbox không dx hiện để tránh lỗi sửa các dòng cũ chưa lưu đi qua dòng khác
            btnUndo.Enabled = btnLuu.Enabled = false;
            Program.flagCloseFormVT = true; //Khi load bật cho phép có thể đóng form

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





        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            position = vattuBindingSource.Position;
            this.vattuBindingSource.AddNew();
            btnThem.Enabled = btnXoa.Enabled = vattuGridControl.Enabled = false;
            btnRefresh.Enabled = btnSua.Enabled = btnThoat.Enabled = false;
            btnUndo.Enabled = gbChiTietVT.Enabled = btnLuu.Enabled = true;

            Program.flagCloseFormVT = false;    //Bật cờ lên để chặn tắt Form đột ngột khi nhập liệu
                                                //Giá trị mặc định khi Thêm VT
            sOLUONGTONNumericUpDown1.Value = 0;

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnRefresh.Enabled = btnThem.Enabled = btnXoa.Enabled = vattuGridControl.Enabled = true;
            btnSua.Enabled = btnThoat.Enabled = true;
            btnUndo.Enabled = btnLuu.Enabled = gbChiTietVT.Enabled = false;

            Program.flagCloseFormVT = true; //Undo lại thì cho phép thoát mà ko kiểm tra dữ liệu

            if (dangThem == true)
            {
                vattuBindingSource.RemoveCurrent();
                vattuBindingSource.Position = position;
            }
            dangThem = false;
            vattuBindingSource.CancelEdit();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = vattuBindingSource.Position;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            vattuBindingSource.Position = position;
            pnThongBao.Visible = true;
            lbThongBao.Text = "Làm mới danh sách vật tư thành công. ";
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(mAVTTextEdit, "Mã VT is not empty!")) return;
            if (!checkValidate(tENVTTextEdit, "Tên VT is not empty!")) return;
            if (!checkValidate(dVTTextEdit, "Đơn vị tính is not empty!")) return;
            if (mAVTTextEdit.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã VT không được quá 4 kí tự!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (mAVTTextEdit.Text.Contains(" "))
            {
                MessageBox.Show("Mã VT không được chứa khoảng trắng!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int findPositionTENVT = vattuBindingSource.Find("TENVT", tENVTTextEdit.Text);
            if (findPositionTENVT != -1 && (findPositionTENVT != vattuBindingSource.Position))
            {
                MessageBox.Show("Tên Vật tư trùng. Vui lòng chọn tên Vật tư khác!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";

            using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
            {
                sqlConnection.Open();
                SqlDataReader dataReader = null;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", mAVTTextEdit.Text);
                sqlCommand.Parameters.AddWithValue("@p2", "MAVT");

                try
                {
                    dataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                int positionMAVT = vattuBindingSource.Find("MAVT", mAVTTextEdit.Text);
                int postionCurrent = vattuBindingSource.Position;
                //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
                if (result == 1 && (positionMAVT != postionCurrent))
                {
                    MessageBox.Show("Mã VT đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        try
                        {
                            Program.flagCloseFormVT = true; //Bật cờ cho phép tắt Form NV
                            btnThem.Enabled = btnXoa.Enabled = vattuGridControl.Enabled = btnRefresh.Enabled = true;
                            //btnUndo.Enabled = btnLuu.Enabled = false;
                            this.vattuBindingSource.EndEdit();
                            this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet.Vattu);
                            vattuBindingSource.Position = position;

                            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
                            vattuGridControl.Enabled = btnSua.Enabled = btnThoat.Enabled = true;
                            dangThem = btnUndo.Enabled = gbChiTietVT.Enabled = btnLuu.Enabled = false;

                            pnThongBao.Visible = true;
                            lbThongBao.Text = "Thêm mới hoặc cập nhật thông tin nhân viên thành công. ";
                        }
                        catch (Exception ex)
                        {
                            //Khi Update database lỗi thì xóa record vừa thêm trong bds
                            vattuBindingSource.RemoveCurrent();
                            MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mavt = "";
            if (vattuBindingSource.Position != -1)
            {
                mavt = ((DataRowView)vattuBindingSource[vattuBindingSource.Position])["MAVT"].ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa vật tư này?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //Kiểm tra MAVT có tồn tại trong các Phiếu
                    string query = "DECLARE	@result int " +
                          "EXEC @result = SP_CheckID @p1, @p2 " +
                          "SELECT 'result' = @result";

                    using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
                    {

                        SqlDataReader dataReader = null;
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@p1", mavt);
                        sqlCommand.Parameters.AddWithValue("@p2", "MAVT_EXIST");

                        try
                        {
                            dataReader = sqlCommand.ExecuteReader();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        dataReader.Read();
                        int result = int.Parse(dataReader.GetValue(0).ToString());
                        dataReader.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Vật tư này đã tồn tại trong các Phiếu, không thể xóa. Vui lòng kiểm tra lại!\n", "Notification",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        vattuBindingSource.RemoveCurrent();
                        this.vattuTableAdapter.Update(this.qLVT_DATHANGDataSet.Vattu);
                        pnThongBao.Visible = true;
                        lbThongBao.Text = "Xóa vật tư thành công. ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư hãy xóa lại! \n" + ex.Message, "Thông báo lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
                    vattuBindingSource.Position = vattuBindingSource.Find("MAVT", mavt);
                    return;
                }
            }

            if (vattuBindingSource.Count == 0) btnXoa.Enabled = false;

        }


        private void btnThoatVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThem = false;
            this.gbChiTietVT.Enabled = true;
            position = vattuBindingSource.Position;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = btnRefresh.Enabled = btnThoat.Enabled = vattuGridControl.Enabled = false;
            btnUndo.Enabled = btnLuu.Enabled = true;
        }
    }
}