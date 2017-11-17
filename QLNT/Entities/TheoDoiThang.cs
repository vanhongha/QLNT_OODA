using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class TheoDoiThang
    {
        private string maTheoDoi;
        private string maTre;
        private int thang;
        private int nam;
        private bool phieuThang;
        private bool phieuTuan1;
        private bool phieuTuan2;
        private bool phieuTuan3;
        private bool phieuTuan4;
        private string nhanXetThang;

        public string MaTheoDoi
        {
            get
            {
                return maTheoDoi;
            }

            set
            {
                maTheoDoi = value;
            }
        }

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

        public int Thang
        {
            get
            {
                return thang;
            }

            set
            {
                thang = value;
            }
        }

        public int Nam
        {
            get
            {
                return nam;
            }

            set
            {
                nam = value;
            }
        }

        public bool PhieuThang
        {
            get
            {
                return phieuThang;
            }

            set
            {
                phieuThang = value;
            }
        }

        public bool PhieuTuan1
        {
            get
            {
                return phieuTuan1;
            }

            set
            {
                phieuTuan1 = value;
            }
        }

        public bool PhieuTuan2
        {
            get
            {
                return phieuTuan2;
            }

            set
            {
                phieuTuan2 = value;
            }
        }

        public bool PhieuTuan3
        {
            get
            {
                return phieuTuan3;
            }

            set
            {
                phieuTuan3 = value;
            }
        }

        public bool PhieuTuan4
        {
            get
            {
                return phieuTuan4;
            }

            set
            {
                phieuTuan4 = value;
            }
        }

        public string NhanXetThang
        {
            get
            {
                return nhanXetThang;
            }

            set
            {
                nhanXetThang = value;
            }
        }
        public TheoDoiThang(DataRow row)
        {
            this.maTheoDoi = row["MaTT"].ToString();
            this.maTre = row["MaTre"].ToString();
            this.nam = int.Parse(row["Nam"].ToString());
            this.thang = int.Parse(row["Thang"].ToString());
            this.phieuThang = bool.Parse(row["PhieuBeNgoanThang"].ToString());
            this.phieuTuan1 = bool.Parse(row["PhieuBeNgoanTuan1"].ToString());
            this.phieuTuan2 = bool.Parse(row["PhieuBeNgoanTuan2"].ToString());
            this.phieuTuan3 = bool.Parse(row["PhieuBeNgoanTuan3"].ToString());
            this.phieuTuan4 = bool.Parse(row["PhieuBeNgoanTuan4"].ToString());
            this.nhanXetThang = row["NhanXetThang"].ToString();
        }

        public TheoDoiThang()
        {
        }
    }
}
