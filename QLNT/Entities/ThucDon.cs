using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ThucDon
    {
        private string _maThucDon;
        public string MaThucDon
        {
            get { return _maThucDon; }
            set { _maThucDon = value; }
        }

        private string _nguoiLap;
        public string NguoiLap
        {
            get { return _nguoiLap; }
            set { _nguoiLap = value; }
        }

        private DateTime _ngayLap;
        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
    }
}
