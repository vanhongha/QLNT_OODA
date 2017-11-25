using System;
using QLNT.Entities;
using QLNT.DataLayer;
using System.Data;

namespace QLNT.Presentation
{
    class PhieuBeNgoanBLL
    {
        public static object TaoPhieuBeNgoanMoi(Lop lop, string datetime)
        {
            return PhieuBeNgoanDAL.TaoPhieuBeNgoanMoi(lop, datetime);
        }

        public static bool LuuPhieuBeNgoan(TheoDoiThang phieubengoan)
        {
            DataTable dt = PhieuBeNgoanDAL.LuuPhieuBeNgoan(phieubengoan);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }

            return false;
        }

        public static object LayPhieuBeNgoanTheoLop(Lop lop, string datetime)
        {
            return PhieuBeNgoanDAL.LayPhieuBeNgoanTheoLop(lop, datetime);
        }
    }
}