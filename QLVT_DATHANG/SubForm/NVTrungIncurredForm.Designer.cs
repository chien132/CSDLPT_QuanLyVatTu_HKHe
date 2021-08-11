namespace QLVT_DATHANG.SubForm
{
    partial class NVTrungIncurredForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NVTrungIncurredForm));
            this.qLVT_DATHANGDataSet_NVTrung = new QLVT_DATHANG.QLVT_DATHANGDataSet_NVTrung();
            this.sP_CheckNVTrungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CheckNVTrungTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSet_NVTrungTableAdapters.SP_CheckNVTrungTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.QLVT_DATHANGDataSet_NVTrungTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.mANVToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mANVToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sP_CheckNVTrungGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrowguid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet_NVTrung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CheckNVTrungBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CheckNVTrungGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVT_DATHANGDataSet_NVTrung
            // 
            this.qLVT_DATHANGDataSet_NVTrung.DataSetName = "QLVT_DATHANGDataSet_NVTrung";
            this.qLVT_DATHANGDataSet_NVTrung.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_CheckNVTrungBindingSource
            // 
            this.sP_CheckNVTrungBindingSource.DataMember = "SP_CheckNVTrung";
            this.sP_CheckNVTrungBindingSource.DataSource = this.qLVT_DATHANGDataSet_NVTrung;
            // 
            // sP_CheckNVTrungTableAdapter
            // 
            this.sP_CheckNVTrungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.QLVT_DATHANGDataSet_NVTrungTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANVToolStripLabel,
            this.mANVToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(773, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // mANVToolStripLabel
            // 
            this.mANVToolStripLabel.Name = "mANVToolStripLabel";
            this.mANVToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.mANVToolStripLabel.Text = "MANV:";
            // 
            // mANVToolStripTextBox
            // 
            this.mANVToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mANVToolStripTextBox.Name = "mANVToolStripTextBox";
            this.mANVToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // sP_CheckNVTrungGridControl
            // 
            this.sP_CheckNVTrungGridControl.DataSource = this.sP_CheckNVTrungBindingSource;
            this.sP_CheckNVTrungGridControl.Location = new System.Drawing.Point(21, 30);
            this.sP_CheckNVTrungGridControl.MainView = this.gridView1;
            this.sP_CheckNVTrungGridControl.Name = "sP_CheckNVTrungGridControl";
            this.sP_CheckNVTrungGridControl.Size = new System.Drawing.Size(726, 164);
            this.sP_CheckNVTrungGridControl.TabIndex = 2;
            this.sP_CheckNVTrungGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa,
            this.colrowguid});
            this.gridView1.GridControl = this.sP_CheckNVTrungGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "NHÂN VIÊN TRÙNG VỚI CHI NHÁNH KHÁC";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
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
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
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
            // colrowguid
            // 
            this.colrowguid.FieldName = "rowguid";
            this.colrowguid.Name = "colrowguid";
            // 
            // NVTrungIncurredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 416);
            this.Controls.Add(this.sP_CheckNVTrungGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("NVTrungIncurredForm.IconOptions.Image")));
            this.Name = "NVTrungIncurredForm";
            this.Text = "Nhân viên trùng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NVTrungIncurredForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet_NVTrung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CheckNVTrungBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_CheckNVTrungGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLVT_DATHANGDataSet_NVTrung qLVT_DATHANGDataSet_NVTrung;
        private System.Windows.Forms.BindingSource sP_CheckNVTrungBindingSource;
        private QLVT_DATHANGDataSet_NVTrungTableAdapters.SP_CheckNVTrungTableAdapter sP_CheckNVTrungTableAdapter;
        private QLVT_DATHANGDataSet_NVTrungTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel mANVToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mANVToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl sP_CheckNVTrungGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colrowguid;
    }
}