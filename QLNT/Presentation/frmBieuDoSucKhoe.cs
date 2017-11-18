using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
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

        public frmBieuDoSucKhoe()
        {
            InitializeComponent();
        }

        public frmBieuDoSucKhoe(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            tabControl = _tabControl;
            tab = _tab;
            InitializeComponent();
        }

        private void frmBieuDoSucKhoe_Load(object sender, System.EventArgs e)
        {
            InitDataGridView();
            InitTypeChart();
            LoadListNamHoc();
            LoadListLoaiLop();
            LoadDataGridView();
        }

        private void InitDataGridView()
        {
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 50;
            sttColumn.ReadOnly = true;
            dgvTre.Columns.Add(sttColumn);
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

        private void LoadListNamHoc()
        {
            cboNamHoc.DisplayMember = "Text";
            cboNamHoc.ValueMember = "Value";
            foreach (NamHoc namHoc in LopBLL.GetListNienKhoa())
            {
                cboNamHoc.Items.Add(new { Text = namHoc.NienKhoa.Trim(), Value = namHoc.MaNamHoc.Trim() });
            }
        }

        private void LoadListLoaiLop()
        {
            cboLoaiLop.DisplayMember = "Text";
            cboLoaiLop.ValueMember = "Value";
            foreach (LoaiLop loaiLop in LopBLL.GetListLoaiLop())
            {
                cboLoaiLop.Items.Add(new { Text = loaiLop.TenLoaiLop.Trim(), Value = loaiLop.MaLoaiLop.Trim() });
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

            dgvTre.Columns[0].HeaderText = "STT";
            dgvTre.Columns[2].HeaderText = "Họ tên trẻ";
            dgvTre.Columns[3].HeaderText = "Ngày sinh";
            dgvTre.Columns[4].HeaderText = "Giới tính";

            dgvTre.Columns[0].Width = 50;
            dgvTre.Columns[2].Width = 200;
            dgvTre.Columns[3].Width = 120;
            dgvTre.Columns[4].Width = 100;

            for (int i = 0; i < dgvTre.Rows.Count; i++)
            {
                dgvTre.Rows[i].Cells[0].Value = i + 1;
            }

            string[] listProp = { "STT", "HoTenTre", "GioiTinh", "NgaySinh" };
            ControlFormat.DataGridViewFormat(dgvTre, listProp);
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

            foreach (int thang in listThang)
            {
                cboTuThang.Items.Add(thang.ToString());
                cboDenThang.Items.Add(thang.ToString());
            }

            cboTuThang.Text = namHoc.NgayBatDau.Month.ToString();
            cboDenThang.Text = namHoc.NgayKetThuc.Month.ToString();
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

        private void LoadListChiTietSucKhoe()
        {
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

            UpdateChartData();
        }

        private void UpdateChartData()
        {
            List<SucKhoe> listSucKhoe = SucKhoeBLL.GetListSucKhoeTheoThang(
                    maTre,
                    int.Parse(cboTuThang.SelectedItem.ToString()),
                    int.Parse(cboDenThang.SelectedItem.ToString()),
                    KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            series.Points.Clear();

            foreach (SucKhoe sucKhoe in listSucKhoe)
            {
                series.Points.AddXY(sucKhoe.Thang.ToString() + "/" + sucKhoe.Nam.ToString(),
                    rdoCanNang.Checked ? sucKhoe.CanNang : sucKhoe.ChieuCao);
            }

            title.Text = rdoCanNang.Checked ? "Biểu đồ cân nặng" : "Biểu đồ chiều cao";
        } 

        private void rdoCanNang_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartData();
        }

        private void rdoChieuCao_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartData();
        }
    }
}
