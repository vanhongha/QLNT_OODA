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
        private string ngaySinh;
        private string gioiTinh;
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

        public string NgaySinh
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

        public string GioiTinh
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
            this.ngaySinh = row["NgaySinh"].ToString();
            this.gioiTinh = row["GioiTinh"].ToString();
            this.tenCha = row["HoTenCha"].ToString();
            this.tenMe = row["HoTenMe"].ToString();
            this.diaChi = row["DiaChi"].ToString();
            this.dienThoai = row["SDTLienLac"].ToString();
        }

        public Tre()
        {
        }
    }
}
