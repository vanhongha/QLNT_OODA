using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
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
    public partial class frmXepLop : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        private List<DataGridViewRow> listSelectedRows;
        private List<string> listMaTre;

        public frmXepLop()
        {
            InitializeComponent();
        }

        public frmXepLop(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        #region Function
        void LoadDGVDanhSachFromDB()
        {
            if (rdoXepLop.Checked)
            {
                dgvDanhSach.DataSource = TreBLL.GetListTreChuaCoLop();

                dgvDanhSach.Columns[0].HeaderText = "Họ tên trẻ";
                dgvDanhSach.Columns[1].HeaderText = "Ngày sinh";

                dgvDanhSach.Columns[0].Width = 140;
                dgvDanhSach.Columns[1].Width = 120;

                string[] listProp = { "HoTenTre", "NgaySinh" };
                ControlFormat.DataGridViewFormat(dgvDanhSach, listProp);
            }
            else
            {
                if (cboLopHoc_LuaChon.SelectedItem != null)
                {
                    dgvDanhSach.DataSource = TreBLL.GetListTre(LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLopHoc_LuaChon.SelectedItem.ToString())));

                    dgvDanhSach.Columns[0].HeaderText = "Họ tên trẻ";
                    dgvDanhSach.Columns[1].HeaderText = "Ngày sinh";

                    dgvDanhSach.Columns[0].Width = 140;
                    dgvDanhSach.Columns[1].Width = 120;

                    string[] listProp = { "HoTenTre", "NgaySinh" };
                    ControlFormat.DataGridViewFormat(dgvDanhSach, listProp);
                }
            }
        }

        void LoadDGVKetQuaFromDB()
        {
            if (cboLop.SelectedItem != null)
            {
                dgvKetQua.DataSource = TreBLL.GetListTre(LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())));

                dgvKetQua.Columns[1].HeaderText = "Họ tên trẻ";
                dgvKetQua.Columns[2].HeaderText = "Ngày sinh";

                dgvKetQua.Columns[1].Width = 140;
                dgvKetQua.Columns[2].Width = 120;

                string[] listProp = { "HoTenTre", "NgaySinh" };
                ControlFormat.DataGridViewFormat(dgvKetQua, listProp);
            }
        }

        void LoadDGVAfterPuttingForward(bool isPuttedAll)
        {
            if (isPuttedAll)
                dgvDanhSach.SelectAll();
            
            List<DataGridViewRow> selectedRows = dgvDanhSach.SelectedRows
                .OfType<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .ToList();

            List<DataGridViewCell> selectedCells = dgvDanhSach.SelectedCells.OfType<DataGridViewCell>().ToList();

            foreach (DataGridViewCell cell in selectedCells)
                if (!selectedRows.Contains(dgvDanhSach.Rows[cell.RowIndex]))
                    selectedRows.Add(dgvDanhSach.Rows[cell.RowIndex]);

            DataTable dtable = (DataTable)(dgvKetQua.DataSource);
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.BackColor = Color.AntiqueWhite;
            foreach (DataGridViewRow row in selectedRows)
            {              
                object[] RowValues = { row.Cells[2].Value, row.Cells[0].Value, row.Cells[1].Value };
                    
                dtable.Rows.Add(RowValues);
                dgvKetQua.Rows[dgvKetQua.RowCount - 1].DefaultCellStyle = cellStyle;
                dgvDanhSach.Rows.Remove(row);
            }
        }

        void LoadDGVAfterPuttingBack(bool isPuttedAll)
        {
            if (isPuttedAll)
                dgvKetQua.SelectAll();

            List<DataGridViewRow> selectedRows = dgvKetQua.SelectedRows
                .OfType<DataGridViewRow>()
                .Where(row => !row.IsNewRow)
                .ToList();

            List<DataGridViewCell> selectedCells = dgvKetQua.SelectedCells.OfType<DataGridViewCell>().ToList();

            foreach (DataGridViewCell cell in selectedCells)
                if (!selectedRows.Contains(dgvKetQua.Rows[cell.RowIndex]))
                    selectedRows.Add(dgvKetQua.Rows[cell.RowIndex]);

            DataTable dtable = (DataTable)(dgvDanhSach.DataSource);
            foreach (DataGridViewRow row in selectedRows)
            {
                object[] RowValues = { row.Cells["HoTenTre"].Value, row.Cells["NgaySinh"].Value, row.Cells["MaTre"].Value };

                dtable.Rows.Add(RowValues);
                dgvKetQua.Rows.Remove(row);
            }
        }

        private void LoadListNamHoc()
        {
            ComboboxLoad.NienKhoa(cboNamHoc_LuaChon);
            ComboboxLoad.NienKhoa(cboNamHoc);
        }

        private void LoadListLoaiLop()
        {
            ComboboxLoad.LoaiLop(cboLoaiLop);
            ComboboxLoad.LoaiLop(cboLoaiLop_LuaChon);
        }

        private void RemoveAllListMaTre()
        {
            listMaTre.Clear();
        }

        private void SaveListMaTre(DataGridView dgv)
        {
            List<DataGridViewRow> selectedRows = dgv.SelectedRows
                     .OfType<DataGridViewRow>()
                     .Where(row => !row.IsNewRow)
                     .ToList();
            List<DataGridViewCell> selectedCells = dgv.SelectedCells.OfType<DataGridViewCell>().ToList();

            foreach (DataGridViewCell cell in selectedCells)
            {
                if (!selectedRows.Contains(dgv.Rows[cell.RowIndex]))
                    selectedRows.Add(dgv.Rows[cell.RowIndex]);
            }

            foreach (DataGridViewRow row in selectedRows)
                if (!listMaTre.Contains(row.Cells["MaTre"].Value.ToString()))
                    listMaTre.Add(row.Cells["MaTre"].Value.ToString());
        }

        private void PutForward()
        {
            if (cboLop.SelectedItem != null)
            {
                DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                if (Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
                {
                    if (TreBLL.XepLop(listMaTre, KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())))
                    {
                        LoadDGVDanhSachFromDB();
                        LoadDGVKetQuaFromDB();
                        MessageBox.Show("Thêm trẻ vào lớp " +
                            LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())).TenLop +
                            " thành công!",
                            "Thông báo");
                    }
                }
                else
                    MessageBox.Show("Lớp được chọn không còn hoạt động, vui lòng chọn lớp của niên khóa hiện tại", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng chọn lớp để chuyển trẻ!");
        }

        #endregion

        #region Event
        private void frmXepLop_Load(object sender, EventArgs e)
        {
            listMaTre = new List<string>();
            listSelectedRows = new List<DataGridViewRow>();
            rdoChuyenLop.Checked = true;
            LoadDGVDanhSachFromDB();
            LoadListNamHoc();
            LoadListLoaiLop();
        }

        private void rdoChuyenLop_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiLop_LuaChon.Enabled = true;
            cboLopHoc_LuaChon.Enabled = true;
            cboNamHoc_LuaChon.Enabled = true;
            txtSiSo_LuaChon.Enabled = true;

            LoadDGVDanhSachFromDB();
        }

        private void rdoXepLop_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiLop_LuaChon.Text = null;
            cboLopHoc_LuaChon.Text = null;
            cboNamHoc_LuaChon.Text = null;
            txtSiSo_LuaChon.Text = null;

            cboLoaiLop_LuaChon.Enabled = false;
            cboLopHoc_LuaChon.Enabled = false;
            cboNamHoc_LuaChon.Enabled = false;
            txtSiSo_LuaChon.Enabled = false;

            LoadDGVDanhSachFromDB();
        }

        private void cboNamHoc_LuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxLoad.Lop(cboLopHoc_LuaChon, cboNamHoc_LuaChon, cboLoaiLop_LuaChon);
        }

        private void cboLoaiLop_LuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxLoad.Lop(cboLopHoc_LuaChon, cboNamHoc_LuaChon, cboLoaiLop_LuaChon);
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxLoad.Lop(cboLop, cboNamHoc, cboLoaiLop);
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxLoad.Lop(cboLop, cboNamHoc, cboLoaiLop);
        }

        private void cboLopHoc_LuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGVDanhSachFromDB();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGVKetQuaFromDB();
        }

        private void btnPutForward_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedItem != null)
            {
                DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                if (Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
                {
                    LoadDGVAfterPuttingForward(false);
                    //grLuaChon.Enabled = false;
                }
                else
                    MessageBox.Show("Lớp được chọn không còn hoạt động, vui lòng chọn lớp của niên khóa hiện tại", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng chọn lớp cần chuyển đến!", "Thông báo");
        }

        private void btnPutForwardAll_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedItem != null)
            {
                DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                if (Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
                {
                    LoadDGVAfterPuttingForward(true);
                    //grLuaChon.Enabled = false;
                }
                else
                    MessageBox.Show("Lớp được chọn không còn hoạt động, vui lòng chọn lớp của niên khóa hiện tại", "Thông báo");
            }
            else
                MessageBox.Show("Vui lòng chọn lớp cần chuyển đến!", "Thông báo");
        }

        private void btnPutBack_Click(object sender, EventArgs e)
        {
            LoadDGVAfterPuttingBack(false);
        }

        private void btnPutBackAll_Click(object sender, EventArgs e)
        {
            LoadDGVAfterPuttingBack(true);
        }

        #endregion


    }
}
