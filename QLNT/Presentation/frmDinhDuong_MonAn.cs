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
using QLNT.Ultilities;
using QLNT.BusinessLayer;
using QLNT.Entities;

namespace QLNT.Presentation
{
    public partial class frmDinhDuong_MonAn : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        public frmDinhDuong_MonAn(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
        }

        private void frmDinhDuong_MonAn_Load(object sender, EventArgs e)
        {
            getDataGridViewMonAn();
            getCombobox();
        }

        private void getDataGridViewMonAn()
        {
            dgvMonAn.DataSource = MonAnBLL.LayDanhSachMonAn();

            string[] column = { "MaMonAn", "TenMonAn", "NangLuong" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvMonAn, column);
            dgvMonAn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMonAn.Columns[0].HeaderText = "Mã món ăn";
            dgvMonAn.Columns[0].Width = 160;
            dgvMonAn.Columns[1].HeaderText = "Tên món ăn";
            dgvMonAn.Columns[1].Width = 160;
            dgvMonAn.Columns[2].HeaderText = "Năng lượng (Kcal/gam)";
            dgvMonAn.Columns[2].Width = 160;

            dgvMonAn.ClearSelection();
            dgvMonAn.CurrentCell = null;
        }

        private void getDataGridViewChiTietMonAn(string maMon)
        {

            dgvChiTietMonAn.DataSource = ChiTietMonAnBLL.LayDanhSachChiTietMonAn(maMon);

            string[] column = {"TenNguyenLieu", "TenLoaiNL","SoLuong", "NangLuong"};
            Ultilities.ControlFormat.DataGridViewFormat(dgvChiTietMonAn, column);

            //dgvDanhSachMuaNL.ColumnCount.ToString();
            //MessageBox.Show(dgvDanhSachMuaNL.ColumnCount.ToString());

            dgvChiTietMonAn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietMonAn.Columns[0].HeaderText = "Tên Nguyên Liệu";
            dgvChiTietMonAn.Columns[0].Width = 140;
            dgvChiTietMonAn.Columns[1].HeaderText = "Loại Nguyên Liệu";
            dgvChiTietMonAn.Columns[1].Width = 120;
            dgvChiTietMonAn.Columns[2].HeaderText = "Khối Lượng (gam)";
            dgvChiTietMonAn.Columns[2].Width = 120;
            dgvChiTietMonAn.Columns[3].HeaderText = "Năng Lượng (Kcal/gam)";
            dgvChiTietMonAn.Columns[3].Width = 120;
            dgvChiTietMonAn.ClearSelection();
            XoaTrang();
        }

        private void getCombobox()
        {
            cboChonNguyenLieu.DataSource = NguyenLieuBLL.LayDanhSachTenVaMaNguyenLieu();
            cboChonNguyenLieu.DisplayMember = "TenNguyenLieu";
            cboChonNguyenLieu.ValueMember = "MaNguyenLieu";
            cboChonNguyenLieu.Text = "";
        }

        private void XoaTrang()
        {
            txtNangLuongChiTiet.Text = "0";
            txtKhoiLuong.Text = "10";
            cboChonNguyenLieu.Text = "";

        }

        private void setTextInfo()
        {
            txtMaMonAn.Text = "";
            txtNangLuongChiTiet.Text = "";

            txtKhoiLuong.Text = "";
            txtTenMonAn.Text = "";
            cboChonNguyenLieu.Text = "";
        }

        public void setEnabledComponent(bool value)
        {
            cboChonNguyenLieu.Enabled = value;
            txtKhoiLuong.Enabled = value;
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells["MaMonAn"].Value.ToString().Trim();
            txtTenMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells["TenMonAn"].Value.ToString().Trim();
            txtNangLuong.Text = dgvMonAn.Rows[e.RowIndex].Cells["NangLuong"].Value.ToString().Trim();
            getDataGridViewChiTietMonAn(txtMaMonAn.Text);
        }

        private void dgvChiTietMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex > dgvChiTietMonAn.RowCount))
            {
                XoaTrang();
                return;
            }

            cboChonNguyenLieu.Text = dgvChiTietMonAn.Rows[e.RowIndex].Cells["TenNguyenLieu"].Value.ToString();
            if (cboChonNguyenLieu.Text == "")
                return;

            cboChonNguyenLieu.Enabled = false;
            txtKhoiLuong.Text = dgvChiTietMonAn.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString().Trim();
            txtNangLuongChiTiet.Text = dgvChiTietMonAn.Rows[e.RowIndex].Cells["NangLuong"].Value.ToString().Trim();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaMonAn.Text = MonAnBLL.SinhMaTuDong();
            txtTenMonAn.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MonAnBLL.LuuMonAn(txtMaMonAn.Text.Trim(), txtTenMonAn.Text.Trim());
            getDataGridViewMonAn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonAnBLL.XoaMonAn(txtMaMonAn.Text);
            txtMaMonAn.Text = MonAnBLL.SinhMaTuDong();
            txtTenMonAn.Text = "";
            getDataGridViewMonAn();
        }

        private void btnLuuChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietMonAnBLL.LuuChiTietMonAn(txtMaMonAn.Text.Trim(), 
                cboChonNguyenLieu.Text.Trim(), 
                int.Parse(txtKhoiLuong.Text.Trim()));
            getDataGridViewMonAn();
            getDataGridViewChiTietMonAn(txtMaMonAn.Text.Trim());
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietMonAnBLL.XoaChiTietMonAn(txtMaMonAn.Text.Trim(), cboChonNguyenLieu.Text.Trim());
            XoaTrang();
            getDataGridViewChiTietMonAn(txtMaMonAn.Text.Trim());
        }

        private void btnXoaTrangNL_Click(object sender, EventArgs e)
        {
            XoaTrang();
            setEnabledComponent(true);
        }
    }
}
