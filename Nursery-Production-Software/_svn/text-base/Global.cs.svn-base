using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Nursery_Production_Software
{
    public static class Global
    {
        #region Class Scope Variables

        private static SqlConnection sqlConn = new SqlConnection(GetConnectionString());

        #endregion

        #region Public Functions

        public static bool ExecuteQuery(string query)
        {
            SqlCommand com = new SqlCommand(query, sqlConn);
            com.Connection.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                com.Connection.Close();
                return false;
            }
            com.Connection.Close();
            return true;
        }

        public static DataSet GetData(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch (Exception)
            {
                return ds;
            }
            return ds;
        }

        #endregion

        #region Private Functions

        private static string GetConnectionString()
        {
            try
            {
                //using (System.IO.StreamReader sr = new System.IO.StreamReader("required.settings"))
                //{
                //    string retval = sr.ReadLine();
                string retval;
                    retval = "Data Source=sql1.vision.local;Initial Catalog=MSVision;User ID=sa;Password='122lake';";
                    return retval;
                //}
            }
            catch (Exception ex)
            {
                //run setup wizard
                return "ERROR " + ex.Message;
            }
        }

        #endregion
    }
}
