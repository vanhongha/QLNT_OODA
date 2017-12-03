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
    class LopBLL
    {
        public static List<NamHoc> GetListNienKhoa()
        {
            return LopDAL.GetListNienKhoa();
        }

        public static List<LoaiLop> GetListLoaiLop()
        {
            return LopDAL.GetListLoaiLop();
        }

        public static List<Lop> GetListLop(string maNamHoc, string maLoaiLop)
        {
            return LopDAL.GetListLop(maNamHoc, maLoaiLop);
        }

        public static List<Lop> GetListLop(string maNamHoc)
        {
            return LopDAL.GetListLop(maNamHoc);
        }

        public static Lop GetInfoLop(string maLop)
        {
            DataTable dt = LopDAL.GetInfoLop(maLop);
            foreach (DataRow row in dt.Rows)
            {
                return new Lop(row);
            }
            return new Lop();
        }

        public static NamHoc GetInfoNamHoc(string maNamHoc)
        {
            DataTable dt = LopDAL.GetInfoNamHoc(maNamHoc);
            foreach(DataRow row in dt.Rows)
            {
                return new NamHoc(row);
            }
            return new NamHoc();
        }

        public static DataTable GetSucKhoeTheoLop(string maLop, int thang, int nam)
        {
            return LopDAL.GetSucKhoeTheoLop(maLop, thang, nam);
        }

        public static int GetNamHoc(int thang, string maNamHoc)
        {
            NamHoc namHoc = LopBLL.GetInfoNamHoc(maNamHoc);
            int nam = 0;
            if (thang < namHoc.NgayBatDau.Month)
                nam = namHoc.NgayKetThuc.Year;
            else
                nam = namHoc.NgayBatDau.Year;
            return nam;
        }

        public static string getMaNamHoc(DateTime ngayHoc)
        {
            return LopDAL.getMaNamHoc(ngayHoc);
        }
    }
}
