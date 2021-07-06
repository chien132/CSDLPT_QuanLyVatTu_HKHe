namespace QuanLyVatTu.SubForm
{
    partial class SubFormCTPX
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormCTPX));
            this.qLVTDataSet = new QuanLyVatTu.QLVTDataSet();
            this.cTPX_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatBDS = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.CTPXTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.NhanVienTableAdapter();
            this.phieuXuatTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.PhieuXuatTableAdapter();
            this.vattuTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.VattuTableAdapter();
            this.tbMaPX = new System.Windows.Forms.TextBox();
            this.tbMaVT = new System.Windows.Forms.TextBox();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nuDonGia = new System.Windows.Forms.NumericUpDown();
            this.vatTuBDS = new System.Windows.Forms.BindingSource(this.components);
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvVatTu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOK = new System.Windows.Forms.Button();
            mAPXLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPX_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(60, 26);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(79, 13);
            mAPXLabel.TabIndex = 1;
            mAPXLabel.Text = "Mã Phiếu Xuất:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(99, 61);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(40, 13);
            mAVTLabel.TabIndex = 3;
            mAVTLabel.Text = "Mã VT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(86, 95);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(53, 13);
            sOLUONGLabel.TabIndex = 5;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(91, 130);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(48, 13);
            dONGIALabel.TabIndex = 7;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTPX_BDS
            // 
            this.cTPX_BDS.DataMember = "FK_CTPX_PX";
            this.cTPX_BDS.DataSource = this.phieuXuatBDS;
            // 
            // phieuXuatBDS
            // 
            this.phieuXuatBDS.DataMember = "FK_PX_NhanVien";
            this.phieuXuatBDS.DataSource = this.nhanVienBDS;
            // 
            // nhanVienBDS
            // 
            this.nhanVienBDS.DataMember = "NhanVien";
            this.nhanVienBDS.DataSource = this.qLVTDataSet;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // tbMaPX
            // 
            this.tbMaPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTPX_BDS, "MAPX", true));
            this.tbMaPX.Enabled = false;
            this.tbMaPX.Location = new System.Drawing.Point(145, 23);
            this.tbMaPX.Name = "tbMaPX";
            this.tbMaPX.Size = new System.Drawing.Size(172, 21);
            this.tbMaPX.TabIndex = 2;
            // 
            // tbMaVT
            // 
            this.tbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTPX_BDS, "MAVT", true));
            this.tbMaVT.Enabled = false;
            this.tbMaVT.Location = new System.Drawing.Point(145, 58);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(172, 21);
            this.tbMaVT.TabIndex = 4;
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cTPX_BDS, "SOLUONG", true));
            this.nuSoLuong.Location = new System.Drawing.Point(145, 93);
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
            this.nuSoLuong.Size = new System.Drawing.Size(172, 21);
            this.nuSoLuong.TabIndex = 6;
            this.nuSoLuong.ThousandsSeparator = true;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuDonGia
            // 
            this.nuDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cTPX_BDS, "DONGIA", true));
            this.nuDonGia.DecimalPlaces = 2;
            this.nuDonGia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuDonGia.Location = new System.Drawing.Point(145, 128);
            this.nuDonGia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Size = new System.Drawing.Size(172, 21);
            this.nuDonGia.TabIndex = 8;
            this.nuDonGia.ThousandsSeparator = true;
            // 
            // vatTuBDS
            // 
            this.vatTuBDS.DataMember = "Vattu";
            this.vatTuBDS.DataSource = this.qLVTDataSet;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.vatTuBDS;
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.vattuGridControl.Location = new System.Drawing.Point(376, 0);
            this.vattuGridControl.MainView = this.gvVatTu;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(408, 211);
            this.vattuGridControl.TabIndex = 8;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVatTu});
            // 
            // gvVatTu
            // 
            this.gvVatTu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gvVatTu.GridControl = this.vattuGridControl;
            this.gvVatTu.Name = "gvVatTu";
            this.gvVatTu.OptionsBehavior.Editable = false;
            this.gvVatTu.OptionsView.ShowGroupPanel = false;
            this.gvVatTu.OptionsView.ShowViewCaption = true;
            this.gvVatTu.ViewCaption = "Vật Tư";
            this.gvVatTu.Click += new System.EventHandler(this.gvVatTu_Click);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(227, 163);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SubFormCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 211);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(this.nuDonGia);
            this.Controls.Add(sOLUONGLabel);
            this.Controls.Add(this.nuSoLuong);
            this.Controls.Add(mAVTLabel);
            this.Controls.Add(this.tbMaVT);
            this.Controls.Add(mAPXLabel);
            this.Controls.Add(this.tbMaPX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormCTPX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Chi Tiết Phiếu Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTPX_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTPX_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPX_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPX_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatTuBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource cTPX_BDS;
        private QLVTDataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbMaPX;
        private System.Windows.Forms.TextBox tbMaVT;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private System.Windows.Forms.NumericUpDown nuDonGia;
        private QLVTDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource vatTuBDS;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVatTu;
        private System.Windows.Forms.Button btnOK;
        private QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBDS;
        private QLVTDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource phieuXuatBDS;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
    }
}