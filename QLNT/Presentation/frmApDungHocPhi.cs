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

        #region Init
        private void initDataGridView()
        {
            DataGridViewTextBoxColumn columnSTTTre = new DataGridViewTextBoxColumn();
            columnSTTTre.Name = "STT";
            columnSTTTre.HeaderText = "STT";
            columnSTTTre.Width = 50;
            columnSTTTre.ReadOnly = true;
            dgvTre.Columns.Add(columnSTTTre);

            DataGridViewTextBoxColumn gioiTinhColumn = new DataGridViewTextBoxColumn();
            gioiTinhColumn.Name = "GioiTinhCol";
            gioiTinhColumn.HeaderText = "Giới tính";
            gioiTinhColumn.Width = 150;
            gioiTinhColumn.ReadOnly = false;
            gioiTinhColumn.FillWeight = 10;
            dgvTre.Columns.Add(gioiTinhColumn);

            DataGridViewTextBoxColumn columnSTTChiTiet = new DataGridViewTextBoxColumn();
            columnSTTChiTiet.Name = "STT";
            columnSTTChiTiet.HeaderText = "STT";
            columnSTTChiTiet.Width = 50;
            columnSTTChiTiet.ReadOnly = true;
            dgvChiTietHocPhi.Columns.Add(columnSTTChiTiet);
        }
        #endregion

        #region Function
        private void loadListNamHoc()
        {
            cboNamHoc.DisplayMember = "Text";
            cboNamHoc.ValueMember = "Value";
            foreach (NamHoc namHoc in LopBLL.GetListNienKhoa())
            {
                cboNamHoc.Items.Add(new { Text = namHoc.NienKhoa.Trim(), Value = namHoc.MaNamHoc.Trim() });
            }
            if(cboNamHoc.Items.Count > 0)
            {
                cboNamHoc.SelectedIndex = cboNamHoc.Items.Count - 1;
            }
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

            int thangCapNhat = DateTime.Now.Month - 1;
            if(thangCapNhat == 0)
            {
                thangCapNhat = 12;
            }
            cboThang.Text = thangCapNhat.ToString();
        }

        private void loadListLoaiLop()
        {
            cboLoaiLop.DisplayMember = "Text";
            cboLoaiLop.ValueMember = "Value";
            foreach (LoaiLop loaiLop in LopBLL.GetListLoaiLop())
            {
                cboLoaiLop.Items.Add(new { Text = loaiLop.TenLoaiLop.Trim(), Value = loaiLop.MaLoaiLop.Trim() });
            }
            if(cboLoaiLop.Items.Count > 0)
            {
                cboLoaiLop.SelectedIndex = 0;
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
            
            dgvTre.Columns["HoTenTre"].DisplayIndex = 1;
            dgvTre.Columns["GioiTinhCol"].DisplayIndex = 2;
            dgvTre.Columns["NgaySinh"].DisplayIndex = 3;
            dgvTre.Columns["HocPhiThangNay"].DisplayIndex = 4;
            dgvTre.Columns["TienNoThangTruoc"].DisplayIndex = 5;
            dgvTre.Columns["TongTienHocPhi"].DisplayIndex = 6;
            dgvTre.Columns["SoTienDaDong"].DisplayIndex = 7;
            dgvTre.Columns["SoTienConNo"].DisplayIndex = 8;

            dgvTre.Columns["HoTenTre"].HeaderText = "Họ tên trẻ";
            dgvTre.Columns["GioiTinhCol"].HeaderText = "Giới tính";
            dgvTre.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvTre.Columns["HocPhiThangNay"].HeaderText = "Học phí tháng này";
            dgvTre.Columns["TienNoThangTruoc"].HeaderText = "Tiền nợ tháng trước";
            dgvTre.Columns["TongTienHocPhi"].HeaderText = "Tổng tiền học phí";
            dgvTre.Columns["SoTienDaDong"].HeaderText = "Số tiền đã đóng";
            dgvTre.Columns["SoTienConNo"].HeaderText = "Số tiền còn nợ";

            dgvTre.Columns["HoTenTre"].Width = 260;
            dgvTre.Columns["GioiTinhCol"].Width = 100;
            dgvTre.Columns["NgaySinh"].Width = 120;
            dgvTre.Columns["HocPhiThangNay"].Width = 140;
            dgvTre.Columns["TienNoThangTruoc"].Width = 140;
            dgvTre.Columns["TongTienHocPhi"].Width = 140;
            dgvTre.Columns["SoTienDaDong"].Width = 140;
            dgvTre.Columns["SoTienConNo"].Width = 140;

            string[] listProp = { "STT", "HoTenTre", "GioiTinhCol", "NgaySinh", "HocPhiThangNay", "TienNoThangTruoc", "TongTienHocPhi", "SoTienDaDong", "SoTienConNo" };
            ControlFormat.DataGridViewFormat(dgvTre, listProp);

            dgvTre.ClearSelection();
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

        private void LoadListChiTietHocPhi()
        {
            dgvChiTietHocPhi.DataSource = DataHandle.ListToDataTable(listChiTietHocPhi);

            dgvChiTietHocPhi.Columns[3].HeaderText = "Tên chi phí";
            dgvChiTietHocPhi.Columns[4].HeaderText = "Số tiền";

            dgvChiTietHocPhi.Columns[3].Width = 250;
            dgvChiTietHocPhi.Columns[4].Width = 100;

            string[] listProp = { "STT", "TenChiPhi", "SoTien" };
            ControlFormat.DataGridViewFormat(dgvChiTietHocPhi, listProp);

            dgvChiTietHocPhi.ClearSelection();
        }

        private bool KiemTraTonTaiDanhMucChiPhi(string maDanhMuc)
        {
            foreach (ChiTietHocPhi chiTiet in listChiTietHocPhi)
            {
                if (maDanhMuc == chiTiet.MaDanhMuc)
                    return true;
            }
            return false;
        }

        private void RefreshView()
        {
            listChiTietHocPhi.Clear();
            LoadListChiTietHocPhi();
            LoadDataGridViewTre();
            txtSoTien.Clear();
            cboChiPhi.SelectedIndex = -1;
        }
        #endregion

        #region Event
        private void frmApDungHocPhi_Load(object sender, EventArgs e)
        {
            initDataGridView();
            loadListNamHoc();
            loadListLoaiLop();
            LoadDataGridViewTre();
            LoadListChiPhi();
            LoadListChiTietHocPhi();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboLoaiLop.Text.Equals(""))
            {
                loadListLop();
                RefreshView();
            }
            LoadListThang();
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboNamHoc.Text.Equals(""))
            {
                loadListLop();
                RefreshView();
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshView();
            int thang = int.Parse(cboThang.Text);
            int nam = LopBLL.GetNamHoc(thang, KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            int dieuKien = HocPhiBLL.CoTheCapNhatHocPhi(thang, nam, DateTime.Now);

            cboChiPhi.Enabled = false;
            txtSoTien.Enabled = false;
            btnThemChiPhi.Enabled = false;
            btnXoa.Enabled = false;
            btnApDungHocPhi.Enabled = false;
            if(dieuKien == -1)
            {
                lbMessage.Text = "Đã quá hạn áp dụng học phí";
            }
            else if(dieuKien == 1)
            {
                lbMessage.Text = "Chưa tới thời gian áp dụng học phí";
            }
            else
            {
                lbMessage.Text = "";
                cboChiPhi.Enabled = true;
                txtSoTien.Enabled = true;
                btnThemChiPhi.Enabled = true;
                btnXoa.Enabled = true;
                btnApDungHocPhi.Enabled = true;
            }
        }

        private void cboChiPhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChiPhi.SelectedItem == null) return;
            DanhMucChiPhi danhMuc = DanhMucChiPhiBLL.GetInfoDanhMuc(KeyHandle.GetKeyFromCombobox(cboChiPhi.SelectedItem.ToString()));
            if (danhMuc.TenLoaiChiPhi == "Cố định")
            {
                txtSoTien.Enabled = false;
            }
            else
            {
                txtSoTien.Enabled = true;
            }
            labelTheoNgay.Visible = danhMuc.TinhTheoSoNgayDiHoc == 1;

            txtSoTien.Text = danhMuc.SoTien.ToString();
        }

        private void dgvTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvTre.RowCount)
            {
                maHocPhi = dgvTre.Rows[e.RowIndex].Cells["MaHocPhi"].Value.ToString();

                listChiTietHocPhi = HocPhiBLL.GetChiTietHocPhi(maHocPhi);
                LoadListChiTietHocPhi();
            }
        }

        private void btnThemChiPhi_Click(object sender, EventArgs e)
        {
            if (cboChiPhi.SelectedItem == null || cboChiPhi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chi phí.");
                return;
            }
            if (txtSoTien.Text == "")
            {
                MessageBox.Show("Số tiền không được để trống.");
                return;
            }
            if(dgvTre.SelectedRows.Count == 0)
            {
                MessageBox.Show("Phải chọn ít nhất một trẻ trước khi thêm chi phí.");
                return;
            }

            if (KiemTraTonTaiDanhMucChiPhi(KeyHandle.GetKeyFromCombobox(cboChiPhi.SelectedItem.ToString()))) return;

            try
            {
                ChiTietHocPhi chiTiet = new ChiTietHocPhi();
                chiTiet.MaHocPhi = maHocPhi;
                chiTiet.MaDanhMuc = KeyHandle.GetKeyFromCombobox(cboChiPhi.SelectedItem.ToString());
                chiTiet.TenChiPhi = cboChiPhi.Text;
                chiTiet.SoTien = decimal.Parse(txtSoTien.Text);

                listChiTietHocPhi.Add(chiTiet);
                LoadListChiTietHocPhi();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra. " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvChiTietHocPhi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Phải chọn ít nhất một chi phí để xóa.");
                return;
            }
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

        private void btnApDungHocPhi_Click(object sender, EventArgs e)
        {
            if(dgvTre.SelectedRows.Count == 0)
            {
                MessageBox.Show("Phải chọn ít nhất một trẻ để áp dụng học phí.");
                return;
            }
            try
            {
                for (int i = 0; i < dgvTre.SelectedRows.Count; i++)
                {
                    HocPhi hocPhi = new HocPhi();
                    hocPhi.MaHocPhi = dgvTre.SelectedRows[i].Cells["MaHocPhi"].Value.ToString();
                    hocPhi.MaTre = dgvTre.SelectedRows[i].Cells["MaTre"].Value.ToString();
                    hocPhi.Thang = int.Parse(dgvTre.SelectedRows[i].Cells["Thang"].Value.ToString());
                    hocPhi.Nam = int.Parse(dgvTre.SelectedRows[i].Cells["Nam"].Value.ToString());
                    hocPhi.HocPhiThangNay = HocPhiBLL.TinhHocPhiThangNay(hocPhi, listChiTietHocPhi);
                    hocPhi.TienNoThangTruoc = HocPhiBLL.LayTienNoHocPhiThangTruoc(hocPhi);
                    hocPhi.TongTienHocPhi = hocPhi.HocPhiThangNay + hocPhi.TienNoThangTruoc;
                    hocPhi.SoTienDaDong = decimal.Parse(dgvTre.SelectedRows[i].Cells["SoTienDaDong"].Value.ToString());
                    hocPhi.SoTienConNo = hocPhi.TongTienHocPhi - hocPhi.SoTienDaDong;

                    HocPhiBLL.CapNhatHocPhi(hocPhi, listChiTietHocPhi);
                }
                MessageBox.Show("Áp dụng học phí thanh công!");
            } catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra.");
            }

            RefreshView();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void dgvChiTietHocPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < dgvChiTietHocPhi.RowCount)
            {
                cboChiPhi.Text = dgvChiTietHocPhi.SelectedRows[0].Cells["TenChiPhi"].Value.ToString();
            }
        }

        private void dgvTre_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvTre.Rows.Count; i++)
            {
                dgvTre.Rows[i].Cells[0].Value = i + 1;
                dgvTre.Rows[i].Cells["GioiTinhCol"].Value =
                    int.Parse(dgvTre.Rows[i].Cells["GioiTinh"].Value.ToString()) == 1 ? "Nam" : "Nữ";
            }
        }

        private void dgvChiTietHocPhi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvChiTietHocPhi.Rows.Count; i++)
            {
                dgvChiTietHocPhi.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dgvChiTietHocPhi_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            base.OnClick(e);
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        #endregion

    }
}
