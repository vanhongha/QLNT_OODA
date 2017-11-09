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
            this.ribbonBar7 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar5 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.label = new DevComponents.DotNetBar.LabelItem();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThongTin_TaiKhoan = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangXuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnHocPhi = new DevComponents.DotNetBar.ButtonItem();
            this.btnBaoCao_HocPhi = new DevComponents.DotNetBar.ButtonItem();
            this.btnTemp = new DevComponents.DotNetBar.ButtonItem();
            this.btnSucKhoe_ThongTin = new DevComponents.DotNetBar.ButtonItem();
            this.btnSucKhoe_BaoCao = new DevComponents.DotNetBar.ButtonItem();
            this.btnDiemDanh = new DevComponents.DotNetBar.ButtonItem();
            this.btnTraCuu = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhieuBeNgoan = new DevComponents.DotNetBar.ButtonItem();
            this.btnTiepNhan = new DevComponents.DotNetBar.ButtonItem();
            this.btnXepLop = new DevComponents.DotNetBar.ButtonItem();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.panel1.SuspendLayout();
            this.ribbonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ribbonPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 104);
            this.panel1.TabIndex = 0;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel4.Controls.Add(this.ribbonBar2);
            this.ribbonPanel4.Controls.Add(this.ribbonBar1);
            this.ribbonPanel4.Controls.Add(this.ribbonBar7);
            this.ribbonPanel4.Controls.Add(this.ribbonBar5);
            this.ribbonPanel4.Controls.Add(this.ribbonBar4);
            this.ribbonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel4.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel4.Size = new System.Drawing.Size(1324, 104);
            this.ribbonPanel4.TabIndex = 5;
            // 
            // ribbonBar7
            // 
            this.ribbonBar7.AutoOverflowEnabled = true;
            this.ribbonBar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar7.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnTemp});
            this.ribbonBar7.Location = new System.Drawing.Point(455, 0);
            this.ribbonBar7.Name = "ribbonBar7";
            this.ribbonBar7.Size = new System.Drawing.Size(217, 101);
            this.ribbonBar7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar7.TabIndex = 2;
            this.ribbonBar7.Text = "Quản lý dinh dưỡng";
            // 
            // ribbonBar5
            // 
            this.ribbonBar5.AutoOverflowEnabled = true;
            this.ribbonBar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSucKhoe_ThongTin,
            this.btnSucKhoe_BaoCao});
            this.ribbonBar5.Location = new System.Drawing.Point(331, 0);
            this.ribbonBar5.Name = "ribbonBar5";
            this.ribbonBar5.Size = new System.Drawing.Size(124, 101);
            this.ribbonBar5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar5.TabIndex = 1;
            this.ribbonBar5.Text = "Quản lý sức khỏe";
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDiemDanh,
            this.btnTraCuu,
            this.btnPhieuBeNgoan,
            this.btnTiepNhan,
            this.btnXepLop});
            this.ribbonBar4.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(328, 101);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar4.TabIndex = 0;
            this.ribbonBar4.Text = "Quản lý trẻ";
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHocPhi,
            this.btnBaoCao_HocPhi});
            this.ribbonBar1.Location = new System.Drawing.Point(672, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(119, 101);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 3;
            this.ribbonBar1.Text = "Quản lý học phí";
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThongTin_TaiKhoan,
            this.btnDangXuat});
            this.ribbonBar2.Location = new System.Drawing.Point(791, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(106, 101);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 4;
            this.ribbonBar2.Text = "Tài khoản";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabControlPanel1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 104);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1324, 655);
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
            this.tabControlPanel1.Size = new System.Drawing.Size(1324, 629);
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
            // bar1
            // 
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.label});
            this.bar1.Location = new System.Drawing.Point(1, 1);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1322, 19);
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
            this.reflectionLabel1.Location = new System.Drawing.Point(1, 579);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(1322, 49);
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
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Yellow;
            this.tabItem1.Text = "Trang chính";
            this.tabItem1.TextColor = System.Drawing.Color.Black;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QLNT.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(1, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1322, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnThongTin_TaiKhoan
            // 
            this.btnThongTin_TaiKhoan.Image = global::QLNT.Properties.Resources.thongtin;
            this.btnThongTin_TaiKhoan.ImagePaddingHorizontal = 8;
            this.btnThongTin_TaiKhoan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThongTin_TaiKhoan.Name = "btnThongTin_TaiKhoan";
            this.btnThongTin_TaiKhoan.SubItemsExpandWidth = 14;
            this.btnThongTin_TaiKhoan.Text = "Thông tin";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = global::QLNT.Properties.Resources.dangxuat;
            this.btnDangXuat.ImagePaddingHorizontal = 8;
            this.btnDangXuat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.SubItemsExpandWidth = 14;
            this.btnDangXuat.Text = "Đăng xuất";
            // 
            // btnHocPhi
            // 
            this.btnHocPhi.Image = global::QLNT.Properties.Resources.hocphi;
            this.btnHocPhi.ImagePaddingHorizontal = 8;
            this.btnHocPhi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHocPhi.Name = "btnHocPhi";
            this.btnHocPhi.SubItemsExpandWidth = 14;
            this.btnHocPhi.Text = "Học phí";
            // 
            // btnBaoCao_HocPhi
            // 
            this.btnBaoCao_HocPhi.Image = global::QLNT.Properties.Resources.baocao;
            this.btnBaoCao_HocPhi.ImagePaddingHorizontal = 8;
            this.btnBaoCao_HocPhi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBaoCao_HocPhi.Name = "btnBaoCao_HocPhi";
            this.btnBaoCao_HocPhi.SubItemsExpandWidth = 14;
            this.btnBaoCao_HocPhi.Text = "Báo cáo";
            // 
            // btnTemp
            // 
            this.btnTemp.Image = ((System.Drawing.Image)(resources.GetObject("btnTemp.Image")));
            this.btnTemp.ImagePaddingHorizontal = 8;
            this.btnTemp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.SubItemsExpandWidth = 14;
            this.btnTemp.Text = "Đăng xuất";
            // 
            // btnSucKhoe_ThongTin
            // 
            this.btnSucKhoe_ThongTin.Image = global::QLNT.Properties.Resources.suckhoe;
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
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Image = global::QLNT.Properties.Resources.diemdanh;
            this.btnDiemDanh.ImagePaddingHorizontal = 8;
            this.btnDiemDanh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.SubItemsExpandWidth = 14;
            this.btnDiemDanh.Text = "Điểm danh";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImagePaddingHorizontal = 8;
            this.btnTraCuu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.SubItemsExpandWidth = 14;
            this.btnTraCuu.Text = "Tra cứu";
            // 
            // btnPhieuBeNgoan
            // 
            this.btnPhieuBeNgoan.Image = global::QLNT.Properties.Resources.phieubengoan;
            this.btnPhieuBeNgoan.ImagePaddingHorizontal = 8;
            this.btnPhieuBeNgoan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhieuBeNgoan.Name = "btnPhieuBeNgoan";
            this.btnPhieuBeNgoan.SubItemsExpandWidth = 14;
            this.btnPhieuBeNgoan.Text = "Phiếu bé ngoan";
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Image = global::QLNT.Properties.Resources.ThemTre;
            this.btnTiepNhan.ImagePaddingHorizontal = 8;
            this.btnTiepNhan.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.SubItemsExpandWidth = 14;
            this.btnTiepNhan.Text = "Tiếp nhận";
            // 
            // btnXepLop
            // 
            this.btnXepLop.Image = global::QLNT.Properties.Resources.xeplop;
            this.btnXepLop.ImagePaddingHorizontal = 8;
            this.btnXepLop.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXepLop.Name = "btnXepLop";
            this.btnXepLop.SubItemsExpandWidth = 14;
            this.btnXepLop.Text = "Xếp lớp";
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
            this.ClientSize = new System.Drawing.Size(1324, 759);
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
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel4;
        private DevComponents.DotNetBar.RibbonBar ribbonBar7;
        private DevComponents.DotNetBar.ButtonItem btnTemp;
        private DevComponents.DotNetBar.RibbonBar ribbonBar5;
        private DevComponents.DotNetBar.ButtonItem btnSucKhoe_ThongTin;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnTiepNhan;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnDangXuat;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnHocPhi;
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
        private DevComponents.DotNetBar.ButtonItem btnBaoCao_HocPhi;
        private DevComponents.DotNetBar.ButtonItem btnSucKhoe_BaoCao;
        private DevComponents.DotNetBar.ButtonItem btnTraCuu;
        private DevComponents.DotNetBar.ButtonItem btnTimKiem;
    }
}