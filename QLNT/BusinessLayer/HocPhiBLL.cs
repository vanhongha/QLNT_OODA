using QLNT.BusinessLayer;
using QLNT.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class HocPhiBLL
    {
        public static List<HocPhi> GetListHocPhiTheoThang(string maLop, int thang, int nam)
        {
            DataTable dt = HocPhiDAL.GetListHocPhiTheoThang(maLop, thang, nam);
            List<HocPhi> list = new List<HocPhi>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HocPhi(row));
            }

            return list;
        }

        public static List<ChiTietHocPhi> GetChiTietHocPhi(string maHocPhi)
        {
            List<ChiTietHocPhi> list = new List<ChiTietHocPhi>();
            DataTable dt = HocPhiDAL.GetChiTietHocPhi(maHocPhi);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ChiTietHocPhi(row));
            }
            return list;
        }

        //return -1 nếu quá thời gian áp dụng
        //return 0 nếu tới thời gian áp dụng
        //return 1 nếu chưa tới thời gian áp dụng
        public static int CoTheCapNhatHocPhi(int hocPhiThang, int hocPhiNam, DateTime ngayCapNhat)
        {
            //tháng có thể cập nhật được học phí
            //ví dụ: muốn cập nhật học phí tháng 11/2017 thì thời gian cập nhật hợp lệ là 12/2017
            //vì khi trẻ học xong tháng 11 thì mới có đầy đủ các thông tin về ngày đi học để tính học phí
            int thangHopLe = hocPhiThang + 1;
            int namHopLe = hocPhiNam;
            if(thangHopLe > 12)
            {
                thangHopLe = 1;
                namHopLe += 1;
            }

            if(namHopLe < ngayCapNhat.Year)
            {
                return -1;
            }
            else if(namHopLe > ngayCapNhat.Year)
            {
                return 1;
            }
            else if(thangHopLe < ngayCapNhat.Month)
            {
                return -1;
            }
            else if(thangHopLe > ngayCapNhat.Month)
            {
                return 1;
            }
            return 0;
        }

        public static void CapNhatHocPhiVoiTienNoThangTruoc(HocPhi hocPhi)
        {
            HocPhiDAL.CapNhatHocPhi(hocPhi);
        }

        public static void CapNhatHocPhi(HocPhi hocPhi, List<ChiTietHocPhi> listChiTiet)
        {
            int soNgayDiHoc = TreBLL.GetSoNgayDiHocTrongThang(hocPhi.MaTre, hocPhi.Thang, hocPhi.Nam);
            //Xoa tat ca cac chi tiet hoc phi hien co
            foreach (ChiTietHocPhi chiTiet in GetChiTietHocPhi(hocPhi.MaHocPhi))
            {
                HocPhiDAL.XoaChiTietHocPhi(chiTiet);
            }

            //Luu cac chi tiet hoc phi vua moi cap nhat
            foreach (ChiTietHocPhi chiTiet in listChiTiet)
            {
                DanhMucChiPhi danhMuc = DanhMucChiPhiBLL.GetInfoDanhMuc(chiTiet.MaDanhMuc);
                ChiTietHocPhi chiTietHocPhi = (ChiTietHocPhi)chiTiet.Clone();
                //cap nhat lai so tien trong list neu danh muc chi phi nay tinh tien theo so ngay di hoc
                chiTietHocPhi.SoTien = danhMuc.TinhTheoSoNgayDiHoc == 1 ? danhMuc.SoTien * soNgayDiHoc : chiTiet.SoTien;
                chiTietHocPhi.MaHocPhi = hocPhi.MaHocPhi;
                HocPhiDAL.ThemChiTietHocPhi(chiTietHocPhi);
            }

            //luu hoc phi
            HocPhiDAL.CapNhatHocPhi(hocPhi);
        }

        public static bool KiemTraTonTaiHocPhi(string maTre, int thang, int nam)
        {
            DataTable dt = HocPhiDAL.KiemTraTonTaiHocPhi(maTre, thang, nam);
            foreach (DataRow row in dt.Rows)
            {
                return int.Parse(row[0].ToString()) == 1;
            }

            return false;
        }

        public static void KhoiTaoHocPhi(string maTre, int thang, int nam)
        {
            HocPhi hocPhi = new HocPhi();
            hocPhi.MaHocPhi = GenerateMaHocPhi();
            hocPhi.MaTre = maTre;
            hocPhi.Thang = thang;
            hocPhi.Nam = nam;
            HocPhiDAL.KhoiTaoHocPhi(hocPhi);
        }

        public static string GenerateMaHocPhi()
        {
            string id = HocPhiDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MAHP000001";
            }
            int nextID = int.Parse(id.Remove(0, "MAHP".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MAHP" + id;
        }

        public static decimal TinhHocPhiThangNay(HocPhi hocPhi, List<ChiTietHocPhi> list)
        {
            decimal tong = 0;
            int soNgayDiHoc = TreBLL.GetSoNgayDiHocTrongThang(hocPhi.MaTre, hocPhi.Thang, hocPhi.Nam);
            foreach (ChiTietHocPhi chiTiet in list)
            {
                DanhMucChiPhi danhMuc = DanhMucChiPhiBLL.GetInfoDanhMuc(chiTiet.MaDanhMuc);

                //cap nhat lai so tien trong list neu danh muc chi phi nay tinh tien theo so ngay di hoc
                tong += danhMuc.TinhTheoSoNgayDiHoc == 1 ? danhMuc.SoTien * soNgayDiHoc : chiTiet.SoTien;
            }

            return tong;
        }

        public static decimal LayTienNoHocPhiThangTruoc(HocPhi hocPhi)
        {
            int thang = hocPhi.Thang;
            int nam = hocPhi.Nam;

            if(thang == 1)
            {
                thang = 12;
                nam -= 1;
            }
            else
            {
                thang -= 1;
            }

            DataTable dt = HocPhiDAL.LaySoTienConNoCuaThang(thang, nam, hocPhi.MaTre);
            foreach(DataRow row in dt.Rows)
            {
                return decimal.Parse(row["SoTienConNo"].ToString());
            }

            return 0;
        }

        public static HocPhi LayThongTinHocPhi(string maHocPhi)
        {
            DataTable dt = HocPhiDAL.GetInfoHocPhi(maHocPhi);
            foreach(DataRow row in dt.Rows)
            {
                return new HocPhi(row);
            }
            return new HocPhi();
        }

        public static DataTable LayDanhSachBienLaiTheoThang(string maTre, int thang, string maNamHoc)
        {
            int nam = LopBLL.GetNamHoc(thang, maNamHoc);
            return HocPhiDAL.LayDanhSachBienLaiTheoThang(maTre, thang, nam);
        }

        public static void ThemBienLai(BienLaiThuHocPhi bienLai, string maHocPhi)
        {
            //Thêm biên lai
            HocPhiDAL.ThemBienLai(bienLai);

            //Cập nhật lại số tiền đã đóng và số tiền còn nợ của học phí tháng đó
            HocPhi hocPhi = LayThongTinHocPhi(maHocPhi);
            hocPhi.SoTienDaDong += bienLai.SoTienThu;
            hocPhi.SoTienConNo = hocPhi.TongTienHocPhi - hocPhi.SoTienDaDong;
            HocPhiDAL.CapNhatHocPhi(hocPhi);
        }

        public static void HuyBienLai(BienLaiThuHocPhi bienLai, string maHocPhi)
        {
            //Xóa biên lai
            HocPhiDAL.HuyBienLai(bienLai.MaBienLai);

            //Cập nhật lại học phí cho trẻ
            HocPhi hocPhi = LayThongTinHocPhi(maHocPhi);
            hocPhi.SoTienDaDong -= bienLai.SoTienThu;
            hocPhi.SoTienConNo = hocPhi.TongTienHocPhi - hocPhi.SoTienDaDong;
            HocPhiDAL.CapNhatHocPhi(hocPhi);
        }

        public static string GenerateMaBienLai()
        {
            string id = HocPhiDAL.GetLastBienLaiID().Trim();
            if (id == "")
            {
                return "MABL000001";
            }
            int nextID = int.Parse(id.Remove(0, "MABL".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MABL" + id;
        }

        public static bool CoTheHuyBienLai(DateTime ngayThu, DateTime ngayHuy)
        {
            return ngayHuy.Day == ngayThu.Day && ngayThu.Month == ngayHuy.Month && ngayThu.Year == ngayHuy.Year;
        }
    }
}
