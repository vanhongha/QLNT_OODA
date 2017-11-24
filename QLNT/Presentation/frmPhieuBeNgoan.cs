using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmPhieuBeNgoan : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmPhieuBeNgoan(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        public frmPhieuBeNgoan()
        {
            InitializeComponent();
        }

        private void frmPhieuBeNgoan_Load(object sender, EventArgs e)
        {
            Init();
            loadListNamHoc();
        }

        private void loadListNamHoc()
        {
            cboNamHoc.DisplayMember = "Text";
            cboNamHoc.ValueMember = "Value";
            foreach (NamHoc namHoc in LopBLL.GetListNienKhoa())
            {
                cboNamHoc.Items.Add(new { Text = namHoc.NienKhoa.Trim(), Value = namHoc.MaNamHoc.Trim() });
            }
        }

        private void Init()
        {
            DateTime date = DateTime.Now;
            dtThangLapPhieu.MaxDate = date.AddYears(1);
            dtThangLapPhieu.MinDate = date;

            dtThangLapPhieu.Format = DateTimePickerFormat.Custom;
            dtThangLapPhieu.CustomFormat = "MM/yyyy";
            dtThangLapPhieu.ShowUpDown = true;
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListLop();
            string namhoc = cboNamHoc.Text;
            int year = Int32.Parse(namhoc.Split('-')[0]);
            if ((new DateTime(year, 9, 5)) >= dtThangLapPhieu.MaxDate)
            {
                dtThangLapPhieu.MaxDate = new DateTime(year + 1, 9, 5);
                dtThangLapPhieu.MinDate = dtThangLapPhieu.MaxDate.AddYears(-1);
                dtThangLapPhieu.Value = new DateTime(year, DateTime.Now.Month, 1);
            }
            if ((new DateTime(year + 1, 9, 5)) <= dtThangLapPhieu.MinDate)
            {
                dtThangLapPhieu.MinDate = new DateTime(year, 9, 5);
                dtThangLapPhieu.MaxDate = dtThangLapPhieu.MinDate.AddYears(1);
                dtThangLapPhieu.Value = new DateTime(year, DateTime.Now.Month, 1);
            }
        }

        private void LoadListLop()
        {
            cboLop.Items.Clear();
            cboLop.DisplayMember = "Text";
            cboLop.ValueMember = "Value";
            if (cboNamHoc.SelectedItem != null)
                foreach (Lop lop in LopBLL.GetListLop(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString())))
                    cboLop.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });
            cboLop.Text = "";
        }

        private void dtThangLapPhieu_ValueChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            dgvPhieuBeNgoan.Columns.Clear();
            if (!string.IsNullOrEmpty(cboLop.Text))
            {
                string datetime = dtThangLapPhieu.Value.ToString("yyyy-MM");
                dgvPhieuBeNgoan.DataSource = DiemDanhBLL.LaySoDiemDanhLop(
                    LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())),
                    datetime.Split(' ')[0]);

                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "HienDienCheckbox";
                checkColumn.HeaderText = "Hiện Diện";
                checkColumn.Width = 50;
                checkColumn.ReadOnly = false;
                checkColumn.FillWeight = 10;
                dgvPhieuBeNgoan.Columns.Add(checkColumn);

                dgvPhieuBeNgoan.Columns["HienDien"].Visible = false;
                for (int i = 0; i < dgvPhieuBeNgoan.RowCount; i++)
                {
                    DataGridViewCheckBoxCell chkBoxCell = (DataGridViewCheckBoxCell)dgvPhieuBeNgoan.Rows[i].Cells["HienDienCheckbox"];
                    if (dgvPhieuBeNgoan.Rows[i].Cells["HienDien"].Value.ToString() == "1")
                    {
                        chkBoxCell.Value = "true";
                    }
                    else
                    {
                        chkBoxCell.Value = "false";
                    }
                }
            }
        }

        private void btnTaoPhieuMoi_Click(object sender, EventArgs e)
        {
            dgvPhieuBeNgoan.Columns.Clear();
            if (!string.IsNullOrEmpty(cboLop.Text))
            {
                dgvPhieuBeNgoan.DataSource = PhieuBeNgoanBLL.TaoPhieuBeNgoanMoi(LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())));
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "HienDienCheckbox";
                checkColumn.HeaderText = "Hiện Diện";
                checkColumn.Width = 50;
                checkColumn.ReadOnly = false;
                checkColumn.FillWeight = 10;
                dgvPhieuBeNgoan.Columns.Add(checkColumn);

                dgvPhieuBeNgoan.Columns["HienDien"].Visible = false;

            }
        }
    }
}
