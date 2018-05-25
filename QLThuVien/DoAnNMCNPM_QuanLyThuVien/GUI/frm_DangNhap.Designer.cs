namespace DoAnNMCNPM_QuanLyThuVien
{
    partial class frm_DangNhap
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.chkXacNhan = new Telerik.WinControls.UI.RadCheckBox();
            this.txtTenDangNhap = new Telerik.WinControls.UI.RadTextBox();
            this.txtMatKhau = new Telerik.WinControls.UI.RadTextBox();
            this.btnDangNhap = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(60, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(98, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Tên đăng nhập";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(60, 69);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Mật khẩu";
            // 
            // chkXacNhan
            // 
            this.chkXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkXacNhan.Location = new System.Drawing.Point(208, 107);
            this.chkXacNhan.Name = "chkXacNhan";
            this.chkXacNhan.Size = new System.Drawing.Size(74, 19);
            this.chkXacNhan.TabIndex = 2;
            this.chkXacNhan.Text = "Xác nhận ";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(186, 26);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(130, 20);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(186, 68);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(130, 20);
            this.txtMatKhau.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangNhap.Location = new System.Drawing.Point(208, 153);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(87, 39);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.access_512;
            this.pictureBox1.Location = new System.Drawing.Point(60, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(399, 210);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.chkXacNhan);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox chkXacNhan;
        private Telerik.WinControls.UI.RadTextBox txtTenDangNhap;
        private Telerik.WinControls.UI.RadTextBox txtMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton btnDangNhap;
    }
}