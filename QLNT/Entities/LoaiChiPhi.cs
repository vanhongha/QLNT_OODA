using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class LoaiChiPhi
    {
        private string maLoaiChiPhi;

        public string MaLoaiChiPhi
        {
            get { return maLoaiChiPhi; }
            set { maLoaiChiPhi = value; }
        }

        private string tenLoaiChiPhi;

        public string TenLoaiChiPHi
        {
            get { return tenLoaiChiPhi; }
            set { tenLoaiChiPhi = value; }
        }

        public LoaiChiPhi(DataRow row)
        {
            this.maLoaiChiPhi = row["MaLoaiChiPhi"].ToString();
            this.tenLoaiChiPhi = row["TenLoaiChiPhi"].ToString();
        }
    }
}
