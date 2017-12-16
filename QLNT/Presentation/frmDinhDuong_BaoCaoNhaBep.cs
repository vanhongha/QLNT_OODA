using Microsoft.Reporting.WinForms;
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
    public partial class frmDinhDuong_BaoCaoNhaBep : Form
    {
        private string BuoiAD = "";
        private DateTime NgayAD = new DateTime();

        public frmDinhDuong_BaoCaoNhaBep(string buoiAD, DateTime ngayAD)
        {
            InitializeComponent();
            BuoiAD = buoiAD;
            NgayAD = ngayAD;
        }

        private void frmDinhDuong_BaoCaoNhaBep_Load(object sender, EventArgs e)
        {
            FillParameter();
            this.layDanhSachMonAnTheoBuoiTableAdapter.Fill(thucDonDataSet.LayDanhSachMonAnTheoBuoi, BuoiAD, NgayAD);
            this.layDanhSachNguyenLieuTheoBuoiTableAdapter.Fill(thucDonDataSet.LayDanhSachNguyenLieuTheoBuoi, BuoiAD, NgayAD);
            this.reportViewer1.RefreshReport();
        }

        private void FillParameter()
        {
            ReportParameter[] key = new ReportParameter[2];
            ReportParameter Buoi = new ReportParameter("Buoi", BuoiAD);
            ReportParameter Ngay = new ReportParameter("Ngay", NgayAD.ToString("dd/MM/yyyy"));
            key[0] = Buoi;
            key[1] = Ngay;

            reportViewer1.LocalReport.SetParameters(key);
        }

    }
}
