using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmApDungHocPhi : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

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
            LoadDataGirdView();
            LoadListChiPhi();
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

        private void LoadDataGirdView()
        {
            if (cboLop.SelectedItem == null || cboThang.SelectedItem == null || cboNamHoc.SelectedItem == null)
            {
                dgvTre.DataSource = SucKhoeBLL.GetListSucKhoe("", 0, "");
            }
            else
            {
                dgvTre.DataSource = SucKhoeBLL.GetListSucKhoe(
                    KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString()),
                    int.Parse(cboThang.SelectedItem.ToString()),
                    KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            }

            //dgvTre.Columns[0].HeaderText = "STT";
            //dgvTre.Columns[4].HeaderText = "Họ tên trẻ";
            //dgvTre.Columns[5].HeaderText = "Giới tính";
            //dgvTre.Columns[6].HeaderText = "Ngày sinh";
            //dgvTre.Columns[7].HeaderText = "Cân nặng (kg)";
            //dgvTre.Columns[8].HeaderText = "Chiều cao (cm)";
            //dgvTre.Columns[9].HeaderText = "BMI";
            //dgvTre.Columns[10].HeaderText = "Tình trạng";
            //dgvTre.Columns[11].HeaderText = "Ghi chú";

            //dgvTre.Columns[0].Width = 50;
            //dgvTre.Columns[4].Width = 260;
            //dgvTre.Columns[5].Width = 100;
            //dgvTre.Columns[6].Width = 120;
            //dgvTre.Columns[7].Width = 150;
            //dgvTre.Columns[8].Width = 150;
            //dgvTre.Columns[9].Width = 120;
            //dgvTre.Columns[10].Width = 200;
            //dgvTre.Columns[10].Width = 300;

            for (int i = 0; i < dgvTre.Rows.Count; i++)
            {
                dgvTre.Rows[i].Cells[0].Value = i + 1;
            }

            string[] listProp = { "STT", "HoTenTre", "GioiTinh", "NgaySinh", "CanNang", "ChieuCao", "BMI", "TinhTrang", "GhiChu" };
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
                LoadDataGirdView();
            }
            LoadListThang();
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboNamHoc.Text.Equals(""))
            {
                loadListLop();
                LoadDataGirdView();
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGirdView();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGirdView();
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

            txtSoTien.Text = danhMuc.SoTien.ToString();
        }
    }
}
