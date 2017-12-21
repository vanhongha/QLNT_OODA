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
            tabControl = _tabControl;
            tab = _tab;
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

        public void getDataGridViewThongTinThucDonTheoMonAn()
        {
            dgvThongTinThucDon_MonAn.DataSource = ThongTinThucDonBLL.LayDanhSachMonAnTheoBuoi(cboBuoiAD.Text.ToString().Trim(), dtpNgay_Loc.Value);
            string[] column = { "MaMonAn", "TenMonAn", "NangLuong", "SoLuong"};
            Ultilities.ControlFormat.DataGridViewFormat(dgvThongTinThucDon_MonAn, column);

            dgvThongTinThucDon_MonAn.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongTinThucDon_MonAn.Columns[0].HeaderText = "Mã món ăn";
            dgvThongTinThucDon_MonAn.Columns[0].Width = 120;
            dgvThongTinThucDon_MonAn.Columns[1].HeaderText = "Tên món ăn";
            dgvThongTinThucDon_MonAn.Columns[1].Width = 120;
            dgvThongTinThucDon_MonAn.Columns[2].HeaderText = "Năng lượng";
            dgvThongTinThucDon_MonAn.Columns[2].Width = 120;
            dgvThongTinThucDon_MonAn.Columns[3].HeaderText = "Tổng suất ăn";
            dgvThongTinThucDon_MonAn.Columns[3].Width = 120;
            dgvThongTinThucDon_MonAn.ClearSelection();
        }

        public void getDataGridViewThongTinThucDonTheoNguyenLieu()
        {
            dgvThongTinThucDon_NguyenLieu.DataSource = ThongTinThucDonBLL.LayDanhSachNguyenLieuTheoBuoi(cboBuoiAD.Text.ToString().Trim(), dtpNgay_Loc.Value);
            string[] column = { "MaNguyenLieu", "TenNguyenLieu", "SoLuong" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvThongTinThucDon_NguyenLieu, column);

            dgvThongTinThucDon_NguyenLieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongTinThucDon_NguyenLieu.Columns[0].HeaderText = "Mã nguyên liệu";
            dgvThongTinThucDon_NguyenLieu.Columns[0].Width = 120;
            dgvThongTinThucDon_NguyenLieu.Columns[1].HeaderText = "Tên nguyên liệu";
            dgvThongTinThucDon_NguyenLieu.Columns[1].Width = 120;
            dgvThongTinThucDon_NguyenLieu.Columns[2].HeaderText = "Số lượng (gam)";
            dgvThongTinThucDon_NguyenLieu.Columns[2].Width = 120;
            dgvThongTinThucDon_NguyenLieu.ClearSelection();
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
        }

        public void getComboBoxMonAn()
        {
            cboTenMonAn.DataSource = ThongTinThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboTenMonAn.DisplayMember = "TenMonAn";
            cboTenMonAn.ValueMember = "MaMonAn";
            cboTenMonAn.Text = "";
        }

        private void getComboboxMonAnTheoTuKhoa(ComboBox cbo)
        {
            cbo.DataSource = ThongTinThucDonBLL.LayDanhSachTenVaMaMonAn(cboBuoiAD.Text);
            cbo.DisplayMember = "TenMonAn";
            cbo.ValueMember = "MaMonAn";
        }

        private void setCheckBoxColumn(DataGridView dgv)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "X";
            checkBoxColumn.Width = 50;
            dgv.Columns.Clear();
            dgv.Columns.Add(checkBoxColumn);
        }

        private void getDataGridViewTre()
        {
            try {
                getDataGridViewTreChuaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
                getDataGridViewTreDaXetThucDon(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
                ckbAll.Checked = false;
                ckbAll_TreDaXetTD.Checked = false;
            }
            catch { }
            
        }

        private void setEnableButton(bool value)
        {
            btnAdd.Enabled = value;
            btnAddAll.Enabled = value;
            btnRemove.Enabled = value;
            btnRemoveAll.Enabled = value;
            btnReload.Enabled = value;
            btnThem.Enabled = value;
            btnXoa.Enabled = value;
            btnXuatDanhSachTheoLop.Enabled = value;
            btnBaoCaoNhaBep.Enabled = value;
            lblNote.Visible = !value;
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataGridViewTre();
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (ThongTinThucDonBLL.themMonAnTrongBangMonAn(tableMonAn, cboTenMonAn.Text.ToString().Trim()))
            {
                lblTongNangLuong.Text = ThongTinThucDonBLL.getTongNangLuong(dgvMonAn);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(ThongTinThucDonBLL.xoaMonAnTrongBangMonAn(tableMonAn, cboTenMonAn.Text.ToString().Trim()))
            {
                lblTongNangLuong.Text = ThongTinThucDonBLL.getTongNangLuong(dgvMonAn);
            }
            
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.RowIndex > dgvMonAn.RowCount) { return; }
            cboTenMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells["TenMonAn"].Value.ToString().Trim();
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
            getDataGridViewTre();
            getDataGridViewThongTinThucDonTheoMonAn();
            getDataGridViewThongTinThucDonTheoNguyenLieu();
        }

        void XoaThucDonCuaTre(bool isGetAll)
        {
            ThongTinThucDonBLL.getListTre(listTre, dgvTreDaXetThucDon, isGetAll);
            if (!ThongTinThucDonBLL.HuyThongTinThucDon(listTre ,cboBuoiAD.Text.ToString(), dtpNgay_Loc.Value)) { return; }
            getDataGridViewTre();
            getDataGridViewThongTinThucDonTheoMonAn();
            getDataGridViewThongTinThucDonTheoNguyenLieu();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            XoaThucDonCuaTre(false);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            XoaThucDonCuaTre(true);
        }

        private void cboBuoiAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataGridViewTre();
            getDataGridViewThongTinThucDonTheoMonAn();
            getDataGridViewThongTinThucDonTheoNguyenLieu();
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboboxLop();
        }

        private void dtpNgay_Loc_ValueChanged(object sender, EventArgs e)
        {
            getComboboxLop();
            if(DateTime.Compare(dtpNgay_Loc.Value, DateTime.Today) < 0)
            {
                setEnableButton(false);
            }
            else
            {
                setEnableButton(true);
            }
        }
        

        private void dgvTreChuaXetThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.RowIndex > dgvTreChuaXetThucDon.RowCount) { return; }
            dgvTreChuaXetThucDon.Rows[e.RowIndex].Cells[0].Value = !Convert.ToBoolean(dgvTreChuaXetThucDon.Rows[e.RowIndex].Cells[0].Value);
            ckbAll.Checked = ThongTinThucDonBLL.isCheckedAll(dgvTreChuaXetThucDon);
        }

        private void ckbAll_Click(object sender, EventArgs e)
        {
            ThongTinThucDonBLL.checkAllDataGridView(dgvTreChuaXetThucDon, ckbAll.Checked);
        }

        private void ckbAll_TreDaXetTD_Click(object sender, EventArgs e)
        {
            ThongTinThucDonBLL.checkAllDataGridView(dgvTreDaXetThucDon, ckbAll_TreDaXetTD.Checked);
        }

        private void dgvTreDaXetThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dgvTreDaXetThucDon.RowCount) { return; }
            dgvTreDaXetThucDon.Rows[e.RowIndex].Cells[0].Value = !Convert.ToBoolean(dgvTreDaXetThucDon.Rows[e.RowIndex].Cells[0].Value);
            ckbAll_TreDaXetTD.Checked = ThongTinThucDonBLL.isCheckedAll(dgvTreDaXetThucDon);

            tableMonAn = MonAnBLL.setDateDgvMonAn(tableMonAn,ThongTinThucDonBLL.LayThongTinThucDonTheoTre(dgvTreDaXetThucDon.Rows[e.RowIndex].Cells["MaTre"].Value.ToString().Trim(),cboBuoiAD.Text, dtpNgay_Loc.Value));
            lblTongNangLuong.Text = ThongTinThucDonBLL.getTongNangLuong(dgvMonAn);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinThucDon_MonAn.Rows.Count <= 0)
                {
                    MessageBox.Show("Chưa có dữ liệu nào cho bữa ăn này", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (ThongTinThucDonBLL.kiemTraInBaoCao(cboBuoiAD.Text.Trim(), dtpNgay_Loc.Value))
                {
                    Form frmBaoCaoNhaBep = new frmDinhDuong_BaoCaoNhaBep(cboBuoiAD.Text.Trim(), dtpNgay_Loc.Value);
                    frmBaoCaoNhaBep.ShowDialog();
                }
            }
            catch { }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongTinThucDon_MonAn.Rows.Count <= 0)
                {
                    MessageBox.Show("Chưa có dữ liệu nào cho bữa ăn này", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (ThongTinThucDonBLL.kiemTraInBaoCao(cboLop.SelectedValue.ToString().Trim(), cboBuoiAD.Text.Trim(), dtpNgay_Loc.Value))
                {
                    Form frmBaoCaoSuatAn = new frmDinhDuong_BaoCaoSuatAn(cboLop.SelectedValue.ToString().Trim(), cboBuoiAD.Text.Trim(), dtpNgay_Loc.Value);
                    frmBaoCaoSuatAn.ShowDialog();
                }
            }
            catch { }
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            getComboBoxMonAn();
            
        }
    }
}
