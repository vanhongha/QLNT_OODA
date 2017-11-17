using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmBieuDoSucKhoe : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmBieuDoSucKhoe()
        {
            InitializeComponent();
        }

        public frmBieuDoSucKhoe(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {     
            tabControl = _tabControl;
            tab = _tab;
            InitializeComponent();
        }
    }
}
