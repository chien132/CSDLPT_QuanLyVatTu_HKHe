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
using DevExpress.XtraEditors.Events;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;


namespace QLVT_DATHANG
{
    public partial class NhanVienForm : DevExpress.XtraEditors.XtraForm
    {
        private int position;
        private string maCN = "";
        public NhanVienForm()
        {
            InitializeComponent();
        }



        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            this.gb_thongtinNV.Enabled = this.btnLuu.Enabled = this.btnUndo.Enabled = false;

            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            this.cbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            this.cbChiNhanh.DisplayMember = "TENCN";
            this.cbChiNhanh.ValueMember = "TENSERVER";
            this.cbChiNhanh.SelectedIndex = Program.mChinhanh;
            maCN = Program.mChinhanh==0 ? "CN1" : "CN2";
            //this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);

            //Cấu hình chiều cao của các panel
            gb_thongtinNV.Height = 270;
            gbDonDatHang.Height = 350;
            gbPhieuNhap.Height = 350;
            gbPhieuXuat.Height = 350;
            gcNhanVien.Height = 345;

            //Tắt các panel của PhieuNhap - PhieuXuat - DatHang trước
            gbDonDatHang.Visible = gbPhieuNhap.Visible = gbPhieuXuat.Visible = false;
            
            cbChiNhanh.Enabled = false;
            if (Program.group == "CONGTY")
            {
                btnThem.Links[0].Visible = btnXoa.Links[0].Visible = btnLuu.Links[0].Visible = false;
                btnChuyenCN.Links[0].Visible = btnUndo.Links[0].Visible = false;
                cbChiNhanh.Enabled = true;
            }

            else if (Program.group == "USER")
            {
                btnChuyenCN.Links[0].Visible = false;
            }


            this.cbChiNhanh.DataSource = Program.bds_dspm; //DataSource của cbChiNhanh tham chiếu đến bindingSource ở LoginForm
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";

            
            maCNTextEdit.Enabled = false;
        }

        public static int taoMaNVMoi()
        {
            string query = "SELECT *FROM ListMANV";
            SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataReader dataReader = null;
            List<int> list = new List<int>();
            try
            {
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    list.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();

                for (int i = 1; i <= list[list.Count - 1]; i++)
                {
                    if (list.BinarySearch(i) < 0) return i; //Tìm thấy số âm tức số đó chưa tồn tại. Nhận số đó là ID mới
                }
                return list[(list.Count - 1)] + 1;    //Nếu duyệt từ bé đến lớn trong dãy không có MANV mới sẽ +1 lên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm Mã Nhân Viên mới! \n" + ex.Message, "Notification", MessageBoxButtons.OK);
                dataReader.Close();
            }
            return -1;  //Không tìm thấy trả -1 đánh dấu Dừng chương trình
        }


