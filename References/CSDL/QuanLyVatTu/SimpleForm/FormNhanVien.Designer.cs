namespace QuanLyVatTu
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnSwitch = new DevExpress.XtraBars.BarSubItem();
            this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelChiNhanh = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qLVTDataSet = new QuanLyVatTu.QLVTDataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.mANVNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lUONGNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.lbInfor = new System.Windows.Forms.Label();
            this.mACNTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.phieuXuatBDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.PhieuXuatTableAdapter();
            this.datHangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu3 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.phieuNhapTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            this.cTPNTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.CTPNTableAdapter();
            this.gbDatHang = new System.Windows.Forms.GroupBox();
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            this.chiTietDDH_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDDH = new DevExpress.XtraGrid.GridControl();
            this.gvDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmsDDH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiAddDDH = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPhieuNhap = new System.Windows.Forms.GroupBox();
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.chiTietPN_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapBDS = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatHangByPN = new DevExpress.XtraGrid.GridControl();
            this.gvDatHangByPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbPhieuXuat = new System.Windows.Forms.GroupBox();
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.chiTietPX_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTDDHTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.CTDDHTableAdapter();
            this.cTPXTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.CTPXTableAdapter();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.cmsCTDDH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiAddCTDDH = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiAddPN = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCTPN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiAddCTPN = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPX = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiAddPX = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCTPX = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.smiAddCTPX = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiNhanhBDS = new System.Windows.Forms.BindingSource(this.components);
            this.chiNhanhTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.ChiNhanhTableAdapter();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panelChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.gbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).BeginInit();
            this.gbDatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDDH_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDDH)).BeginInit();
            this.cmsDDH.SuspendLayout();
            this.gbPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPN_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHangByPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatHangByPN)).BeginInit();
            this.gbPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPX_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.cmsCTDDH.SuspendLayout();
            this.cmsPN.SuspendLayout();
            this.cmsCTPN.SuspendLayout();
            this.cmsPX.SuspendLayout();
            this.cmsCTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            mANVLabel.Location = new System.Drawing.Point(183, 44);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            hOLabel.Location = new System.Drawing.Point(354, 44);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(24, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            tENLabel.Location = new System.Drawing.Point(504, 44);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(29, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            nGAYSINHLabel.Location = new System.Drawing.Point(166, 75);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(58, 13);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            lUONGLabel.Location = new System.Drawing.Point(488, 72);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(41, 13);
            lUONGLabel.TabIndex = 8;
            lUONGLabel.Text = "Lương:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dIACHILabel.Location = new System.Drawing.Point(181, 102);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            mACNLabel.Location = new System.Drawing.Point(183, 137);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(42, 13);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Mã CN:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnSave,
            this.btnRefresh,
            this.btnDelete,
            this.btnUndo,
            this.btnChuyenCN,
            this.btnLogout,
            this.btnEdit,
            this.btnSwitch,
            this.btnInfo,
            this.btnDatHang,
            this.btnPhieuNhap,
            this.btnPhieuXuat,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 41;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSwitch, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChuyenCN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLogout, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnAdd.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnAdd.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnDelete.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDelete.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 7;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnEdit.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnEdit.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnEdit.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEdit.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnEdit.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnSave.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnSave.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnSave.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSave.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnSave.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUndo.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnUndo.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnUndo.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnUndo.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUndo.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUndo.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUndo.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnUndo.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnUndo.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 2;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnRefresh.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnRefresh.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnRefresh.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRefresh.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnRefresh.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnRefresh.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Caption = "Loại Phiếu";
            this.btnSwitch.Id = 35;
            this.btnSwitch.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.table_32;
            this.btnSwitch.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSwitch.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnSwitch.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnSwitch.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnSwitch.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSwitch.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSwitch.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSwitch.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnSwitch.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnSwitch.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnSwitch.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDatHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhieuNhap),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhieuXuat)});
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(120, 0);
            // 
            // btnInfo
            // 
            this.btnInfo.Caption = "Thông tin";
            this.btnInfo.Id = 36;
            this.btnInfo.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.info_user_24;
            this.btnInfo.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnInfo.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnInfo.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnInfo.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ItemAppearance.Normal.Options.UseFont = true;
            this.btnInfo.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnInfo.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnInfo.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfo_ItemClick);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Caption = "Đặt Hàng";
            this.btnDatHang.Id = 37;
            this.btnDatHang.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.order_24;
            this.btnDatHang.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDatHang.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnDatHang.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDatHang.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnDatHang.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDatHang.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDatHang.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDatHang.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnDatHang.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDatHang.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatHang_ItemClick);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Caption = "Phiếu Nhập";
            this.btnPhieuNhap.Id = 38;
            this.btnPhieuNhap.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.import_24;
            this.btnPhieuNhap.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPhieuNhap.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnPhieuNhap.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPhieuNhap.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnPhieuNhap.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPhieuNhap.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPhieuNhap.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPhieuNhap.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnPhieuNhap.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnPhieuNhap.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuNhap_ItemClick);
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Caption = "Phiếu Xuất";
            this.btnPhieuXuat.Id = 39;
            this.btnPhieuXuat.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.export_24;
            this.btnPhieuXuat.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPhieuXuat.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnPhieuXuat.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnPhieuXuat.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnPhieuXuat.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPhieuXuat.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPhieuXuat.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPhieuXuat.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnPhieuXuat.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnPhieuXuat.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuXuat_ItemClick);
            // 
            // btnChuyenCN
            // 
            this.btnChuyenCN.Caption = "Chuyển CN";
            this.btnChuyenCN.Id = 5;
            this.btnChuyenCN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenCN.ImageOptions.Image")));
            this.btnChuyenCN.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChuyenCN.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnChuyenCN.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnChuyenCN.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnChuyenCN.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChuyenCN.ItemAppearance.Normal.Options.UseFont = true;
            this.btnChuyenCN.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChuyenCN.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnChuyenCN.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnChuyenCN.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnChuyenCN.Name = "btnChuyenCN";
            this.btnChuyenCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChuyenCN_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Exit";
            this.btnLogout.Id = 6;
            this.btnLogout.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.turn_off_32;
            this.btnLogout.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnLogout.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.btnLogout.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ItemAppearance.Normal.Options.UseFont = true;
            this.btnLogout.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.btnLogout.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnLogout.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1392, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 864);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1392, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 824);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1392, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 824);
            // 
            // panelChiNhanh
            // 
            this.panelChiNhanh.Controls.Add(this.cbChiNhanh);
            this.panelChiNhanh.Controls.Add(this.label1);
            this.panelChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChiNhanh.Location = new System.Drawing.Point(0, 40);
            this.panelChiNhanh.Name = "panelChiNhanh";
            this.panelChiNhanh.Size = new System.Drawing.Size(1392, 38);
            this.panelChiNhanh.TabIndex = 4;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(73, 9);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(173, 21);
            this.cbChiNhanh.TabIndex = 1;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLVTDataSet;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.nhanVienBindingSource;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 78);
            this.nhanVienGridControl.MainView = this.gvNhanVien;
            this.nhanVienGridControl.MenuManager = this.barManager1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1392, 206);
            this.nhanVienGridControl.TabIndex = 6;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien,
            this.gridView1,
            this.gridView2});
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gvNhanVien.GridControl = this.nhanVienGridControl;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsBehavior.Editable = false;
            this.gvNhanVien.OptionsDetail.SmartDetailHeight = true;
            this.gvNhanVien.OptionsView.ShowGroupPanel = false;
            this.gvNhanVien.OptionsView.ShowViewCaption = true;
            this.gvNhanVien.ViewCaption = "Nhân Viên";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.DisplayFormat.FormatString = "N0";
            this.colLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.Caption = "Trạng thái xóa";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.nhanVienGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(this.mANVNumericUpDown);
            this.gbInfor.Controls.Add(this.lUONGNumericUpDown);
            this.gbInfor.Controls.Add(this.nGAYSINHDateEdit);
            this.gbInfor.Controls.Add(this.trangThaiXoaCheckBox);
            this.gbInfor.Controls.Add(this.lbInfor);
            this.gbInfor.Controls.Add(mACNLabel);
            this.gbInfor.Controls.Add(this.mACNTextBox);
            this.gbInfor.Controls.Add(dIACHILabel);
            this.gbInfor.Controls.Add(this.dIACHITextBox);
            this.gbInfor.Controls.Add(lUONGLabel);
            this.gbInfor.Controls.Add(nGAYSINHLabel);
            this.gbInfor.Controls.Add(tENLabel);
            this.gbInfor.Controls.Add(this.tENTextBox);
            this.gbInfor.Controls.Add(hOLabel);
            this.gbInfor.Controls.Add(this.hOTextBox);
            this.gbInfor.Controls.Add(mANVLabel);
            this.gbInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbInfor.Location = new System.Drawing.Point(0, 284);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Size = new System.Drawing.Size(1392, 175);
            this.gbInfor.TabIndex = 11;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Thông tin Nhân Viên";
            // 
            // mANVNumericUpDown
            // 
            this.mANVNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "MANV", true));
            this.mANVNumericUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mANVNumericUpDown.Location = new System.Drawing.Point(228, 41);
            this.mANVNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.mANVNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mANVNumericUpDown.Name = "mANVNumericUpDown";
            this.mANVNumericUpDown.Size = new System.Drawing.Size(110, 21);
            this.mANVNumericUpDown.TabIndex = 1;
            this.mANVNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lUONGNumericUpDown
            // 
            this.lUONGNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "LUONG", true));
            this.lUONGNumericUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lUONGNumericUpDown.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.lUONGNumericUpDown.Location = new System.Drawing.Point(539, 68);
            this.lUONGNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.lUONGNumericUpDown.Minimum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.lUONGNumericUpDown.Name = "lUONGNumericUpDown";
            this.lUONGNumericUpDown.Size = new System.Drawing.Size(128, 21);
            this.lUONGNumericUpDown.TabIndex = 5;
            this.lUONGNumericUpDown.ThousandsSeparator = true;
            this.lUONGNumericUpDown.Value = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateEdit.EditValue = new System.DateTime(2020, 12, 4, 0, 0, 0, 0);
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(228, 71);
            this.nGAYSINHDateEdit.MenuManager = this.barManager1;
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.nGAYSINHDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.nGAYSINHDateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.nGAYSINHDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.nGAYSINHDateEdit.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(200, 20);
            this.nGAYSINHDateEdit.TabIndex = 4;
            // 
            // trangThaiXoaCheckBox
            // 
            this.trangThaiXoaCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.nhanVienBindingSource, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(567, 129);
            this.trangThaiXoaCheckBox.Name = "trangThaiXoaCheckBox";
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.trangThaiXoaCheckBox.TabIndex = 18;
            this.trangThaiXoaCheckBox.Text = "Trạng thái xóa";
            this.trangThaiXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // lbInfor
            // 
            this.lbInfor.AutoSize = true;
            this.lbInfor.Image = global::QuanLyVatTu.Properties.Resources.img_user_961;
            this.lbInfor.Location = new System.Drawing.Point(32, 22);
            this.lbInfor.MinimumSize = new System.Drawing.Size(128, 128);
            this.lbInfor.Name = "lbInfor";
            this.lbInfor.Size = new System.Drawing.Size(128, 128);
            this.lbInfor.TabIndex = 17;
            // 
            // mACNTextBox
            // 
            this.mACNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MACN", true));
            this.mACNTextBox.Enabled = false;
            this.mACNTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.mACNTextBox.Location = new System.Drawing.Point(228, 134);
            this.mACNTextBox.Name = "mACNTextBox";
            this.mACNTextBox.Size = new System.Drawing.Size(100, 21);
            this.mACNTextBox.TabIndex = 13;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DIACHI", true));
            this.dIACHITextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dIACHITextBox.Location = new System.Drawing.Point(228, 99);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(439, 21);
            this.dIACHITextBox.TabIndex = 6;
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TEN", true));
            this.tENTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tENTextBox.Location = new System.Drawing.Point(539, 41);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.Size = new System.Drawing.Size(128, 21);
            this.tENTextBox.TabIndex = 3;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "HO", true));
            this.hOTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.hOTextBox.Location = new System.Drawing.Point(386, 41);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(100, 21);
            this.hOTextBox.TabIndex = 2;
            // 
            // phieuXuatBDS
            // 
            this.phieuXuatBDS.DataMember = "FK_PX_NhanVien";
            this.phieuXuatBDS.DataSource = this.nhanVienBindingSource;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // datHangBDS
            // 
            this.datHangBDS.DataMember = "FK_DatHang_NhanVien";
            this.datHangBDS.DataSource = this.nhanVienBindingSource;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // popupMenu2
            // 
            this.popupMenu2.Manager = this.barManager1;
            this.popupMenu2.Name = "popupMenu2";
            // 
            // popupMenu3
            // 
            this.popupMenu3.Manager = this.barManager1;
            this.popupMenu3.Name = "popupMenu3";
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // gbDatHang
            // 
            this.gbDatHang.Controls.Add(this.gcCTDDH);
            this.gbDatHang.Controls.Add(this.gcDDH);
            this.gbDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatHang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbDatHang.Location = new System.Drawing.Point(0, 459);
            this.gbDatHang.Name = "gbDatHang";
            this.gbDatHang.Size = new System.Drawing.Size(1392, 100);
            this.gbDatHang.TabIndex = 25;
            this.gbDatHang.TabStop = false;
            this.gbDatHang.Text = "Danh sách Đơn Đặt Hàng";
            this.gbDatHang.Visible = false;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.chiTietDDH_BDS;
            this.gcCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTDDH.Location = new System.Drawing.Point(757, 17);
            this.gcCTDDH.MainView = this.gvCTDDH;
            this.gcCTDDH.MenuManager = this.barManager1;
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(632, 80);
            this.gcCTDDH.TabIndex = 1;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            this.gcCTDDH.MouseHover += new System.EventHandler(this.gcCTDDH_MouseHover);
            // 
            // chiTietDDH_BDS
            // 
            this.chiTietDDH_BDS.DataMember = "FK_CTDDH_DatHang";
            this.chiTietDDH_BDS.DataSource = this.datHangBDS;
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.GridControl = this.gcCTDDH;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Chi Tiết Đơn Đặt Hàng";
            this.gvCTDDH.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvCTDDH_PopupMenuShowing);
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.Caption = "Mã số DDH";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.DisplayFormat.FormatString = "N0";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // gcDDH
            // 
            this.gcDDH.DataSource = this.datHangBDS;
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcDDH.Location = new System.Drawing.Point(3, 17);
            this.gcDDH.MainView = this.gvDDH;
            this.gcDDH.MenuManager = this.barManager1;
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(754, 80);
            this.gcDDH.TabIndex = 0;
            this.gcDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDDH});
            this.gcDDH.MouseHover += new System.EventHandler(this.gcDDH_MouseHover);
            // 
            // gvDDH
            // 
            this.gvDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV1,
            this.colMAKHO});
            this.gvDDH.GridControl = this.gcDDH;
            this.gvDDH.Name = "gvDDH";
            this.gvDDH.OptionsBehavior.Editable = false;
            this.gvDDH.OptionsView.ShowGroupPanel = false;
            this.gvDDH.OptionsView.ShowViewCaption = true;
            this.gvDDH.ViewCaption = "Đơn Đặt Hàng";
            this.gvDDH.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvDDH_PopupMenuShowing);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số DDH";
            this.colMasoDDH.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colMasoDDH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày lập";
            this.colNGAY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = " Nhà cung cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            // 
            // colMANV1
            // 
            this.colMANV1.Caption = "Mã NV";
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // cmsDDH
            // 
            this.cmsDDH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddDDH});
            this.cmsDDH.Name = "cmsDDH";
            this.cmsDDH.Size = new System.Drawing.Size(133, 26);
            // 
            // smiAddDDH
            // 
            this.smiAddDDH.Image = global::QuanLyVatTu.Properties.Resources.add_16;
            this.smiAddDDH.Name = "smiAddDDH";
            this.smiAddDDH.Size = new System.Drawing.Size(132, 22);
            this.smiAddDDH.Text = "Thêm DDH";
            this.smiAddDDH.Click += new System.EventHandler(this.smiAddDDH_Click);
            // 
            // gbPhieuNhap
            // 
            this.gbPhieuNhap.Controls.Add(this.gcCTPN);
            this.gbPhieuNhap.Controls.Add(this.gcPhieuNhap);
            this.gbPhieuNhap.Controls.Add(this.gcDatHangByPN);
            this.gbPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPhieuNhap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbPhieuNhap.Location = new System.Drawing.Point(0, 559);
            this.gbPhieuNhap.Name = "gbPhieuNhap";
            this.gbPhieuNhap.Size = new System.Drawing.Size(1392, 105);
            this.gbPhieuNhap.TabIndex = 26;
            this.gbPhieuNhap.TabStop = false;
            this.gbPhieuNhap.Text = "Danh sách Phiếu Nhập";
            this.gbPhieuNhap.Visible = false;
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.chiTietPN_BDS;
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPN.Location = new System.Drawing.Point(757, 17);
            this.gcCTPN.MainView = this.gvCTPN;
            this.gcCTPN.MenuManager = this.barManager1;
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.Size = new System.Drawing.Size(632, 85);
            this.gcCTPN.TabIndex = 3;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPN});
            this.gcCTPN.MouseHover += new System.EventHandler(this.gcCTPN_MouseHover);
            // 
            // chiTietPN_BDS
            // 
            this.chiTietPN_BDS.DataMember = "FK_CTPN_PhieuNhap";
            this.chiTietPN_BDS.DataSource = this.phieuNhapBDS;
            // 
            // phieuNhapBDS
            // 
            this.phieuNhapBDS.DataMember = "FK_PhieuNhap_DatHang";
            this.phieuNhapBDS.DataSource = this.datHangBDS;
            // 
            // gvCTPN
            // 
            this.gvCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT1,
            this.colSOLUONG1,
            this.colDONGIA1});
            this.gvCTPN.GridControl = this.gcCTPN;
            this.gvCTPN.Name = "gvCTPN";
            this.gvCTPN.OptionsBehavior.Editable = false;
            this.gvCTPN.OptionsView.ShowGroupPanel = false;
            this.gvCTPN.OptionsView.ShowViewCaption = true;
            this.gvCTPN.ViewCaption = "Chi Tiết Phiếu Nhập";
            this.gvCTPN.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvCTPN_PopupMenuShowing);
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "Mã Phiếu Nhập";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            // 
            // colMAVT1
            // 
            this.colMAVT1.Caption = "Mã VT";
            this.colMAVT1.FieldName = "MAVT";
            this.colMAVT1.Name = "colMAVT1";
            this.colMAVT1.Visible = true;
            this.colMAVT1.VisibleIndex = 1;
            // 
            // colSOLUONG1
            // 
            this.colSOLUONG1.Caption = "Số lượng";
            this.colSOLUONG1.FieldName = "SOLUONG";
            this.colSOLUONG1.Name = "colSOLUONG1";
            this.colSOLUONG1.Visible = true;
            this.colSOLUONG1.VisibleIndex = 2;
            // 
            // colDONGIA1
            // 
            this.colDONGIA1.Caption = "Đơn giá";
            this.colDONGIA1.DisplayFormat.FormatString = "N0";
            this.colDONGIA1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA1.FieldName = "DONGIA";
            this.colDONGIA1.Name = "colDONGIA1";
            this.colDONGIA1.Visible = true;
            this.colDONGIA1.VisibleIndex = 3;
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.DataSource = this.phieuNhapBDS;
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcPhieuNhap.Location = new System.Drawing.Point(135, 17);
            this.gcPhieuNhap.MainView = this.gvPhieuNhap;
            this.gcPhieuNhap.MenuManager = this.barManager1;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(622, 85);
            this.gcPhieuNhap.TabIndex = 3;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuNhap});
            this.gcPhieuNhap.MouseHover += new System.EventHandler(this.gcPhieuNhap_MouseHover);
            // 
            // gvPhieuNhap
            // 
            this.gvPhieuNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY2,
            this.colMasoDDH3,
            this.colMANV3});
            this.gvPhieuNhap.GridControl = this.gcPhieuNhap;
            this.gvPhieuNhap.Name = "gvPhieuNhap";
            this.gvPhieuNhap.OptionsBehavior.Editable = false;
            this.gvPhieuNhap.OptionsView.ShowGroupPanel = false;
            this.gvPhieuNhap.OptionsView.ShowViewCaption = true;
            this.gvPhieuNhap.ViewCaption = "Phiếu Nhập";
            this.gvPhieuNhap.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvPhieuNhap_PopupMenuShowing);
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã Phiếu Nhập";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            // 
            // colNGAY2
            // 
            this.colNGAY2.Caption = "Ngày cập nhật";
            this.colNGAY2.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY2.FieldName = "NGAY";
            this.colNGAY2.Name = "colNGAY2";
            this.colNGAY2.Visible = true;
            this.colNGAY2.VisibleIndex = 1;
            // 
            // colMasoDDH3
            // 
            this.colMasoDDH3.Caption = "Mã số DDH";
            this.colMasoDDH3.FieldName = "MasoDDH";
            this.colMasoDDH3.Name = "colMasoDDH3";
            this.colMasoDDH3.Visible = true;
            this.colMasoDDH3.VisibleIndex = 2;
            // 
            // colMANV3
            // 
            this.colMANV3.Caption = "Mã NV";
            this.colMANV3.FieldName = "MANV";
            this.colMANV3.Name = "colMANV3";
            this.colMANV3.Visible = true;
            this.colMANV3.VisibleIndex = 3;
            // 
            // gcDatHangByPN
            // 
            this.gcDatHangByPN.DataSource = this.datHangBDS;
            this.gcDatHangByPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcDatHangByPN.Location = new System.Drawing.Point(3, 17);
            this.gcDatHangByPN.MainView = this.gvDatHangByPN;
            this.gcDatHangByPN.MenuManager = this.barManager1;
            this.gcDatHangByPN.Name = "gcDatHangByPN";
            this.gcDatHangByPN.Size = new System.Drawing.Size(132, 85);
            this.gcDatHangByPN.TabIndex = 3;
            this.gcDatHangByPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDatHangByPN});
            // 
            // gvDatHangByPN
            // 
            this.gvDatHangByPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH2,
            this.colNGAY1,
            this.colNhaCC1,
            this.colMANV2,
            this.colMAKHO1});
            this.gvDatHangByPN.GridControl = this.gcDatHangByPN;
            this.gvDatHangByPN.Name = "gvDatHangByPN";
            this.gvDatHangByPN.OptionsBehavior.Editable = false;
            this.gvDatHangByPN.OptionsView.ShowGroupPanel = false;
            this.gvDatHangByPN.OptionsView.ShowViewCaption = true;
            this.gvDatHangByPN.ViewCaption = "Đơn Đặt Hàng";
            this.gvDatHangByPN.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvDatHangByPN_PopupMenuShowing);
            // 
            // colMasoDDH2
            // 
            this.colMasoDDH2.Caption = "Mã số DDH";
            this.colMasoDDH2.FieldName = "MasoDDH";
            this.colMasoDDH2.Name = "colMasoDDH2";
            this.colMasoDDH2.Visible = true;
            this.colMasoDDH2.VisibleIndex = 0;
            // 
            // colNGAY1
            // 
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.Name = "colNGAY1";
            // 
            // colNhaCC1
            // 
            this.colNhaCC1.FieldName = "NhaCC";
            this.colNhaCC1.Name = "colNhaCC1";
            // 
            // colMANV2
            // 
            this.colMANV2.FieldName = "MANV";
            this.colMANV2.Name = "colMANV2";
            // 
            // colMAKHO1
            // 
            this.colMAKHO1.FieldName = "MAKHO";
            this.colMAKHO1.Name = "colMAKHO1";
            // 
            // gbPhieuXuat
            // 
            this.gbPhieuXuat.Controls.Add(this.gcCTPX);
            this.gbPhieuXuat.Controls.Add(this.gcPhieuXuat);
            this.gbPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPhieuXuat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbPhieuXuat.Location = new System.Drawing.Point(0, 664);
            this.gbPhieuXuat.Name = "gbPhieuXuat";
            this.gbPhieuXuat.Size = new System.Drawing.Size(1392, 200);
            this.gbPhieuXuat.TabIndex = 27;
            this.gbPhieuXuat.TabStop = false;
            this.gbPhieuXuat.Text = "Danh sách Phiếu Xuất";
            this.gbPhieuXuat.Visible = false;
            this.gbPhieuXuat.Enter += new System.EventHandler(this.gbPhieuXuat_Enter);
            // 
            // gcCTPX
            // 
            this.gcCTPX.DataSource = this.chiTietPX_BDS;
            this.gcCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPX.Location = new System.Drawing.Point(757, 17);
            this.gcCTPX.MainView = this.gvCTPX;
            this.gcCTPX.MenuManager = this.barManager1;
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.Size = new System.Drawing.Size(632, 180);
            this.gcCTPX.TabIndex = 1;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPX});
            this.gcCTPX.MouseHover += new System.EventHandler(this.gtCTPhieuXuat_MouseHover);
            // 
            // chiTietPX_BDS
            // 
            this.chiTietPX_BDS.DataMember = "FK_CTPX_PX";
            this.chiTietPX_BDS.DataSource = this.phieuXuatBDS;
            // 
            // gvCTPX
            // 
            this.gvCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT2,
            this.colSOLUONG2,
            this.colDONGIA2});
            this.gvCTPX.GridControl = this.gcCTPX;
            this.gvCTPX.Name = "gvCTPX";
            this.gvCTPX.OptionsBehavior.Editable = false;
            this.gvCTPX.OptionsView.ShowGroupPanel = false;
            this.gvCTPX.OptionsView.ShowViewCaption = true;
            this.gvCTPX.ViewCaption = "Chi Tiết Phiếu Xuất";
            this.gvCTPX.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvCTPX_PopupMenuShowing);
            // 
            // colMAPX1
            // 
            this.colMAPX1.Caption = "Mã Phiếu Xuất";
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            // 
            // colMAVT2
            // 
            this.colMAVT2.Caption = "Mã VT";
            this.colMAVT2.FieldName = "MAVT";
            this.colMAVT2.Name = "colMAVT2";
            this.colMAVT2.Visible = true;
            this.colMAVT2.VisibleIndex = 1;
            // 
            // colSOLUONG2
            // 
            this.colSOLUONG2.Caption = "Số lượng";
            this.colSOLUONG2.DisplayFormat.FormatString = "N0";
            this.colSOLUONG2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSOLUONG2.FieldName = "SOLUONG";
            this.colSOLUONG2.Name = "colSOLUONG2";
            this.colSOLUONG2.Visible = true;
            this.colSOLUONG2.VisibleIndex = 2;
            // 
            // colDONGIA2
            // 
            this.colDONGIA2.Caption = "Đơn giá";
            this.colDONGIA2.DisplayFormat.FormatString = "N0";
            this.colDONGIA2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA2.FieldName = "DONGIA";
            this.colDONGIA2.Name = "colDONGIA2";
            this.colDONGIA2.Visible = true;
            this.colDONGIA2.VisibleIndex = 3;
            // 
            // gcPhieuXuat
            // 
            this.gcPhieuXuat.DataSource = this.phieuXuatBDS;
            this.gcPhieuXuat.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcPhieuXuat.Location = new System.Drawing.Point(3, 17);
            this.gcPhieuXuat.MainView = this.gvPhieuXuat;
            this.gcPhieuXuat.MenuManager = this.barManager1;
            this.gcPhieuXuat.Name = "gcPhieuXuat";
            this.gcPhieuXuat.Size = new System.Drawing.Size(754, 180);
            this.gcPhieuXuat.TabIndex = 0;
            this.gcPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuXuat});
            this.gcPhieuXuat.MouseHover += new System.EventHandler(this.gcPhieuXuat_MouseHover);
            // 
            // gvPhieuXuat
            // 
            this.gvPhieuXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY3,
            this.colHOTENKH,
            this.colMANV4,
            this.colMAKHO2});
            this.gvPhieuXuat.GridControl = this.gcPhieuXuat;
            this.gvPhieuXuat.Name = "gvPhieuXuat";
            this.gvPhieuXuat.OptionsBehavior.Editable = false;
            this.gvPhieuXuat.OptionsView.ShowGroupPanel = false;
            this.gvPhieuXuat.OptionsView.ShowViewCaption = true;
            this.gvPhieuXuat.ViewCaption = "Phiếu Xuất";
            this.gvPhieuXuat.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvPhieuXuat_PopupMenuShowing);
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã Phiếu Xuất";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            // 
            // colNGAY3
            // 
            this.colNGAY3.Caption = "Ngày cập nhật";
            this.colNGAY3.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY3.FieldName = "NGAY";
            this.colNGAY3.Name = "colNGAY3";
            this.colNGAY3.Visible = true;
            this.colNGAY3.VisibleIndex = 1;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên Khách Hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            // 
            // colMANV4
            // 
            this.colMANV4.Caption = "Mã NV";
            this.colMANV4.FieldName = "MANV";
            this.colMANV4.Name = "colMANV4";
            this.colMANV4.Visible = true;
            this.colMANV4.VisibleIndex = 3;
            // 
            // colMAKHO2
            // 
            this.colMAKHO2.Caption = "Mã Kho";
            this.colMAKHO2.FieldName = "MAKHO";
            this.colMAKHO2.Name = "colMAKHO2";
            this.colMAKHO2.Visible = true;
            this.colMAKHO2.VisibleIndex = 4;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // cmsCTDDH
            // 
            this.cmsCTDDH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddCTDDH});
            this.cmsCTDDH.Name = "cmsCTDDH";
            this.cmsCTDDH.Size = new System.Drawing.Size(172, 26);
            // 
            // smiAddCTDDH
            // 
            this.smiAddCTDDH.Image = global::QuanLyVatTu.Properties.Resources.add_16;
            this.smiAddCTDDH.Name = "smiAddCTDDH";
            this.smiAddCTDDH.Size = new System.Drawing.Size(171, 22);
            this.smiAddCTDDH.Text = "Thêm chi tiết DDH";
            this.smiAddCTDDH.Click += new System.EventHandler(this.smiAddCTDDH_Click);
            // 
            // cmsPN
            // 
            this.cmsPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddPN});
            this.cmsPN.Name = "cmsPN";
            this.cmsPN.Size = new System.Drawing.Size(170, 26);
            // 
            // smiAddPN
            // 
            this.smiAddPN.Image = global::QuanLyVatTu.Properties.Resources.add_16;
            this.smiAddPN.Name = "smiAddPN";
            this.smiAddPN.Size = new System.Drawing.Size(169, 22);
            this.smiAddPN.Text = "Thêm Phiếu Nhập";
            this.smiAddPN.Click += new System.EventHandler(this.smiAddPN_Click);
            // 
            // cmsCTPN
            // 
            this.cmsCTPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddCTPN});
            this.cmsCTPN.Name = "cmsCTPN";
            this.cmsCTPN.Size = new System.Drawing.Size(209, 26);
            // 
            // smiAddCTPN
            // 
            this.smiAddCTPN.Image = global::QuanLyVatTu.Properties.Resources.add_16;
            this.smiAddCTPN.Name = "smiAddCTPN";
            this.smiAddCTPN.Size = new System.Drawing.Size(208, 22);
            this.smiAddCTPN.Text = "Thêm chi tiết Phiếu Nhập";
            this.smiAddCTPN.Click += new System.EventHandler(this.smiAddCTPN_Click);
            // 
            // cmsPX
            // 
            this.cmsPX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddPX});
            this.cmsPX.Name = "cmsPX";
            this.cmsPX.Size = new System.Drawing.Size(165, 26);
            // 
            // smiAddPX
            // 
            this.smiAddPX.Image = global::QuanLyVatTu.Properties.Resources.add_16;
            this.smiAddPX.Name = "smiAddPX";
            this.smiAddPX.Size = new System.Drawing.Size(164, 22);
            this.smiAddPX.Text = "Thêm Phiếu Xuất";
            this.smiAddPX.Click += new System.EventHandler(this.smiAddPX_Click);
            // 
            // cmsCTPX
            // 
            this.cmsCTPX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiAddCTPX});
            this.cmsCTPX.Name = "cmsCTPX";
            this.cmsCTPX.Size = new System.Drawing.Size(204, 26);
            // 
            // smiAddCTPX
            // 
            this.smiAddCTPX.Image = global::QuanLyVatTu.Properties.Resources.add_16;
            this.smiAddCTPX.Name = "smiAddCTPX";
            this.smiAddCTPX.Size = new System.Drawing.Size(203, 22);
            this.smiAddCTPX.Text = "Thêm chi tiết Phiếu Xuất";
            this.smiAddCTPX.Click += new System.EventHandler(this.smiAddCTPX_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // chiNhanhBDS
            // 
            this.chiNhanhBDS.DataMember = "ChiNhanh";
            this.chiNhanhBDS.DataSource = this.qLVTDataSet;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add";
            this.barButtonItem1.Id = 40;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Exit";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.turn_off_32;
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem2.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Exit";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.turn_off_32;
            this.barButtonItem3.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem3.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barButtonItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem3.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem3.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Exit";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.turn_off_32;
            this.barButtonItem4.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem4.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.Red;
            this.barButtonItem4.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem4.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.barButtonItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem4.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barButtonItem4.ItemAppearance.Pressed.ForeColor = System.Drawing.Color.Blue;
            this.barButtonItem4.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem4.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1409, 856);
            this.Controls.Add(this.gbPhieuXuat);
            this.Controls.Add(this.gbPhieuNhap);
            this.Controls.Add(this.gbDatHang);
            this.Controls.Add(this.gbInfor);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.panelChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FormNhanVien.IconOptions.Icon")));
            this.Name = "FormNhanVien";
            this.Text = "Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panelChiNhanh.ResumeLayout(false);
            this.panelChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUONGNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).EndInit();
            this.gbDatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDDH_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDDH)).EndInit();
            this.cmsDDH.ResumeLayout(false);
            this.gbPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPN_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatHangByPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatHangByPN)).EndInit();
            this.gbPhieuXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPX_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.cmsCTDDH.ResumeLayout(false);
            this.cmsPN.ResumeLayout(false);
            this.cmsCTPN.ResumeLayout(false);
            this.cmsPX.ResumeLayout(false);
            this.cmsCTPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chiNhanhBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.Panel panelChiNhanh;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label1;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.TextBox mACNTextBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnChuyenCN;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private System.Windows.Forms.Label lbInfor;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private System.Windows.Forms.CheckBox trangThaiXoaCheckBox;
        private System.Windows.Forms.BindingSource phieuXuatBDS;
        private System.Windows.Forms.BindingSource datHangBDS;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.PopupMenu popupMenu3;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraBars.BarSubItem btnSwitch;
        private DevExpress.XtraBars.BarButtonItem btnInfo;
        private DevExpress.XtraBars.BarButtonItem btnDatHang;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnPhieuXuat;
        private System.Windows.Forms.GroupBox gbPhieuXuat;
        private System.Windows.Forms.GroupBox gbPhieuNhap;
        private System.Windows.Forms.GroupBox gbDatHang;
        private DevExpress.XtraGrid.GridControl gcDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDDH;
        private System.Windows.Forms.BindingSource chiTietDDH_BDS;
        private System.Windows.Forms.BindingSource phieuNhapBDS;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.GridControl gcPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuXuat;
        private System.Windows.Forms.BindingSource chiTietPX_BDS;
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.Windows.Forms.ContextMenuStrip cmsDDH;
        private System.Windows.Forms.ToolStripMenuItem smiAddDDH;
        private System.Windows.Forms.ContextMenuStrip cmsCTDDH;
        private System.Windows.Forms.ToolStripMenuItem smiAddCTDDH;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private System.Windows.Forms.NumericUpDown lUONGNumericUpDown;
        private System.Windows.Forms.NumericUpDown mANVNumericUpDown;
        private DevExpress.XtraGrid.GridControl gcDatHangByPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDatHangByPN;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private System.Windows.Forms.BindingSource chiTietPN_BDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPN;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH2;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH3;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA1;
        private System.Windows.Forms.ContextMenuStrip cmsPN;
        private System.Windows.Forms.ToolStripMenuItem smiAddPN;
        private System.Windows.Forms.ContextMenuStrip cmsCTPN;
        private System.Windows.Forms.ToolStripMenuItem smiAddCTPN;
        private System.Windows.Forms.ContextMenuStrip cmsPX;
        private System.Windows.Forms.ToolStripMenuItem smiAddPX;
        private System.Windows.Forms.ContextMenuStrip cmsCTPX;
        private System.Windows.Forms.ToolStripMenuItem smiAddCTPX;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG2;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY3;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV4;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource chiNhanhBDS;
        private QLVTDataSetTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        public QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        public QLVTDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        public QLVTDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        public QLVTDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        public QLVTDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        public QLVTDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        public QLVTDataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}