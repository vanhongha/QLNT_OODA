using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Entities
{
    class MonAn
    {
        private string _maMonAn;
        public string MaMonAn
        {
            get { return _maMonAn; }
            set { _maMonAn = value; }
        }

        private string _tenMonAn;
        public string TenMonAn
        {
            get { return _tenMonAn; }
            set { _tenMonAn = value; }
        }

        public MonAn() { }
        
        public MonAn(string maMonAn, string tenMonAn)
        {
            _maMonAn = maMonAn;
            _tenMonAn = tenMonAn;
        }
    }
}
