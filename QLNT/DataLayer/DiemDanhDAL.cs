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
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LAY_SO_DIEM_DANH_LOP"); ;
           
            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@NgayDiemDanh", ngaydiemdanh);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        

        public static object TaoBangDiemDanhMoi(Lop lop, string ngaydiemdanh)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("TAO_BANG_DIEM_DANH_MOI");

            cmd.Parameters.AddWithValue("@MaLop", lop.MaLop);
            cmd.Parameters.AddWithValue("@Ngay", ngaydiemdanh.Split('/')[0]);
            cmd.Parameters.AddWithValue("@Thang", ngaydiemdanh.Split('/')[1]);
            cmd.Parameters.AddWithValue("@Nam", ngaydiemdanh.Split('/')[2]);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static void XoaBangDiemDanh(string matre, string day, string month, string year)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("XOA_BANG_DIEM_DANH");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", matre);
            cmd.Parameters.AddWithValue("@Ngay", Int32.Parse(day));
            cmd.Parameters.AddWithValue("@Thang", Int32.Parse(month));
            cmd.Parameters.AddWithValue("@Nam", Int32.Parse(year));

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static DataTable LuuBangDiemDanh(TheoDoiNgay bangdiemdanh)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LUU_BANG_DIEM_DANH");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", bangdiemdanh.MaTre);
            cmd.Parameters.AddWithValue("@NgayDiemDanh", bangdiemdanh.NgayDiemDanh);
            cmd.Parameters.AddWithValue("@HienDien", bangdiemdanh.HienDien);
            cmd.Parameters.AddWithValue("@NhanXet", bangdiemdanh.NhanXet);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }
    }
}
