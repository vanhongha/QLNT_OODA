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
    public partial class frmDinhDuong_ApDungThucDon : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        string maThucDon = "";
        public frmDinhDuong_ApDungThucDon(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
        }

        private void frmDinhDuong_ApDungThucDon_Load(object sender, EventArgs e)
        {
            getComboboxLoaiLop();
            getDataGridViewThucDon();
            initForm();
        }

        public void getDataGridViewLop(string maLop, int thang, int nam)
        {
            setCheckBoxColumn();
            dgvLop.DataSource = LopBLL.GetSucKhoeTheoLop(maLop, thang, nam);
            string[] column = { "X", "MaTre", "HoTenTre", "BMI", "TinhTrang", "GhiChu" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvLop, column);

            dgvLop.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLop.Columns[1].HeaderText = "Mã Trẻ";
            dgvLop.Columns[1].Width = 120;
            dgvLop.Columns[2].HeaderText = "Tên Trẻ";
            dgvLop.Columns[2].Width = 120;
            dgvLop.Columns[3].HeaderText = "BMI";
            dgvLop.Columns[3].Width = 70;
            dgvLop.Columns[4].HeaderText = "Tình Trạng";
            dgvLop.Columns[4].Width = 120;
            dgvLop.Columns[5].HeaderText = "Ghi Chú";
            dgvLop.Columns[5].Width = 120;
            dgvLop.ClearSelection();
        }

        private void getDataGridViewThucDon()
        {
            dgvThucDon.ClearSelection();
            dgvThucDon.DataSource = ThucDonBLL.LayDanhSachThucDon();
            string[] columns = { "MaThucDon", "NangLuong", "NguoiLap", "NgayLap", "TrangThai" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvThucDon, columns);

            dgvThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThucDon.Columns[0].HeaderText = "Mã thực đơn";
            dgvThucDon.Columns[0].Width = 120;
            dgvThucDon.Columns[1].HeaderText = "Năng lượng (Kcal/gam)";
            dgvThucDon.Columns[1].Width = 120;
            dgvThucDon.Columns[2].HeaderText = "Người lập";
            dgvThucDon.Columns[2].Width = 100;
            dgvThucDon.Columns[3].HeaderText = "Ngày lập";
            dgvThucDon.Columns[3].Width = 100;
            dgvThucDon.Columns[4].HeaderText = "Trạng thái";
            dgvThucDon.Columns[4].Width = 120;
            dgvThucDon.ClearSelection();
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
            dgvChiTietThucDon.ClearSelection();
        }

        public void getComboboxLoaiLop()
        {
            cboLoaiLop.DataSource = LopBLL.GetListLoaiLop();
            cboLoaiLop.DisplayMember = "TenLoaiLop";
            cboLoaiLop.ValueMember = "MaLoaiLop";
        }

        public void getComboboxLop()
        {
            cboLop.DataSource = LopBLL.GetListLop(LopBLL.getMaNamHoc(dtpNgay_Loc.Value), cboLoaiLop.SelectedValue.ToString().Trim());
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        private void setCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvLop.Columns.Clear();
            dgvLop.Columns.Add(checkBoxColumn);
        }

        public void initForm()
        {
            dtpNgay_Loc.Value = DateTime.Today;
            cboBuoiAD.SelectedText = "Sáng";
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboboxLop();
        }

        private void dtpNgay_Loc_ValueChanged(object sender, EventArgs e)
        {
            getComboboxLop();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataGridViewLop(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
        }

        private void dgvThucDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvThucDon.RowCount)
                return;
            maThucDon = dgvThucDon.Rows[e.RowIndex].Cells["MaThucDon"].Value.ToString();
            getDataGridViewChiTietThucDon(maThucDon);
        }
    }
}
