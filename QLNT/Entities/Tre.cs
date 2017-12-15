using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class Tre
    {
        private string maTre;
        private string hoTen;
        private DateTime ngaySinh;
        private int gioiTinh;
        private string tenCha;
        private string tenMe;
        private string diaChi;
        private string dienThoai;

        public string MaTre
        {
            get
            {
                return maTre;
            }

            set
            {
                maTre = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public int GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string TenCha
        {
            get
            {
                return tenCha;
            }

            set
            {
                tenCha = value;
            }
        }

        public string TenMe
        {
            get
            {
                return tenMe;
            }

            set
            {
                tenMe = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string DienThoai
        {
            get
            {
                return dienThoai;
            }

            set
            {
                dienThoai = value;
            }
        }

        public Tre(DataRow row)
        {
            this.maTre = row["MaTre"].ToString();
            this.HoTen = row["HoTenTre"].ToString();
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.gioiTinh = (int)row["GioiTinh"];
            this.tenCha = row["HoTenCha"].ToString();
            this.tenMe = row["HoTenMe"].ToString();
            this.diaChi = row["DiaChi"].ToString();
            this.dienThoai = row["SDTLienLac"].ToString();
        }
        public Tre(string maTre, string hoTen, 
            int gioiTinh, DateTime ngaySinh, 
            string tenCha, string tenMe, 
            string diaChi, string dienThoai)
        {
            this.MaTre = maTre;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.tenCha = tenCha;
            this.TenMe = tenMe;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
        }

        public Tre()
        {
        }
    }
}
