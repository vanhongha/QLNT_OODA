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
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmDinhDuong_MonAn_Load(object sender, EventArgs e)
        {
            getDataGridViewMonAn();
            getCombobox();
            setEnableChiTietMonAn(false);
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
            getDataGridViewChiTietMonAn("");
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
            txtMaMonAn.Text = MonAnBLL.SinhMaTuDong();
            txtTenMonAn.Text = "";
        }

        private void XoaTrangChiTiet()
        {
            txtNangLuongChiTiet.Text = "0";
            txtKhoiLuong.Text = "";
            cboChonNguyenLieu.Text = "";

        }

        public void setEnableChiTietMonAn(bool value)
        {
            txtKhoiLuong.Enabled = value;
            cboChonNguyenLieu.Enabled = value;
            btnLuuChiTiet.Enabled = value;
            btnXoaChiTiet.Enabled = value;
        }

        private void SetEnabledComponents(bool value)
        {
            lblNote.Visible = !value;
            setEnableChiTietMonAn(value);
        }

        private void setTextInfo()
        {
            txtMaMonAn.Text = "";
            txtNangLuongChiTiet.Text = "";

            txtKhoiLuong.Text = "";
            txtTenMonAn.Text = "";
            cboChonNguyenLieu.Text = "";
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex > dgvMonAn.RowCount))
            {
                return;
            }
            txtMaMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells["MaMonAn"].Value.ToString().Trim();
            txtTenMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells["TenMonAn"].Value.ToString().Trim();
            getDataGridViewChiTietMonAn(txtMaMonAn.Text);

            XoaTrangChiTiet();
            SetEnabledComponents(!MonAnBLL.KiemTraMonAnTrongThucDon(txtMaMonAn.Text));

        }

        private void dgvChiTietMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0) || (e.RowIndex > dgvChiTietMonAn.RowCount))
            {
                XoaTrangChiTiet();
                return;
            }

            cboChonNguyenLieu.Text = dgvChiTietMonAn.Rows[e.RowIndex].Cells["TenNguyenLieu"].Value.ToString();
            if (cboChonNguyenLieu.Text == "")
                return;
            
            txtKhoiLuong.Text = dgvChiTietMonAn.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString().Trim();
            txtNangLuongChiTiet.Text = dgvChiTietMonAn.Rows[e.RowIndex].Cells["NangLuong"].Value.ToString().Trim();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MonAnBLL.LuuMonAn(txtMaMonAn.Text.Trim(), txtTenMonAn.Text.Trim());
            getDataGridViewMonAn();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonAnBLL.XoaMonAn(txtMaMonAn.Text);
            XoaTrang();
            getDataGridViewMonAn();
            XoaTrangChiTiet();

        }

        private void btnLuuChiTiet_Click(object sender, EventArgs e)
        {
            if (MonAnBLL.KiemTraMonAnTrongThucDon(txtMaMonAn.Text)){
                SetEnabledComponents(false);
                MessageBox.Show("Không thể cập nhật chi tiết của món ăn đã được áp dụng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (ChiTietMonAnBLL.LuuChiTietMonAn(txtMaMonAn.Text.Trim(), 
                cboChonNguyenLieu.Text.Trim(), txtKhoiLuong.Text))
            {
                getDataGridViewMonAn();
                getDataGridViewChiTietMonAn(txtMaMonAn.Text.Trim());
            }
            
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (MonAnBLL.KiemTraMonAnTrongThucDon(txtMaMonAn.Text))
            {
                SetEnabledComponents(false);
                MessageBox.Show("Không thể xóa chi tiết của món ăn đã được áp dụng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            ChiTietMonAnBLL.XoaChiTietMonAn(txtMaMonAn.Text.Trim(), cboChonNguyenLieu.Text.Trim());
            XoaTrangChiTiet();
            getDataGridViewMonAn();
            getDataGridViewChiTietMonAn(txtMaMonAn.Text.Trim());
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            getCombobox();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void txtKhoiLuong_TextChanged(object sender, EventArgs e)
        {
            txtNangLuongChiTiet.Text = ChiTietMonAnBLL.TinhNangLuong(txtKhoiLuong, cboChonNguyenLieu.Text.ToString()).ToString();
            
        }
    }
}
