using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class LoaiLop
    {
        private string maLoaiLop;

        public string MaLoaiLop
        {
            get { return maLoaiLop; }
            set { maLoaiLop = value; }
        }

        private string tenLoaiLop;

        public string TenLoaiLop
        {
            get { return tenLoaiLop; }
            set { tenLoaiLop = value; }
        }

        public LoaiLop(DataRow row)
        {
            this.maLoaiLop = row["MaLoaiLop"].ToString();
            this.tenLoaiLop = row["TenLop"].ToString();
        }
    }
}
