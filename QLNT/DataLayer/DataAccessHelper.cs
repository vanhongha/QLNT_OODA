using System;
using System.Data;
using System.Data.SqlClient;


namespace QLNT.DataLayer
{

    class DataAccessHelper
    {
        #region Data access properties
        SqlConnection con;
        SqlCommand cmd;
        string connectionString;
        DataTable dt;

        static DataAccessHelper instance;
        #endregion

        #region Init properties
        public static DataAccessHelper GetInstance()
        {
            if (instance == null)
                instance = new DataAccessHelper();
            return instance;
        }

        public DataAccessHelper()
        {
            //con = new System.Data.SqlClient.SqlConnection();
            //con.ConnectionString = "Server=.\\SQLEXPRESS; AttachDbFilename = QLNT.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //con.Open();Server=.\SQLExpress;AttachDbFilename=|DataDirectory|\\hotel.mdf;
            //connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QLNT;Data Source=DESKTOP-EMQJODI\HONGHA";
            //String connectionString = @"Server=.\SQLExpress;AttachDbFilename=|DataDirectory|QLNT.mdf;Database=dbname; Trusted_Connection=Yes;";
         
        }
        #endregion

        #region Procceed with database
        public void Open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public DataTable GetDataTable(string select)
        {
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetDataTable()
        {
            return dt;
        }

        public void SetDataTable(DataTable dt)
        {
            this.dt = dt;
        }

        public bool SetupSQLName(string name)
        {
            string prefix = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QLNT;Data Source=";
            connectionString = prefix + name;
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public SqlCommand Command(String commandString)
        {
            this.cmd = new SqlCommand(commandString, con);
            return cmd;
        }
        #endregion


    }
}
