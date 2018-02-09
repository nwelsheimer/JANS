using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using General;

namespace RackOptimizer
{
  public partial class frmRackOptimize : Form
  {
    DataTable rackAnalysisSummary = new DataTable();
    DataTable storeRackInfo = new DataTable();
    DataTable sessionInventory = new DataTable();
    DataTable rackRounding = new DataTable();
    DataTable partialShelves = new DataTable();
    
    int totalRackRound = 0;
    string sessionId = "";

    #region Grid and form init
    public frmRackOptimize()
    {
      InitializeComponent();
      Global.connectToDB();
    }

    private void frmRackOptimize_Load(object sender, EventArgs e)
    {
      cmbSession.ValueMember = "id";
      cmbSession.DisplayMember = "sessionName";
      cmbSession.DataSource = Global.GetData("usp_RO_SelectSessionNames").Tables[0].DefaultView;
    }

    private void grdPartialShelves_InitializeLayout(object sender, InitializeLayoutEventArgs e)
    {
      e.Layout.Override.FilterUIProvider = this.fltShelvesProvider;
    }

    private void grdStoreRacks_InitializeLayout(object sender, InitializeLayoutEventArgs e)
    {
      e.Layout.Override.FilterUIProvider = this.fltShelvesProvider;
    }

    private void grdSessionInventory_InitializeLayout(object sender, InitializeLayoutEventArgs e)
    {
      e.Layout.Override.FilterUIProvider = this.fltShelvesProvider;
    }

    private void grdRackOptimize_InitializeLayout(object sender, InitializeLayoutEventArgs e)
    {
      e.Layout.Override.FilterUIProvider = this.fltShelvesProvider;
    }
    #endregion
    #region Data handling
    private void refreshRackData()
    {
      if (totalRackRound>0) //Only run this code if racks have been built
      {
        storeRackInfo = Global.GetData("usp_RO_SelectStoreRacks @sessionId=" + sessionId).Tables[0];
        storeRackInfo.Columns.Add("NewRacks");
        grdStoreRacks.DataSource = storeRackInfo.DefaultView;
        formatStoreGrid();

        sessionInventory = Global.GetData("usp_RO_SelectSessionInventory @sessionId=" + sessionId).Tables[0];
        grdSessionInventory.DataSource = sessionInventory.DefaultView;
        formatInventoryGrid();

        pnlRackWarning1.Visible = false;
      } else
      {
        storeRackInfo.Clear();
        sessionInventory.Clear();

        pnlRackWarning1.Visible = true;
      }
    }

    private void refreshRoundingData()
    {
      rackRounding = Global.GetData("usp_RO_SelectRackOptimize @sessionId="+sessionId+", @threshold="+txtThreshold.Text).Tables[0];

      grdRackOptimize.DataSource = rackRounding.DefaultView;

      string shipId;
      string newRacks="";
      foreach (DataRow dr in storeRackInfo.Rows)
      {
        shipId = dr["shipId"].ToString();
        foreach (DataRow rr in rackRounding.Rows)
        {
          if (rr["shipId"].ToString() == shipId)
            newRacks = rr["PredictedRacks"].ToString();
        }
        dr["NewRacks"] = newRacks;
        newRacks = "";
        shipId = "";
      }
    }

