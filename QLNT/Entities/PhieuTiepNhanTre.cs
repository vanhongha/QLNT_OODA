using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class PhieuTiepNhanTre
    {
        private string maPhieu;
        private string ngayTiepNhan;
        private string maTre;
        private string nguoiTiepNhan;

        public string MaPhieu
        {
            get
            {
                return maPhieu;
            }

            set
            {
                maPhieu = value;
            }
        }

        public string NgayTiepNhan
        {
            get
            {
                return ngayTiepNhan;
            }

            set
            {
                ngayTiepNhan = value;
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

        public string NguoiTiepNhan
        {
            get
            {
                return nguoiTiepNhan;
            }

            set
            {
                nguoiTiepNhan = value;
            }
        }
        public PhieuTiepNhanTre(DataRow row)
        {
            this.maTre = row["MaTre"].ToString();
            this.maPhieu = row["MaPhieu"].ToString();
            this.ngayTiepNhan = row["NgayTiepNhanTre"].ToString();
            this.nguoiTiepNhan = row["NguoiTiepNhan"].ToString();

        }
        public PhieuTiepNhanTre(string matre, string maphieu, string ngaytiepnhan, string nguoitiepnhan)
        {
            this.maTre = matre;
            this.maPhieu = maphieu;
            this.ngayTiepNhan = ngaytiepnhan;
            this.nguoiTiepNhan = nguoitiepnhan;
        }
        public PhieuTiepNhanTre()
        {
        }
    }
}
