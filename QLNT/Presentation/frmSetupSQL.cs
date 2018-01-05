using QLNT.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT.Presentation
{
    public partial class frmSetupSQL : Form
    {
        static string fileName = @"\sql.txt";
        string path = Directory.GetCurrentDirectory() + fileName;

        public frmSetupSQL()
        {
            InitializeComponent();
            FillSQLName();
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

            if(ExistFile())
            {
                string[] sqlName = new string[1];
                sqlName[0] = txtServerName.Text;
                File.WriteAllLines(path, sqlName);
            }
            else
            {
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(txtServerName.Text);

                    fs.Write(info, 0, info.Length);
                }
            }
            this.Hide();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            this.Close();
        }

        void KetNoiThatBai()
        {
            MessageBox.Show("Kết nối tới SQL server thất bại!\rXin vui lòng kiểm tra lại tên server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtServerName.Text = null;
        }

        void FillSQLName()
        {            
            if (File.Exists(path))
                txtServerName.Text = File.ReadLines(path).First();
        }

        bool ExistFile()
        {
            return File.Exists(path);
        }
    }
}
