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
    class SucKhoeBLL
    {
        public static DataTable GetListSucKhoe(string maLop, int thang, string maNamHoc)
        {
            NamHoc namHoc = LopBLL.GetInfoNamHoc(maNamHoc);
            int nam = 0;
            if (thang < namHoc.NgayBatDau.Month)
                nam = namHoc.NgayKetThuc.Year;
            else
                nam = namHoc.NgayBatDau.Year;
            
            return SucKhoeDAL.GetListSucKhoe(maLop, thang, nam);
        }
    }
}
