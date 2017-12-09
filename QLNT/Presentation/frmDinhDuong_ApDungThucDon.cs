﻿using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNT.Ultilities;
using QLNT.Entities;
using QLNT.BusinessLayer;

namespace QLNT.Presentation
{
    public partial class frmDinhDuong_ApDungThucDon : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        string maThucDon = "";
        public frmDinhDuong_ApDungThucDon(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
        }

        private void frmDinhDuong_ApDungThucDon_Load(object sender, EventArgs e)
        {
            getComboboxLoaiLop();
            dtpNgay_Loc.Value = DateTime.Today;
            cboBuoiAD.SelectedText = "Sáng";
        }

        public void getDataGridViewLop(string maLop, int thang, int nam)
        {
            setCheckBoxColumn();
            dgvLop.DataSource = LopBLL.GetSucKhoeTheoLop(maLop, thang, nam);
            string[] column = { "X", "MaTre", "HoTenTre", "BMI", "TinhTrang", "GhiChu" };
            Ultilities.ControlFormat.DataGridViewFormat(dgvLop, column);

            dgvLop.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLop.Columns[1].HeaderText = "Mã Trẻ";
            dgvLop.Columns[1].Width = 100;
            dgvLop.Columns[2].HeaderText = "Tên Trẻ";
            dgvLop.Columns[2].Width = 120;
            dgvLop.Columns[3].HeaderText = "BMI";
            dgvLop.Columns[3].Width = 50;
            dgvLop.Columns[4].HeaderText = "Tình Trạng";
            //dgvLop.Columns[4].Width = 100;
            dgvLop.Columns[5].HeaderText = "Ghi Chú";
            dgvLop.Columns[5].Width = 100;
            dgvLop.ClearSelection();
        }

        public void getComboboxLoaiLop()
        {
            cboLoaiLop.DataSource = LopBLL.GetListLoaiLop();
            cboLoaiLop.DisplayMember = "TenLoaiLop";
            cboLoaiLop.ValueMember = "MaLoaiLop";
            getComboBoxMonAn();
        }

        public void getComboboxLop()
        {
            cboLop.DataSource = LopBLL.GetListLop(LopBLL.getMaNamHoc(dtpNgay_Loc.Value), cboLoaiLop.SelectedValue.ToString().Trim());
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            try
            {
                //cboLop.SelectedText = cboLop.Items.
            }
            catch(Exception err)
            {

            }
        }

        public void getComboBoxMonAn()
        {
            cboMonChinh.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonChinh.DisplayMember = "TenMonAn";
            cboMonChinh.ValueMember = "MaMonAn";

            cboMonPhu1.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonPhu1.DisplayMember = "TenMonAn";
            cboMonPhu1.ValueMember = "MaMonAn";
            cboMonPhu1.Text = "";

            cboMonPhu2.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonPhu2.DisplayMember = "TenMonAn";
            cboMonPhu2.ValueMember = "MaMonAn";
            cboMonPhu2.Text = "";

            cboMonPhu3.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonPhu3.DisplayMember = "TenMonAn";
            cboMonPhu3.ValueMember = "MaMonAn";
            cboMonPhu3.Text = "";

            cboMonPhu4.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonPhu4.DisplayMember = "TenMonAn";
            cboMonPhu4.ValueMember = "MaMonAn";
            cboMonPhu4.Text = "";

            cboMonPhu5.DataSource = ChiTietThucDonBLL.LayDanhSachTenVaMaMonAn();
            cboMonPhu5.DisplayMember = "TenMonAn";
            cboMonPhu5.ValueMember = "MaMonAn";
            cboMonPhu5.Text = "";
        }

        private void setCheckBoxColumn()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "X";
            checkBoxColumn.Width = 50;
            checkBoxColumn.ReadOnly = false;
            dgvLop.Columns.Clear();
            dgvLop.Columns.Add(checkBoxColumn);
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getComboboxLop();
        }

        private void dtpNgay_Loc_ValueChanged(object sender, EventArgs e)
        {
            getComboboxLop();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataGridViewLop(cboLop.SelectedValue.ToString().Trim(), dtpNgay_Loc.Value.Month, dtpNgay_Loc.Value.Year);
        }
    }
}
