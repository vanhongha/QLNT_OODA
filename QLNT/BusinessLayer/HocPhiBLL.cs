using QLNT.BusinessLayer;
using QLNT.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class HocPhiBLL
    {
        public static List<HocPhi> GetListHocPhiTheoThang(string maLop, int thang, int nam)
        {
            DataTable dt = HocPhiDAL.GetListHocPhiTheoThang(maLop, thang, nam);
            List<HocPhi> list = new List<HocPhi>(); 
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HocPhi(row));
            }

            return list;
        }

        public static List<ChiTietHocPhi> GetChiTietHocPhi(string maHocPhi)
        {
            List<ChiTietHocPhi> list = new List<ChiTietHocPhi>();
            DataTable dt = HocPhiDAL.GetChiTietHocPhi(maHocPhi);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ChiTietHocPhi(row));
            }
            return list;
        }

        public static void CapNhatHocPhi(HocPhi hocPhi, List<ChiTietHocPhi> listChiTiet)
        {
            int soNgayDiHoc = TreBLL.GetSoNgayDiHocTrongThang(hocPhi.MaTre, hocPhi.Thang, hocPhi.Nam);
            //Xoa tat ca cac chi tiet hoc phi hien co
            foreach (ChiTietHocPhi chiTiet in GetChiTietHocPhi(hocPhi.MaHocPhi))
            {
                HocPhiDAL.XoaChiTietHocPhi(chiTiet);
            }

            //Luu cac chi tiet hoc phi vua moi cap nhat
            foreach(ChiTietHocPhi chiTiet in listChiTiet)
            {
                DanhMucChiPhi danhMuc = DanhMucChiPhiBLL.GetInfoDanhMuc(chiTiet.MaDanhMuc);
                ChiTietHocPhi chiTietHocPhi = (ChiTietHocPhi)chiTiet.Clone();
                //cap nhat lai so tien trong list neu danh muc chi phi nay tinh tien theo so ngay di hoc
                chiTietHocPhi.SoTien = danhMuc.TruTienKhiNghi == 1 ? chiTiet.SoTien * soNgayDiHoc : chiTietHocPhi.SoTien;
                chiTietHocPhi.MaHocPhi = hocPhi.MaHocPhi;
                HocPhiDAL.ThemChiTietHocPhi(chiTietHocPhi);
            }

            //luu hoc phi
            HocPhiDAL.CapNhatHocPhi(hocPhi);
        }

        public static void ThemHocPhi(HocPhi hocPhi)
        {
            HocPhiDAL.ThemHocPhi(hocPhi);
        }

        public static string GenerateMaHocPhi()
        {
            string id = HocPhiDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MAHP000001";
            }
            int nextID = int.Parse(id.Remove(0, "MAHP".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MAHP" + id;
        }

        public static decimal TinhTongTien(string maTre, int thang, int nam, List<ChiTietHocPhi> list)
        {
            decimal tong = 0;
            int soNgayDiHoc = TreBLL.GetSoNgayDiHocTrongThang(maTre, thang, nam);
            foreach(ChiTietHocPhi chiTiet in list)
            {
                DanhMucChiPhi danhMuc = DanhMucChiPhiBLL.GetInfoDanhMuc(chiTiet.MaDanhMuc);

                //cap nhat lai so tien trong list neu danh muc chi phi nay tinh tien theo so ngay di hoc
                tong += danhMuc.TruTienKhiNghi == 1 ? chiTiet.SoTien * soNgayDiHoc : chiTiet.SoTien;
            }

            thang = thang - 1;
            if(thang == 0)
            {
                thang = 12;
                nam -= 1;
            }

            return tong + GetTienNoThang(maTre, thang, nam);
        }

        public static decimal GetTienNoThang(string maTre, int thang, int nam)
        {
            DataTable dt = HocPhiDAL.GetTienNoThang(maTre, thang, nam);
            foreach(DataRow row in dt.Rows)
            {
                return decimal.Parse(row["TienConNo"].ToString());
            }

            return 0;
        }
    }
}
