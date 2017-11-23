using DevComponents.DotNetBar;
using System.Windows.Forms;
using System;
using QLNT.Entities;
using QLNT.BusinessLayer;
using System.Data;

namespace QLNT.Presentation
{
    public partial class frmDiemDanh : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmDiemDanh(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        public frmDiemDanh()
        {
            InitializeComponent();
        }

        private void frmDiemDanh_Load(object sender, System.EventArgs e)
        {
            Init();
            loadListNamHoc();
            loadDataGridView();
        }
        
        private void loadDataGridView()
        {
            dgvDiemDanh.Columns.Clear();
            if (!string.IsNullOrEmpty(cboLop.Text))
            {
                string datetime = dtNgayDiemDanh.Value.ToString("yyyy-MM-dd");
                dgvDiemDanh.DataSource = DiemDanhBLL.LaySoDiemDanhLop(
                    LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())),
                    datetime.Split(' ')[0]);
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "HienDienCheckbox";
                checkColumn.HeaderText = "Hiện Diện";
                checkColumn.Width = 50;
                checkColumn.ReadOnly = false;
                checkColumn.FillWeight = 10; 
                dgvDiemDanh.Columns.Add(checkColumn);
                
                dgvDiemDanh.Columns["HienDien"].Visible = false;
                for (int i = 0; i < dgvDiemDanh.RowCount; i++)
                {
                    DataGridViewCheckBoxCell chkBoxCell = (DataGridViewCheckBoxCell)dgvDiemDanh.Rows[i].Cells["HienDienCheckbox"];
                    if (dgvDiemDanh.Rows[i].Cells["HienDien"].Value.ToString()=="1")
                    {
                        chkBoxCell.Value = "true";
                    }
                    else
                    {
                        chkBoxCell.Value = "false";
                    }
                }
                
            }



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

        private void Init()
        {
            int year = DateTime.Now.Year;
            DateTime date = new DateTime(year, 1,1);
            dtNgayDiemDanh.MaxDate = date.AddYears(1);
            dtNgayDiemDanh.MinDate = date;

            
            
        }
        private void LoadListLop()
        {
            cboLop.Items.Clear();
            cboLop.DisplayMember = "Text";
            cboLop.ValueMember = "Value";
            if (cboNamHoc.SelectedItem != null)
                foreach (Lop lop in LopBLL.GetListLop(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString())))
                    cboLop.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });

            cboLop.Text = "";
        }

       

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListLop();
            string namhoc = cboNamHoc.Text;
            int year = Int32.Parse(namhoc.Split('-')[0]);
            dtNgayDiemDanh.MinDate = new DateTime(year, 9, 5);
            dtNgayDiemDanh.MaxDate = new DateTime(year + 1, 9, 5);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtNgayDiemDanh_ValueChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnLuuDiemDanh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDiemDanh.Rows.Count; i++)
            {
                string maTre = dgvDiemDanh.Rows[i].Cells["MaTre"].Value.ToString();
                if (dgvDiemDanh.Rows[i].Cells["HienDienCheckbox"].Value.ToString() == "true" ||
                    dgvDiemDanh.Rows[i].Cells["HienDienCheckbox"].Value.ToString() == "True")
                    dgvDiemDanh.Rows[i].Cells["HienDien"].Value = "1";
                else
                    dgvDiemDanh.Rows[i].Cells["HienDien"].Value = "0";
            }
            LuuBangDiemDanh(dgvDiemDanh);
            
        }

        private void LuuBangDiemDanh(DataGridView dgvDiemDanh)
        {
            for (int i = 0; i < dgvDiemDanh.Rows.Count; i++)
            {
                TheoDoiNgay bangdiemdanh = new TheoDoiNgay();
                bangdiemdanh.MaTre = dgvDiemDanh.Rows[i].Cells["MaTre"].Value.ToString();
                bangdiemdanh.NgayDiemDanh = dtNgayDiemDanh.Value.ToString("yyyy-MM-dd");
                bangdiemdanh.HienDien = Int32.Parse(dgvDiemDanh.Rows[i].Cells["HienDien"].Value.ToString());
                bangdiemdanh.NhanXet = dgvDiemDanh.Rows[i].Cells["NhanXet"].Value.ToString();
                DiemDanhBLL.LuuBangDiemDanh(bangdiemdanh);
            }
        
        }
    }
}
