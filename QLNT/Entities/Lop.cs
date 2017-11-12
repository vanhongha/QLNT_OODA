using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class Lop
    {
        private string maLop;

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        private string tenLop;

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        private string maNamHoc;

        public string MaNamHoc
        {
            get { return maNamHoc; }
            set { maNamHoc = value; }
        }

        private string maLoaiLop;

        public string MaLoaiLop
        {
            get { return maLoaiLop; }
            set { maLoaiLop = value; }
        }

        private int siSo;

        public int SiSo
        {
            get { return siSo; }
            set { siSo = value; }
        }

        private string maGV;

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }

        public Lop(DataRow row)
        {
            this.maLop = row["MaLop"].ToString();
            this.tenLop = row["TenLop"].ToString();
            this.maNamHoc = row["NamHoc"].ToString();
            this.maLoaiLop = row["MaLoaiLop"].ToString();
            this.maGV = row["MaGV"].ToString();
            this.siSo = int.Parse(row["SiSo"].ToString());
        }

        public Lop()
        {
        }
    }
}
