using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmTimKiem : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        #region Init
        public frmTimKiem()
        {
            InitializeComponent();
        }

        public frmTimKiem(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmTimKiem_Load(object sender, System.EventArgs e)
        {
            Init();
            loadListNamHoc();
            loadDataGirdView();
        }

        void Init()
        {
            grpChonLop.Enabled = false;
            grpKey.Enabled = false;

            DataGridViewTextBoxColumn gioiTinhColumn = new DataGridViewTextBoxColumn();
            gioiTinhColumn.Name = "GioiTinhCol";
            gioiTinhColumn.HeaderText = "Giới tính";
            gioiTinhColumn.Width = 150;
            gioiTinhColumn.ReadOnly = false;
            gioiTinhColumn.FillWeight = 10;
            dgvKetQua.Columns.Add(gioiTinhColumn);
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
        #endregion

        #region Function
        private void loadDataGirdView()
        {
            if (string.IsNullOrEmpty(cboLop.Text) && string.IsNullOrEmpty(txtKeyWord.Text))
                dgvKetQua.DataSource = TreBLL.GetListTre();
            else if (string.IsNullOrEmpty(cboLop.Text) && !string.IsNullOrEmpty(txtKeyWord.Text))
                dgvKetQua.DataSource = TreBLL.GetListTre(null, txtKeyWord.Text.Trim());
            else if (!string.IsNullOrEmpty(cboLop.Text) && string.IsNullOrEmpty(txtKeyWord.Text))
                dgvKetQua.DataSource = TreBLL.GetListTre(LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())));
            else
                dgvKetQua.DataSource = TreBLL.GetListTre(LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())), txtKeyWord.Text);

            dgvKetQua.Columns["MaTre"].DisplayIndex = 0;
            dgvKetQua.Columns["HoTenTre"].DisplayIndex = 1;
            dgvKetQua.Columns["NgaySinh"].DisplayIndex = 2;
            dgvKetQua.Columns["GioiTinhCol"].DisplayIndex = 3; 
            dgvKetQua.Columns["HoTenCha"].DisplayIndex = 4;
            dgvKetQua.Columns["HoTenMe"].DisplayIndex = 5;
            dgvKetQua.Columns["DiaChi"].DisplayIndex = 6;
            dgvKetQua.Columns["SDTLienLac"].DisplayIndex = 7;

            dgvKetQua.Columns["MaTre"].HeaderText = "Mã trẻ";
            dgvKetQua.Columns["HoTenTre"].HeaderText = "Họ tên trẻ";
            dgvKetQua.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvKetQua.Columns["HoTenCha"].HeaderText = "Họ tên cha";
            dgvKetQua.Columns["HoTenMe"].HeaderText = "Họ tên mẹ";
            dgvKetQua.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvKetQua.Columns["SDTLienLac"].HeaderText = "SDT";

            dgvKetQua.Columns["MaTre"].Width = 100;
            dgvKetQua.Columns["HoTenTre"].Width = 150;
            dgvKetQua.Columns["NgaySinh"].Width = 120;
            dgvKetQua.Columns["HoTenCha"].Width = 150;
            dgvKetQua.Columns["HoTenMe"].Width = 150;
            dgvKetQua.Columns["DiaChi"].Width = 200;
            dgvKetQua.Columns["SDTLienLac"].Width = 100;

            string[] listProp = { "MaTre", "HoTenTre", "NgaySinh", "GioiTinhCol", "HoTenCha", "HoTenMe", "DiaChi", "SDTLienLac" };
            ControlFormat.DataGridViewFormat(dgvKetQua, listProp);
        }

        private void LoadListLop()
        {
            cboLop.Items.Clear();
            cboLop.DisplayMember = "Text";
            cboLop.ValueMember = "Value";
            if(cboNamHoc.SelectedItem != null)
                foreach (Lop lop in LopBLL.GetListLop(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString())))
                    cboLop.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });
            
            cboLop.Text = "";
        }
        #endregion

        #region Event
        private void chkTimTheoLop_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkTimTheoLop.Checked)
                grpChonLop.Enabled = true;
            else
            {
                grpChonLop.Enabled = false;
                cboLop.Text = null;
                cboNamHoc.Text = null;
            }
        }

        private void chkTimTheoKey_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkTimTheoKey.Checked)
                grpKey.Enabled = true;
            else
            {
                grpKey.Enabled = false;
                txtKeyWord.Text = null;
            }
        }
        private void txtKeyWord_TextChanged(object sender, System.EventArgs e)
        {
            if (chkTimTheoKey.Checked)
                loadDataGirdView();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadListLop();
        }

        private void cboLop_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            loadDataGirdView();
        }

        private void btnDong_Click(object sender, System.EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void btnCapNhat_Click(object sender, System.EventArgs e)
        {
            Tre tempTre = new Tre(txtMaTre.Text,
                txtHoTen.Text,
                rdoNam.Checked ? 1 : 0,
                dtNgaySinh.Value,
                txtHoTenCha.Text,
                txtHoTenMe.Text,
                txtDiaChi.Text,
                txtSDT.Text);

            if (TreBLL.CapNhatThongTinTre(tempTre))
            {
                MessageBox.Show("Cập nhật thông tin trẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGirdView();
            }
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvKetQua.RowCount)
            {
                txtMaTre.Text = dgvKetQua.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                txtHoTen.Text = dgvKetQua.Rows[e.RowIndex].Cells["HoTenTre"].Value.ToString();
                txtHoTenCha.Text = dgvKetQua.Rows[e.RowIndex].Cells["HoTenCha"].Value.ToString();
                txtHoTenMe.Text = dgvKetQua.Rows[e.RowIndex].Cells["HoTenMe"].Value.ToString();
                txtDiaChi.Text = dgvKetQua.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvKetQua.Rows[e.RowIndex].Cells["SDTLienLac"].Value.ToString();
                dtNgaySinh.Value = Convert.ToDateTime(dgvKetQua.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString());
                rdoNam.Checked = Convert.ToInt32(dgvKetQua.Rows[e.RowIndex].Cells["GioiTinh"].Value) == 1;
                rdoNu.Checked = Convert.ToInt32(dgvKetQua.Rows[e.RowIndex].Cells["GioiTinh"].Value) == 0;
            }       
        }
        #endregion

        private void dgvKetQua_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvKetQua.Rows.Count; i++)
            {
                dgvKetQua.Rows[i].Cells["GioiTinhCol"].Value =
                    int.Parse(dgvKetQua.Rows[i].Cells["GioiTinh"].Value.ToString()) == 1 ? "Nam" : "Nữ";
            }
        }
    }
}
