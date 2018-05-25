namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    partial class frm_ThongTinSachChuaTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtTuCanTim = new Telerik.WinControls.UI.RadTextBoxControl();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTimKiemTheo = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTTSachChuaTra = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuCanTim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSachChuaTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTuCanTim);
            this.panel1.Controls.Add(this.radButton1);
            this.panel1.Controls.Add(this.radButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbTimKiemTheo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 75);
            this.panel1.TabIndex = 0;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radGroupBox3.Controls.Add(this.dgvTTSachChuaTra);
            this.radGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radGroupBox3.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox3.HeaderText = "Tông tin  sách chưa trả";
            this.radGroupBox3.Location = new System.Drawing.Point(0, 75);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(1120, 485);
            this.radGroupBox3.TabIndex = 13;
            this.radGroupBox3.Text = "Tông tin  sách chưa trả";
            // 
            // txtTuCanTim
            // 
            this.txtTuCanTim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTuCanTim.Location = new System.Drawing.Point(428, 24);
            this.txtTuCanTim.Name = "txtTuCanTim";
            this.txtTuCanTim.Size = new System.Drawing.Size(164, 27);
            this.txtTuCanTim.TabIndex = 42;
            this.txtTuCanTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuCanTim_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(337, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Từ cần tìm";
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
            this.cmbTimKiemTheo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTimKiemTheo.Location = new System.Drawing.Point(163, 24);
            this.cmbTimKiemTheo.Name = "cmbTimKiemTheo";
            this.cmbTimKiemTheo.Size = new System.Drawing.Size(126, 27);
            this.cmbTimKiemTheo.TabIndex = 38;
            this.cmbTimKiemTheo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tìm kiếm theo";
            // 
            // dgvTTSachChuaTra
            // 
            this.dgvTTSachChuaTra.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTSachChuaTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTTSachChuaTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTSachChuaTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTSachChuaTra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTTSachChuaTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTSachChuaTra.Location = new System.Drawing.Point(2, 18);
            this.dgvTTSachChuaTra.Name = "dgvTTSachChuaTra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTSachChuaTra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTTSachChuaTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTSachChuaTra.Size = new System.Drawing.Size(1116, 465);
            this.dgvTTSachChuaTra.TabIndex = 0;
            this.dgvTTSachChuaTra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTSachChuaTra_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaPhieuMuon";
            this.Column2.HeaderText = "Mã phiếu mượn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MaThe";
            this.Column3.HeaderText = "Mã thẻ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TenDocGia";
            this.Column4.HeaderText = "Tên độc giả";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "NgayMuon";
            this.Column5.HeaderText = "Ngày mượn";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "NgayDuKienTra";
            this.Column6.HeaderText = "Ngà dự kiến trả";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radButton1.ForeColor = System.Drawing.Color.Black;
            this.radButton1.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.Actions_edit_delete_icon;
            this.radButton1.Location = new System.Drawing.Point(801, 18);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(103, 33);
            this.radButton1.TabIndex = 41;
            this.radButton1.Text = "   Thoát";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radButton2.ForeColor = System.Drawing.Color.Black;
            this.radButton2.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.find_icon;
            this.radButton2.Location = new System.Drawing.Point(638, 18);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(116, 33);
            this.radButton2.TabIndex = 40;
            this.radButton2.Text = "      Tìm kiếm";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // frm_ThongTinSachChuaTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ThongTinSachChuaTra";
            this.Size = new System.Drawing.Size(1120, 560);
            this.Load += new System.EventHandler(this.frm_ThongTinSachChuaTra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuCanTim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiemTheo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTSachChuaTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadTextBoxControl txtTuCanTim;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadMultiColumnComboBox cmbTimKiemTheo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTTSachChuaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
