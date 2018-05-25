namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    partial class frm_QLTienPhieuPhat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.dgvDanhSachPhieuPhat = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoat = new Telerik.WinControls.UI.RadButton();
            this.lbTongTienThu = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtTuCanTim = new Telerik.WinControls.UI.RadTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiem = new Telerik.WinControls.UI.RadButton();
            this.cmbTimKiemTheo = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuPhat)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTongTienThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuCanTim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo.EditorControl.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radGroupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 560);
            this.panel2.TabIndex = 4;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.dgvDanhSachPhieuPhat);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radGroupBox1.HeaderText = "Danh sách phiếu phạt";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 123);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(671, 437);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Danh sách phiếu phạt";
            // 
            // dgvDanhSachPhieuPhat
            // 
            this.dgvDanhSachPhieuPhat.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDanhSachPhieuPhat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachPhieuPhat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDanhSachPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column5,
            this.Column6});
            this.dgvDanhSachPhieuPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuPhat.Location = new System.Drawing.Point(2, 18);
            this.dgvDanhSachPhieuPhat.Name = "dgvDanhSachPhieuPhat";
            this.dgvDanhSachPhieuPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieuPhat.Size = new System.Drawing.Size(667, 417);
            this.dgvDanhSachPhieuPhat.TabIndex = 1;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "STT";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "MaPhieuTra";
            this.Column5.HeaderText = "Mã phiếu mượn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "TongNo";
            this.Column6.HeaderText = "Tổng nợ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.lbTongTienThu);
            this.panel3.Controls.Add(this.radLabel1);
            this.panel3.Controls.Add(this.txtTuCanTim);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.cmbTimKiemTheo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 123);
            this.panel3.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.Actions_edit_delete_icon;
            this.btnThoat.Location = new System.Drawing.Point(445, 70);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 33);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbTongTienThu
            // 
            this.lbTongTienThu.AutoSize = false;
            this.lbTongTienThu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbTongTienThu.Location = new System.Drawing.Point(104, 72);
            this.lbTongTienThu.Name = "lbTongTienThu";
            this.lbTongTienThu.Size = new System.Drawing.Size(110, 25);
            this.lbTongTienThu.TabIndex = 12;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(6, 78);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(97, 19);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "Tổng tiền thu";
            // 
            // txtTuCanTim
            // 
            this.txtTuCanTim.AutoSize = false;
            this.txtTuCanTim.Location = new System.Drawing.Point(378, 18);
            this.txtTuCanTim.Name = "txtTuCanTim";
            this.txtTuCanTim.Size = new System.Drawing.Size(161, 25);
            this.txtTuCanTim.TabIndex = 10;
            this.txtTuCanTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuCanTim_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(297, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Từ cần tìm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.find_icon;
            this.btnTimKiem.Location = new System.Drawing.Point(300, 70);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 33);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "      Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbTimKiemTheo
            // 
            this.cmbTimKiemTheo.AutoSize = false;
            this.cmbTimKiemTheo.AutoSizeDropDownToBestFit = true;
            // 
            // cmbTimKiemTheo.NestedRadGridView
            // 
            this.cmbTimKiemTheo.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTimKiemTheo.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimKiemTheo.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbTimKiemTheo.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.cmbTimKiemTheo.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.cmbTimKiemTheo.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.cmbTimKiemTheo.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.cmbTimKiemTheo.EditorControl.MasterTemplate.EnableGrouping = false;
            this.cmbTimKiemTheo.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.cmbTimKiemTheo.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.cmbTimKiemTheo.EditorControl.Name = "NestedRadGridView";
            this.cmbTimKiemTheo.EditorControl.ReadOnly = true;
            this.cmbTimKiemTheo.EditorControl.ShowGroupPanel = false;
            this.cmbTimKiemTheo.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.cmbTimKiemTheo.EditorControl.TabIndex = 0;
            this.cmbTimKiemTheo.Location = new System.Drawing.Point(104, 20);
            this.cmbTimKiemTheo.Name = "cmbTimKiemTheo";
            this.cmbTimKiemTheo.Size = new System.Drawing.Size(110, 23);
            this.cmbTimKiemTheo.TabIndex = 7;
            this.cmbTimKiemTheo.TabStop = false;
            this.cmbTimKiemTheo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiemTheo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(671, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 560);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources._30042013_034243_271;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_QLTienPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frm_QLTienPhieuPhat";
            this.Size = new System.Drawing.Size(1124, 560);
            this.Load += new System.EventHandler(this.frm_QLTienPhieuPhat_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuPhat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbTongTienThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuCanTim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Panel panel3;
        private Telerik.WinControls.UI.RadLabel lbTongTienThu;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtTuCanTim;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnTimKiem;
        private Telerik.WinControls.UI.RadMultiColumnComboBox cmbTimKiemTheo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
