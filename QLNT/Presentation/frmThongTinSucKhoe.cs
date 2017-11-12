using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using System;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmThongTinSucKhoe : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmThongTinSucKhoe(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmThongTinSucKhoe_Load(object sender, EventArgs e)
        {
            loadListNamHoc();
            loadListLoaiLop();
            initComboboxThang();
        }

        private void loadListNamHoc()
        {
            cboNamHoc.DisplayMember = "Text";
            cboNamHoc.ValueMember = "Value";
            foreach(NamHoc namHoc in LopBLL.GetListNamHoc())
            {
                cboNamHoc.Items.Add(new { Text = namHoc.NienKhoa.Trim(), Value = namHoc.MaNamHoc.Trim() });
            }
        }

        private void loadListLoaiLop()
        {
            cboLoaiLop.DisplayMember = "Text";
            cboLoaiLop.ValueMember = "Value";
            foreach (LoaiLop loaiLop in LopBLL.GetListLoaiLop())
            {
                cboLoaiLop.Items.Add(new { Text = loaiLop.TenLoaiLop.Trim(), Value = loaiLop.MaLoaiLop.Trim() });
            }
        }

        private void loadListLop()
        {
            cboLop.Items.Clear();
            cboLop.DisplayMember = "Text";
            cboLop.ValueMember = "Value";
            foreach (Lop lop in LopBLL.GetListLop(GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()),
                GetKeyFromCombobox(cboLoaiLop.SelectedItem.ToString())))
            {
                cboLop.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });
            }
            cboLop.Text = "";
            txtSiSo.Text = "";
        }

        private void initComboboxThang()
        {
            for(int i = 1; i < 13; i++)
            {
                cboThang.Items.Add(i.ToString());
            }

            DateTime date = DateTime.Now;
            cboThang.Text = date.Month.ToString();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cboLoaiLop.Text.Equals(""))
            {
                loadListLop();
            }
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cboNamHoc.Text.Equals(""))
            {
                loadListLop();
            }
        }

        string GetKeyFromCombobox(string value)
        {
            if (value != null)
            {
                var code = value.Split(new[] { "Value = " }, StringSplitOptions.None)[1];
                code = code.Substring(0, code.Length - 2);
                return code;
            }
            return "";
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSiSo.Text = LopBLL.GetInfoLop(GetKeyFromCombobox(cboLop.SelectedItem.ToString())).SiSo.ToString();
            loadDataGirdView();
        }

        private void loadDataGirdView()
        {
            dgvSucKhoe.DataSource = SucKhoeBLL.GetListSucKhoe(
                GetKeyFromCombobox(cboLop.SelectedItem.ToString()),
                int.Parse(cboThang.SelectedItem.ToString()),
                GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            dgvSucKhoe.Columns[1].HeaderText = "Mã trẻ";
            dgvSucKhoe.Columns[2].HeaderText = "Họ tên trẻ";
            dgvSucKhoe.Columns[3].HeaderText = "Giới tính";
            dgvSucKhoe.Columns[4].HeaderText = "Ngày sinh";
            dgvSucKhoe.Columns[5].HeaderText = "Cân nặng";
            dgvSucKhoe.Columns[6].HeaderText = "Chiều cao";
            dgvSucKhoe.Columns[7].HeaderText = "BMI";
            dgvSucKhoe.Columns[8].HeaderText = "Ghi chú";

            dgvSucKhoe.Columns[1].Width = 120;
            dgvSucKhoe.Columns[2].Width = 200;
            dgvSucKhoe.Columns[3].Width = 100;
            dgvSucKhoe.Columns[4].Width = 100;
            dgvSucKhoe.Columns[5].Width = 120;
            dgvSucKhoe.Columns[6].Width = 120;
            dgvSucKhoe.Columns[7].Width = 120;
            dgvSucKhoe.Columns[8].Width = 400;

            for (int i = 0; i < dgvSucKhoe.Rows.Count; i ++)
            {
                dgvSucKhoe.Rows[i].Cells[0].Value = i + 1;
            }

        }
        
    }
}
