using Microsoft.Reporting.WinForms;
using QLNT.BusinessLayer;
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
    public partial class frmBaoCaoSucKhoeTheoThang : Form
    {
        private string maTre;
        private DateTime tgBatDau;
        private DateTime tgKetThuc;

        public frmBaoCaoSucKhoeTheoThang(string maTre, DateTime tgBatDau, DateTime tgKetThuc)
        {
            InitializeComponent();
            this.maTre = maTre;
            this.tgKetThuc = tgKetThuc;
            this.tgBatDau = tgBatDau;
        }

        private void frmBaoCaoSucKhoeTheoThang_Load(object sender, EventArgs e)
        {
            FillParameter();
            this.getSucKhoeTrongKhoangThoiGianTableAdapter.Fill(this.sucKhoeTheoThangDataset.GetSucKhoeTrongKhoangThoiGian, tgBatDau, tgKetThuc, maTre);
            this.reportViewer1.RefreshReport();
        }

        private void FillParameter()
        {
            ReportParameter[] key = new ReportParameter[7];
            ReportParameter ThangBatDau = new ReportParameter("ThangBatDau", tgBatDau.Month.ToString());
            ReportParameter NamBatDau = new ReportParameter("NamBatDau", tgBatDau.Year.ToString());
            ReportParameter ThangKetThuc = new ReportParameter("ThangKetThuc", tgKetThuc.Month.ToString());
            ReportParameter NamKetThuc = new ReportParameter("NamKetThuc", tgKetThuc.Year.ToString());
            ReportParameter HoTenTre = new ReportParameter("HoTenTre", TreBLL.GetTre(maTre).HoTen);
            ReportParameter GioiTinh = new ReportParameter("GioiTinh", TreBLL.GetTre(maTre).GioiTinh == 1 ? "Nam" : "Nữ");
            ReportParameter NgaySinh = new ReportParameter("NgaySinh", TreBLL.GetTre(maTre).NgaySinh.ToShortDateString());

            key[0] = ThangBatDau;
            key[1] = NamBatDau;
            key[2] = ThangKetThuc;
            key[3] = NamKetThuc;
            key[4] = HoTenTre;
            key[5] = GioiTinh;
            key[6] = NgaySinh;
            reportViewer1.LocalReport.SetParameters(key);
        }
    }
}
