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
    public partial class frmThuHocPhi : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        private string maTre = "";
        private decimal hocPhiConNo = 0;

        public frmThuHocPhi(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmThuHocPhi_Load(object sender, EventArgs e)
        {
            InitDataGridView();
            LoadListNamHoc();
            LoadListLoaiLop();
            LoadDataGirdView();
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
            if (cboLop.SelectedItem == null || cboNamHoc.SelectedItem == null)
            {
                dgvTre.DataSource = TreBLL.GetListTreTheoMaLop("");
            }
            else
            {
                dgvTre.DataSource = TreBLL.GetListTreTheoMaLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString()));
            }

            dgvTre.Columns[0].HeaderText = "STT";
            dgvTre.Columns[2].HeaderText = "Họ tên trẻ";
            dgvTre.Columns[3].HeaderText = "Giới tính";
            dgvTre.Columns[4].HeaderText = "Ngày sinh";
            dgvTre.Columns[9].HeaderText = "Học phí còn nợ";

            dgvTre.Columns[0].Width = 50;
            dgvTre.Columns[2].Width = 260;
            dgvTre.Columns[3].Width = 100;
            dgvTre.Columns[4].Width = 120;
            dgvTre.Columns[9].Width = 200;

            for (int i = 0; i < dgvTre.Rows.Count; i++)
            {
                dgvTre.Rows[i].Cells[0].Value = i + 1;
            }

            string[] listProp = { "STT", "HoTenTre", "GioiTinh", "NgaySinh", "HocPhiConNo" };
            ControlFormat.DataGridViewFormat(dgvTre, listProp);
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboLoaiLop.Text.Equals(""))
            {
                LoadListLop();
                LoadDataGirdView();
                ClearAllField();
            }
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

        private void ClearAllField()
        {
            txtTenTre.Clear();
            txtNguoiDongTien.Clear();
            txtNguoiThuTien.Clear();
            txtSoTienDong.Clear();
            txtSoTienConNo.Clear();
            txtGhiChu.Clear();
            dtNgayThu.Text = "";
        }

        private void dgvTre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.RowIndex != dgvTre.RowCount)
            {
                ClearAllField();
                txtTenTre.Text = dgvTre.Rows[e.RowIndex].Cells["HoTenTre"].Value.ToString();
                txtSoTienConNo.Text = dgvTre.Rows[e.RowIndex].Cells["HocPhiConNo"].Value.ToString();
                maTre = dgvTre.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                hocPhiConNo = decimal.Parse(dgvTre.Rows[e.RowIndex].Cells["HocPhiConNo"].Value.ToString());
                LoadListThongTinDongHocPhi();
            }
        }

        private void LoadListThongTinDongHocPhi()
        {
            dgvBienLai.DataSource = HocPhiBLL.GetListBienLai(maTre);
        }

        private void txtSoTienDong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienDong.Text == "") return;
            try
            {
                decimal soTienDong = decimal.Parse(txtSoTienDong.Text);
                txtSoTienConNo.Text = (hocPhiConNo - soTienDong).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi.");
                txtSoTienDong.Clear();
            }
        }

        private void btnLapBienLai_Click(object sender, EventArgs e)
        {
            if (txtTenTre.Text == "" || txtSoTienDong.Text == "" || txtNguoiDongTien.Text == "" || txtNguoiThuTien.Text == "") return;
            BienLaiThuHocPhi bienLai = new BienLaiThuHocPhi();
            bienLai.MaBienLai = HocPhiBLL.GenerateMaBienLai();
            bienLai.MaTre = maTre;
            bienLai.NguoiDong = txtNguoiDongTien.Text;
            bienLai.NguoiThu = txtNguoiThuTien.Text;
            bienLai.NgayThu = dtNgayThu.Value;
            bienLai.SoTienThu = decimal.Parse(txtSoTienDong.Text);
            bienLai.SoTienConNo = decimal.Parse(txtSoTienConNo.Text);
            bienLai.GhiChu = txtGhiChu.Text;

            HocPhiBLL.ThemBienLai(bienLai);
            LoadDataGirdView();
            LoadListThongTinDongHocPhi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }
    }
}
