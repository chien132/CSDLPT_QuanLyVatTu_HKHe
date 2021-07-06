namespace QuanLyVatTu.SubForm
{
    partial class SubFormCTPN
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormCTPN));
            this.qLVTDataSet = new QuanLyVatTu.QLVTDataSet();
            this.CTPN_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapBDS = new System.Windows.Forms.BindingSource(this.components);
            this.datHangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.CTPNTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.CTDDHTableAdapter();
            this.datHangTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.nhanVienTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.NhanVienTableAdapter();
            this.phieuNhapTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.tbMaVT = new System.Windows.Forms.TextBox();
            this.nuDonGia = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.CTDDH_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            mAPNLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPN_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTDDH_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(68, 22);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(82, 13);
            mAPNLabel.TabIndex = 1;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(110, 59);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 3;
            mAVTLabel.Text = "Mã VT:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(102, 132);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(48, 13);
            dONGIALabel.TabIndex = 7;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(97, 95);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(53, 13);
            sOLUONGLabel.TabIndex = 9;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CTPN_BDS
            // 
            this.CTPN_BDS.AllowNew = true;
            this.CTPN_BDS.DataMember = "FK_CTPN_PhieuNhap";
            this.CTPN_BDS.DataSource = this.phieuNhapBDS;
            // 
            // phieuNhapBDS
            // 
            this.phieuNhapBDS.DataMember = "FK_PhieuNhap_DatHang";
            this.phieuNhapBDS.DataSource = this.datHangBDS;
            // 
            // datHangBDS
            // 
            this.datHangBDS.DataMember = "FK_DatHang_NhanVien";
            this.datHangBDS.DataSource = this.nhanVienBDS;
            // 
            // nhanVienBDS
            // 
            this.nhanVienBDS.DataMember = "NhanVien";
            this.nhanVienBDS.DataSource = this.qLVTDataSet;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tbMaPN
            // 
            this.tbMaPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CTPN_BDS, "MAPN", true));
            this.tbMaPN.Enabled = false;
            this.tbMaPN.Location = new System.Drawing.Point(156, 19);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.Size = new System.Drawing.Size(162, 21);
            this.tbMaPN.TabIndex = 2;
            // 
            // tbMaVT
            // 
            this.tbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CTPN_BDS, "MAVT", true));
            this.tbMaVT.Enabled = false;
            this.tbMaVT.Location = new System.Drawing.Point(156, 56);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(162, 21);
            this.tbMaVT.TabIndex = 4;
            // 
            // nuDonGia
            // 
            this.nuDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CTPN_BDS, "DONGIA", true));
            this.nuDonGia.DecimalPlaces = 2;
            this.nuDonGia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuDonGia.Location = new System.Drawing.Point(156, 130);
            this.nuDonGia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Size = new System.Drawing.Size(162, 21);
            this.nuDonGia.TabIndex = 8;
            this.nuDonGia.ThousandsSeparator = true;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(228, 166);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CTDDH_BDS
            // 
            this.CTDDH_BDS.DataMember = "FK_CTDDH_DatHang";
            this.CTDDH_BDS.DataSource = this.datHangBDS;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.CTDDH_BDS;
            this.gcCTDDH.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcCTDDH.Location = new System.Drawing.Point(370, 0);
            this.gcCTDDH.MainView = this.gvCTDDH;
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(414, 211);
            this.gcCTDDH.TabIndex = 9;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.GridControl = this.gcCTDDH;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Chi Tiết Đơn Đặt Hàng";
            this.gvCTDDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCTDDH_RowClick);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
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
            this.colSOLUONG.DisplayFormat.FormatString = "N0";
            this.colSOLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
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
            // nuSoLuong
            // 
            this.nuSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CTPN_BDS, "SOLUONG", true));
            this.nuSoLuong.Location = new System.Drawing.Point(156, 93);
            this.nuSoLuong.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nuSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuSoLuong.Name = "nuSoLuong";
            this.nuSoLuong.Size = new System.Drawing.Size(162, 21);
            this.nuSoLuong.TabIndex = 10;
            this.nuSoLuong.ThousandsSeparator = true;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SubFormCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 211);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(this.gcCTDDH);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(mAVTLabel);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(mAPNLabel);
            this.Controls.Add(this.tbMaPN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Chi Tiết Phiếu Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTPN_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTPN_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPN_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTDDH_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource CTPN_BDS;
        private QLVTDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbMaPN;
        private System.Windows.Forms.TextBox tbMaVT;
        private System.Windows.Forms.NumericUpDown nuDonGia;
        private System.Windows.Forms.Button btnOK;
        private QLVTDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource datHangBDS;
        private QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBDS;
        private QLVTDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource phieuNhapBDS;
        private QLVTDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource CTDDH_BDS;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
    }
}