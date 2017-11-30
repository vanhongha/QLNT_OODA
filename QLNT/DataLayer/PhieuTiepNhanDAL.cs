using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;

namespace QLNT.DataLayer
{
    class PhieuTiepNhanDAL
    {
        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaPhieu from PHIEUTIEPNHANTRE order by MaPhieu desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static DataTable ThemPhieu(PhieuTiepNhanTre phieumoi)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEM_PHIEU_TIEP_NHAN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", phieumoi.MaTre);
            cmd.Parameters.AddWithValue("@MaPhieu", phieumoi.MaPhieu);
            cmd.Parameters.AddWithValue("@NgayTiepNhanTre", phieumoi.NgayTiepNhan);
            cmd.Parameters.AddWithValue("@NguoiTiepNhan", phieumoi.NguoiTiepNhan);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }
    }
}
