using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using QLNT.DataLayer;
using System.Data;

namespace QLNT.BusinessLayer
{
    class DiemDanhBLL
    {
        public static object LaySoDiemDanhLop(Lop lop, string ngaydiemdanh)
        {
            return DiemDanhDAL.LaySoDiemDanhLop(lop, ngaydiemdanh);
        }

        public static bool LuuBangDiemDanh(TheoDoiNgay bangdiemdanh)
        {
            DataTable dt = DiemDanhDAL.LuuBangDiemDanh(bangdiemdanh);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }

            return false;
        }

        public static object TaoBangDiemDanhMoi(Lop lop, string ngaydiemdanh)
        {
            return DiemDanhDAL.TaoBangDiemDanhMoi(lop, ngaydiemdanh);
        }

        public static void XoaBangDiemDanh(string matre, string day, string month, string year)
        {
            DiemDanhDAL.XoaBangDiemDanh(matre, day, month, year);
        }
    }
}
