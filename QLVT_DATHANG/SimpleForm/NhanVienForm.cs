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
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPX);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTPN);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DS_NHANVIEN.ChiNhanh' table. You can move, or remove it, as needed.
            this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DS_NHANVIEN.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);

            //Cấu hình Default chiều cao của các panel =))
            gb_thongtinNV.Height = 270;
            gbDonDatHang.Height = 350;
            gbPhieuNhap.Height = 350;
            gbPhieuXuat.Height = 350;
            gcNhanVien.Height = 345;
            //Tắt các panel của PhieuNhap - PhieuXuat - DatHang trước
            gbDonDatHang.Visible = gbPhieuNhap.Visible = gbPhieuXuat.Visible = false;

            if (Program.group == "CONGTY")
            {
                btnThem.Links[0].Visible = btnXoa.Links[0].Visible = btnLuu.Links[0].Visible = false;
                btnChuyenCN.Links[0].Visible = btnUndo.Links[0].Visible = false;
            }
      
            else if (Program.group == "USER")
            {
                 btnChuyenCN.Links[0].Visible = false;
            }


            this.cbChiNhanh.DataSource = Program.bds_dspm; //DataSource của cbChiNhanh tham chiếu đến bindingSource ở LoginForm
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";

            cbChiNhanh.Enabled = false;
            mACNTextEdit.Enabled = false;
        }

        public static int newMANV()
        {
            string query = "SELECT MAX(MANV) FROM LINK2.QLVT_DATHANG.DBO.NHANVIEN";

            int maNvNew = 0;


            using (SqlConnection sqlConnection = new SqlConnection(Program.connstr))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                try
                {
                    maNvNew = (Int32)sqlCommand.ExecuteScalar();

                    return maNvNew + 1;    //Nếu duyệt từ bé đến lớn trong dãy không có MANV mới sẽ +1 lên
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm Mã Nhân Viên mới! \n" + ex.Message, "Notification", MessageBoxButtons.OK);

                }
            }

            return -1;  //Không tìm thấy trả -1 đánh dấu Dừng chương trình
        }




        private bool checkValidate(NumericUpDown nu, string str)
        {
            if (nu.Value == 0)
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
            mANVNumericUpDown.Value = newMANV();
            lUONGSpinEdit.Value = 4000000;
            ((DataRowView)nhanVienBindingSource[nhanVienBindingSource.Position])["LUONG"] = 4000000;
            if(cbChiNhanh.Text=="CHI NHÁNH 1")
            {
                mACNTextEdit.Text = "CN1";
            }
           else if (cbChiNhanh.Text == "CHI NHÁNH 2")
            {
                mACNTextEdit.Text = "CN2";
            }

            mACNTextEdit.Enabled = false;
            trangThaiXoaCheckBox.Checked = trangThaiXoaCheckBox.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = gcNhanVien.Enabled = false;
            btnChuyenCN.Enabled = btnRefresh.Enabled = false;
            btnUndo.Enabled = gb_thongtinNV.Enabled = btnLuu.Enabled = true;
            Program.flagCloseFormNV = false;    //Bật cờ lên để chặn tắt Form đột ngột khi nhập liệu
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkValidate(mANVNumericUpDown, "Mã NV is not empty!")) return;
            if (!checkValidate(hOTextEdit, "Họ is not empty!")) return;
            if (!checkValidate(tENTextEdit, "Tên is not empty!")) return;
            if (nGAYSINHDateEdit.Text.Equals(""))
            {
                MessageBox.Show("Ngày sinh is not empty!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nGAYSINHDateEdit.Focus();
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
                sqlCommand1.Parameters.AddWithValue("@p1", mANVNumericUpDown.Value);
                sqlCommand1.Parameters.AddWithValue("@p2", "MANV");
                try
                {
                    Console.WriteLine("1111");
                    dataReader = sqlCommand1.ExecuteReader();
                    Console.WriteLine("2222");

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

                int positionMANV = nhanVienBindingSource.Find("MANV", mANVNumericUpDown.Value);
                int postionCurrent = nhanVienBindingSource.Position;
                //Bỏ qua TH tồn tại ở CN hiện tại khi vị trí MANV đang nhập đúng băng vị trí đang đứng
                if (result == 1 && (positionMANV != postionCurrent))
                {
                    MessageBox.Show("Mã NV đã tồn tại ở Chi Nhánh hiện tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (result == 2)
                {
                    MessageBox.Show("Mã NV đã tồn tại ở Chi Nhánh khác!", "Thông báo",
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
                            btnThem.Enabled = btnXoa.Enabled = gcNhanVien.Enabled = true;
                            btnChuyenCN.Enabled = btnRefresh.Enabled = true;
                            btnUndo.Enabled = gb_thongtinNV.Enabled = btnLuu.Enabled = true;
                            this.nhanVienBindingSource.EndEdit();
                            this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
                            nhanVienBindingSource.Position = positionMANV;
                            pnThongBao.Visible=true;
                            lbThongBao.Text = "Thêm mới hoặc cập nhật thông tin nhân viên thành công. ";
                            
                            //Timer time = new Timer();
                            //time.Start();
                            //if (time.Tick=10)
                            //{
                            //    pnThongBao.Visible = false;
                            //}



                        }
                        catch (Exception ex)
                        {
                            //Khi Update database lỗi thì xóa record vừa thêm trong bds
                            nhanVienBindingSource.RemoveCurrent();
                            MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int positionNV = nhanVienBindingSource.Find("MANV", mANVNumericUpDown.Value);
            int trangthaixoaNV = int.Parse(((DataRowView)nhanVienBindingSource[positionNV])["TrangThaiXoa"].ToString());
            if (trangthaixoaNV == 1)
            {
                MessageBox.Show("Nhân Viên này đã bị xóa hoặc chuyển chi nhánh. Vui lòng chọn nhân viên khác!\n", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (mANVNumericUpDown.Value == Program.manv)
            {
                MessageBox.Show("Tài khoản Nhân Viên đang được đăng nhập không thể xóa. Vui lòng chọn nhân viên khác!\n", "Error",
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
                        MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
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
                        MessageBox.Show("Lỗi khi thực thi Database!\n" + ex.Message, "Notification",
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
                        MessageBox.Show("Xóa Login không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("Xóa User không thành công. Vui lòng liên hệ Quản trị viên!", "Notification",
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
            btnThem.Enabled = btnXoa.Enabled = gcNhanVien.Enabled = btnLuu.Enabled = true;
            btnRefresh.Enabled = btnChuyenCN.Enabled  = btnSwitchPanel.Enabled = true;
            btnUndo.Enabled  = false;
            Program.flagCloseFormNV = true; //Undo lại thì cho phép thoát mà ko kiểm tra dữ liệu
            nhanVienBindingSource.CancelEdit();
            nhanVienBindingSource.Position = position;
        }


        // CHUYEN CHI NHANH
        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.chuyenChiNhanhSubForm = new SubForm.ChuyenChiNhanhSubForm();
            Program.chuyenChiNhanhSubForm.Show();
            Program.nhanVienForm.Enabled = false;


 

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
            Program.frmMain.Enabled = false;
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
                if (datHangBindingSource.Count != 0)
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
    }
}