using QLNT.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class HocPhiBLL
    {
        public static List<HocPhi> GetListHocPhiTheoThang(string maLop, int thang, int nam)
        {
            DataTable dt = HocPhiDAL.GetListHocPhiTheoThang(maLop, thang, nam);
            List<HocPhi> list = new List<HocPhi>(); 
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HocPhi(row));
            }

            return list;
        }

        public static DataTable GetChiTietHocPhi(string maHocPhi)
        {
            return HocPhiDAL.GetChiTietHocPhi(maHocPhi);
        }
    }
}
