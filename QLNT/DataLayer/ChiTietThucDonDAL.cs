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
    class ChiTietThucDonDAL
    {
        public static void ThemChiTietThucDon(string maThucDon, string maMonAn)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemChiTietThucDon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
            cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaChiTietThucDon(string maThucDon, string maMonAn)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XoaChiTietThucDon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
            cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable LayDanhSachChiTietThucDon(string maThucDon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachChiTietThucDonTheoMa");
            
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static DataTable LayDanhSachTenVaMaMonAn()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachTenVaMaMonAn");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static DataTable LayDanhSachMaMonAnTheoThucDon(string maThucDon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachMaMonAnTrongThucDon");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static bool KiemTraMonAnTrongThucDon(string maThucDon, string maMonAn)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KiemTraTonTaiMonAnTrongThucDon");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaThucDon", maThucDon);
            cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return true;
            }
            return false;
        }
    }
}
