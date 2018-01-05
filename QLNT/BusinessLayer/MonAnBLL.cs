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
    class MonAnBLL
    {
        public static void LuuMonAn(string maMonAn, string tenMonAn)
        {
            if(maMonAn == "")
            {
                MessageBox.Show("Chưa có mã món ăn\nVui lòng chọn Xóa trắng để sinh mã món ăn mới", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string _maMonAn = LayMaMonAnTheoTen(tenMonAn);
            if (tenMonAn == "")
            {
                MessageBox.Show("Vui lòng điền tên nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (_maMonAn != "")
            {
                if (_maMonAn != maMonAn)
                {
                    MessageBox.Show("Món ăn '" + tenMonAn + "' đã tồn tại với mã '" + _maMonAn + "'\nVui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MonAn monAn = new MonAn(maMonAn,tenMonAn);
                    CapNhatMonAn(monAn);
                }
            }
            else
            {
                MonAn monAn = new MonAn(maMonAn, tenMonAn);
                if (KiemTraMonAn(maMonAn))
                {
                    CapNhatMonAn(monAn);
                }
                ThemMonAn(monAn);
            }
        }
        public static void ThemMonAn(MonAn monAn)
        {
            MonAnDAL.ThemMonAn(monAn);
        }

        public static void XoaMonAn(string maMon)
        {
            if(maMon == "")
            {
                MessageBox.Show("Chưa chọn món để xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            MonAnDAL.XoaMonAn(maMon);
        }

        public static void CapNhatMonAn(MonAn monAn)
        {
            MonAnDAL.CapNhatMonAn(monAn);
        }

        public static string LayMaMonAnTheoTen(string tenMonAn)
        {
            return MonAnDAL.LayMaMonAnTheoTen(tenMonAn);
        }

        public static string LayNangLuongMonAnTheoTen(string tenMonAn)
        {
            return MonAnDAL.LayNangLuongMonAnTheoTen(tenMonAn);
        }

        public static DataTable LayDanhSachMonAn()
        {
            return MonAnDAL.LayDanhSachMonAn();
        }
       
        public static string SinhMaTuDong()
        {
            string maCuoi = MonAnDAL.LayMaCuoi().Trim();

            //chưa có phiếu mua nào trong CSDL
            if (maCuoi == "")
            {
                return "MAMA000001";
            }

            //xoa 4 chữ cái đầu chuỗi và tăng số đếm lên 1
            int maTiepTheo = int.Parse(maCuoi.Remove(0, 4)) + 1;
            string maTuDong = maTiepTheo.ToString().Trim();

            while (maTuDong.Length < 6)
            {
                maTuDong = "0" + maTuDong;
                maTuDong.Trim();
            }

            return "MAMA" + maTuDong;
        }

        public static bool KiemTraMonAn(string maMonAn)
        {
            return MonAnDAL.KiemTraMonAn(maMonAn);
        }

        public static bool KiemTraMonAnTrongThucDon(string maMonAn)
        {
            return MonAnDAL.KiemTraMonAnTrongThucDon(maMonAn);
        }

        public static DataTable initDgvMonAn(DataTable tableMonAn)
        {
            DataColumn column;
            DataColumn[] key = new DataColumn[1];
            column = new DataColumn();
            column.ColumnName = "TenMonAn";
            tableMonAn.Columns.Add(column);
            key[0] = column;
            tableMonAn.PrimaryKey = key;

            column = new DataColumn();
            column.ColumnName = "NangLuong";
            tableMonAn.Columns.Add(column);

            return tableMonAn;
        }

        public static DataTable setDateDgvMonAn(DataTable tableMonAn, DataTable data)
        {
            tableMonAn.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                DataRow newRow = tableMonAn.NewRow();
                newRow["TenMonAn"] = row.ItemArray[0].ToString().Trim();
                newRow["NangLuong"] = row.ItemArray[1].ToString().Trim();
                tableMonAn.Rows.Add(newRow);
            }
            return tableMonAn;
        }
    }
}
