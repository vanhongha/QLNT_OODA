using QLNT.DataLayer;
using QLNT.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.BusinessLayer
{
    class SucKhoeBLL
    {
        public static DataTable GetListSucKhoe(string maLop, int thang, string maNamHoc)
        {
            return SucKhoeDAL.GetListSucKhoe(maLop, thang, LopBLL.GetNamHoc(thang, maNamHoc));
        }

        public static double CalculateBMI(double canNang, double chieuCao)
        {
            double bmi = 0;
            if (canNang == 0 || chieuCao == 0)
                return bmi;
            bmi = canNang / Math.Pow(chieuCao / 100, 2);
            bmi = Math.Round(bmi, 2);
            return bmi;
        }

        public static string TinhTrangDuaTrenBMI(double bmi, string gioiTinh, DateTime ngaySinh)
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

        //return -1 khi thời gian cập nhật nhỏ hơn hiện tại
        //return 0 khi thời gian cập nhật bằng hiện tại
        //return 1 khi thời gian cập nhật lớn hơn hiện tại
        public static int CoTheCapNhatSucKhoe(int thang, string maNamHoc)
        {
            int nam = LopBLL.GetNamHoc(thang, maNamHoc);
            if (DateTime.Now.Year > nam)
            {
                return -1;
            }
            else if (DateTime.Now.Year < nam)
            {
                return 1;
            } else if (DateTime.Now.Month < thang)
            {
                return 1;
            } else if (DateTime.Now.Month > thang)
            {
                return -1;
            }
            return 0;
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

        public static List<SucKhoe> GetListSucKhoeTheoThang(string maTre, int tuThang, int denThang, string maNamHoc)
        {
            List<SucKhoe> listSucKhoe = new List<SucKhoe>();

            listSucKhoe.Add(SucKhoeDAL.GetSucKhoeTheoThang(maTre, tuThang, LopBLL.GetNamHoc(tuThang, maNamHoc)));
            while (tuThang != denThang)
            {
                tuThang++;
                if (tuThang > 12)
                    tuThang = 1;
                listSucKhoe.Add(SucKhoeDAL.GetSucKhoeTheoThang(maTre, tuThang, LopBLL.GetNamHoc(tuThang, maNamHoc)));
            }

            return listSucKhoe;
        }

        public static void KhoiTaoSucKhoe(string maTre, int thang, int nam)
        {
            SucKhoeDAL.KhoiTaoSucKhoe(maTre, thang, nam);
        }

        public static bool KiemTraTonTaiSucKhoe(string maTre, int thang, int nam)
        {
            DataTable dt = SucKhoeDAL.KiemTraTonTaiSucKhoe(maTre, thang, nam);
            foreach (DataRow row in dt.Rows)
            {
                return int.Parse(row[0].ToString()) == 1;
            }

            return false;
        }

    }
}
