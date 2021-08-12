namespace QLVT_DATHANG.SubForm
{
    partial class PhieuNhapSubForm
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
            System.Windows.Forms.Label mAPNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuNhapSubForm));
            this.thoat = new System.Windows.Forms.Button();
            this.tbMaSoDDH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.qLVT_DATHANGDataSet = new QLVT_DATHANG.QLVT_DATHANGDataSet();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.mAPNTextEdit = new DevExpress.XtraEditors.TextEdit();
            masoDDHLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(73, 175);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(75, 16);
            masoDDHLabel.TabIndex = 10;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(50, 124);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(98, 16);
            mAPNLabel.TabIndex = 8;
            mAPNLabel.Text = "Mã Phiếu Nhập:";
            // 
            // thoat
            // 
            this.thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(281, 225);
            this.thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(91, 31);
            this.thoat.TabIndex = 12;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // tbMaSoDDH
            // 
            this.tbMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phieuNhapBindingSource, "MasoDDH", true));
            this.tbMaSoDDH.Enabled = false;
            this.tbMaSoDDH.Location = new System.Drawing.Point(166, 172);
            this.tbMaSoDDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaSoDDH.Name = "tbMaSoDDH";
            this.tbMaSoDDH.Size = new System.Drawing.Size(206, 23);
            this.tbMaSoDDH.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mAPNTextEdit);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.thoat);
            this.groupBox1.Controls.Add(mAPNLabel);
            this.groupBox1.Controls.Add(masoDDHLabel);
            this.groupBox1.Controls.Add(this.tbMaSoDDH);
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 285);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm phiếu nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVT_DATHANG.Properties.Resources.packing_list2;
            this.pictureBox1.Location = new System.Drawing.Point(212, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // mAPNTextEdit
            // 
            this.mAPNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAPN", true));
            this.mAPNTextEdit.Location = new System.Drawing.Point(166, 123);
            this.mAPNTextEdit.Name = "mAPNTextEdit";
            this.mAPNTextEdit.Size = new System.Drawing.Size(206, 20);
            this.mAPNTextEdit.TabIndex = 23;
            // 
            // PhieuNhapSubForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 309);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("PhieuNhapSubForm.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PhieuNhapSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhieuNhapSubForm_FormClosing);
            this.Load += new System.EventHandler(this.PhieuNhapSubForm_Load);
            this.Shown += new System.EventHandler(this.PhieuNhapSubForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPNTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox tbMaSoDDH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit mAPNTextEdit;
    }
}