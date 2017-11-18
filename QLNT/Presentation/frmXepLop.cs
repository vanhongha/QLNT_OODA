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
        void LoadDGVDanhSach()
        {
            if (rdoXepLop.Checked)
            {
                dgvDanhSach.DataSource = TreBLL.GetListTreChuaCoLop();
                dgvDanhSach.Columns[1].HeaderText = "Họ tên trẻ";
                dgvDanhSach.Columns[2].HeaderText = "Ngày sinh";

                dgvDanhSach.Columns[0].Width = 50;
                dgvDanhSach.Columns[1].Width = 140;
                dgvDanhSach.Columns[2].Width = 120;

                for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
                    dgvDanhSach.Rows[i].Cells[0].Value = i + 1;

                string[] listProp = { "STT", "HoTenTre", "NgaySinh" };
                ControlFormat.DataGridViewFormat(dgvDanhSach, listProp);
            }
            else
            {
                if (cboLopHoc_LuaChon.SelectedItem != null)
                {
                    dgvDanhSach.DataSource = TreBLL.GetListTre(LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLopHoc_LuaChon.SelectedItem.ToString())));

                    dgvDanhSach.Columns[1].HeaderText = "Họ tên trẻ";
                    dgvDanhSach.Columns[2].HeaderText = "Ngày sinh";

                    dgvDanhSach.Columns[0].Width = 50;
                    dgvDanhSach.Columns[1].Width = 140;
                    dgvDanhSach.Columns[2].Width = 120;

                    for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
                        dgvDanhSach.Rows[i].Cells[0].Value = i + 1;

                    string[] listProp = { "STT", "HoTenTre", "NgaySinh" };
                    ControlFormat.DataGridViewFormat(dgvDanhSach, listProp);
                }
            }
        }

        void LoadDGVKetQua()
        {
            if (cboLop.SelectedItem != null)
            {
                dgvKetQua.DataSource = TreBLL.GetListTre(LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())));

                dgvKetQua.Columns[1].HeaderText = "Họ tên trẻ";
                dgvKetQua.Columns[2].HeaderText = "Ngày sinh";

                dgvKetQua.Columns[0].Width = 50;
                dgvKetQua.Columns[1].Width = 140;
                dgvKetQua.Columns[2].Width = 120;

                for (int i = 0; i < dgvKetQua.Rows.Count; i++)
                    dgvKetQua.Rows[i].Cells[0].Value = i + 1;

                string[] listProp = { "STT", "HoTenTre", "NgaySinh" };
                ControlFormat.DataGridViewFormat(dgvKetQua, listProp);
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

        private void SaveListMaTre()
        {
            List<DataGridViewRow> selectedRows = dgvDanhSach.SelectedRows
                     .OfType<DataGridViewRow>()
                     .Where(row => !row.IsNewRow)
                     .ToList();
            List<DataGridViewCell> selectedCells = dgvDanhSach.SelectedCells.OfType<DataGridViewCell>().ToList();

            foreach (DataGridViewCell cell in selectedCells)
            {
                if (!selectedRows.Contains(dgvDanhSach.Rows[cell.RowIndex]))
                    selectedRows.Add(dgvDanhSach.Rows[cell.RowIndex]);
            }

            foreach (DataGridViewRow row in selectedRows)
                if (!listMaTre.Contains(row.Cells["MaTre"].Value.ToString()))
                    listMaTre.Add(row.Cells["MaTre"].Value.ToString());
                
            foreach (string ma in listMaTre)
                MessageBox.Show(ma);
        }
        #endregion

        #region Event
        private void frmXepLop_Load(object sender, EventArgs e)
        {
            listMaTre = new List<string>();
            rdoChuyenLop.Checked = true;
            LoadDGVDanhSach();
            LoadListNamHoc();
            LoadListLoaiLop();
        }

        private void rdoChuyenLop_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiLop_LuaChon.Enabled = true;
            cboLopHoc_LuaChon.Enabled = true;
            cboNamHoc_LuaChon.Enabled = true;
            txtSiSo_LuaChon.Enabled = true;

            LoadDGVDanhSach();
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

            LoadDGVDanhSach();
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
            LoadDGVDanhSach();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGVKetQua();
        }

        private void btnPutForward_Click(object sender, EventArgs e)
        {
            RemoveAllListMaTre();
            SaveListMaTre();
        }
        #endregion


    }
}
