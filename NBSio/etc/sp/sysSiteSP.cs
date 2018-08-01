using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using NBSio.etc.dbobj;

namespace NBSio.etc.sp
{
  public class sysSiteSP : DBConn
  {
    /// <summary>
    /// Inserts new site to DB
    /// </summary>
    /// <param name="siteObj">DB site object</param>
    public void SiteAdd(sysSiteObj siteObj)
    {
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("usp_SYS_InsertSite", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = cmd.Parameters.Add("@description", SqlDbType.NVarChar);
        prm.Value = siteObj.description;
        prm = cmd.Parameters.Add("@address1", SqlDbType.NVarChar);
        prm.Value = siteObj.address1;
        prm = cmd.Parameters.Add("@address2", SqlDbType.NVarChar);
        prm.Value = siteObj.address2;
        prm = cmd.Parameters.Add("@city", SqlDbType.NVarChar);
        prm.Value = siteObj.city;
        prm = cmd.Parameters.Add("@state", SqlDbType.NVarChar);
        prm.Value = siteObj.state;
        prm = cmd.Parameters.Add("@zip", SqlDbType.NVarChar);
        prm.Value = siteObj.zip;
        prm = cmd.Parameters.Add("@phone", SqlDbType.NVarChar);
        prm.Value = siteObj.phone;
        prm = cmd.Parameters.Add("@managed", SqlDbType.Bit);
        prm.Value = siteObj.managed;
        prm = cmd.Parameters.Add("@dflt", SqlDbType.Bit);
        prm.Value = siteObj.dflt;
        cmd.ExecuteNonQuery();
      } catch (Exception ex)
      {
        MessageBox.Show("sysSiteSP : siteAdd \r\n" + ex);
      } finally
      {
        sqlcon.Close();
      }
    }

    /// <summary>
    /// Selects all sites with detail from DB
    /// </summary>
    /// <returns>siteObj object</returns>
    public DataTable ViewAllSites()
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("usp_SYS_SelectAllSites", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("sysSiteSP : ViewAllSites \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    public DataTable ViewSiteOnly()
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("usp_SYS_GetSites", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("sysSiteSP : ViewSiteOnly \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    public sysSiteObj GetSiteById(int _siteId)
    {
      sysSiteObj obj = new sysSiteObj();
      SqlDataReader rdr = null;
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("usp_SYS_GetSiteById", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = cmd.Parameters.Add("@siteId", SqlDbType.Int);
        prm.Value = _siteId;
        rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          obj.siteId = Convert.ToInt32(rdr["siteId"].ToString());
          obj.description = rdr["description"].ToString();
          obj.address1 = rdr["address1"].ToString();
          obj.address2 = rdr["address2"].ToString();
          obj.city = rdr["city"].ToString();
          obj.state = rdr["state"].ToString(); 
          obj.zip = rdr["zip"].ToString();
          obj.phone = rdr["phone"].ToString();
          obj.managed = Convert.ToBoolean(rdr["managed"].ToString());
          obj.dflt = Convert.ToBoolean(rdr["dflt"].ToString());
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("sysSiteSP : GetSiteById \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return obj;
    }
  }
}
