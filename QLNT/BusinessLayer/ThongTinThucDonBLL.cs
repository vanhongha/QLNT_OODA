using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DataLayer;
using QLNT.Entities;
using System.Data;
using System.Windows.Forms;

namespace QLNT.BusinessLayer
{
    class ThongTinThucDonBLL
    {
        public static bool LuuThongTinThucDon(List<string> listTre, List<string> listMonAn, string buoiAD, DateTime ngayAD)
        {
            #region // check input
            if (listTre.Count == 0)
            {
                MessageBox.Show("Chưa chọn trẻ để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (listMonAn.Count == 0)
            {
                MessageBox.Show("Chưa chọn món ăn để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (buoiAD == "")
            {
                MessageBox.Show("Chưa chọn buổi để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (ngayAD == null)
            {
                MessageBox.Show("Chưa chọn ngày để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            #endregion

            string[] loaiAD = { "Món chính", "Món phụ 1", "Món phụ 2", "Món phụ 3", "Món phụ 4", "Món phụ 5" };
            for(int i = 0; i < listTre.Count; i++)
            {
                for(int j = 0; j < listMonAn.Count; j++)
                {
                    if(listMonAn[j] == "")
                    {
                        continue;
                    }
                    Entities.ThongTinThucDon thongTinTD = new Entities.ThongTinThucDon(listTre[i], buoiAD, ngayAD, listMonAn[j], loaiAD[j]);
                    if (!ThemThongTinThucDon(thongTinTD)) { return false; }
                }
            }

            MessageBox.Show("Đã thêm thực đơn cho "+ listTre.Count + " trẻ", "Thông báo", MessageBoxButtons.OK);
            return true;

        }

        public static bool HuyThongTinThucDon(List<string> listTre, string buoiAD, DateTime ngayAD)
        {
            #region // check input
            if (listTre.Count == 0)
            {
                MessageBox.Show("Chưa chọn trẻ để hủy thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (buoiAD == "")
            {
                MessageBox.Show("Chưa chọn buổi để hủy thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (ngayAD == null)
            {
                MessageBox.Show("Chưa chọn ngày để hủy thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            #endregion
            for (int i = 0; i < listTre.Count; i++)
            {
                XoaThongTinThucDon(listTre[i], buoiAD, ngayAD);
            }

            MessageBox.Show("Đã hủy thực đơn cho " + listTre.Count + " trẻ", "Thông báo", MessageBoxButtons.OK);
            return true;
        }

        public static bool ThemThongTinThucDon(Entities.ThongTinThucDon thongTinTD)
        {
            return ThongTinThucDonDAL.ThemThongTinThucDon(thongTinTD);
        }

        public static void XoaThongTinThucDon(string maTre, string buoiAD, DateTime ngayAD)
        {
            ThongTinThucDonDAL.XoaThongTinThucDon(maTre, buoiAD, ngayAD);
        }
        public static void XoaThongTinThucDon(Entities.ThongTinThucDon thongTinTD)
        {
            ThongTinThucDonDAL.XoaThongTinThucDon(thongTinTD);
        }

        public static DataTable LayDanhSachTreChuaXetThucDon(string maLop, int thang, int nam, string buoiAD, DateTime ngayAD)
        {
           
            return ThongTinThucDonDAL.LayDanhSachTreChuaXetThucDon(maLop, thang, nam, buoiAD, ngayAD);
            
        }

        public static DataTable LayDanhSachTreDaXetThucDon(string maLop, int thang, int nam, string buoiAD, DateTime ngayAD)
        {
            return ThongTinThucDonDAL.LayDanhSachTreDaXetThucDon(maLop, thang, nam, buoiAD, ngayAD);
        }

        public static DataTable LayThongTinThucDonTheoTre(string maTre, string buoiAD, DateTime ngayAD)
        {
            return ThongTinThucDonDAL.LayThongTinThucDonTheoTre(maTre, buoiAD, ngayAD);
        }

        public static DataTable LayDanhSachMonAnTheoBuoi(string buoiAD, DateTime ngayAD)
        {
            return ThongTinThucDonDAL.LayDanhSachMonAnTheoBuoi(buoiAD, ngayAD);
        }

        public static DataTable LayDanhSachMonAnTheoNgay(DateTime ngayAD)
        {
            return ThongTinThucDonDAL.LayDanhSachMonAnTheoNgay(ngayAD);
        }

        public static DataTable LayDanhSachNguyenLieuTheoBuoi(string buoiAD, DateTime ngayAD)
        {
            return ThongTinThucDonDAL.LayDanhSachNguyenLieuTheoBuoi(buoiAD, ngayAD);
        }

        public static DataTable LayDanhSachNguyenLieuTheoNgay(DateTime ngayAD)
        {
            return ThongTinThucDonDAL.LayDanhSachNguyenLieuTheoNgay(ngayAD);
        }

        public static void getListTre(List<string> listTre, DataGridView dgv, bool getAll)
        {
            listTre.Clear();
            if (getAll)
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    listTre.Add(dgv.Rows[i].Cells["MaTre"].Value.ToString().Trim());
                }
            }
            else
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    DataGridViewRow row = dgv.Rows[i];
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        listTre.Add(row.Cells["MaTre"].Value.ToString().Trim());
                    }
                }
            }
            
        }

        public static void getListMonAn(List <string> listMonAn, DataGridView dgv)
        {
            listMonAn.Clear();
            for (int i = 0; i < dgv.RowCount; i++)
            {
                listMonAn.Add(MonAnBLL.LayMaMonAnTheoTen(dgv.Rows[i].Cells["TenMonAn"].Value.ToString().Trim()));
            }
        }

        public static bool isCheckedAll(DataGridView dgv)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (!Convert.ToBoolean(dgv.Rows[i].Cells[0].Value))
                {
                    return false;
                }
            }
            return true;
        }

        public static void checkAllDataGridView(DataGridView dgv, bool value)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = value;
            }
        }

        public static string getTongNangLuong(DataGridView dgvMonAn)
        {
            double tongNL = 0;
            for (int i = 0; i < dgvMonAn.RowCount; i++)
            {
                if(dgvMonAn.Rows[i].Cells["NangLuong"].Value.ToString() == "") { continue; }
                tongNL += Convert.ToDouble(dgvMonAn.Rows[i].Cells["NangLuong"].Value.ToString());
            }
            return "Tổng năng lượng: " + tongNL;
        }

        public static bool xoaMonAnTrongBangMonAn(DataTable tableMonAn, string tenMonAn)
        {
            if (MonAnBLL.LayMaMonAnTheoTen(tenMonAn) == "")
            {
                MessageBox.Show("Món ăn đã nhập không tồn tại\nVui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tenMonAn == "")
            {
                MessageBox.Show("Chưa chọn món ăn để xóa", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tableMonAn.Rows.Find(tenMonAn) == null)
            {
                MessageBox.Show("Món ăn không tồn tại trong bảng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            DataRow row = tableMonAn.NewRow();
            row["TenMonAn"] = tenMonAn;
            row["NangLuong"] = MonAnBLL.LayNangLuongMonAnTheoTen(tenMonAn);
            tableMonAn.Rows.Remove(tableMonAn.Rows.Find(tenMonAn));

            return true;
        }

        public static bool themMonAnTrongBangMonAn(DataTable tableMonAn, string tenMonAn)
        {
            if (MonAnBLL.LayMaMonAnTheoTen(tenMonAn) == "")
            {
                MessageBox.Show("Món ăn đã nhập không tồn tại\nVui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (tableMonAn.Rows.Count >= 6)
            {
                MessageBox.Show("Không thể thêm món\nChỉ được chọn tối đa 6 món ăn cho một bữa ăn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (tableMonAn.Rows.Find(tenMonAn) != null)
            {
                MessageBox.Show("Món ăn đã tồn tại trong bảng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            
            DataRow row = tableMonAn.NewRow();
            row["TenMonAn"] = tenMonAn;
            row["NangLuong"] = MonAnBLL.LayNangLuongMonAnTheoTen(tenMonAn);
            tableMonAn.Rows.Add(row);

            return true;
        }

        public static bool kiemTraInBaoCao(string BuoiAD, DateTime NgayAD)
        {
            if(BuoiAD == "")
            {
                MessageBox.Show("Chưa chọn buổi để xuất báo cáo", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            
            if(NgayAD == null)
            {
                MessageBox.Show("Chưa chọn ngày để xuất báo cáo", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool kiemTraInBaoCao( string MaLop, string BuoiAD, DateTime NgayAD)
        {
            if(MaLop == "")
            {
                MessageBox.Show("Chưa chọn buổi để xuất báo cáo", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return kiemTraInBaoCao(BuoiAD, NgayAD);
        }
    }
}
