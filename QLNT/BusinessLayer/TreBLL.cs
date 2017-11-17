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
    class TreBLL
    {
        public static DataTable GetListTre(Lop lop = null, string keyWord = null)
        {
            return TreDAL.GetListTre(lop, keyWord);
        }
    }
}
