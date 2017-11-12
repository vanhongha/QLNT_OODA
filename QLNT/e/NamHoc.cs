using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class NamHoc
    {
        private string maNamHoc;

        public string MaNamHoc
        {
            get { return maNamHoc; }
            set { maNamHoc = value; }
        }

        private string nienKhoa;

        public string NienKhoa
        {
            get { return nienKhoa; }
            set { nienKhoa = value; }
        }

        private DateTime ngayBatDau;

        public DateTime NgayBatDau
        {
            get { return ngayBatDau; }
            set { ngayBatDau = value; }
        }

        private DateTime ngayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }


        public NamHoc(DataRow row)
        {
            this.maNamHoc = row["MaNamHoc"].ToString();
            this.nienKhoa = row["NamHoc"].ToString();
            this.NgayBatDau = (DateTime) row["NgayBatDau"];
            this.ngayKetThuc = (DateTime) row["NgayKetThuc"];
        }

        public NamHoc()
        {
        }
    }
}
