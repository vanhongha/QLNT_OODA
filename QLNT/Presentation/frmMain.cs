﻿using DevComponents.DotNetBar;
using QLNT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmMain : Form
    {
        public string username;
        private static Quyen quyen;

        public static Quyen Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        public void DangXuat()
        {
            this.Hide();
            new frmDangNhap().ShowDialog();
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        #region Phan Quyen
        private void PhanQuyen()
        {
            switch (quyen)
            {
                case Quyen.NhaBep:
                    ribonQLChung.Enabled = false;
                    ribonQLHP.Enabled = false;
                    ribonQLSK.Enabled = false;
                    ribonQLTre.Enabled = false;
                    break;
                case Quyen.GiaoVien:
                    btnTraCuu.Enabled = false;
                    btnTiepNhan.Enabled = false;
                    btnXepLop.Enabled = false;
                    btnDanhMucChiPhi.Enabled = false;
                    btnApDungHocPhi.Enabled = false;
                    btnNguyenLieu.Enabled = false;
                    btnMonAn.Enabled = false;
                    btnThuHocPhi.Enabled = false;
                    btnQLChung_Lop.Enabled = false;
                    break;
                case Quyen.GiaoVu:
                    btnPhieuBeNgoan.Enabled = false;
                    btnSucKhoe_ThongTin.Enabled = false;
                    btnSucKhoe_BaoCao.Enabled = false;
                    btnNguyenLieu.Enabled = false;
                    btnMonAn.Enabled = false;
                    btnApDung.Enabled = false;
                    break;
            }
        }
        #endregion

        public bool CheckOpenedTabs(string name)
        {
            for (int i = 0; i < tabControl.Tabs.Count; i++)
            {
                if (tabControl.Tabs[i].Text == name)
                {
                    tabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void btnSucKhoe_ThongTin_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Thông tin sức khỏe"))
            {
                TabItem tab = tabControl.CreateTab("Thông tin sức khỏe");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmThongTinSucKhoe _frmBieuDoSucKhoe = new frmThongTinSucKhoe(tabControl, tab);
                _frmBieuDoSucKhoe.TopLevel = false;
                _frmBieuDoSucKhoe.Dock = DockStyle.Fill;
                _frmBieuDoSucKhoe.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmBieuDoSucKhoe);
                _frmBieuDoSucKhoe.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Tiếp nhận"))
            {
                TabItem tab = tabControl.CreateTab("Tiếp nhận");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmTiepNhan _frmTiepNhan = new frmTiepNhan(tabControl, tab);
                _frmTiepNhan.TopLevel = false;
                _frmTiepNhan.Dock = DockStyle.Fill;
                _frmTiepNhan.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmTiepNhan);
                _frmTiepNhan.username = this.username;
                _frmTiepNhan.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Điểm danh"))
            {
                TabItem tab = tabControl.CreateTab("Điểm danh");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmDiemDanh _frmDiemDanh = new frmDiemDanh(tabControl, tab);
                _frmDiemDanh.TopLevel = false;
                _frmDiemDanh.Dock = DockStyle.Fill;
                _frmDiemDanh.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmDiemDanh);
                _frmDiemDanh.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnPhieuBeNgoan_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Phiếu bé ngoan"))
            {
                TabItem tab = tabControl.CreateTab("Phiếu bé ngoan");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmPhieuBeNgoan _frmPhieuBeNgoan = new frmPhieuBeNgoan(tabControl, tab);
                _frmPhieuBeNgoan.TopLevel = false;
                _frmPhieuBeNgoan.Dock = DockStyle.Fill;
                _frmPhieuBeNgoan.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmPhieuBeNgoan);
                _frmPhieuBeNgoan.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Tra cứu"))
            {
                TabItem tab = tabControl.CreateTab("Tra cứu");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmTimKiem _frmTimKiem = new frmTimKiem(tabControl, tab);
                _frmTimKiem.TopLevel = false;
                _frmTimKiem.Dock = DockStyle.Fill;
                _frmTimKiem.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmTimKiem);
                _frmTimKiem.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnSucKhoe_BaoCao_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Biểu đồ sức khỏe"))
            {
                TabItem tab = tabControl.CreateTab("Biểu đồ sức khỏe");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmBieuDoSucKhoe _frmBieuDoSucKhoe = new frmBieuDoSucKhoe(tabControl, tab);
                _frmBieuDoSucKhoe.TopLevel = false;
                _frmBieuDoSucKhoe.Dock = DockStyle.Fill;
                _frmBieuDoSucKhoe.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmBieuDoSucKhoe);
                _frmBieuDoSucKhoe.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Xếp lớp"))
            {
                TabItem tab = tabControl.CreateTab("Xếp lớp");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmXepLop _frmXepLop = new frmXepLop(tabControl, tab);
                _frmXepLop.TopLevel = false;
                _frmXepLop.Dock = DockStyle.Fill;
                _frmXepLop.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmXepLop);
                _frmXepLop.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Món ăn"))
            {
                TabItem tab = tabControl.CreateTab("Món ăn");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmDinhDuong_MonAn _frmDinhDuong_MonAn = new frmDinhDuong_MonAn(tabControl, tab);
                _frmDinhDuong_MonAn.TopLevel = false;
                _frmDinhDuong_MonAn.Dock = DockStyle.Fill;
                _frmDinhDuong_MonAn.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmDinhDuong_MonAn);
                _frmDinhDuong_MonAn.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Nguyên liệu"))
            {
                TabItem tab = tabControl.CreateTab("Nguyên liệu");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmDinhDuong_NguyenLieu _frmDinhDuong_NguyenLieu = new frmDinhDuong_NguyenLieu(tabControl, tab);
                _frmDinhDuong_NguyenLieu.TopLevel = false;
                _frmDinhDuong_NguyenLieu.Dock = DockStyle.Fill;
                _frmDinhDuong_NguyenLieu.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmDinhDuong_NguyenLieu);
                _frmDinhDuong_NguyenLieu.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnDanhMucChiPhi_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Danh mục chi phí"))
            {
                TabItem tab = tabControl.CreateTab("Danh mục chi phí");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmDanhMucChiPhi _frmDanhMucChiPhi = new frmDanhMucChiPhi(tabControl, tab);
                _frmDanhMucChiPhi.TopLevel = false;
                _frmDanhMucChiPhi.Dock = DockStyle.Fill;
                _frmDanhMucChiPhi.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmDanhMucChiPhi);
                _frmDanhMucChiPhi.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnApDungHocPhi_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Áp dụng học phí"))
            {
                TabItem tab = tabControl.CreateTab("Áp dụng học phí");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmApDungHocPhi _frmApDungHocPhi = new frmApDungHocPhi(tabControl, tab);
                _frmApDungHocPhi.TopLevel = false;
                _frmApDungHocPhi.Dock = DockStyle.Fill;
                _frmApDungHocPhi.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmApDungHocPhi);
                _frmApDungHocPhi.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnThuHocPhi_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Thu học phí"))
            {
                TabItem tab = tabControl.CreateTab("Thu học phí");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmThuHocPhi _frmThuHocPhi = new frmThuHocPhi(tabControl, tab, username);
                _frmThuHocPhi.TopLevel = false;
                _frmThuHocPhi.Dock = DockStyle.Fill;
                _frmThuHocPhi.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmThuHocPhi);
                _frmThuHocPhi.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnApDung_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Lịch ăn"))
            {
                TabItem tab = tabControl.CreateTab("Lịch ăn");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmDinhDuong_ApDungThucDon _frmDinhDuong_ApDungThucDon = new frmDinhDuong_ApDungThucDon(tabControl, tab);
                _frmDinhDuong_ApDungThucDon.TopLevel = false;
                _frmDinhDuong_ApDungThucDon.Dock = DockStyle.Fill;
                _frmDinhDuong_ApDungThucDon.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmDinhDuong_ApDungThucDon);
                _frmDinhDuong_ApDungThucDon.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;

                if(quyen==Quyen.GiaoVien)
                {
                    _frmDinhDuong_ApDungThucDon.PhanQuyenGiaoVien();
                }
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnQLChung_Lop_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Quản lý lớp"))
            {
                TabItem tab = tabControl.CreateTab("Quản lý lớp");
                tab.PredefinedColor = eTabItemColor.Blue;
                frmQLChung_Lop _frmQLChung_Lop = new frmQLChung_Lop(tabControl, tab);
                _frmQLChung_Lop.TopLevel = false;
                _frmQLChung_Lop.Dock = DockStyle.Fill;
                _frmQLChung_Lop.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmQLChung_Lop);
                _frmQLChung_Lop.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        private void btnThongTin_TaiKhoan_Click(object sender, EventArgs e)
        {
            frmThongTinPhanMem _frmThongTinPhanMem = new frmThongTinPhanMem();
            _frmThongTinPhanMem.ShowDialog();
        }
    }
    
}
