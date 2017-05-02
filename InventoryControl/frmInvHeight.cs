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
        DataTable itemHeights = new DataTable();
        MetroFramework.Components.MetroStyleManager sm = metroTools.setStyles();

        public frmInvHeight()
        {
            InitializeComponent();
            Global.connectToDB();
            itemHeights = Global.GetData("usp_INV_SelectHeights @siteId=33").Tables[0];
            this.StyleManager = sm;
            sm.Owner = this;
            grdHeight.DataSource = itemHeights;
        }
    }
}
