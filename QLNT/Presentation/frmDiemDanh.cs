using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmDiemDanh : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmDiemDanh(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        public frmDiemDanh()
        {
            InitializeComponent();
        }
    }
}
