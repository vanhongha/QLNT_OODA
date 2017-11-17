using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
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
        #endregion

    }
}
