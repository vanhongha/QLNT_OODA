using QLNT.DataLayer;
using QLNT.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.BusinessLayer
{
    class LopBLL
    {
        public static string GenMaLop()
        {
            string id = LopDAL.GetLastID().Trim();
            if (id == "")            
                return "MLOP000001";            
            int nextID = int.Parse(id.Remove(0, "MLOP".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MLOP" + id;
        }

        public static int GetSiSoToiDa()
        {
            return LopDAL.GetSiSoToiDa();
        }

        public static string GenMaLoaiLop()
        {
            string id = LopDAL.GetLastLoaiLopID().Trim();
            if (id == "")
                return "MLLOP00001";
            int nextID = int.Parse(id.Remove(0, "MLLOP".Length)) + 1;
            id = "0000" + nextID.ToString();
            id = id.Substring(id.Length - 5, 5);
            return "MLLOP" + id;
        }

        public static string GenMaNienKhoa()
        {
            string id = LopDAL.GetLastIDNienKhoa().Trim();
            if (id == "")
                return "MANH000001";
            int nextID = int.Parse(id.Remove(0, "MANH".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MANH" + id;
        }
        
        public static List<NamHoc> GetListNienKhoa()
        {
            return LopDAL.GetListNienKhoa();
        }

        public static List<LoaiLop> GetListLoaiLop()
        {
            return LopDAL.GetListLoaiLop();
        }

        public static List<string> GetListGiaoVien()
        {
            return LopDAL.GetListGiaoVien();
        }

        public static List<Lop> GetListLop(string maNamHoc, string maLoaiLop)
        {
            return LopDAL.GetListLop(maNamHoc, maLoaiLop);
        }

        public static List<Lop> GetListLop(string maNamHoc = null)
        {
            return LopDAL.GetListLop(maNamHoc);
        }

        public static Lop GetInfoLop(string maLop)
        {
            DataTable dt = LopDAL.GetInfoLop(maLop);
            foreach (DataRow row in dt.Rows)
            {
                return new Lop(row);
            }
            return new Lop();
        }

        public static NamHoc GetInfoNamHoc(string maNamHoc)
        {
            DataTable dt = LopDAL.GetInfoNamHoc(maNamHoc);
            foreach(DataRow row in dt.Rows)
            {
                return new NamHoc(row);
            }
            return new NamHoc();
        }

        public static int GetNamHoc(int thang, string maNamHoc)
        {
            NamHoc namHoc = LopBLL.GetInfoNamHoc(maNamHoc);
            int nam = 0;
            if (thang < namHoc.NgayBatDau.Month)
                nam = namHoc.NgayKetThuc.Year;
            else
                nam = namHoc.NgayBatDau.Year;
            return nam;
        }

        public static string getMaNamHoc(DateTime ngayHoc)
        {
            return LopDAL.getMaNamHoc(ngayHoc);
        }

        public static int GetSiSo(string maLop)
        {
            return LopDAL.GetSiSo(maLop);
        }

        public static void CapNhatSiSo(string maLop, int siSo)
        {
            LopDAL.CapNhatSiSo(maLop, siSo);
        }

        public static bool CapNhatSiSoToiDa(int siSoCu, int siSoMoi)
        {
            try
            {
                LopDAL.CapNhatSiSoToiDa(siSoCu, siSoMoi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public static bool CapNhatLop(string maLop, string tenLop, string maGV)
        {
            try
            {
                LopDAL.CapNhatLop(maLop, tenLop, maGV);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
            
        }

        public static bool ThemLop(string maLop, string maLoaiLop, string maNamHoc, string maGV, string tenLop)
        {
            try
            {
                LopDAL.ThemLop(maLop, maLoaiLop, maNamHoc, maGV, tenLop);
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool ThemLoaiLop(string maLoaiLop, string tenLoaiLop)
        {
            try
            {
                LopDAL.ThemLoaiLop(maLoaiLop, tenLoaiLop);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool CapNhatLoaiLop(string maLoaiLop, string tenLoaiLop)
        {
            try
            {
                LopDAL.CapNhatLoaiLop(maLoaiLop, tenLoaiLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public static bool CapNhatNienKhoa(string maNienKhoa, string tenNienKhoa)
        {
            try
            {
                LopDAL.CapNhatNienKhoa(maNienKhoa, tenNienKhoa);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool ThemNienKhoa(string maNienKhoa, string tenNienKhoa, DateTime tgBatDau, DateTime tgKetThuc)
        {
            try
            {
                LopDAL.ThemNienKhoa(maNienKhoa, tenNienKhoa, tgBatDau, tgKetThuc);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
