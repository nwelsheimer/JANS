using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using General;

namespace Forecast
{
    public partial class frmSetup : MetroForm
    {
        public frmSetup()
        {
            InitializeComponent();
        }

        private void disableControls()
        {
            cmbCustomer.Enabled = false;
            lbRegions.Enabled = false;
            lbSKURegions.Enabled = false;
            txtNewRegion.Enabled = false;
            cbAssignedPlans.Enabled = false;
            btnAddRegion.Enabled = false;

            lbRegions.Items.Clear();
            cbAssignedPlans.Items.Clear();
            lbSKURegions.Items.Clear();
            cmbCustomer.SelectedIndex = -1;
            txtNewRegion.Text = "";
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            disableControls();

            //cmbCustomer.DataSource = Global.GetData("usp_FC_SelectSetup").Tables[0].DefaultView;
            //cmbCustomer.DisplayMember = "companyName";
            //cmbCustomer.ValueMember = "id";
            //cmbCustomer.SelectedIndex = -1;

            cmbInputName.DataSource = Global.GetData("usp_FC_SelectSetup @selection=1").Tables[0].DefaultView;
            cmbInputName.DisplayMember = "description";
            cmbInputName.ValueMember = "id";
            cmbInputName.SelectedIndex = -1;

            lbRegions.Enabled = true;
        }

        private void cmbInputName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRegions.Enabled)
            {
                lbRegions.DataSource = Global.GetData("usp_FC_SelectSetup @selection=2, @input=" + cmbInputName.SelectedValue.ToString()).Tables[0].DefaultView;
                lbRegions.DisplayMember = "description";
                lbRegions.ValueMember = "id";
            }
        }

        private void lbRegions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.grdInputLayout = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("Defaults set. Close and open application now.");
        }
    }
}
