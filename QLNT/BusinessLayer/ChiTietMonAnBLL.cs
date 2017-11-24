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
    class ChiTietMonAnBLL
    {
        public static void LuuChiTietMonAn(string maMonAn, string tenNguyenLieu, int soLuong)
        {
            string _maNL = NguyenLieuBLL.LayMaNguyenLieuTheoTen(tenNguyenLieu);
            if (maMonAn == "")
            {
                MessageBox.Show("Chưa chọn món ăn để cập nhật", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(_maNL == "")
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if(soLuong == 0)
            {
                MessageBox.Show("Số lượng không thể bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            ChiTietMonAn chiTiet = new ChiTietMonAn(maMonAn, _maNL, soLuong);
            if (KiemTraMaNL(maMonAn,_maNL))
            {
                CapNhatChiTietMonAn(chiTiet);
            }else
            {
                ThemChiTietMonAn(chiTiet);
            }
        }
        public static void ThemChiTietMonAn(ChiTietMonAn chiTietMonAn)
        {
            ChiTietMonAnDAL.ThemChiTietMonAn(chiTietMonAn);
        }

        public static void CapNhatChiTietMonAn(ChiTietMonAn chiTietMonAn)
        {
            ChiTietMonAnDAL.CapNhatChiTietMonAn(chiTietMonAn);
        }

        public static DataTable LayDanhSachChiTietMonAn(string maMon)
        {
            return ChiTietMonAnDAL.LayDanhSachChiTietMonAn(maMon);
        }

        public static void XoaChiTietMonAn(string maMon, string tenNL)
        {
            string maNL = NguyenLieuBLL.LayMaNguyenLieuTheoTen(tenNL);
            ChiTietMonAnDAL.XoaChiTietMonAn(maMon, maNL);
        }

        public static bool KiemTraMaNL(string maMon, string MaNL)
        {
            return ChiTietMonAnDAL.KiemTraMaNL(maMon, MaNL);
        }
    }
}
