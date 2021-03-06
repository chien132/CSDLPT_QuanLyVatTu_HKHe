namespace QLVT_DATHANG.SubForm
{
    partial class CTDDHSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTDDHSubForm));
            this.qLVT_DATHANGDataSet = new QLVT_DATHANG.QLVT_DATHANGDataSet();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMasoDDH = new System.Windows.Forms.TextBox();
            this.tbMaVT = new System.Windows.Forms.TextBox();
            this.masoDDHLabel = new System.Windows.Forms.Label();
            this.mAVTLabel1 = new System.Windows.Forms.Label();
            this.sOLUONGLabel = new System.Windows.Forms.Label();
            this.nuDonGia = new System.Windows.Forms.NumericUpDown();
            this.dONGIALabel = new System.Windows.Forms.Label();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbMasoDDH);
            this.groupBox1.Controls.Add(this.tbMaVT);
            this.groupBox1.Controls.Add(this.masoDDHLabel);
            this.groupBox1.Controls.Add(this.mAVTLabel1);
            this.groupBox1.Controls.Add(this.sOLUONGLabel);
            this.groupBox1.Controls.Add(this.nuDonGia);
            this.groupBox1.Controls.Add(this.dONGIALabel);
            this.groupBox1.Controls.Add(this.nuSoLuong);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 368);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm chi tiết đơn đặt hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(143, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbMasoDDH
            // 
            this.tbMasoDDH.Enabled = false;
            this.tbMasoDDH.Location = new System.Drawing.Point(143, 153);
            this.tbMasoDDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMasoDDH.Name = "tbMasoDDH";
            this.tbMasoDDH.Size = new System.Drawing.Size(224, 23);
            this.tbMasoDDH.TabIndex = 16;
            // 
            // tbMaVT
            // 
            this.tbMaVT.Enabled = false;
            this.tbMaVT.Location = new System.Drawing.Point(143, 199);
            this.tbMaVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(224, 23);
            this.tbMaVT.TabIndex = 23;
            // 
            // masoDDHLabel
            // 
            this.masoDDHLabel.AutoSize = true;
            this.masoDDHLabel.Location = new System.Drawing.Point(45, 157);
            this.masoDDHLabel.Name = "masoDDHLabel";
            this.masoDDHLabel.Size = new System.Drawing.Size(77, 16);
            this.masoDDHLabel.TabIndex = 15;
            this.masoDDHLabel.Text = "Mã số ĐĐH:";
            // 
            // mAVTLabel1
            // 
            this.mAVTLabel1.AutoSize = true;
            this.mAVTLabel1.Location = new System.Drawing.Point(45, 202);
            this.mAVTLabel1.Name = "mAVTLabel1";
            this.mAVTLabel1.Size = new System.Drawing.Size(67, 16);
            this.mAVTLabel1.TabIndex = 21;
            this.mAVTLabel1.Text = "Mã vật tư:";
            // 
            // sOLUONGLabel
            // 
            this.sOLUONGLabel.AutoSize = true;
            this.sOLUONGLabel.Location = new System.Drawing.Point(45, 243);
            this.sOLUONGLabel.Name = "sOLUONGLabel";
            this.sOLUONGLabel.Size = new System.Drawing.Size(64, 16);
            this.sOLUONGLabel.TabIndex = 17;
            this.sOLUONGLabel.Text = "Số lượng:";
            // 
            // nuDonGia
            // 
            this.nuDonGia.DecimalPlaces = 2;
            this.nuDonGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuDonGia.Location = new System.Drawing.Point(143, 282);
            this.nuDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuDonGia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Size = new System.Drawing.Size(225, 23);
            this.nuDonGia.TabIndex = 22;
            this.nuDonGia.ThousandsSeparator = true;
            // 
            // dONGIALabel
            // 
            this.dONGIALabel.AutoSize = true;
            this.dONGIALabel.Location = new System.Drawing.Point(45, 282);
            this.dONGIALabel.Name = "dONGIALabel";
            this.dONGIALabel.Size = new System.Drawing.Size(57, 16);
            this.dONGIALabel.TabIndex = 18;
            this.dONGIALabel.Text = "Đơn giá:";
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.Location = new System.Drawing.Point(143, 241);
            this.nuSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.nuSoLuong.Size = new System.Drawing.Size(225, 23);
            this.nuSoLuong.TabIndex = 20;
            this.nuSoLuong.ThousandsSeparator = true;
            this.nuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(263, 325);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 31);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "Thoát";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.vattuBindingSource;
            this.vattuGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vattuGridControl.Location = new System.Drawing.Point(477, 43);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(525, 437);
            this.vattuGridControl.TabIndex = 36;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.vattuGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "DANH SÁCH VẬT TƯ";
            // 
            // colMAVT
            // 
            this.colMAVT.AppearanceHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colMAVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAVT.AppearanceHeader.Options.UseBackColor = true;
            this.colMAVT.AppearanceHeader.Options.UseFont = true;
            this.colMAVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.OptionsColumn.AllowFocus = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.AppearanceHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colTENVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENVT.AppearanceHeader.Options.UseBackColor = true;
            this.colTENVT.AppearanceHeader.Options.UseFont = true;
            this.colTENVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.OptionsColumn.AllowEdit = false;
            this.colTENVT.OptionsColumn.AllowFocus = false;
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.AppearanceHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colDVT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDVT.AppearanceHeader.Options.UseBackColor = true;
            this.colDVT.AppearanceHeader.Options.UseFont = true;
            this.colDVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.OptionsColumn.AllowFocus = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.AppearanceCell.Options.UseTextOptions = true;
            this.colSOLUONGTON.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONGTON.AppearanceHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colSOLUONGTON.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOLUONGTON.AppearanceHeader.Options.UseBackColor = true;
            this.colSOLUONGTON.AppearanceHeader.Options.UseFont = true;
            this.colSOLUONGTON.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOLUONGTON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.OptionsColumn.AllowEdit = false;
            this.colSOLUONGTON.OptionsColumn.AllowFocus = false;
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // CTDDHSubForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 425);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::QLVT_DATHANG.Properties.Resources.note;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CTDDHSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập chi tiết đơn đặt hàng";
            this.Load += new System.EventHandler(this.CTDDHSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbMasoDDH;
        private System.Windows.Forms.TextBox tbMaVT;
        private System.Windows.Forms.Label masoDDHLabel;
        private System.Windows.Forms.Label mAVTLabel1;
        private System.Windows.Forms.Label sOLUONGLabel;
        private System.Windows.Forms.NumericUpDown nuDonGia;
        private System.Windows.Forms.Label dONGIALabel;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private System.Windows.Forms.Button btnOK;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
    }
}