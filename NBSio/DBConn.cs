///-----------------------------------------------------------------
///   Description:    Database connection class
///   Author:         NDW                    Date: 7/27/2018
///   Notes:          
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NBSio
{
  public class DBConn
  {
    protected SqlConnection sqlcon = global5k.extSQL();

    public DBConn()
    {
      SqlConnection.ClearAllPools();

      try
      {
        sqlcon.Open();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
