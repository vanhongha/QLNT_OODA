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
            if (canNang == 0 || chieuCao == 0)
                return bmi;
            bmi = canNang / (float) Math.Pow(chieuCao / 100, 2);
            bmi = (float) Math.Round(bmi, 2);
            return bmi;
        }

        public static string TinhTrangDuaTrenBMI(float bmi, string gioiTinh, DateTime ngaySinh)
        {
            int namSinh = ngaySinh.Year;
            int tuoi = DateTime.Now.Year - namSinh;
            bool isGirl = gioiTinh.Trim() == "Nữ";
            if(isGirl) 
                switch(tuoi)
                {
                    case 3:
                        if (bmi >= 20.3)
                            return "Béo phì";
                        else if (bmi >= 18.4)
                            return "Thừa cân/Tiền béo phì";
                        else if (bmi >= 16.8)
                            return "Nguy cơ thừa cân cao";
                        else if (bmi >= 14.2)
                            return "Bình thường";
                        else
                            return "Suy dinh dưỡng";
                    case 4:
                        if (bmi >= 20.6)
                            return "Béo phì";
                        else if (bmi >= 18.5)
                            return "Thừa cân/Tiền béo phì";
                        else if (bmi >= 16.7)
                            return "Nguy cơ thừa cân cao";
                        else if (bmi >= 14)
                            return "Bình thường";
                        else
                            return "Suy dinh dưỡng";
                    case 5:
                        if (bmi >= 21.1)
                            return "Béo phì";
                        else if (bmi >= 18.8)
                            return "Thừa cân/Tiền béo phì";
                        else if (bmi >= 16.9)
                            return "Nguy cơ thừa cân cao";
                        else if (bmi >= 13.9)
                            return "Bình thường";
                        else
                            return "Suy dinh dưỡng";
                    default:
                        return "Binh thường";
                }
            else
                switch (tuoi)
                {
                    case 3:
                        if (bmi >= 20)
                            return "Béo phì";
                        else if (bmi >= 18.9)
                            return "Thừa cân/Tiền béo phì";
                        else if (bmi >= 16.9)
                            return "Nguy cơ thừa cân cao";
                        else if (bmi >= 14.4)
                            return "Bình thường";
                        else
                            return "Suy dinh dưỡng";
                    case 4:
                        if (bmi >= 19.9)
                            return "Béo phì";
                        else if (bmi >= 18.2)
                            return "Thừa cân/Tiền béo phì";
                        else if (bmi >= 16.7)
                            return "Nguy cơ thừa cân cao";
                        else if (bmi >= 14.1)
                            return "Bình thường";
                        else
                            return "Suy dinh dưỡng";
                    case 5:
                        if (bmi >= 21.3)
                            return "Béo phì";
                        else if (bmi >= 18.3)
                            return "Thừa cân/Tiền béo phì";
                        else if (bmi >= 16.6)
                            return "Nguy cơ thừa cân cao";
                        else if (bmi >= 14)
                            return "Bình thường";
                        else
                            return "Suy dinh dưỡng";
                    default:
                        return "Binh thường";
                }

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
