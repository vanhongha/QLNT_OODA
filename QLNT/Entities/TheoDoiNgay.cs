using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class TheoDoiNgay
    {
        private string maTre;
        private string ngayDiemDanh;
        private bool hienDien;
        private string nhanXet;

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

        public string NgayDiemDanh
        {
            get
            {
                return ngayDiemDanh;
            }

            set
            {
                ngayDiemDanh = value;
            }
        }

        public bool HienDien
        {
            get
            {
                return hienDien;
            }

            set
            {
                hienDien = value;
            }
        }

        public string NhanXet
        {
            get
            {
                return nhanXet;
            }

            set
            {
                nhanXet = value;
            }
        }
        public TheoDoiNgay(DataRow row)
        {
            this.maTre = row["MaTre"].ToString();
            this.ngayDiemDanh = row["Ngay"].ToString();
            this.hienDien = bool.Parse(row["HienDien"].ToString());
            this.nhanXet = row["NhanXet"].ToString();
            
        }

        public TheoDoiNgay()
        {
        }
    }
}
