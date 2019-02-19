using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NBSio.etc.sp;
using NBSio.etc.dbobj;
using Nursery_Production_Software.etc;

namespace Nursery_Production_Software.sysForms
{
  public partial class frmWwwUsers : DevExpress.XtraEditors.XtraForm
  {
    wwwUserObj wwwUser = new wwwUserObj();
    wwwUserSP wwwSP = new wwwUserSP();
    DataTable wwwUsersMainView;
    DataTable stList;
    bool addingRow = false;
    int rightClickedRowId;
    int leftClickedRowId;
    int rowId=-1;

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

      //Create store lookup grid
      DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit storeLookup = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
      stList = wwwSP.ViewCustomerShipTos();
      grdShipTos.DataSource = stList;
      gvShipTos.BestFitColumns();
      storeLookup.PopupControl = popStoreList;

      //Bind store lookup grid to column
      DevExpress.XtraGrid.Columns.GridColumn shipTos = new DevExpress.XtraGrid.Columns.GridColumn();
      shipTos.Caption = "Locations";
      shipTos.Name = "ShipTos";
      shipTos.FieldName = "ShipTos";
      shipTos.Visible = true;

      shipTos.ColumnEdit = storeLookup;

      //and bind the lookup to the grid
      gvWWWUsers.Columns["vendorName"].ColumnEdit = lk;
      gvWWWUsers.Columns.Add(shipTos);
      gvWWWUsers.BestFitColumns();
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
      if (MessageBox.Show("Warning: About to delete " + gvWWWUsers.SelectedRowsCount.ToString() + " users. Continue?", "Delete users", MessageBoxButtons.OKCancel) == DialogResult.OK)
        gvWWWUsers.DeleteSelectedRows();
    }

    private int GetRowAt(NBSGridView view, Point p)
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
        int rowId = GetRowAt(gvWWWUsers, p);
        if (rowId>=0)
        {
          rightClickedRowId = rowId;
          popGrid1.ShowPopup(Cursor.Position);
        }
      } else
      {
        leftClickedRowId = -1;
        Point p = new Point(e.X, e.Y);
        int rowId = GetRowAt(gvWWWUsers, p);
        if (rowId >= 0)
          leftClickedRowId = rowId;
      }
    }

    private void btnDeleteUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (MessageBox.Show("Are you sure you want to delete user " + gvWWWUsers.GetRowCellValue(rightClickedRowId, "username").ToString() + "?", "Confirm delete users", MessageBoxButtons.OKCancel)==DialogResult.OK)
      {
        gvWWWUsers.DeleteRow(rightClickedRowId);
      }
    }

    private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      etc.passwordBox pbox = new etc.passwordBox();
      string password = pbox.Show("New password for " + gvWWWUsers.GetRowCellValue(rightClickedRowId, "username"), "Confirm Password", true, true, 6);

      if (password.Length > 0)
      {
        wwwUser.clear();
        wwwUser.userId = Convert.ToInt32(gvWWWUsers.GetRowCellValue(rightClickedRowId, "userId"));
        wwwUser.password = password;
        wwwSP.UserUpdate(wwwUser);

        MessageBox.Show("Password updated!");
      }

    }

    private void popStoreList_Paint(object sender, PaintEventArgs e)
    {
      rowId = leftClickedRowId;

      lblStoreNum.Text = "Editing user: " + gvWWWUsers.GetRowCellValue(rowId, "username");
      stList = wwwSP.ViewCustomerShipTos(Convert.ToInt32(gvWWWUsers.GetRowCellValue(rowId, "userId")));
      grdShipTos.DataSource = stList;
      gvShipTos.Columns[1].OptionsColumn.AllowEdit = false;
      gvShipTos.Columns[2].OptionsColumn.AllowEdit = false;
      gvShipTos.Columns[3].OptionsColumn.AllowEdit = false;
    }

    private void gvShipTos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      if (e.RowHandle>=0)
        wwwSP.VMIUserUpdate(Convert.ToInt32(gvWWWUsers.GetRowCellValue(rowId, "userId")), Convert.ToInt32(gvShipTos.GetRowCellValue(e.RowHandle, "ShipId")), Convert.ToBoolean(e.Value));
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      //get file name to save the spreadsheet
      string filename = NBSio.xl4k.getFilePath(1, DateTime.Now.ToString("MM-dd-yyyy")+" User Template");
      //create master dataset for export 
      DataSet userExport = new DataSet();
      //add user dataset
      DataTable userlist = wwwSP.ExportUsers();
      userlist.TableName = "UserList";
      userExport.Tables.Add(userlist);
      //add ship to dataset
      stList.TableName = "ShipToList";
      userExport.Tables.Add(stList);


      if (NBSio.xl4k.basicExcelExport(userExport, filename))
        MessageBox.Show("Export Complete");
    }

    private void btnImport_Click(object sender, EventArgs e)
    {

    }
  }
}
