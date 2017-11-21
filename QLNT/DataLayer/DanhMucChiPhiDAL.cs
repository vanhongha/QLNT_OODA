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
    class DanhMucChiPhiDAL
    {
        public static DataTable GetListDanhMucChiPhi()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetListDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaDanhMuc from DANHMUCCHIPHI order by MaDanhMuc desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static void ThemDanhMucChiPhi(DanhMucChiPhi danhMuc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("ThemDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMuc", danhMuc.MaDanhMuc);
            cmd.Parameters.AddWithValue("@TenChiPhi", danhMuc.TenChiPhi);
            cmd.Parameters.AddWithValue("@MaLoaiChiPhi", danhMuc.MaLoaiChiPhi);
            cmd.Parameters.AddWithValue("@SoTien", danhMuc.SoTien);
            cmd.Parameters.AddWithValue("@TruTienKhiNghi", danhMuc.TruTienKhiNghi);
            cmd.Parameters.AddWithValue("@GhiChu", danhMuc.GhiChu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatDanhMucChiPhi(DanhMucChiPhi danhMuc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CapNhatDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMuc", danhMuc.MaDanhMuc);
            cmd.Parameters.AddWithValue("@TenChiPhi", danhMuc.TenChiPhi);
            cmd.Parameters.AddWithValue("@MaLoaiChiPhi", danhMuc.MaLoaiChiPhi);
            cmd.Parameters.AddWithValue("@SoTien", danhMuc.SoTien);
            cmd.Parameters.AddWithValue("@TruTienKhiNghi", danhMuc.TruTienKhiNghi);
            cmd.Parameters.AddWithValue("@GhiChu", danhMuc.GhiChu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void XoaDanhMucChiPhi(string maDanhMuc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XoaDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static List<LoaiChiPhi> GetListLoaiChiPhi()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetListLoaiChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<LoaiChiPhi> list = new List<LoaiChiPhi>();
            foreach(DataRow row in db.dt.Rows)
            {
                list.Add(new LoaiChiPhi(row));
            }

            return list;
        }

        public static string GetTenLoaiChiPhi(string maLoai)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetTenLoaiChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLoai", maLoai);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            foreach(DataRow row in db.dt.Rows)
            {
                return row["TenLoaiChiPhi"].ToString();
            }

            return "";
        }
    }
}
