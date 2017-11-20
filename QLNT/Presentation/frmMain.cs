using DevComponents.DotNetBar;
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
                    break;
                case Quyen.GiaoVien:
                    btnTraCuu.Enabled = false;
                    btnTiepNhan.Enabled = false;
                    btnXepLop.Enabled = false;
                    btnApDungHocPhi.Enabled = false;
                    btnThuHocPhi.Enabled = false;
                    break;
                case Quyen.GiaoVu:
                    btnPhieuBeNgoan.Enabled = false;
                    btnSucKhoe_ThongTin.Enabled = false;
                    btnSucKhoe_BaoCao.Enabled = false;
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
                tab.PredefinedColor = eTabItemColor.Yellow;
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
                tab.PredefinedColor = eTabItemColor.Green;
                frmTiepNhan _frmTiepNhan = new frmTiepNhan(tabControl, tab);
                _frmTiepNhan.TopLevel = false;
                _frmTiepNhan.Dock = DockStyle.Fill;
                _frmTiepNhan.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmTiepNhan);
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
                tab.PredefinedColor = eTabItemColor.Lemon;
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
                tab.PredefinedColor = eTabItemColor.Red;
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
                tab.PredefinedColor = eTabItemColor.Cyan;
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
                tab.PredefinedColor = eTabItemColor.Yellow;
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
                tab.PredefinedColor = eTabItemColor.Cyan;
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

        private void btnApDungHocPhi_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Áp dụng học phí"))
            {
                TabItem tab = tabControl.CreateTab("Áp dụng học phí");
                tab.PredefinedColor = eTabItemColor.Yellow;
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
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmThuHocPhi _frmThuHocPhi = new frmThuHocPhi(tabControl, tab);
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
    }
}
