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
        public static void ThemThongTinThucDon(ThongTinThucDon thongTinTD)
        {
            try
            {
                DataAccessHelper db = new DataAccessHelper();
                SqlCommand cmd = db.Command("ThemThongTinThucDon");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTre", thongTinTD.MaTre);
                cmd.Parameters.AddWithValue("@BuoiApDung", thongTinTD.BuoiApDung);
                cmd.Parameters.AddWithValue("@NgayApDung", thongTinTD.NgayApDung);
                cmd.Parameters.AddWithValue("@MonApDung", thongTinTD.MonApDung);
                cmd.Parameters.AddWithValue("@LoaiApDung", thongTinTD.LoaiApDung);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                db.dt = new DataTable();
                da.Fill(db.dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Phát sinh lỗi khi thêm thông thực đơn, vui lòng kiểm tra thông tin và thử lại", "Thông báo", MessageBoxButtons.OK);
            }

        }

        public static void XoaThongTinThucDon(ThongTinThucDon thongTinTD)
        {
            try
            {
                DataAccessHelper db = new DataAccessHelper();
                SqlCommand cmd = db.Command("XoaThongTinThucDon");
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTre", thongTinTD.MaTre);
                cmd.Parameters.AddWithValue("@BuoiApDung", thongTinTD.BuoiApDung);
                cmd.Parameters.AddWithValue("@NgayApDung", thongTinTD.NgayApDung);
                cmd.Parameters.AddWithValue("@MonApDung", thongTinTD.MonApDung);
                cmd.Parameters.AddWithValue("@LoaiApDung", thongTinTD.LoaiApDung);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                db.dt = new DataTable();
                da.Fill(db.dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Phát sinh lỗi khi thêm thông thực đơn, vui lòng kiểm tra thông tin và thử lại", "Thông báo", MessageBoxButtons.OK);
            }

        }

    }
}
