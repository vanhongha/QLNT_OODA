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
        public static void LuuThongTinThucDon(string[] arrMaTre, string[] arrMaMon, string buoiAD, DateTime ngayAD)
        {
            #region // check input
            if (arrMaTre.Length == 0)
            {
                MessageBox.Show("Chưa chọn trẻ để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (arrMaMon.Length == 0)
            {
                MessageBox.Show("Chưa chọn món ăn để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (buoiAD == "")
            {
                MessageBox.Show("Chưa chọn buổi để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (ngayAD == null)
            {
                MessageBox.Show("Chưa chọn ngày để xét thực đơn", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            #endregion

            string[] loaiAD = { "Món chính", "Món phụ 1", "Món phụ 2", "Món phụ 3", "Món phụ 4", "Món phụ 5" };
            for(int i = 0; i < arrMaTre.Length; i++)
            {
                for(int j = 0; j < arrMaMon.Length; j++)
                {
                    if(arrMaMon[j] == "")
                    {
                        continue;
                    }
                    ThongTinThucDon thongTinTD = new ThongTinThucDon(arrMaTre[i], buoiAD, ngayAD, arrMaMon[j], loaiAD[j]);
                }
            }
        }

        public static void ThemThongTinThucDon(ThongTinThucDon thongTinTD)
        {
            ThongTinThucDonDAL.ThemThongTinThucDon(thongTinTD);
        }
        public static void XoaThongTinThucDon(ThongTinThucDon thongTinTD)
        {
            ThongTinThucDonDAL.XoaThongTinThucDon(thongTinTD);
        }
    }
}
