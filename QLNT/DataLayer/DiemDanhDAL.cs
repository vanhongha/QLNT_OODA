using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;

namespace QLNT.DataLayer
{
    class DiemDanhDAL
    {
        public static DataTable LaySoDiemDanhLop(Lop lop, string ngaydiemdanh)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = null;
            
                cmd = db.Command("LAY_SO_DIEM_DANH_LOP");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@NgayDiemDanh", ngaydiemdanh);


            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }
    }
}
