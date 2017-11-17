using System;

namespace QLNT.Entities
{
    class SucKhoe
    {

        private string maTre;

        public string MaTre
        {
            get { return maTre; }
            set { maTre = value; }
        }

        private int thang;

        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }

        private int nam;

        public int Nam
        {
            get { return nam; }
            set { nam = value; }
        }


        private string hoTenTre;
        
        public string HoTenTre
        {
            get { return hoTenTre; }
            set { hoTenTre = value; }
        }

        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }


        private float canNang;

        public float CanNang
        {
            get { return canNang; }
            set { canNang = value; }
        }

        private float chieuCao;

        public float ChieuCao
        {
            get { return chieuCao; }
            set { chieuCao = value; }
        }

        private float bmi;

        public float BMI
        {
            get { return bmi; }
            set { bmi = value; }
        }

        private string tinhTrang;

        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public SucKhoe(System.Data.DataRow row)
        {
            this.maTre = row["MaTre"].ToString();
            this.thang = int.Parse(row["Thang"].ToString());
            this.nam = int.Parse(row["Nam"].ToString());
            this.hoTenTre = row["HoTenTre"].ToString();
            this.gioiTinh = row["GioiTinh"].ToString();
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.chieuCao = float.Parse(row["ChieuCao"].ToString());
            this.canNang = float.Parse(row["CanNang"].ToString());
            this.bmi = float.Parse(row["BMI"].ToString());
            this.ghiChu = row["GhiChu"].ToString();
        }

        public SucKhoe()
        {
        }
    }
}
