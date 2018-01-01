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
    class LoaiNguyenLieuDAL
    {
        public static DataTable layDanhSachLoaiNguyenLieu()
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachLoaiNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            //DataTable dt = db.GetDataTable("SELECT * FROM NGUYENLIEU");
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static string layMaLoaiNguyenLieuTheoTen(string tenLoaiNL)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayMaLoaiNguyenLieuTheoTen");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenLoaiNL", tenLoaiNL);
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
    }
}
