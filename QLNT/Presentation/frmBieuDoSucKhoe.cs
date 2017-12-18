using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLNT.Presentation
{
    public partial class frmBieuDoSucKhoe : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        private string maTre = "";
        private Series series = new Series("SeriesLineChart");
        private Title title = new Title("Title");

        public frmBieuDoSucKhoe(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            tabControl = _tabControl;
            tab = _tab;
            InitializeComponent();
        }

        #region Init
        private void InitDataGridView()
        {
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 50;
            sttColumn.ReadOnly = true;
            dgvTre.Columns.Add(sttColumn);

            DataGridViewTextBoxColumn gioiTinhColumn = new DataGridViewTextBoxColumn();
            gioiTinhColumn.Name = "GioiTinhCol";
            gioiTinhColumn.HeaderText = "Giới tính";
            gioiTinhColumn.Width = 150;
            gioiTinhColumn.ReadOnly = false;
            gioiTinhColumn.FillWeight = 10;
            dgvTre.Columns.Add(gioiTinhColumn);
        }

        private void InitTypeChart()
        {
            series.ChartType = SeriesChartType.Line;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 10;
            series.BorderWidth = 3;
            chart.Series.Add(series);
            chart.ChartAreas[0].AxisX.IsMarginVisible = false;
            title.Text = "";
            title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold);
            chart.Titles.Add(title);
        }
        #endregion

        #region Function
        private void LoadListNamHoc()
        {
            cboNamHoc.DisplayMember = "Text";
            cboNamHoc.ValueMember = "Value";
            foreach (NamHoc namHoc in LopBLL.GetListNienKhoa())
            {
                cboNamHoc.Items.Add(new { Text = namHoc.NienKhoa.Trim(), Value = namHoc.MaNamHoc.Trim() });
            }

            if(cboNamHoc.Items.Count > 0)
            {
                cboNamHoc.SelectedIndex = cboNamHoc.Items.Count - 1;
            }
        }

        private void LoadListThang()
        {
            NamHoc namHoc = LopBLL.GetInfoNamHoc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            int thangBatDau = namHoc.NgayBatDau.Month;
            int thangKetThuc = namHoc.NgayKetThuc.Month;

            List<int> listThang = new List<int>();
            listThang.Add(thangBatDau);

            while (thangBatDau != thangKetThuc)
            {
                thangBatDau++;
                if (thangBatDau > 12)
                    thangBatDau = 1;
                listThang.Add(thangBatDau);
            }

            cboTuThang.Items.Clear();
            cboDenThang.Items.Clear();

            foreach (int thang in listThang)
            {
                cboTuThang.Items.Add(thang.ToString());
                cboDenThang.Items.Add(thang.ToString());
            }

            cboTuThang.Text = namHoc.NgayBatDau.Month.ToString();
            cboDenThang.Text = namHoc.NgayKetThuc.Month.ToString();
        }

        private void LoadListLoaiLop()
        {
            cboLoaiLop.DisplayMember = "Text";
            cboLoaiLop.ValueMember = "Value";
            foreach (LoaiLop loaiLop in LopBLL.GetListLoaiLop())
            {
                cboLoaiLop.Items.Add(new { Text = loaiLop.TenLoaiLop.Trim(), Value = loaiLop.MaLoaiLop.Trim() });
            }

            if(cboLoaiLop.Items.Count > 0)
            {
                cboLoaiLop.SelectedIndex = 0;
            }
        }

        private void LoadListLop()
        {
            cboLop.Items.Clear();
            cboLop.DisplayMember = "Text";
            cboLop.ValueMember = "Value";
            foreach (Lop lop in LopBLL.GetListLop(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()),
                KeyHandle.GetKeyFromCombobox(cboLoaiLop.SelectedItem.ToString())))
            {
                cboLop.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });
            }
            cboLop.Text = "";
        }

        private void LoadDataGridView()
        {
            if (cboLop.SelectedItem == null)
            {
                dgvTre.DataSource = TreBLL.GetListTreTheoMaLop("");
            }
            else
            {
                dgvTre.DataSource = TreBLL.GetListTreTheoMaLop(
                    KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString()));
            }

            dgvTre.Columns["HoTenTre"].DisplayIndex = 1;
            dgvTre.Columns["NgaySinh"].DisplayIndex = 2;
            dgvTre.Columns["GioiTinhCol"].DisplayIndex = 3;

            dgvTre.Columns["HoTenTre"].HeaderText = "Họ tên trẻ";
            dgvTre.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvTre.Columns["GioiTinhCol"].HeaderText = "Giới tính";

            dgvTre.Columns["HoTenTre"].Width = 200;
            dgvTre.Columns["NgaySinh"].Width = 120;
            dgvTre.Columns["GioiTinhCol"].Width = 80;

            string[] listProp = { "STT", "HoTenTre", "GioiTinhCol", "NgaySinh" };
            ControlFormat.DataGridViewFormat(dgvTre, listProp);

            dgvTre.ClearSelection();
            maTre = "";
            UpdateChartData();
        }

        private void LoadListChiTietSucKhoe()
        {
            if (cboTuThang.SelectedItem == null || cboDenThang.SelectedItem == null)
            {
                dgvChiTietSucKhoe.DataSource = null;
                UpdateChartData();
                return;
            }

            dgvChiTietSucKhoe.DataSource = SucKhoeBLL.GetListSucKhoeTheoThang(
                    maTre,
                    int.Parse(cboTuThang.SelectedItem.ToString()),
                    int.Parse(cboDenThang.SelectedItem.ToString()),
                    KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            dgvChiTietSucKhoe.Columns[1].HeaderText = "Tháng";
            dgvChiTietSucKhoe.Columns[2].HeaderText = "Năm";
            dgvChiTietSucKhoe.Columns[6].HeaderText = "Cân nặng (kg)";
            dgvChiTietSucKhoe.Columns[7].HeaderText = "Chiều cao (cm)";
            dgvChiTietSucKhoe.Columns[9].HeaderText = "Tình trạng";
            dgvChiTietSucKhoe.Columns[10].HeaderText = "Ghi chú";

            dgvChiTietSucKhoe.Columns[1].Width = 60;
            dgvChiTietSucKhoe.Columns[2].Width = 60;
            dgvChiTietSucKhoe.Columns[6].Width = 150;
            dgvChiTietSucKhoe.Columns[7].Width = 150;
            dgvChiTietSucKhoe.Columns[9].Width = 200;
            dgvChiTietSucKhoe.Columns[10].Width = 300;

            string[] listProp = { "Thang", "Nam", "CanNang", "ChieuCao", "TinhTrang", "GhiChu" };
            ControlFormat.DataGridViewFormat(dgvChiTietSucKhoe, listProp);

            dgvChiTietSucKhoe.ClearSelection();

            UpdateChartData();
        }

        private void UpdateChartData()
        {
            series.Points.Clear();
            title.Text = rdoCanNang.Checked ? "Biểu đồ cân nặng" : "Biểu đồ chiều cao";
            if (maTre == "" || cboTuThang.SelectedItem == null || cboDenThang.SelectedItem == null) return;
            List<SucKhoe> listSucKhoe = SucKhoeBLL.GetListSucKhoeTheoThang(
                    maTre,
                    int.Parse(cboTuThang.SelectedItem.ToString()),
                    int.Parse(cboDenThang.SelectedItem.ToString()),
                    KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            foreach (SucKhoe sucKhoe in listSucKhoe)
            {
                series.Points.AddXY(sucKhoe.Thang.ToString() + "/" + sucKhoe.Nam.ToString(),
                    rdoCanNang.Checked ? sucKhoe.CanNang : sucKhoe.ChieuCao);
            }
        }
        #endregion

        #region Event
        private void frmBieuDoSucKhoe_Load(object sender, System.EventArgs e)
        {
            InitDataGridView();
            InitTypeChart();
            LoadListNamHoc();
            LoadListLoaiLop();
            LoadDataGridView();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!cboLoaiLop.Text.Equals(""))
            {
                LoadListLop();
                LoadDataGridView();
            }

            LoadListThang();
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!cboNamHoc.Text.Equals(""))
            {
                LoadListLop();
                LoadDataGridView();
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadDataGridView();
        }

        private void cboTuThang_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            NamHoc namHoc = LopBLL.GetInfoNamHoc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            int thangBatDau = int.Parse(cboTuThang.SelectedItem.ToString());
            int thangKetThuc = namHoc.NgayKetThuc.Month;

            List<int> listThang = new List<int>();

            while (thangBatDau != thangKetThuc)
            {
                thangBatDau++;
                if (thangBatDau > 12)
                    thangBatDau = 1;
                listThang.Add(thangBatDau);
            }

            cboDenThang.Items.Clear();
            foreach (int thang in listThang)
            {
                cboDenThang.Items.Add(thang.ToString());
            }
        }

        private void cboDenThang_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cboDenThang.SelectedItem.ToString() != "" && maTre != "")
            {
                LoadListChiTietSucKhoe();
            }
        }

        private void dgvTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvTre.RowCount)
            {
                maTre = dgvTre.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                LoadListChiTietSucKhoe();
            }
        }

        private void rdoCanNang_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartData();
        }

        private void rdoChieuCao_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartData();
        }

        private void btnInBaoCao_Click(object sender, System.EventArgs e)
        {
            if (dgvChiTietSucKhoe.SelectedRows.Count > 0)
            {
                int thang = int.Parse(dgvChiTietSucKhoe.SelectedRows[0].Cells["Thang"].Value.ToString());
                int nam = int.Parse(dgvChiTietSucKhoe.SelectedRows[0].Cells["Nam"].Value.ToString());
                Form frmBaoCaoSucKhoe = new frmBaoCaoSucKhoe(maTre, thang, nam);
                frmBaoCaoSucKhoe.ShowDialog();
            } 
            else
            {
                MessageBox.Show("Chọn một tháng trong chi tiết sức khỏe để in báo cáo.");
            }
        }

        private void btnInBaoCaoTheoThang_Click(object sender, System.EventArgs e)
        {
            if(cboTuThang.Text == "" || cboDenThang.Text == "")
            {
                MessageBox.Show("Phải chọn thời gian để in báo cáo.");
                return;
            }
            if(maTre == "")
            {
                MessageBox.Show("Phải chọn một trẻ để in báo cáo.");
                return;
            }
            DateTime tgBatDau = DateTime.Now;
            DateTime tgKetThuc = DateTime.Now;

            int thangBatDau = Convert.ToInt32(cboTuThang.Text);
            int thangKetThuc = Convert.ToInt32(cboDenThang.Text);

            int namBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString())).Year;
            int namKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString())).Year;

            if (thangBatDau >= 8 && thangBatDau <= 12)
                tgBatDau = new DateTime(namBatDau, thangBatDau, 1);
            else if (thangBatDau >= 1 && thangBatDau <= 5)
                tgBatDau = new DateTime(namKetThuc, thangBatDau, 1);

            if (thangKetThuc >= 8 && thangKetThuc <= 12)
                tgKetThuc = new DateTime(namBatDau, thangKetThuc, 28);
            else if (thangKetThuc >= 1 && thangKetThuc <= 5)
                tgKetThuc = new DateTime(namKetThuc, thangKetThuc, 28);

            Form frmBaoCaoSucKhoe = new frmBaoCaoSucKhoeTheoThang(maTre, tgBatDau, tgKetThuc);
            frmBaoCaoSucKhoe.ShowDialog();
        }

        private void btnDong_Click(object sender, System.EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void dgvTre_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvTre.Rows.Count; i++)
            {
                dgvTre.Rows[i].Cells["STT"].Value = i + 1;
                dgvTre.Rows[i].Cells["GioiTinhCol"].Value =
                     int.Parse(dgvTre.Rows[i].Cells["GioiTinh"].Value.ToString()) == 1 ? "Nam" : "Nữ";
            }
        }

        private void dgvTre_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            base.OnClick(e);
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvChiTietSucKhoe_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            base.OnClick(e);
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        #endregion

    
    }
}
