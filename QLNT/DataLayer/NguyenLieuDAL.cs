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
                DataAccessHelper db = new DataAccessHelper();
                SqlCommand cmd = db.Command("ThemNguyenLieu");

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNguyenLieu);
                cmd.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNguyenLieu);
                cmd.Parameters.AddWithValue("@MaLoaiNL", nguyenLieu.MaLoai);
                cmd.Parameters.AddWithValue("@NangLuong", nguyenLieu.NangLuong);
                cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                db.dt = new DataTable();
                da.Fill(db.dt);
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
                DataAccessHelper db = new DataAccessHelper();
                SqlCommand cmd = db.Command("XoaNguyenLieu");

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", maNL);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                db.dt = new DataTable();
                da.Fill(db.dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể xóa nguyên liệu đã được sử dụng trong món ăn");
            }
}

        public static void CapNhatNguyenLieu(NguyenLieu nguyenLieu)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CapNhatNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNguyenLieu);
            cmd.Parameters.AddWithValue("@MaLoaiNL", nguyenLieu.MaLoai);
            cmd.Parameters.AddWithValue("@NangLuong", nguyenLieu.NangLuong);
            cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable LayDanhSachNguyenLieu()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachThongTinNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable LayDanhSachNguyenLieu(string tuKhoa)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("TimKiemNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static string LayMaNguyenLieuTheoTen(string tenNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayMaNguyenLieuTheoTen");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNL", tenNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        
        public static string LayMaCuoi()
        {

            DataAccessHelper db = new DataAccessHelper();
            DataTable dt = db.GetDataTable("select top 1 MaNguyenLieu from NGUYENLIEU order by MaNguyenLieu desc");

            foreach (DataRow row in dt.Rows)
            {
                return row.ItemArray[0].ToString();
            }
            return "";
        }

        public static bool KiemTraTenNL(string tenNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KiemTraTonTaiTenNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNL", tenNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return true;
            }
            return false;
            
        }

        public static bool KiemTraMaNL(string maNL)
        {

            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KiemTraTonTaiMaNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", maNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return true;
            }
            return false;
        }

        public static bool KiemTraTonTaiMaNguyenLieuTrongMonAn(string maNL)
        {

            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KiemTraTonTaiMaNguyenLieuTrongMonAn");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", maNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return true;
            }
            return false;
        }

        public static DataTable LayDanhSachTenVaMaNguyenLieu()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayDanhSachTenVaMaNguyenLieu");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static double LayNangLuongNguyenLieuTheoMa(string maNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LayNangLuongNguyenLieuTheoMa");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNguyenLieu", maNL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);
            foreach (DataRow row in db.dt.Rows)
            {
                return double.Parse(row.ItemArray[0].ToString());
            }
            return 0;

        }
    }
}
