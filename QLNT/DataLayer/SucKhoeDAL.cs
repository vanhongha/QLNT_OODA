using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;

namespace QLNT.DataLayer
{
    class SucKhoeDAL
    {
        public static DataTable GetListSucKhoe(string maLop, int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetListSucKhoe");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void CapNhatSucKhoe(SucKhoe sucKhoe)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CapNhatSucKhoe");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", sucKhoe.MaTre);
            cmd.Parameters.AddWithValue("@Thang", sucKhoe.Thang);
            cmd.Parameters.AddWithValue("@Nam", sucKhoe.Nam);
            cmd.Parameters.AddWithValue("@CanNang", sucKhoe.CanNang);
            cmd.Parameters.AddWithValue("@ChieuCao", sucKhoe.ChieuCao);
            cmd.Parameters.AddWithValue("@BMI", sucKhoe.BMI);
            cmd.Parameters.AddWithValue("@TinhTrang", sucKhoe.TinhTrang);
            cmd.Parameters.AddWithValue("@GhiChu", sucKhoe.GhiChu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static SucKhoe GetSucKhoeTheoThang(string maTre, int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetSucKhoeTheoThang");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach(DataRow row in db.dt.Rows)
            {
                return new SucKhoe(row);
            }

            return null;
        }

        public static DataTable KiemTraTonTaiSucKhoe(string maTre, int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KiemTraTonTaiSucKhoe");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void KhoiTaoSucKhoe(string maTre, int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KhoiTaoSucKhoe");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
