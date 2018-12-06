﻿using System;
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
        SqlCommand cmd = new SqlCommand("sp_www_InsertUser", sqlcon);
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
    /// Selects all users from DB
    /// </summary>
    /// <returns>wwwUser object</returns>
    public DataTable ViewAllUsers()
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

  }
}