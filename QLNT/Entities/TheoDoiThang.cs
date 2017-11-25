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
        
        private string maTre;
        private int thang;
        private int nam;
        private int phieuThang;
        private int phieuTuan1;
        private int phieuTuan2;
        private int phieuTuan3;
        private int phieuTuan4;
        private string nhanXetThang;

        

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

        public int PhieuThang
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

        public int PhieuTuan1
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

        public int PhieuTuan2
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

        public int PhieuTuan3
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

        public int PhieuTuan4
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
            
            this.maTre = row["MaTre"].ToString();
            this.nam = int.Parse(row["Nam"].ToString());
            this.thang = int.Parse(row["Thang"].ToString());
            this.phieuThang = int.Parse(row["PhieuBeNgoanThang"].ToString());
            this.phieuTuan1 = int.Parse(row["PhieuBeNgoanTuan1"].ToString());
            this.phieuTuan2 = int.Parse(row["PhieuBeNgoanTuan2"].ToString());
            this.phieuTuan3 = int.Parse(row["PhieuBeNgoanTuan3"].ToString());
            this.phieuTuan4 = int.Parse(row["PhieuBeNgoanTuan4"].ToString());
            this.nhanXetThang = row["NhanXetThang"].ToString();
        }

        public TheoDoiThang()
        {
        }
    }
}
