using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DataLayer;
using QLNT.Entities;
using System.Data;

namespace QLNT.BusinessLayer
{
    class ChiTietThucDonBLL
    {
        public static void ThemChiTietThucDon(string maThucDon, string maMonAn)
        {
            ChiTietThucDonDAL.ThemChiTietThucDon(maThucDon, maMonAn);
        }

        public static void XoaChiTietThucDon(string maThucDon, string maMonAn)
        {
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
