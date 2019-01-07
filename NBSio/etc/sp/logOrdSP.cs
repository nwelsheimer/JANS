using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using NBSio.etc.dbobj;

namespace NBSio.etc.sp
{
  public class logOrdSP : DBConn
  {
    /// <summary>
    /// Selects orders available for routing
    /// </summary>
    /// <returns>logOrdObj object</returns>
    public DataTable ViewAvailableOrders()
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("usp_log_GetOrdersForRouting", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("logOrdSP : View Available Orders \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    /// <summary>
    /// Export fleet information for routing
    /// </summary>
    /// <returns>datatable with fleet information</returns>
    public DataTable ExportFleetDetails()
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("usp_log_ExportFleetDetails", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("logOrdSP : ExportFleetDetails \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    /// <summary>
    /// Exports orders for routing
    /// </summary>
    /// <returns>Order list datatable</returns>
    public DataTable ExportStopDetails(string orderNumbers)
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("usp_log_ExportStopDetails", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = adp.SelectCommand.Parameters.Add("@orderNumbers", SqlDbType.NVarChar);
        prm.Value = orderNumbers;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("logOrdSP : ExportStopDetails \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    /// <summary>
    /// Gets the next available load number
    /// </summary>
    /// <returns>Load number string</returns>
    public String GetNextLoadNum()
    {
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("usp_log_GetNextLoadNumber", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        return cmd.ExecuteScalar().ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show("logOrdSP : GetNextLoadNum \r\n" + ex);
        return "";
      }
      finally
      {
        sqlcon.Close();
      }
    }

    public String ImportStopDetail(string orderNumbers)
    {
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("usp_log_ImportStopDetails", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = cmd.Parameters.Add("@orderNumbers", SqlDbType.NVarChar);
        prm.Value = orderNumbers;

        return cmd.ExecuteScalar().ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show("logOrdSP : ImportStopDetail \r\n" + ex);
        return "Stop file failed to import.";
      }
      finally
      {
        sqlcon.Close();
      }
    }
  }
}
