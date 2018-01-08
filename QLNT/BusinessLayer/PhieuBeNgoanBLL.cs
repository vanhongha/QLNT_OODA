using System;
using QLNT.Entities;
using QLNT.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    class PhieuBeNgoanBLL
    {
        public static object TaoPhieuBeNgoanMoi(Lop lop, string datetime)
        {
            return PhieuBeNgoanDAL.TaoPhieuBeNgoanMoi(lop, datetime);
        }

        public static bool LuuPhieuBeNgoan(TheoDoiThang phieubengoan)
        {
            DataTable dt = PhieuBeNgoanDAL.LuuPhieuBeNgoan(phieubengoan);
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;
            }

            return false;
        }

        public static object LayPhieuBeNgoanTheoLop(Lop lop, string datetime)
        {
            return PhieuBeNgoanDAL.LayPhieuBeNgoanTheoLop(lop, datetime);
        }

        public static void XoaPhieuBeNgoan(string value, string v1, string v2)
        {
            PhieuBeNgoanDAL.XoaPhieuBeNgoan(value, v1, v2);
        }

        //public static bool KiemTraPhieuTuan(DataGridView dgvPhieuBeNgoan, int rowIndex, int columnIndex, string tenPhieu)
        //{
        //    try
        //    {
        //        if (!Convert.ToBoolean(dgvPhieuBeNgoan.Rows[rowIndex].Cells[tenPhieu].Value))
        //        {
        //            dgvPhieuBeNgoan.Rows[rowIndex].Cells["cbPhieuThang"].Value = false;
        //            return false;

        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}

        public static bool XetPhieuThang(DataGridView dgvPhieuBeNgoan, int rowIndex, int columnIndex)
        {
            try
            {
                if (!Convert.ToBoolean(dgvPhieuBeNgoan.Rows[rowIndex].Cells["cbPhieu1"].Value))
                {
                    return false;
                }

                if (!Convert.ToBoolean(dgvPhieuBeNgoan.Rows[rowIndex].Cells["cbPhieu2"].Value))
                {
                    return false;
                }

                if (!Convert.ToBoolean(dgvPhieuBeNgoan.Rows[rowIndex].Cells["cbPhieu3"].Value))
                {
                    return false;
                }

                if (!Convert.ToBoolean(dgvPhieuBeNgoan.Rows[rowIndex].Cells["cbPhieu4"].Value))
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}