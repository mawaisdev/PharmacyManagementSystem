using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    internal class ManageDatabase
    {
        protected SqlConnection GetConnection() 
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"data source = AWAIS\SQLEXPRESS;database=Pharmacy;integrated security = true;";

            return conn;
        }

        public DataSet GetData(string Query)
        {
            var conn = GetConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = Query;
            var DataAdapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            DataAdapter.Fill(ds);

            return ds;
        }

        public void SetData(string Query, string Message)
        {
            var conn = GetConnection();
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(Message,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
