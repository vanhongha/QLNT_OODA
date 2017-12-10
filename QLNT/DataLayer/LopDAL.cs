﻿using QLNT.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.DataLayer
{
    class LopDAL
    {
        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaLop from LOP order by MaLop desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static List<NamHoc> GetListNienKhoa()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetNamHoc");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            List<NamHoc> listNamHoc = new List<NamHoc>();
            foreach (DataRow row in db.dt.Rows)
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

        public static List<Lop> GetListLop(string maNamHoc = null)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd;

            if(maNamHoc == null)
            {
                cmd = db.Command("GetLop");
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd = db.Command("GETLISTLOP_NAM");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);
            }        

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

        public static int GetSiSo(string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetSiSoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return int.Parse(row.ItemArray[0].ToString());
            }
            return -1;
        }

        public static void CapNhatSiSo(string maLop, int siSo)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CapNhatSiSoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@SiSo", siSo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatLop(string maLop, string tenLop, string maGV)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CapNhatLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@TenLop", tenLop);
            cmd.Parameters.AddWithValue("@MaGV", maGV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void ThemLop(string maLop, string maLoaiLop, string maNamHoc, string maGV, string tenLop)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMLOP");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@MaLoaiLop", maLoaiLop);
            cmd.Parameters.AddWithValue("@MaNienKhoa", maNamHoc);
            cmd.Parameters.AddWithValue("@MaGV", maGV);
            cmd.Parameters.AddWithValue("@SiSo", 0);
            cmd.Parameters.AddWithValue("@TenLop", tenLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}