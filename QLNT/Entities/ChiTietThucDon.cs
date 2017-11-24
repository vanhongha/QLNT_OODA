using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class ChiTietThucDon
    {
        private string _maThucDon;
        public string MaThucDon
        {
            get { return _maThucDon; }
            set { _maThucDon = value; }
        }

        private string _maMonAn;
        public string MaMonAn
        {
            get { return _maMonAn; }
            set { _maMonAn = value; }
        }
    }
}
