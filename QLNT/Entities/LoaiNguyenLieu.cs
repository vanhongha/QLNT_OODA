using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class LoaiNguyenLieu
    {
        private string _maLoaiNguyenLieu;
        public string MaLoaiNguyenLieu
        {
            get { return _maLoaiNguyenLieu; }
            set { _maLoaiNguyenLieu = value; }
        }

        private string _tenLoaiNguyenLieu;
        public string TenLoaiNguyenLieu
        {
            get { return _tenLoaiNguyenLieu; }
            set { _tenLoaiNguyenLieu = value; }
        }
    }
}
