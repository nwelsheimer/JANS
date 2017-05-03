using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using Nursery_Production_Software.etc;
using General;

namespace InventoryControl
{
    public partial class frmInvHeight : MetroForm
    {
        DataTable itemHeights = new DataTable(); //local working dataset
        MetroFramework.Components.MetroStyleManager sm = metroTools.setStyles(); //JANS local style manager

        public frmInvHeight()
        {
            InitializeComponent();
            Global.connectToDB(); //faster method for setting up DB connectivity in JANS. Use this going forward

            this.StyleManager = sm; //Assign the style manager to the form
            sm.Owner = this;

            cmbSite.DataSource = Global.GetData("usp_SYS_GetSites").Tables[0]; //Set up site combo
            cmbSite.ValueMember = "id";
            cmbSite.DisplayMember = "description";
            updateGrid();
        }

        private void updateGrid()
        {
            if (cmbSite.SelectedValue.ToString() != "")
                itemHeights = Global.GetData("usp_INV_SelectHeights @siteId=" + cmbSite.SelectedValue).Tables[0];
            grdHeight.DataSource = itemHeights;
            ugrdHeights.DataSource = itemHeights;
        }
        
        private void cmbSite_SelectionChangeCommitted(object sender, EventArgs e)
        {
            updateGrid();
        }
    }
}
