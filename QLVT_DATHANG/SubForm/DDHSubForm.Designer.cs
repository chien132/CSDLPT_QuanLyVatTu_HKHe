namespace QLVT_DATHANG.SubForm
{
    partial class DDHSubForm
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DDHSubForm));
            this.tableAdapterManager = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMaKho = new DevExpress.XtraEditors.TextEdit();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT_DATHANG.QLVT_DATHANGDataSet();
            this.tbNCC = new DevExpress.XtraEditors.TextEdit();
            this.tbMaDDH = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvKho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datHangTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.khoTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            mAKHOLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(33, 255);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(55, 16);
            mAKHOLabel.TabIndex = 23;
            mAKHOLabel.Text = "Mã Kho:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(3, 210);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(90, 16);
            nhaCCLabel.TabIndex = 20;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(30, 165);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(60, 16);
            masoDDHLabel.TabIndex = 19;
            masoDDHLabel.Text = "Mã ĐĐH:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMaKho);
            this.groupBox1.Controls.Add(this.tbNCC);
            this.groupBox1.Controls.Add(this.tbMaDDH);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(mAKHOLabel);
            this.groupBox1.Controls.Add(nhaCCLabel);
            this.groupBox1.Controls.Add(masoDDHLabel);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm đơn đặt hàng";
            // 
            // tbMaKho
            // 
            this.tbMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MAKHO", true));
            this.tbMaKho.Enabled = false;
            this.tbMaKho.Location = new System.Drawing.Point(131, 254);
            this.tbMaKho.Name = "tbMaKho";
            this.tbMaKho.Size = new System.Drawing.Size(185, 20);
            this.tbMaKho.TabIndex = 30;
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNCC
            // 
            this.tbNCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "NhaCC", true));
            this.tbNCC.Location = new System.Drawing.Point(131, 206);
            this.tbNCC.Name = "tbNCC";
            this.tbNCC.Size = new System.Drawing.Size(185, 20);
            this.tbNCC.TabIndex = 29;
            // 
            // tbMaDDH
            // 
            this.tbMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MasoDDH", true));
            this.tbMaDDH.Location = new System.Drawing.Point(131, 161);
            this.tbMaDDH.Name = "tbMaDDH";
            this.tbMaDDH.Size = new System.Drawing.Size(185, 20);
            this.tbMaDDH.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(131, 304);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 25);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBindingSource;
            this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.khoGridControl.Location = new System.Drawing.Point(393, 0);
            this.khoGridControl.MainView = this.gvKho;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(473, 400);
            this.khoGridControl.TabIndex = 29;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKho});
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // gvKho
            // 
            this.gvKho.Appearance.FocusedRow.BackColor = System.Drawing.Color.Lime;
            this.gvKho.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvKho.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvKho.Appearance.Row.Options.UseFont = true;
            this.gvKho.Appearance.Row.Options.UseTextOptions = true;
            this.gvKho.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvKho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gvKho.GridControl = this.khoGridControl;
            this.gvKho.Name = "gvKho";
            this.gvKho.OptionsView.ShowGroupPanel = false;
            this.gvKho.OptionsView.ShowViewCaption = true;
            this.gvKho.ViewCaption = "DANH SÁCH KHO";
            this.gvKho.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvKho_RowClick);
            // 
            // colMAKHO
            // 
            this.colMAKHO.AppearanceHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colMAKHO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKHO.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHO.AppearanceHeader.Options.UseFont = true;
            this.colMAKHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAKHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.OptionsColumn.AllowFocus = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.AppearanceHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colTENKHO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENKHO.AppearanceHeader.Options.UseBackColor = true;
            this.colTENKHO.AppearanceHeader.Options.UseFont = true;
            this.colTENKHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENKHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.OptionsColumn.AllowEdit = false;
            this.colTENKHO.OptionsColumn.AllowFocus = false;
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colDIACHI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.AppearanceHeader.Options.UseFont = true;
            this.colDIACHI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIACHI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.OptionsColumn.AllowFocus = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.AppearanceHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colMACN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMACN.AppearanceHeader.Options.UseBackColor = true;
            this.colMACN.AppearanceHeader.Options.UseFont = true;
            this.colMACN.AppearanceHeader.Options.UseTextOptions = true;
            this.colMACN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.OptionsColumn.AllowFocus = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // DDHSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 400);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DDHSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đơn đặt hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DDHSubForm_FormClosing);
            this.Load += new System.EventHandler(this.DDHSubForm_Load);
            this.Shown += new System.EventHandler(this.SubFormDDH_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKho;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbNCC;
        private DevExpress.XtraEditors.TextEdit tbMaDDH;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraEditors.TextEdit tbMaKho;
    }
}