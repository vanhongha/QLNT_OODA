﻿using DevComponents.DotNetBar;
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
    public partial class frmThuHocPhi : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmThuHocPhi(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmThuHocPhi_Load(object sender, EventArgs e)
        {

        }
    }
}
