namespace QLVT_DATHANG.SubForm
{
    partial class CTPNSubForm
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
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label mAPNLabel;
            this.qLVT_DATHANGDataSet = new QLVT_DATHANG.QLVT_DATHANGDataSet();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.nuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.nuDonGia = new System.Windows.Forms.NumericUpDown();
            this.tbMaVT = new System.Windows.Forms.TextBox();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(33, 232);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(64, 16);
            sOLUONGLabel.TabIndex = 17;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(33, 278);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(57, 16);
            dONGIALabel.TabIndex = 15;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(33, 188);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(67, 16);
            mAVTLabel.TabIndex = 13;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(33, 143);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(98, 16);
            mAPNLabel.TabIndex = 11;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "CTDDH";
            this.cTDDHBindingSource.DataSource = this.qLVT_DATHANGDataSet;
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
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nuSoLuong
            // 
            this.nuSoLuong.Location = new System.Drawing.Point(135, 230);
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
            this.nuSoLuong.Size = new System.Drawing.Size(189, 23);
            this.nuSoLuong.TabIndex = 19;
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
            this.btnOK.Location = new System.Drawing.Point(237, 320);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 40);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "Thoát";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nuDonGia
            // 
            this.nuDonGia.DecimalPlaces = 2;
            this.nuDonGia.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nuDonGia.Location = new System.Drawing.Point(135, 275);
            this.nuDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuDonGia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nuDonGia.Name = "nuDonGia";
            this.nuDonGia.Size = new System.Drawing.Size(189, 23);
            this.nuDonGia.TabIndex = 16;
            this.nuDonGia.ThousandsSeparator = true;
            // 
            // tbMaVT
            // 
            this.tbMaVT.Enabled = false;
            this.tbMaVT.Location = new System.Drawing.Point(135, 184);
            this.tbMaVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaVT.Name = "tbMaVT";
            this.tbMaVT.Size = new System.Drawing.Size(188, 23);
            this.tbMaVT.TabIndex = 14;
            // 
            // tbMaPN
            // 
            this.tbMaPN.Enabled = false;
            this.tbMaPN.Location = new System.Drawing.Point(135, 139);
            this.tbMaPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.Size = new System.Drawing.Size(188, 23);
            this.tbMaPN.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbMaPN);
            this.groupBox1.Controls.Add(sOLUONGLabel);
            this.groupBox1.Controls.Add(mAPNLabel);
            this.groupBox1.Controls.Add(this.nuSoLuong);
            this.groupBox1.Controls.Add(this.tbMaVT);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(mAVTLabel);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(this.nuDonGia);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 372);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVT_DATHANG.Properties.Resources.packing_list2;
            this.pictureBox1.Location = new System.Drawing.Point(174, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(126, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.cTDDHBindingSource;
            this.gcCTDDH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcCTDDH.Location = new System.Drawing.Point(395, 21);
            this.gcCTDDH.MainView = this.gvCTDDH;
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(484, 373);
            this.gcCTDDH.TabIndex = 21;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvCTDDH.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCTDDH.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCTDDH.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvCTDDH.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCTDDH.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCTDDH.Appearance.Row.Options.UseFont = true;
            this.gvCTDDH.Appearance.Row.Options.UseTextOptions = true;
            this.gvCTDDH.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCTDDH.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCTDDH.Appearance.ViewCaption.Options.UseFont = true;
            this.gvCTDDH.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gvCTDDH.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.GridControl = this.gcCTDDH;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "CHI TIẾT ĐƠN ĐẶT HÀNG";
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.colMasoDDH1.AppearanceHeader.Options.UseBackColor = true;
            this.colMasoDDH1.Caption = "Mã số ĐĐH";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.OptionsColumn.AllowEdit = false;
            this.colMasoDDH1.OptionsColumn.AllowFocus = false;
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.colMAVT.AppearanceHeader.Options.UseBackColor = true;
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.OptionsColumn.AllowFocus = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.colSOLUONG.AppearanceHeader.Options.UseBackColor = true;
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.OptionsColumn.AllowFocus = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.colDONGIA.AppearanceHeader.Options.UseBackColor = true;
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.OptionsColumn.AllowFocus = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // CTPNSubForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 399);
            this.Controls.Add(this.gcCTDDH);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = global::QLVT_DATHANG.Properties.Resources.file;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CTPNSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập chi tiết phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CTPNSubForm_FormClosing);
            this.Load += new System.EventHandler(this.CTPNSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDonGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown nuSoLuong;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nuDonGia;
        private System.Windows.Forms.TextBox tbMaVT;
        private System.Windows.Forms.TextBox tbMaPN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
    }
}