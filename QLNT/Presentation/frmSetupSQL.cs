using QLNT.DataLayer;
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
    public partial class frmSetupSQL : Form
    {
        public frmSetupSQL()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (DataAccessHelper.GetInstance().SetupSQLName(txtServerName.Text))
                KetNoiThanhCong();
            else
                KetNoiThatBai();
        }

        void KetNoiThanhCong()
        {
            MessageBox.Show("Kết nối tới SQL server thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }

        void KetNoiThatBai()
        {
            MessageBox.Show("Kết nối tới SQL server thất bại!\rXin vui lòng kiểm tra lại tên server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtServerName.Text = null;
        }
    }
}
