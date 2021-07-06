namespace QuanLyVatTu.SubForm
{
    partial class SubFormCTDDH
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormCTDDH));
            this.qLVTDataSet = new QuanLyVatTu.QLVTDataSet();
            this.cTDDHBDS = new System.Windows.Forms.BindingSource(this.components);
            this.datHangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.CTDDHTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager();
            this.tbMasoDDH = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.vatTuBDS = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.VattuTableAdapter();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gvVatTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVienTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.NhanVienTableAdapter();
            this.datHangTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nuDonGia = new System.Windows.Forms.NumericUpDown();
            this.tbMaVT = new System.Windows.Forms.TextBox();
            masoDDHLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(66, 28);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(63, 13);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(76, 98);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(53, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(81, 132);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(48, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // mAVTLabel1
            // 
            mAVTLabel1.AutoSize = true;
            mAVTLabel1.Location = new System.Drawing.Point(89, 65);
            mAVTLabel1.Name = "mAVTLabel1";
            mAVTLabel1.Size = new System.Drawing.Size(40, 13);
            mAVTLabel1.TabIndex = 12;
            mAVTLabel1.Text = "Mã VT:";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTDDHBDS
            // 
            this.cTDDHBDS.AllowNew = true;
            this.cTDDHBDS.DataMember = "FK_CTDDH_DatHang";
            this.cTDDHBDS.DataSource = this.datHangBDS;
            // 
            // datHangBDS
            // 
            this.datHangBDS.AllowNew = true;
            this.datHangBDS.DataMember = "FK_DatHang_NhanVien";
            this.datHangBDS.DataSource = this.nhanVienBDS;
            // 
            // nhanVienBDS
            // 
            this.nhanVienBDS.DataMember = "NhanVien";
            this.nhanVienBDS.DataSource = this.qLVTDataSet;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // tbMasoDDH
            // 
            this.tbMasoDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDDHBDS, "MasoDDH", true));
            this.tbMasoDDH.Enabled = false;
            this.tbMasoDDH.Location = new System.Drawing.Point(135, 25);
            this.tbMasoDDH.Name = "tbMasoDDH";
            this.tbMasoDDH.Size = new System.Drawing.Size(193, 21);
            this.tbMasoDDH.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(238, 165);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // vatTuBDS
            // 
            this.vatTuBDS.DataMember = "Vattu";
            this.vatTuBDS.DataSource = this.qLVTDataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.vatTuBDS;
            this.gcVatTu.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcVatTu.Location = new System.Drawing.Point(376, 0);
            this.gcVatTu.MainView = this.gvVatTu;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(408, 211);
            this.gcVatTu.TabIndex = 9;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVatTu});
            // 
            // gvVatTu
            // 
            this.gvVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gvVatTu.GridControl = this.gcVatTu;
            this.gvVatTu.Name = "gvVatTu";
            this.gvVatTu.OptionsBehavior.Editable = false;
            this.gvVatTu.OptionsView.ShowGroupPanel = false;
            this.gvVatTu.OptionsView.ShowViewCaption = true;
            this.gvVatTu.ViewCaption = "Vật Tư";
            this.gvVatTu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvVatTu_RowClick);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên VT";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.DisplayFormat.FormatString = "N0";
            this.colSOLUONGTON.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cTDDHBDS, "SOLUONG", true));
            this.nuSoLuong.Location = new System.Drawing.Point(135, 96);
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
            this.nuSoLuong.Size = new System.Drawing.Size(193, 21);
            this.nuSoLuong.TabIndex = 11;
            this.nuSoLuong.ThousandsSeparator = true;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuDonGia
            // 
            this.nuDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cTDDHBDS, "DONGIA", true));
            this.nuDonGia.DecimalPlaces = 2;
            this.nuDonGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuDonGia.Location = new System.Drawing.Point(135, 130);
            this.nuDonGia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Size = new System.Drawing.Size(193, 21);
            this.nuDonGia.TabIndex = 12;
            this.nuDonGia.ThousandsSeparator = true;
            // 
            // tbMaVT
            // 
            this.tbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTDDHBDS, "MAVT", true));
            this.tbMaVT.Enabled = false;
            this.tbMaVT.Location = new System.Drawing.Point(135, 62);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(193, 21);
            this.tbMaVT.TabIndex = 14;
            // 
            // SubFormCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 211);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(mAVTLabel1);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.tbMasoDDH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormCTDDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Chi Tiết Đơn Đặt Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTDDH_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTDDH_Load);
            this.Shown += new System.EventHandler(this.SubFormCTDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource cTDDHBDS;
        private QLVTDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbMasoDDH;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource vatTuBDS;
        private QLVTDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.BindingSource nhanVienBDS;
        private QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource datHangBDS;
        private QLVTDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private System.Windows.Forms.NumericUpDown nuDonGia;
        private System.Windows.Forms.TextBox tbMaVT;
    }
}