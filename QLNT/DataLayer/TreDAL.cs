using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;
using System;

namespace QLNT.DataLayer
{
    class TreDAL
    {
        public static DataTable GetListTre(Lop lop = null, string keyWord = null, string gioiTinh = null)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = null;
            if (lop == null && string.IsNullOrEmpty(keyWord) && gioiTinh == null)
                cmd = DataAccessHelper.GetInstance().Command("GetTre");
            else if (lop == null && !string.IsNullOrEmpty(keyWord) && gioiTinh == null)
            {
                cmd = DataAccessHelper.GetInstance().Command("GETTRETHEOKEY");
                cmd.Parameters.AddWithValue("@key", keyWord);
            }
            else if (lop != null && string.IsNullOrEmpty(keyWord) && gioiTinh == null)
            {
                cmd = DataAccessHelper.GetInstance().Command("GETTRETHEOLOP");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            }
            else if (lop == null && string.IsNullOrEmpty(keyWord) && gioiTinh != null)
            {
                // Lọc theo giới tính
                cmd = DataAccessHelper.GetInstance().Command("GetTreTheoGioiTinh");
                cmd.Parameters.AddWithValue("@GioiTinh", Convert.ToInt32(gioiTinh));
            }
            else if(lop != null && string.IsNullOrEmpty(keyWord) && gioiTinh != null)
            {
                // Lọc theo giới tính và lớp
                cmd = DataAccessHelper.GetInstance().Command("GetTreTheoGioiTinh_Lop");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@GioiTinh", Convert.ToInt32(gioiTinh));
            }
            else if (lop == null && !string.IsNullOrEmpty(keyWord) && gioiTinh != null)
            {
                // Lọc theo giới tính và key
                cmd = DataAccessHelper.GetInstance().Command("GetTreTheoGioiTinh_Key");
                cmd.Parameters.AddWithValue("@key", keyWord);
                cmd.Parameters.AddWithValue("@GioiTinh", Convert.ToInt32(gioiTinh));
            }
            else if (lop != null && !string.IsNullOrEmpty(keyWord) && gioiTinh == null) // Lọc theo lớp và key
            {
                cmd = DataAccessHelper.GetInstance().Command("GETTRETHEOLOP_KEY");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@key", keyWord);
            }
            else
            {
                // Lọc cả 3 thằng
                cmd = DataAccessHelper.GetInstance().Command("GetTreAllFilter");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@key", keyWord);
                cmd.Parameters.AddWithValue("@GioiTinh", Convert.ToInt32(gioiTinh));
            }

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();

            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static Tre GetTre(string maTre)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetTreTheoMaTre");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return new Tre(row);
            }
            DataAccessHelper.GetInstance().Close();
            return null;
        }

        public static DataTable GetListTreChuaCoLop(int tuoiMin, int tuoiMax)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetListTreChuaCoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuoiMin", tuoiMin);
            cmd.Parameters.AddWithValue("@TuoiMax", tuoiMax);
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayThongTinTre(string maTre)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GETTHONGTINTRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();

            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static void XoaTre(string maTre)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("XOATRE");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void CapNhatThongTinTre(Tre tre)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("SUATTTRE");

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
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }       

        public static DataTable ThemTre(Tre tre)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("THEMTRE");

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
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static string GetLastID()
        {
            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("Select top 1 MaTre from TRE order by MaTre desc");
            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static string GetTinhTrangTrongLop(string maTre, string maLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetTinhTrangTrongLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "0";
        }
        
        public static DataTable GetListTreTheoMaLop(string maLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetListTreTheoLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static void XepLop(string maTre, string maLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("XepLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void ThoiHoc(string maTre, string maLop)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("ThoiHoc");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@MaLop", maLop);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }
        

        public static void ChuyenLop(string maTre, string maLopMoi)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("ChuyenLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@MaLopMoi", maLopMoi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void LenLop(string maTre, string maLopMoi)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LenLop");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@MaLop", maLopMoi);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static DataTable LayTongSoNgayDiHocTrongThang(string maTre, int thang, int nam)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayTongSoNgayDiHocTrongThang");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();

            return DataAccessHelper.GetInstance().GetDataTable();
        }
    }
}
