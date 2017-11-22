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
               
            }
            else
            {
               
            }

            //dgvTre.Columns[0].HeaderText = "STT";
            //dgvTre.Columns[4].HeaderText = "Họ tên trẻ";
            //dgvTre.Columns[5].HeaderText = "Giới tính";
            //dgvTre.Columns[6].HeaderText = "Ngày sinh";
            //dgvTre.Columns[7].HeaderText = "Cân nặng (kg)";
            //dgvTre.Columns[8].HeaderText = "Chiều cao (cm)";
            //dgvTre.Columns[9].HeaderText = "BMI";
            //dgvTre.Columns[10].HeaderText = "Tình trạng";
            //dgvTre.Columns[11].HeaderText = "Ghi chú";

            //dgvTre.Columns[0].Width = 50;
            //dgvTre.Columns[4].Width = 260;
            //dgvTre.Columns[5].Width = 100;
            //dgvTre.Columns[6].Width = 120;
            //dgvTre.Columns[7].Width = 150;
            //dgvTre.Columns[8].Width = 150;
            //dgvTre.Columns[9].Width = 120;
            //dgvTre.Columns[10].Width = 200;
            //dgvTre.Columns[10].Width = 300;

            //for (int i = 0; i < dgvTre.Rows.Count; i++)
            //{
            //    dgvTre.Rows[i].Cells[0].Value = i + 1;
            //}

            string[] listProp = { "STT", "HoTenTre", "GioiTinh", "NgaySinh", "CanNang", "ChieuCao", "BMI", "TinhTrang", "GhiChu" };
            ControlFormat.DataGridViewFormat(dgvTre, listProp);
        }
    }
}
