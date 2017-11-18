﻿using QLNT.DataLayer;
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
    class TreBLL
    {
        public static DataTable GetListTre(Lop lop = null, string keyWord = null)
        {
            return TreDAL.GetListTre(lop, keyWord);
        }


        public static DataTable GetListTreChuaCoLop()
        {
            return TreDAL.GetListTreChuaCoLop();
        }
        public static string GenMaTre()
        {
            string id = TreDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MTRE000001";
            }
            int nextID = int.Parse(id.Remove(0, "MTRE".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MTRE" + id;
        }

        public static bool ThemTre(Tre hocsinhmoi)
        {
            DataTable dt = TreDAL.ThemTre(hocsinhmoi);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }

            return false;
        }

        public static DataTable LayThongTinTre(string maTre)
        {
            return TreDAL.LayThongTinTre(maTre);
        }

        public static void CapNhatThongTinTre(Tre tre)
        {
            TreDAL.CapNhatThongTinTre(tre);
        }

        public static void XoaTre(string maTre)
        {
            TreDAL.XoaTre(maTre);
        }

        public static DataTable GetListTreTheoMaLop(string maLop)
        {
            return TreDAL.GetListTreTheoMaLop(maLop);
        }
    }
}
