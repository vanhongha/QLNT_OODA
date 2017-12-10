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
    public partial class frmBaoCaoSucKhoe : Form
    {
        private string maTre;
        private int thang;
        private int nam;
        public frmBaoCaoSucKhoe(string maTre, int thang, int nam)
        {
            InitializeComponent();
            this.maTre = maTre;
            this.thang = thang;
            this.nam = nam;
        }

        private void frmBaoCaoSucKhoe_Load(object sender, EventArgs e)
        {
            this.getSucKhoeTheoThangTableAdapter.Fill(sucKhoeDataSet.GetSucKhoeTheoThang, maTre, thang, nam);
            this.reportViewer1.RefreshReport();
        }
        
    }
}
