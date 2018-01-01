using QLNT.Entities;
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
            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("Select top 1 MaLop from LOP order by MaLop desc");
            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }
        
        public static string GetLastLoaiLopID()
        {
            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("Select top 1 MaLoaiLop from LOAILOP order by MaLoaiLop desc");
            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static string GetLastIDNienKhoa()
        {
            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("Select top 1 MaNamHoc from NAMHOC order by MaNamHoc desc");
            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static List<NamHoc> GetListNienKhoa()
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetNamHoc");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            List<NamHoc> listNamHoc = new List<NamHoc>();
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                listNamHoc.Add(new NamHoc(row));
            }
            DataAccessHelper.GetInstance().Close();
            return listNamHoc;
        }

        public static List<LoaiLop> GetListLoaiLop()
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GETLOAILOP");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            List<LoaiLop> listLoaiLop = new List<LoaiLop>();
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                listLoaiLop.Add(new LoaiLop(row));
            }
            DataAccessHelper.GetInstance().Close();
            return listLoaiLop;
        }

        public static List<Lop> GetListLop(string maNamHoc, string maLoaiLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetListLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);
            cmd.Parameters.AddWithValue("@MaLoaiLop", maLoaiLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            List<Lop> listLop = new List<Lop>();
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                listLop.Add(new Lop(row));
            }
            DataAccessHelper.GetInstance().Close();
            return listLop;
        }

        public static List<Lop> GetListLop(string maNamHoc = null)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd;

            if(maNamHoc == null)
            {
                cmd = DataAccessHelper.GetInstance().Command("GetLop");
                cmd.CommandType = CommandType.StoredProcedure;
            }
            else
            {
                cmd = DataAccessHelper.GetInstance().Command("GETLISTLOP_NAM");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);
            }        

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            List<Lop> listLop = new List<Lop>();
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                listLop.Add(new Lop(row));
            }
            DataAccessHelper.GetInstance().Close();
            return listLop;
        }

        public static DataTable GetInfoLop(string maLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetInfoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable GetInfoNamHoc(string maNamHoc)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetInfoNamHoc");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", maNamHoc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static string getMaNamHoc(DateTime ngayHoc)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayMaNamHocTheoNgay");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ngay", ngayHoc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static int GetSiSo(string maLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetSiSoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return int.Parse(row.ItemArray[0].ToString());
            }
            DataAccessHelper.GetInstance().Close();
            return -1;
        }

        public static void CapNhatSiSo(string maLop, int siSo)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatSiSoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@SiSo", siSo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void CapNhatLop(string maLop, string tenLop, string maGV)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@TenLop", tenLop);
            cmd.Parameters.AddWithValue("@MaGV", maGV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void ThemLop(string maLop, string maLoaiLop, string maNamHoc, string maGV, string tenLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("THEMLOP");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@MaLoaiLop", maLoaiLop);
            cmd.Parameters.AddWithValue("@MaNienKhoa", maNamHoc);
            cmd.Parameters.AddWithValue("@MaGV", maGV);
            cmd.Parameters.AddWithValue("@SiSo", 0);
            cmd.Parameters.AddWithValue("@TenLop", tenLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void ThemLoaiLop(string maLoaiLop, string tenLoaiLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("ThemLoaiLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLoaiLop", maLoaiLop);
            cmd.Parameters.AddWithValue("@TenLoaiLop", tenLoaiLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void CapNhatLoaiLop(string maLoaiLop, string tenLoaiLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatLoaiLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLoaiLop", maLoaiLop);
            cmd.Parameters.AddWithValue("@TenLoaiLop", tenLoaiLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void CapNhatNienKhoa(string maNienKhoa, string tenNienKhoa)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatNienKhoa");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", maNienKhoa);
            cmd.Parameters.AddWithValue("@NamHoc", tenNienKhoa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void ThemNienKhoa(string maNienKhoa, string tenNienKhoa, DateTime tgBatDau, DateTime tgKetThuc)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("ThemNienKhoa");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNamHoc", maNienKhoa);
            cmd.Parameters.AddWithValue("@NamHoc", tenNienKhoa);
            cmd.Parameters.AddWithValue("@NgayBatDau", tgBatDau);
            cmd.Parameters.AddWithValue("@NgayKetThuc", tgKetThuc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }
    }
}