        private bool checkValidate(NumericUpDown nu, string str)
        {
            Console.WriteLine(nu.Value);
            if (nu.Value == 0 && nu.Value.ToString().Trim().Length < 1)
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nu.Focus();
                return false;
            }
            return true;
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

        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
        }

        //Button
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Thông tin", Properties.Resources.business__1_, gb_thongtinNV);
            position = nhanVienBindingSource.Position;
            this.nhanVienBindingSource.AddNew();
            //Giá trị mặc định khi Thêm NV
            maNVNumericUpDown.Value = taoMaNVMoi();
            luongTextEdit.Text = "4000000";
            ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["LUONG"] = 4000000;
            if (cbChiNhanh.Text == "Chi Nhánh 1")
            {
                maCNTextEdit.Text = "CN1";
            }
            else if (cbChiNhanh.Text == "Chi Nhánh 2")
            {
                maCNTextEdit.Text = "CN2";
            }

            maCNTextEdit.Enabled = false;
            trangThaiXoaCheckBox.Checked = trangThaiXoaCheckBox.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = gcNhanVien.Enabled = false;
            btnChuyenCN.Enabled = btnRefresh.Enabled = btnEdit.Enabled = false;
            btnUndo.Enabled = gb_thongtinNV.Enabled = btnLuu.Enabled = true;
            Program.flagCloseFormNV = false;    //Bật cờ lên để chặn tắt Form đột ngột khi nhập liệu
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(maNVNumericUpDown, "Hãy nhập Mã NV!")) return;
            if (!checkValidate(hoTextEdit, "Hãy nhập Họ!")) return;
            if (!checkValidate(tenTextEdit, "Hãy nhập Tên!")) return;
            if (ngaySinhDateEdit.Text.Equals(""))
            {
                MessageBox.Show("Hãy nhập Ngày sinh!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ngaySinhDateEdit.Focus();
                return;
            }
            if (Int32.Parse(luongTextEdit.Text.Replace(",",String.Empty).Replace(".",String.Empty)) < 4000000)
            {
                MessageBox.Show("Lương không được < 4,000,000!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                luongTextEdit.Text = "4000000";
                luongTextEdit.Focus();
                return;
            }

            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_CheckID @p1, @p2 " +
                           "SELECT 'result' = @result";


            SqlDataReader dataReader = null;


            using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand(query, sqlConnection);
                // sqlCommand1.CommandType = CommandType.Text;
                sqlCommand1.Parameters.AddWithValue("@p1", maNVNumericUpDown.Value);
                sqlCommand1.Parameters.AddWithValue("@p2", "MANV");
                try
                {
                    dataReader = sqlCommand1.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                int positionMANV = nhanVienBindingSource.Find("MANV", maNVNumericUpDown.Value);
                int postionCurrent = nhanVienBindingSource.Position;
                //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
                if (result == 1 && (positionMANV != postionCurrent))
                {
                    MessageBox.Show("Mã NV đã tồn tại!", "Thông báo",
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
                            Program.flagCloseFormNV = true; //Bật cờ cho phép tắt Form NV
                            btnThem.Enabled = btnXoa.Enabled = gcNhanVien.Enabled = btnEdit.Enabled = true;
                            btnChuyenCN.Enabled = btnRefresh.Enabled = btnExit.Enabled = true;
                            btnUndo.Enabled = gb_thongtinNV.Enabled = btnLuu.Enabled = false;
                            this.nhanVienBindingSource.EndEdit();
                            this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
                            nhanVienBindingSource.Position = positionMANV;
                            pnThongBao.Visible = true;
                            lbThongBao.Text = "Thêm mới hoặc cập nhật thông tin nhân viên thành công. ";

                            if (maNVNumericUpDown.Value == Program.manv)
                            {
                                Program.mainForm.updateNVDN(hoTextEdit.Text + " " + tenTextEdit.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                            //Khi Update database lỗi thì xóa record vừa thêm trong bds
                            nhanVienBindingSource.RemoveCurrent();
                            MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int positionNV = nhanVienBindingSource.Find("MANV", maNVNumericUpDown.Value);
            int trangthaixoaNV = int.Parse(((DataRowView)nhanVienBindingSource[positionNV])["TrangThaiXoa"].ToString());
            if (trangthaixoaNV == 1)
            {
                MessageBox.Show("Nhân Viên này đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (maNVNumericUpDown.Value == Program.manv)
            {
                MessageBox.Show("Tài khoản Nhân Viên đang được đăng nhập không thể xóa. Vui lòng chọn nhân viên khác!\n", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Int32 manv = 0;
            DialogResult dr1 = MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "Xác nhận",
                                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (dr1 == DialogResult.OK)
            {
                manv = int.Parse(getDataRow(nhanVienBindingSource, "MANV"));
                //Kiểm tra MANV có tồn tại trong các Phiếu
                string query = "DECLARE	@result int " +
                      "EXEC @result = SP_CheckID @p1, @p2 " +
                      "SELECT 'result' = @result";


                SqlDataReader dataReader = null;

                using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand1 = new SqlCommand(query, sqlConnection);
                    sqlCommand1.CommandType = CommandType.Text;



                    sqlCommand1.Parameters.AddWithValue("@p1", manv);
                    sqlCommand1.Parameters.AddWithValue("@p2", "MANV_EXIST");



                    try
                    {
                        dataReader = sqlCommand1.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dataReader.Read();
                    int result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 1)
                    {
                        DialogResult ketqua = MessageBox.Show("Nhân Viên này đã lập các loại Phiếu. Bạn có chắc muốn xóa?", "Xác nhận",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (ketqua == DialogResult.Cancel) return;
                    }

                    //Update trạng thái và xóa login, user(nếu có)
                    query = "DECLARE @result int " +
                          "EXEC @result = SP_XoaNV @p1 " +
                          "SELECT 'result' = @result";
                    //sqlConnection.Open();
                    SqlCommand sqlCommand2 = new SqlCommand(query, sqlConnection);
                    sqlCommand1.CommandType = CommandType.Text;
                    sqlCommand2.Parameters.AddWithValue("@p1", manv);
                    dataReader = null;
                    try
                    {
                        dataReader = sqlCommand2.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
                        nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", manv);
                        return;
                    }
                    dataReader.Read();
                    result = int.Parse(dataReader.GetValue(0).ToString());
                    dataReader.Close();
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa Login không thành công. Vui lòng liên hệ Quản trị viên!", "Thông báo",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("Xóa User không thành công. Vui lòng liên hệ Quản trị viên!", "Thông báo",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (nhanVienBindingSource.Count == 0) btnXoa.Enabled = false;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", manv);
            pnThongBao.Visible = true;
            lbThongBao.Text = "Xoá nhân viên thành công. ";
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
            //if (gbDatHang.Visible || gbPhieuNhap.Visible || gbPhieuXuat.Visible)
            //{
            //    Nếu đăng Nhập các phiếu khi Refresh cho về vị trí Nhân Viên đang đăng nhập
            //    nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
            //}
            pnThongBao.Visible = true;
            lbThongBao.Text = "Làm mới thành công. ";

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnEdit.Enabled = btnExit.Enabled = true;
            btnRefresh.Enabled = btnChuyenCN.Enabled = btnSwitchPanel.Enabled = gcNhanVien.Enabled = true;
            btnUndo.Enabled = btnLuu.Enabled = gb_thongtinNV.Enabled = false;
            Program.flagCloseFormNV = true; //Undo lại thì cho phép thoát mà ko kiểm tra dữ liệu
            nhanVienBindingSource.CancelEdit();
            nhanVienBindingSource.Position = position;
        }


        // CHUYEN CHI NHANH
        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int positionNV = nhanVienBindingSource.Find("MANV", maNVNumericUpDown.Value);
            int trangthaixoaNV = int.Parse(((DataRowView)nhanVienBindingSource[positionNV])["TrangThaiXoa"].ToString());
            if (trangthaixoaNV == 1)
            {
                MessageBox.Show("Nhân Viên này đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (maNVNumericUpDown.Value == Program.manv)
            {
                MessageBox.Show("Tài khoản Nhân Viên đang được đăng nhập không thể chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult resultDR = MessageBox.Show("Bạn có chắc muốn chuyển nhân viên này?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultDR == DialogResult.OK)
            {
                position = nhanVienBindingSource.Position;
                int MANVCurrent = 0;
                int MANVNew = 0;
                try
                {
                    MANVCurrent = int.Parse(((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["MANV"].ToString());
                    MANVNew = taoMaNVMoi();
                    if (MANVNew == -1) return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi Parse Int!\n" + ex.Message, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "DECLARE	@result int " +
                               "EXEC @result = SP_ChuyenCN @p1, @p2 " +
                               "SELECT 'result' = @result";
                SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
                sqlCommand.Parameters.AddWithValue("@p1", MANVCurrent);
                sqlCommand.Parameters.AddWithValue("@p2", MANVNew);
                SqlDataReader dataReader = null;

                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

                try
                {
                    dataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //dataReader.Close();
                    return;
                }
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();

                if (result == -2)         //Trường hợp 1: Kiểm tra thấy bên chi nhánh kia có ít nhất 1 NV giống nhau về họ tên, ngày sinh
                {
                    Program.maNVChuyenCN = MANVCurrent;
                    Program.nVTrungIncurredForm = new SubForm.NVTrungIncurredForm();
                    Program.nVTrungIncurredForm.Show();
                    Program.mainForm.Enabled = false;
                }
                else if (result == -1)    //Trường hợp thất bại
                {
                    MessageBox.Show("Chuyển Chi nhánh thất bại! Dữ liệu đã được Roolback!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == -3)
                {
                    MessageBox.Show("Xóa Login không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == -4)
                {
                    MessageBox.Show("Xóa User không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (result == 0)     //Trường hợp thành công khi bên Chi nhánh kia nhân viên chưa từng chuyển chi nhánh
                {
                    MessageBox.Show("Chuyển chi nhánh thành công. Với Mã Nhân Viên mới là: " + MANVNew, "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);  //Cập nhật xong Refresh lại 
                nhanVienBindingSource.Position = position;                  //Cho con trỏ chuột về vị trí trước đó
            }
        }

        private void btnExit_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }



        private void btnDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Đặt hàng", Properties.Resources.inventory__3_, gbDonDatHang);
            //Đồng thời cho con trỏ chuột về đúng vị trí NV đang login
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
        }


        // SWITCH PANEL
        private void btnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Thông tin", Properties.Resources.business__1_, gb_thongtinNV);
        }


        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Phiếu nhập", Properties.Resources.packing_list, gbPhieuNhap);
            //Đồng thời cho con trỏ chuột về đúng vị trí NV đang login
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switchPanel("Phiếu Xuất", Properties.Resources.export, gbPhieuXuat);
            //Đồng thời cho con trỏ chuột về đúng vị trí NV đang login
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
        }


        private void switchPanel(string caption, Bitmap image, GroupBox groupBox)
        {
            btnSwitchPanel.Links[0].Caption = caption;
            btnSwitchPanel.Links[0].ImageOptions.Image = image;
            gb_thongtinNV.Visible = false;
            gbDonDatHang.Visible = false;
            gbPhieuNhap.Visible = false;
            gbPhieuXuat.Visible = false;
            groupBox.Visible = true;
        }

        //DDH
        private void gvDDH_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (Program.group == "CHINHANH" || Program.group == "USER")
            {
                int maNVLapDDH = 0;
                if (gvDDH.GetRowCellValue(datHangBindingSource.Position, "MANV") != null)
                {
                    maNVLapDDH = int.Parse(gvDDH.GetRowCellValue(datHangBindingSource.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddDDH = createMenuItem("Thêm đơn đặt hàng", Properties.Resources.plus);
                    menuAddDDH.Click += new EventHandler(menuAddDDH_Click);
                    menu.Items.Add(menuAddDDH);

                    if (maNVLapDDH == Program.manv)
                    {
                        DXMenuItem menuAddCTDDH = createMenuItem("Thêm chi tiết ĐĐH", Properties.Resources.inventory__3_);
                        menuAddCTDDH.Click += new EventHandler(menuAddChiTietDDH_Click);
                        menu.Items.Add(menuAddCTDDH);
                    }
                    DXMenuItem menuAddPN = createMenuItem("Thêm Phiếu Nhập", Properties.Resources.packing_list);
                    menuAddPN.Click += new EventHandler(menuAddPN_Click);
                    menu.Items.Add(menuAddPN);
                }
            }
        }

        private void menuAddDDH_Click(object sender, EventArgs e)   //MenuItem của PopupMenu
        {
            Program.dDHSubForm = new SubForm.DDHSubForm();
            Program.dDHSubForm.Show();


            Program.nhanVienForm.Enabled = false;
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
        }


        //CHI TIET DDH

        private void gvCTDDH_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (Program.group == "CHINHANH" || Program.group == "USER")
            {
                if (e.MenuType == GridMenuType.Row && kiemTraCTDDHCuaNV())
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddChiTietDDH = createMenuItem("Thêm chi tiết ĐĐH", Properties.Resources.plus);
                    menuAddChiTietDDH.Click += new EventHandler(menuAddChiTietDDH_Click);
                    menu.Items.Add(menuAddChiTietDDH);
                }
            }
        }

        private void menuAddChiTietDDH_Click(object sender, EventArgs e)//MenuItem của PopupMenu
        {
            Program.cTDDHSubForm = new SubForm.CTDDHSubForm();
            Program.cTDDHSubForm.Show();
            Program.nhanVienForm.Enabled = false;
        }

        private bool kiemTraCTDDHCuaNV()
        {
            int maNVLapDDH = 0;
            if (gvDDH.GetRowCellValue(datHangBindingSource.Position, "MANV") != null)
            {
                maNVLapDDH = int.Parse(gvDDH.GetRowCellValue(datHangBindingSource.Position, "MANV").ToString().Trim());
            }
            return (maNVLapDDH == Program.manv);
        }

        private void menuAddPN_Click(object sender, EventArgs e)
        {
            if (phieuNhapBindingSource.Count > 0)
            {
                MessageBox.Show("Đơn đặt hàng này đã được lập Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.phieuNhapSubForm = new SubForm.PhieuNhapSubForm();
            Program.phieuNhapSubForm.Show();
            Program.mainForm.Enabled = false;
        }



        private DXMenuItem createMenuItem(string caption, Bitmap image)
        {
            DXMenuItem menuItem = new DXMenuItem();
            menuItem.Image = image;
            menuItem.Caption = caption;
            return menuItem;
        }


        //Phieu nhap
        private void gvDatHangByPN_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (Program.group == "CHINHANH" || Program.group == "USER")
            {
                if (datHangBindingSource.Count != 0 && e.Menu != null)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddPN = createMenuItem("Thêm Phiếu Nhập", Properties.Resources.plus);
                    menuAddPN.Click += new EventHandler(menuAddPN_Click);
                    menu.Items.Add(menuAddPN);
                }
            }
        }
        private void gvPhieuNhap_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            {
                int maNVLapPN = 0;
                if (gvPN.GetRowCellValue(phieuNhapBindingSource.Position, "MANV") != null)
                {
                    maNVLapPN = int.Parse(gvPN.GetRowCellValue(phieuNhapBindingSource.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row && maNVLapPN == Program.manv)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddCTPN = createMenuItem("Thêm chi tiết Phiếu Nhập", Properties.Resources.plus);
                    menuAddCTPN.Click += new EventHandler(menuAddCTPN_Click);
                    menu.Items.Add(menuAddCTPN);
                }
            }
        }

        private void menuAddCTPN_Click(object sender, EventArgs e)
        {
            if (cTDDHBindingSource.Count == 0)
            {
                MessageBox.Show("Đơn Đặt hàng của Phiếu Nhập này chưa có Chi Tiết Đơn Đặt Hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cTDDHBindingSource.Count == cTDDHBindingSource.Count)
            {
                MessageBox.Show("Đơn đặt hàng này đã lập đủ Chi Tiết Phiếu Nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.phieuNhapSubForm = new SubForm.PhieuNhapSubForm();
            Program.phieuNhapSubForm.Show();
            Program.nhanVienForm.Enabled = false;
        }

        private void smiAddPN_Click(object sender, EventArgs e)
        {
            Program.phieuNhapSubForm = new SubForm.PhieuNhapSubForm();
            Program.phieuNhapSubForm.Show();
            Program.nhanVienForm.Enabled = false;
        }

        //CT PN
        private void gvCTPN_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (Program.group == "CHINHANH" || Program.group == "USER")
            {
                int maNVLapPN = 0;
                if (gvPN.GetRowCellValue(phieuNhapBindingSource.Position, "MANV") != null)
                {
                    maNVLapPN = int.Parse(gvPN.GetRowCellValue(phieuNhapBindingSource.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row && maNVLapPN == Program.manv)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddCTPN = createMenuItem("Thêm chi tiết Phiếu Nhập", Properties.Resources.plus);
                    menuAddCTPN.Click += new EventHandler(menuAddCTPN_Click);
                    menu.Items.Add(menuAddCTPN);
                }
            }
        }


        private void smiAddCTPN_Click(object sender, EventArgs e)
        {
            if (cTDDHBindingSource.Count == 0)
            {
                MessageBox.Show("Đơn Đặt hàng của Phiếu Nhập này chưa có Chi Tiết Đơn Đặt Hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.cTPNSubForm = new SubForm.CTPNSubForm();
            Program.cTPNSubForm.Show();
            Program.nhanVienForm.Enabled = false;
        }

        //Phieu Xuat

        private void gvPhieuXuat_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (Program.group == "CHINHANH" || Program.group == "USER")
            {
                int maNVLapPX = 0;
                if (gvPX.GetRowCellValue(phieuXuatBindingSource.Position, "MANV") != null)
                {
                    maNVLapPX = int.Parse(gvPX.GetRowCellValue(phieuXuatBindingSource.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddPX = createMenuItem("Thêm Phiếu Xuất", Properties.Resources.plus);
                    menuAddPX.Click += new EventHandler(menuAddPX_Click);
                    menu.Items.Add(menuAddPX);

                    if (maNVLapPX == Program.manv)
                    {
                        DXMenuItem menuAddCTPX = createMenuItem("Thêm chi tiết Phiếu Xuất", Properties.Resources.export);
                        menuAddCTPX.Click += new EventHandler(menuAddCTPX_Click);
                        menu.Items.Add(menuAddCTPX);
                    }
                }
            }
        }


        private void menuAddPX_Click(object sender, EventArgs e)
        {
            Program.phieuXuatSubForm = new SubForm.PhieuXuatSubForm();
            Program.phieuXuatSubForm.Show();
            Program.nhanVienForm.Enabled = false;
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
        }
        private void smiAddPX_Click(object sender, EventArgs e)
        {
            Program.phieuXuatSubForm = new SubForm.PhieuXuatSubForm();
            Program.phieuXuatSubForm.Show();
            Program.nhanVienForm.Enabled = false;
            nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", Program.manv);
        }

        // CHI TIET PHIEU XUAT

        private void gvCTPX_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (Program.group == "CHINHANH" || Program.group == "USER")
            {
                int maNVLapPX = 0;
                if (gvPX.GetRowCellValue(phieuXuatBindingSource.Position, "MANV") != null)
                {
                    maNVLapPX = int.Parse(gvPX.GetRowCellValue(phieuXuatBindingSource.Position, "MANV").ToString().Trim());
                }
                if (e.MenuType == GridMenuType.Row && maNVLapPX == Program.manv)
                {
                    GridViewMenu menu = e.Menu;
                    DXMenuItem menuAddCTPX = createMenuItem("Thêm chi tiết Phiếu Xuất", Properties.Resources.plus);
                    menuAddCTPX.Click += new EventHandler(menuAddCTPX_Click);
                    menu.Items.Add(menuAddCTPX);
                }
            }
        }

        private void menuAddCTPX_Click(object sender, EventArgs e)
        {
            Program.CTPXSubForm = new SubForm.CTPXSubForm();
            Program.CTPXSubForm.Show();
            Program.nhanVienForm.Enabled = false;
        }
        private void smiAddCTPX_Click(object sender, EventArgs e)
        {
            Program.CTPXSubForm = new SubForm.CTPXSubForm();
            Program.CTPXSubForm.Show();
            Program.nhanVienForm.Enabled = false;
        }

        //Getter-Setter các DataSet và BindingSource
        public BindingSource getDatHangBDS()
        {
            return this.datHangBindingSource;
        }
        public BindingSource getCTDatHangBDS()
        {
            return this.cTDDHBindingSource;
        }
        public BindingSource getPhieuNhapBDS()
        {
            return this.phieuNhapBindingSource;
        }
        public BindingSource getCTPhieuNhapBDS()
        {
            return this.cTPNBindingSource;
        }
        public BindingSource getPhieuXuatBDS()
        {
            return this.phieuXuatBindingSource;
        }
        public BindingSource getCTPhieuXuatBDS()
        {
            return this.cTPXBindingSource;
        }
        public QLVT_DATHANGDataSet getDataSet()
        {
            return this.qLVT_DATHANGDataSet;
        }

        private void maNVNumericUpDown_Leave(object sender, EventArgs e)
        {
            if (maNVNumericUpDown.Text == "")
            {
                maNVNumericUpDown.Value = taoMaNVMoi();
                maNVNumericUpDown.Text = maNVNumericUpDown.Value.ToString();
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gb_thongtinNV.Enabled = true;
            position = nhanVienBindingSource.Position;
            btnXoa.Enabled = btnThem.Enabled = btnEdit.Enabled = btnRefresh.Enabled = false;
            btnExit.Enabled = btnChuyenCN.Enabled = btnSwitchPanel.Enabled = gcNhanVien.Enabled = false;
            btnUndo.Enabled = btnLuu.Enabled = true;
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
                        MessageBox.Show("Kết nối Server thất bại! " + ex.Message, "Notification", MessageBoxButtons.OK);
                        return;
                    }

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;

                    this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
                    this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
                    this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
                    this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
                    this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);
                    this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);
                    this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);

                    //Đồng thời cập nhật cho Form Kho nếu thay đổi ConnectionString và Fill lại
                    if (Program.khoForm != null)
                    {

                        Program.khoForm.khoTableAdapter.Connection.ConnectionString = Program.connstr;

                        Program.khoForm.khoTableAdapter.Fill(Program.khoForm.getDataSet().Kho);

                    }
                }
            }
        }
    }
}