using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmApDungHocPhi : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        private string maHocPhi = "";
        private List<ChiTietHocPhi> listChiTietHocPhi = new List<ChiTietHocPhi>();

        public frmApDungHocPhi(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmApDungHocPhi_Load(object sender, EventArgs e)
        {
            initDataGridView();
            loadListNamHoc();
            loadListLoaiLop();
            LoadDataGridViewTre();
            LoadListChiPhi();
            LoadListChiTietHocPhi();
        }

        private void initDataGridView()
        {
            DataGridViewTextBoxColumn columnSTTTre = new DataGridViewTextBoxColumn();
            columnSTTTre.Name = "STT";
            columnSTTTre.HeaderText = "STT";
            columnSTTTre.Width = 50;
            columnSTTTre.ReadOnly = true;
            dgvTre.Columns.Add(columnSTTTre);

            DataGridViewTextBoxColumn columnSTTChiTiet = new DataGridViewTextBoxColumn();
            columnSTTChiTiet.Name = "STT";
            columnSTTChiTiet.HeaderText = "STT";
            columnSTTChiTiet.Width = 50;
            columnSTTChiTiet.ReadOnly = true;
            dgvChiTietHocPhi.Columns.Add(columnSTTChiTiet);
        }

        private void loadListNamHoc()
        {
            cboNamHoc.DisplayMember = "Text";
            cboNamHoc.ValueMember = "Value";
            foreach (NamHoc namHoc in LopBLL.GetListNienKhoa())
            {
                cboNamHoc.Items.Add(new { Text = namHoc.NienKhoa.Trim(), Value = namHoc.MaNamHoc.Trim() });
            }
        }

        private void loadListLoaiLop()
        {
            cboLoaiLop.DisplayMember = "Text";
            cboLoaiLop.ValueMember = "Value";
            foreach (LoaiLop loaiLop in LopBLL.GetListLoaiLop())
            {
                cboLoaiLop.Items.Add(new { Text = loaiLop.TenLoaiLop.Trim(), Value = loaiLop.MaLoaiLop.Trim() });
            }
        }

        private void loadListLop()
        {
            cboLop.Items.Clear();
            cboLop.DisplayMember = "Text";
            cboLop.ValueMember = "Value";
            foreach (Lop lop in LopBLL.GetListLop(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()),
                KeyHandle.GetKeyFromCombobox(cboLoaiLop.SelectedItem.ToString())))
            {
                cboLop.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });
            }
            cboLop.Text = "";
        }

        private void LoadDataGridViewTre()
        {
            if (cboLop.SelectedItem == null || cboThang.SelectedItem == null || cboNamHoc.SelectedItem == null)
            {
                dgvTre.DataSource = HocPhiBLL.GetListHocPhiTheoThang("", 0, 0);
            }
            else
            {
                dgvTre.DataSource = HocPhiBLL.GetListHocPhiTheoThang(
                    KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString()),
                    int.Parse(cboThang.Text),
                    LopBLL.GetNamHoc(int.Parse(cboThang.Text), KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString())));
            }

            dgvTre.Columns[0].HeaderText = "STT";
            dgvTre.Columns[3].HeaderText = "Họ tên trẻ";
            dgvTre.Columns[4].HeaderText = "Giới tính";
            dgvTre.Columns[5].HeaderText = "Ngày sinh";
            dgvTre.Columns[8].HeaderText = "Tổng tiền";

            dgvTre.Columns[0].Width = 50;
            dgvTre.Columns[3].Width = 260;
            dgvTre.Columns[4].Width = 100;
            dgvTre.Columns[5].Width = 120;
            dgvTre.Columns[8].Width = 150;

            for (int i = 0; i < dgvTre.Rows.Count; i++)
            {
                dgvTre.Rows[i].Cells[0].Value = i + 1;
            }

            string[] listProp = { "STT", "HoTenTre", "GioiTinh", "NgaySinh", "TongTien" };
            ControlFormat.DataGridViewFormat(dgvTre, listProp);
        }

        private void LoadListChiPhi()
        {
            cboChiPhi.Items.Clear();
            cboChiPhi.DisplayMember = "Text";
            cboChiPhi.ValueMember = "Value";
            foreach (DanhMucChiPhi danhMuc in DanhMucChiPhiBLL.GetListDanhMucChiPhi())
            {
                cboChiPhi.Items.Add(new { Text = danhMuc.TenChiPhi.Trim(), Value = danhMuc.MaDanhMuc.Trim() });
            }
            cboChiPhi.Text = "";
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboLoaiLop.Text.Equals(""))
            {
                loadListLop();
                LoadDataGridViewTre();
            }
            LoadListThang();
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboNamHoc.Text.Equals(""))
            {
                loadListLop();
                LoadDataGridViewTre();
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridViewTre();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridViewTre();
        }

        private void LoadListThang()
        {
            NamHoc namHoc = LopBLL.GetInfoNamHoc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            int thangBatDau = namHoc.NgayBatDau.Month;
            int thangKetThuc = namHoc.NgayKetThuc.Month;

            List<int> listThang = new List<int>();
            listThang.Add(thangBatDau);

            while (thangBatDau != thangKetThuc)
            {
                thangBatDau++;
                if (thangBatDau > 12)
                    thangBatDau = 1;
                listThang.Add(thangBatDau);
            }

            cboThang.Items.Clear();
            foreach (int thang in listThang)
            {
                cboThang.Items.Add(thang.ToString());
            }
        }

        private void cboChiPhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DanhMucChiPhi danhMuc = DanhMucChiPhiBLL.GetInfoDanhMuc(KeyHandle.GetKeyFromCombobox(cboChiPhi.SelectedItem.ToString()));
            if(danhMuc.TenLoaiChiPhi == "Cố định")
            {
                txtSoTien.Enabled = false;
            } else
            {
                txtSoTien.Enabled = true;
            }
            labelTheoNgay.Visible = danhMuc.TruTienKhiNghi == 1;

            txtSoTien.Text = danhMuc.SoTien.ToString();
        }

        private void dgvTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 || e.RowIndex != dgvTre.RowCount)
            {
                maHocPhi = dgvTre.Rows[e.RowIndex].Cells["MaHocPhi"].Value.ToString();

                listChiTietHocPhi = HocPhiBLL.GetChiTietHocPhi(maHocPhi);
                LoadListChiTietHocPhi();
            }
        }

        private void LoadListChiTietHocPhi()
        {
            dgvChiTietHocPhi.DataSource = DataHandle.ListToDataTable(listChiTietHocPhi);

            dgvChiTietHocPhi.Columns[0].HeaderText = "STT";
            dgvChiTietHocPhi.Columns[3].HeaderText = "Tên chi phí";
            dgvChiTietHocPhi.Columns[4].HeaderText = "Số tiền";

            dgvChiTietHocPhi.Columns[0].Width = 50;
            dgvChiTietHocPhi.Columns[3].Width = 250;
            dgvChiTietHocPhi.Columns[4].Width = 100;

            string[] listProp = { "STT", "TenChiPhi", "SoTien" };
            ControlFormat.DataGridViewFormat(dgvChiTietHocPhi, listProp);
        }

        private void btnThemChiPhi_Click(object sender, EventArgs e)
        {
            if(txtSoTien.Text != "" && cboChiPhi.Text != "")
            {
                if (CheckExistDanhMucChiPhi(KeyHandle.GetKeyFromCombobox(cboChiPhi.SelectedItem.ToString()))) return;

                ChiTietHocPhi chiTiet = new ChiTietHocPhi();
                chiTiet.MaHocPhi = maHocPhi;
                chiTiet.MaDanhMuc = KeyHandle.GetKeyFromCombobox(cboChiPhi.SelectedItem.ToString());
                chiTiet.TenChiPhi = cboChiPhi.Text;
                chiTiet.SoTien = decimal.Parse(txtSoTien.Text);

                listChiTietHocPhi.Add(chiTiet);
                LoadListChiTietHocPhi();
            }
        }

        private bool CheckExistDanhMucChiPhi(string maDanhMuc)
        {
            foreach(ChiTietHocPhi chiTiet in listChiTietHocPhi)
            {
                if (maDanhMuc == chiTiet.MaDanhMuc)
                    return true;
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvChiTietHocPhi.SelectedRows.Count; i++)
            {
                string maDanhMuc = dgvChiTietHocPhi.SelectedRows[i].Cells["MaDanhMuc"].Value.ToString();
                foreach (ChiTietHocPhi chiTiet in listChiTietHocPhi.ToArray())
                {
                    if (chiTiet.MaDanhMuc == maDanhMuc)
                        listChiTietHocPhi.Remove(chiTiet);
                }
            }
            LoadListChiTietHocPhi();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void RefreshView()
        {
            listChiTietHocPhi.Clear();
            LoadListChiTietHocPhi();
            LoadDataGridViewTre();
            txtSoTien.Clear();
            cboChiPhi.Text = "";
        }

        private void btnApDungHocPhi_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dgvTre.SelectedRows.Count; i++)
            {
                HocPhi hocPhi = new HocPhi();
                hocPhi.MaHocPhi = dgvTre.SelectedRows[i].Cells["MaHocPhi"].Value.ToString();
                hocPhi.MaTre = dgvTre.SelectedRows[i].Cells["MaTre"].Value.ToString();
                hocPhi.Thang = int.Parse(dgvTre.SelectedRows[i].Cells["Thang"].Value.ToString());
                hocPhi.Nam = int.Parse(dgvTre.SelectedRows[i].Cells["Nam"].Value.ToString());
                hocPhi.TongTien = HocPhiBLL.TinhTongTien(hocPhi, listChiTietHocPhi);
                int nam = hocPhi.Nam;
                int thang = hocPhi.Thang - 1;
                if(thang == 0)
                {
                    thang = 12;
                    nam -= 1;
                } 

                HocPhiBLL.CapNhatHocPhi(hocPhi, listChiTietHocPhi);
            }

            RefreshView();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }
    }
}
