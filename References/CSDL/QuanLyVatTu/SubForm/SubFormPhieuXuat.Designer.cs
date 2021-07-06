namespace QuanLyVatTu.SubForm
{
    partial class SubFormPhieuXuat
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
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAPXLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormPhieuXuat));
            this.qLVTDataSet = new QuanLyVatTu.QLVTDataSet();
            this.phieuXuatTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager();
            this.khoTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.nhanVienTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.NhanVienTableAdapter();
            this.nhanVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatBDS = new System.Windows.Forms.BindingSource(this.components);
            this.tbKhachHang = new System.Windows.Forms.TextBox();
            this.tbMaKho = new System.Windows.Forms.TextBox();
            this.khoBDS = new System.Windows.Forms.BindingSource(this.components);
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbMaPX = new System.Windows.Forms.TextBox();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(42, 87);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(103, 13);
            hOTENKHLabel.TabIndex = 3;
            hOTENKHLabel.Text = "Họ tên Khách Hàng:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(99, 122);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(46, 13);
            mAKHOLabel.TabIndex = 5;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(66, 52);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(79, 13);
            mAPXLabel.TabIndex = 7;
            mAPXLabel.Text = "Mã Phiếu Xuất:";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienBDS
            // 
            this.nhanVienBDS.DataMember = "NhanVien";
            this.nhanVienBDS.DataSource = this.qLVTDataSet;
            // 
            // phieuXuatBDS
            // 
            this.phieuXuatBDS.AllowNew = true;
            this.phieuXuatBDS.DataMember = "FK_PX_NhanVien";
            this.phieuXuatBDS.DataSource = this.nhanVienBDS;
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatBDS, "HOTENKH", true));
            this.tbKhachHang.Location = new System.Drawing.Point(151, 84);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(178, 21);
            this.tbKhachHang.TabIndex = 4;
            // 
            // tbMaKho
            // 
            this.tbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatBDS, "MAKHO", true));
            this.tbMaKho.Enabled = false;
            this.tbMaKho.Location = new System.Drawing.Point(151, 119);
            this.tbMaKho.Name = "tbMaKho";
            this.tbMaKho.Size = new System.Drawing.Size(178, 21);
            this.tbMaKho.TabIndex = 6;
            // 
            // khoBDS
            // 
            this.khoBDS.DataMember = "Kho";
            this.khoBDS.DataSource = this.qLVTDataSet;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBDS;
            this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.khoGridControl.Location = new System.Drawing.Point(379, 0);
            this.khoGridControl.MainView = this.gvKho;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(405, 211);
            this.khoGridControl.TabIndex = 6;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKho});
            // 
            // gvKho
            // 
            this.gvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gvKho.GridControl = this.khoGridControl;
            this.gvKho.Name = "gvKho";
            this.gvKho.OptionsBehavior.Editable = false;
            this.gvKho.OptionsView.ShowGroupPanel = false;
            this.gvKho.OptionsView.ShowViewCaption = true;
            this.gvKho.ViewCaption = "Kho";
            this.gvKho.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvKho_RowClick);
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên Kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(239, 162);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbMaPX
            // 
            this.tbMaPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuXuatBDS, "MAPX", true));
            this.tbMaPX.Location = new System.Drawing.Point(151, 49);
            this.tbMaPX.Name = "tbMaPX";
            this.tbMaPX.Size = new System.Drawing.Size(178, 21);
            this.tbMaPX.TabIndex = 3;
            // 
            // SubFormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 211);
            this.Controls.Add(mAPXLabel);
            this.Controls.Add(this.tbMaPX);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(mAKHOLabel);
            this.Controls.Add(this.tbMaKho);
            this.Controls.Add(hOTENKHLabel);
            this.Controls.Add(this.tbKhachHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormPhieuXuat_FormClosing);
            this.Load += new System.EventHandler(this.SubFormPhieuXuat_Load);
            this.Shown += new System.EventHandler(this.SubFormPhieuXuat_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVTDataSet qLVTDataSet;
        private QLVTDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBDS;
        private System.Windows.Forms.BindingSource phieuXuatBDS;
        private System.Windows.Forms.TextBox tbKhachHang;
        private System.Windows.Forms.TextBox tbMaKho;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource khoBDS;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.TextBox tbMaPX;
    }
}