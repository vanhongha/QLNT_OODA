using DevComponents.DotNetBar;
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
    public partial class frmThongTinSucKhoe : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmThongTinSucKhoe()
        {
            InitializeComponent();
        }

        public frmThongTinSucKhoe(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
