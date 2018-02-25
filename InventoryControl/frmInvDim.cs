using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using General;

namespace InventoryControl
{
  public partial class frmInvDim : Form
  {
    DataTable itemHeights = new DataTable(); //local working dataset

    public frmInvDim()
    {
      InitializeComponent();

      Global.connectToDB(); //faster method for setting up DB connectivity in JANS. Use this going forward

      cmbSelectSite.DataSource = Global.GetData("usp_SYS_GetSites").Tables[0]; //Set up site combo
      cmbSelectSite.ValueMember = "id";
      cmbSelectSite.DisplayMember = "description";
      updateGrid();
      buildDimGrid();
    }

    private void buildDimGrid()
    {
      if (grdDIM.DisplayLayout.Bands[0].Columns.Count > 0)
      {
        grdDIM.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand, true);

        grdDIM.DisplayLayout.Bands[0].Columns["prodId"].Hidden = true;
        grdDIM.DisplayLayout.Bands[0].Columns["siteId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
        grdDIM.DisplayLayout.Bands[0].Columns["prodId"].Hidden = true;
        grdDIM.DisplayLayout.Bands[0].Columns["siteId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;

        grdDIM.DisplayLayout.Bands[0].Columns["Site"].CellActivation = Activation.Disabled;
        grdDIM.DisplayLayout.Bands[0].Columns["Item Description"].CellActivation = Activation.Disabled;
        grdDIM.DisplayLayout.Bands[0].Columns["Size"].CellActivation = Activation.Disabled;
        grdDIM.DisplayLayout.Bands[0].Columns["Type"].CellActivation = Activation.Disabled;
        grdDIM.DisplayLayout.Bands[0].Columns["prodId"].CellActivation = Activation.Disabled;
        grdDIM.DisplayLayout.Bands[0].Columns["siteId"].CellActivation = Activation.Disabled;
      }
    }

  private void updateGrid()
  {
    if (cmbSelectSite.SelectedIndex>0)
      itemHeights = Global.GetData("usp_IC_SelectHeights @siteId=" + cmbSelectSite.SelectedValue.ToString()).Tables[0];
    grdDIM.DataSource = itemHeights;
  }

  private void cmbSelectSite_SelectedIndexChanged(object sender, EventArgs e)
  {
    updateGrid();
    buildDimGrid();
  }

    private void grdDIM_AfterRowUpdate(object sender, RowEventArgs e)
    {
      string prodId = e.Row.Cells["prodId"].Text;
      string siteId = e.Row.Cells["siteId"].Text;
      string defaultHeight = e.Row.Cells["Default Height"].Text;
      string currentHeight = e.Row.Cells["Current Height"].Text;

      Global.ExecuteQuery("usp_IC_UpdateHeights @prodId=" + prodId + ", @siteId=" + siteId + ", @defaultHeight=" + defaultHeight + ", @currentHeight=" + currentHeight);
    }
  }
}
