namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    partial class frm_TTCTSachChuaTracs
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
            this.dgvCTsachChuaTra = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTsachChuaTra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTsachChuaTra
            // 
            this.dgvCTsachChuaTra.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCTsachChuaTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCTsachChuaTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTsachChuaTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.MaSach,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvCTsachChuaTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTsachChuaTra.Location = new System.Drawing.Point(0, 0);
            this.dgvCTsachChuaTra.Name = "dgvCTsachChuaTra";
            this.dgvCTsachChuaTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTsachChuaTra.Size = new System.Drawing.Size(638, 234);
            this.dgvCTsachChuaTra.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "STT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 40;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Width = 80;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenDauSach";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TacGia";
            this.Column3.HeaderText = "Tác giả";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenTheLoai";
            this.Column4.HeaderText = "Thể loại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ChuThich";
            this.Column5.HeaderText = "Tình trạng mượn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frm_TTCTSachChuaTracs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 234);
            this.Controls.Add(this.dgvCTsachChuaTra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frm_TTCTSachChuaTracs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.frm_TTCTSachChuaTracs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTsachChuaTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTsachChuaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}