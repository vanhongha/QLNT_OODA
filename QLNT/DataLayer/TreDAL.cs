﻿using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;
using System;

namespace QLNT.DataLayer
{
    class TreDAL
    {
        public static DataTable GetListTre(Lop lop = null, string keyWord = null)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = null;
            if (lop == null && string.IsNullOrEmpty(keyWord))
                cmd = db.Command("GETTRE");
            else if (lop == null && !string.IsNullOrEmpty(keyWord))
            {
                cmd = db.Command("GETTRETHEOKEY");
                cmd.Parameters.AddWithValue("@key", keyWord);
            }
            else if (lop != null && string.IsNullOrEmpty(keyWord))
            {
                cmd = db.Command("GETTRETHEOLOP");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            }
            else
            {
                cmd = db.Command("GETTRETHEOLOP_KEY");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@key", keyWord);
            }

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }


        public static DataTable GetListTreChuaCoLop()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = null;
            cmd = db.Command("GetListTreChuaCoLop");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static DataTable LayThongTinTre(string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTHONGTINTRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void XoaTre(string maTre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XOATRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatThongTinTre(Tre tre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("SUATTTRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", tre.MaTre);
            cmd.Parameters.AddWithValue("@TenTre", tre.HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", tre.GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", tre.NgaySinh);
            cmd.Parameters.AddWithValue("@TenBo", tre.TenCha);
            cmd.Parameters.AddWithValue("@TenMe", tre.TenMe);
            cmd.Parameters.AddWithValue("@DiaChi", tre.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", tre.DienThoai);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);            
        }       

        public static DataTable ThemTre(Tre tre)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("THEMTRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", tre.MaTre);
            cmd.Parameters.AddWithValue("@TenTre", tre.HoTen);
            cmd.Parameters.AddWithValue("@GioiTinh", tre.GioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", tre.NgaySinh);
            cmd.Parameters.AddWithValue("@TenBo", tre.TenCha);
            cmd.Parameters.AddWithValue("@TenMe", tre.TenMe);
            cmd.Parameters.AddWithValue("@DiaChi", tre.DiaChi);
            cmd.Parameters.AddWithValue("@DienThoai", tre.DienThoai);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static string GetLastID()
        {
            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("Select top 1 MaTre from TRE order by MaTre desc");
            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static DataTable GetListTreTheoMaLop(string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GetListTreTheoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static void XepLop(string maTre, string maLop)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("XepLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
        }
    }
}
