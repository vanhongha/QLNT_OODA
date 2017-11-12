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
        public static List<NamHoc> GetListNamHoc()
        {
            return LopDAL.GetListNamHoc();
        }

        public static List<LoaiLop> GetListLoaiLop()
        {
            return LopDAL.GetListLoaiLop();
        }

        public static List<Lop> GetListLop(string maNamHoc, string maLoaiLop)
        {
            return LopDAL.GetListLop(maNamHoc, maLoaiLop);
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
    }
}
