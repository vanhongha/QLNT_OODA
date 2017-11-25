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
using QLNT.Ultilities;
using QLNT.Entities;
using QLNT.BusinessLayer;

namespace QLNT.Presentation
{
    public partial class frmDinhDuong_ThucDon : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        public frmDinhDuong_ThucDon(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
        }

        private void frmDinhDuong_ThucDon_Load(object sender, EventArgs e)
        {
            getDataGridViewThucDon();
            getDataGridViewChiTietThucDon("");
            getComboBoxMonAn();

        }

        private void getDataGridViewThucDon()
        {
            dgvThucDon.DataSource = ThucDonBLL.LayDanhSachThucDon();
            string[] columns = { "MaThucDon", "NangLuong", "NguoiLap", "NgayLap", "TrangThai" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvThucDon, columns);

            dgvThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThucDon.Columns[0].HeaderText = "Mã thực đơn";
            dgvThucDon.Columns[0].Width = 120;
            dgvThucDon.Columns[1].HeaderText =  "Năng lượng (Kcal/gam)";
            dgvThucDon.Columns[1].Width = 120;
            dgvThucDon.Columns[2].HeaderText = "Người lập";
            dgvThucDon.Columns[2].Width = 100;
            dgvThucDon.Columns[3].HeaderText = "Ngày lập";
            dgvThucDon.Columns[3].Width = 100;
            dgvThucDon.Columns[4].HeaderText = "Trạng thái";
            dgvThucDon.Columns[4].Width = 120;
        }

        private void getDataGridViewChiTietThucDon(string maThucDon)
        {
            dgvChiTietThucDon.DataSource = ChiTietThucDonBLL.LayDanhSachChiTietThucDon(maThucDon);
            string[] columns = { "MaThucDon", "MaMonAn", "TenMonAn", "NangLuong" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvChiTietThucDon, columns);

            dgvChiTietThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietThucDon.Columns[0].HeaderText = "Mã thực đơn";
            dgvChiTietThucDon.Columns[0].Width = 120;
            dgvChiTietThucDon.Columns[1].HeaderText = "Mã Món Ăn";
            dgvChiTietThucDon.Columns[1].Width = 120;
            dgvChiTietThucDon.Columns[2].HeaderText = "Tên Món Ăn";
            dgvChiTietThucDon.Columns[2].Width = 120;
            dgvChiTietThucDon.Columns[3].HeaderText = "Năng lượng (Kcal/gam)";
            dgvChiTietThucDon.Columns[3].Width = 120;
        }

        private void getComboBoxMonAn()
        {
            cboMonAn.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonAn.DisplayMember = "TenMonAn";
            cboMonAn.ValueMember = "MaMonAn";
        }

        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvThucDon.RowCount)
                return;
            txtMaThucDon.Text = dgvThucDon.Rows[e.RowIndex].Cells["MaThucDon"].Value.ToString().Trim();
            txtNguoiLap.Text = dgvThucDon.Rows[e.RowIndex].Cells["NguoiLap"].Value.ToString().Trim();
            getDataGridViewChiTietThucDon(txtMaThucDon.Text);
        }

        private void dgvChiTietThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvChiTietThucDon.RowCount)
                return;

            cboMonAn.Text = dgvChiTietThucDon.Rows[e.RowIndex].Cells["TenMonAn"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThucDonBLL.ThemThucDon(ThucDonBLL.SinhMaTuDong());
            getDataGridViewThucDon();
            getDataGridViewChiTietThucDon(txtMaThucDon.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThucDonBLL.XoaThucDon(txtMaThucDon.Text.Trim());
            getDataGridViewThucDon();
            getDataGridViewChiTietThucDon("");
        }

        private void btnXoaTrangChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
