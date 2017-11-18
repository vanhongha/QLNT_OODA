using QLNT.BusinessLayer;
using QLNT.Entities;
using System.Windows.Forms;

namespace QLNT.Ultilities
{
    class ComboboxLoad
    {
        public static void NienKhoa(ComboBox cbo)
        {
            cbo.Items.Clear();
            cbo.DisplayMember = "Text";
            cbo.ValueMember = "Value";

            foreach (NamHoc namHoc in LopBLL.GetListNienKhoa())
                cbo.Items.Add(new { Text = namHoc.NienKhoa.Trim(), Value = namHoc.MaNamHoc.Trim() });            
        }

        public static void LoaiLop(ComboBox cbo)
        {
            cbo.Items.Clear();
            cbo.DisplayMember = "Text";
            cbo.ValueMember = "Value";

            foreach (LoaiLop loaiLop in LopBLL.GetListLoaiLop())
                cbo.Items.Add(new { Text = loaiLop.TenLoaiLop.Trim(), Value = loaiLop.MaLoaiLop.Trim() });            
        }

        public static void Lop(ComboBox cbo, ComboBox cboNamHoc, ComboBox cboLoaiLop)
        {
            cbo.Items.Clear();
            cbo.DisplayMember = "Text";
            cbo.ValueMember = "Value";
            if (cboNamHoc.SelectedItem != null && cboLoaiLop.SelectedItem != null)
                foreach (Lop lop in LopBLL.GetListLop(KeyHandle.GetKeyFromCombobox(cboNamHoc.SelectedItem.ToString()),
                    KeyHandle.GetKeyFromCombobox(cboLoaiLop.SelectedItem.ToString())))
                    cbo.Items.Add(new { Text = lop.TenLop.Trim(), Value = lop.MaLop.Trim() });
            
            cbo.Text = "";
        }
    }
}
