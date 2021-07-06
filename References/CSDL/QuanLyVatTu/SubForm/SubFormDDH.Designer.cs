namespace QuanLyVatTu.SubForm
{
    partial class SubFormDDH
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
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormDDH));
            this.qLVTDataSet = new QuanLyVatTu.QLVTDataSet();
            this.khoBDS = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager();
            this.datHangTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.DatHangTableAdapter();
            this.gcKho = new DevExpress.XtraGrid.GridControl();
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.datHangBDS = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBDS = new System.Windows.Forms.BindingSource(this.components);
            this.tbMaDDH = new System.Windows.Forms.TextBox();
            this.tbNCC = new System.Windows.Forms.TextBox();
            this.tbMaKho = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nhanVienTableAdapter = new QuanLyVatTu.QLVTDataSetTableAdapters.NhanVienTableAdapter();
            masoDDHLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(88, 27);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(49, 13);
            masoDDHLabel.TabIndex = 13;
            masoDDHLabel.Text = "Mã DDH:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(61, 72);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(76, 13);
            nhaCCLabel.TabIndex = 14;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(91, 117);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(46, 13);
            mAKHOLabel.TabIndex = 16;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // qLVTDataSet
            // 
            this.qLVTDataSet.DataSetName = "QLVTDataSet";
            this.qLVTDataSet.EnforceConstraints = false;
            this.qLVTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoBDS
            // 
            this.khoBDS.DataMember = "Kho";
            this.khoBDS.DataSource = this.qLVTDataSet;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.QLVTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // gcKho
            // 
            this.gcKho.DataSource = this.khoBDS;
            this.gcKho.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcKho.Location = new System.Drawing.Point(384, 0);
            this.gcKho.MainView = this.gvKho;
            this.gcKho.Name = "gcKho";
            this.gcKho.Size = new System.Drawing.Size(400, 211);
            this.gcKho.TabIndex = 8;
            this.gcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKho});
            // 
            // gvKho
            // 
            this.gvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI1,
            this.colMACN1});
            this.gvKho.GridControl = this.gcKho;
            this.gvKho.Name = "gvKho";
            this.gvKho.OptionsBehavior.Editable = false;
            this.gvKho.OptionsView.ShowGroupPanel = false;
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
            // colDIACHI1
            // 
            this.colDIACHI1.Caption = "Địa chỉ";
            this.colDIACHI1.FieldName = "DIACHI";
            this.colDIACHI1.Name = "colDIACHI1";
            this.colDIACHI1.Visible = true;
            this.colDIACHI1.VisibleIndex = 2;
            // 
            // colMACN1
            // 
            this.colMACN1.Caption = "Mã CN";
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(238, 154);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 25);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
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
            // tbMaDDH
            // 
            this.tbMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datHangBDS, "MasoDDH", true));
            this.tbMaDDH.Location = new System.Drawing.Point(143, 24);
            this.tbMaDDH.Name = "tbMaDDH";
            this.tbMaDDH.Size = new System.Drawing.Size(185, 21);
            this.tbMaDDH.TabIndex = 14;
            // 
            // tbNCC
            // 
            this.tbNCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datHangBDS, "NhaCC", true));
            this.tbNCC.Location = new System.Drawing.Point(143, 69);
            this.tbNCC.Name = "tbNCC";
            this.tbNCC.Size = new System.Drawing.Size(185, 21);
            this.tbNCC.TabIndex = 15;
            // 
            // tbMaKho
            // 
            this.tbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datHangBDS, "MAKHO", true));
            this.tbMaKho.Enabled = false;
            this.tbMaKho.Location = new System.Drawing.Point(143, 114);
            this.tbMaKho.Name = "tbMaKho";
            this.tbMaKho.Size = new System.Drawing.Size(185, 21);
            this.tbMaKho.TabIndex = 17;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // SubFormDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 211);
            this.Controls.Add(mAKHOLabel);
            this.Controls.Add(this.tbMaKho);
            this.Controls.Add(nhaCCLabel);
            this.Controls.Add(this.tbNCC);
            this.Controls.Add(masoDDHLabel);
            this.Controls.Add(this.tbMaDDH);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gcKho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubFormDDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Đơn Đặt Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormDDH_FormClosing);
            this.Load += new System.EventHandler(this.SubFormDDH_Load);
            this.Shown += new System.EventHandler(this.SubFormDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.qLVTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QLVTDataSet qLVTDataSet;
        private System.Windows.Forms.BindingSource khoBDS;
        private QLVTDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private QLVTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private System.Windows.Forms.Button btnOk;
        private QLVTDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource datHangBDS;
        private System.Windows.Forms.TextBox tbMaDDH;
        private System.Windows.Forms.TextBox tbNCC;
        private System.Windows.Forms.TextBox tbMaKho;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private System.Windows.Forms.BindingSource nhanVienBDS;
        private QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
    }
}