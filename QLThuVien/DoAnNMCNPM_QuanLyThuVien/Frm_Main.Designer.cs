namespace DoAnNMCNPM_QuanLyThuVien
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.tabThuVien = new Telerik.WinControls.UI.RibbonTab();
            this.tabThuVien_GioiThieu = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.tabThuVien_ThuThu = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.tabSach = new Telerik.WinControls.UI.RibbonTab();
            this.tabSach_NhapSach = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.tabSach_ThongTinSach = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.tabMuonTraSach = new Telerik.WinControls.UI.RibbonTab();
            this.tabMuonSach = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.tabTraSach = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.tabDocGia = new Telerik.WinControls.UI.RibbonTab();
            this.tabDocGia_QLDocGia = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.tabDocGia_QLTheDocGia = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.tabBaoCao = new Telerik.WinControls.UI.RibbonTab();
            this.tabBaoCao_TinhHinhMuonSach = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.tabBaoCao_SachTraTre = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButtonElement10 = new Telerik.WinControls.UI.RadButtonElement();
            this.btnDangXuat = new Telerik.WinControls.UI.RadButtonElement();
            this.btnQuyDinh = new Telerik.WinControls.UI.RadButtonElement();
            this.btnThuThu = new Telerik.WinControls.UI.RadButtonElement();
            this.btnQLCuonSach = new Telerik.WinControls.UI.RadButtonElement();
            this.btnQLDauSach = new Telerik.WinControls.UI.RadButtonElement();
            this.btnMuon = new Telerik.WinControls.UI.RadButtonElement();
            this.btnTraSach = new Telerik.WinControls.UI.RadButtonElement();
            this.btnQLPhieuTienPhat = new Telerik.WinControls.UI.RadButtonElement();
            this.btnQlSachChuaTra = new Telerik.WinControls.UI.RadButtonElement();
            this.btnDocGia = new Telerik.WinControls.UI.RadButtonElement();
            this.btnTheDocGia = new Telerik.WinControls.UI.RadButtonElement();
            this.btnBaocaoSachTraTre = new Telerik.WinControls.UI.RadButtonElement();
            this.btnTinhHinhmuonSach = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabThuVien,
            this.tabSach,
            this.tabMuonTraSach,
            this.tabDocGia,
            this.tabBaoCao});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.Size = new System.Drawing.Size(1032, 182);
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuSeparatorItem1,
            this.radMenuItem1});
            this.radRibbonBar1.StartMenuRightColumnItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem2});
            this.radRibbonBar1.TabIndex = 0;
            // 
            // tabThuVien
            // 
            this.tabThuVien.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabThuVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.tabThuVien.IsSelected = true;
            this.tabThuVien.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabThuVien_GioiThieu,
            this.radRibbonBarGroup1,
            this.tabThuVien_ThuThu});
            this.tabThuVien.Name = "tabThuVien";
            this.tabThuVien.Text = "Thư Viện";
            this.tabThuVien.UseMnemonic = false;
            this.tabThuVien.ZIndex = 0;
            this.tabThuVien.Click += new System.EventHandler(this.tabThuVien_Click);
            // 
            // tabThuVien_GioiThieu
            // 
            this.tabThuVien_GioiThieu.AutoSize = false;
            this.tabThuVien_GioiThieu.BorderHighlightColor = System.Drawing.Color.WhiteSmoke;
            this.tabThuVien_GioiThieu.Bounds = new System.Drawing.Rectangle(0, 0, 92, 100);
            this.tabThuVien_GioiThieu.EnableBorderHighlight = true;
            this.tabThuVien_GioiThieu.EnableElementShadow = false;
            this.tabThuVien_GioiThieu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabThuVien_GioiThieu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnDangXuat});
            this.tabThuVien_GioiThieu.Name = "tabThuVien_GioiThieu";
            this.tabThuVien_GioiThieu.Text = "Thoát";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(204)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlassRect;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(2))).RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_GioiThieu.GetChildAt(2))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AutoSize = false;
            this.radRibbonBarGroup1.Bounds = new System.Drawing.Rectangle(0, 0, 115, 100);
            this.radRibbonBarGroup1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnQuyDinh});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Quy định";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).GradientAngle = 91F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.2714286F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 1F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(207)))), ((int)(((byte)(53)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(198)))), ((int)(((byte)(246)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.3632653F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 1F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup1.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // tabThuVien_ThuThu
            // 
            this.tabThuVien_ThuThu.AutoSize = false;
            this.tabThuVien_ThuThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(110)))), ((int)(((byte)(242)))));
            this.tabThuVien_ThuThu.BorderHighlightColor = System.Drawing.Color.WhiteSmoke;
            this.tabThuVien_ThuThu.BorderHighlightThickness = 10;
            this.tabThuVien_ThuThu.Bounds = new System.Drawing.Rectangle(0, 0, 123, 100);
            this.tabThuVien_ThuThu.EnableBorderHighlight = false;
            this.tabThuVien_ThuThu.EnableElementShadow = false;
            this.tabThuVien_ThuThu.EnableFocusBorder = false;
            this.tabThuVien_ThuThu.EnableFocusBorderAnimation = false;
            this.tabThuVien_ThuThu.EnableHighlight = false;
            this.tabThuVien_ThuThu.EnableRippleAnimation = false;
            this.tabThuVien_ThuThu.FlipText = false;
            this.tabThuVien_ThuThu.FocusBorderColor = System.Drawing.Color.Red;
            this.tabThuVien_ThuThu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabThuVien_ThuThu.HighlightColor = System.Drawing.Color.Silver;
            this.tabThuVien_ThuThu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnThuThu});
            this.tabThuVien_ThuThu.Name = "tabThuVien_ThuThu";
            this.tabThuVien_ThuThu.RippleAnimationColor = System.Drawing.Color.Red;
            this.tabThuVien_ThuThu.ShadowColor = System.Drawing.Color.White;
            this.tabThuVien_ThuThu.ShadowDepth = 5;
            this.tabThuVien_ThuThu.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.tabThuVien_ThuThu.StretchHorizontally = true;
            this.tabThuVien_ThuThu.Text = "Thủ thư";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(204)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlassRect;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabThuVien_ThuThu.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_ThuThu.GetChildAt(2))).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_ThuThu.GetChildAt(2))).BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_ThuThu.GetChildAt(2))).LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_ThuThu.GetChildAt(2))).BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_ThuThu.GetChildAt(2))).BottomShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(251)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_ThuThu.GetChildAt(2))).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_ThuThu.GetChildAt(2))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.tabThuVien_ThuThu.GetChildAt(2))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            // 
            // tabSach
            // 
            this.tabSach.AutoSize = false;
            this.tabSach.Bounds = new System.Drawing.Rectangle(0, 0, 56, 35);
            this.tabSach.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.tabSach.IsSelected = false;
            this.tabSach.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabSach_NhapSach,
            this.tabSach_ThongTinSach});
            this.tabSach.Name = "tabSach";
            this.tabSach.Text = "Sách";
            this.tabSach.UseMnemonic = false;
            this.tabSach.Click += new System.EventHandler(this.tabSach_Click);
            // 
            // tabSach_NhapSach
            // 
            this.tabSach_NhapSach.AutoSize = false;
            this.tabSach_NhapSach.BorderHighlightColor = System.Drawing.Color.White;
            this.tabSach_NhapSach.Bounds = new System.Drawing.Rectangle(0, 0, 113, 100);
            this.tabSach_NhapSach.EnableBorderHighlight = false;
            this.tabSach_NhapSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabSach_NhapSach.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnQLCuonSach});
            this.tabSach_NhapSach.Name = "tabSach_NhapSach";
            this.tabSach_NhapSach.Text = "QL Cuốn sách";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(204)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlassRect;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_NhapSach.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // tabSach_ThongTinSach
            // 
            this.tabSach_ThongTinSach.AutoSize = false;
            this.tabSach_ThongTinSach.BorderHighlightColor = System.Drawing.Color.White;
            this.tabSach_ThongTinSach.Bounds = new System.Drawing.Rectangle(0, 0, 121, 100);
            this.tabSach_ThongTinSach.EnableBorderHighlight = true;
            this.tabSach_ThongTinSach.EnableElementShadow = true;
            this.tabSach_ThongTinSach.EnableFocusBorder = true;
            this.tabSach_ThongTinSach.FocusBorderColor = System.Drawing.Color.Black;
            this.tabSach_ThongTinSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabSach_ThongTinSach.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnQLDauSach});
            this.tabSach_ThongTinSach.Name = "tabSach_ThongTinSach";
            this.tabSach_ThongTinSach.Opacity = 1D;
            this.tabSach_ThongTinSach.ShouldPaint = true;
            this.tabSach_ThongTinSach.Text = "QL đầu sách";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(204)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlassRect;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabSach_ThongTinSach.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // tabMuonTraSach
            // 
            this.tabMuonTraSach.AutoSize = false;
            this.tabMuonTraSach.Bounds = new System.Drawing.Rectangle(0, 0, 145, 35);
            this.tabMuonTraSach.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabMuonTraSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.tabMuonTraSach.IsSelected = false;
            this.tabMuonTraSach.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabMuonSach,
            this.tabTraSach,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3});
            this.tabMuonTraSach.Name = "tabMuonTraSach";
            this.tabMuonTraSach.Text = "Mượn - Trả sách";
            this.tabMuonTraSach.UseMnemonic = false;
            this.tabMuonTraSach.Click += new System.EventHandler(this.tabMuonTraSach_Click);
            // 
            // tabMuonSach
            // 
            this.tabMuonSach.AutoSize = false;
            this.tabMuonSach.BorderHighlightColor = System.Drawing.Color.White;
            this.tabMuonSach.Bounds = new System.Drawing.Rectangle(0, 0, 125, 100);
            this.tabMuonSach.EnableBorderHighlight = false;
            this.tabMuonSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabMuonSach.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnMuon});
            this.tabMuonSach.Name = "tabMuonSach";
            this.tabMuonSach.Text = "Mượn sách";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(204)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlassRect;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabMuonSach.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // tabTraSach
            // 
            this.tabTraSach.AutoSize = false;
            this.tabTraSach.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.tabTraSach.BorderHighlightColor = System.Drawing.Color.Red;
            this.tabTraSach.Bounds = new System.Drawing.Rectangle(0, 0, 120, 100);
            this.tabTraSach.ClipDrawing = false;
            this.tabTraSach.CustomFontStyle = System.Drawing.FontStyle.Regular;
            this.tabTraSach.EnableBorderHighlight = false;
            this.tabTraSach.EnableElementShadow = false;
            this.tabTraSach.EnableFocusBorder = false;
            this.tabTraSach.EnableFocusBorderAnimation = false;
            this.tabTraSach.EnableHighlight = false;
            this.tabTraSach.EnableRippleAnimation = false;
            this.tabTraSach.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.tabTraSach.FocusBorderColor = System.Drawing.Color.Red;
            this.tabTraSach.FocusBorderWidth = 10;
            this.tabTraSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabTraSach.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnTraSach});
            this.tabTraSach.Name = "tabTraSach";
            this.tabTraSach.Text = "Trả sách";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(204)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlassRect;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabTraSach.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.AutoSize = false;
            this.radRibbonBarGroup2.Bounds = new System.Drawing.Rectangle(0, 0, 133, 100);
            this.radRibbonBarGroup2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnQLPhieuTienPhat});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "QL Phiếu tiền phạt";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(74)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).GradientAngle = 89F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(63)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(215)))), ((int)(((byte)(245)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.2285714F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 1F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup2.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnQlSachChuaTra});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "QL sách chưa trả";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).GradientAngle = 89F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(216)))), ((int)(((byte)(80)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radRibbonBarGroup3.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // tabDocGia
            // 
            this.tabDocGia.AutoSize = false;
            this.tabDocGia.BorderRightShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(244)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tabDocGia.Bounds = new System.Drawing.Rectangle(0, 0, 79, 35);
            this.tabDocGia.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabDocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.tabDocGia.IsSelected = false;
            this.tabDocGia.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabDocGia_QLDocGia,
            this.tabDocGia_QLTheDocGia});
            this.tabDocGia.Name = "tabDocGia";
            this.tabDocGia.Text = "Độc giả";
            this.tabDocGia.UseMnemonic = false;
            this.tabDocGia.Click += new System.EventHandler(this.tabDocGia_Click);
            // 
            // tabDocGia_QLDocGia
            // 
            this.tabDocGia_QLDocGia.AutoSize = false;
            this.tabDocGia_QLDocGia.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.tabDocGia_QLDocGia.BorderHighlightColor = System.Drawing.Color.White;
            this.tabDocGia_QLDocGia.Bounds = new System.Drawing.Rectangle(0, 0, 115, 93);
            this.tabDocGia_QLDocGia.EnableBorderHighlight = false;
            this.tabDocGia_QLDocGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabDocGia_QLDocGia.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnDocGia});
            this.tabDocGia_QLDocGia.Name = "tabDocGia_QLDocGia";
            this.tabDocGia_QLDocGia.Text = "QL Độc giả";
            this.tabDocGia_QLDocGia.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(204)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.SystemColors.ControlLightLight;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.OfficeGlassRect;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.5F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 0.666F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLDocGia.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // tabDocGia_QLTheDocGia
            // 
            this.tabDocGia_QLTheDocGia.AutoSize = false;
            this.tabDocGia_QLTheDocGia.BorderHighlightColor = System.Drawing.Color.White;
            this.tabDocGia_QLTheDocGia.Bounds = new System.Drawing.Rectangle(0, 0, 110, 93);
            this.tabDocGia_QLTheDocGia.EnableBorderHighlight = false;
            this.tabDocGia_QLTheDocGia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabDocGia_QLTheDocGia.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnTheDocGia});
            this.tabDocGia_QLTheDocGia.Name = "tabDocGia_QLTheDocGia";
            this.tabDocGia_QLTheDocGia.Text = "QL Thẻ độc giả";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).GradientAngle = 91F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(191)))), ((int)(((byte)(239)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.1510204F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 1F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabDocGia_QLTheDocGia.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabBaoCao.IsSelected = false;
            this.tabBaoCao.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.tabBaoCao_TinhHinhMuonSach,
            this.tabBaoCao_SachTraTre});
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Text = "Báo cáo";
            this.tabBaoCao.UseMnemonic = false;
            this.tabBaoCao.Click += new System.EventHandler(this.tabBaoCao_Click);
            // 
            // tabBaoCao_TinhHinhMuonSach
            // 
            this.tabBaoCao_TinhHinhMuonSach.AutoSize = false;
            this.tabBaoCao_TinhHinhMuonSach.BorderHighlightColor = System.Drawing.Color.White;
            this.tabBaoCao_TinhHinhMuonSach.Bounds = new System.Drawing.Rectangle(0, 0, 126, 97);
            this.tabBaoCao_TinhHinhMuonSach.EnableBorderHighlight = false;
            this.tabBaoCao_TinhHinhMuonSach.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabBaoCao_TinhHinhMuonSach.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement2,
            this.btnBaocaoSachTraTre});
            this.tabBaoCao_TinhHinhMuonSach.Name = "tabBaoCao_TinhHinhMuonSach";
            this.tabBaoCao_TinhHinhMuonSach.Text = "TK Sách trả trễ";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(194)))), ((int)(((byte)(239)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.4122449F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 1F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(3))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(3))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(3))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(3))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(3))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(3))).GradientPercentage = 0.2612245F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(3))).GradientPercentage2 = 1F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_TinhHinhMuonSach.GetChildAt(3))).BackColor = System.Drawing.SystemColors.Control;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AutoSize = false;
            this.radButtonElement2.Bounds = new System.Drawing.Rectangle(0, 0, 2, 67);
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.Text = "";
            // 
            // tabBaoCao_SachTraTre
            // 
            this.tabBaoCao_SachTraTre.AutoSize = false;
            this.tabBaoCao_SachTraTre.BorderHighlightColor = System.Drawing.Color.White;
            this.tabBaoCao_SachTraTre.Bounds = new System.Drawing.Rectangle(0, 0, 149, 96);
            this.tabBaoCao_SachTraTre.EnableBorderHighlight = false;
            this.tabBaoCao_SachTraTre.EnableFocusBorderAnimation = false;
            this.tabBaoCao_SachTraTre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabBaoCao_SachTraTre.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnTinhHinhmuonSach});
            this.tabBaoCao_SachTraTre.Name = "tabBaoCao_SachTraTre";
            this.tabBaoCao_SachTraTre.Text = "TK Tình hình mượn sách";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(154)))), ((int)(((byte)(34)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(98)))), ((int)(((byte)(19)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(224)))), ((int)(((byte)(156)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).GradientPercentage = 0.2653061F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).GradientPercentage2 = 1F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(3))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(3))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(3))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(3))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(3))).GradientAngle = 90F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(3))).GradientPercentage = 0.15F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(3))).GradientPercentage2 = 0.7F;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.tabBaoCao_SachTraTre.GetChildAt(3))).BackColor = System.Drawing.Color.Transparent;
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "radMenuItem1";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "radMenuItem2";
            // 
            // radPanel1
            // 
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 182);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1032, 408);
            this.radPanel1.TabIndex = 1;
            // 
            // radButtonElement10
            // 
            this.radButtonElement10.AutoSize = false;
            this.radButtonElement10.Bounds = new System.Drawing.Rectangle(0, 0, 113, 74);
            this.radButtonElement10.Name = "radButtonElement10";
            this.radButtonElement10.Text = "";
            this.radButtonElement10.UseCompatibleTextRendering = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = false;
            this.btnDangXuat.Bounds = new System.Drawing.Rectangle(0, 0, 89, 72);
            this.btnDangXuat.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.Log_Out_icon;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Text = "";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuyDinh
            // 
            this.btnQuyDinh.AutoSize = false;
            this.btnQuyDinh.Bounds = new System.Drawing.Rectangle(0, 0, 105, 70);
            this.btnQuyDinh.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.Gavel_Law_icon;
            this.btnQuyDinh.Name = "btnQuyDinh";
            this.btnQuyDinh.Text = "";
            this.btnQuyDinh.Click += new System.EventHandler(this.btnQuyDinh_Click);
            // 
            // btnThuThu
            // 
            this.btnThuThu.AutoSize = false;
            this.btnThuThu.Bounds = new System.Drawing.Rectangle(0, 0, 117, 72);
            this.btnThuThu.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.Teacher_icon;
            this.btnThuThu.Name = "btnThuThu";
            this.btnThuThu.Text = "";
            this.btnThuThu.Click += new System.EventHandler(this.btnThuThu_Click);
            // 
            // btnQLCuonSach
            // 
            this.btnQLCuonSach.AutoSize = false;
            this.btnQLCuonSach.Bounds = new System.Drawing.Rectangle(0, 0, 104, 67);
            this.btnQLCuonSach.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.book_icon_Copy;
            this.btnQLCuonSach.Name = "btnQLCuonSach";
            this.btnQLCuonSach.RightToLeft = false;
            this.btnQLCuonSach.Text = "";
            this.btnQLCuonSach.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnQLCuonSach.Click += new System.EventHandler(this.btnQLCuonSach_Click);
            // 
            // btnQLDauSach
            // 
            this.btnQLDauSach.AutoSize = false;
            this.btnQLDauSach.Bounds = new System.Drawing.Rectangle(0, 0, 115, 68);
            this.btnQLDauSach.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.artage_io_thumb_0d4096e23497379994a843ea6c2389a4;
            this.btnQLDauSach.Name = "btnQLDauSach";
            this.btnQLDauSach.Text = "";
            this.btnQLDauSach.Click += new System.EventHandler(this.btnQLDauSach_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.AutoSize = false;
            this.btnMuon.Bounds = new System.Drawing.Rectangle(0, 0, 116, 66);
            this.btnMuon.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources._28;
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Text = "";
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.AutoSize = false;
            this.btnTraSach.Bounds = new System.Drawing.Rectangle(0, 0, 114, 70);
            this.btnTraSach.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.anh;
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Text = "";
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnQLPhieuTienPhat
            // 
            this.btnQLPhieuTienPhat.AutoSize = false;
            this.btnQLPhieuTienPhat.Bounds = new System.Drawing.Rectangle(0, 0, 126, 70);
            this.btnQLPhieuTienPhat.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.custom_reports_icon;
            this.btnQLPhieuTienPhat.Name = "btnQLPhieuTienPhat";
            this.btnQLPhieuTienPhat.Text = "";
            this.btnQLPhieuTienPhat.Click += new System.EventHandler(this.btnQLPhieuTienPhat_Click);
            // 
            // btnQlSachChuaTra
            // 
            this.btnQlSachChuaTra.AutoSize = false;
            this.btnQlSachChuaTra.Bounds = new System.Drawing.Rectangle(0, 0, 112, 70);
            this.btnQlSachChuaTra.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.books_2462293_960_7203;
            this.btnQlSachChuaTra.Name = "btnQlSachChuaTra";
            this.btnQlSachChuaTra.Text = "";
            this.btnQlSachChuaTra.Click += new System.EventHandler(this.btnQlSachChuaTra_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.AutoSize = false;
            this.btnDocGia.Bounds = new System.Drawing.Rectangle(0, 0, 108, 63);
            this.btnDocGia.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.engineer_icon;
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Text = "";
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnTheDocGia
            // 
            this.btnTheDocGia.AutoSize = false;
            this.btnTheDocGia.Bounds = new System.Drawing.Rectangle(0, 0, 101, 63);
            this.btnTheDocGia.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.Student_id_icon;
            this.btnTheDocGia.Name = "btnTheDocGia";
            this.btnTheDocGia.Text = "";
            this.btnTheDocGia.Click += new System.EventHandler(this.btnTheDocGia_Click);
            // 
            // btnBaocaoSachTraTre
            // 
            this.btnBaocaoSachTraTre.AutoSize = false;
            this.btnBaocaoSachTraTre.Bounds = new System.Drawing.Rectangle(0, 0, 115, 67);
            this.btnBaocaoSachTraTre.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.Balance_icon;
            this.btnBaocaoSachTraTre.Name = "btnBaocaoSachTraTre";
            this.btnBaocaoSachTraTre.Text = "";
            this.btnBaocaoSachTraTre.Click += new System.EventHandler(this.btnBaocaoSachTraTre_Click);
            // 
            // btnTinhHinhmuonSach
            // 
            this.btnTinhHinhmuonSach.AutoSize = false;
            this.btnTinhHinhmuonSach.Bounds = new System.Drawing.Rectangle(0, 0, 142, 66);
            this.btnTinhHinhmuonSach.Image = global::DoAnNMCNPM_QuanLyThuVien.Properties.Resources.reports_icon;
            this.btnTinhHinhmuonSach.Name = "btnTinhHinhmuonSach";
            this.btnTinhHinhmuonSach.Text = "";
            this.btnTinhHinhmuonSach.Click += new System.EventHandler(this.btnTinhHinhmuonSach_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 590);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radRibbonBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RibbonTab tabThuVien;
        private Telerik.WinControls.UI.RibbonTab tabSach;
        private Telerik.WinControls.UI.RibbonTab tabMuonTraSach;
        private Telerik.WinControls.UI.RibbonTab tabDocGia;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabThuVien_GioiThieu;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabSach_NhapSach;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabMuonSach;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabTraSach;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabDocGia_QLDocGia;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabThuVien_ThuThu;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabSach_ThongTinSach;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabDocGia_QLTheDocGia;
        private Telerik.WinControls.UI.RibbonTab tabBaoCao;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabBaoCao_TinhHinhMuonSach;
        private Telerik.WinControls.UI.RadRibbonBarGroup tabBaoCao_SachTraTre;
        private Telerik.WinControls.UI.RadButtonElement btnThuThu;
        private Telerik.WinControls.UI.RadButtonElement btnQLCuonSach;
        private Telerik.WinControls.UI.RadButtonElement btnQLDauSach;
        private Telerik.WinControls.UI.RadButtonElement btnMuon;
        private Telerik.WinControls.UI.RadButtonElement btnDocGia;
        private Telerik.WinControls.UI.RadButtonElement btnTheDocGia;
        private Telerik.WinControls.UI.RadButtonElement btnDangXuat;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement10;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadButtonElement btnQuyDinh;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadButtonElement btnQLPhieuTienPhat;
        private Telerik.WinControls.UI.RadButtonElement btnTraSach;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement btnBaocaoSachTraTre;
        private Telerik.WinControls.UI.RadButtonElement btnTinhHinhmuonSach;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement btnQlSachChuaTra;
    }
}