using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class NguyenLieu
    {
        private string _maNguyenLieu;
        public string MaNguyenLieu
        {
            get { return _maNguyenLieu; }
            set { _maNguyenLieu = value; }
        }

        private string _tenNguyenLieu;
        public string TenNguyenLieu
        {
            get { return _tenNguyenLieu; }
            set { _tenNguyenLieu = value; }
        }

        private string _maLoai;
        public string MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }

        private double _nangLuong;
        public double NangLuong
        {
            get { return _nangLuong; }
            set { _nangLuong = value; }
        }

        private string _donViTinh;
        public string DonViTinh
        {
            get { return _donViTinh; }
            set { _donViTinh = value; }
        }

        public NguyenLieu() { }

        public NguyenLieu(string MaNguyenLieu, string TenNguyenLieu, string MaLoai, double NangLuong, string DonViTinh)
        {
            _maNguyenLieu = MaNguyenLieu;
            _tenNguyenLieu = TenNguyenLieu;
            _maLoai = MaLoai;
            _nangLuong = NangLuong;
            _donViTinh = DonViTinh;
        }
    }
}
