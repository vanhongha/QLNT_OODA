using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmThongTinSucKhoe : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        private string maTre;
        private string gioiTinh;
        private DateTime ngaySinh;

        public frmThongTinSucKhoe(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        #region Init
        private void initDataGridView()
        {
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 50;
            sttColumn.ReadOnly = true;
            dgvSucKhoe.Columns.Add(sttColumn);

            DataGridViewTextBoxColumn gioiTinhColumn = new DataGridViewTextBoxColumn();
            gioiTinhColumn.Name = "GioiTinhCol";
            gioiTinhColumn.HeaderText = "Giới tính";
            gioiTinhColumn.Width = 150;
            gioiTinhColumn.ReadOnly = false;
            gioiTinhColumn.FillWeight = 10;
            dgvSucKhoe.Columns.Add(gioiTinhColumn);

            DataGridViewTextBoxColumn tinhTrangCol = new DataGridViewTextBoxColumn();
            tinhTrangCol.Name = "TinhTrangCol";
            tinhTrangCol.HeaderText = "Tình trạng học tập";
            tinhTrangCol.Width = 200;
            tinhTrangCol.ReadOnly = false;
            tinhTrangCol.FillWeight = 10;
            dgvSucKhoe.Columns.Add(tinhTrangCol);
        }
        #endregion

        #region Function
        private void loadListNamHoc()
        {
            cboNamHoc.DisplayMember = "Text";
            cboNamHoc.ValueMember = "Value";
            foreach (NamHoc namHoc in LopBLL.GetListNienKhoa())
            {
                cboNamHoc.Items.Add(new { Text = namHoc.NienKhoa.Trim(), Value = namHoc.MaNamHoc.Trim() });
            }
            cboNamHoc.SelectedIndex = cboNamHoc.Items.Count - 1;
        }

        private void loadListLoaiLop()
        {
            cboLoaiLop.DisplayMember = "Text";
            cboLoaiLop.ValueMember = "Value";
            foreach (LoaiLop loaiLop in LopBLL.GetListLoaiLop())
            {
                cboLoaiLop.Items.Add(new { Text = loaiLop.TenLoaiLop.Trim(), Value = loaiLop.MaLoaiLop.Trim() });
            }
            cboLoaiLop.SelectedIndex = 0;
        }

        private void loadListLop()
        {
            cboLop.Items.Clear();
            cboLop.DisplayMember = "Text";
            cboLop.ValueMember = "Value";
            foreach (Lop lop in LopBLL.GetListLop(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()),
                KeyHandle.GetKeyFromCombobox(cboLoaiLop.SelectedItem.ToString())))
            {
                cboLop.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });
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

            cboThang.Items.Clear();
            foreach (int thang in listThang)
            {
                cboThang.Items.Add(thang.ToString());
            }

            cboThang.Text = DateTime.Now.Month.ToString();
        }

        private void LoadDataGirdView()
        {
            if (cboLop.SelectedItem == null || cboThang.SelectedItem == null || cboNamHoc.SelectedItem == null)
            {
                dgvSucKhoe.DataSource = SucKhoeBLL.GetListSucKhoe("", 0, "");
            }
            else
            {
                dgvSucKhoe.DataSource = SucKhoeBLL.GetListSucKhoe(
                    KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString()),
                    int.Parse(cboThang.SelectedItem.ToString()),
                    KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            }

            dgvSucKhoe.Columns["HoTenTre"].DisplayIndex = 1;
            dgvSucKhoe.Columns["GioiTinhCol"].DisplayIndex = 2;
            dgvSucKhoe.Columns["NgaySinh"].DisplayIndex = 3;
            dgvSucKhoe.Columns["CanNang"].DisplayIndex = 4;
            dgvSucKhoe.Columns["ChieuCao"].DisplayIndex = 5;
            dgvSucKhoe.Columns["BMI"].DisplayIndex = 6;
            dgvSucKhoe.Columns["TinhTrang"].DisplayIndex = 7;
            dgvSucKhoe.Columns["GhiChu"].DisplayIndex = 8;
            dgvSucKhoe.Columns["TinhTrangCol"].DisplayIndex = 9;

            dgvSucKhoe.Columns["HoTenTre"].HeaderText = "Họ tên trẻ";
            dgvSucKhoe.Columns["GioiTinhCol"].HeaderText = "Giới tính";
            dgvSucKhoe.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvSucKhoe.Columns["CanNang"].HeaderText = "Cân nặng (kg)";
            dgvSucKhoe.Columns["ChieuCao"].HeaderText = "Chiều cao (cm)";
            dgvSucKhoe.Columns["BMI"].HeaderText = "BMI";
            dgvSucKhoe.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgvSucKhoe.Columns["GhiChu"].HeaderText = "Ghi chú";

            dgvSucKhoe.Columns["HoTenTre"].Width = 200;
            dgvSucKhoe.Columns["GioiTinhCol"].Width = 80;
            dgvSucKhoe.Columns["NgaySinh"].Width = 100;
            dgvSucKhoe.Columns["CanNang"].Width = 140;
            dgvSucKhoe.Columns["ChieuCao"].Width = 140;
            dgvSucKhoe.Columns["BMI"].Width = 70;
            dgvSucKhoe.Columns["TinhTrang"].Width = 180;
            dgvSucKhoe.Columns["GhiChu"].Width = 200;

            string[] listProp = { "STT", "HoTenTre", "GioiTinhCol", "NgaySinh", "CanNang", "ChieuCao", "BMI", "TinhTrang", "GhiChu", "TinhTrangCol"};
            ControlFormat.DataGridViewFormat(dgvSucKhoe, listProp);

            dgvSucKhoe.ClearSelection();
            maTre = "";
        }

        private void ClearAllField()
        {
            txtCanNang.Clear();
            txtChieuCao.Clear();
            txtBMI.Clear();
            txtTinhTrang.Clear();
            txtGhiChu.Clear();
            txtTenTre.Clear();
            btnCapNhat.Enabled = false;
            lbMessage.Text = "";
        }

        private void XetRangBuocCapNhatSucKhoe(string maTinhTrang, int dieuKien)
        {
            if (maTinhTrang == "2")
            {
                txtCanNang.ReadOnly = true;
                txtChieuCao.ReadOnly = true;
                txtGhiChu.Enabled = false;
                btnCapNhat.Enabled = false;
                lbMessage.Text = "Không thể cập nhật sức khỏe cho trẻ đã thôi học";
            }
            else
            {
                if (dieuKien == 0)
                {
                    txtCanNang.ReadOnly = false;
                    txtChieuCao.ReadOnly = false;
                    txtGhiChu.Enabled = true;
                    btnCapNhat.Enabled = true;
                    lbMessage.Text = "";
                }
                else
                {
                    txtCanNang.ReadOnly = true;
                    txtChieuCao.ReadOnly = true;
                    txtGhiChu.Enabled = false;
                    btnCapNhat.Enabled = false;
                    lbMessage.Text =
                        dieuKien == -1
                        ? "Đã qua thời gian cập nhật sức khỏe cho trẻ"
                        : "Chưa tới thời gian cập nhật sức khỏe cho trẻ";
                }
            }
        }

        #endregion

        #region Event
        private void frmThongTinSucKhoe_Load(object sender, EventArgs e)
        {
            initDataGridView();
            loadListNamHoc();
            loadListLoaiLop();
            LoadDataGirdView();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboLoaiLop.Text.Equals(""))
            {
                loadListLop();
                LoadDataGirdView();
                ClearAllField();
            }
            LoadListThang();
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboNamHoc.Text.Equals(""))
            {
                loadListLop();
                LoadDataGirdView();
                ClearAllField();
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSiSo.Text = LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())).SiSo.ToString();
            LoadDataGirdView();
            ClearAllField();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGirdView();
            ClearAllField();
        }

        private void dgvSucKhoe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvSucKhoe.RowCount)
            {
                try
                {
                    maTre = dgvSucKhoe.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                    gioiTinh = dgvSucKhoe.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                    ngaySinh = (DateTime)dgvSucKhoe.Rows[e.RowIndex].Cells["NgaySinh"].Value;
                    txtTenTre.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["HoTenTre"].Value.ToString();
                    txtCanNang.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["CanNang"].Value.ToString();
                    txtChieuCao.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["ChieuCao"].Value.ToString();
                    txtBMI.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["BMI"].Value.ToString();
                    txtTinhTrang.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["TinhTrang"].Value.ToString();
                    txtGhiChu.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
                    
                    int dieuKien = SucKhoeBLL.CoTheCapNhatSucKhoe(
                        int.Parse(cboThang.Text), 
                        KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                    string maTinhTrang = dgvSucKhoe.Rows[e.RowIndex].Cells["MaTinhTrang"].Value.ToString().Trim();
                    XetRangBuocCapNhatSucKhoe(maTinhTrang, dieuKien);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi. " + ex.Message);
                }
            }
        }

        private void txtCanNang_TextChanged(object sender, EventArgs e)
        {
            if (txtCanNang.Text == "")
            {
                txtBMI.Clear();
                return;
            }
            try
            {
                double.Parse(txtCanNang.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chỉ được nhập ký tự số.");
                txtCanNang.Clear();
                return;
            }

            if(txtChieuCao.Text != "")
            {
                double canNang = double.Parse(txtCanNang.Text);
                double chieuCao = double.Parse(txtChieuCao.Text);
                txtBMI.Text = SucKhoeBLL.CalculateBMI(canNang, chieuCao).ToString();
            }
        }

        private void txtChieuCao_TextChanged(object sender, EventArgs e)
        {
            if (txtChieuCao.Text == "")
            {
                txtBMI.Clear();
                return;
            }
            try
            {
                double.Parse(txtChieuCao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ được nhập ký tự số.");
                txtChieuCao.Clear();
                return;
            }

            if (txtCanNang.Text != "")
            {
                double canNang = double.Parse(txtCanNang.Text);
                double chieuCao = double.Parse(txtChieuCao.Text);
                txtBMI.Text = SucKhoeBLL.CalculateBMI(canNang, chieuCao).ToString();
            }
        }

        private void txtBMI_TextChanged(object sender, EventArgs e)
        {
            if(txtBMI.Text == "" || txtBMI.Text.Trim() == "0")
            {
                txtTinhTrang.Clear();
            } else
            {
                double bmi = double.Parse(txtBMI.Text);
                txtTinhTrang.Text = SucKhoeBLL.TinhTrangDuaTrenBMI(bmi, gioiTinh, ngaySinh);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtCanNang.Text == "")
            {
                MessageBox.Show("Cân nặng không được để trống.");
                return;
            }
            if(txtChieuCao.Text == "")
            {
                MessageBox.Show("Chiều cao không được để trống.");
                return;
            }
            SucKhoe sucKhoe = new SucKhoe();
            sucKhoe.MaTre = maTre;
            sucKhoe.Thang = int.Parse(cboThang.Text);
            sucKhoe.Nam = LopBLL.GetNamHoc(sucKhoe.Thang, KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            sucKhoe.CanNang = txtCanNang.Text.Trim() == "" ? 0 : double.Parse(txtCanNang.Text);
            sucKhoe.ChieuCao = txtChieuCao.Text.Trim() == "" ? 0 : double.Parse(txtChieuCao.Text);
            sucKhoe.BMI = txtBMI.Text.Trim() == "" ? 0 : double.Parse(txtBMI.Text);
            sucKhoe.TinhTrang = txtTinhTrang.Text;
            sucKhoe.GhiChu = txtGhiChu.Text;
            if (SucKhoeBLL.CapNhatSucKhoe(sucKhoe))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataGirdView();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void dgvSucKhoe_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            base.OnClick(e);
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvSucKhoe_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string maTinhTrang = "";
            for (int i = 0; i < dgvSucKhoe.Rows.Count; i++)
            {
                dgvSucKhoe.Rows[i].Cells[0].Value = i + 1;
                dgvSucKhoe.Rows[i].Cells["GioiTinhCol"].Value =
                    int.Parse(dgvSucKhoe.Rows[i].Cells["GioiTinh"].Value.ToString()) == 1 ? "Nam" : "Nữ";
                maTinhTrang = dgvSucKhoe.Rows[i].Cells["MaTinhTrang"].Value.ToString().Trim();
                dgvSucKhoe.Rows[i].DefaultCellStyle.BackColor = maTinhTrang == "2" ? Color.Yellow : Color.White;
                if(maTinhTrang == "2")
                {
                    dgvSucKhoe.Rows[i].Cells["TinhTrangCol"].Value = "Đã thôi học";
                }
            }
        }
        #endregion

    }
}
