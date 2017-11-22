using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using QLNT.DataLayer;

namespace QLNT.BusinessLayer
{
    class DiemDanhBLL
    {
        public static object LaySoDiemDanhLop(Lop lop, string ngaydiemdanh)
        {
            return DiemDanhDAL.LaySoDiemDanhLop(lop, ngaydiemdanh);
        }
    }
}
