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
    class LopDAL
    {
        public static List<NamHoc> GetListNienKhoa()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetNamHoc");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<NamHoc> listNamHoc = new List<NamHoc>();
            foreach(DataRow row in db.dt.Rows)
            {
                listNamHoc.Add(new NamHoc(row));
            }
            return listNamHoc;
        } 

        public static List<LoaiLop> GetListLoaiLop()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLOAILOP");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<LoaiLop> listLoaiLop = new List<LoaiLop>();
            foreach (DataRow row in db.dt.Rows)
            {
                listLoaiLop.Add(new LoaiLop(row));
            }
            return listLoaiLop;
        }

        public static List<Lop> GetListLop(string maNamHoc, string maLoaiLop)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetListLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);
            cmd.Parameters.AddWithValue("@MaLoaiLop", maLoaiLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<Lop> listLop = new List<Lop>();
            foreach (DataRow row in db.dt.Rows)
            {
                listLop.Add(new Lop(row));
            }
            return listLop;
        }

        public static List<Lop> GetListLop(string maNamHoc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETLISTLOP_NAM");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<Lop> listLop = new List<Lop>();
            foreach (DataRow row in db.dt.Rows)
            {
                listLop.Add(new Lop(row));
            }
            return listLop;
        }

        public static DataTable GetInfoLop(string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetInfoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetInfoNamHoc(string maNamHoc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetInfoNamHoc");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable GetSucKhoeTheoLop(string maLop, int thang, int nam)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachSucKhoeTheoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static string getMaNamHoc(DateTime ngayHoc)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayMaNamHocTheoNgay");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ngay", ngayHoc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }
        
    }
}
