using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace Nursery_Production_Software
{
    class dbio
    {
        #region Public Properties
        public static string
            SQLCON,
            validEmail = @"\w{1,}[@][\w\-]{1,}([.]([\w\-]{1,}))+$",
            validPhone = @"^(\d{3})?\d{7}";
        #endregion
        #region Private Properties
        private static NpgsqlConnection conn = null; //The connection to the database server that everything should flow through
        #endregion

        #region Public Data Functions
        public static bool ConnectToDB(string server, string db, string username, string password, string port = "4532")
        {
            SQLCON = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                        server, port, username, password, db);
            try
            {
                return CheckConnection();
            } catch
            {
                return false;
            }

        }

        public static DataSet GetData(string query)
        {
            CheckConnection();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch (NpgsqlException sqlX)
            {
                //com.Connection.Close();
                MessageBox.Show("SQL Error occurred:\n" + sqlX.Message + "\n\nSQL: " + query, "SQL Error", MessageBoxButtons.OK);
                return null;
            }
            catch (Exception X)
            {
                //com.Connection.Close();
                MessageBox.Show("Unknown error occurred:\n" + X.Message, "General Error", MessageBoxButtons.OK);
                return null;
            }
            return ds;
        }
        #endregion

        #region Private Functions
        private static bool CheckConnection()
        {
            if (conn == null)
            {
                try
                {
                    conn = new NpgsqlConnection(SQLCON);
                    conn.Open();
                    return true;
                }
                catch (NpgsqlException sqlX)
                {
                    //com.Connection.Close();
                    MessageBox.Show("SQL Error occurred:\n" + sqlX.Message);
                    conn.Close();
                    conn = null;
                    return false;
                }
                catch (Exception X)
                {
                    //com.Connection.Close();
                    MessageBox.Show("Unknown error occurred:\n" + X.Message, "General Error");
                    conn.Close();
                    conn = null;
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
