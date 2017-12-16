using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmDinhDuong_BaoCaoSuatAn : Form
    {
        private string MaLop = "";
        private string BuoiAD = "";
        private DateTime NgayAD = new DateTime();
        public frmDinhDuong_BaoCaoSuatAn(string maLop,string buoiAD, DateTime ngayAD)
        {
            InitializeComponent();
            MaLop = maLop;
            BuoiAD = buoiAD;
            NgayAD = ngayAD;
        }

        private void frmDinhDuong_BaoCaoSuatAn_Load(object sender, EventArgs e)
        {
            this.layDanhSachThongTinSuatAnTheoLopTableAdapter.Fill(thucDonDataSet.LayDanhSachThongTinSuatAnTheoLop, MaLop, BuoiAD, NgayAD);
            this.reportViewer1.RefreshReport();
        }
    }
}
