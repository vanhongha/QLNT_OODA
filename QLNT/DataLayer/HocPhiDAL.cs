using QLNT.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.DataLayer
{
    class HocPhiDAL
    {
        public static DataTable GetListHocPhiTheoThang(string maLop, int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetListHocPhiTheoThang");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetChiTietHocPhi(string maHocPhi)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetChiTietHocPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocPhi", maHocPhi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void CapNhatHocPhi(HocPhi hocPhi)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CapNhatHocPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocPhi", hocPhi.MaHocPhi);
            cmd.Parameters.AddWithValue("@HocPhiThangNay", hocPhi.HocPhiThangNay);
            cmd.Parameters.AddWithValue("@TienNoThangTruoc", hocPhi.TienNoThangTruoc);
            cmd.Parameters.AddWithValue("@TongTienHocPhi", hocPhi.TongTienHocPhi);
            cmd.Parameters.AddWithValue("@SoTienDaDong", hocPhi.SoTienDaDong);
            cmd.Parameters.AddWithValue("@SoTienConNo", hocPhi.SoTienConNo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

        }

        public static void ThemHocPhi(HocPhi hocPhi)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemHocPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocPhi", hocPhi.MaHocPhi);
            cmd.Parameters.AddWithValue("@MaTre", hocPhi.MaTre);
            cmd.Parameters.AddWithValue("@Thang", hocPhi.Thang);
            cmd.Parameters.AddWithValue("@Nam", hocPhi.Nam);
            cmd.Parameters.AddWithValue("@HocPhiThangNay", hocPhi.HocPhiThangNay);
            cmd.Parameters.AddWithValue("@TienNoThangTruoc", hocPhi.TienNoThangTruoc);
            cmd.Parameters.AddWithValue("@TongTienHocPhi", hocPhi.TongTienHocPhi);
            cmd.Parameters.AddWithValue("@SoTienDaDong", hocPhi.SoTienDaDong);
            cmd.Parameters.AddWithValue("@SoTienConNo", hocPhi.SoTienConNo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable LaySoTienConNoCuaThang(int thang, int nam, string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LaySoTienConNoCuaThang");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaHocPhi from HOCPHI order by MaHocPhi desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void XoaChiTietHocPhi(ChiTietHocPhi chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XoaChiTietHocPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocPhi", chiTiet.MaHocPhi);
            cmd.Parameters.AddWithValue("@MaDanhMuc", chiTiet.MaDanhMuc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void ThemChiTietHocPhi(ChiTietHocPhi chiTiet)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemChiTietHocPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocPhi", chiTiet.MaHocPhi);
            cmd.Parameters.AddWithValue("@MaDanhMuc", chiTiet.MaDanhMuc);
            cmd.Parameters.AddWithValue("@SoTien", chiTiet.SoTien);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable GetInfoHocPhi(string maHocPhi)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetInfoHocPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHocPhi", maHocPhi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable LayDanhSachBienLaiTheoThang(string maTre, int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachBienLaiTheoThang");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void ThemBienLai(BienLaiThuHocPhi bienLai)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemBienLai");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBienLai", bienLai.MaBienLai);
            cmd.Parameters.AddWithValue("@MaTre", bienLai.MaTre);
            cmd.Parameters.AddWithValue("@NguoiDong", bienLai.NguoiDong);
            cmd.Parameters.AddWithValue("@NguoiThu", bienLai.NguoiThu);
            cmd.Parameters.AddWithValue("@NgayThu", bienLai.NgayThu);
            cmd.Parameters.AddWithValue("@SoTienThu", bienLai.SoTienThu);
            cmd.Parameters.AddWithValue("@SoTienConNo", bienLai.SoTienConNo);
            cmd.Parameters.AddWithValue("@GhiChu", bienLai.GhiChu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaBienLai(string maBienLai)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XoaBienLai");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBienLai", maBienLai);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable GetInfoBienLai(string maBienLai)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetInfoBienLai");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaBienLai", maBienLai);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static string GetLastBienLaiID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaBienLai from BIENLAITHUHOCPHI order by MaBienLai desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }
    }
}
