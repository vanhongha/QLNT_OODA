using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNT.DataLayer;
using QLNT.Entities;

namespace QLNT.BusinessLayer
{
    class PhieuTiepNhanBLL
    {
        public static string GenMaPhieu()
        {
            string id = PhieuTiepNhanDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MPTN000001";
            }
            int nextID = int.Parse(id.Remove(0, "MPTN".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MPTN" + id;
        }

        public static bool ThemPhieu(PhieuTiepNhanTre phieumoi)
        {
            DataTable dt = PhieuTiepNhanDAL.ThemPhieu(phieumoi);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }

            return false;
        }
    }
}
