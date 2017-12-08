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
    class TreBLL
    {
        public static DataTable GetListTre(Lop lop = null, string keyWord = null)
        {
            return TreDAL.GetListTre(lop, keyWord);
        }

        public static DataTable GetListTreChuaCoLop()
        {
            return TreDAL.GetListTreChuaCoLop();
        }

        public static string GenMaTre()
        {
            string id = TreDAL.GetLastID().Trim();
            if (id == "")
            {
                return "MTRE000001";
            }
            int nextID = int.Parse(id.Remove(0, "MTRE".Length)) + 1;
            id = "00000" + nextID.ToString();
            id = id.Substring(id.Length - 6, 6);
            return "MTRE" + id;
        }

        public static bool ThemTre(Tre hocsinhmoi)
        {
            DataTable dt = TreDAL.ThemTre(hocsinhmoi);
            foreach (DataRow row in dt.Rows)            
                if (row.ItemArray[0].ToString().Trim() == "0")
                    return true;            

            return false;
        }

        public static DataTable LayThongTinTre(string maTre)
        {
            return TreDAL.LayThongTinTre(maTre);
        }

        public static void CapNhatThongTinTre(Tre tre)
        {
            TreDAL.CapNhatThongTinTre(tre);
        }

        public static void XoaTre(string maTre)
        {
            TreDAL.XoaTre(maTre);
        }

        public static void XoaTre(List<string> listMaTre)
        {
            foreach (string maTre in listMaTre)
                TreDAL.XoaTre(maTre);
        }

        public static DataTable GetListTreTheoMaLop(string maLop)
        {
            return TreDAL.GetListTreTheoMaLop(maLop);
        }

        public static bool XepLop(List<string> listMaTre, string maLop)
        {
            foreach (string maTre in listMaTre)
            {
                try
                {
                    TreDAL.XepLop(maTre, maLop);
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool LenLop(List<string> listMaTre, string maLopMoi,string maLopCu)
        {
            foreach (string maTre in listMaTre)
            {
                if (string.Compare(TreDAL.GetTinhTrangTrongLop(maTre, maLopCu).Trim(), "0") == 0) 
                {
                    try
                    {
                        TreDAL.LenLop(maTre, maLopMoi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else                
                    return false;                
            }
            return true;
        }

        public static bool ChuyenLop(List<string> listMaTre, string maLopMoi, string maLopCu)
        {
            foreach (string maTre in listMaTre)
            {
                if (string.Compare(TreDAL.GetTinhTrangTrongLop(maTre, maLopCu).Trim(), "0") == 0)
                {
                    try
                    {
                        TreDAL.ChuyenLop(maTre, maLopMoi);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    return false;
            }
            return true;
        }

        public static bool ThoiHoc(List<string> listMaTre, string maLop)
        {
            foreach (string maTre in listMaTre)
            {
                if (string.Compare(TreDAL.GetTinhTrangTrongLop(maTre, maLop).Trim(), "0") == 0)
                {
                    try
                    {
                        TreDAL.ThoiHoc(maTre, maLop);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    return false;
            }
            return true;
        }        

        public static int GetSoNgayDiHocTrongThang(string maTre, int thang, int nam)
        {
            return 20;
        }

        public static void KhoiTaoSucKhoe(string maTre, int thang, int nam)
        {
            if(!SucKhoeBLL.KiemTraTonTaiSucKhoe(maTre, thang, nam))
                SucKhoeBLL.KhoiTaoSucKhoe(maTre, thang, nam);
        }

        public static void KhoiTaoHocPhi(string maTre, int thang, int nam)
        {
            if (!HocPhiBLL.KiemTraTonTaiHocPhi(maTre, thang, nam))
                HocPhiBLL.KhoiTaoHocPhi(maTre, thang, nam);
        }
    }
}