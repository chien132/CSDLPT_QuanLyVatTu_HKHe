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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.pbChiNhanh = new System.Windows.Forms.PictureBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChiNhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightCyan;
            this.btnLogin.Location = new System.Drawing.Point(132, 267);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(250, 60);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "           Đăng nhập  ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(257, 78);
            this.cbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(178, 24);
            this.cbChiNhanh.TabIndex = 1;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(257, 141);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(178, 23);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.Text = "TT";
            this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLogin_KeyPress);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(257, 206);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(178, 23);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "12345";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
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
            // pbPassword
            // 
            this.pbPassword.Image = global::QLVT_DATHANG.Properties.Resources._lock;
            this.pbPassword.Location = new System.Drawing.Point(80, 190);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(44, 43);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 6;
            this.pbPassword.TabStop = false;
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::QLVT_DATHANG.Properties.Resources._6405579;
            this.pbLogin.Location = new System.Drawing.Point(80, 122);
            this.pbLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(41, 43);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 5;
            this.pbLogin.TabStop = false;
            // 
            // pbChiNhanh
            // 
            this.pbChiNhanh.Image = global::QLVT_DATHANG.Properties.Resources.branch;
            this.pbChiNhanh.Location = new System.Drawing.Point(80, 60);
            this.pbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbChiNhanh.Name = "pbChiNhanh";
            this.pbChiNhanh.Size = new System.Drawing.Size(44, 43);
            this.pbChiNhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChiNhanh.TabIndex = 4;
            this.pbChiNhanh.TabStop = false;
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(129, 86);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(70, 16);
            this.lbChiNhanh.TabIndex = 8;
            this.lbChiNhanh.Text = "Chi nhánh:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(129, 148);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(99, 16);
            this.lbLogin.TabIndex = 9;
            this.lbLogin.Text = "Tên đăng nhập:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(129, 213);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(65, 16);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Mật khẩu:";
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightPink;
            this.btnExit.Location = new System.Drawing.Point(178, 345);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 47);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "           Thoát  ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // LoginForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 374);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbChiNhanh);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.pbChiNhanh);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.cbChiNhanh);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LoginForm.IconOptions.LargeImage")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChiNhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbChiNhanh;
        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbPassword;

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnExit;
    }
}