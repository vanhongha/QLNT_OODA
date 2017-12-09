using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ThongTinThucDon
    {
        private string _maTre;
        public string MaTre
        {
            get { return _maTre; }
            set { _maTre = value; }
        }

        private string _buoiApDung;
        public string BuoiApDung
        {
            get { return _buoiApDung; }
            set { _buoiApDung = value; }
        }

        private DateTime _ngayApDung;
        public DateTime NgayApDung
        {
            get { return _ngayApDung; }
            set { _ngayApDung = value; }
        }

        private string _monApDung;
        public string MonApDung
        {
            get { return _monApDung; }
            set { _monApDung = value; }
        }

        private string _loaiApDung;
        public string LoaiApDung
        {
            get { return _loaiApDung; }
            set { _loaiApDung = value; }
        }

        public ThongTinThucDon() { }
        public ThongTinThucDon(string maTre, string buoiApDung, DateTime ngayApDung, string monApdung, string loaiApDung)
        {
            _maTre = maTre;
            _buoiApDung = buoiApDung;
            _monApDung = monApdung;
            _loaiApDung = loaiApDung;
            _ngayApDung = ngayApDung;
        }
    }
}
