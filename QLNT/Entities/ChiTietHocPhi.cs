using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ChiTietHocPhi : ICloneable
    {
        private string maHocPhi;

        public string MaHocPhi
        {
            get { return maHocPhi; }
            set { maHocPhi = value; }
        }

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

        private decimal soTien;

        public decimal SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }

        public ChiTietHocPhi(DataRow row)
        {
            maHocPhi = row["MaHocPhi"].ToString();
            maDanhMuc = row["MaDanhMuc"].ToString();
            tenChiPhi = row["TenChiPhi"].ToString();
            soTien = decimal.Parse(row["SoTien"].ToString());
        }

        public ChiTietHocPhi()
        {
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
