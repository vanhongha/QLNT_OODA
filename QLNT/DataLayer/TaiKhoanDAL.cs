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
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("GETTHONGTINUSER");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }
    }
}
