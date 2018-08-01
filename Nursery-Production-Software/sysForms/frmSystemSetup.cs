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

namespace Nursery_Production_Software.sysForms
{
  public partial class frmSystemSetup : Form
  {
    sysSiteSP siteSP = new sysSiteSP();
    sysSiteObj siteObj = new sysSiteObj();

    public frmSystemSetup()
    {
      InitializeComponent();
    }

    private void frmSystemSetup_Load(object sender, EventArgs e)
    {
      cmbSelectSite.DataSource = siteSP.ViewSiteOnly();
      cmbSelectSite.ValueMember = "id";
      cmbSelectSite.DisplayMember = "description";
    }

    private void cmbSelectSite_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Convert.ToInt32(cmbSelectSite.SelectedValue.ToString())>0)
      {
        siteObj = siteSP.GetSiteById(Convert.ToInt32(cmbSelectSite.SelectedValue.ToString()));

        txtDescription.Text = siteObj.description;
        txtAddress1.Text = siteObj.address1;
        txtAddress2.Text = siteObj.address2;
        txtCity.Text = siteObj.city;
        txtState.Text = siteObj.state;
        txtZip.Text = siteObj.zip;
        txtPhone.Text = siteObj.phone;
        chkDefault.Checked = siteObj.dflt;
        chkManaged.Checked = siteObj.managed;
      }
    }
  }
}
