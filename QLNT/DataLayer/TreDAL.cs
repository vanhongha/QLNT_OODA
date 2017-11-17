using QLNT.Entities;
using System.Data;
using System.Data.SqlClient;

namespace QLNT.DataLayer
{
    class TreDAL
    {
        public static DataTable GetListTre(Lop lop = null, string keyWord = null)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = null;
            if (lop == null && string.IsNullOrEmpty(keyWord))
                cmd = db.Command("GETTRE");
            else if (lop == null && !string.IsNullOrEmpty(keyWord))
            {
                cmd = db.Command("GETTRETHEOKEY");
                cmd.Parameters.AddWithValue("@key", keyWord);
            }
            else if (lop != null && string.IsNullOrEmpty(keyWord))
            {
                cmd = db.Command("GETTRETHEOLOP");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            }
            else
            {
                cmd = db.Command("GETTRETHEOLOP_KEY");
                cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
                cmd.Parameters.AddWithValue("@key", keyWord);
            }

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }
    }
}
