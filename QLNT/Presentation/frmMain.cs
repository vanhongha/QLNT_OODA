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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        public bool CheckOpenedTabs(string name)
        {
            for (int i = 0; i < tabControl.Tabs.Count; i++)
            {
                if (tabControl.Tabs[i].Text == name)
                {
                    tabControl.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void btnSucKhoe_ThongTin_Click(object sender, EventArgs e)
        {
            if (!CheckOpenedTabs("Thông tin sức khỏe"))
            {
                TabItem tab = tabControl.CreateTab("Thông tin sức khỏe");
                tab.PredefinedColor = eTabItemColor.Yellow;
                frmThongTinSucKhoe _frmThongTinSucKhoe = new frmThongTinSucKhoe(tabControl, tab);
                _frmThongTinSucKhoe.TopLevel = false;
                _frmThongTinSucKhoe.Dock = DockStyle.Fill;
                _frmThongTinSucKhoe.StartPosition = FormStartPosition.CenterParent;
                tab.AttachedControl.Controls.Add(_frmThongTinSucKhoe);
                _frmThongTinSucKhoe.Show();
                tabControl.SelectedTabIndex = tabControl.Tabs.Count - 1;
            }
            else
                tabControl.TabIndex = tabControl.Tabs.Count - 1;
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
