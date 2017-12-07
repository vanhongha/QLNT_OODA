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
    public partial class frmXepLop : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        private List<string> listMaTre;

        public frmXepLop()
        {
            InitializeComponent();
        }

        public frmXepLop(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        #region Function
        void LoadDGVDanhSach()
        {
            if (rdoXepLop.Checked)
            {
                dgvDanhSach.DataSource = TreBLL.GetListTreChuaCoLop();
                dgvDanhSach.Columns[1].HeaderText = "Họ tên trẻ";
                dgvDanhSach.Columns[2].HeaderText = "Ngày sinh";

                dgvDanhSach.Columns[0].Width = 50;
                dgvDanhSach.Columns[1].Width = 140;
                dgvDanhSach.Columns[2].Width = 120;

                for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
                    dgvDanhSach.Rows[i].Cells[0].Value = i + 1;

                string[] listProp = { "STT", "HoTenTre", "NgaySinh" };
                ControlFormat.DataGridViewFormat(dgvDanhSach, listProp);
                txtSiSo_LuaChon.Text = "";
            }
            else
            {
                if (cboLopHoc_LuaChon.SelectedItem != null)
                {
                    string maLop = KeyHandle.GetKeyFromCombobox(cboLopHoc_LuaChon.SelectedItem.ToString());
                    dgvDanhSach.DataSource = TreBLL.GetListTre(LopBLL.GetInfoLop(maLop));

                    dgvDanhSach.Columns[1].HeaderText = "Họ tên trẻ";
                    dgvDanhSach.Columns[2].HeaderText = "Ngày sinh";

                    dgvDanhSach.Columns[0].Width = 50;
                    dgvDanhSach.Columns[1].Width = 140;
                    dgvDanhSach.Columns[2].Width = 120;

                    for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
                        dgvDanhSach.Rows[i].Cells[0].Value = i + 1;

                    string[] listProp = { "STT", "HoTenTre", "NgaySinh" };
                    ControlFormat.DataGridViewFormat(dgvDanhSach, listProp);
                }
            }
        }

        void LoadDGVKetQua()
        {
            if (cboLop.SelectedItem != null)
            {
                string maLop = KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString());
                dgvKetQua.DataSource = TreBLL.GetListTre(LopBLL.GetInfoLop(maLop));

                dgvKetQua.Columns[2].HeaderText = "Họ tên trẻ";
                dgvKetQua.Columns[3].HeaderText = "Ngày sinh";

                dgvKetQua.Columns[0].Width = 50;
                dgvKetQua.Columns[2].Width = 140;
                dgvKetQua.Columns[3].Width = 120;

                for (int i = 0; i < dgvKetQua.Rows.Count; i++)
                    dgvKetQua.Rows[i].Cells[0].Value = i + 1;

                string[] listProp = { "STT", "HoTenTre", "NgaySinh" };
                ControlFormat.DataGridViewFormat(dgvKetQua, listProp);
            }
        }

        private void LoadListNamHoc()
        {
            ComboboxLoad.NienKhoa(cboNamHoc_LuaChon);
            ComboboxLoad.NienKhoa(cboNamHoc);
        }

        private void LoadListLoaiLop()
        {
            ComboboxLoad.LoaiLop(cboLoaiLop);
            ComboboxLoad.LoaiLop(cboLoaiLop_LuaChon);
        }

        private void RemoveAllListMaTre()
        {
            listMaTre.Clear();
        }

        private void SaveListMaTre(DataGridView dgv)
        {
            List<DataGridViewRow> selectedRows = dgv.SelectedRows
                     .OfType<DataGridViewRow>()
                     .Where(row => !row.IsNewRow)
                     .ToList();
            List<DataGridViewCell> selectedCells = dgv.SelectedCells.OfType<DataGridViewCell>().ToList();

            foreach (DataGridViewCell cell in selectedCells)
            {
                if (!selectedRows.Contains(dgv.Rows[cell.RowIndex]))
                    selectedRows.Add(dgv.Rows[cell.RowIndex]);
            }

            foreach (DataGridViewRow row in selectedRows)
                if (!listMaTre.Contains(row.Cells["MaTre"].Value.ToString()))
                    listMaTre.Add(row.Cells["MaTre"].Value.ToString());
        }

        // Có thêm ngày bắt đầu & ngày kết thúc là để khởi tạo thông tin sức khoẻ
        void XepLop(List<string> listMaTre, string maLop, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            if (TreBLL.XepLop(listMaTre, maLop))
            {
                KhoiTaoSucKhoe(listMaTre, ngayBatDau, ngayKetThuc);
                KhoiTaoHocPhi(listMaTre, ngayBatDau, ngayKetThuc);
                LoadDGVDanhSach();
                LoadDGVKetQua();
                MessageBox.Show("Thêm " + listMaTre.Count + " trẻ vào lớp " +
                    LopBLL.GetInfoLop(maLop).TenLop +
                    " thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Có thêm ngày bắt đầu & ngày kết thúc là để khởi tạo thông tin sức khoẻ
        void LenLop(List<string> listMaTre, string maLop, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            if (TreBLL.ChuyenLop(listMaTre, maLop))
            {
                KhoiTaoSucKhoe(listMaTre, ngayBatDau, ngayKetThuc);
                KhoiTaoHocPhi(listMaTre, ngayBatDau, ngayKetThuc);
                LoadDGVDanhSach();
                LoadDGVKetQua();
                MessageBox.Show("Chuyển " + listMaTre.Count + " trẻ vào lớp " +
                    LopBLL.GetInfoLop(maLop).TenLop +
                    " thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Trẻ có lớp rồi -> chuyển lớp
        void ChuyenLop(List<string> listMaTre, string maLop)
        {
            if (TreBLL.ChuyenLop(listMaTre, maLop))
            {
                LoadDGVDanhSach();
                LoadDGVKetQua();
                MessageBox.Show("Chuyển " + listMaTre.Count + " trẻ vào lớp " +
                    LopBLL.GetInfoLop(maLop).TenLop +
                    " thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void PuttingForwardHandle()
        {
            if (cboLop.SelectedItem != null)
            {
                // Ngày bắt đầu của niên khóa cần chuyển đến
                DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                // Ngày kết thúc của niên khóa cần chuyển đến
                DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                if (Checking.IsInOfDate(ngayBatDau, ngayKetThuc))   // Kiểm tra nếu như ngày bắt đầu, kết thúc của niên khóa cần chuyển đến là hợp lệ
                {
                    if (listMaTre.Count > 0)
                    {
                        // ------------------ XẾP LỚP - Dành cho trẻ mới được thêm vào trường và chưa có lớp ------------------ //
                        if (rdoXepLop.Checked)
                        {
                            string maLop = KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString());
                            XepLop(listMaTre, maLop, ngayBatDau, ngayKetThuc);
                            LopBLL.CapNhatSiSo(maLop, dgvKetQua.Rows.Count);
                            txtSiSo.Text = LopBLL.GetSiSo(maLop).ToString();
                        }
                        // ------------------ CHUYỂN LỚP - LÊN LỚP ------------------ //
                        else
                        {
                            // Ngày bắt đầu của niên khóa đang được chọn (left)
                            DateTime _ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc_LuaChon.SelectedItem.ToString()));
                            // Ngày kết thúc của niên khóa đang được chọn (left)
                            DateTime _ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc_LuaChon.SelectedItem.ToString()));
                            string maLop = KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString());
                            string maLopLuaChon = KeyHandle.GetKeyFromCombobox(cboLopHoc_LuaChon.SelectedItem.ToString());
                            // CHUYỂN LỚP
                            // Nếu như niên khóa được chọn hợp lệ: có nghĩa là lớp đó đang trong niên khóa đang được hoạt động
                            // và được chuyển đến lớp có niên khóa đang được hoạt động => CHUYỂN LỚP
                            if (Checking.IsInOfDate(_ngayBatDau, _ngayKetThuc))                     
                                ChuyenLop(listMaTre, maLop);                              

                            // Ngược lại thì trẻ được LÊN LỚP
                            else
                                LenLop(listMaTre, maLopLuaChon, ngayBatDau, ngayKetThuc);

                            // Xếp lớp xong thì cập nhật sĩ số
                            LopBLL.CapNhatSiSo(maLop, dgvKetQua.Rows.Count);
                            LopBLL.CapNhatSiSo(maLopLuaChon, dgvDanhSach.Rows.Count);
                            txtSiSo.Text = LopBLL.GetSiSo(maLop).ToString();
                            txtSiSo_LuaChon.Text = LopBLL.GetSiSo(maLopLuaChon).ToString();
                        }
                    }
                }
                else
                    MessageBox.Show("Lớp được chọn không còn hoạt động, vui lòng chọn lớp của niên khóa hiện tại", 
                        "Thông báo",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vui lòng chọn lớp để chuyển trẻ!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }

        private void PuttingBackHandle()
        {
            if (cboLopHoc_LuaChon.SelectedItem != null)
            {
                DateTime ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc_LuaChon.SelectedItem.ToString()));
                DateTime ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc_LuaChon.SelectedItem.ToString()));
                if (Checking.IsInOfDate(ngayBatDau, ngayKetThuc))
                {
                    if (listMaTre.Count > 0)
                    {
                        // CHUYỂN LỚP - LÊN LỚP
                        if (rdoChuyenLop.Checked)
                        {
                            // Ngày bắt đầu của niên khóa đang được chọn (right)
                            DateTime _ngayBatDau = NamHocBLL.GetNgayBatDau(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                            // Ngày kết thúc của niên khóa đang được chọn (right)
                            DateTime _ngayKetThuc = NamHocBLL.GetNgayKetThuc(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()));
                            string maLop = KeyHandle.GetKeyFromCombobox(cboLop.SelectedItem.ToString());
                            string maLopLuaChon = KeyHandle.GetKeyFromCombobox(cboLopHoc_LuaChon.SelectedItem.ToString());
                            // CHUYỂN LỚP
                            // Nếu như niên khóa được chọn hợp lệ: có nghĩa là lớp đó đang trong niên khóa đang được hoạt động
                            // và được chuyển đến lớp có niên khóa đang được hoạt động => CHUYỂN LỚP
                            if (Checking.IsInOfDate(_ngayBatDau, _ngayKetThuc))
                                ChuyenLop(listMaTre, maLopLuaChon);

                            // Ngược lại thì trẻ được LÊN LỚP
                            else
                                LenLop(listMaTre, maLopLuaChon, ngayBatDau, ngayKetThuc);

                            // Xếp lớp xong thì cập nhật sĩ số
                            LopBLL.CapNhatSiSo(maLop, dgvKetQua.Rows.Count);
                            LopBLL.CapNhatSiSo(maLopLuaChon, dgvDanhSach.Rows.Count);
                            txtSiSo.Text = LopBLL.GetSiSo(maLop).ToString();
                            txtSiSo_LuaChon.Text = LopBLL.GetSiSo(maLopLuaChon).ToString();
                        }
                    }
                }
                else
                    MessageBox.Show("Lớp được chọn không còn hoạt động, vui lòng chọn lớp của niên khóa hiện tại",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Vui lòng chọn lớp để chuyển trẻ!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
        }

        private void KhoiTaoSucKhoe(List<string> listMatre, DateTime start, DateTime end)
        {
            List<ThangNam> listThangNam = DataHandle.GetThoiGianTrongKhoan(start, end);
            foreach (ThangNam tn in listThangNam)
                foreach (string maTre in listMatre)
                    TreBLL.KhoiTaoSucKhoe(maTre, tn.thang, tn.nam);
        }

        private void KhoiTaoHocPhi(List<string> listMatre, DateTime start, DateTime end)
        {
            List<ThangNam> listThangNam = DataHandle.GetThoiGianTrongKhoan(start, end);
            foreach (ThangNam tn in listThangNam)
                foreach (string maTre in listMatre)
                    TreBLL.KhoiTaoHocPhi(maTre, tn.thang, tn.nam);
        }
        #endregion

        #region Event
        private void frmXepLop_Load(object sender, EventArgs e)
        {
            listMaTre = new List<string>();
            rdoChuyenLop.Checked = true;
            LoadDGVDanhSach();
            LoadListNamHoc();
            LoadListLoaiLop();
        }

        private void rdoChuyenLop_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiLop_LuaChon.Enabled = true;
            cboLopHoc_LuaChon.Enabled = true;
            cboNamHoc_LuaChon.Enabled = true;
            txtSiSo_LuaChon.Enabled = true;

            LoadDGVDanhSach();
        }

        private void rdoXepLop_CheckedChanged(object sender, EventArgs e)
        {
            cboLoaiLop_LuaChon.Text = null;
            cboLopHoc_LuaChon.Text = null;
            cboNamHoc_LuaChon.Text = null;
            txtSiSo_LuaChon.Text = null;

            cboLoaiLop_LuaChon.Enabled = false;
            cboLopHoc_LuaChon.Enabled = false;
            cboNamHoc_LuaChon.Enabled = false;
            txtSiSo_LuaChon.Enabled = false;

            LoadDGVDanhSach();
        }

        private void cboNamHoc_LuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxLoad.Lop(cboLopHoc_LuaChon, cboNamHoc_LuaChon, cboLoaiLop_LuaChon);
        }

        private void cboLoaiLop_LuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxLoad.Lop(cboLopHoc_LuaChon, cboNamHoc_LuaChon, cboLoaiLop_LuaChon);
        }

        private void cboLoaiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxLoad.Lop(cboLop, cboNamHoc, cboLoaiLop);
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxLoad.Lop(cboLop, cboNamHoc, cboLoaiLop);
        }

        private void cboLopHoc_LuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGVDanhSach();
            txtSiSo_LuaChon.Text = dgvDanhSach.Rows.Count.ToString();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDGVKetQua();
            txtSiSo.Text = dgvKetQua.Rows.Count.ToString();
        }

        private void btnPutForward_Click(object sender, EventArgs e)
        {
            RemoveAllListMaTre();
            SaveListMaTre(dgvDanhSach);
            PuttingForwardHandle();           
        }

        private void btnPutForwardAll_Click(object sender, EventArgs e)
        {
            RemoveAllListMaTre();
            dgvDanhSach.SelectAll();
            SaveListMaTre(dgvDanhSach);
            PuttingForwardHandle();
        }

        private void btnPutBack_Click(object sender, EventArgs e)
        {
            RemoveAllListMaTre();
            SaveListMaTre(dgvKetQua);
            PuttingBackHandle();
        }

        private void btnPutBackAll_Click(object sender, EventArgs e)
        {
            RemoveAllListMaTre();
            dgvKetQua.SelectAll();
            SaveListMaTre(dgvKetQua);
            PuttingBackHandle();
        }

        #endregion


    }
}
