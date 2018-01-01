using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;

namespace QLNT.DataLayer
{
    class SucKhoeDAL
    {
        public static DataTable GetListSucKhoe(string maLop, int thang, int nam)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetListSucKhoe");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static void CapNhatSucKhoe(SucKhoe sucKhoe)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatSucKhoe");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", sucKhoe.MaTre);
            cmd.Parameters.AddWithValue("@Thang", sucKhoe.Thang);
            cmd.Parameters.AddWithValue("@Nam", sucKhoe.Nam);
            cmd.Parameters.AddWithValue("@CanNang", sucKhoe.CanNang);
            cmd.Parameters.AddWithValue("@ChieuCao", sucKhoe.ChieuCao);
            cmd.Parameters.AddWithValue("@BMI", sucKhoe.BMI);
            cmd.Parameters.AddWithValue("@TinhTrang", sucKhoe.TinhTrang);
            cmd.Parameters.AddWithValue("@GhiChu", sucKhoe.GhiChu);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static SucKhoe GetSucKhoeTheoThang(string maTre, int thang, int nam)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GetSucKhoeTheoThang");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());

            foreach(DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return new SucKhoe(row);
            }
            DataAccessHelper.GetInstance().Close();
            return new SucKhoe();
        }

        public static DataTable KiemTraTonTaiSucKhoe(string maTre, int thang, int nam)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("KiemTraTonTaiSucKhoe");

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

        public static void KhoiTaoSucKhoe(string maTre, int thang, int nam)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("KhoiTaoSucKhoe");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }
    }
}
