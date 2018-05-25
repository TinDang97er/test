namespace DoAnNMCNPM_QuanLyThuVien.GUI
{
    partial class frm_TinhHinhMuonSach
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tKTinhHinhMuonSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet3 = new DoAnNMCNPM_QuanLyThuVien.QLTVDataSet3();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.rpvBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnBaoCao = new Telerik.WinControls.UI.RadButton();
            this.dtDen = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtTu = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tKTinhHinhMuonSachTableAdapter = new DoAnNMCNPM_QuanLyThuVien.QLTVDataSet3TableAdapters.TKTinhHinhMuonSachTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tKTinhHinhMuonSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tKTinhHinhMuonSachBindingSource
            // 
            this.tKTinhHinhMuonSachBindingSource.DataMember = "TKTinhHinhMuonSach";
            this.tKTinhHinhMuonSachBindingSource.DataSource = this.qLTVDataSet3;
            // 
            // qLTVDataSet3
            // 
            this.qLTVDataSet3.DataSetName = "QLTVDataSet3";
            this.qLTVDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radGroupBox2);
            this.panel1.Controls.Add(this.radGroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 560);
            this.panel1.TabIndex = 0;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radGroupBox2.Controls.Add(this.rpvBaoCao);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "Thông tin";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 79);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(744, 481);
            this.radGroupBox2.TabIndex = 6;
            this.radGroupBox2.Text = "Thông tin";
            // 
            // rpvBaoCao
            // 
            this.rpvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tKTinhHinhMuonSachBindingSource;
            this.rpvBaoCao.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvBaoCao.LocalReport.ReportEmbeddedResource = "DoAnNMCNPM_QuanLyThuVien.TinhHinhMuonSach.rdlc";
            this.rpvBaoCao.Location = new System.Drawing.Point(2, 18);
            this.rpvBaoCao.Name = "rpvBaoCao";
            this.rpvBaoCao.ServerReport.BearerToken = null;
            this.rpvBaoCao.Size = new System.Drawing.Size(740, 461);
            this.rpvBaoCao.TabIndex = 0;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radGroupBox1.Controls.Add(this.lbTime);
            this.radGroupBox1.Controls.Add(this.btnBaoCao);
            this.radGroupBox1.Controls.Add(this.dtDen);
            this.radGroupBox1.Controls.Add(this.dtTu);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "Báo cáo";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(744, 79);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Báo cáo";
            // 
            // lbTime
            // 
            this.lbTime.Location = new System.Drawing.Point(616, 33);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(79, 24);
            this.lbTime.TabIndex = 16;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnBaoCao.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.Clipboard_icon;
            this.btnBaoCao.Location = new System.Drawing.Point(477, 31);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(83, 31);
            this.btnBaoCao.TabIndex = 15;
            this.btnBaoCao.Text = "     Báo cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // dtDen
            // 
            this.dtDen.AutoSize = false;
            this.dtDen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(351, 36);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(97, 24);
            this.dtDen.TabIndex = 14;
            this.dtDen.TabStop = false;
            this.dtDen.Text = "4/22/2018";
            this.dtDen.Value = new System.DateTime(2018, 4, 22, 22, 59, 49, 326);
            // 
            // dtTu
            // 
            this.dtTu.AutoSize = false;
            this.dtTu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(196, 34);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(97, 24);
            this.dtTu.TabIndex = 14;
            this.dtTu.TabStop = false;
            this.dtTu.Text = "4/22/2018";
            this.dtTu.Value = new System.DateTime(2018, 4, 22, 22, 59, 49, 326);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(311, 38);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(34, 19);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Đến";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(46, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(144, 19);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Thời gian báo cáo từ";
            // 
            // tKTinhHinhMuonSachTableAdapter
            // 
            this.tKTinhHinhMuonSachTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(744, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 560);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.bo_co;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_TinhHinhMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_TinhHinhMuonSach";
            this.Size = new System.Drawing.Size(1124, 560);
            ((System.ComponentModel.ISupportInitialize)(this.tKTinhHinhMuonSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnBaoCao;
        private Telerik.WinControls.UI.RadDateTimePicker dtDen;
        private Telerik.WinControls.UI.RadDateTimePicker dtTu;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCao;
        private System.Windows.Forms.BindingSource tKTinhHinhMuonSachBindingSource;
        private QLTVDataSet3 qLTVDataSet3;
        private QLTVDataSet3TableAdapters.TKTinhHinhMuonSachTableAdapter tKTinhHinhMuonSachTableAdapter;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
