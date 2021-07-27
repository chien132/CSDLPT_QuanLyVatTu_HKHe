namespace QLVT_DATHANG
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bt_dang_nhap = new System.Windows.Forms.Button();
            this.cb_chi_nhanh = new System.Windows.Forms.ComboBox();
            this.tb_dang_nhap = new System.Windows.Forms.TextBox();
            this.tb_mat_khau = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.qLVT_DATHANGDataSet_DSPhanManh = new QLVT_DATHANG.QLVT_DATHANGDataSet_DSPhanManh();
            this.get_SubscribesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_SubscribesTableAdapter = new QLVT_DATHANG.QLVT_DATHANGDataSet_DSPhanManhTableAdapters.Get_SubscribesTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.QLVT_DATHANGDataSet_DSPhanManhTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet_DSPhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_SubscribesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_dang_nhap
            // 
            this.bt_dang_nhap.BackColor = System.Drawing.Color.LightCyan;
            this.bt_dang_nhap.Location = new System.Drawing.Point(132, 275);
            this.bt_dang_nhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_dang_nhap.Name = "bt_dang_nhap";
            this.bt_dang_nhap.Size = new System.Drawing.Size(250, 60);
            this.bt_dang_nhap.TabIndex = 0;
            this.bt_dang_nhap.Text = "           Đăng nhập  ";
            this.bt_dang_nhap.UseVisualStyleBackColor = false;
            this.bt_dang_nhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_chi_nhanh
            // 
            this.cb_chi_nhanh.DataSource = this.get_SubscribesBindingSource;
            this.cb_chi_nhanh.DisplayMember = "TENCN";
            this.cb_chi_nhanh.FormattingEnabled = true;
            this.cb_chi_nhanh.Location = new System.Drawing.Point(257, 78);
            this.cb_chi_nhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_chi_nhanh.Name = "cb_chi_nhanh";
            this.cb_chi_nhanh.Size = new System.Drawing.Size(178, 24);
            this.cb_chi_nhanh.TabIndex = 1;
            this.cb_chi_nhanh.ValueMember = "TENSERVER";
            // 
            // tb_dang_nhap
            // 
            this.tb_dang_nhap.Location = new System.Drawing.Point(257, 141);
            this.tb_dang_nhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_dang_nhap.Name = "tb_dang_nhap";
            this.tb_dang_nhap.Size = new System.Drawing.Size(178, 23);
            this.tb_dang_nhap.TabIndex = 2;
            this.tb_dang_nhap.Text = "LT";
            // 
            // tb_mat_khau
            // 
            this.tb_mat_khau.Location = new System.Drawing.Point(257, 206);
            this.tb_mat_khau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_mat_khau.Name = "tb_mat_khau";
            this.tb_mat_khau.Size = new System.Drawing.Size(178, 23);
            this.tb_mat_khau.TabIndex = 3;
            this.tb_mat_khau.Text = "12345";
            this.tb_mat_khau.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox4.Image = global::QLVT_DATHANG.Properties.Resources.enter;
            this.pictureBox4.Location = new System.Drawing.Point(150, 284);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QLVT_DATHANG.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(80, 190);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLVT_DATHANG.Properties.Resources._6405579;
            this.pictureBox2.Location = new System.Drawing.Point(80, 122);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVT_DATHANG.Properties.Resources.branch;
            this.pictureBox1.Location = new System.Drawing.Point(80, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chi nhánh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox5.Image = global::QLVT_DATHANG.Properties.Resources.log_out;
            this.pictureBox5.Location = new System.Drawing.Point(193, 359);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Location = new System.Drawing.Point(178, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "           Thoát  ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exit);
            // 
            // qLVT_DATHANGDataSet_DSPhanManh
            // 
            this.qLVT_DATHANGDataSet_DSPhanManh.DataSetName = "QLVT_DATHANGDataSet_DSPhanManh";
            this.qLVT_DATHANGDataSet_DSPhanManh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_SubscribesBindingSource
            // 
            this.get_SubscribesBindingSource.DataMember = "Get_Subscribes";
            this.get_SubscribesBindingSource.DataSource = this.qLVT_DATHANGDataSet_DSPhanManh;
            // 
            // get_SubscribesTableAdapter
            // 
            this.get_SubscribesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.QLVT_DATHANGDataSet_DSPhanManhTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LoginForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 401);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_mat_khau);
            this.Controls.Add(this.tb_dang_nhap);
            this.Controls.Add(this.cb_chi_nhanh);
            this.Controls.Add(this.bt_dang_nhap);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LoginForm.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet_DSPhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_SubscribesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_dang_nhap;
        private System.Windows.Forms.ComboBox cb_chi_nhanh;
        private System.Windows.Forms.TextBox tb_dang_nhap;
        private System.Windows.Forms.TextBox tb_mat_khau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private QLVT_DATHANGDataSet_DSPhanManh qLVT_DATHANGDataSet_DSPhanManh;
        private System.Windows.Forms.BindingSource get_SubscribesBindingSource;
        private QLVT_DATHANGDataSet_DSPhanManhTableAdapters.Get_SubscribesTableAdapter get_SubscribesTableAdapter;
        private QLVT_DATHANGDataSet_DSPhanManhTableAdapters.TableAdapterManager tableAdapterManager;
    }
}