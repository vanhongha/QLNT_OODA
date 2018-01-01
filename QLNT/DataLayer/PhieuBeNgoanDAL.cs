using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using System.Data.SqlClient;
using System.Data;

namespace QLNT.DataLayer
{
    class PhieuBeNgoanDAL
    {
        public static object TaoPhieuBeNgoanMoi(Lop lop, string datetime)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("TAO_PHIEU_BE_NGOAN_MOI");

            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@Thang", Int32.Parse(datetime.Split('/')[0]));
            cmd.Parameters.AddWithValue("@Nam", Int32.Parse(datetime.Split('/')[1]));


            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LuuPhieuBeNgoan(TheoDoiThang phieubengoan)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LUU_PHIEU_BE_NGOAN");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", phieubengoan.MaTre);
            cmd.Parameters.AddWithValue("@Thang", phieubengoan.Thang);
            cmd.Parameters.AddWithValue("@Nam", phieubengoan.Nam);
            cmd.Parameters.AddWithValue("@NhanXetThang", phieubengoan.NhanXetThang);
            cmd.Parameters.AddWithValue("@PhieuBeNgoanTuan1", phieubengoan.PhieuTuan1);
            cmd.Parameters.AddWithValue("@PhieuBeNgoanTuan2", phieubengoan.PhieuTuan2);
            cmd.Parameters.AddWithValue("@PhieuBeNgoanTuan3", phieubengoan.PhieuTuan3);
            cmd.Parameters.AddWithValue("@PhieuBeNgoanTuan4", phieubengoan.PhieuTuan4);
            cmd.Parameters.AddWithValue("@PhieuBeNgoanThang", phieubengoan.PhieuThang);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static void XoaPhieuBeNgoan(string value, string v1, string v2)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("XOA_PHIEU_BE_NGOAN");
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", value);
            cmd.Parameters.AddWithValue("@Thang", Int32.Parse(v1));
            cmd.Parameters.AddWithValue("@Nam", Int32.Parse(v2));

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static object LayPhieuBeNgoanTheoLop(Lop lop, string datetime)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = null;

            cmd = DataAccessHelper.GetInstance().Command("LAY_PHIEU_BE_NGOAN_LOP");
            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@Thang", Int32.Parse(datetime.Split('/')[0]));
            cmd.Parameters.AddWithValue("@Nam", Int32.Parse(datetime.Split('/')[1]));

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }
    }
}
