﻿using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmThuHocPhi : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        private string username;

        private string maTre = "";
        private string maHocPhi = "";
        private decimal hocPhiConNo = 0;

        public frmThuHocPhi(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab, string _username)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
            username = _username;
        }

        private void frmThuHocPhi_Load(object sender, EventArgs e)
        {
            InitDataGridView();
            LoadListNamHoc();
            LoadListLoaiLop();
            LoadDataGirdView();
            lbNgayThu.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtNguoiThuTien.Text = TaiKhoanBLL.GetTenNguoiDung(username);
        }

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

            DataGridViewTextBoxColumn tinhTrangCol = new DataGridViewTextBoxColumn();
            tinhTrangCol.Name = "TinhTrang";
            tinhTrangCol.HeaderText = "Tình trạng";
            tinhTrangCol.Width = 150;
            tinhTrangCol.ReadOnly = false;
            tinhTrangCol.FillWeight = 10;
            dgvBienLai.Columns.Add(tinhTrangCol);
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

        private void LoadDataGirdView()
        {
            int thang = DateTime.Now.Month - 1;
            int nam = DateTime.Now.Year;
            if (thang == 0)
            {
                thang = 12;
                nam -= 1;
            } 

            if (cboLop.SelectedItem == null || cboNamHoc.SelectedItem == null)
            {
                dgvTre.DataSource = HocPhiBLL.GetListHocPhiTheoThang("", thang, nam);
            }
            else
            {
                dgvTre.DataSource = HocPhiBLL.GetListHocPhiTheoThang(
                    KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString()),
                    thang, nam);
            }

            dgvTre.Columns["STT"].DisplayIndex = 0;
            dgvTre.Columns["HoTenTre"].DisplayIndex = 1;
            dgvTre.Columns["GioiTinhCol"].DisplayIndex = 2;
            dgvTre.Columns["NgaySinh"].DisplayIndex = 3;
            dgvTre.Columns["TongTienHocPhi"].DisplayIndex = 4;
            dgvTre.Columns["SoTienDaDong"].DisplayIndex = 5;
            dgvTre.Columns["SoTienConNo"].DisplayIndex = 6;

            dgvTre.Columns["STT"].HeaderText = "STT";
            dgvTre.Columns["HoTenTre"].HeaderText = "Họ tên trẻ";
            dgvTre.Columns["GioiTinhCol"].HeaderText = "Giới tính";
            dgvTre.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvTre.Columns["TongTienHocPhi"].HeaderText = "Tổng tiền học phí";
            dgvTre.Columns["SoTienDaDong"].HeaderText = "Số tiền đã đóng";
            dgvTre.Columns["SoTienConNo"].HeaderText = "Số tiền còn nợ";

            dgvTre.Columns["STT"].Width = 50;
            dgvTre.Columns["HoTenTre"].Width = 300;
            dgvTre.Columns["GioiTinhCol"].Width = 100;
            dgvTre.Columns["NgaySinh"].Width = 140;
            dgvTre.Columns["TongTienHocPhi"].Width = 250;
            dgvTre.Columns["SoTienDaDong"].Width = 250;
            dgvTre.Columns["SoTienConNo"].Width = 250;

            string[] listProp = { "STT", "HoTenTre", "GioiTinhCol", "NgaySinh", "TongTienHocPhi", "SoTienDaDong", "SoTienConNo"};
            ControlFormat.DataGridViewFormat(dgvTre, listProp);

            dgvTre.ClearSelection();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboLoaiLop.Text.Equals(""))
            {
                LoadListLop();
                LoadDataGirdView();
                ClearAllField();
            }
            LoadListThang();
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboNamHoc.Text.Equals(""))
            {
                LoadListLop();
                LoadDataGirdView();
                ClearAllField();
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGirdView();
            ClearAllField();
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

            cboThang.Items.Clear();
            foreach (int thang in listThang)
            {
                cboThang.Items.Add(thang.ToString());
            }
        }

        private void ClearAllField()
        {
            txtTenTre.Clear();
            txtNguoiDongTien.Clear();
            txtSoTienDong.Clear();
            txtSoTienConNo.Clear();
            txtGhiChu.Clear();
            maTre = "";
            maHocPhi = "";
            hocPhiConNo = 0;
        }

        private void dgvTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvTre.RowCount)
            {
                ClearAllField();
                txtTenTre.Text = dgvTre.Rows[e.RowIndex].Cells["HoTenTre"].Value.ToString();
                txtSoTienConNo.Text = dgvTre.Rows[e.RowIndex].Cells["SoTienConNo"].Value.ToString();
                maTre = dgvTre.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                maHocPhi = dgvTre.Rows[e.RowIndex].Cells["MaHocPhi"].Value.ToString();
                hocPhiConNo = decimal.Parse(dgvTre.Rows[e.RowIndex].Cells["SoTienConNo"].Value.ToString());
                LoadListThongTinDongHocPhi();
            }
        }

        private void LoadListThongTinDongHocPhi()
        {
            int thang;
            if (cboThang.Text == "")
                thang = 0;
            else
                thang = int.Parse(cboThang.Text);
            dgvBienLai.DataSource = HocPhiBLL.LayDanhSachBienLaiTheoThang(maTre, thang, KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            dgvBienLai.Columns["MaBienLai"].DisplayIndex = 0;
            dgvBienLai.Columns["NguoiDong"].DisplayIndex = 1;
            dgvBienLai.Columns["NguoiThu"].DisplayIndex = 2;
            dgvBienLai.Columns["NgayThu"].DisplayIndex = 3;
            dgvBienLai.Columns["SoTienThu"].DisplayIndex = 4;
            dgvBienLai.Columns["SoTienConNo"].DisplayIndex = 5;
            dgvBienLai.Columns["GhiChu"].DisplayIndex = 6;
            dgvBienLai.Columns["TinhTrang"].DisplayIndex = 7;

            dgvBienLai.Columns["MaBienLai"].HeaderText = "Mã biên lai";
            dgvBienLai.Columns["NguoiDong"].HeaderText = "Người nộp tiền";
            dgvBienLai.Columns["NguoiThu"].HeaderText = "Người thu tiền";
            dgvBienLai.Columns["NgayThu"].HeaderText = "Ngày thu tiền";
            dgvBienLai.Columns["SoTienThu"].HeaderText = "Số tiền thu";
            dgvBienLai.Columns["SoTienConNo"].HeaderText = "Số tiền còn nợ";
            dgvBienLai.Columns["GhiChu"].HeaderText = "Nội dung thu";
            dgvBienLai.Columns["TinhTrang"].HeaderText = "Tình trạng";

            dgvBienLai.Columns["MaBienLai"].Width = 120;
            dgvBienLai.Columns["NguoiDong"].Width = 200;
            dgvBienLai.Columns["NguoiThu"].Width = 200;
            dgvBienLai.Columns["NgayThu"].Width = 150;
            dgvBienLai.Columns["SoTienThu"].Width = 140;
            dgvBienLai.Columns["SoTienConNo"].Width = 140;
            dgvBienLai.Columns["GhiChu"].Width = 200;
            dgvBienLai.Columns["TinhTrang"].Width = 150;

            string[] listProp = { "MaBienLai", "NguoiDong", "NguoiThu", "NgayThu", "SoTienThu", "SoTienConNo", "GhiChu", "TinhTrang" };
            ControlFormat.DataGridViewFormat(dgvBienLai, listProp);

            dgvBienLai.ClearSelection();
        }

        private void txtSoTienDong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienDong.Text == "")
            {
                txtSoTienConNo.Text = hocPhiConNo.ToString();
                return;
            }
            try
            {
                decimal soTienDong = decimal.Parse(txtSoTienDong.Text);
                if(hocPhiConNo - soTienDong < 0)
                {
                    MessageBox.Show("Số tiền thu không được vượt quá số tiền nợ học phí.");
                    txtSoTienDong.Clear();
                    return;
                }
                txtSoTienConNo.Text = (hocPhiConNo - soTienDong).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ được nhập kí tự số.");
                txtSoTienDong.Clear();
            }
        }

        private void btnLapBienLai_Click(object sender, EventArgs e)
        {
            if(txtTenTre.Text == "")
            {
                MessageBox.Show("Phải chọn một trẻ để lập biên lai.");
                return;
            }
            if(txtNguoiDongTien.Text == "")
            {
                MessageBox.Show("Tên người đóng tiền không được bỏ trống.");
                return;
            }
            if(txtNguoiThuTien.Text == "")
            {
                MessageBox.Show("Tên người thu tiền không được bỏ trống");
                return;
            }
            if(txtSoTienDong.Text == "")
            {
                MessageBox.Show("Số tiền đóng không được bỏ trống.");
                return;
            }
            if(decimal.Parse(txtSoTienDong.Text) <= 0)
            {
                MessageBox.Show("Số tiền đóng phải lớn hơn 0.");
                return;
            }

            try
            {
                BienLaiThuHocPhi bienLai = new BienLaiThuHocPhi();
                bienLai.MaBienLai = HocPhiBLL.GenerateMaBienLai();
                bienLai.MaTre = maTre;
                bienLai.NguoiDong = txtNguoiDongTien.Text;
                bienLai.NguoiThu = txtNguoiThuTien.Text;
                bienLai.NgayThu = DateTime.Now;
                bienLai.SoTienThu = decimal.Parse(txtSoTienDong.Text);
                bienLai.SoTienConNo = decimal.Parse(txtSoTienConNo.Text);
                bienLai.GhiChu = txtGhiChu.Text;

                HocPhiBLL.ThemBienLai(bienLai, maHocPhi);
                MessageBox.Show("Thêm biên lai thành công!");
                
                LoadDataGirdView();
                cboThang.Text = DateTime.Now.Month.ToString();
                LoadListThongTinDongHocPhi();
                txtNguoiDongTien.Clear();
                txtSoTienDong.Clear();
                txtGhiChu.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListThongTinDongHocPhi();
        }

        private void btnXoaBienLai_Click(object sender, EventArgs e)
        {
            if(dgvBienLai.SelectedRows.Count < 1)
            {
                MessageBox.Show("Phải chọn một biên lai.");
                return;
            }
            if(!HocPhiBLL.CoTheHuyBienLai((DateTime)dgvBienLai.SelectedRows[0].Cells["NgayThu"].Value, DateTime.Now))
            {
                MessageBox.Show("Không thể hủy biên lai này. Biên lai chỉ được hủy trong ngày tạo.");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc sẽ hủy biên lai đã chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (result == DialogResult.Yes)
                {
                    BienLaiThuHocPhi bienLai = new BienLaiThuHocPhi();
                    bienLai.MaBienLai = dgvBienLai.SelectedRows[0].Cells["MaBienLai"].Value.ToString();
                    bienLai.MaTre = dgvBienLai.SelectedRows[0].Cells["MaTre"].Value.ToString();
                    bienLai.NguoiDong = dgvBienLai.SelectedRows[0].Cells["NguoiDong"].Value.ToString();
                    bienLai.NguoiThu = dgvBienLai.SelectedRows[0].Cells["NguoiThu"].Value.ToString();
                    bienLai.NgayThu = (DateTime)dgvBienLai.SelectedRows[0].Cells["NgayThu"].Value;
                    bienLai.SoTienThu = decimal.Parse(dgvBienLai.SelectedRows[0].Cells["SoTienThu"].Value.ToString());
                    bienLai.SoTienConNo = decimal.Parse(dgvBienLai.SelectedRows[0].Cells["SoTienConNo"].Value.ToString());
                    bienLai.GhiChu = dgvBienLai.SelectedRows[0].Cells["GhiChu"].Value.ToString();
                    HocPhiBLL.HuyBienLai(bienLai, maHocPhi);
                    MessageBox.Show("Đã hủy biên lai!");

                    LoadListThongTinDongHocPhi();
                    LoadDataGirdView();
                    ClearAllField();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnInBienLai_Click(object sender, EventArgs e)
        {
            if(dgvBienLai.SelectedRows.Count < 1)
            {
                MessageBox.Show("Phải chọn một biên lai.");
                return;
            }
            Form frmBienLai = new frmBienLaiHocPhi(dgvBienLai.SelectedRows[0].Cells["MaBienLai"].Value.ToString());
            frmBienLai.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataGirdView();
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

        private void dgvBienLai_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for(int i = 0; i < dgvBienLai.Rows.Count; i++)
            {
                if(dgvBienLai.Rows[i].Cells["ConSuDung"].Value.ToString() == "0")
                {
                    dgvBienLai.Rows[i].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    dgvBienLai.Rows[i].Cells["TinhTrang"].Value = "Đã hủy";
                }
            }
        }

        private void dgvBienLai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.RowIndex < dgvBienLai.Rows.Count)
            {
                if (dgvBienLai.Rows[e.RowIndex].Cells["ConSuDung"].Value.ToString() == "0")
                {
                    btnInBienLai.Enabled = false;
                    btnXoaBienLai.Enabled = false;
                }
                else
                {
                    btnInBienLai.Enabled = true;
                    btnXoaBienLai.Enabled = true;
                }
            }
        }
    }
}
