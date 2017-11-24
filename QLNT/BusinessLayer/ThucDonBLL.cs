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
    class ThucDonBLL
    {
        public static void ThemThucDon(string maThucDon)
        {
            ThucDon thucDon = new ThucDon();
            thucDon.MaThucDon = maThucDon;
            thucDon.NguoiLap = "Nông Thị Lệ";
            thucDon.NgayLap = DateTime.Today;
            ThucDonDAL.ThemThucDon(thucDon);
        }

        public static void XoaThucDon(string maThucDon)
        {
            ThucDonDAL.XoaThucDon(maThucDon);
        }

        public static DataTable LayDanhSachThucDon()
        {
            return ThucDonDAL.LayDanhSachThucDon();
        }

        public static DataTable LayDanhSachMaThucDon()
        {
            return ThucDonDAL.LayDanhSachMaThucDon();
        }

        public static bool KiemTraThucDonDaDuocApDung(string maThucDon)
        {
            return ThucDonDAL.KiemTraThucDonDaDuocApDung(maThucDon);
        }

        public static string SinhMaTuDong()
        {
            string maCuoi = ThucDonDAL.LayMaCuoi().Trim();

            //chưa có phiếu mua nào trong CSDL
            if (maCuoi == "")
            {
                return "MATD000001";
            }

            //xoa 4 chữ cái đầu chuỗi và tăng số đếm lên 1
            int maTiepTheo = int.Parse(maCuoi.Remove(0, 4)) + 1;
            string maTuDong = maTiepTheo.ToString().Trim();

            while (maTuDong.Length < 6)
            {
                maTuDong = "0" + maTuDong;
                maTuDong.Trim();
            }

            return "MATD" + maTuDong;
        }
    }
}
