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

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "TinhTheoNgayCheckBox";
            checkColumn.HeaderText = "Tính theo số ngày đi học";
            checkColumn.Width = 150;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10;
            dgvDanhMuc.Columns.Add(checkColumn);
        }

        private void LoadDataGridView()
        {
            dgvDanhMuc.DataSource = DanhMucChiPhiBLL.GetListDanhMucChiPhi();

            string[] listProp = { "STT", "TenChiPhi", "TenLoaiChiPhi", "SoTien", "TinhTheoNgayCheckBox", "GhiChu" };
            ControlFormat.DataGridViewFormat(dgvDanhMuc, listProp);

            dgvDanhMuc.Columns["STT"].DisplayIndex = 0;
            dgvDanhMuc.Columns["TenChiPhi"].DisplayIndex = 1;
            dgvDanhMuc.Columns["TenLoaiChiPhi"].DisplayIndex = 2;
            dgvDanhMuc.Columns["SoTien"].DisplayIndex = 3;
            dgvDanhMuc.Columns["TinhTheoNgayCheckBox"].DisplayIndex = 4;
            dgvDanhMuc.Columns["GhiChu"].DisplayIndex = 5;

            dgvDanhMuc.Columns["TenChiPhi"].HeaderText = "Tên chi phí";
            dgvDanhMuc.Columns["TenLoaiChiPhi"].HeaderText = "Loại chi phí";
            dgvDanhMuc.Columns["SoTien"].HeaderText = "Số tiền";
            dgvDanhMuc.Columns["GhiChu"].HeaderText = "Ghi chú";

            dgvDanhMuc.Columns["TenChiPhi"].Width = 300;
            dgvDanhMuc.Columns["TenLoaiChiPhi"].Width = 200;
            dgvDanhMuc.Columns["SoTien"].Width = 100;
            dgvDanhMuc.Columns["GhiChu"].Width = 650;

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

        private void dgvDanhMuc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvDanhMuc.Rows.Count; i++)
            {
                dgvDanhMuc.Rows[i].Cells["STT"].Value = i + 1;
                dgvDanhMuc.Rows[i].Cells["TinhTheoNgayCheckBox"].Value =
                    int.Parse(dgvDanhMuc.Rows[i].Cells["TinhTheoSoNgayDiHoc"].Value.ToString()) == 1 ? "true" : "false";
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.RowIndex != dgvDanhMuc.RowCount)
            {
                txtTenChiPhi.Text = dgvDanhMuc.Rows[e.RowIndex].Cells["TenChiPhi"].Value.ToString();
                
                txtSoTien.Text = dgvDanhMuc.Rows[e.RowIndex].Cells["SoTien"].Value.ToString();
                txtGhiChu.Text = dgvDanhMuc.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
                int truTienKhiNghi = int.Parse(dgvDanhMuc.Rows[e.RowIndex].Cells["TinhTheoSoNgayDiHoc"].Value.ToString());
                chkTinhTheoSoNgayDiHoc.Checked = truTienKhiNghi == 1;
                cboLoaiChiPhi.Text = DanhMucChiPhiBLL.GetTenLoaiChiPhi(dgvDanhMuc.Rows[e.RowIndex].Cells["MaLoaiChiPhi"].Value.ToString().Trim());

                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;

                maDanhMuc = dgvDanhMuc.Rows[e.RowIndex].Cells["MaDanhMuc"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenChiPhi.Text == "")
            {
                MessageBox.Show("Tên chi phí không được để trống.");
                return;
            }
            if (txtSoTien.Text == "")
            {
                MessageBox.Show("Số tiền không được để trống.");
                return;
            }
            if (KeyHandle.GetKeyFromCombobox(cboLoaiChiPhi.SelectedItem.ToString()) == "")
            {
                MessageBox.Show("Loại chi phí không được để trống.");
                return;
            }

            //Lưu danh mục chi phí xuống CSDL
            try
            {
                DanhMucChiPhi danhMuc = new DanhMucChiPhi();
                danhMuc.MaDanhMuc = DanhMucChiPhiBLL.GenerateMaDanhMuc();
                danhMuc.TenChiPhi = txtTenChiPhi.Text;
                danhMuc.MaLoaiChiPhi = KeyHandle.GetKeyFromCombobox(cboLoaiChiPhi.SelectedItem.ToString());
                danhMuc.SoTien = decimal.Parse(txtSoTien.Text);
                danhMuc.GhiChu = txtGhiChu.Text;
                danhMuc.TinhTheoSoNgayDiHoc = chkTinhTheoSoNgayDiHoc.Checked ? 1 : 0;
                DanhMucChiPhiBLL.ThemDanhMucChiPhi(danhMuc);
                MessageBox.Show("Thêm danh mục chi phí thành công!");
                LoadDataGridView();
            } catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu xuống cơ sở dữ liệu.");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenChiPhi.Text == "")
            {
                MessageBox.Show("Tên chi phí không được để trống.");
                return;
            }
            if (txtSoTien.Text == "")
            {
                MessageBox.Show("Số tiền không được để trống.");
                return;
            }
            if (KeyHandle.GetKeyFromCombobox(cboLoaiChiPhi.SelectedItem.ToString()) == "")
            {
                MessageBox.Show("Loại chi phí không được để trống.");
                return;
            }

            //Cập nhật lại danh mục chi phí xuống CSDL
            try
            {
                DanhMucChiPhi danhMuc = new DanhMucChiPhi();
                danhMuc.MaDanhMuc = maDanhMuc;
                danhMuc.TenChiPhi = txtTenChiPhi.Text;
                danhMuc.MaLoaiChiPhi = KeyHandle.GetKeyFromCombobox(cboLoaiChiPhi.SelectedItem.ToString());
                danhMuc.SoTien = decimal.Parse(txtSoTien.Text);
                danhMuc.GhiChu = txtGhiChu.Text;
                danhMuc.TinhTheoSoNgayDiHoc = chkTinhTheoSoNgayDiHoc.Checked ? 1 : 0;
                DanhMucChiPhiBLL.CapNhatDanhMucChiPhi(danhMuc);
                MessageBox.Show("Cập nhật danh mục chi phí thành công!");
                LoadDataGridView();
            } catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu xuống cơ sở dữ liệu.");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAllField();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kiểm tra nếu danh mục này đang được sử dụng thì không cho xóa
            if(DanhMucChiPhiBLL.KiemTraSuDungDanhMucChiPhi(maDanhMuc))
            {
                MessageBox.Show("Danh mục chi phí này không thể xóa vì danh mục này đang áp dụng để tính học phí.");
                return;
            }
            //Xoa danh mục chi phí
            try
            {
                DanhMucChiPhiBLL.XoaDanhMucChiPhi(maDanhMuc);
                MessageBox.Show("Đã xóa danh mục chi phí thành công!");
                LoadDataGridView();
            } catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi.");
            }
        }

        private void ClearAllField()
        {
            txtTenChiPhi.Clear();
            txtSoTien.Clear();
            cboLoaiChiPhi.Text = "";
            chkTinhTheoSoNgayDiHoc.Checked = false;
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

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTien.Text == "") return;
            try
            {
                decimal.Parse(txtSoTien.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Chỉ được nhập kí tự số.");
                txtSoTien.Text = "";
            }
        }
    }
}
