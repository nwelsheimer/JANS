using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBSio.etc.sp;
using NBSio.etc.dbobj;
using BCrypt.Net;

namespace Nursery_Production_Software.sysForms
{
  public partial class frmWwwUsers : DevExpress.XtraEditors.XtraForm
  {
    wwwUserObj wwwUser = new wwwUserObj();
    wwwUserSP wwwSP = new wwwUserSP();
    DataTable wwwUsersMainView;
    bool addingRow = false;

    public frmWwwUsers()
    {
      InitializeComponent();
    }

    private void frmWwwUsers_Load(object sender, EventArgs e)
    {
      //no pre-load filters. Hopefully this doesn't bite us with larger datasets
      wwwUsersMainView = wwwSP.ViewAllUsers();
      grdWwwUsers.DataSource = wwwUsersMainView;
      wwwUsersMainView.RowChanged += WwwUsersMainView_RowChanged;
      wwwUsersMainView.RowDeleted += WwwUsersMainView_RowDeleted;
    }

    private void WwwUsersMainView_RowDeleted(object sender, DataRowChangeEventArgs e)
    {
      //If it's not cancelling insert of a new row, run the delete SP
      if (!addingRow)
        wwwSP.UserDelete(Convert.ToInt32(e.Row["userId", DataRowVersion.Original]));
    }

    private void WwwUsersMainView_RowChanged(object sender, DataRowChangeEventArgs e)
    {
      //A new row was added to the dataset
      if (e.Action == DataRowAction.Add)
      { 
        addingRow = true;
        if (e.Row["username"].ToString().Length > 0 && e.Row["emailAddress"].ToString().Length > 0)
        {
          //Prompt for a password for the newly created user
          etc.passwordBox pbox = new etc.passwordBox();
          string password = pbox.Show("Enter password for user " + e.Row["username"], "Confirm Password", true, true, 6);

          if (password.Length == 0)
            e.Row.Delete();
          else
          {
            //We have the minimum information to insert a new user record
            wwwUser.clear();
            wwwUser.username = e.Row["username"].ToString();
            wwwUser.emailAddress = e.Row["emailAddress"].ToString();
            wwwUser.password = password;
            wwwUser.firstName = e.Row["firstName"].ToString();
            wwwUser.lastName = e.Row["lastName"].ToString();
            wwwUser.phoneNumber = e.Row["phoneNumber"].ToString();
            wwwUser.vendorId = 0;
            wwwUser.isApproved = Convert.ToBoolean(string.IsNullOrEmpty(e.Row["isApproved"].ToString()) ? "false" : e.Row["isApproved"]);

            e.Row["userId"] = wwwSP.UserAdd(wwwUser).ToString();
          }
        } else
        {
          e.Row.Delete();
        }
        addingRow = false;
      }

      if (e.Action == DataRowAction.Change)
      {
        MessageBox.Show("data changed" + e.Row.ItemArray[1]);
        //e.Row[3] = "we can change";
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Warning: about to delete " + gridView1.SelectedRowsCount.ToString() + " users. Continue?", "Delete users", MessageBoxButtons.OKCancel) == DialogResult.OK)
        gridView1.DeleteSelectedRows();
    }
  }
}
