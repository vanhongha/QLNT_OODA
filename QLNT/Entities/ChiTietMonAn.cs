using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ChiTietMonAn
    {
        private string _maMon;
        private string _maNL;
        private int _soLuong;

        public string MaMon
        {
            get
            {
                return _maMon;
            }

            set
            {
                _maMon = value;
            }
        }

        public string MaNL
        {
            get
            {
                return _maNL;
            }

            set
            {
                _maNL = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }
        public ChiTietMonAn() { }
        public ChiTietMonAn(string maMonAn, string maNguyenLieu, int soLuong)
        {
            _maMon = maMonAn;
            _maNL = maNguyenLieu;
            _soLuong = soLuong;
        }
    }
}
