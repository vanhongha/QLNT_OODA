using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class BienLaiThuHocPhi
    {
        private string maBienLai;

        public string MaBienLai
        {
            get { return maBienLai; }
            set { maBienLai = value; }
        }

        private string maTre;

        public string MaTre
        {
            get { return maTre; }
            set { maTre = value; }
        }

        private string nguoiDong;

        public string NguoiDong
        {
            get { return nguoiDong; }
            set { nguoiDong = value; }
        }

        private string nguoiThu;

        public string NguoiThu
        {
            get { return nguoiThu; }
            set { nguoiThu = value; }
        }

        private DateTime ngayThu;

        public DateTime NgayThu
        {
            get { return ngayThu; }
            set { ngayThu = value; }
        }

        private decimal soTienThu;

        public decimal SoTienThu
        {
            get { return soTienThu; }
            set { soTienThu = value; }
        }

        private decimal soTienConNo;

        public decimal SoTienConNo
        {
            get { return soTienConNo; }
            set { soTienConNo = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }


        public BienLaiThuHocPhi(DataRow row)
        {
            maBienLai = row["MaBienLai"].ToString();
            maTre = row["MaTre"].ToString();
            nguoiDong = row["NguoiDong"].ToString();
            nguoiThu = row["NguoiThu"].ToString();
            ngayThu = (DateTime)row["NgayThu"];
            soTienThu = decimal.Parse(row["SoTienThu"].ToString());
            soTienConNo = decimal.Parse(row["SoTienConNo"].ToString());
            ghiChu = row["GhiChu"].ToString();
        }

        public BienLaiThuHocPhi()
        {
        }
    }
}
