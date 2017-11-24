using System;
using QLNT.Entities;
using QLNT.DataLayer;

namespace QLNT.Presentation
{
    class PhieuBeNgoanBLL
    {
        public static object TaoPhieuBeNgoanMoi(Lop lop)
        {
            return PhieuBeNgoanDAL.TaoPhieuBeNgoanMoi(lop);
        }
    }
}