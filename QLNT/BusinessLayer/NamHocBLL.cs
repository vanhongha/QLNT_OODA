using QLNT.DataLayer;
using System;
using System.Windows.Forms;

namespace QLNT.BusinessLayer
{
    class NamHocBLL
    {
        public static DateTime GetNgayBatDau(string maNam)
        {
            return NamHocDAL.GetNgayBatDau(maNam).Date;
        }

        public static DateTime GetNgayKetThuc(string maNam)
        {
            return NamHocDAL.GetNgayKetThuc(maNam).Date;
        }
    }
}
