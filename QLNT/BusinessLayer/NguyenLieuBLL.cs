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
    class NguyenLieuBLL
    {
        public static void LuuNguyenLieu(string maNL, string tenNL, string tenLoaiNL, string chiSoDD,string soLuongTon, string donViTinh)
        {
            string _maNL = LayMaNguyenLieuTheoTen(tenNL);
            string _maLNL = LoaiNguyenLieuBLL.layMaLoaiNguyenLieuTheoTen(tenLoaiNL);
            if(_maLNL == "")
            {
                MessageBox.Show("Vui lòng chọn loại nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (_maNL != "")
            {   
                if(_maNL != maNL)
                {
                    MessageBox.Show("Nguyên liệu '" + tenNL + "' đã tồn tại với mã '" + _maNL + "'\nVui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    NguyenLieu nguyenLieu = new NguyenLieu(maNL, tenNL, _maLNL, chiSoDD, soLuongTon, donViTinh);
                    CapNhatNguyenLieu(nguyenLieu);
                } 
            }
            else
            {
                NguyenLieu nguyenLieu = new NguyenLieu(maNL, tenNL, _maLNL, chiSoDD, soLuongTon, donViTinh);
                if(KiemTraMaNL(maNL))
                {
                    CapNhatNguyenLieu(nguyenLieu);
                }
                ThemNguyenLieu(nguyenLieu);
            }
            
            
            
        }
        public static void ThemNguyenLieu(NguyenLieu nguyenlieu)
        {
            NguyenLieuDAL.ThemNguyenLieu(nguyenlieu);
        }

        public static void XoaNguyenLieu(string maNL)
        {
            NguyenLieuDAL.XoaNguyenLieu(maNL);
        }

        public static void CapNhatNguyenLieu(NguyenLieu nguyenlieu)
        {
            NguyenLieuDAL.CapNhatNguyenLieu(nguyenlieu);
        }

        public static void CapNhatTonNguyenLieuTheoMa(string maNguyenLieu, int soLuongDung)
        {
            NguyenLieuDAL.CapNhatTonNguyenLieuTheoMa(maNguyenLieu,soLuongDung);
        }

        public static DataTable LayDanhSachNguyenLieu()
        {
            return NguyenLieuDAL.LayDanhSachNguyenLieu();
        }

        public static DataTable LayDanhSachNguyenLieu(string tuKhoa)
        {
            return NguyenLieuDAL.LayDanhSachNguyenLieu(tuKhoa);
        }

        public static DataTable LayDanhSachTenVaMaNguyenLieu()
        {
            return NguyenLieuDAL.LayDanhSachTenVaMaNguyenLieu();
        }

        public static string LayMaNguyenLieuTheoTen(string tenNL)
        {
            return NguyenLieuDAL.LayMaNguyenLieuTheoTen(tenNL);
        }
        public static string LayDonViTinhTheoTen(string tenNL)
        {
            return NguyenLieuDAL.LayDonViTinhTheoTen(tenNL);
        }
        public static string LayCSDDTheoTen(string tenNL)
        {
            return NguyenLieuDAL.LayCSDDTheoTen(tenNL);
        }

        public static string LaySoLuongTonTheoMaNguyenLieu(string maNguyenLieu)
        {
            return NguyenLieuDAL.LaySoLuongTonTheoMaNguyenLieu(maNguyenLieu);
        }

        public static string SinhMaTuDong()
        {
            string maCuoi = NguyenLieuDAL.LayMaCuoi().Trim();

            //chưa có Nguyên liệu nào trong CSDL
            if (maCuoi == "")
            {
                return "MANL000001";
            }

            //xoa 4 chữ cái đầu chuỗi và tăng số đếm lên 1
            int maTiepTheo = int.Parse(maCuoi.Remove(0, 4)) + 1;
            string maTuDong = maTiepTheo.ToString().Trim();

            while (maTuDong.Length < 6)
            {
                maTuDong = "0" + maTuDong;
                maTuDong.Trim();
            }

            return "MANL" + maTuDong;
        }

        public static bool KiemTraTenNL(string TenNL)
        {
            return NguyenLieuDAL.KiemTraTenNL(TenNL);
        }

        public static bool KiemTraMaNL(string MaNL)
        {
            return NguyenLieuDAL.KiemTraMaNL(MaNL);
        }
        public static bool CoTrongChiTietPhieuMua(string MaNL)
        {
            return NguyenLieuDAL.CoTrongChiTietPhieuMua(MaNL);
        }
    }
}
