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
    public partial class frmTiepNhan : UserControl
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;
        public frmTiepNhan()
        {
            InitializeComponent();
        }
        public frmTiepNhan(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
