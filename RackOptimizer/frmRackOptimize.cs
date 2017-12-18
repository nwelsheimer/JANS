using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using General;

namespace RackOptimizer
{
  public partial class frmRackOptimize : Form
  {
    DataTable rackAnalysisSummary;
    DataView partialShelves; 

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

    private void refreshData()
    {
      string sessionId = cmbSession.SelectedValue.ToString();
      rackAnalysisSummary = Global.GetData("usp_RO_SelectRackAnalysis @sessionId=" + sessionId).Tables[0];

      lblTotalStores.Text = rackAnalysisSummary.Rows[0]["StoreCount"].ToString();
      lblPartialShelves.Text = rackAnalysisSummary.Rows[0]["PartialShelves"].ToString();

      DataTable tempShelves = Global.GetData("usp_RO_SelectPartialShelves @sessionId=" + sessionId).Tables[0];

      tempShelves.Columns.Add("SuggestedQty");
      string sizeCode = "";
      int qtyRemain = 0;
      int available = 0;
      double partial = 0.0;
      int suggested;

      foreach (DataRow dr in tempShelves.Rows)
      {
        suggested = 0;
        if (dr["sizeGroup"].ToString()!=sizeCode)
        { //New size group
          sizeCode = dr["SizeGroup"].ToString();
          qtyRemain = (int)Convert.ToDouble(dr["UnitsNeeded"].ToString());
          partial = Convert.ToDouble(dr["PartialShelves"].ToString());
        }

        if (qtyRemain>0)
        {
          if (partial <= .4)
          {
            suggested = qtyRemain * -1;
            qtyRemain = 0;
          }
          else
          {
            available = (int)Convert.ToDouble(dr["Available"].ToString());
            if (available > 0)
            {
              suggested = available >= qtyRemain ? qtyRemain : available;
              qtyRemain -= suggested;
            }
          }
        }
        dr["SuggestedQty"] = suggested.ToString();
      }

      partialShelves = tempShelves.DefaultView;
      grdPartialShelves.DataSource = partialShelves;

      formatShelvesGrid();
    }

    private void formatShelvesGrid()
    {
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeGroup"].Hidden = true;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeGroup"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;

      grdPartialShelves.DisplayLayout.Bands[0].Columns["Store"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SKUDescription"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeDescription"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["TotalShelves"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["PartialShelves"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["UnitsNeeded"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeGroup"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Requested"].CellActivation = Activation.Disabled;
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Available"].CellActivation = Activation.Disabled;

      grdPartialShelves.DisplayLayout.Bands[0].Columns["TotalShelves"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["PartialShelves"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["UnitsNeeded"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Requested"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Available"].Format = "n0";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SuggestedQty"].Format = "n0";

      grdPartialShelves.DisplayLayout.Bands[0].Columns["Store"].Header.Caption = "Store Number";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SKUDescription"].Header.Caption = "SKU Description";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SizeDescription"].Header.Caption = "Size Description";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["TotalShelves"].Header.Caption = "Total Shelves";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["PartialShelves"].Header.Caption = "Partial Shelves";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["UnitsNeeded"].Header.Caption = "Units Needed";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["Available"].Header.Caption = "Available";
      grdPartialShelves.DisplayLayout.Bands[0].Columns["SuggestedQty"].Header.Caption = "Suggested Change";
    }

    private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbSession.SelectedIndex >= 0)
      {
        refreshData();
      }
    }

    private void chkFullShelves_CheckedChanged(object sender, EventArgs e)
    {
      bool hideFullShelf = chkFullShelves.Checked;

      if (hideFullShelf)
      {
        partialShelves.RowFilter = "UnitsNeeded>0";
      } else
      {
        partialShelves.RowFilter = "";
      }
    }

    private void grdPartialShelves_InitializeRow(object sender, InitializeRowEventArgs e)
    {
      if (Convert.ToInt32(e.Row.Cells["SuggestedQty"].Value) > 0)
        e.Row.Cells["SuggestedQty"].Appearance.ForeColor = Color.Green;
      if (Convert.ToInt32(e.Row.Cells["SuggestedQty"].Value) < 0)
        e.Row.Cells["SuggestedQty"].Appearance.ForeColor = Color.Red;
      if (Convert.ToInt32(e.Row.Cells["SuggestedQty"].Value) == 0)
        e.Row.Cells["SuggestedQty"].Appearance.ForeColor = Color.Black;
    }

    private void grdPartialShelves_KeyDown(object sender, KeyEventArgs e)
    {
      Global.GridNavigation(grdPartialShelves, e);
    }
  }
}
