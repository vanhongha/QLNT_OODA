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
        public static List<DanhMucChiPhi> GetListDanhMucChiPhi()
        {
            List<DanhMucChiPhi> list = new List<DanhMucChiPhi>();
            DataTable dt = DanhMucChiPhiDAL.GetListDanhMucChiPhi();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DanhMucChiPhi(row));
            }
            return list;
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

        public static DanhMucChiPhi GetInfoDanhMuc(string maDanhMuc)
        {
            DataTable dt = DanhMucChiPhiDAL.GetInfoDanhMuc(maDanhMuc);
            foreach (DataRow row in dt.Rows)
            {
                return new DanhMucChiPhi(row);
            }

            return new DanhMucChiPhi();
        }

        public static List<LoaiChiPhi> GetListLoaiChiPhi()
        {
            return DanhMucChiPhiDAL.GetListLoaiChiPhi();
        }

        public static string GetTenLoaiChiPhi(string maLoai)
        {
            return DanhMucChiPhiDAL.GetTenLoaiChiPhi(maLoai);
        }

        //Hàm kiểm tra xem danh mục chi phí này có đang được sử dụng hay không
        public static bool KiemTraSuDungDanhMucChiPhi(string maDanhMuc)
        {
            DataTable dt = DanhMucChiPhiDAL.KiemTraSuDungDanhMucChiPhi(maDanhMuc);
            foreach(DataRow row in dt.Rows)
            {
                return int.Parse(row[0].ToString()) == 1;
            }

            return false;
        }
    }
}
