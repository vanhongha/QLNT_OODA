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
    class MonAnDAL
    {
        public static void ThemMonAn(MonAn monAn)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("ThemMonAn");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", monAn.MaMonAn);
            cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void XoaMonAn(string maMon)
        {
            try
            {
                DataAccessHelper.GetInstance().Open();
                SqlCommand cmd = DataAccessHelper.GetInstance().Command("XoaMonAn");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaMonAn", maMon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataAccessHelper.GetInstance().SetDataTable(new DataTable());
                da.Fill(DataAccessHelper.GetInstance().GetDataTable());
                DataAccessHelper.GetInstance().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể xóa món ăn đã áp dụng vào thực đơn");
            }

        }

        public static void CapNhatMonAn(MonAn monAn)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatMonAn");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", monAn.MaMonAn);
            cmd.Parameters.AddWithValue("@TenMonAn", monAn.TenMonAn);
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static string LayMaMonAnTheoTen(string tenMonAn)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayMaMonAnTheoTen");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
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

        public static string LayNangLuongMonAnTheoTen(string tenMonAn)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayNangLuongMonAnTheoTen");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
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

        public static DataTable LayDanhSachMonAn()
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachMonAn");
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static string LayMaCuoi()
        {

            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("select top 1 MaMonAn from MONAN order by MaMonAn desc");

            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static bool KiemTraMonAn(string maMonAn)
        {

            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("select * from MONAN where MaMonAn = '" + maMonAn.Trim() + "'");

            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return true;
            }
            DataAccessHelper.GetInstance().Close();
            return false;
        }

        public static bool KiemTraMonAnTrongThucDon(string maMonAn)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("KiemTraTonTaiMonAnTrongThucDon");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMonAn", maMonAn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return true;
            }
            DataAccessHelper.GetInstance().Close();
            return false;
        }
    }
}
