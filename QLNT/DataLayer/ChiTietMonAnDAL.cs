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
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("ThemNguyenLieuTungMon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", chiTietMonAn.MaMon);
            cmd.Parameters.AddWithValue("@MaNL", chiTietMonAn.MaNL);
            cmd.Parameters.AddWithValue("@SL", chiTietMonAn.SoLuong);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void CapNhatChiTietMonAn(ChiTietMonAn chiTietMonAn)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatNguyenLieuTungMon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", chiTietMonAn.MaMon);
            cmd.Parameters.AddWithValue("@MaNL", chiTietMonAn.MaNL);
            cmd.Parameters.AddWithValue("@SL", chiTietMonAn.SoLuong);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void XoaChiTietMonAn(string maMon, string maNL)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("XoaNguyenLieuTungMon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMon", maMon);
            cmd.Parameters.AddWithValue("@MaNL", maNL);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        //public static void XoaDanhSachChiTietPhieuMuaNL(string maPhieuMua)
        //{
        //    DataAccessHelper.GetInstance().Open();
        //    SqlCommand cmd = DataAccessHelper.GetInstance().Command("XOA_DANH_SACH_CHI_TIET_PHIEU_MUA");
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@MaPhieu", maPhieuMua);

        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataAccessHelper.GetInstance().SetDataTable(new DataTable());
        //    da.Fill(DataAccessHelper.GetInstance().GetDataTable());
        //}

        public static DataTable LayDanhSachChiTietMonAn(string maMon)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachNguyenLieuTheoMaMon");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaMonAn", maMon);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static bool KiemTraMaNL(string maMon, string maNL)
        {
            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("select * from CHITIET_MONAN where MaMonAn = '" + maMon + "' and MaNguyenLieu = '" + maNL + "'");

            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return true;
            }
            DataAccessHelper.GetInstance().Close();
            return false;
        }
    }
}
