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
            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("Select top 1 MaPhieu from PHIEUTIEPNHANTRE order by MaPhieu desc");
            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static DataTable ThemPhieu(PhieuTiepNhanTre phieumoi)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("THEM_PHIEU_TIEP_NHAN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", phieumoi.MaTre);
            cmd.Parameters.AddWithValue("@MaPhieu", phieumoi.MaPhieu);
            cmd.Parameters.AddWithValue("@NgayTiepNhanTre", phieumoi.NgayTiepNhan);
            cmd.Parameters.AddWithValue("@NguoiTiepNhan", phieumoi.NguoiTiepNhan);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }
    }
}
