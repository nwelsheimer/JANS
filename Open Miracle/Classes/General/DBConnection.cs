//This is a source code or part of Openmiracle project
//Copyright (C) 2013  Openmiracle
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using General;

//<summary>    
//Summary description for DBConnection    
//</summary>    
namespace Open_Miracle
{
  public class DBConnection
  {
    protected SqlConnection sqlcon;
    /* Old code for DBOM database credentials
	protected string serverName = (ConfigurationManager.AppSettings["MsSqlServer"] == null || ConfigurationManager.AppSettings["MsSqlServer"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlServer"].ToString();
	protected string userId = (ConfigurationManager.AppSettings["MsSqlUserId"] == null || ConfigurationManager.AppSettings["MsSqlUserId"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlUserId"].ToString();
	protected string password = (ConfigurationManager.AppSettings["MsSqlPassword"] == null || ConfigurationManager.AppSettings["MsSqlPassword"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["MsSqlPassword"].ToString();
	protected string ApplicationPath = (ConfigurationManager.AppSettings["ApplicationPath"] == null || ConfigurationManager.AppSettings["ApplicationPath"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["ApplicationPath"].ToString();
	protected string isSqlServer = (ConfigurationManager.AppSettings["isServerConnection"] == null || ConfigurationManager.AppSettings["isServerConnection"].ToString() == string.Empty) ? null : ConfigurationManager.AppSettings["isServerConnection"].ToString();
	*/
    public DBConnection()
    {
      SqlConnection.ClearAllPools();
      sqlcon = Global.extSQL("DBOpenMiracle");
      try
      {
        sqlcon.Open();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        sqlcon.Close();
      }
    }
  }
}
