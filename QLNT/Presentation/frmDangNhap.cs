using QLNT.BusinessLayer;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            labStatus.Visible = false;
        }

        void DangNhap()
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text) && !string.IsNullOrEmpty(txtMatKhau.Text))
            {
                if (DangNhapBLL.XemDL("*", txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim()).Rows.Count != 0)
                {
                    frmMain formMain = new frmMain();
                    frmMain.Quyen = (Quyen)Enum.Parse(typeof(Quyen), DangNhapBLL.XemDL("QUYEN", txtTaiKhoan.Text, txtMatKhau.Text).Rows[0][0].ToString());
                    this.Hide();
                    formMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    labStatus.Visible = true;
                    txtMatKhau.Clear();
                }
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '•';
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.TextLength != 0)
                labStatus.Visible = false;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DangNhap();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.TextLength != 0)
                labStatus.Visible = false;
        }
    }
}
