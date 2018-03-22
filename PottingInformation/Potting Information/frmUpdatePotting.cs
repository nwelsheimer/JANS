using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using General;
using Infragistics.Win;

namespace Potting_Information
{
  public partial class frmUpdatePotting : Form
  {
    string lotId;
    string siteId;
    string fromItemId;

    DataTable locations;
    DataTable pottingLog;
    DataTable inputDetail;

    public frmUpdatePotting(string LOTID, DateTime POTTEDDATE)
    {
      InitializeComponent();
      lotId = LOTID;
      dtPottedDate.Value = POTTEDDATE;
    }

    private void frmUpdatePotting_Load(object sender, EventArgs e)
    {
      lblLotId.Text = "Lot ID: " + lotId;

      DataTable itemName = Global.GetData("usp_PI_SelectUpdateSummary @lotId=" + lotId).Tables[0];
      lblItemName.Text = itemName.Rows[0]["itemDesc"].ToString() + " " + itemName.Rows[0]["sizeDesc"].ToString();
      lblFromSize.Text = "From Size: " + itemName.Rows[0]["fromSize"].ToString();
      ckComplete.Checked = Convert.ToBoolean(itemName.Rows[0]["lotComplete"] == null ? 0 : Convert.ToInt16(itemName.Rows[0]["lotComplete"].ToString()));
      siteId = itemName.Rows[0]["siteId"].ToString();
      fromItemId = itemName.Rows[0]["iFrom"].ToString();
      setupLogGrid();
      setupInputGrid();
    }

    public DateTime returnPottingDate()
    {
      return dtPottedDate.Value;
    }

    private void setupLogGrid()
    {
      locations = Global.GetData("usp_PI_SelectLocations @siteId=" + siteId).Tables[0];
      pottingLog = Global.GetData("usp_PI_SelectPottingLog @lotId=" + lotId).Tables[0];

      grdPottingDetail.DataSource = pottingLog;

      grdPottingDetail.DisplayLayout.Bands[0].Columns["locId"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown;
      grdPottingDetail.DisplayLayout.Bands[0].Columns["locId"].AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
      grdPottingDetail.DisplayLayout.Bands[0].Columns["locId"].ValueList = new BindableValueList(locations, "", "locationCode", "locId", this.grdPottingDetail);
      
      grdPottingDetail.DisplayLayout.Bands[0].Columns["id"].Hidden = true;
      grdPottingDetail.DisplayLayout.Bands[0].Columns["counted"].Hidden = true;

      grdPottingDetail.DisplayLayout.Bands[0].Columns["locId"].Header.Caption = "Set down location";
      grdPottingDetail.DisplayLayout.Bands[0].Columns["qty"].Header.Caption = "Quantity";
      
      foreach (UltraGridRow r in grdPottingDetail.Rows)
      {
        string counted = r.Cells["counted"].Value == null ? "False" : r.Cells["counted"].Value.ToString();
        if (counted == "True")
          r.Activation = Activation.NoEdit;
      }

      pottingLog.RowChanged += new DataRowChangeEventHandler(recordChanged);
    }

    private void setupInputGrid()
    {
      inputDetail = Global.GetData("usp_PI_SelectPottingInputDetail @lotId=" + lotId + ", @prodId=" + fromItemId + " , @siteId=" + siteId).Tables[0];

      grdInputItems.DataSource = inputDetail;

      grdInputItems.Columns["description"].ReadOnly = true;

      grdInputItems.Columns["id"].Visible = false;
      grdInputItems.Columns["inputLocId"].Visible = false;

      grdInputItems.Columns["qty"].HeaderText = "Quantity";
      grdInputItems.Columns["description"].HeaderText = "From Location";

      inputDetail.RowChanged += new DataRowChangeEventHandler(inputRecordChanged);
    }

    private void inputRecordChanged(object sender, DataRowChangeEventArgs e)
    {
      string rowIndex = e.Row["id"].ToString();
      string inputLocId = e.Row["inputLocId"].ToString();
      string qty = e.Row["qty"].ToString();

      if (inputLocId.Length > 0 && qty.Length > 0)
      {
        if (rowIndex.Length > 0)
        {
          Global.ExecuteQuery("usp_PI_UpdatePottingLogInputs @lotId=" + lotId + ",@locId=" + inputLocId + ", @qty=" + qty + ",@logIndex=" + rowIndex);
        }
        else
        {
          string newIndex = Global.ExecuteQueryGetId("exec usp_PI_UpdatePottingLogInputs @lotId=" + lotId + ",@locId=" + inputLocId + ",@qty=" + qty);
          e.Row["id"] = newIndex;
        }
      }
    }

    private void recordChanged(object sender, DataRowChangeEventArgs e)
    {
      string rowIndex = e.Row["id"].ToString(); //grdDriverLog.Rows[e.RowIndex].Cells["id"].Value.ToString();
      string locId = e.Row["locId"].ToString(); //grdDriverLog.Rows[e.RowIndex].Cells["locId"].Value.ToString();
      string qty = e.Row["qty"].ToString(); //grdDriverLog.Rows[e.RowIndex].Cells["qty"].Value.ToString();

      if (locId.Length > 0 && qty.Length > 0)
      {
        if (rowIndex.Length > 0)
        {
          Global.ExecuteQuery("usp_PI_UpdatePottingLog @lotId=" + lotId + ",@locId=" + locId + ", @qty=" + qty + ",@counted=0,@logIndex=" + rowIndex + ",@potDate='" + dtPottedDate.Value.ToString("yyyy/MM/dd") + "'");
        }
        else
        {
          string newIndex = Global.ExecuteQueryGetId("exec usp_PI_UpdatePottingLog @lotId=" + lotId + ",@locId=" + locId + ",@qty=" + qty + ",@potDate='" + dtPottedDate.Value.ToString("yyyy/MM/dd") + "'");
          e.Row["id"] = newIndex;
          //grdDriverLog.Rows[e.RowIndex].Cells["id"].Value = newIndex;
        }
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ckComplete_CheckedChanged(object sender, EventArgs e)
    {
      string complete = ckComplete.Checked ? "1" : "0";
      Global.ExecuteQuery("update PI_PottingLog set lotComplete="+complete+" where lotId="+lotId);
    }
  }
}
