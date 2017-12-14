using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General;

namespace RackOptimizer
{
  public partial class frmRackOptimize : Form
  {
    DataTable rackAnalysisSummary;

    public frmRackOptimize()
    {
      InitializeComponent();
      Global.connectToDB();
    }

    private void frmRackOptimize_Load(object sender, EventArgs e)
    {
      cmbSession.DataSource = Global.GetData("usp_RO_SelectSessionNames").Tables[0];
      cmbSession.ValueMember = "id";
      cmbSession.DisplayMember = "sessionName";
    }

    private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbSession.SelectedIndex > 0)
      {
        string sessionId = cmbSession.SelectedValue.ToString();
        rackAnalysisSummary = Global.GetData("usp_RO_SelectRackAnalysis @sessionId=" + sessionId).Tables[0];

        lblTotalStores.Text = rackAnalysisSummary.Columns["StoreCount"].ToString();
        lblPartialShelves.Text = rackAnalysisSummary.Columns["PartialShelves"].ToString();
      }
    }
  }
}
