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

            dgvKetQua.Columns[0].HeaderText = "Mã trẻ";
            dgvKetQua.Columns[1].HeaderText = "Họ tên trẻ";
            dgvKetQua.Columns[2].HeaderText = "Ngày sinh";
            dgvKetQua.Columns[3].HeaderText = "Giới tính";
            dgvKetQua.Columns[4].HeaderText = "Họ tên cha";
            dgvKetQua.Columns[5].HeaderText = "Họ tên mẹ";
            dgvKetQua.Columns[6].HeaderText = "Địa chỉ";
            dgvKetQua.Columns[7].HeaderText = "SDT";

            dgvKetQua.Columns[0].Width = 100;
            dgvKetQua.Columns[1].Width = 150;
            dgvKetQua.Columns[2].Width = 120;
            dgvKetQua.Columns[3].Width = 80;
            dgvKetQua.Columns[4].Width = 150;
            dgvKetQua.Columns[5].Width = 150;
            dgvKetQua.Columns[6].Width = 200;
            dgvKetQua.Columns[7].Width = 100;

            string[] listProp = { "MaTre", "HoTenTre", "NgaySinh", "GioiTinh", "HoTenCha", "HoTenMe", "DiaChi", "SDTLienLac" };
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
            MessageBox.Show("cbo lop");
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
    }
}
