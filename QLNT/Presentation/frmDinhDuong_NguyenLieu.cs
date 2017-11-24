using System;
using System.Collections.Generic;
using DevComponents.DotNetBar;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;

namespace QLNT.Presentation
{
    public partial class frmDinhDuong_NguyenLieu : Form
    {
        private string[] selectedNguyenLieu = new string[5];
        private string TuKhoa = "";
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        public frmDinhDuong_NguyenLieu(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            
        }

        private void frmDinhDuong_NguyenLieu_Load(object sender, EventArgs e)
        {
            getDataGridView();
            getCombobox();
            SetEnabledComponents(false);
            XoaTrang();
        }

        private void getDataGridView()
        {
            dgvNguyenLieu.DataSource = NguyenLieuBLL.LayDanhSachNguyenLieu(TuKhoa);
            string[] column = { "MaNguyenLieu", "TenNguyenLieu", "TenLoaiNL", "ChiSoDinhDuong", "SoLuongTon", "DonViTinh" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvNguyenLieu, column);

            dgvNguyenLieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNguyenLieu.Columns[0].HeaderText = "Mã nguyên liệu";
            dgvNguyenLieu.Columns[0].Width = 100;
            dgvNguyenLieu.Columns[1].HeaderText = "Tên nguyên liệu";
            dgvNguyenLieu.Columns[1].Width = 120;
            dgvNguyenLieu.Columns[2].HeaderText = "Loại nguyên liệu";
            dgvNguyenLieu.Columns[2].Width = 120;
            dgvNguyenLieu.Columns[3].HeaderText = "Chỉ số dinh dưỡng";
            dgvNguyenLieu.Columns[3].Width = 100;
            dgvNguyenLieu.Columns[4].HeaderText = "Số lượng tồn";
            dgvNguyenLieu.Columns[4].Width = 100;
            dgvNguyenLieu.Columns[5].HeaderText = "Đơn vị tính";
            dgvNguyenLieu.Columns[5].Width = 100;
            dgvNguyenLieu.ClearSelection();

        }


        private void getCombobox()
        {
            cboLoaiNguyenLieu.DataSource = LoaiNguyenLieuBLL.layDanhSachLoaiNguyenLieu();
            cboLoaiNguyenLieu.DisplayMember = "TenLoaiNL";
            cboLoaiNguyenLieu.ValueMember = "MaLoaiNL";
            cboLoaiNguyenLieu.Text = "";
        }

        private void SetEnabledComponents(bool value)
        {
            txtTenNguyenLieu.Enabled = value;
            cboLoaiNguyenLieu.Enabled = value;
            txtChiSoDinhDuong.Enabled = value;
            txtSoLuongTon.Enabled = value;
        }

        private void XoaTrang()
        {
            txtMaNguyenLieu.Text = NguyenLieuBLL.SinhMaTuDong();
            txtTenNguyenLieu.Text = "";
            txtChiSoDinhDuong.Text = "0";
            txtSoLuongTon.Text = "0";
            txtDonViTinh.Text = "g";
            cboLoaiNguyenLieu.Text = "";
            SetEnabledComponents(true);
            txtDonViTinh.Enabled = true;
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboLoaiNguyenLieu.Text = "";
            txtMaNguyenLieu.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["MaNguyenLieu"].Value.ToString();
            txtTenNguyenLieu.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["TenNguyenLieu"].Value.ToString();
            cboLoaiNguyenLieu.SelectedText = dgvNguyenLieu.Rows[e.RowIndex].Cells["TenLoaiNL"].Value.ToString();
            txtChiSoDinhDuong.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["ChiSoDinhDuong"].Value.ToString();
            txtSoLuongTon.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["SoLuongTon"].Value.ToString();
            txtDonViTinh.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguyenLieuBLL.LuuNguyenLieu(txtMaNguyenLieu.Text.Trim(),txtTenNguyenLieu.Text.Trim(), cboLoaiNguyenLieu.Text.Trim(), txtChiSoDinhDuong.Text.Trim(), txtSoLuongTon.Text.Trim(), txtDonViTinh.Text.Trim());
            getDataGridView();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NguyenLieuBLL.XoaNguyenLieu(txtMaNguyenLieu.Text.Trim());
            getDataGridView();
            XoaTrang();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TuKhoa = txtTimKiem.Text.Trim();
            getDataGridView();
            if (TuKhoa == "")
            {
                lblKetQua.Visible = false;
                lblSoKetQua.Visible = false;
                return;
            }
            lblKetQua.Visible = true;
            lblSoKetQua.Visible = true;
            lblSoKetQua.Text = dgvNguyenLieu.RowCount.ToString();
            XoaTrang();
        }
    }
}
