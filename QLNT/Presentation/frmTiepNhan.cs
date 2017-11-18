using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;

namespace QLNT.Presentation
{
    public partial class frmTiepNhan : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        #region Init
        public frmTiepNhan()
        {
            InitializeComponent();
        }
        public frmTiepNhan(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }
        private void frmTiepNhan_Load(object sender, EventArgs e)
        {
            Init();
            loadDataGridView();
        }

        private void Init()
        {
            txtMaPhieu.Text = PhieuTiepNhanBLL.GenMaPhieu().ToString();
            txtMaHocSinh.Text = TreBLL.GenMaTre().ToString();
            txtNgayTiepNhan.Text = DateTime.Now.ToString();
            //txtNguoiTiepNhan.Text = DangNhapBLL.GetThongTinNguoiDung().Rows[3].ToString();
            dateNgaySinh.MinDate = DateTime.Today.AddYears(-7);
            dateNgaySinh.MaxDate = DateTime.Today.AddYears(-2);
        }

        #endregion

        #region Functions
        private void loadDataGridView()
        {
            dgvTiepNhan.DataSource = TreBLL.GetListTre();
            dgvTiepNhan.Columns[0].HeaderText = "Mã trẻ";
            dgvTiepNhan.Columns[1].HeaderText = "Họ tên trẻ";
            dgvTiepNhan.Columns[2].HeaderText = "Ngày sinh";
            dgvTiepNhan.Columns[3].HeaderText = "Giới tính";
            dgvTiepNhan.Columns[4].HeaderText = "Họ tên cha";
            dgvTiepNhan.Columns[5].HeaderText = "Họ tên mẹ";
            dgvTiepNhan.Columns[6].HeaderText = "Địa chỉ";
            dgvTiepNhan.Columns[7].HeaderText = "SDT";

            dgvTiepNhan.Columns[0].Width = 100;
            dgvTiepNhan.Columns[1].Width = 150;
            dgvTiepNhan.Columns[2].Width = 120;
            dgvTiepNhan.Columns[3].Width = 80;
            dgvTiepNhan.Columns[4].Width = 150;
            dgvTiepNhan.Columns[5].Width = 150;
            dgvTiepNhan.Columns[6].Width = 200;
            dgvTiepNhan.Columns[7].Width = 100;

        }
        private void CleanInput()
        {
            txtHoTen.Text = "";
            txtHoTenCha.Text = "";
            txtHoTenMe.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            dateNgaySinh.ResetText();
            rdbNam.Checked = true;
            rdbNu.Checked = false;
        }
        #endregion

        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length > 50
                || txtHoTenCha.Text.Length > 50
                || txtHoTenMe.Text.Length > 50
                || txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Các trường họ tên không được quá dài (ít hơn 50 ký tự)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Tre hocsinhmoi = new Tre(txtMaHocSinh.Text, txtHoTen.Text,
            rdbNam.Checked == true ? "Nam" : "Nu",
            dateNgaySinh.Value,
            txtHoTenCha.Text,
            txtHoTenMe.Text,
            txtDiaChi.Text,
            txtSDT.Text);

            try
            {
                if (TreBLL.ThemTre(hocsinhmoi))
                {
                    MessageBox.Show("Đã thêm trẻ thành công", "Thông báo", MessageBoxButtons.OK);
                    CleanInput();
                    loadDataGridView();
                }
                else
                    MessageBox.Show("Lỗi chưa xác định", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        #endregion
        string maTre;
        private void dgvTiepNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvTiepNhan.RowCount)
                {
                    maTre = dgvTiepNhan.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                    LayThongTinTre(maTre);
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void LayThongTinTre(string maTre)
        {
            string gioiTinh;
            DataTable dt = TreBLL.LayThongTinTre(maTre);
            txtHoTen.Text = dt.Rows[0]["HoTenTre"].ToString();

            gioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            if (gioiTinh == "Nam")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;

            //dtNgaySinh.Value = DateTime.ParseExact(dt.Rows[0]["HoTenMe"].ToString(), "dd/MM/yyy", null);

            txtHoTenMe.Text = dt.Rows[0]["HoTenMe"].ToString();
            txtHoTenCha.Text = dt.Rows[0]["HoTenCha"].ToString();
            txtSDT.Text = dt.Rows[0]["SDTLienLac"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Tre tre = new Tre();

                tre.MaTre = maTre;
                tre.HoTen = txtHoTen.Text;

                if (rdbNam.Checked)
                    tre.GioiTinh = "Nam";
                else
                    tre.GioiTinh = "Nu";

                tre.NgaySinh = dateNgaySinh.Value;
                tre.TenCha = txtHoTenCha.Text;
                tre.TenMe = txtHoTenMe.Text;
                tre.DiaChi = txtDiaChi.Text;
                tre.DienThoai = txtSDT.Text;

                MessageBox.Show(tre.MaTre);

                TreBLL.CapNhatThongTinTre(tre);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                loadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Init();
            CleanInput();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa trẻ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    TreBLL.XoaTre(maTre);
                    MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CleanInput();
                    loadDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    
    }
}
