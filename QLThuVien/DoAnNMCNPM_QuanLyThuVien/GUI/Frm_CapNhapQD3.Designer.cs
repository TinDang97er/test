namespace DoAnNMCNPM_QuanLyThuVien
{
    partial class Frm_CapNhapQD3
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoSachMuonToiDa = new System.Windows.Forms.TextBox();
            this.txtSoNgayMuonToiDa = new System.Windows.Forms.TextBox();
            this.btnLuu = new Telerik.WinControls.UI.RadButton();
            this.btnThoat = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số sách mượn tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Ngày mượn tối đa";
            // 
            // txtSoSachMuonToiDa
            // 
            this.txtSoSachMuonToiDa.Location = new System.Drawing.Point(156, 22);
            this.txtSoSachMuonToiDa.Name = "txtSoSachMuonToiDa";
            this.txtSoSachMuonToiDa.Size = new System.Drawing.Size(74, 20);
            this.txtSoSachMuonToiDa.TabIndex = 1;
            this.txtSoSachMuonToiDa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoSachMuonToiDa_KeyPress);
            // 
            // txtSoNgayMuonToiDa
            // 
            this.txtSoNgayMuonToiDa.Location = new System.Drawing.Point(156, 51);
            this.txtSoNgayMuonToiDa.Name = "txtSoNgayMuonToiDa";
            this.txtSoNgayMuonToiDa.Size = new System.Drawing.Size(74, 20);
            this.txtSoNgayMuonToiDa.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(46, 99);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 32);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(166, 99);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 32);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_CapNhapQD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 143);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoNgayMuonToiDa);
            this.Controls.Add(this.txtSoSachMuonToiDa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_CapNhapQD3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quy định 3";
            this.Load += new System.EventHandler(this.Frm_CapNhapQD3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoSachMuonToiDa;
        private System.Windows.Forms.TextBox txtSoNgayMuonToiDa;
        private Telerik.WinControls.UI.RadButton btnLuu;
        private Telerik.WinControls.UI.RadButton btnThoat;
    }
}