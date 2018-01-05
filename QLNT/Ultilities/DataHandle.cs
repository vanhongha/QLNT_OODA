using QLNT.BusinessLayer;
using QLNT.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace QLNT.Ultilities
{
    struct ThangNam
    {
        public int thang;
        public int nam;
    }

    class DataHandle
    {
        public static DataTable ReadDataFromExcelFile(string filePath)
        {
            //string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath.Trim() + ";Extended Properties=Excel 8.0";
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
              "Data Source=" + filePath + ";" +
              "Extended Properties=Excel 8.0;";
            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connectionString);
            DataTable data = null;
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();

                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);

                data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // Đóng chuỗi kết nối
                oledbConn.Close();
            }
            return data;
        }

        public static void ThemTreVaoDBTuExcel(DataTable data)
        {
            if (data == null || data.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để import");
                return;
            }
            try
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    Tre tre = new Tre(TreBLL.GenMaTre().ToString(),
                        data.Rows[i][0].ToString().Trim(),  // Họ tên
                        Convert.ToInt32(data.Rows[i][1].ToString()),   // Giới tính,
                        DateTime.Parse(data.Rows[i][2].ToString().Trim()), // Ngày sinh
                        data.Rows[i][3].ToString().Trim(),  // Họ tên cha
                        data.Rows[i][4].ToString().Trim(),  // Họ tên mẹ
                        data.Rows[i][5].ToString().Trim(),  // Địa chỉ
                        data.Rows[i][6].ToString().Trim()); // SĐT

                    try
                    {
                        TreBLL.ThemTre(tre);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                MessageBox.Show("Import hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        // Lưu lại 1 hoặc nhiều trẻ được chọn từ datagridview
        public static List<string> SaveListMaTre(DataGridView dgv)
        {
            List<string> listMaTre = new List<string>();
            List<DataGridViewRow> selectedRows = dgv.SelectedRows
                     .OfType<DataGridViewRow>()
                     .Where(row => !row.IsNewRow)
                     .ToList();
            List<DataGridViewCell> selectedCells = dgv.SelectedCells.OfType<DataGridViewCell>().ToList();

            foreach (DataGridViewCell cell in selectedCells)
            {
                if (!selectedRows.Contains(dgv.Rows[cell.RowIndex]))
                    selectedRows.Add(dgv.Rows[cell.RowIndex]);
            }

            foreach (DataGridViewRow row in selectedRows)
                if (!listMaTre.Contains(row.Cells["MaTre"].Value.ToString()))
                    listMaTre.Add(row.Cells["MaTre"].Value.ToString());
            return listMaTre;
        }

        public static DataTable ListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public static List<ThangNam> GetThoiGianTrongKhoan(DateTime start, DateTime end)
        {
            int tempThang = 0;
            int tempNam = 0;
            ThangNam tempThangNam;
            DateTime runningDate = start;
            List<ThangNam> listThangNam = new List<ThangNam>();

            while(runningDate < end.AddMonths(1))
            {
                tempThang = runningDate.Month;
                tempNam = runningDate.Year;
                tempThangNam.thang = tempThang;
                tempThangNam.nam = tempNam;
                listThangNam.Add(tempThangNam);

                runningDate = runningDate.AddMonths(1);
            }

            return listThangNam;
        }
    }
}
