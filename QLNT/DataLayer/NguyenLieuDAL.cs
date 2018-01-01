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
    class NguyenLieuDAL
    {
        public static void ThemNguyenLieu(NguyenLieu nguyenLieu)
        {
            try
            {
                DataAccessHelper.GetInstance().Open();
                SqlCommand cmd = DataAccessHelper.GetInstance().Command("ThemNguyenLieu");

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNguyenLieu);
                cmd.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNguyenLieu);
                cmd.Parameters.AddWithValue("@MaLoaiNL", nguyenLieu.MaLoai);
                cmd.Parameters.AddWithValue("@NangLuong", nguyenLieu.NangLuong);
                cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataAccessHelper.GetInstance().SetDataTable(new DataTable());
                da.Fill(DataAccessHelper.GetInstance().GetDataTable());
                DataAccessHelper.GetInstance().Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Phát sinh lỗi khi lưu nguyên liệu, vui lòng kiểm tra nguyên liệu và thử lại", "Thông báo", MessageBoxButtons.OK);
            }
            
        }
        public static void XoaNguyenLieu(string maNL)
        {
            try
            { 
                DataAccessHelper.GetInstance().Open();
                SqlCommand cmd = DataAccessHelper.GetInstance().Command("XoaNguyenLieu");

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", maNL);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataAccessHelper.GetInstance().SetDataTable(new DataTable());
                da.Fill(DataAccessHelper.GetInstance().GetDataTable());
                DataAccessHelper.GetInstance().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể xóa nguyên liệu đã được sử dụng trong món ăn");
            }
}

        public static void CapNhatNguyenLieu(NguyenLieu nguyenLieu)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("CapNhatNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNguyenLieu);
            cmd.Parameters.AddWithValue("@MaLoaiNL", nguyenLieu.MaLoai);
            cmd.Parameters.AddWithValue("@NangLuong", nguyenLieu.NangLuong);
            cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
        }

        public static DataTable LayDanhSachNguyenLieu()
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachThongTinNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayDanhSachNguyenLieu(string tuKhoa)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("TimKiemNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static string LayMaNguyenLieuTheoTen(string tenNL)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayMaNguyenLieuTheoTen");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNL", tenNL);
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

        
        public static string LayMaCuoi()
        {
            DataAccessHelper.GetInstance().Open();
            DataTable dt = DataAccessHelper.GetInstance().GetDataTable("select top 1 MaNguyenLieu from NGUYENLIEU order by MaNguyenLieu desc");

            foreach (DataRow row in dt.Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return row.ItemArray[0].ToString();
            }
            DataAccessHelper.GetInstance().Close();
            return "";
        }

        public static bool KiemTraTenNL(string tenNL)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("KiemTraTonTaiTenNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNL", tenNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return true;
            }
            DataAccessHelper.GetInstance().Close();
            return false;
            
        }

        public static bool KiemTraMaNL(string maNL)
        {

            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("KiemTraTonTaiMaNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", maNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return true;
            }
            DataAccessHelper.GetInstance().Close();
            return false;
        }

        public static bool KiemTraTonTaiMaNguyenLieuTrongMonAn(string maNL)
        {

            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("KiemTraTonTaiMaNguyenLieuTrongMonAn");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", maNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return true;
            }
            DataAccessHelper.GetInstance().Close();
            return false;
        }

        public static DataTable LayDanhSachTenVaMaNguyenLieu()
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachTenVaMaNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static double LayNangLuongNguyenLieuTheoMa(string maNL)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayNangLuongNguyenLieuTheoMa");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNguyenLieu", maNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            foreach (DataRow row in DataAccessHelper.GetInstance().GetDataTable().Rows)
            {
                DataAccessHelper.GetInstance().Close();
                return double.Parse(row.ItemArray[0].ToString());
            }
            DataAccessHelper.GetInstance().Close();
            return 0;
        }
    }
}
