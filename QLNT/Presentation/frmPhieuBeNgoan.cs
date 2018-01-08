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
    public partial class frmPhieuBeNgoan : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        #region Init
        public frmPhieuBeNgoan(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        public frmPhieuBeNgoan()
        {
            InitializeComponent();
        }

        private void frmPhieuBeNgoan_Load(object sender, EventArgs e)
        {
            Init();
            loadListNamHoc();
        }

        private void Init()
        {
            DateTime date = DateTime.Now;

            dtThangLapPhieu.Format = DateTimePickerFormat.Custom;
            dtThangLapPhieu.CustomFormat = "MM/yyyy";
            //dtThangLapPhieu.ShowUpDown = true;
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

        private void loadDataGridView()
        {
            dgvPhieuBeNgoan.Columns.Clear();
            if (!string.IsNullOrEmpty(cboLop.Text))
            {

                string datetime = dtThangLapPhieu.Text;
                dgvPhieuBeNgoan.DataSource = PhieuBeNgoanBLL.LayPhieuBeNgoanTheoLop(
                    LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())),
                    datetime);
                TaoPhieuTrong();
                if (dgvPhieuBeNgoan.RowCount <= 0)
                {
                    lbThongBao.Text = "Tháng " + dtThangLapPhieu.Value.ToString("MM-yyyy") + " chưa tạo phiếu bé ngoan";
                    btnLuuPhieu.Enabled = false;
                    lbThongBao.Visible = true;
                }
                else
                {
                    lbThongBao.Visible = false;
                    btnLuuPhieu.Enabled = true;

                    for (int i = 0; i < dgvPhieuBeNgoan.Rows.Count; i++)
                    {

                        for (int j = 1; j < 5; j++)
                        {
                            DataGridViewCheckBoxCell chkBoxCell = (DataGridViewCheckBoxCell)dgvPhieuBeNgoan.Rows[i].Cells["cbPhieu" + j];
                            if (dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanTuan" + j].Value.ToString() == "1")
                                chkBoxCell.Value = "true";
                            else
                                chkBoxCell.Value = "false";
                            
                        }
                        if (dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanThang"].Value.ToString() == "1")
                            dgvPhieuBeNgoan.Rows[i].Cells["cbPhieuThang"].Value = "true";
                        else
                            dgvPhieuBeNgoan.Rows[i].Cells["cbPhieuThang"].Value = "false";

                    }
                }
            }
            //(dgvPhieuBeNgoan as DataGridView).CellClick
            //                += new DataGridViewCellEventHandler(cb_CheckedChange);
        }

        private void XoaPhieuCu()
        {
            string ngaylapphieu = dtThangLapPhieu.Text;
            for (int i = 0; i < dgvPhieuBeNgoan.Rows.Count; i++)
            {
                PhieuBeNgoanBLL.XoaPhieuBeNgoan(dgvPhieuBeNgoan.Rows[i].Cells["MaTre"].Value.ToString(),
                    ngaylapphieu.Split('/')[0],
                    ngaylapphieu.Split('/')[1]);
            }
        }

        private void TaoPhieuTrong()
        {
            dgvPhieuBeNgoan.Columns["MaTre"].HeaderText = "Mã Trẻ";
            dgvPhieuBeNgoan.Columns["MaTre"].FillWeight = 50;
            dgvPhieuBeNgoan.Columns["HoTenTre"].HeaderText = "Họ Tên Trẻ";
            //dgvPhieuBeNgoan.Columns["HoTenTre"].FillWeight = 150;
            dgvPhieuBeNgoan.Columns["NhanXetThang"].HeaderText = "Nhận Xét Tháng";
            dgvPhieuBeNgoan.Columns["NhanXetThang"].FillWeight = 150;

            for (int i = 1; i < 5; i++)
            {
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "cbPhieu" + i;
                checkColumn.HeaderText = "Tuần " + i;
                checkColumn.ReadOnly = false;
                checkColumn.FillWeight = 20;
                checkColumn.DisplayIndex = 1 + i;
                dgvPhieuBeNgoan.Columns.Add(checkColumn);
                dgvPhieuBeNgoan.Columns["PhieuBeNgoanTuan" + i].Visible = false;

            }
            DataGridViewCheckBoxColumn phieuthang = new DataGridViewCheckBoxColumn();
            phieuthang.Name = "cbPhieuThang";
            phieuthang.HeaderText = "Cả Tháng";
            phieuthang.ReadOnly = false;
            phieuthang.FillWeight = 30;
            phieuthang.DefaultCellStyle.BackColor = Color.LimeGreen;
            phieuthang.DisplayIndex = 6;
            dgvPhieuBeNgoan.Columns.Add(phieuthang);
            dgvPhieuBeNgoan.Columns["PhieuBeNgoanThang"].Visible = false;

            dgvPhieuBeNgoan.Columns["NhanXetThang"].DisplayIndex = 7;

        }

        private void LuuPhieuBeNgoan(DataGridView dgvPhieuBeNgoan)
        {
            for (int i = 0; i < dgvPhieuBeNgoan.Rows.Count; i++)
            {
                TheoDoiThang phieubengoan = new TheoDoiThang();
                phieubengoan.MaTre = dgvPhieuBeNgoan.Rows[i].Cells["MaTre"].Value.ToString();
                string ngaylapphieu = dtThangLapPhieu.Text;
                phieubengoan.Nam = Int32.Parse(ngaylapphieu.Split('/')[1]);
                phieubengoan.Thang = Int32.Parse(ngaylapphieu.Split('/')[0]);
                phieubengoan.NhanXetThang = dgvPhieuBeNgoan.Rows[i].Cells["NhanXetThang"].Value.ToString();
                phieubengoan.PhieuTuan1 = Int32.Parse(dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanTuan1"].Value.ToString());
                phieubengoan.PhieuTuan2 = Int32.Parse(dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanTuan2"].Value.ToString());
                phieubengoan.PhieuTuan3 = Int32.Parse(dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanTuan3"].Value.ToString());
                phieubengoan.PhieuTuan4 = Int32.Parse(dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanTuan4"].Value.ToString());
                phieubengoan.PhieuThang = Int32.Parse(dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanThang"].Value.ToString());
                PhieuBeNgoanBLL.LuuPhieuBeNgoan(phieubengoan);
            }
        }
        #endregion

        #region Events
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListLop();

            DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));


            if (ngayBatDau >= dtThangLapPhieu.MaxDate)
            {
                dtThangLapPhieu.MaxDate = ngayKetThuc;
                dtThangLapPhieu.MinDate = ngayBatDau;
                dtThangLapPhieu.Value = ngayBatDau;
            }
            else
            {
                dtThangLapPhieu.MinDate = ngayBatDau;
                dtThangLapPhieu.MaxDate = ngayKetThuc;
                dtThangLapPhieu.Value = ngayBatDau;
            }


        }

        private void dtThangLapPhieu_ValueChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnTaoPhieuMoi_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = new DialogResult();
                if (dgvPhieuBeNgoan.RowCount > 0)
                {
                    confirm = MessageBox.Show("Tháng này đã có dữ liệu. Bạn có chắc muốn xóa để tạo mới hoàn toàn?",
                        "Cân nhắc", MessageBoxButtons.YesNo);
                }
                if (confirm == DialogResult.Yes || dgvPhieuBeNgoan.RowCount <= 0)
                {
                    XoaPhieuCu();
                    dgvPhieuBeNgoan.Columns.Clear();
                    if (!string.IsNullOrEmpty(cboLop.Text))
                    {
                        dgvPhieuBeNgoan.DataSource = PhieuBeNgoanBLL.TaoPhieuBeNgoanMoi(
                            LopBLL.GetInfoLop(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())),
                            dtThangLapPhieu.Text);
                        TaoPhieuTrong();
                        MessageBox.Show("Một phiếu mới hoàn toàn vừa được tạo", "Thông báo");
                        btnLuuPhieu.Enabled = true;
                    }
                }
                else if (confirm == DialogResult.No)
                { return; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }

        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                //Xoa cai cu
                XoaPhieuCu();
                //Tao cai moi
                for (int i = 0; i < dgvPhieuBeNgoan.Rows.Count; i++)
                {
                    for (int j = 1; j < 5; j++)
                    {
                        if (dgvPhieuBeNgoan.Rows[i].Cells["cbPhieu" + j].Value == null ||
                        dgvPhieuBeNgoan.Rows[i].Cells["cbPhieu" + j].Value.ToString() == "False" ||
                        dgvPhieuBeNgoan.Rows[i].Cells["cbPhieu" + j].Value.ToString() == "false")
                            dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanTuan" + j].Value = "0";
                        else
                            dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanTuan" + j].Value = "1";
                    }
                    if (dgvPhieuBeNgoan.Rows[i].Cells["cbPhieuThang"].Value == null ||
                        dgvPhieuBeNgoan.Rows[i].Cells["cbPhieuThang"].Value.ToString() == "False" ||
                        dgvPhieuBeNgoan.Rows[i].Cells["cbPhieuThang"].Value.ToString() == "false")
                        dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanThang"].Value = "0";
                    else
                        dgvPhieuBeNgoan.Rows[i].Cells["PhieuBeNgoanThang"].Value = "1";

                }
                LuuPhieuBeNgoan(dgvPhieuBeNgoan);
                MessageBox.Show("Phiếu được lưu thành công", "Thông báo");
                loadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        #endregion
        //public void cb_CheckedChange(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < dgvPhieuBeNgoan.RowCount; i++) {
        //        if (dgvPhieuBeNgoan.Rows[i].Cells["cbPhieu1"].Value.ToString() == "true"
        //            && dgvPhieuBeNgoan.Rows[i].Cells["cbPhieu2"].Value.ToString() == "true"
        //            && dgvPhieuBeNgoan.Rows[i].Cells["cbPhieu3"].Value.ToString() == "true"
        //            && dgvPhieuBeNgoan.Rows[i].Cells["cbPhieu4"].Value.ToString() == "true")
        //        {
        //            dgvPhieuBeNgoan.Rows[i].Cells["cbPhieuThang"].Value="1";
        //        }
        //    }
        //    Console.Write("i - ");
            
        //}
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView();

            DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
            DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));

            if (LopBLL.GetSiSo(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())) > 0
            && Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
            {
                btnTaoPhieuMoi.Enabled = true;
                //btnLuuPhieu.Enabled = true;
            }
            else if (LopBLL.GetSiSo(KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString())) <= 0)
            {
                lbThongBao.Text += "\nLớp không có học sinh, không thể tạo phiếu mới";
                btnLuuPhieu.Enabled = false;
                btnTaoPhieuMoi.Enabled = false;
                lbThongBao.Visible = true;
            }
            else if (!Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
            {
                lbThongBao.Text += "\nNiên khóa đã qua, không thể tạo phiếu mới";
                btnLuuPhieu.Enabled = false;
                btnTaoPhieuMoi.Enabled = false;
                lbThongBao.Visible = true;
            }

        }

        private void dgvPhieuBeNgoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvPhieuBeNgoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !Convert.ToBoolean(dgvPhieuBeNgoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                dgvPhieuBeNgoan.Rows[e.RowIndex].Cells["cbPhieuThang"].Value = PhieuBeNgoanBLL.XetPhieuThang(dgvPhieuBeNgoan, e.RowIndex, e.ColumnIndex);
            }
            catch
            {
                return;
            }
        }
    }
}
