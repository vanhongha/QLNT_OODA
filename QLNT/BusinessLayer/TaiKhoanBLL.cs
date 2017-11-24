using QLNT.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.BusinessLayer
{
    class TaiKhoanBLL
    {
        public static string GetTenNguoiDung(string tenDangNhap)
        {
            foreach(DataRow row in TaiKhoanDAL.GetTenNguoiDung(tenDangNhap).Rows)
            {
                return row["TenHienThi"].ToString();
            }

            return "";
        }
    }
}
