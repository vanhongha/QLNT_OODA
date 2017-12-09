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
        string[] arrMonAn = {};
        string[] arrTre = {};
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

        public void getDataGridViewLop(string maLop, int thang, int nam)
        {
            setCheckBoxColumn();
            dgvLop.DataSource = LopBLL.GetSucKhoeTheoLop(maLop, thang, nam);
            string[] column = { "X", "MaTre", "HoTenTre", "BMI", "TinhTrang", "GhiChu" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvLop, column);

            dgvLop.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLop.Columns[1].HeaderText = "Mã Trẻ";
            dgvLop.Columns[1].Width = 100;
            dgvLop.Columns[2].HeaderText = "Tên Trẻ";
            dgvLop.Columns[2].Width = 120;
            dgvLop.Columns[3].HeaderText = "BMI";
            dgvLop.Columns[3].Width = 50;
            dgvLop.Columns[4].HeaderText = "Tình Trạng";
            //dgvLop.Columns[4].Width = 100;
            dgvLop.Columns[5].HeaderText = "Ghi Chú";
            dgvLop.Columns[5].Width = 100;
            dgvLop.ClearSelection();
        }

        public void getDataGridViewMonAn()
        {
            DataColumn column;
            DataColumn[] key = new DataColumn[1];
            column = new DataColumn();
            column.ColumnName = "TenMonAn";
            tableMonAn.Columns.Add(column);
            key[0] = column;
            tableMonAn.PrimaryKey = key;

            column = new DataColumn();
            column.ColumnName = "NangLuong";
            tableMonAn.Columns.Add(column);
            
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

        private void setCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvLop.Columns.Clear();
            dgvLop.Columns.Add(checkBoxColumn);
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
            DataRow row = tableMonAn.NewRow();
            row["TenMonAn"] = cboTenMonAn.Text.Trim();
            row["NangLuong"] = MonAnBLL.LayNangLuongMonAnTheoTen(cboTenMonAn.Text.Trim());
            tableMonAn.Rows.Add(row);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRow row = tableMonAn.NewRow();
            row["TenMonAn"] = cboTenMonAn.Text.Trim();
            row["NangLuong"] = MonAnBLL.LayNangLuongMonAnTheoTen(cboTenMonAn.Text.Trim());
            tableMonAn.Rows.Remove(tableMonAn.Rows.Find(cboTenMonAn.Text.Trim()));
        }
    }
}