    private Boolean refreshRackAnalysis()
    {
      rackAnalysisSummary = Global.GetData("usp_RO_SelectRackAnalysis @sessionId=" + sessionId).Tables[0];

      if (rackAnalysisSummary.Rows.Count > 0)
      {
        //Summary information
        totalRackRound = Convert.ToInt32(rackAnalysisSummary.Rows[0]["Total"].ToString());
        lblTotalStores.Text = rackAnalysisSummary.Rows[0]["StoreCount"].ToString();
        lblPartialShelves.Text = rackAnalysisSummary.Rows[0]["PartialShelves"].ToString();
        lblRoundUp.Text = totalRackRound > 0 ? rackAnalysisSummary.Rows[0]["RoundUp"].ToString() : "N/A";
        lblRoundDown.Text = totalRackRound > 0 ? rackAnalysisSummary.Rows[0]["RoundDown"].ToString() : "N/A";

        //Rack Rounding Summary
        lblRack1.Text = totalRackRound > 0 ? rackAnalysisSummary.Rows[0][".1"].ToString() : "N/A";
        lblRack2.Text = totalRackRound > 0 ? rackAnalysisSummary.Rows[0][".2"].ToString() : "N/A";
        lblRack3.Text = totalRackRound > 0 ? rackAnalysisSummary.Rows[0][".3"].ToString() : "N/A";
        lblRack4.Text = totalRackRound > 0 ? rackAnalysisSummary.Rows[0][".4"].ToString() : "N/A";
        lblRack5.Text = totalRackRound > 0 ? rackAnalysisSummary.Rows[0][".5"].ToString() : "N/A";
        lblRack6.Text = totalRackRound > 0 ? rackAnalysisSummary.Rows[0][".6"].ToString() : "N/A";

        return true;
      }
      else
        return false;
    }

    private void refreshData()
    {
      sessionId = cmbSession.SelectedValue.ToString();

      if (refreshRackAnalysis())
      {
        partialShelves = Global.GetData("usp_RO_SelectPartialShelves @sessionId=" + sessionId).Tables[0];
        partialShelves.Columns.Add("Incomplete");
        partialShelves.Columns.Add("NewQty");

        string sizeCode = "";
        int qtyRemain = 0;
        int available = 0;
        double partial = 0.0;
        int suggested;
        string prodId = "";
        string store = "";
        bool noneNeeded = false;

        foreach (DataRow dr in partialShelves.Rows)
        {
          suggested = 0;
          available = (int)Convert.ToDouble(dr["Available"].ToString());
          prodId = dr["prodId"].ToString();

          if (dr["sizeGroup"].ToString() != sizeCode || dr["Store"].ToString() != store)
          { //New size group or store
            sizeCode = dr["SizeGroup"].ToString();
            store = dr["Store"].ToString();
            qtyRemain = (int)Convert.ToDouble(dr["UnitsNeeded"].ToString());
            noneNeeded = qtyRemain == 0 ? true : false;
            partial = Convert.ToDouble(dr["ShelfRound"].ToString());
          }

          if (noneNeeded)
            if((int)Convert.ToDouble(dr["UnitsNeeded"].ToString())>0)
            {
              qtyRemain = (int)Convert.ToDouble(dr["UnitsNeeded"].ToString());
              noneNeeded = false;
            }

            //Add negative signs to round down 'units needed' --NDW 1/10/2018
            if (partial <= .4)
            dr["UnitsNeeded"] = (int)Convert.ToDouble(dr["UnitsNeeded"].ToString())*-1;

          if (qtyRemain > 0)
          {
            if (partial <= .4)
            {
              suggested = qtyRemain * -1;
              //update available qty
              recalculateAvailableShelf(qtyRemain, available, prodId);

              qtyRemain = 0;
            }
            else
            {
              if (available > 0)
              {
                suggested = available >= qtyRemain ? qtyRemain : available;
                qtyRemain -= suggested;
                //update available
                recalculateAvailableShelf(suggested * -1, available, prodId);
              }
              else
                dr["Incomplete"] = "1";
            }
          }
          dr["SuggestedQty"] = suggested.ToString();
        }

        recalculateAvailableShelf(0, 0, "0");
        grdPartialShelves.DataSource = partialShelves.DefaultView;
        filterZeroPartials();

        formatShelvesGrid();

        refreshRackData();
      }
      else
      {
        storeRackInfo.Clear();
        sessionInventory.Clear();
        rackRounding.Clear();
        partialShelves.Clear();
      }
    }
#endregion
    #region Grid Building
    private void formatShelvesGrid()
    {
      grdPartialShelves.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand, true);
     
