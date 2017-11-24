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
                SqlCommand cmd = db.Command("THEM_NGUYEN_LIEU");

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNguyenLieu);
                cmd.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNguyenLieu);
                cmd.Parameters.AddWithValue("@MaLoaiNL", nguyenLieu.MaLoai);
                cmd.Parameters.AddWithValue("@ChiSoDD", nguyenLieu.ChiSoDinhDuong);
                cmd.Parameters.AddWithValue("@SoLuongTon", nguyenLieu.SoLuongTon);
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
                SqlCommand cmd = db.Command("XOA_NGUYEN_LIEU");

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
            SqlCommand cmd = db.Command("CAP_NHAT_NGUYEN_LIEU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNL", nguyenLieu.MaNguyenLieu);
            cmd.Parameters.AddWithValue("@TenNL", nguyenLieu.TenNguyenLieu);
            cmd.Parameters.AddWithValue("@MaLoaiNL", nguyenLieu.MaLoai);
            cmd.Parameters.AddWithValue("@ChiSoDD", nguyenLieu.ChiSoDinhDuong);
            cmd.Parameters.AddWithValue("@SoLuongTon", nguyenLieu.SoLuongTon);
            cmd.Parameters.AddWithValue("@DonViTinh", nguyenLieu.DonViTinh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static void CapNhatTonNguyenLieuTheoMa(string maNguyenLieu, int soLuongDung)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("CAP_NHAT_SO_LUONG_NGUYEN_LIEU_THEO_MA");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
            cmd.Parameters.AddWithValue("@SoLuongDung", soLuongDung);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            db.dt = new DataTable();
            da.Fill(db.dt);
        }

        public static DataTable LayDanhSachNguyenLieu()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_THONG_TIN_NGUYEN_LIEU");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable LayDanhSachNguyenLieu(string tuKhoa)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("TIM_KIEM_NGUYEN_LIEU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static DataTable LayDanhSachTenVaMaNguyenLieu()
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DANH_SACH_TEN_VA_MA_NGUYEN_LIEU");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            db.dt = new DataTable();
            da.Fill(db.dt);

            return db.dt;
        }

        public static string LayMaNguyenLieuTheoTen(string tenNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_MA_NGUYEN_LIEU_THEO_TEN");

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
        public static string LayDonViTinhTheoTen(string tenNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_DON_VI_TINH_THEO_TEN");

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
        public static string LayCSDDTheoTen(string tenNL)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_CSDD_THEO_TEN");

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

        public static string LaySoLuongTonTheoMaNguyenLieu(string maNguyenLieu)
        {
            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("LAY_SO_LUONG_NGUYEN_LIEU_TON_TU_MA_NGUYEN_LIEU");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNguyenLieu", maNguyenLieu);
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
            SqlCommand cmd = db.Command("KIEM_TRA_TON_TAI_TEN_NGUYEN_LIEU");

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
            SqlCommand cmd = db.Command("KIEM_TRA_TON_TAI_MA_NGUYEN_LIEU");

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

        public static bool CoTrongChiTietPhieuMua(string maNL)
        {

            DataAccessHelper db = new DataAccessHelper();
            SqlCommand cmd = db.Command("KIEM_TRA_TON_TAI_MA_NGUYEN_LIEU_TRONG_CTPM");

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
    }
}
