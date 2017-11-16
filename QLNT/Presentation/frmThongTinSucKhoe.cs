using DevComponents.DotNetBar;
using QLNT.BusinessLayer;
using QLNT.Entities;
using QLNT.Ultilities;
using System;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmThongTinSucKhoe : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        private string maTre;

        public frmThongTinSucKhoe(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmThongTinSucKhoe_Load(object sender, EventArgs e)
        {
            initDataGridView();
            loadListNamHoc();
            loadListLoaiLop();
            initComboboxThang();
            loadDataGirdView();
        }

        private void initDataGridView()
        {
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.Name = "STT";
            sttColumn.HeaderText = "STT";
            sttColumn.Width = 50;
            sttColumn.ReadOnly = true;
            dgvSucKhoe.Columns.Add(sttColumn);
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
            for (int i = 1; i < 13; i++)
            {
                cboThang.Items.Add(i.ToString());
            }

            DateTime date = DateTime.Now;
            cboThang.Text = date.Month.ToString();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboLoaiLop.Text.Equals(""))
            {
                loadListLop();
            }
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboNamHoc.Text.Equals(""))
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
            if (cboLop.SelectedItem == null || cboThang.SelectedItem == null || cboNamHoc.SelectedItem == null)
            {
                dgvSucKhoe.DataSource = SucKhoeBLL.GetListSucKhoe("", 0, "");
            }
            else
            {
                dgvSucKhoe.DataSource = SucKhoeBLL.GetListSucKhoe(
                    GetKeyFromCombobox(cboLop.SelectedItem.ToString()),
                    int.Parse(cboThang.SelectedItem.ToString()),
                    GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            }

            dgvSucKhoe.Columns[0].HeaderText = "STT";
            dgvSucKhoe.Columns[4].HeaderText = "Họ tên trẻ";
            dgvSucKhoe.Columns[5].HeaderText = "Giới tính";
            dgvSucKhoe.Columns[6].HeaderText = "Ngày sinh";
            dgvSucKhoe.Columns[7].HeaderText = "Cân nặng (kg)";
            dgvSucKhoe.Columns[8].HeaderText = "Chiều cao (cm)";
            dgvSucKhoe.Columns[9].HeaderText = "BMI";
            dgvSucKhoe.Columns[10].HeaderText = "Ghi chú";

            dgvSucKhoe.Columns[0].Width = 50;
            dgvSucKhoe.Columns[4].Width = 260;
            dgvSucKhoe.Columns[5].Width = 100;
            dgvSucKhoe.Columns[6].Width = 120;
            dgvSucKhoe.Columns[7].Width = 150;
            dgvSucKhoe.Columns[8].Width = 150;
            dgvSucKhoe.Columns[9].Width = 120;
            dgvSucKhoe.Columns[10].Width = 500;

            for (int i = 0; i < dgvSucKhoe.Rows.Count; i++)
            {
                dgvSucKhoe.Rows[i].Cells[0].Value = i + 1;
            }

            string[] listProp = { "STT", "HoTenTre", "GioiTinh", "NgaySinh", "CanNang", "ChieuCao", "BMI", "GhiChu" };
            ControlFormat.DataGridViewFormat(dgvSucKhoe, listProp);
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGirdView();
        }

        private void dgvSucKhoe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgvSucKhoe.RowCount)
            {
                maTre = dgvSucKhoe.Rows[e.RowIndex].Cells["MaTre"].Value.ToString();
                txtCanNang.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["CanNang"].Value.ToString();
                txtChieuCao.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["ChieuCao"].Value.ToString();
                txtBMI.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["BMI"].Value.ToString();
                txtGhiChu.Text = dgvSucKhoe.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
                btnCapNhat.Enabled = true;
            }
        }

        private void txtCanNang_TextChanged(object sender, EventArgs e)
        {
            if (txtCanNang.Text == "") return;
            try
            {
                float.Parse(txtCanNang.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chỉ được nhập ký tự số.");
                return;
            }

            if(txtChieuCao.Text != "")
            {
                float canNang = float.Parse(txtCanNang.Text);
                float chieuCao = float.Parse(txtChieuCao.Text);
                txtBMI.Text = SucKhoeBLL.CalculateBMI(canNang, chieuCao).ToString();
            }
        }

        private void txtChieuCao_TextChanged(object sender, EventArgs e)
        {
            if (txtChieuCao.Text == "") return;
            try
            {
                float.Parse(txtChieuCao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ được nhập ký tự số.");
                return;
            }

            if (txtCanNang.Text != "")
            {
                float canNang = float.Parse(txtCanNang.Text);
                float chieuCao = float.Parse(txtChieuCao.Text);
                txtBMI.Text = SucKhoeBLL.CalculateBMI(canNang, chieuCao).ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SucKhoe sucKhoe = new SucKhoe();
            sucKhoe.MaTre = maTre;
            sucKhoe.Thang = int.Parse(cboThang.Text);
            sucKhoe.Nam = LopBLL.GetNamHoc(sucKhoe.Thang, GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            sucKhoe.CanNang = float.Parse(txtCanNang.Text);
            sucKhoe.ChieuCao = float.Parse(txtChieuCao.Text);
            sucKhoe.BMI = float.Parse(txtBMI.Text);
            sucKhoe.GhiChu = txtGhiChu.Text;
            if (SucKhoeBLL.CapNhatSucKhoe(sucKhoe))
            {
                MessageBox.Show("Cập nhật thành công!");
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
    }
}
