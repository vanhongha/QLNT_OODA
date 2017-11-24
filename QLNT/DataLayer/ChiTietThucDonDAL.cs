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
            SqlCommand cmd = db.Command("THEM_CHI_TIET_THUC_DON");
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
            SqlCommand cmd = db.Command("XOA_CHI_TIET_THUC_DON");
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
            SqlCommand cmd = db.Command("LAY_DANH_SACH_CHI_TIET_THUC_DON_THEO_MA");
            
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
            SqlCommand cmd = db.Command("LAY_DANH_SACH_TEN_VA_MA_MON_AN");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static DataTable LayDanhSachMaMonAnTheoThucDon(string maThucDon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_MA_MON_AN_TRONG_THUC_DON");

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
            SqlCommand cmd = db.Command("KIEM_TRA_TON_TAI_MON_AN_TRONG_THUC_DON");

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
