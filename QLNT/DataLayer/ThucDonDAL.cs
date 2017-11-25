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
    class ThucDonDAL
    {
        public static void ThemThucDon(ThucDon thucDon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemThucDon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaThucDon", thucDon.MaThucDon);
            cmd.Parameters.AddWithValue("@NguoiLap", thucDon.NguoiLap);
            cmd.Parameters.AddWithValue("@NgayLap", thucDon.NgayLap);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaThucDon(string maThucDon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XoaThucDon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
        
        public static DataTable LayDanhSachThucDon()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachThucDon");
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static bool KiemTraThucDonDaDuocApDung(string maThucDon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KiemTraTonTaiThucDonTrongApDungThucDon");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return true;
            }
            return false;
        }

        public static string LayMaCuoi()
        {

            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select top 1 MaThucDon from THUCDON order by MaThucDon desc");

            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }
    }
}
