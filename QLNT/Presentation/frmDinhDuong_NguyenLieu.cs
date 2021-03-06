﻿using System;
using System.Collections.Generic;
using DevComponents.DotNetBar;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;

namespace QLNT.Presentation
{
    public partial class frmDinhDuong_NguyenLieu : Form
    {
        private string[] selectedNguyenLieu = new string[5];
        private string TuKhoa = "";
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        public frmDinhDuong_NguyenLieu(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;

        }

        private void frmDinhDuong_NguyenLieu_Load(object sender, EventArgs e)
        {
            getDataGridView();
            getCombobox();
            SetEnabledComponents(false);
            XoaTrang();
        }

        private void getDataGridView()
        {
            dgvNguyenLieu.DataSource = NguyenLieuBLL.LayDanhSachNguyenLieu(TuKhoa);
            string[] column = { "MaNguyenLieu", "TenNguyenLieu", "TenLoaiNL", "NangLuong", "DonViTinh" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvNguyenLieu, column);

            dgvNguyenLieu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNguyenLieu.Columns[0].HeaderText = "Mã nguyên liệu";
            dgvNguyenLieu.Columns[0].Width = 120;
            dgvNguyenLieu.Columns[1].HeaderText = "Tên nguyên liệu";
            dgvNguyenLieu.Columns[1].Width = 140;
            dgvNguyenLieu.Columns[2].HeaderText = "Loại nguyên liệu";
            dgvNguyenLieu.Columns[2].Width = 120;
            dgvNguyenLieu.Columns[3].HeaderText = "Năng lượng";
            dgvNguyenLieu.Columns[3].Width = 120;
            dgvNguyenLieu.Columns[4].HeaderText = "Đơn vị tính";
            dgvNguyenLieu.Columns[4].Width = 120;
            dgvNguyenLieu.ClearSelection();

        }


        private void getCombobox()
        {
            cboLoaiNguyenLieu.DataSource = LoaiNguyenLieuBLL.layDanhSachLoaiNguyenLieu();
            cboLoaiNguyenLieu.DisplayMember = "TenLoaiNL";
            cboLoaiNguyenLieu.Text = "";
        }

        private void SetEnabledComponents(bool value)
        {
            lblNote.Visible = !value;
            txtTenNguyenLieu.Enabled = value;
            cboLoaiNguyenLieu.Enabled = value;
            txtNangLuong.Enabled = value;
        }

        private void XoaTrang()
        {
            txtMaNguyenLieu.Text = NguyenLieuBLL.SinhMaTuDong();
            txtTenNguyenLieu.Text = "";
            txtNangLuong.Text = "0";
            txtDonViTinh.Text = "Kcal/gam";
            cboLoaiNguyenLieu.Text = "";
            SetEnabledComponents(true);
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex  > dgvNguyenLieu.RowCount) { return; }
            cboLoaiNguyenLieu.Text = "";
            txtMaNguyenLieu.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["MaNguyenLieu"].Value.ToString();
            txtTenNguyenLieu.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["TenNguyenLieu"].Value.ToString();
            cboLoaiNguyenLieu.SelectedText = dgvNguyenLieu.Rows[e.RowIndex].Cells["TenLoaiNL"].Value.ToString();
            txtNangLuong.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["NangLuong"].Value.ToString();
            txtDonViTinh.Text = dgvNguyenLieu.Rows[e.RowIndex].Cells["DonViTinh"].Value.ToString();
            
            SetEnabledComponents(!NguyenLieuBLL.KiemTraTonTaiMaNguyenLieuTrongMonAn(txtMaNguyenLieu.Text));
            
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (NguyenLieuBLL.KiemTraTonTaiMaNguyenLieuTrongMonAn(txtMaNguyenLieu.Text))
            {
                SetEnabledComponents(false);
                MessageBox.Show("Không thể cập nhật nguyên liệu đã được sử dụng trong món ăn");
                return;
            }

            if(txtNangLuong.Text.Trim() == "")
            {
                MessageBox.Show("Năng lượng không được bỏ trống");
                return;
            }
            NguyenLieuBLL.LuuNguyenLieu(txtMaNguyenLieu.Text.Trim(),txtTenNguyenLieu.Text.Trim(), cboLoaiNguyenLieu.Text.Trim(), double.Parse(txtNangLuong.Text.Trim()), txtDonViTinh.Text.Trim());
            getDataGridView();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (NguyenLieuBLL.KiemTraTonTaiMaNguyenLieuTrongMonAn(txtMaNguyenLieu.Text))
            {
                SetEnabledComponents(false);
                MessageBox.Show("Không thể xóa nguyên liệu đã được sử dụng trong món ăn");
                return;
            }
            NguyenLieuBLL.XoaNguyenLieu(txtMaNguyenLieu.Text.Trim());
            getDataGridView();
            XoaTrang();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TuKhoa = txtTimKiem.Text.Trim();
            getDataGridView();
            if (TuKhoa == "")
            {
                lblKetQua.Visible = false;
                lblSoKetQua.Visible = false;
                return;
            }
            lblKetQua.Visible = true;
            lblSoKetQua.Visible = true;
            lblSoKetQua.Text = dgvNguyenLieu.RowCount.ToString();
            XoaTrang();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void txtNangLuong_TextChanged(object sender, EventArgs e)
        {
            if(txtNangLuong.Text.Trim() == "") { return; }
            try
            {
                 double.Parse(txtNangLuong.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Năng lượng phải là số thực lớn hơn 0", "Lỗi nhập", MessageBoxButtons.OK);
                txtNangLuong.Text = "";
            }
        }
    }
}
