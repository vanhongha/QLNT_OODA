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
            return SucKhoeDAL.GetListSucKhoe(maLop, thang, LopBLL.GetNamHoc(thang, maNamHoc));
        }

        public static float CalculateBMI(float canNang, float chieuCao)
        {
            float bmi = 0;
            bmi = canNang / (float) Math.Pow(chieuCao / 100, 2);
            bmi = (float) Math.Round(bmi, 2);
            return bmi;
        }

        public static bool CapNhatSucKhoe(SucKhoe sucKhoe)
        {
            try
            {
                SucKhoeDAL.CapNhatSucKhoe(sucKhoe);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