      //Load user preferances
      Global.GridLayout(grdPartialShelves, 2, Properties.Settings.Default.partialShelvesLayout);

      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeGroup"].Hidden = true;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeGroup"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["ShelfRound"].Hidden = true;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["ShelfRound"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["replId"].Hidden = true;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["replId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["prodId"].Hidden = true;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["prodId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Incomplete"].Hidden = true;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Incomplete"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;

      grdPartialShelves.DisplayLayout.Bands[0].Columns["Store"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["custom4"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["custom3"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SKUDescription"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeDescription"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["TotalShelves"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["TotalRacks"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["PartialShelves"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["UnitsNeeded"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeGroup"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Requested"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Available"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Incomplete"].CellActivation = Activation.Disabled;

      grdPartialShelves.DisplayLayout.Bands[0].Columns["TotalShelves"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["PartialShelves"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["UnitsNeeded"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Requested"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Available"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SuggestedQty"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["NewQty"].Format = "n0";

      grdPartialShelves.DisplayLayout.Bands[0].Columns["SuggestedQty"].MaskInput = "{double:-5.0}";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["NewQty"].MaskInput = "{double:-5.0}";

      grdPartialShelves.DisplayLayout.Bands[0].Columns["Store"].Header.Caption = "Store Number";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["custom4"].Header.Caption = "Rank";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["custom3"].Header.Caption = "Zone";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SKUDescription"].Header.Caption = "SKU Description";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeDescription"].Header.Caption = "Size Description";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["TotalShelves"].Header.Caption = "Total Shelves";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["TotalRacks"].Header.Caption = "Total Racks";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["PartialShelves"].Header.Caption = "Partial Shelves";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["UnitsNeeded"].Header.Caption = "Units Needed";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Available"].Header.Caption = "Available";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SuggestedQty"].Header.Caption = "Suggested Change";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["NewQty"].Header.Caption = "New Qty";

      grdPartialShelves.DisplayLayout.Bands[0].Columns["SuggestedQty"].CellAppearance.BackColor = Color.Wheat;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["NewQty"].CellAppearance.BackColor = Color.Wheat;
    }

    private void formatStoreGrid()
    {
      grdStoreRacks.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand, true);
     
      //Load user preferances
      Global.GridLayout(grdStoreRacks, 2, Properties.Settings.Default.storeRacksLayout);

      grdStoreRacks.DisplayLayout.Bands[0].Columns["shipID"].Hidden = true;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["shipId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;

      grdStoreRacks.DisplayLayout.Bands[0].Columns["shipId"].CellActivation = Activation.Disabled;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["Store"].CellActivation = Activation.Disabled;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["Rank"].CellActivation = Activation.Disabled;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["Zone"].CellActivation = Activation.Disabled;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["Racks"].CellActivation = Activation.Disabled;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["LastRack"].CellActivation = Activation.Disabled;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["LastSlot"].CellActivation = Activation.Disabled;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["OriginalRacks"].CellActivation = Activation.Disabled;
      grdStoreRacks.DisplayLayout.Bands[0].Columns["NewRacks"].CellActivation = Activation.Disabled;

      grdStoreRacks.DisplayLayout.Bands[0].Columns["LastRack"].Header.Caption = "Precise";
      grdStoreRacks.DisplayLayout.Bands[0].Columns["LastSlot"].Header.Caption = "Slot";
      grdStoreRacks.DisplayLayout.Bands[0].Columns["SuggestedRacks"].Header.Caption = "Target";
      grdStoreRacks.DisplayLayout.Bands[0].Columns["OriginalRacks"].Header.Caption = "Original Racks";
      grdStoreRacks.DisplayLayout.Bands[0].Columns["Racks"].Header.Caption = "Current Racks";
      grdStoreRacks.DisplayLayout.Bands[0].Columns["NewRacks"].Header.Caption = "New Racks";

      grdStoreRacks.DisplayLayout.Bands[0].Columns["Skip"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;

      grdStoreRacks.DisplayLayout.Bands[0].Columns["SuggestedRacks"].MaskInput = "{double:2.0}";
    }

    private void formatRoundingGrid()
    {
      grdRackOptimize.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand, true);
     
      //Load user preferances
      Global.GridLayout(grdRackOptimize, 2, Properties.Settings.Default.rackOptimizeLayout);

      grdRackOptimize.DisplayLayout.Bands[0].Columns["prodId"].Hidden = true;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["prodId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["OrderId"].Hidden = true;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["OrderId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["shipId"].Hidden = true;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["shipId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;

      grdRackOptimize.DisplayLayout.Bands[0].Columns["OrderNum"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["OrderId"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["ShipId"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["StoreNum"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["prodId"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["ItemDescription"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["SizeDescription"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["qtyAck"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["available"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["Racks"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["Rank"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["Zone"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["Height"].CellActivation = Activation.Disabled;
      grdRackOptimize.DisplayLayout.Bands[0].Columns["PredictedRacks"].CellActivation = Activation.Disabled;

      grdRackOptimize.DisplayLayout.Bands[0].Columns["OrderNum"].Header.Caption = "Order #";
      grdRackOptimize.DisplayLayout.Bands[0].Columns["StoreNum"].Header.Caption = "Store #";
      grdRackOptimize.DisplayLayout.Bands[0].Columns["ItemDescription"].Header.Caption = "Item Description";
      grdRackOptimize.DisplayLayout.Bands[0].Columns["SizeDescription"].Header.Caption = "Size Description";
      grdRackOptimize.DisplayLayout.Bands[0].Columns["QtyAdjusted"].Header.Caption = "Adjustment Qty";
      grdRackOptimize.DisplayLayout.Bands[0].Columns["qtyAck"].Header.Caption = "On Order";
      grdRackOptimize.DisplayLayout.Bands[0].Columns["available"].Header.Caption = "Available";
      grdRackOptimize.DisplayLayout.Bands[0].Columns["Racks"].Header.Caption = "Total Racks";
      grdRackOptimize.DisplayLayout.Bands[0].Columns["PredictedRacks"].Header.Caption = "New Racks";

      grdRackOptimize.DisplayLayout.Bands[0].Columns["StoreNum"].SortIndicator = SortIndicator.Ascending;
      //highlightRoundingRowsBySort();
    }

    private void formatInventoryGrid()
    {
      grdSessionInventory.DisplayLayout.PerformAutoResizeColumns(false, PerformAutoSizeType.AllRowsInBand, true);
     
      //Load user preferances
      Global.GridLayout(grdSessionInventory, 2, Properties.Settings.Default.sessionInventoryLayout);

      grdSessionInventory.DisplayLayout.Bands[0].Columns["prodId"].Hidden = true;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["prodId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["sessionId"].Hidden = true;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["sessionId"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;

      grdSessionInventory.DisplayLayout.Bands[0].Columns["prodId"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["sessionId"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["ProductId"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["ItemDescription"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["SizeDescription"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["isCG"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["Height"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["OnOrderUnits"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["NumOfStores"].CellActivation = Activation.Disabled;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["Available"].CellActivation = Activation.Disabled;

      grdSessionInventory.DisplayLayout.Bands[0].Columns["ProductId"].Header.Caption = "Product ID";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["ItemDescription"].Header.Caption = "Item Description";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["SizeDescription"].Header.Caption = "Size Description";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["isCG"].Header.Caption = "CG";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["Height"].Header.Caption = "Height";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndDwnPriority"].Header.Caption = "Down Rank";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndDwnMax"].Header.Caption = "Max Down";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndUpPriority"].Header.Caption = "Up Rank";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndUpMax"].Header.Caption = "Max Up";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["OnOrderUnits"].Header.Caption = "On Orders";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["NumOfStores"].Header.Caption = "Total Stores";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["Available"].Header.Caption = "Available";

      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndDwnPriority"].MaskInput = "{double:2.0}";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndDwnMax"].MaskInput = "{double:3.0}";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndUpPriority"].MaskInput = "{double:2.0}";
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndUpMax"].MaskInput = "{double:3.0}";

      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndDwnPriority"].CellAppearance.BackColor = Color.Pink;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndDwnMax"].CellAppearance.BackColor = Color.Pink;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndUpPriority"].CellAppearance.BackColor = Color.PaleGreen;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndUpMax"].CellAppearance.BackColor = Color.PaleGreen;

      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndDwnPriority"].Header.Appearance.BackColor = Color.Red;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndDwnMax"].Header.Appearance.BackColor = Color.Red;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndUpPriority"].Header.Appearance.BackColor = Color.Green;
      grdSessionInventory.DisplayLayout.Bands[0].Columns["RndUpMax"].Header.Appearance.BackColor = Color.Green;
    }

    private void grdPartialShelves_InitializeRow(object sender, InitializeRowEventArgs e)
    {
      if (Convert.ToInt32(e.Row.Cells["SuggestedQty"].Value) > 0)
        e.Row.Cells["SuggestedQty"].Appearance.ForeColor = Color.Green;
      if (Convert.ToInt32(e.Row.Cells["SuggestedQty"].Value) < 0)
        e.Row.Cells["SuggestedQty"].Appearance.ForeColor = Color.Red;
      if (Convert.ToInt32(e.Row.Cells["SuggestedQty"].Value) == 0)
        e.Row.Cells["SuggestedQty"].Appearance.ForeColor = Color.Black;

      if (Convert.ToInt32(e.Row.Cells["UnitsNeeded"].Value) > 0)
        e.Row.Cells["UnitsNeeded"].Appearance.ForeColor = Color.Green;
      if (Convert.ToInt32(e.Row.Cells["UnitsNeeded"].Value) < 0)
        e.Row.Cells["UnitsNeeded"].Appearance.ForeColor = Color.Red;
      if (Convert.ToInt32(e.Row.Cells["UnitsNeeded"].Value) == 0)
        e.Row.Cells["UnitsNeeded"].Appearance.ForeColor = Color.Black;

      if (e.Row.Cells["Incomplete"].Value.ToString() == "1")
        e.Row.Appearance.BackColor = Color.LightPink;
    }

    private void highlightRoundingRowsBySort()
    {
      int groupCount = 0;
      string groupVal = "";
      string sortColumn = grdRackOptimize.DisplayLayout.Bands[0].SortedColumns[0].Key;

      foreach (UltraGridRow gr in grdRackOptimize.Rows)
      {
        if (groupVal != gr.Cells[sortColumn].Value.ToString())
        { //New sort group begins
          groupVal = gr.Cells[sortColumn].Value.ToString();
          groupCount++;
        }

        gr.Appearance.BackColor = groupCount % 2 == 0 ? Color.Silver : Color.White;
      }
    }

    private void grdRackOptimize_InitializeRow(object sender, InitializeRowEventArgs e)
    {
      if (Convert.ToInt32(e.Row.Cells["QtyAdjusted"].Value) > 0)
        e.Row.Cells["QtyAdjusted"].Appearance.ForeColor = Color.Green;
      if (Convert.ToInt32(e.Row.Cells["QtyAdjusted"].Value) < 0)
        e.Row.Cells["QtyAdjusted"].Appearance.ForeColor = Color.Red;
      if (Convert.ToInt32(e.Row.Cells["QtyAdjusted"].Value) == 0)
        e.Row.Cells["QtyAdjusted"].Appearance.ForeColor = Color.Black;
    }

    private void filterZeroPartials()
    {
      bool hideFullShelf = chkFullShelves.Checked;

      if (hideFullShelf)
      {
        partialShelves.DefaultView.RowFilter = "UnitsNeeded<>0";
      }
      else
      {
        partialShelves.DefaultView.RowFilter = "";
      }
    }
    #endregion
    #region Button Pushing
    private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbSession.SelectedIndex >= 0)
      {
        refreshData();
      }
    }

    private void label8_Click(object sender, EventArgs e)
    {
      lblClear.Visible = !lblClear.Visible;
    }

    private void lblClear_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Clear saved column layout data?", "Question!", MessageBoxButtons.OKCancel) == DialogResult.OK)
      {
        Properties.Settings.Default.rackOptimizeLayout = "";
        Properties.Settings.Default.partialShelvesLayout = "";
        Properties.Settings.Default.sessionInventoryLayout = "";
        Properties.Settings.Default.storeRacksLayout = "";

        Properties.Settings.Default.Save();
      }
    }

    private void columnChooseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Try to cast the sender to a ToolStripItem
      ToolStripItem menuItem = sender as ToolStripItem;
      if (menuItem != null)
      {
        // Retrieve the ContextMenuStrip that owns this ToolStripItem
        ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
        if (owner != null)
        {
          // Get the grid that is displaying this context menu
          UltraGrid sourceControl = (UltraGrid)owner.SourceControl;
          sourceControl.ShowColumnChooser();
        }
      }
    }

    private void saveLayoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //Save the grid layout
      Properties.Settings.Default.rackOptimizeLayout = Global.GridLayout(grdRackOptimize, 1);
      Properties.Settings.Default.partialShelvesLayout = Global.GridLayout(grdPartialShelves, 1);
      Properties.Settings.Default.sessionInventoryLayout = Global.GridLayout(grdSessionInventory, 1);
      Properties.Settings.Default.storeRacksLayout = Global.GridLayout(grdStoreRacks, 1);

      Properties.Settings.Default.Save();
      MessageBox.Show("Grid settings saved.");
    }

    private void chkFullShelves_CheckedChanged(object sender, EventArgs e)
    {
      filterZeroPartials();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      refreshRoundingData();
      formatRoundingGrid();
    }

    private void grdPartialShelves_KeyDown(object sender, KeyEventArgs e)
    {
      Global.GridNavigation(grdPartialShelves, e);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      refreshData();
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Warning: You are about to modify your replenishment session by the value indicated in the Suggested Quantity. No turning back from here...","WARNING",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
        updateShelves();
    }

    private void btnUpdateRacks_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Warning: This process will update replenishment, live order data, and will re-rack the selected orders. Continue?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        updateRacks();
    }

    private void grdStoreRacks_KeyDown(object sender, KeyEventArgs e)
    {
      Global.GridNavigation(grdStoreRacks, e);
    }

    private void grdSessionInventory_KeyDown(object sender, KeyEventArgs e)
    {
      Global.GridNavigation(grdSessionInventory, e);
    }

    private void grdRackOptimize_KeyDown(object sender, KeyEventArgs e)
    {
      Global.GridNavigation(grdRackOptimize, e);
    }
    #endregion
    #region Updates
    private void grdSessionInventory_AfterCellUpdate(object sender, CellEventArgs e)
    {
      string prodId = e.Cell.Row.Cells["prodId"].Text.Replace("_", "");

      string dwnPri = e.Cell.Row.Cells["RndDwnPriority"].Text.Replace("_","");
      string dwnMax = e.Cell.Row.Cells["RndDwnMax"].Text.Replace("_", "");
      string upPri = e.Cell.Row.Cells["RndUpPriority"].Text.Replace("_", "");
      string upMax = e.Cell.Row.Cells["RndUpMax"].Text.Replace("_", "");

      Global.ExecuteQuery("usp_RO_UpdateSessionInventory @sessionId="+sessionId+", @prodId="+prodId+", @dwnPri="+dwnPri+", " +
        "@dwnMax=" + dwnMax + ", @upPri=" + upPri + ", @upMax=" + upMax);
    }

    private void recalculateAvailableShelf(int adjust, int available, string prodId)
    {
      foreach (DataRow dr2 in partialShelves.Rows)
      {
        if (dr2["prodId"].ToString() == prodId)
          dr2["Available"] = available + adjust;
        dr2["NewQty"] = (int)Convert.ToDouble(dr2["Requested"].ToString()) + Convert.ToInt32(dr2["SuggestedQty"].ToString());
      }
    }

    private void updateRacks()
    {
      //Displaying loading panel
      lbLoadingStatus.Text = "OPTIMIZING ORDERS...";
      barLoading.Value = 0;
      pnLoading.Visible = true;

      bgUpdateOrders.RunWorkerAsync();
    }

    private void updateShelves()
    {
      var format = new System.Globalization.NumberFormatInfo();
      format.NegativeSign = "-";
      format.NumberDecimalSeparator = ".";
      
      int qty;
      int id;
      int suggestedQty;

      foreach (UltraGridRow gr in grdPartialShelves.Rows.GetFilteredInNonGroupByRows())
      {
        qty = id = suggestedQty = 0;
        suggestedQty = int.Parse(gr.Cells["SuggestedQty"].Value.ToString(), format);

        qty = (int)double.Parse(gr.Cells["Requested"].Value.ToString(), format) + suggestedQty;
        id = Convert.ToInt32(gr.Cells["replId"].Value.ToString());

        if (suggestedQty != 0)
          Global.GetData("usp_RO_UpdateReplenishment @id=" + id + ", @qty=" + qty);
      }

      refreshData();
      
    }

    private void grdStoreRacks_AfterCellUpdate(object sender, CellEventArgs e)
    {
      string shipId = e.Cell.Row.Cells["shipId"].Text.Replace("_", "");

      string target = e.Cell.Row.Cells["SuggestedRacks"].Text.Replace("_", "");
      string exclude = Convert.ToBoolean(e.Cell.Row.Cells["Skip"].Text) ? "1" : "0";

      Global.ExecuteQuery("usp_RO_UpdateSessionStores @sessionId=" + sessionId + ", @shipId=" + shipId + ", @target=" + target + ", @exclude=" + exclude);

      
    }

    private void grdPartialShelves_AfterCellUpdate(object sender, CellEventArgs e)
    {
      string prodId = e.Cell.Row.Cells["prodId"].Text;
      int available = int.Parse(e.Cell.Row.Cells["Available"].Text, System.Globalization.NumberStyles.AllowThousands);
      int qty = 0;

      if (e.Cell.Column.Key == "SuggestedQty")
        qty = Convert.ToInt32(e.Cell.Row.Cells["SuggestedQty"].Text.Replace("_", ""));
      else
      {
        e.Cell.Row.Cells["SuggestedQty"].Value = Convert.ToInt32(e.Cell.Row.Cells["NewQty"].Text.Replace("_", "")) - (int)Convert.ToDouble(e.Cell.Row.Cells["Requested"].Text.Replace("_", ""));
      }

      recalculateAvailableShelf(qty * -1, available, prodId);
    }

    private void grdPartialShelves_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
    {
      string prodId = e.Cell.Row.Cells["prodId"].Text;
      int available = int.Parse(e.Cell.Row.Cells["Available"].Text, System.Globalization.NumberStyles.AllowThousands);
      int qty = Convert.ToInt32(e.Cell.Row.Cells["SuggestedQty"].Value.ToString().Replace("_", ""));

      recalculateAvailableShelf(qty, available, prodId);
    }
    #endregion
    #region Background worker
    private void bgUpdateRacks_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
      barLoading.Value=e.ProgressPercentage;
    }

    private void bgUpdateRacks_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      DataView tempUpdate = rackRounding.DefaultView;
      tempUpdate.Sort = "QtyAdjusted asc";
      tempUpdate.RowFilter = "QtyAdjusted <> 0";
      float recordUpdate = 0;
      float percentComplete = 0;
      string orderId = "";
      string ordId = "";

      DataTable reRack = tempUpdate.ToTable(true, "OrderNum", "OrderId");
      recordUpdate = 100/reRack.Rows.Count;

      foreach (DataRow row in reRack.Rows)
      {
        orderId = row["OrderNum"].ToString();
        ordId = row["OrderId"].ToString();

        Global.ExecuteQuery("usp_RO_RackByOrder @orderId=" + orderId + ", @ordId=" + ordId + ",@sessionId=" + sessionId);
        percentComplete += recordUpdate;
        bgUpdateRacks.ReportProgress((int)percentComplete);
      }
    }

    private void bgUpdateOrders_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
      barLoading.Value = e.ProgressPercentage;
    }

    private void bgUpdateOrders_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      //Update loading bar and fire off racking process
      lbLoadingStatus.Text = "RE-RACKING ORDERS...";
      barLoading.Value = 0;

      bgUpdateRacks.RunWorkerAsync();
    }

    private void bgUpdateOrders_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      //Update the order detail and replenishment data, then rebuild racks
      DataView tempUpdate = rackRounding.DefaultView;
      float recordUpdate = 0;
      float percentComplete = 0;
      string orderId = "";
      string prodId = "";
      string qty = "";
      DataRow dr;

      //Want to reallocate orders that are going down first
      tempUpdate.Sort = "QtyAdjusted asc";
      tempUpdate.RowFilter = "QtyAdjusted <> 0";
      recordUpdate = 100/tempUpdate.Count;
      
      foreach (DataRowView rv in tempUpdate)
      {
        dr = rv.Row;
        orderId = dr["OrderId"].ToString();
        prodId = dr["prodId"].ToString();
        qty = dr["QtyAdjusted"].ToString();

        Global.ExecuteQuery("usp_RO_UpdateRackOptimize @sessionId=" + sessionId + ", @ordId=" + orderId + ", @prodId=" + prodId + ", @qty=" + qty);
        percentComplete += recordUpdate;
        bgUpdateOrders.ReportProgress((int)percentComplete);
      }
    }

    private void bgUpdateRacks_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      refreshData();
      refreshRoundingData();
      highlightRoundingRowsBySort();
      pnLoading.Visible = false;
    }
    #endregion
    #region Grid Filtering
    private void ckSelectAll_Click(object sender, EventArgs e)
    {
      bool checkState = ckSelectAll.Checked;

      
      foreach (UltraGridRow r in grdStoreRacks.Rows.GetFilteredInNonGroupByRows())
      {
        r.Cells["Skip"].Value = checkState;
      }
      
      grdStoreRacks.UpdateData();
      refreshRackAnalysis(); //Update analysis in case # of stores has changed
    }
    #endregion

    private void grdStoreRacks_CellChange(object sender, CellEventArgs e)
    {
      if (e.Cell.Column.Key == "Skip")
        grdStoreRacks.PerformAction(UltraGridAction.ExitEditMode);

      refreshRackAnalysis(); //Update analysis in case # of stores has changed
    }

    private void grdRackOptimize_AfterSortChange(object sender, BandEventArgs e)
    {
      highlightRoundingRowsBySort();
    }

    private void txtThreshold_Leave(object sender, EventArgs e)
    {
      Decimal threshold = Convert.ToDecimal(txtThreshold.Text);

      foreach (UltraGridRow r in grdStoreRacks.Rows.GetFilteredInNonGroupByRows())
      {
        r.Cells["Skip"].Value = Convert.ToDecimal(r.Cells["LastRack"].Value) >= threshold ? true : false;
      }

      grdStoreRacks.UpdateData();
      refreshRackAnalysis(); //Update analysis in case # of stores has changed
    }
  }
}
