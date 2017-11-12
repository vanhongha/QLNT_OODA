using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLNT.Presentation
{
    public partial class frmDiemDanh : UserControl
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        public frmDiemDanh()
        {
            InitializeComponent();
        }
        public frmDiemDanh(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
