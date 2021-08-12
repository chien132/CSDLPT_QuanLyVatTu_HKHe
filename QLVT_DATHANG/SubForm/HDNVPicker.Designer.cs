
namespace QLVT_DATHANG.SubForm
{
    partial class HDNVPicker
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
            this.chiNhanhTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.ChiNhanhTableAdapter();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT_DATHANG.QLVT_DATHANGDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nhanVienTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(838, 418);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 33);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(145, 17);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(233, 21);
            this.cbChiNhanh.TabIndex = 1;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = this.chiNhanhTableAdapter;
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
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nhanVienGridControl);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 463);
            this.panel1.TabIndex = 1;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.nhanVienBindingSource;
            this.nhanVienGridControl.Location = new System.Drawing.Point(12, 45);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(911, 359);
            this.nhanVienGridControl.TabIndex = 3;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // HDNVPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 463);
            this.Controls.Add(this.panel1);
            this.Name = "HDNVPicker";
            this.Text = "HDNVPicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HDNVPicker_FormClosing);
            this.Load += new System.EventHandler(this.HDNVPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLVT_DATHANGDataSetTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label1;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}