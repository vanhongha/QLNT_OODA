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
    public partial class frmBienLaiHocPhi : Form
    {
        string maBienLai;

        public frmBienLaiHocPhi(string maBienLai)
        {
            InitializeComponent();
            this.maBienLai = maBienLai;
        }

        private void frmBienLaiHocPhi_Load(object sender, EventArgs e)
        {
            this.getInfoBienLaiHocPhiTableAdapter.Fill(bienLaiHocPhiDataSet.GetInfoBienlaiHocPhi, maBienLai);
            this.reportViewer1.RefreshReport();
        }
    }
}
