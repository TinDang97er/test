namespace DoAnNMCNPM_QuanLyThuVien
{
    partial class frm_CapNhapQD2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTheLoai = new System.Windows.Forms.TextBox();
            this.txtHanNhanSach = new System.Windows.Forms.TextBox();
            this.btnLuu = new Telerik.WinControls.UI.RadButton();
            this.btnThoat = new Telerik.WinControls.UI.RadButton();
            this.btnThem = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hạn nhận sách(năm)";
            // 
            // txtSoTheLoai
            // 
            this.txtSoTheLoai.Location = new System.Drawing.Point(85, 27);
            this.txtSoTheLoai.Name = "txtSoTheLoai";
            this.txtSoTheLoai.Size = new System.Drawing.Size(54, 20);
            this.txtSoTheLoai.TabIndex = 1;
            this.txtSoTheLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTheLoai_KeyPress);
            // 
            // txtHanNhanSach
            // 
            this.txtHanNhanSach.Location = new System.Drawing.Point(164, 66);
            this.txtHanNhanSach.Name = "txtHanNhanSach";
            this.txtHanNhanSach.Size = new System.Drawing.Size(54, 20);
            this.txtHanNhanSach.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(57, 106);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 32);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(137, 106);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 32);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(161, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 20);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frm_CapNhapQD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 150);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtHanNhanSach);
            this.Controls.Add(this.txtSoTheLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frm_CapNhapQD2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quy định 2";
            this.Load += new System.EventHandler(this.frm_CapNhapQD2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTheLoai;
        private System.Windows.Forms.TextBox txtHanNhanSach;
        private Telerik.WinControls.UI.RadButton btnLuu;
        private Telerik.WinControls.UI.RadButton btnThoat;
        private Telerik.WinControls.UI.RadButton btnThem;
    }
}