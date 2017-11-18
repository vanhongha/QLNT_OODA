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
    }
}
