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
    class ThongTinThucDonBLL
    {
        public static bool LuuThongTinThucDon(List<string> listTre, List<string> listMonAn, string buoiAD, DateTime ngayAD)
        {
            #region // check input
            if (listTre.Count == 0)
            {
                MessageBox.Show("Chưa chọn trẻ để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (listMonAn.Count == 0)
            {
                MessageBox.Show("Chưa chọn món ăn để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (buoiAD == "")
            {
                MessageBox.Show("Chưa chọn buổi để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (ngayAD == null)
            {
                MessageBox.Show("Chưa chọn ngày để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            #endregion

            string[] loaiAD = { "Món chính", "Món phụ 1", "Món phụ 2", "Món phụ 3", "Món phụ 4", "Món phụ 5" };
            for(int i = 0; i < listTre.Count; i++)
            {
                for(int j = 0; j < listMonAn.Count; j++)
                {
                    if(listMonAn[j] == "")
                    {
                        continue;
                    }
                    ThongTinThucDon thongTinTD = new ThongTinThucDon(listTre[i], buoiAD, ngayAD, listMonAn[j], loaiAD[j]);
                    if (!ThemThongTinThucDon(thongTinTD)) { return false; }
                }
            }

            return true;
        }

        public static bool HuyThongTinThucDon(List<string> listTre, string buoiAD, DateTime ngayAD)
        {
            #region // check input
            if (listTre.Count == 0)
            {
                MessageBox.Show("Chưa chọn trẻ để hủy thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (buoiAD == "")
            {
                MessageBox.Show("Chưa chọn buổi để hủy thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (ngayAD == null)
            {
                MessageBox.Show("Chưa chọn ngày để hủy thực đơn", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            #endregion
            for (int i = 0; i < listTre.Count; i++)
            {
                XoaThongTinThucDon(listTre[i], buoiAD, ngayAD);
            }

            return true;
        }

        public static bool ThemThongTinThucDon(ThongTinThucDon thongTinTD)
        {
            return ThongTinThucDonDAL.ThemThongTinThucDon(thongTinTD);
        }

        public static void XoaThongTinThucDon(string maTre, string buoiAD, DateTime ngayAD)
        {
            ThongTinThucDonDAL.XoaThongTinThucDon(maTre, buoiAD, ngayAD);
        }
        public static void XoaThongTinThucDon(ThongTinThucDon thongTinTD)
        {
            ThongTinThucDonDAL.XoaThongTinThucDon(thongTinTD);
        }

        public static DataTable LayDanhSachTreChuaXetThucDon(string maLop, int thang, int nam, string buoiAD, DateTime ngayAD)
        {
           
            return ThongTinThucDonDAL.LayDanhSachTreChuaXetThucDon(maLop, thang, nam, buoiAD, ngayAD);
            
        }

        public static DataTable LayDanhSachTreDaXetThucDon(string maLop, int thang, int nam, string buoiAD, DateTime ngayAD)
        {
            return ThongTinThucDonDAL.LayDanhSachTreDaXetThucDon(maLop, thang, nam, buoiAD, ngayAD);
        }

        public static void getListTre(List<string> listTre, DataGridView dgv, bool getAll)
        {
            listTre.Clear();
            if (getAll)
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    listTre.Add(dgv.Rows[i].Cells["MaTre"].Value.ToString().Trim());
                }
            }
            else
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    DataGridViewRow row = dgv.Rows[i];
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        listTre.Add(row.Cells["MaTre"].Value.ToString().Trim());
                    }
                }
            }
            
        }

        public static void getListMonAn(List <string> listMonAn, DataGridView dgv)
        {
            listMonAn.Clear();
            for (int i = 0; i < dgv.RowCount; i++)
            {
                listMonAn.Add(MonAnBLL.LayMaMonAnTheoTen(dgv.Rows[i].Cells["TenMonAn"].Value.ToString().Trim()));
            }
        }
    }
}
