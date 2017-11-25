using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNT.DataLayer
{
    class ChiTietMonAnDAL
    {
        public static void ThemChiTietMonAn(ChiTietMonAn chiTietMonAn)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemNguyenLieuTungMon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", chiTietMonAn.MaMon);
            cmd.Parameters.AddWithValue("@MaNL", chiTietMonAn.MaNL);
            cmd.Parameters.AddWithValue("@SL", chiTietMonAn.SoLuong);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatChiTietMonAn(ChiTietMonAn chiTietMonAn)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CapNhatNguyenLieuTungMon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", chiTietMonAn.MaMon);
            cmd.Parameters.AddWithValue("@MaNL", chiTietMonAn.MaNL);
            cmd.Parameters.AddWithValue("@SL", chiTietMonAn.SoLuong);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaChiTietMonAn(string maMon, string maNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XoaNguyenLieuTungMon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMon", maMon);
            cmd.Parameters.AddWithValue("@MaNL", maNL);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        //public static void XoaDanhSachChiTietPhieuMuaNL(string maPhieuMua)
        //{
        //    DataAccessHelper db = new DataAccessHelper();
        //    SqlCommand cmd = db.Command("XOA_DANH_SACH_CHI_TIET_PHIEU_MUA");
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@MaPhieu", maPhieuMua);

        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    db.dt = new DataTable();
        //    da.Fill(db.dt);
        //}

        public static DataTable LayDanhSachChiTietMonAn(string maMon)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachNguyenLieuTheoMaMon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", maMon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static bool KiemTraMaNL(string maMon, string maNL)
        {

            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select * from CHITIET_MONAN where MaMonAn = '" + maMon + "' and MaNguyenLieu = '" + maNL + "'");

            foreach (DataRow row in dt.Rows)
            {
                return true;
            }
            return false;
        }
    }
}
