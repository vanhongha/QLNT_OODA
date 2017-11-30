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
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = null;

            cmd = db.Command("TAO_PHIEU_BE_NGOAN_MOI");
            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@Thang", Int32.Parse(datetime.Split('/')[0]));
            cmd.Parameters.AddWithValue("@Nam", Int32.Parse(datetime.Split('/')[1]));


            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable LuuPhieuBeNgoan(TheoDoiThang phieubengoan)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LUU_PHIEU_BE_NGOAN");

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
            db.dt = new DataTable();
            da.Fill(db.dt);
            return db.dt;
        }

        public static void XoaPhieuBeNgoan(string value, string v1, string v2)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = null;

            cmd = db.Command("XOA_PHIEU_BE_NGOAN");
            cmd.Parameters.AddWithValue("@MaTre", value);
            cmd.Parameters.AddWithValue("@Thang", v1);
            cmd.Parameters.AddWithValue("@Nam", v2);

            cmd.CommandType = CommandType.StoredProcedure;

        }

        public static object LayPhieuBeNgoanTheoLop(Lop lop, string datetime)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = null;

            cmd = db.Command("LAY_PHIEU_BE_NGOAN_LOP");
            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@Thang", Int32.Parse(datetime.Split('/')[0]));
            cmd.Parameters.AddWithValue("@Nam", Int32.Parse(datetime.Split('/')[1]));

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }
    }
}
