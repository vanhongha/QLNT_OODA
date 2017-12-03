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
    class ChiTietThucDonBLL
    {
        public static void ThemChiTietThucDon(string maThucDon, string maMonAn)
        {
            if (maThucDon == "")
            {
                MessageBox.Show("Chưa chọn thực đơn để cập nhật,\nNhấp chọn 1 thực đơn trong bảng THỰC ĐƠN", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //if (ThucDonBLL.KiemTraThucDonDaDuocApDung(maThucDon))
            //{
            //    MessageBox.Show("Không thể cập nhật chi tiết của thực đơn đã được áp dụng", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}

            if (maMonAn == "")
            {
                MessageBox.Show("Chưa chọn món ăn để thêm vào, Vui lòng chọn một món ăn", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (ChiTietThucDonBLL.KiemTraMonAnTrongThucDon(maThucDon, maMonAn))
            {
                MessageBox.Show("Món ăn này đã có trong thực đơn, Vui lòng chọn món khác để thêm", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            ChiTietThucDonDAL.ThemChiTietThucDon(maThucDon, maMonAn);
        }

        public static void XoaChiTietThucDon(string maThucDon, string maMonAn)
        {
            if (maThucDon == "")
            {
                MessageBox.Show("Chưa chọn thực đơn để xóa chi tiết,\nNhấp chọn 1 thực đơn trong bảng THỰC ĐƠN", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            //if (ThucDonBLL.KiemTraThucDonDaDuocApDung(maThucDon))
            //{
            //    MessageBox.Show("Không thể xóa chi tiết của thực đơn đã được áp dụng", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}

            if (maMonAn == "")
            {
                MessageBox.Show("Chưa chọn món ăn để xóa, Vui lòng chọn một món ăn", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            ChiTietThucDonDAL.XoaChiTietThucDon(maThucDon, maMonAn);
        }

        public static DataTable LayDanhSachChiTietThucDon(string maThucDon)
        {
            return ChiTietThucDonDAL.LayDanhSachChiTietThucDon(maThucDon);
        }

        public static DataTable LayDanhSachTenVaMaMonAn()
        {
            return ChiTietThucDonDAL.LayDanhSachTenVaMaMonAn();
        }

        public static DataTable LayDanhSachMaMonAnTheoThucDon(string maThucDon)
        {
            return ChiTietThucDonDAL.LayDanhSachMaMonAnTheoThucDon(maThucDon);
        }

        public static bool KiemTraMonAnTrongThucDon(string maThucDon, string maMonAn)
        {
            return ChiTietThucDonDAL.KiemTraMonAnTrongThucDon(maThucDon, maMonAn);
        }
    }
}
