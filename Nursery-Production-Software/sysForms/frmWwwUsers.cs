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
using Nursery_Production_Software.etc;
using BCrypt.Net;

namespace Nursery_Production_Software.sysForms
{
  public partial class frmWwwUsers : DevExpress.XtraEditors.XtraForm
  {
    wwwUserObj wwwUser = new wwwUserObj();
    wwwUserSP wwwSP = new wwwUserSP();
    DataTable wwwUsersMainView;
    bool addingRow = false;
    int rightClickedRowId;

    public frmWwwUsers()
    {
      InitializeComponent();
    }

    private void frmWwwUsers_Load(object sender, EventArgs e)
    {
      buildGrid();

      //Events to hand data changes
      wwwUsersMainView.RowChanged += WwwUsersMainView_RowChanged;
      wwwUsersMainView.RowDeleted += WwwUsersMainView_RowDeleted;
    }

    private void buildGrid()
    {
      //no pre-load filters. Hopefully this doesn't bite us with larger datasets
      wwwUsersMainView = wwwSP.ViewAllUsers();
      grdWwwUsers.DataSource = wwwUsersMainView;

      //create contract grower lookup
      DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lk = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      DataTable cgList = wwwSP.ViewCGVendors();
      lk.DataSource = cgList.DefaultView;
      lk.ValueMember = "vendorId";
      lk.DisplayMember = "vendorName";

      lk.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
      lk.DropDownRows = cgList.DefaultView.Count;
      lk.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
      lk.NullText = "";

      //and bind the lookup to the grid
      gridView1.Columns["vendorName"].ColumnEdit = lk;
      gridView1.BestFitColumns();
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
            wwwUser.vendorId = Convert.ToInt32(string.IsNullOrEmpty(e.Row["vendorName"].ToString()) ? "0" : e.Row["vendorName"].ToString());
            wwwUser.isApproved = Convert.ToBoolean(string.IsNullOrEmpty(e.Row["isApproved"].ToString()) ? "false" : e.Row["isApproved"]);

            e.Row["userId"] = wwwSP.UserAdd(wwwUser).ToString();
          }
        } else
        {
          e.Row.Delete();
        }
        addingRow = false;
      }

      if (e.Action == DataRowAction.Change && !addingRow)
      {
        wwwUser.clear();
        wwwUser.userId = Convert.ToInt32(string.IsNullOrEmpty(e.Row["userId"].ToString()) ? "0" : e.Row["userId"].ToString());
        wwwUser.username = e.Row["username"].ToString();
        wwwUser.emailAddress = e.Row["emailAddress"].ToString();
        wwwUser.password = "";
        wwwUser.firstName = e.Row["firstName"].ToString();
        wwwUser.lastName = e.Row["lastName"].ToString();
        wwwUser.phoneNumber = e.Row["phoneNumber"].ToString();
        wwwUser.vendorId = Convert.ToInt32(string.IsNullOrEmpty(e.Row["vendorName"].ToString()) ? "0" : e.Row["vendorName"].ToString());
        wwwUser.isApproved = Convert.ToBoolean(string.IsNullOrEmpty(e.Row["isApproved"].ToString()) ? "false" : e.Row["isApproved"]);

        if (wwwUser.userId > 0)
          wwwSP.UserUpdate(wwwUser);
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Warning: about to delete " + gridView1.SelectedRowsCount.ToString() + " users. Continue?", "Delete users", MessageBoxButtons.OKCancel) == DialogResult.OK)
        gridView1.DeleteSelectedRows();
    }

    private int GetRowAt(MyGridView view, Point p)
    {
      int hitinfo = -1;
      hitinfo = view.CalcHitInfo(p).RowHandle;
      return hitinfo;
    }

    private void grdWwwUsers_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        rightClickedRowId = -1;
        Point p = new Point(e.X, e.Y);
        int rowId = GetRowAt(gridView1, p);

        if (rowId>=0)
        {
          rightClickedRowId = rowId;
          popGrid1.ShowPopup(p);
        }
      }
    }

    private void btnDeleteUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      MessageBox.Show("Delete user " + rightClickedRowId.ToString());
    }
  }
}
