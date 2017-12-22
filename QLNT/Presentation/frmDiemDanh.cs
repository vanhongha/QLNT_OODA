using DevComponents.DotNetBar;
using System.Windows.Forms;
using System;
using QLNT.Entities;
using QLNT.BusinessLayer;
using System.Data;
using QLNT.Ultilities;

namespace QLNT.Presentation
{
    public partial class frmDiemDanh : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        #region Init
        public frmDiemDanh(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        public frmDiemDanh()
        {
            InitializeComponent();
        }

        private void Init()
        {
            int year = DateTime.Now.Year;
            DateTime date = new DateTime(year, 1, 1);
            dtNgayDiemDanh.MaxDate = date.AddYears(1);
            dtNgayDiemDanh.MinDate = date;

            dtNgayDiemDanh.Format = DateTimePickerFormat.Custom;
            dtNgayDiemDanh.CustomFormat = "dd/MM/yyyy";
        }
        #endregion

        #region Event
        private void frmDiemDanh_Load(object sender, System.EventArgs e)
        {
            Init();
            loadListNamHoc();
        }
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListLop();
            DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));


            if (ngayBatDau >= dtNgayDiemDanh.MaxDate)
            {
                dtNgayDiemDanh.MaxDate = ngayKetThuc;
                dtNgayDiemDanh.MinDate = ngayBatDau;
                dtNgayDiemDanh.Value = ngayBatDau;
            }
            else
            {
                dtNgayDiemDanh.MinDate = ngayBatDau;
                dtNgayDiemDanh.MaxDate = ngayKetThuc;
                dtNgayDiemDanh.Value = ngayBatDau;
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView();

            DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            if (LopBLL.GetSiSo(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())) > 0
            && Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
            {
                btnLuuDiemDanh.Enabled = true;
                btnTaoBangMoi.Enabled = true;
            }
            else if (LopBLL.GetSiSo(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())) <= 0)
            {
                lbThongBao.Text += "\nLớp không có học sinh, không thể tạo phiếu mới";
                lbThongBao.Visible = true;
                btnLuuDiemDanh.Enabled = false;
                btnTaoBangMoi.Enabled = false;
            }
            else if (!Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
            {
                lbThongBao.Text += "\nNiên khóa đã qua, không thể tạo phiếu mới";
                lbThongBao.Visible = true;
                btnLuuDiemDanh.Enabled = false;
                btnTaoBangMoi.Enabled = false;
            }
        }

        private void dtNgayDiemDanh_ValueChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnLuuDiemDanh_Click(object sender, EventArgs e)
        {
            XoaPhieuCu();
            for (int i = 0; i < dgvDiemDanh.Rows.Count; i++)
            {

                if (dgvDiemDanh.Rows[i].Cells["HienDienCheckbox"].Value == null ||
                    dgvDiemDanh.Rows[i].Cells["HienDienCheckbox"].Value.ToString() == "False" ||
                    dgvDiemDanh.Rows[i].Cells["HienDienCheckbox"].Value.ToString() == "false")
                    dgvDiemDanh.Rows[i].Cells["HienDien"].Value = "0";
                else
                    dgvDiemDanh.Rows[i].Cells["HienDien"].Value = "1";
            }
            LuuBangDiemDanh(dgvDiemDanh);

        }
        private void btnTaoBangMoi_Click(object sender, EventArgs e)
        {
            DialogResult confirm = new DialogResult();
            if (dgvDiemDanh.RowCount > 0)
            {
                confirm = MessageBox.Show("Ngày này đã có dữ liệu điểm danh. Bạn có chắc muốn xóa để tạo mới hoàn toàn?",
                    "Cân nhắc", MessageBoxButtons.YesNo);
            }
            if (confirm == DialogResult.Yes || dgvDiemDanh.RowCount <= 0)
            {
                XoaPhieuCu();
                dgvDiemDanh.Columns.Clear();
                if (!string.IsNullOrEmpty(cboLop.Text))
                {
                    dgvDiemDanh.DataSource = DiemDanhBLL.TaoBangDiemDanhMoi(
                        LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())),
                        dtNgayDiemDanh.Text);
                    TaoPhieuTrong();
                    MessageBox.Show("Một phiếu mới hoàn toàn vừa được tạo", "Thông báo");

                }
            }
            else if (confirm == DialogResult.No)
            {
                return;
            }

        }


        #endregion

        #region Function 
        private void loadDataGridView()
        {
            dgvDiemDanh.Columns.Clear();
            if (!string.IsNullOrEmpty(cboLop.Text))
            {
                string datetime = dtNgayDiemDanh.Value.ToString("yyyy-MM-dd");
                dgvDiemDanh.DataSource = DiemDanhBLL.LaySoDiemDanhLop(
                    LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())),
                    datetime.Split(' ')[0]);

                TaoPhieuTrong();

                if (dgvDiemDanh.RowCount <= 0)
                {
                    lbThongBao.Text = "Ngày " + dtNgayDiemDanh.Value.ToString("dd-MM-yyyy") + " chưa có điểm danh";
                    lbThongBao.Visible = true;
                }
                else
                {
                    lbThongBao.Visible = false;
                    

                    
                    for (int i = 0; i < dgvDiemDanh.RowCount; i++)
                    {
                        DataGridViewCheckBoxCell chkBoxCell = (DataGridViewCheckBoxCell)dgvDiemDanh.Rows[i].Cells["HienDienCheckbox"];
                        if (dgvDiemDanh.Rows[i].Cells["HienDien"].Value.ToString() == "1")
                        {
                            chkBoxCell.Value = "true";
                        }
                        else
                        {
                            chkBoxCell.Value = "false";
                        }
                    }
                }

            }
        }

        private void TaoPhieuTrong()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "HienDienCheckbox";
            checkColumn.HeaderText = "Hiện Diện";
            checkColumn.DisplayIndex = 2;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 20;
            dgvDiemDanh.Columns.Add(checkColumn);

            dgvDiemDanh.Columns["MaTre"].HeaderText = "Mã trẻ";
            dgvDiemDanh.Columns["MaTre"].FillWeight = 50;
            dgvDiemDanh.Columns["HoTenTre"].HeaderText = "Họ Tên Trẻ";
            dgvDiemDanh.Columns["HoTenTre"].FillWeight = 150;
            dgvDiemDanh.Columns["NhanXet"].HeaderText = "Nhận Xét";
            dgvDiemDanh.Columns["NhanXet"].DisplayIndex = 3;
            dgvDiemDanh.Columns["HienDien"].Visible = false;
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
        private void LoadListLop()
        {
            cboLop.Items.Clear();
            cboLop.DisplayMember = "Text";
            cboLop.ValueMember = "Value";
            if (cboNamHoc.SelectedItem != null)
                foreach (Lop lop in LopBLL.GetListLop(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString())))
                    cboLop.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });
            cboLop.Text = "";
        }
        private void LuuBangDiemDanh(DataGridView dgvDiemDanh)
        {
            try
            {
                for (int i = 0; i < dgvDiemDanh.Rows.Count; i++)
                {
                    TheoDoiNgay bangdiemdanh = new TheoDoiNgay();
                    bangdiemdanh.MaTre = dgvDiemDanh.Rows[i].Cells["MaTre"].Value.ToString();
                    bangdiemdanh.NgayDiemDanh = dtNgayDiemDanh.Value.ToString("yyyy-MM-dd");
                    bangdiemdanh.HienDien = Int32.Parse(dgvDiemDanh.Rows[i].Cells["HienDien"].Value.ToString());
                    bangdiemdanh.NhanXet = dgvDiemDanh.Rows[i].Cells["NhanXet"].Value.ToString();
                    DiemDanhBLL.LuuBangDiemDanh(bangdiemdanh);
                }
                MessageBox.Show("Lưu điểm danh thành công", "Thông báo");
                loadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }

        }
        private void XoaPhieuCu()
        {
            string ngaylapphieu = dtNgayDiemDanh.Text;
            for (int i = 0; i < dgvDiemDanh.Rows.Count; i++)
            {
                DiemDanhBLL.XoaBangDiemDanh(dgvDiemDanh.Rows[i].Cells["MaTre"].Value.ToString(),
                    ngaylapphieu.Split('/')[0],
                    ngaylapphieu.Split('/')[1],
                    ngaylapphieu.Split('/')[2]);
            }
        }
        #endregion

     
    }
}
