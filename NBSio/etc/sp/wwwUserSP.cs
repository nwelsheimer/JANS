using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using NBSio.etc.dbobj;

namespace NBSio.etc.sp
{
  public class wwwUserSP : DBConn
  {
    /// <summary>
    /// Inserts new user to DB
    /// </summary>
    /// <param name="wwwUser">DB user object</param>
    public int UserAdd(wwwUserObj wwwUser)
    {
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("sp_www_UpdateUser", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = cmd.Parameters.Add("@username", SqlDbType.NVarChar);
        prm.Value = wwwUser.username;
        prm = cmd.Parameters.Add("@emailAddress", SqlDbType.NVarChar);
        prm.Value = wwwUser.emailAddress;
        prm = cmd.Parameters.Add("@password", SqlDbType.NVarChar);
        prm.Value = wwwUser.password;
        prm = cmd.Parameters.Add("@firstName", SqlDbType.NVarChar);
        prm.Value = wwwUser.firstName;
        prm = cmd.Parameters.Add("@lastName", SqlDbType.NVarChar);
        prm.Value = wwwUser.lastName;
        prm = cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar);
        prm.Value = wwwUser.phoneNumber;
        prm = cmd.Parameters.Add("@vendorId", SqlDbType.Int);
        prm.Value = wwwUser.vendorId;
        prm = cmd.Parameters.Add("@isApproved", SqlDbType.Bit);
        prm.Value = wwwUser.isApproved;
        return Convert.ToInt32(cmd.ExecuteScalar());
      } catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : userAdd \r\n" + ex);
        return 0;
      } finally
      {
        sqlcon.Close();
      }
    }

    /// <summary>
    /// Updates existing user record
    /// </summary>
    /// <param name="wwwUser">DB user object</param>
    public int UserUpdate(wwwUserObj wwwUser)
    {
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("sp_www_UpdateUser", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = cmd.Parameters.Add("@username", SqlDbType.NVarChar);
        prm.Value = wwwUser.username;
        prm = cmd.Parameters.Add("@emailAddress", SqlDbType.NVarChar);
        prm.Value = wwwUser.emailAddress;
        prm = cmd.Parameters.Add("@password", SqlDbType.NVarChar);
        prm.Value = wwwUser.password;
        prm = cmd.Parameters.Add("@firstName", SqlDbType.NVarChar);
        prm.Value = wwwUser.firstName;
        prm = cmd.Parameters.Add("@lastName", SqlDbType.NVarChar);
        prm.Value = wwwUser.lastName;
        prm = cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar);
        prm.Value = wwwUser.phoneNumber;
        prm = cmd.Parameters.Add("@vendorId", SqlDbType.Int);
        prm.Value = wwwUser.vendorId;
        prm = cmd.Parameters.Add("@isApproved", SqlDbType.Bit);
        prm.Value = wwwUser.isApproved;
        prm = cmd.Parameters.Add("@userId", SqlDbType.Int);
        prm.Value = wwwUser.userId;
        return Convert.ToInt32(cmd.ExecuteScalar());
      }
      catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : userUpdate \r\n" + ex);
        return 0;
      }
      finally
      {
        sqlcon.Close();
      }
    }

    /// <summary>
    /// Selects all users from DB
    /// </summary>
    /// <returns>wwwUser object</returns>
    public DataTable ViewAllUsers(string searchString="")
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("sp_www_SelectAllUsers", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = adp.SelectCommand.Parameters.Add("@search", SqlDbType.NVarChar);
        prm.Value = searchString;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : View all users \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    /// <summary>
    /// Selects contract grower vendors
    /// </summary>
    /// <returns>CG vendor datatable</returns>
    public DataTable ViewCGVendors()
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("sp_ic_GetCGVendors", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : ViewCGVendors \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    /// <summary>
    /// Creates dataset for excel user export
    /// </summary>
    /// <returns>Export user datatable</returns>
    public DataTable ExportUsers()
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("sp_www_SelectUserExport", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : ExportUsers \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    /// <summary>
    /// Selects customer ship to locations
    /// </summary>
    /// <returns>Customer ship to datatable</returns>
    public DataTable ViewCustomerShipTos(int userId = 0)
    {
      DataTable dt = new DataTable();
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlDataAdapter adp = new SqlDataAdapter("sp_www_SelectShipTos", sqlcon);
        adp.SelectCommand.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = adp.SelectCommand.Parameters.Add("@userId", SqlDbType.NVarChar);
        prm.Value = userId;
        adp.Fill(dt);
      }
      catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : ViewCustomerShipTos \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
      return dt;
    }

    /// <summary>
    /// Deletes a single user from the WWW table
    /// </summary>
    /// <param name="userId">User Id of the user that's being deleted</param>
    public void UserDelete(int userId)
    {
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("sp_www_DeleteUser", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = cmd.Parameters.Add("@userId", SqlDbType.Int);
        prm.Value = userId;

        cmd.ExecuteNonQuery();
      } catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : userDelete \r\n" + ex);
      } finally
      {
        sqlcon.Close();
      }
    }

    /// <summary>
    /// Imports the excel template one record at a time
    /// </summary>
    /// <param name="userName">User Id of the user that's being deleted</param>
    /// <param name="password">User Id of the user that's being deleted</param>
    /// <param name="email">User Id of the user that's being deleted</param>
    /// <param name="firstName">User Id of the user that's being deleted</param>
    /// <param name="lastName">User Id of the user that's being deleted</param>
    /// <param name="phoneNumber">User Id of the user that's being deleted</param>
    /// <param name="pbsLocation">User Id of the user that's being deleted</param>
    public void UserImport(string userName, string password, string email, string firstName, string lastName, string phoneNumber, string pbsLocation)
    {
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("sp_www_ImportUsers", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = cmd.Parameters.Add("@username", SqlDbType.NVarChar);
        prm.Value = userName;
        prm = cmd.Parameters.Add("@password", SqlDbType.NVarChar);
        prm.Value = password;
        prm = cmd.Parameters.Add("@email", SqlDbType.NVarChar);
        prm.Value = email;
        prm = cmd.Parameters.Add("@firstName", SqlDbType.NVarChar);
        prm.Value = firstName;
        prm = cmd.Parameters.Add("@lastName", SqlDbType.NVarChar);
        prm.Value = lastName;
        prm = cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar);
        prm.Value = phoneNumber;
        prm = cmd.Parameters.Add("@pbsLocation", SqlDbType.NVarChar);
        prm.Value = pbsLocation;

        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : ImportUsers \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
    }

    /// <summary>
    /// Deletes a single user from the WWW table
    /// </summary>
    /// <param name="userId">User Id of the user that's being deleted</param>
    public void VMIUserUpdate(int userId, int shipid, bool updateBit)
    {
      try
      {
        if (sqlcon.State == ConnectionState.Closed)
        {
          sqlcon.Open();
        }
        SqlCommand cmd = new SqlCommand("sp_www_UpdateVMIShipTo", sqlcon);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter prm = new SqlParameter();
        prm = cmd.Parameters.Add("@shipId", SqlDbType.Int);
        prm.Value = shipid;
        prm = cmd.Parameters.Add("@userId", SqlDbType.Int);
        prm.Value = userId;
        prm = cmd.Parameters.Add("@updateBit", SqlDbType.Int);
        prm.Value = updateBit;

        cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        MessageBox.Show("wwwUserSP : VMIUserUpdate \r\n" + ex);
      }
      finally
      {
        sqlcon.Close();
      }
    }

  }
}
