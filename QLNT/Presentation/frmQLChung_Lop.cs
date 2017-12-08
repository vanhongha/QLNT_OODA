using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Ultilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmQLChung_Lop : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmQLChung_Lop(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            this.tabControl = _tabControl;
            this.tab = _tab;
        }
        private void frmQLChung_Lop_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region Function
        void Init()
        {
            rdoQLLop.Checked = true;
            LoadDatagridView();
            LoadGroup("Lop");

            ComboboxLoad.LoaiLop(cboLoaiLop);
            ComboboxLoad.NienKhoa(cboNienKhoa);
        }

        void LoadDatagridView()
        {
            // QL lớp
            if(rdoQLLop.Checked)
            {
                dgvDanhSach.DataSource = LopBLL.GetListLop();

                dgvDanhSach.Columns[0].HeaderText = "Mã lớp";
                dgvDanhSach.Columns[1].HeaderText = "Tên lớp";
                dgvDanhSach.Columns[2].HeaderText = "Niên khóa";
                dgvDanhSach.Columns[3].HeaderText = "Loại lớp";
                dgvDanhSach.Columns[4].HeaderText = "Sĩ số";
                dgvDanhSach.Columns[5].HeaderText = "Giáo viên";
            }
            // QL loại lớp
            else if(rdoQLLoaiLop.Checked)
            {
                dgvDanhSach.DataSource = LopBLL.GetListLoaiLop();

                dgvDanhSach.Columns[0].HeaderText = "Mã loại lớp";
                dgvDanhSach.Columns[1].HeaderText = "Tên loại lớp";
            }
            // QL niên khóa
            else
            {
                dgvDanhSach.DataSource = LopBLL.GetListNienKhoa();
                dgvDanhSach.Columns[0].HeaderText = "Mã niên khóa";
                dgvDanhSach.Columns[1].HeaderText = "Tên niên khóa";
                dgvDanhSach.Columns[2].HeaderText = "Thời gian bắt đầu";
                dgvDanhSach.Columns[3].HeaderText = "Thời gian kết thúc";

                dgvDanhSach.Columns[2].Width = 140;
                dgvDanhSach.Columns[3].Width = 140;
            }
        }

        void LoadGroup(string tenGroup)
        {
            switch(tenGroup)
            {
                case "Lop":
                    grpQLLop.Enabled = true;
                    grpQLLop.Visible = true;

                    grpQLLoaiLop.Enabled = false;
                    grpQLLoaiLop.Visible = false;
                    grpQLNienKhoa.Enabled = false;
                    grpQLNienKhoa.Visible = false;
                    break;
                case "NienKhoa":
                    grpQLNienKhoa.Enabled = true;
                    grpQLNienKhoa.Visible = true;

                    grpQLLoaiLop.Enabled = false;
                    grpQLLoaiLop.Visible = false;
                    grpQLLop.Enabled = false;
                    grpQLLop.Visible = false;
                    break;
                case "LoaiLop":
                    grpQLLoaiLop.Enabled = true;
                    grpQLLoaiLop.Visible = true;

                    grpQLNienKhoa.Enabled = false;
                    grpQLNienKhoa.Visible = false;
                    grpQLLop.Enabled = false;
                    grpQLLop.Visible = false;
                    break;
            }
        }
        #endregion

        #region Event
        private void rdoQLLop_CheckedChanged(object sender, EventArgs e)
        {
            LoadDatagridView();
            LoadGroup("Lop");
        }

        private void rdoQLLoaiLop_CheckedChanged(object sender, EventArgs e)
        {
            LoadDatagridView();
            LoadGroup("LoaiLop");
        }

        private void rdoQLNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            LoadDatagridView();
            LoadGroup("NienKhoa");
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdoQLLop.Checked)
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvDanhSach.RowCount)
                {
                    txtMaLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
                    txtTenLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
                    cboNienKhoa.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaNamHoc"].Value.ToString();
                    txtSiSo.Text = dgvDanhSach.Rows[e.RowIndex].Cells["SiSo"].Value.ToString();
                    cboGiangVien.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
                    cboLoaiLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaLoaiLop"].Value.ToString();

                    cboNienKhoa.Enabled = false;
                    cboLoaiLop.Enabled = false;
                }
            }
            else if(rdoQLLoaiLop.Checked)
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvDanhSach.RowCount)
                {
                    txtMaLoaiLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaLoaiLop"].Value.ToString();
                    txtTenLoaiLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenLoaiLop"].Value.ToString();
                }
            }
            else
            {
                if (e.RowIndex != -1 && e.RowIndex != dgvDanhSach.RowCount)
                {
                    txtMaNienKhoa.Text = dgvDanhSach.Rows[e.RowIndex].Cells["MaNamHoc"].Value.ToString();
                    txtTenNienKhoa.Text = dgvDanhSach.Rows[e.RowIndex].Cells["NienKhoa"].Value.ToString();

                    DateTime ngayBatDau = DateTime.ParseExact(Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells["NgayBatDau"].EditedFormattedValue).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dtNgayBatDau.Value = ngayBatDau;
                    DateTime ngayKetThuc = DateTime.ParseExact(Convert.ToDateTime(dgvDanhSach.Rows[e.RowIndex].Cells["NgayKetThuc"].EditedFormattedValue).ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dtNgayKetThuc.Value = ngayKetThuc;

                    dtNgayBatDau.Enabled = false;
                    dtNgayKetThuc.Enabled = false;
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
