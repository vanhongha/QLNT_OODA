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
        DataTable tableMonAn = new DataTable("MONAN");
        TabItem tab;
        List<string> listMonAn = new List<string>();
        List<string> listTre = new List<string>();
        public frmDinhDuong_ApDungThucDon(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
        }

        private void frmDinhDuong_ApDungThucDon_Load(object sender, EventArgs e)
        {
            getComboboxLoaiLop();
            getDataGridViewMonAn();
            dtpNgay_Loc.Value = DateTime.Today;
            cboBuoiAD.SelectedText = "Sáng";
        }

        public void getDataGridViewTreChuaXetThucDon(string maLop, int thang, int nam)
        {
            setCheckBoxColumn(dgvTreChuaXetThucDon);
            dgvTreChuaXetThucDon.DataSource = ThongTinThucDonBLL.LayDanhSachTreChuaXetThucDon(maLop, thang, nam, cboBuoiAD.Text.ToString().Trim(), dtpNgay_Loc.Value);
            string[] column = { "X", "MaTre", "HoTenTre", "BMI", "TinhTrang", "GhiChu" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvTreChuaXetThucDon, column);

            dgvTreChuaXetThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTreChuaXetThucDon.Columns[1].HeaderText = "Mã Trẻ";
            dgvTreChuaXetThucDon.Columns[1].Width = 100;
            dgvTreChuaXetThucDon.Columns[2].HeaderText = "Tên Trẻ";
            dgvTreChuaXetThucDon.Columns[2].Width = 120;
            dgvTreChuaXetThucDon.Columns[3].HeaderText = "BMI";
            dgvTreChuaXetThucDon.Columns[3].Width = 50;
            dgvTreChuaXetThucDon.Columns[4].HeaderText = "Tình Trạng";
            //dgvLop.Columns[4].Width = 100;
            dgvTreChuaXetThucDon.Columns[5].HeaderText = "Ghi Chú";
            dgvTreChuaXetThucDon.Columns[5].Width = 100;
            dgvTreChuaXetThucDon.ClearSelection();
        }

        public void getDataGridViewTreDaXetThucDon(string maLop, int thang, int nam)
        {
            setCheckBoxColumn(dgvTreDaXetThucDon);
            dgvTreDaXetThucDon.DataSource = ThongTinThucDonBLL.LayDanhSachTreDaXetThucDon(maLop, thang, nam, cboBuoiAD.Text.ToString().Trim(), dtpNgay_Loc.Value);
            string[] column = { "X", "MaTre", "HoTenTre", "BMI", "TinhTrang", "GhiChu" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvTreDaXetThucDon, column);

            dgvTreDaXetThucDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTreDaXetThucDon.Columns[1].HeaderText = "Mã Trẻ";
            dgvTreDaXetThucDon.Columns[1].Width = 100;
            dgvTreDaXetThucDon.Columns[2].HeaderText = "Tên Trẻ";
            dgvTreDaXetThucDon.Columns[2].Width = 120;
            dgvTreDaXetThucDon.Columns[3].HeaderText = "BMI";
            dgvTreDaXetThucDon.Columns[3].Width = 50;
            dgvTreDaXetThucDon.Columns[4].HeaderText = "Tình Trạng";
            //dgvLop.Columns[4].Width = 100;
            dgvTreDaXetThucDon.Columns[5].HeaderText = "Ghi Chú";
            dgvTreDaXetThucDon.Columns[5].Width = 100;
            dgvTreDaXetThucDon.ClearSelection();
        }

        public void getDataGridViewMonAn()
        {
            tableMonAn = MonAnBLL.initDgvMonAn(tableMonAn);
            dgvMonAn.DataSource = tableMonAn;
            dgvMonAn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMonAn.Columns[0].HeaderText = "Tên Món Ăn";
            dgvMonAn.Columns[0].Width = 120;
            dgvMonAn.Columns[1].HeaderText = "Năng Lượng";
            dgvMonAn.Columns[1].Width = 120;
            dgvMonAn.ClearSelection();
        }

        public void getComboboxLoaiLop()
        {
            cboLoaiLop.DataSource = LopBLL.GetListLoaiLop();
            cboLoaiLop.DisplayMember = "TenLoaiLop";
            cboLoaiLop.ValueMember = "MaLoaiLop";
            getComboBoxMonAn();
        }

        public void getComboboxLop()
        {
            cboLop.DataSource = LopBLL.GetListLop(LopBLL.getMaNamHoc(dtpNgay_Loc.Value), cboLoaiLop.SelectedValue.ToString().Trim());
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            try
            {
                //cboLop.SelectedText = cboLop.Items.
            }
            catch(Exception err)
            {

            }
        }

        public void getComboBoxMonAn()
        {
            cboTenMonAn.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboTenMonAn.DisplayMember = "TenMonAn";
            cboTenMonAn.ValueMember = "MaMonAn";
            cboTenMonAn.Text = "";

            //cboMonChinh.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            //cboMonChinh.DisplayMember = "TenMonAn";
            //cboMonChinh.ValueMember = "MaMonAn";
            //cboMonChinh.Text = "";

            //cboMonPhu1.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            //cboMonPhu1.DisplayMember = "TenMonAn";
            //cboMonPhu1.ValueMember = "MaMonAn";
            //cboMonPhu1.Text = "";

            //cboMonPhu2.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            //cboMonPhu2.DisplayMember = "TenMonAn";
            //cboMonPhu2.ValueMember = "MaMonAn";
            //cboMonPhu2.Text = "";

            //cboMonPhu3.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            //cboMonPhu3.DisplayMember = "TenMonAn";
            //cboMonPhu3.ValueMember = "MaMonAn";
            //cboMonPhu3.Text = "";

            //cboMonPhu4.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            //cboMonPhu4.DisplayMember = "TenMonAn";
            //cboMonPhu4.ValueMember = "MaMonAn";
            //cboMonPhu4.Text = "";

            //cboMonPhu5.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            //cboMonPhu5.DisplayMember = "TenMonAn";
            //cboMonPhu5.ValueMember = "MaMonAn";
            //cboMonPhu5.Text = "";
        }

        private void getComboboxMonAnTheoTuKhoa(ComboBox cbo)
        {
            cbo.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn(cboBuoiAD.Text);
            cbo.DisplayMember = "TenMonAn";
            cbo.ValueMember = "MaMonAn";
        }

        private void setCheckBoxColumn(DataGridView dgv)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgv.Columns.Clear();
            dgv.Columns.Add(checkBoxColumn);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataGridViewTreChuaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
            getDataGridViewTreDaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
        }

        private void cboMonChinh_TextChanged(object sender, EventArgs e)
        {
            //arrMonAn[0] = "";
            //if (cboMonChinh.Text == "System.Data.DataRowView" || cboMonChinh.Text.Length > 100)
            //{
            //    return;
            //}
            //if (cboMonChinh.Text == "") { return; }
            //if (MonAnBLL.LayMaMonAnTheoTen(cboMonChinh.Text.Trim()) == "")
            //{
            //    MessageBox.Show("Món ăn đã nhập không tồn tại", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}
            //arrMonAn[0] = MonAnBLL.LayMaMonAnTheoTen(cboMonChinh.Text.Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tableMonAn.Rows.Find(cboTenMonAn.Text.Trim()) != null)
            {
                MessageBox.Show("Món ăn đã tồn tại trong bảng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DataRow row = tableMonAn.NewRow();
            row["TenMonAn"] = cboTenMonAn.Text.Trim();
            row["NangLuong"] = MonAnBLL.LayNangLuongMonAnTheoTen(cboTenMonAn.Text.Trim());
            tableMonAn.Rows.Add(row);
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(tableMonAn.Rows.Find(cboTenMonAn.Text.Trim())== null)
            {
                MessageBox.Show("Món ăn không tồn tại trong bảng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DataRow row = tableMonAn.NewRow();
            row["TenMonAn"] = cboTenMonAn.Text.Trim();
            row["NangLuong"] = MonAnBLL.LayNangLuongMonAnTheoTen(cboTenMonAn.Text.Trim());
            tableMonAn.Rows.Remove(tableMonAn.Rows.Find(cboTenMonAn.Text.Trim()));
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.RowIndex > dgvMonAn.RowCount) { return; }
            cboTenMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells["TenMonAn"].Value.ToString().Trim();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemThucDonChoTre(false);
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            ThemThucDonChoTre(true);
        }

        void ThemThucDonChoTre(bool isGetAll)
        {
            ThongTinThucDonBLL.getListTre(listTre, dgvTreChuaXetThucDon, isGetAll);
            ThongTinThucDonBLL.getListMonAn(listMonAn, dgvMonAn);
            if (!ThongTinThucDonBLL.LuuThongTinThucDon(listTre, listMonAn, cboBuoiAD.Text.ToString(), dtpNgay_Loc.Value)) { return; }
            getDataGridViewTreChuaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
            getDataGridViewTreDaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
        }

        void XoaThucDonCuaTre(bool isGetAll)
        {
            ThongTinThucDonBLL.getListTre(listTre, dgvTreDaXetThucDon, isGetAll);
            if (!ThongTinThucDonBLL.HuyThongTinThucDon(listTre ,cboBuoiAD.Text.ToString(), dtpNgay_Loc.Value)) { return; }
            getDataGridViewTreChuaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
            getDataGridViewTreDaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            XoaThucDonCuaTre(false);
            MessageBox.Show(listTre.Count.ToString(), "Thông báo", MessageBoxButtons.OK);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            XoaThucDonCuaTre(true);
        }

        private void cboBuoiAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataGridViewTreChuaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
            getDataGridViewTreDaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboboxLop();
        }

        private void dtpNgay_Loc_ValueChanged(object sender, EventArgs e)
        {
            getComboboxLop();
        }
    }
}
