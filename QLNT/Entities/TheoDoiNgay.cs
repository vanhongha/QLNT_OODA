using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Entities
{
    class TheoDoiNgay
    {
        private string maTre;
        private string ngayDiemDanh;
        private int hienDien;
        private string nhanXet;

        public string MaTre
        {
            get
            {
                return maTre;
            }

            set
            {
                maTre = value;
            }
        }

        public string NgayDiemDanh
        {
            get
            {
                return ngayDiemDanh;
            }

            set
            {
                ngayDiemDanh = value;
            }
        }

        public int HienDien
        {
            get
            {
                return hienDien;
            }

            set
            {
                hienDien = value;
            }
        }

        public string NhanXet
        {
            get
            {
                return nhanXet;
            }

            set
            {
                nhanXet = value;
            }
        }
        public TheoDoiNgay(DataGridViewRow row)
        {
            this.maTre = row.Cells["MaTre"].ToString();
            this.ngayDiemDanh = row.Cells["Ngay"].ToString();
            this.hienDien = Int32.Parse(row.Cells["HienDien"].ToString());
            this.nhanXet = row.Cells["NhanXet"].ToString();
            
        }

        public TheoDoiNgay()
        {
        }
    }
}
