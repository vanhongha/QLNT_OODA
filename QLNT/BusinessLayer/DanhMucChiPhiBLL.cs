using QLNT.DataLayer;
using QLNT.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.BusinessLayer
{
    class DanhMucChiPhiBLL
    {
        public static DataTable GetListDanhMucChiPhi()
        {
            return DanhMucChiPhiDAL.GetListDanhMucChiPhi();
        }

        public static string GenerateMaDanhMuc()
        {
            string id = DanhMucChiPhiDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MADM000001";
            }
            int nextID = int.Parse(id.Remove(0, "MADM".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MADM" + id;
        }

        public static void ThemDanhMucChiPhi(DanhMucChiPhi danhMuc)
        {
            DanhMucChiPhiDAL.ThemDanhMucChiPhi(danhMuc);
        }

        public static void CapNhatDanhMucChiPhi(DanhMucChiPhi danhMuc)
        {
            DanhMucChiPhiDAL.CapNhatDanhMucChiPhi(danhMuc);
        }

        public static void XoaDanhMucChiPhi(string maDanhMuc)
        {
            DanhMucChiPhiDAL.XoaDanhMucChiPhi(maDanhMuc);
        }

        public static List<LoaiChiPhi> GetListLoaiChiPhi()
        {
            return DanhMucChiPhiDAL.GetListLoaiChiPhi();
        }

        public static string GetTenLoaiChiPhi(string maLoai)
        {
            return DanhMucChiPhiDAL.GetTenLoaiChiPhi(maLoai);
        }
    }
}
