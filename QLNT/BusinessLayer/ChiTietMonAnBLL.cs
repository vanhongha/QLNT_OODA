using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNT.DataLayer;
using QLNT.Entities;
using System.Data;
using System.Windows.Forms;

namespace QLNT.BusinessLayer
{
    class ChiTietMonAnBLL
    {
        public static bool LuuChiTietMonAn(string maMonAn, string tenNguyenLieu, string soLuong)
        {
            string _maNL = NguyenLieuBLL.LayMaNguyenLieuTheoTen(tenNguyenLieu);
            if (maMonAn == "")
            {
                MessageBox.Show("Chưa chọn món ăn để cập nhật", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if(_maNL == "")
            {
                MessageBox.Show("Vui lòng chọn một nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if(soLuong == "")
            {
                MessageBox.Show("Khối lượng không được để trống", "Thông báo", MessageBoxButtons.OK);
                return false;
            }



            ChiTietMonAn chiTiet = new ChiTietMonAn(maMonAn, _maNL, double.Parse(soLuong));
            if (KiemTraMaNL(maMonAn,_maNL))
            {
                CapNhatChiTietMonAn(chiTiet);
            }else
            {
                ThemChiTietMonAn(chiTiet);
            }

            return true;
        }
        public static void ThemChiTietMonAn(ChiTietMonAn chiTietMonAn)
        {
            ChiTietMonAnDAL.ThemChiTietMonAn(chiTietMonAn);
        }

        public static void CapNhatChiTietMonAn(ChiTietMonAn chiTietMonAn)
        {
            ChiTietMonAnDAL.CapNhatChiTietMonAn(chiTietMonAn);
        }

        public static DataTable LayDanhSachChiTietMonAn(string maMon)
        {
            return ChiTietMonAnDAL.LayDanhSachChiTietMonAn(maMon);
        }

        public static void XoaChiTietMonAn(string maMon, string tenNL)
        {
            string maNL = NguyenLieuBLL.LayMaNguyenLieuTheoTen(tenNL);
            ChiTietMonAnDAL.XoaChiTietMonAn(maMon, maNL);
        }

        public static bool KiemTraMaNL(string maMon, string MaNL)
        {
            return ChiTietMonAnDAL.KiemTraMaNL(maMon, MaNL);
        }

        public static double TinhNangLuong(TextBox txtKhoiLuong, string tenNguyenLieu)
        {
            if(txtKhoiLuong.Text == "")
            {
                return 0;
            }

            string maNL = NguyenLieuBLL.LayMaNguyenLieuTheoTen(tenNguyenLieu);
            if (maNL == "")
            {
                MessageBox.Show("chưa chọn nguyên liệu \nvui lòng chọn một nguyên liệu trước", "Thông báo", MessageBoxButtons.OK);
                txtKhoiLuong.Text = "";
                return 0;
            }

            double _khoiLuong = 0;
            try
            {
                _khoiLuong = double.Parse(txtKhoiLuong.Text);
            }
            catch
            {
                MessageBox.Show("Khối lượng phải là số thực", "Lỗi nhập", MessageBoxButtons.OK);
                txtKhoiLuong.Text = "";
                return 0;
            }

            return NguyenLieuBLL.LayNangLuongNguyenLieuTheoMa(maNL)*_khoiLuong;
        }
    }
}
