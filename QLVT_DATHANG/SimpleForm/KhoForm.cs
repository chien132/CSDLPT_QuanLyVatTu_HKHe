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
    public partial class KhoForm : DevExpress.XtraEditors.XtraForm
    {
        private int position;
       
        public KhoForm()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

        private void KhoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.ChiNhanh' table. You can move, or remove it, as needed.
            this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);

            if (Program.group == "CONGTY")
            {
                btnThem.Links[0].Visible = btnXoa.Links[0].Visible = btnLuu.Links[0].Visible= btnUndo.Links[0].Visible = false;
            }

            //maCN = (((DataRowView)chiNhanhBindingSource[0])["MACN"].ToString());    //Cập nhật tự động vào label MACN khi tạo mới


            this.cbChiNhanh.DataSource = Program.bds_dspm; //DataSource của cbChiNhanh tham chiếu đến bindingSource ở LoginForm
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";

            //Mặc định vừa vào groupbox không dx hiện để tránh lỗi sửa các dòng cũ chưa lưu đi qua dòng khác
            btnUndo.Enabled  = false;
            Program.flagCloseFormKho = true; //Khi load bật cho phép có thể đóng form
        }


     

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int position = khoBindingSource.Position;
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
            khoBindingSource.Position = position;
            pnThongBao.Visible = true;
            lbThongBao.Text = "Làm mới danh sách kho thành công. ";
        }



        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = khoBindingSource.Position;
            this.khoBindingSource.AddNew();
            if (cbChiNhanh.Text == "CHI NHÁNH 1")
            {
                mACNTextEdit.Text = "CN1";
            }
            else if (cbChiNhanh.Text == "CHI NHÁNH 2")
            {
                mACNTextEdit.Text = "CN2";
            }
            
            btnThem.Enabled = btnXoa.Enabled = khoGridControl.Enabled = false;
            btnRefresh.Enabled  = false;
            btnUndo.Enabled = gbInfor.Enabled = btnLuu.Enabled = true;
            Program.flagCloseFormKho = false;    //Bật cờ lên để chặn tắt Form đột ngột khi nhập liệu
        }

        private void btnThoatKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(mAKHOTextEdit, "Mã Kho is not empty!")) return;
            if (!checkValidate(tENKHOTextEdit, "Tên Kho is not empty!")) return;
            if (!checkValidate(dIACHITextEdit, "Địa chỉ is not empty!")) return;
            if (mAKHOTextEdit.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã KHO không được quá 4 kí tự!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (mAKHOTextEdit.Text.Contains(" "))
            {
                MessageBox.Show("Mã KHO không được chứa khoảng trắng!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";

            using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", mAKHOTextEdit.Text);
                sqlCommand.Parameters.AddWithValue("@p2", "MAKHO");
                SqlDataReader dataReader = null;
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
                int resultMAKHO = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
            

            query = "DECLARE @result int " +
                    "EXEC @result = SP_CheckID @p1, @p2 " +
                    "SELECT 'result' = @result";


            //sqlConnection.Open();

            SqlCommand sqlCommand1 = new SqlCommand(query, sqlConnection);
                sqlCommand1.Parameters.AddWithValue("@p1", tENKHOTextEdit.Text);
                sqlCommand1.Parameters.AddWithValue("@p2", "TENKHO");
                try
                {
                    dataReader = sqlCommand1.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataReader.Read();
                int resultTENKHO = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                int positionMAKHO = khoBindingSource.Find("MAKHO", mAKHOTextEdit.Text);
                int postionTENKHO = khoBindingSource.Find("TENKHO", tENKHOTextEdit.Text);
                int postionCurrent = khoBindingSource.Position;
                //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
                if (resultMAKHO == 1 && (positionMAKHO != postionCurrent))
                {
                    MessageBox.Show("Mã KHO đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultTENKHO == 1 && (postionTENKHO != postionCurrent))
                {
                    MessageBox.Show("Tên Kho đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultMAKHO == 2)
                {
                    MessageBox.Show("Mã KHO đã tồn tại ở Chi Nhánh khác!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultTENKHO == 2)
                {
                    MessageBox.Show("Tên Kho đã tồn tại ở Chi Nhánh khác!", "Thông báo",
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
                            Program.flagCloseFormKho = true; //Bật cờ cho phép tắt Form NV
                            this.khoBindingSource.EndEdit();
                            this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet.Kho);
                            khoBindingSource.Position = position;
                            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = khoGridControl.Enabled = true;
                           pnThongBao.Visible = true;
                            lbThongBao.Text = "Thêm mới hoặc cập nhật thông tin kho thành công. ";
                        }
                        catch (Exception ex)
                        {
                            //Khi Update database lỗi thì xóa record vừa thêm trong bds
                            khoBindingSource.RemoveCurrent();
                            MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string makho = "";
            if (khoBindingSource.Position != -1)
            {
                makho = ((DataRowView)khoBindingSource[khoBindingSource.Position])["MAKHO"].ToString();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    //Kiểm tra MAKHO có tồn tại trong các Phiếu
                    string query = "DECLARE	@result int " +
                          "EXEC @result = SP_CheckID @p1, @p2 " +
                          "SELECT 'result' = @result";

                    using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
                    {
                        sqlConnection.Open();

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@p1", makho);
                        sqlCommand.Parameters.AddWithValue("@p2", "MAKHO_EXIST");
                        SqlDataReader dataReader = null;
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
                            MessageBox.Show("Kho này đã tồn tại trong các Phiếu, không thể xóa. Vui lòng kiểm tra lại!\n", "Notification",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        khoBindingSource.RemoveCurrent();
                        this.khoTableAdapter.Update(this.qLVT_DATHANGDataSet.Kho);
                       
                        pnThongBao.Visible = true;
                        lbThongBao.Text = "Xóa kho thành công. ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Kho ! \n" + ex.Message, "Thông báo lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);
                    khoBindingSource.Position = khoBindingSource.Find("MAKHO", makho);
                    return;
                }
            }
            if (khoBindingSource.Count == 0) btnXoa.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnRefresh.Enabled = btnThem.Enabled = btnXoa.Enabled = khoGridControl.Enabled = true;
           
            Program.flagCloseFormKho = true; //Undo lại thì cho phép thoát mà ko kiểm tra dữ liệu
            khoBindingSource.CancelEdit();
            khoBindingSource.Position = position;
        }
    }
}