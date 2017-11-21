using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class DanhMucChiPhi
    {
        private string maDanhMuc;

        public string MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }

        private string tenChiPhi;

        public string TenChiPhi
        {
            get { return tenChiPhi; }
            set { tenChiPhi = value; }
        }

        private string maLoaiChiPhi;

        public string MaLoaiChiPhi
        {
            get { return maLoaiChiPhi; }
            set { maLoaiChiPhi = value; }
        }

        private string tenLoaiChiPhi;

        public string TenLoaiChiPhi
        {
            get { return tenLoaiChiPhi; }
            set { tenLoaiChiPhi = value; }
        }

        private decimal soTien;

        public decimal SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }

        private int truTienKhiNghi;

        public int TruTienKhiNghi
        {
            get { return truTienKhiNghi; }
            set { truTienKhiNghi = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
 
        public DanhMucChiPhi() {  }

        public DanhMucChiPhi(DataRow row)
        {
            this.maDanhMuc = row["MaDanhMuc"].ToString();
            this.tenChiPhi = row["TenChiPhi"].ToString();
            this.maLoaiChiPhi = row["MaLoaiChiPhi"].ToString();
            this.tenLoaiChiPhi = row["TenLoaiChiPhi"].ToString();
            this.soTien = decimal.Parse(row["SoTien"].ToString());
            this.truTienKhiNghi = int.Parse(row["TruTienKhiNghi"].ToString());
            this.ghiChu = row["GhiChu"].ToString();
        }


    }
}
