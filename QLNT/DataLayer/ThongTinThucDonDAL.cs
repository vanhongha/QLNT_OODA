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
    class ThongTinThucDonDAL
    {
        public static bool ThemThongTinThucDon(Entities.ThongTinThucDon thongTinTD)
        {
            try
            {
                DataAccessHelper.GetInstance().Open();
                SqlCommand cmd = DataAccessHelper.GetInstance().Command("ThemThongTinThucDon");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTre", thongTinTD.MaTre);
                cmd.Parameters.AddWithValue("@BuoiApDung", thongTinTD.BuoiApDung);
                cmd.Parameters.AddWithValue("@NgayApDung", thongTinTD.NgayApDung);
                cmd.Parameters.AddWithValue("@MonApDung", thongTinTD.MonApDung);
                cmd.Parameters.AddWithValue("@LoaiApDung", thongTinTD.LoaiApDung);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataAccessHelper.GetInstance().SetDataTable(new DataTable());
                da.Fill(DataAccessHelper.GetInstance().GetDataTable());
                DataAccessHelper.GetInstance().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Phát sinh lỗi khi thêm thông thực đơn, vui lòng kiểm tra thông tin và thử lại" + e.Message, "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        public static void XoaThongTinThucDon(string maTre, string buoiAD, DateTime ngayAD)
        {
            try
            {
                DataAccessHelper.GetInstance().Open();
                SqlCommand cmd = DataAccessHelper.GetInstance().Command("XoaThongTinThucDonTheoTre");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTre", maTre);
                cmd.Parameters.AddWithValue("@BuoiApDung", buoiAD);
                cmd.Parameters.AddWithValue("@NgayApDung", ngayAD);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataAccessHelper.GetInstance().SetDataTable(new DataTable());
                da.Fill(DataAccessHelper.GetInstance().GetDataTable());
                DataAccessHelper.GetInstance().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Phát sinh lỗi khi xoá thông thực đơn, vui lòng kiểm tra thông tin và thử lại", "Thông báo", MessageBoxButtons.OK);
            }

        }

        public static void XoaThongTinThucDon(Entities.ThongTinThucDon thongTinTD)
        {
            try
            {
                DataAccessHelper.GetInstance().Open();
                SqlCommand cmd = DataAccessHelper.GetInstance().Command("XoaThongTinThucDon");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTre", thongTinTD.MaTre);
                cmd.Parameters.AddWithValue("@BuoiApDung", thongTinTD.BuoiApDung);
                cmd.Parameters.AddWithValue("@NgayApDung", thongTinTD.NgayApDung);
                cmd.Parameters.AddWithValue("@MonApDung", thongTinTD.MonApDung);
                cmd.Parameters.AddWithValue("@LoaiApDung", thongTinTD.LoaiApDung);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataAccessHelper.GetInstance().SetDataTable(new DataTable());
                da.Fill(DataAccessHelper.GetInstance().GetDataTable());
                DataAccessHelper.GetInstance().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Phát sinh lỗi khi thêm thông thực đơn, vui lòng kiểm tra thông tin và thử lại", "Thông báo", MessageBoxButtons.OK);
            }

        }

        public static DataTable LayDanhSachTreChuaXetThucDon(string maLop, int thang, int nam, string buoiAD, DateTime ngayAD)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachTreChuaXetThucDon");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);
            cmd.Parameters.AddWithValue("@BuoiApDung", buoiAD);
            cmd.Parameters.AddWithValue("@NgayApDung", ngayAD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayDanhSachTreDaXetThucDon(string maLop, int thang, int nam, string buoiAD, DateTime ngayAD)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachTreDaXetThucDon");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaLop", maLop);
            cmd.Parameters.AddWithValue("@Thang", thang);
            cmd.Parameters.AddWithValue("@Nam", nam);
            cmd.Parameters.AddWithValue("@BuoiApDung", buoiAD);
            cmd.Parameters.AddWithValue("@NgayApDung", ngayAD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayThongTinThucDonTheoTre(string maTre, string buoiAD, DateTime ngayAD)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayThongTinThucDonTheoTre");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTre", maTre);;
            cmd.Parameters.AddWithValue("@BuoiApDung", buoiAD);
            cmd.Parameters.AddWithValue("@NgayApDung", ngayAD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayDanhSachMonAnTheoBuoi(string buoiAD, DateTime ngayAD)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachMonAnTheoBuoi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BuoiApDung", buoiAD);
            cmd.Parameters.AddWithValue("@NgayApDung", ngayAD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayDanhSachMonAnTheoNgay(DateTime ngayAD)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("S");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NgayApDung", ngayAD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayDanhSachNguyenLieuTheoBuoi(string buoiAD, DateTime ngayAD)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachNguyenLieuTheoBuoi");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BuoiApDung", buoiAD);
            cmd.Parameters.AddWithValue("@NgayApDung", ngayAD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayDanhSachNguyenLieuTheoNgay(DateTime ngayAD)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachNguyenLieuTheoNgay");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NgayApDung", ngayAD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayDanhSachTenVaMaMonAn()
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("LayDanhSachTenVaMaMonAn");

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

        public static DataTable LayDanhSachTenVaMaMonAn(string tuKhoa)
        {
            DataAccessHelper.GetInstance().Open();
            SqlCommand cmd = DataAccessHelper.GetInstance().Command("TimKiemMonAnTheoTen");

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataAccessHelper.GetInstance().SetDataTable(new DataTable());
            da.Fill(DataAccessHelper.GetInstance().GetDataTable());
            DataAccessHelper.GetInstance().Close();
            return DataAccessHelper.GetInstance().GetDataTable();
        }

    }
}
