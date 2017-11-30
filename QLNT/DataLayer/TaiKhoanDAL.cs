using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.DataLayer
{
    class TaiKhoanDAL
    {
        public static DataTable GetTenNguoiDung(string tenDangNhap)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("GETTHONGTINUSER");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }
    }
}
