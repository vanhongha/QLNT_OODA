using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmQLChung_Lop : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        private List<NamHoc> listNienKhoa;
        private List<LoaiLop> listLoaiLop;
        private List<Lop> listLop;
        private int siSoToiDaHienTai;

        public frmQLChung_Lop(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            this.tabControl = _tabControl;
            this.tab = _tab;
        }

        private void frmQLChung_Lop_Load(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            listNienKhoa = LopBLL.GetListNienKhoa();
            listLoaiLop = LopBLL.GetListLoaiLop();
            listLop = LopBLL.GetListLop();
            LoadListGiaoVien();
            LoadValueInDGV();
            Init();
        }

        #region Function
        void Init()
        {
            rdoQLLop.Checked = true;           
            
            LoadDatagridView();
            LoadGroup("Lop");
            ComboboxLoad.LoaiLop(cboLoaiLop);
            ComboboxLoad.NienKhoa(cboNienKhoa);
        }

        void LoadListGiaoVien()
        {
            cboGiangVien.DataSource = LopBLL.GetListGiaoVien();
        }

        // Lấy mã => đõ ra value trong mấy cột của datagridview
        void LoadValueInDGV()
        {
            foreach(Lop lop in listLop)
            {
                lop.MaLoaiLop = listLoaiLop.FirstOrDefault(c => c.MaLoaiLop == lop.MaLoaiLop).TenLoaiLop;
                lop.MaNamHoc = listNienKhoa.FirstOrDefault(c => c.MaNamHoc == lop.MaNamHoc).NienKhoa;
            }
        }

        void LoadDatagridView()
        {
            //LoadValueInDGV();
            // QL lớp
            if (rdoQLLop.Checked)
            {
                dgvDanhSach.DataSource = listLop;

                dgvDanhSach.Columns[0].HeaderText = "Mã lớp";
                dgvDanhSach.Columns[1].HeaderText = "Tên lớp";
                dgvDanhSach.Columns[2].HeaderText = "Niên khóa";
                dgvDanhSach.Columns[3].HeaderText = "Loại lớp";
                dgvDanhSach.Columns[4].HeaderText = "Sĩ số";
                dgvDanhSach.Columns[5].HeaderText = "Giáo viên";
            }
            // QL loại lớp
            else if (rdoQLLoaiLop.Checked)
            {
                dgvDanhSach.DataSource = listLoaiLop;

                dgvDanhSach.Columns[0].HeaderText = "Mã loại lớp";
                dgvDanhSach.Columns[1].HeaderText = "Tên loại lớp";
            }
            // QL niên khóa
            else
            {
                dgvDanhSach.DataSource = listNienKhoa;
                dgvDanhSach.Columns[0].HeaderText = "Mã niên khóa";
                dgvDanhSach.Columns[1].HeaderText = "Tên niên khóa";
                dgvDanhSach.Columns[2].HeaderText = "Thời gian bắt đầu";
                dgvDanhSach.Columns[3].HeaderText = "Thời gian kết thúc";

                dgvDanhSach.Columns[2].Width = 140;
                dgvDanhSach.Columns[3].Width = 140;
            }
        }

        void LoadGroup(string tenGroup)
        {
            switch(tenGroup)
            {
                case "Lop":
                    grpQLLop.Enabled = true;
                    grpQLLop.Visible = true;

                    grpQLLoaiLop.Enabled = false;
                    grpQLLoaiLop.Visible = false;
                    grpQLNienKhoa.Enabled = false;
                    grpQLNienKhoa.Visible = false;
                    grpQLQuyDinh.Visible = false;
                    grpQLQuyDinh.Enabled = false;
                    break;
                case "NienKhoa":
                    grpQLNienKhoa.Enabled = true;
                    grpQLNienKhoa.Visible = true;

                    grpQLLoaiLop.Enabled = false;
                    grpQLLoaiLop.Visible = false;
                    grpQLLop.Enabled = false;
                    grpQLLop.Visible = false;
                    grpQLQuyDinh.Visible = false;
                    grpQLQuyDinh.Enabled = false;
                    break;
                case "LoaiLop":
                    grpQLLoaiLop.Enabled = true;
                    grpQLLoaiLop.Visible = true;

                    grpQLNienKhoa.Enabled = false;
                    grpQLNienKhoa.Visible = false;
                    grpQLLop.Enabled = false;
                    grpQLLop.Visible = false;
                    grpQLQuyDinh.Visible = false;
                    grpQLQuyDinh.Enabled = false;
                    break;
                case "QuyDinh":
                    grpQLQuyDinh.Visible = true;
                    grpQLQuyDinh.Enabled = true;

                    grpQLLoaiLop.Enabled = false;
                    grpQLLoaiLop.Visible = false;
                    grpQLNienKhoa.Enabled = false;
                    grpQLNienKhoa.Visible = false;
                    grpQLLop.Enabled = false;
                    grpQLLop.Visible = false;
                    dgvDanhSach.Visible = false;
                    dgvDanhSach.Enabled = false;
                    btnThem.Enabled = false;
                    btnCapNhat.Enabled = true;                  
                    break;
            }
        }

        void LamMoi()
        {
            txtMaLoaiLop.Text = "";
            txtMaLop.Text = "";
            txtMaNienKhoa.Text = "";
            txtSiSo.Text = "";
            txtTenLoaiLop.Text = "";
            txtTenLop.Text = "";
            txtTenNienKhoa.Text = "";
            cboBaoMau1.Text = "";
            cboBaoMau2.Text = "";
            cboGiangVien.Text = "";
            cboLoaiLop.Text = "";
            cboNienKhoa.Text = "";
            dtNgayBatDau.Text = "";
            dtNgayKetThuc.Text = "";
            cboLoaiLop.Enabled = true;
            cboNienKhoa.Enabled = true;
            dtNgayBatDau.Enabled = true;
            dtNgayKetThuc.Enabled = true;
            btnThem.Enabled = true;
        }

        void ThemLop(string maLop, string maLoaiLop, string maNienKhoa, string maGV, string tenLop)
        {
            if (LopBLL.ThemLop(maLop,
                           maLoaiLop,
                           maNienKhoa,
                           maGV,
                           tenLop))
            {
                MessageBox.Show("Thêm lớp thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                listLop = LopBLL.GetListLop();
                LoadDatagridView();
            }
        }

        void ThemLoaiLop(string maLoaiLop, string tenLoaiLop)
        {
            if (LopBLL.ThemLoaiLop(maLoaiLop, tenLoaiLop))
            {
                MessageBox.Show("Thêm loại lớp thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                listLoaiLop = LopBLL.GetListLoaiLop();
                LoadDatagridView();
            }
        }

        void ThemNienKhoa(string maNienKhoa, string tenNienKhoa, DateTime tgBatDau, DateTime tgKetThuc)
        {
            if (LopBLL.ThemNienKhoa(maNienKhoa, tenNienKhoa, tgBatDau, tgKetThuc))
            {
                MessageBox.Show("Thêm niên khóa thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                listNienKhoa = LopBLL.GetListNienKhoa();
                LoadDatagridView();
            }
        }
        #endregion

        #region Event
        private void rdoQLLop_CheckedChanged(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            LoadDatagridView();
            LamMoi();
            LoadGroup("Lop");

        }

        private void rdoQLLoaiLop_CheckedChanged(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            LoadDatagridView();
            LamMoi();
            LoadGroup("LoaiLop");
        }

        private void rdoQLNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            LoadDatagridView();
            LamMoi();
            LoadGroup("NienKhoa");
        }

        private void rdoQuyDinh_CheckedChanged(object sender, EventArgs e)
        {
            txtSiSoToiDa.Text = LopBLL.GetSiSoToiDa().ToString();
            siSoToiDaHienTai = LopBLL.GetSiSoToiDa();
            LoadGroup("QuyDinh");
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoQLLop.Checked)
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvDanhSach.RowCount)
                {
                    txtMaLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                    txtTenLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
                    cboNienKhoa.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaNamHoc"].Value.ToString();
                    txtSiSo.Text = dgvDanhSach.Rows[e.RowIndex].Cells["SiSo"].Value.ToString();
                    cboGiangVien.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
                    cboLoaiLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaLoaiLop"].Value.ToString();

                    cboNienKhoa.Enabled = false;
                    cboLoaiLop.Enabled = false;
                }
            }
            else if(rdoQLLoaiLop.Checked)
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvDanhSach.RowCount)
                {
                    txtMaLoaiLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaLoaiLop"].Value.ToString();
                    txtTenLoaiLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenLoaiLop"].Value.ToString();
                }
            }
            else
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvDanhSach.RowCount)
                {
                    txtMaNienKhoa.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaNamHoc"].Value.ToString();
                    txtTenNienKhoa.Text = dgvDanhSach.Rows[e.RowIndex].Cells["NienKhoa"].Value.ToString();

                    DateTime ngayBatDau = DateTime.ParseExact(Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells["NgayBatDau"].EditedFormattedValue).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dtNgayBatDau.Value = ngayBatDau;
                    DateTime ngayKetThuc = DateTime.ParseExact(Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells["NgayKetThuc"].EditedFormattedValue).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dtNgayKetThuc.Value = ngayKetThuc;

                    dtNgayBatDau.Enabled = false;
                    dtNgayKetThuc.Enabled = false;            
                }
            }
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            btnCapNhat.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {            
            if (rdoQLLop.Checked)
            {
                if(LopBLL.CapNhatLop(txtMaLop.Text, txtTenLop.Text, cboGiangVien.Text))
                {
                    MessageBox.Show("Cập nhật lớp thành công!",
                     "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
                    listLop = LopBLL.GetListLop();
                    LoadDatagridView();
                    LoadValueInDGV();
                }
            }
            else if(rdoQLLoaiLop.Checked)
            {
                if(LopBLL.CapNhatLoaiLop(txtMaLoaiLop.Text, txtTenLoaiLop.Text))
                {
                    MessageBox.Show("Cập nhật loại lớp thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    listLoaiLop = LopBLL.GetListLoaiLop();
                    listLop = LopBLL.GetListLop();
                    LoadDatagridView();
                }
            }
            else if(rdoQuyDinh.Checked)
            {
                if(LopBLL.CapNhatSiSoToiDa(siSoToiDaHienTai, Convert.ToInt32(txtSiSoToiDa.Text)))
                {
                    MessageBox.Show("Cập nhật sĩ số lớp tối đa thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
            {
                if (LopBLL.CapNhatNienKhoa(txtMaNienKhoa.Text, txtTenNienKhoa.Text))
                {
                    MessageBox.Show("Cập nhật niên khóa thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    listNienKhoa = LopBLL.GetListNienKhoa();
                    listLop = LopBLL.GetListLop();
                    LoadDatagridView();
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rdoQLLop.Checked)
            {
                if (!string.IsNullOrEmpty(txtTenLop.Text) && !string.IsNullOrEmpty(cboNienKhoa.Text) && !string.IsNullOrEmpty(cboGiangVien.Text))
                {
                    string maNienKhoa = KeyHandle.GetKeyFromCombobox(cboNienKhoa.SelectedItem.ToString());
                    DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(maNienKhoa);
                    DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(maNienKhoa); ;
                    if (Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
                    {
                        if (cboLoaiLop.SelectedItem != null)
                        {
                            ThemLop(LopBLL.GenMaLop(),
                              KeyHandle.GetKeyFromCombobox(cboLoaiLop.SelectedItem.ToString()),
                              maNienKhoa,
                              cboGiangVien.SelectedItem.ToString(),
                              txtTenLop.Text);
                            LoadValueInDGV();
                        }
                        else MessageBox.Show("Vui lòng chọn loại lớp!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DialogResult r = MessageBox.Show("Niên khóa hiện tại đang không còn hoạt động. Bạn có chắc là muốn tạo lớp này?",
                            "Thông báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);
                        if (r == DialogResult.Yes)
                        {
                            if (cboLoaiLop.SelectedItem != null)
                            {
                                ThemLop(LopBLL.GenMaLop(),
                                 KeyHandle.GetKeyFromCombobox(cboLoaiLop.SelectedItem.ToString()),
                                 maNienKhoa,
                                 cboGiangVien.SelectedItem.ToString(),
                                 txtTenLop.Text);
                                LoadValueInDGV();
                            }
                            else MessageBox.Show("Vui lòng chọn loại lớp!",
                              "Thông báo",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi tạo lớp mới!",
                           "Thông báo",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
            }
            else if(rdoQLLoaiLop.Checked)
            {
                if(!string.IsNullOrEmpty(txtTenLoaiLop.Text))                
                    ThemLoaiLop(LopBLL.GenMaLoaiLop(), txtTenLoaiLop.Text);                
                else
                    MessageBox.Show("Vui lòng điền đầy tên loại lớp trước khi tạo loại lớp mới!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtTenNienKhoa.Text))
                {
                    if (dtNgayBatDau.Value.Date > dtNgayKetThuc.Value.Date)
                        MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!",
                          "Thông báo",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning);
                    else
                        ThemNienKhoa(LopBLL.GenMaNienKhoa(), txtTenNienKhoa.Text, dtNgayBatDau.Value.Date, dtNgayKetThuc.Value.Date);
                }
                else
                    MessageBox.Show("Vui lòng điền tên niên khóa!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            listNienKhoa = LopBLL.GetListNienKhoa();
            listLoaiLop = LopBLL.GetListLoaiLop();
            listLop = LopBLL.GetListLop();
            LoadValueInDGV();
            Init();
        }
        #endregion


    }
}
