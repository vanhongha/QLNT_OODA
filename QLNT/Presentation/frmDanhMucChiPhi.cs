using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmDanhMucChiPhi : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        private string maDanhMuc = "";

        public frmDanhMucChiPhi(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmDanhMucChiPhi_Load(object sender, EventArgs e)
        {
            initDataGridView();
            LoadComboboxLoaiChiPhi();
            LoadDataGridView();
        }

        private void initDataGridView()
        {
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 50;
            sttColumn.ReadOnly = true;
            dgvDanhMuc.Columns.Add(sttColumn);
        }

        private void LoadDataGridView()
        {
            dgvDanhMuc.DataSource = DanhMucChiPhiBLL.GetListDanhMucChiPhi();

            dgvDanhMuc.Columns[1].HeaderText = "Tên chi phí";
            dgvDanhMuc.Columns[2].HeaderText = "Loại chi phí";
            dgvDanhMuc.Columns[3].HeaderText = "Số tiền";
            dgvDanhMuc.Columns[4].HeaderText = "Trừ tiền khi nghỉ";
            dgvDanhMuc.Columns[5].HeaderText = "Ghi chú";

            dgvDanhMuc.Columns[1].Width = 300;
            dgvDanhMuc.Columns[2].Width = 200;
            dgvDanhMuc.Columns[3].Width = 100;
            dgvDanhMuc.Columns[4].Width = 100;
            dgvDanhMuc.Columns[5].Width = 700;

            string[] listProp = { "STT", "TenChiPhi", "TenLoaiChiPhi", "SoTien", "TruTienKhiNghi", "GhiChu" };
            ControlFormat.DataGridViewFormat(dgvDanhMuc, listProp);

            for (int i = 0; i < dgvDanhMuc.Rows.Count; i++)
            {
                dgvDanhMuc.Rows[i].Cells["STT"].Value = i + 1;
            }

            ClearAllField();
        }

        private void LoadComboboxLoaiChiPhi()
        {
            cboLoaiChiPhi.DisplayMember = "Text";
            cboLoaiChiPhi.ValueMember = "Value";
            foreach (LoaiChiPhi loaiChiPhi in DanhMucChiPhiBLL.GetListLoaiChiPhi())
            {
                cboLoaiChiPhi.Items.Add(new { Text = loaiChiPhi.TenLoaiChiPHi.Trim(), Value = loaiChiPhi.MaLoaiChiPhi.Trim() });
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.RowIndex != dgvDanhMuc.RowCount)
            {
                txtTenChiPhi.Text = dgvDanhMuc.Rows[e.RowIndex].Cells["TenChiPhi"].Value.ToString();
                
                txtSoTien.Text = dgvDanhMuc.Rows[e.RowIndex].Cells["SoTien"].Value.ToString();
                txtGhiChu.Text = dgvDanhMuc.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
                int truTienKhiNghi = int.Parse(dgvDanhMuc.Rows[e.RowIndex].Cells["TruTienKhiNghi"].Value.ToString());
                chkTruTienKhiNghi.Checked = truTienKhiNghi == 1;
                cboLoaiChiPhi.Text = DanhMucChiPhiBLL.GetTenLoaiChiPhi(dgvDanhMuc.Rows[e.RowIndex].Cells["MaLoaiChiPhi"].Value.ToString().Trim());

                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;

                maDanhMuc = dgvDanhMuc.Rows[e.RowIndex].Cells["MaDanhMuc"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenChiPhi.Text != "" 
                && KeyHandle.GetKeyFromCombobox(cboLoaiChiPhi.SelectedItem.ToString()) != "" 
                && txtSoTien.Text != ""
                && txtGhiChu.Text != "")
            {
                DanhMucChiPhi danhMuc = new DanhMucChiPhi();
                danhMuc.MaDanhMuc = DanhMucChiPhiBLL.GenerateMaDanhMuc();
                danhMuc.TenChiPhi = txtTenChiPhi.Text;
                danhMuc.MaLoaiChiPhi = KeyHandle.GetKeyFromCombobox(cboLoaiChiPhi.SelectedItem.ToString());
                danhMuc.SoTien = decimal.Parse(txtSoTien.Text);
                danhMuc.GhiChu = txtGhiChu.Text;
                danhMuc.TruTienKhiNghi = chkTruTienKhiNghi.Checked ? 1 : 0;
                DanhMucChiPhiBLL.ThemDanhMucChiPhi(danhMuc);
                LoadDataGridView();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (maDanhMuc != ""
                && txtTenChiPhi.Text != ""
                && KeyHandle.GetKeyFromCombobox(cboLoaiChiPhi.SelectedItem.ToString()) != ""
                && txtSoTien.Text != ""
                && txtGhiChu.Text != "")
            {
                DanhMucChiPhi danhMuc = new DanhMucChiPhi();
                danhMuc.MaDanhMuc = maDanhMuc;
                danhMuc.TenChiPhi = txtTenChiPhi.Text;
                danhMuc.MaLoaiChiPhi = KeyHandle.GetKeyFromCombobox(cboLoaiChiPhi.SelectedItem.ToString());
                danhMuc.SoTien = decimal.Parse(txtSoTien.Text);
                danhMuc.GhiChu = txtGhiChu.Text;
                danhMuc.TruTienKhiNghi = chkTruTienKhiNghi.Checked ? 1 : 0;
                DanhMucChiPhiBLL.CapNhatDanhMucChiPhi(danhMuc);
                LoadDataGridView();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAllField();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DanhMucChiPhiBLL.XoaDanhMucChiPhi(maDanhMuc);
            LoadDataGridView();
        }

        private void ClearAllField()
        {
            txtTenChiPhi.Clear();
            txtSoTien.Clear();
            cboLoaiChiPhi.Text = "";
            chkTruTienKhiNghi.Checked = false;
            txtGhiChu.Clear();
            maDanhMuc = "";

            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void cboLoaiChiPhi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoaiChiPhi.Text == "Tùy chỉnh")
            {
                txtSoTien.Text = 0.ToString();
                txtSoTien.Enabled = false;
            }
            else
            {
                txtSoTien.Enabled = true;
            }
        }
    }
}
