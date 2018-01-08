namespace QLNT.Presentation
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbonPanel4 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribonQLChung = new DevComponents.DotNetBar.RibbonBar();
            this.btnQLChung_Lop = new DevComponents.DotNetBar.ButtonItem();
            this.ribonQLTK = new DevComponents.DotNetBar.RibbonBar();
            this.btnThongTin_TaiKhoan = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuat = new DevComponents.DotNetBar.ButtonItem();
            this.ribonQLHP = new DevComponents.DotNetBar.RibbonBar();
            this.btnDanhMucChiPhi = new DevComponents.DotNetBar.ButtonItem();
            this.btnApDungHocPhi = new DevComponents.DotNetBar.ButtonItem();
            this.btnThuHocPhi = new DevComponents.DotNetBar.ButtonItem();
            this.ribonQLDD = new DevComponents.DotNetBar.RibbonBar();
            this.btnNguyenLieu = new DevComponents.DotNetBar.ButtonItem();
            this.btnMonAn = new DevComponents.DotNetBar.ButtonItem();
            this.btnApDung = new DevComponents.DotNetBar.ButtonItem();
            this.ribonQLSK = new DevComponents.DotNetBar.RibbonBar();
            this.btnSucKhoe_ThongTin = new DevComponents.DotNetBar.ButtonItem();
            this.btnSucKhoe_BaoCao = new DevComponents.DotNetBar.ButtonItem();
            this.ribonQLTre = new DevComponents.DotNetBar.RibbonBar();
            this.btnTiepNhan = new DevComponents.DotNetBar.ButtonItem();
            this.btnXepLop = new DevComponents.DotNetBar.ButtonItem();
            this.btnDiemDanh = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhieuBeNgoan = new DevComponents.DotNetBar.ButtonItem();
            this.btnTraCuu = new DevComponents.DotNetBar.ButtonItem();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.label = new DevComponents.DotNetBar.LabelItem();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.panel1.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ribbonPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 104);
            this.panel1.TabIndex = 0;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel4.Controls.Add(this.ribonQLChung);
            this.ribbonPanel4.Controls.Add(this.ribonQLTK);
            this.ribbonPanel4.Controls.Add(this.ribonQLHP);
            this.ribbonPanel4.Controls.Add(this.ribonQLDD);
            this.ribbonPanel4.Controls.Add(this.ribonQLSK);
            this.ribbonPanel4.Controls.Add(this.ribonQLTre);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(1197, 104);
            this.ribbonPanel4.TabIndex = 5;
            // 
            // ribonQLChung
            // 
            this.ribonQLChung.AutoOverflowEnabled = true;
            this.ribonQLChung.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribonQLChung.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQLChung_Lop});
            this.ribonQLChung.Location = new System.Drawing.Point(906, 0);
            this.ribonQLChung.Name = "ribonQLChung";
            this.ribonQLChung.Size = new System.Drawing.Size(106, 101);
            this.ribonQLChung.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribonQLChung.TabIndex = 5;
            this.ribonQLChung.Text = "Quản lý chung";
            // 
            // btnQLChung_Lop
            // 
            this.btnQLChung_Lop.Image = global::QLNT.Properties.Resources.thongtin;
            this.btnQLChung_Lop.ImagePaddingHorizontal = 8;
            this.btnQLChung_Lop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnQLChung_Lop.Name = "btnQLChung_Lop";
            this.btnQLChung_Lop.SubItemsExpandWidth = 14;
            this.btnQLChung_Lop.Text = "Lớp - Niên khóa";
            this.btnQLChung_Lop.Click += new System.EventHandler(this.btnQLChung_Lop_Click);
            // 
            // ribonQLTK
            // 
            this.ribonQLTK.AutoOverflowEnabled = true;
            this.ribonQLTK.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribonQLTK.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThongTin_TaiKhoan,
            this.btnDangXuat});
            this.ribonQLTK.Location = new System.Drawing.Point(800, 0);
            this.ribonQLTK.Name = "ribonQLTK";
            this.ribonQLTK.Size = new System.Drawing.Size(106, 101);
            this.ribonQLTK.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribonQLTK.TabIndex = 4;
            this.ribonQLTK.Text = "Tài khoản";
            // 
            // btnThongTin_TaiKhoan
            // 
            this.btnThongTin_TaiKhoan.Image = global::QLNT.Properties.Resources.thongtin;
            this.btnThongTin_TaiKhoan.ImagePaddingHorizontal = 8;
            this.btnThongTin_TaiKhoan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThongTin_TaiKhoan.Name = "btnThongTin_TaiKhoan";
            this.btnThongTin_TaiKhoan.SubItemsExpandWidth = 14;
            this.btnThongTin_TaiKhoan.Text = "Thông tin";
            this.btnThongTin_TaiKhoan.Click += new System.EventHandler(this.btnThongTin_TaiKhoan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = global::QLNT.Properties.Resources.dangxuat;
            this.btnDangXuat.ImagePaddingHorizontal = 8;
            this.btnDangXuat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.SubItemsExpandWidth = 14;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // ribonQLHP
            // 
            this.ribonQLHP.AutoOverflowEnabled = true;
            this.ribonQLHP.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribonQLHP.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDanhMucChiPhi,
            this.btnApDungHocPhi,
            this.btnThuHocPhi});
            this.ribonQLHP.Location = new System.Drawing.Point(608, 0);
            this.ribonQLHP.Name = "ribonQLHP";
            this.ribonQLHP.Size = new System.Drawing.Size(192, 101);
            this.ribonQLHP.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribonQLHP.TabIndex = 3;
            this.ribonQLHP.Text = "Quản lý học phí";
            // 
            // btnDanhMucChiPhi
            // 
            this.btnDanhMucChiPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucChiPhi.Image")));
            this.btnDanhMucChiPhi.ImagePaddingHorizontal = 8;
            this.btnDanhMucChiPhi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanhMucChiPhi.Name = "btnDanhMucChiPhi";
            this.btnDanhMucChiPhi.SubItemsExpandWidth = 14;
            this.btnDanhMucChiPhi.Text = "Danh mục chi phí";
            this.btnDanhMucChiPhi.Click += new System.EventHandler(this.btnDanhMucChiPhi_Click);
            // 
            // btnApDungHocPhi
            // 
            this.btnApDungHocPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnApDungHocPhi.Image")));
            this.btnApDungHocPhi.ImagePaddingHorizontal = 8;
            this.btnApDungHocPhi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnApDungHocPhi.Name = "btnApDungHocPhi";
            this.btnApDungHocPhi.SubItemsExpandWidth = 14;
            this.btnApDungHocPhi.Text = "Áp dụng học phí";
            this.btnApDungHocPhi.Click += new System.EventHandler(this.btnApDungHocPhi_Click);
            // 
            // btnThuHocPhi
            // 
            this.btnThuHocPhi.Image = ((System.Drawing.Image)(resources.GetObject("btnThuHocPhi.Image")));
            this.btnThuHocPhi.ImagePaddingHorizontal = 8;
            this.btnThuHocPhi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThuHocPhi.Name = "btnThuHocPhi";
            this.btnThuHocPhi.SubItemsExpandWidth = 14;
            this.btnThuHocPhi.Text = "Thu học phí";
            this.btnThuHocPhi.Click += new System.EventHandler(this.btnThuHocPhi_Click);
            // 
            // ribonQLDD
            // 
            this.ribonQLDD.AutoOverflowEnabled = true;
            this.ribonQLDD.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribonQLDD.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNguyenLieu,
            this.btnMonAn,
            this.btnApDung});
            this.ribonQLDD.Location = new System.Drawing.Point(398, 0);
            this.ribonQLDD.Name = "ribonQLDD";
            this.ribonQLDD.Size = new System.Drawing.Size(210, 101);
            this.ribonQLDD.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribonQLDD.TabIndex = 2;
            this.ribonQLDD.Text = "Quản lý dinh dưỡng";
            // 
            // btnNguyenLieu
            // 
            this.btnNguyenLieu.Image = ((System.Drawing.Image)(resources.GetObject("btnNguyenLieu.Image")));
            this.btnNguyenLieu.ImagePaddingHorizontal = 8;
            this.btnNguyenLieu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNguyenLieu.Name = "btnNguyenLieu";
            this.btnNguyenLieu.SubItemsExpandWidth = 14;
            this.btnNguyenLieu.Text = "Nguyên liệu";
            this.btnNguyenLieu.Click += new System.EventHandler(this.btnNguyenLieu_Click);
            // 
            // btnMonAn
            // 
            this.btnMonAn.Image = ((System.Drawing.Image)(resources.GetObject("btnMonAn.Image")));
            this.btnMonAn.ImagePaddingHorizontal = 8;
            this.btnMonAn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMonAn.Name = "btnMonAn";
            this.btnMonAn.SubItemsExpandWidth = 14;
            this.btnMonAn.Text = "Món ăn";
            this.btnMonAn.Click += new System.EventHandler(this.btnMonAn_Click);
            // 
            // btnApDung
            // 
            this.btnApDung.Image = ((System.Drawing.Image)(resources.GetObject("btnApDung.Image")));
            this.btnApDung.ImagePaddingHorizontal = 8;
            this.btnApDung.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnApDung.Name = "btnApDung";
            this.btnApDung.SubItemsExpandWidth = 14;
            this.btnApDung.Text = "Thực đơn";
            this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
            // 
            // ribonQLSK
            // 
            this.ribonQLSK.AutoOverflowEnabled = true;
            this.ribonQLSK.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribonQLSK.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSucKhoe_ThongTin,
            this.btnSucKhoe_BaoCao});
            this.ribonQLSK.Location = new System.Drawing.Point(274, 0);
            this.ribonQLSK.Name = "ribonQLSK";
            this.ribonQLSK.Size = new System.Drawing.Size(124, 101);
            this.ribonQLSK.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribonQLSK.TabIndex = 1;
            this.ribonQLSK.Text = "Quản lý sức khỏe";
            // 
            // btnSucKhoe_ThongTin
            // 
            this.btnSucKhoe_ThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnSucKhoe_ThongTin.Image")));
            this.btnSucKhoe_ThongTin.ImagePaddingHorizontal = 8;
            this.btnSucKhoe_ThongTin.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSucKhoe_ThongTin.Name = "btnSucKhoe_ThongTin";
            this.btnSucKhoe_ThongTin.SubItemsExpandWidth = 14;
            this.btnSucKhoe_ThongTin.Text = "Thông tin";
            this.btnSucKhoe_ThongTin.Click += new System.EventHandler(this.btnSucKhoe_ThongTin_Click);
            // 
            // btnSucKhoe_BaoCao
            // 
            this.btnSucKhoe_BaoCao.Image = global::QLNT.Properties.Resources.baocao;
            this.btnSucKhoe_BaoCao.ImagePaddingHorizontal = 8;
            this.btnSucKhoe_BaoCao.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSucKhoe_BaoCao.Name = "btnSucKhoe_BaoCao";
            this.btnSucKhoe_BaoCao.SubItemsExpandWidth = 14;
            this.btnSucKhoe_BaoCao.Text = "Báo cáo";
            this.btnSucKhoe_BaoCao.Click += new System.EventHandler(this.btnSucKhoe_BaoCao_Click);
            // 
            // ribonQLTre
            // 
            this.ribonQLTre.AutoOverflowEnabled = true;
            this.ribonQLTre.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribonQLTre.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTiepNhan,
            this.btnXepLop,
            this.btnDiemDanh,
            this.btnPhieuBeNgoan,
            this.btnTraCuu});
            this.ribonQLTre.Location = new System.Drawing.Point(3, 0);
            this.ribonQLTre.Name = "ribonQLTre";
            this.ribonQLTre.Size = new System.Drawing.Size(271, 101);
            this.ribonQLTre.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribonQLTre.TabIndex = 0;
            this.ribonQLTre.Text = "Quản lý trẻ";
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Image = global::QLNT.Properties.Resources.ThemTre;
            this.btnTiepNhan.ImagePaddingHorizontal = 8;
            this.btnTiepNhan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.SubItemsExpandWidth = 14;
            this.btnTiepNhan.Text = "Tiếp nhận";
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // btnXepLop
            // 
            this.btnXepLop.Image = global::QLNT.Properties.Resources.xeplop;
            this.btnXepLop.ImagePaddingHorizontal = 8;
            this.btnXepLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXepLop.Name = "btnXepLop";
            this.btnXepLop.SubItemsExpandWidth = 14;
            this.btnXepLop.Text = "Xếp lớp";
            this.btnXepLop.Click += new System.EventHandler(this.btnXepLop_Click);
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Image = ((System.Drawing.Image)(resources.GetObject("btnDiemDanh.Image")));
            this.btnDiemDanh.ImagePaddingHorizontal = 8;
            this.btnDiemDanh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.SubItemsExpandWidth = 14;
            this.btnDiemDanh.Text = "Điểm danh";
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // btnPhieuBeNgoan
            // 
            this.btnPhieuBeNgoan.Image = global::QLNT.Properties.Resources.phieubengoan;
            this.btnPhieuBeNgoan.ImagePaddingHorizontal = 8;
            this.btnPhieuBeNgoan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhieuBeNgoan.Name = "btnPhieuBeNgoan";
            this.btnPhieuBeNgoan.SubItemsExpandWidth = 14;
            this.btnPhieuBeNgoan.Text = "Phiếu bé ngoan";
            this.btnPhieuBeNgoan.Click += new System.EventHandler(this.btnPhieuBeNgoan_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImagePaddingHorizontal = 8;
            this.btnTraCuu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.SubItemsExpandWidth = 14;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // tabControl
            // 
            this.tabControl.AutoCloseTabs = true;
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.CloseButtonOnTabsVisible = true;
            this.tabControl.CloseButtonVisible = true;
            this.tabControl.Controls.Add(this.tabControlPanel1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 104);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1197, 605);
            this.tabControl.TabIndex = 2;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItem1);
            this.tabControl.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.pictureBox1);
            this.tabControlPanel1.Controls.Add(this.bar1);
            this.tabControlPanel1.Controls.Add(this.reflectionLabel1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1197, 579);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = -90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QLNT.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(1, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1195, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.label});
            this.bar1.Location = new System.Drawing.Point(1, 1);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1195, 19);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.bar1.TabIndex = 3;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // label
            // 
            this.label.Name = "label";
            this.label.Text = "Today : ";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.reflectionLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reflectionLabel1.Location = new System.Drawing.Point(1, 529);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(1195, 49);
            this.reflectionLabel1.TabIndex = 2;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Group 3 </i><font color=\"#B02B2C\"> Quản lý mầm non</font></" +
    "font></b>";
            this.reflectionLabel1.Click += new System.EventHandler(this.reflectionLabel1_Click);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(213)))));
            this.tabItem1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(105)))));
            this.tabItem1.CloseButtonVisible = false;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Yellow;
            this.tabItem1.Text = "Trang chính";
            this.tabItem1.TextColor = System.Drawing.Color.Black;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImagePaddingHorizontal = 8;
            this.btnTimKiem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.SubItemsExpandWidth = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 709);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Quản lý mầm non";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ribbonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonBar ribonQLDD;
        private DevComponents.DotNetBar.RibbonBar ribonQLSK;
        private DevComponents.DotNetBar.ButtonItem btnSucKhoe_ThongTin;
        private DevComponents.DotNetBar.RibbonBar ribonQLTre;
        private DevComponents.DotNetBar.ButtonItem btnTiepNhan;
        private DevComponents.DotNetBar.RibbonBar ribonQLTK;
        private DevComponents.DotNetBar.ButtonItem btnDangXuat;
        private DevComponents.DotNetBar.RibbonBar ribonQLHP;
        private DevComponents.DotNetBar.ButtonItem btnDanhMucChiPhi;
        private DevComponents.DotNetBar.ButtonItem btnDiemDanh;
        private DevComponents.DotNetBar.ButtonItem btnPhieuBeNgoan;
        private DevComponents.DotNetBar.ButtonItem btnXepLop;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem label;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.ButtonItem btnThongTin_TaiKhoan;
        private DevComponents.DotNetBar.ButtonItem btnApDungHocPhi;
        private DevComponents.DotNetBar.ButtonItem btnSucKhoe_BaoCao;
        private DevComponents.DotNetBar.ButtonItem btnTraCuu;
        private DevComponents.DotNetBar.ButtonItem btnTimKiem;
        private DevComponents.DotNetBar.ButtonItem btnMonAn;
        private DevComponents.DotNetBar.ButtonItem btnNguyenLieu;
        private DevComponents.DotNetBar.ButtonItem btnThuHocPhi;
        private DevComponents.DotNetBar.ButtonItem btnApDung;
        private DevComponents.DotNetBar.RibbonBar ribonQLChung;
        private DevComponents.DotNetBar.ButtonItem btnQLChung_Lop;
    }
}