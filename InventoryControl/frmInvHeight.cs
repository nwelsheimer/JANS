using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nursery_Production_Software.etc;
using General;

namespace InventoryControl
{
  public partial class frmInvHeight : Form
  {
    DataTable itemHeights = new DataTable(); //local working dataset

    public frmInvHeight()
    {
      InitializeComponent();

      Global.connectToDB(); //faster method for setting up DB connectivity in JANS. Use this going forward

      cmbSelectSite.DataSource = Global.GetData("usp_SYS_GetSites").Tables[0]; //Set up site combo
      cmbSelectSite.ValueMember = "id";
      cmbSelectSite.DisplayMember = "description";
      updateGrid();
    }

  private void updateGrid()
  {
    if (cmbSelectSite.SelectedIndex>0)
      itemHeights = Global.GetData("usp_INV_SelectHeights @siteId=" + cmbSelectSite.SelectedValue.ToString()).Tables[0];
    ugrdHeights.DataSource = itemHeights;
  }

  private void cmbSelectSite_SelectedIndexChanged(object sender, EventArgs e)
  {
    updateGrid();
  }
}
}
