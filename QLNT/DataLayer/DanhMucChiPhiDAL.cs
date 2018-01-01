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
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetListDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static string GetLastID()
        {
            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("Select top 1 MaDanhMuc from DANHMUCCHIPHI order by MaDanhMuc desc");
            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static void ThemDanhMucChiPhi(DanhMucChiPhi danhMuc)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("ThemDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMuc", danhMuc.MaDanhMuc);
            cmd.Parameters.AddWithValue("@TenChiPhi", danhMuc.TenChiPhi);
            cmd.Parameters.AddWithValue("@MaLoaiChiPhi", danhMuc.MaLoaiChiPhi);
            cmd.Parameters.AddWithValue("@SoTien", danhMuc.SoTien);
            cmd.Parameters.AddWithValue("@TinhTheoSoNgayDiHoc", danhMuc.TinhTheoSoNgayDiHoc);
            cmd.Parameters.AddWithValue("@GhiChu", danhMuc.GhiChu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void CapNhatDanhMucChiPhi(DanhMucChiPhi danhMuc)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMuc", danhMuc.MaDanhMuc);
            cmd.Parameters.AddWithValue("@TenChiPhi", danhMuc.TenChiPhi);
            cmd.Parameters.AddWithValue("@MaLoaiChiPhi", danhMuc.MaLoaiChiPhi);
            cmd.Parameters.AddWithValue("@SoTien", danhMuc.SoTien);
            cmd.Parameters.AddWithValue("@TinhTheoSoNgayDiHoc", danhMuc.TinhTheoSoNgayDiHoc);
            cmd.Parameters.AddWithValue("@GhiChu", danhMuc.GhiChu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static void XoaDanhMucChiPhi(string maDanhMuc)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("XoaDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static DataTable GetInfoDanhMuc(string maDanhMuc)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetInfoDanhMuc");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static List<LoaiChiPhi> GetListLoaiChiPhi()
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetListLoaiChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            List<LoaiChiPhi> list = new List<LoaiChiPhi>();
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                list.Add(new LoaiChiPhi(row));
            }

            DataAccessHelper.GetInstance().Close();
            return list;
        }

        public static string GetTenLoaiChiPhi(string maLoai)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetTenLoaiChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLoai", maLoai);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row["TenLoaiChiPhi"].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static DataTable KiemTraSuDungDanhMucChiPhi(string maDanhMuc)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("KiemTraSuDungDanhMucChiPhi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", maDanhMuc);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }
    }
}
