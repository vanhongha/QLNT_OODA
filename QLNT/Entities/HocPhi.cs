using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class HocPhi
    {
        private string maHocPhi;

        public string MaHocPhi
        {
            get { return maHocPhi; }
            set { maHocPhi = value; }
        }

        private string maTre;

        public string MaTre
        {
            get { return maTre; }
            set { maTre = value; }
        }

        private string hoTenTre;

        public string HoTenTre
        {
            get { return hoTenTre; }
            set { hoTenTre = value; }
        }

        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        private int thang;

        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }

        private int nam;

        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }

        private decimal tongTien;

        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        
        public HocPhi(DataRow row)
        {
            maHocPhi = row["MaHocPhi"].ToString();
            maTre = row["MaTre"].ToString();
            hoTenTre = row["HoTenTre"].ToString();
            gioiTinh = row["GioiTinh"].ToString();
            ngaySinh = (DateTime)row["NgaySinh"];
            thang = int.Parse(row["Thang"].ToString());
            nam = int.Parse(row["Nam"].ToString());
            tongTien = decimal.Parse(row["TongTienNo"].ToString());
        }

        public HocPhi() { }

    }
}
