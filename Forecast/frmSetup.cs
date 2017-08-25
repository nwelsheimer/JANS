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
            cmbInputName.Enabled = false;//
            cmbCustomer.Enabled = false;
            lbRegions.Enabled = false;//
            lbSKURegions.Enabled = false;
            txtNewRegion.Enabled = false;//
            cbAssignedPlans.Enabled = false;
            btnAddRegion.Enabled = false;//

            lbRegions.Items.Clear();
            cbAssignedPlans.Items.Clear();
            lbSKURegions.Items.Clear();
            cmbCustomer.SelectedIndex = -1;
            txtNewRegion.Text = "";
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {
            disableControls();

            cmbInputName.DataSource = Global.GetData("usp_FC_SelectSetup @selection=1").Tables[0].DefaultView;
            cmbInputName.DisplayMember = "description";
            cmbInputName.ValueMember = "id";
            cmbInputName.SelectedIndex = -1;
            cmbInputName.Enabled = true;
        }

        private void cmbInputName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInputName.Enabled)
            {
                lbRegions.Enabled = false;
                lbRegions.DataSource = Global.GetData("usp_FC_SelectSetup @selection=2, @input=" + cmbInputName.SelectedValue.ToString()).Tables[0].DefaultView;
                lbRegions.DisplayMember = "description";
                lbRegions.ValueMember = "id";
                lbRegions.SelectedIndex = -1;
                lbRegions.Enabled = true;
                txtNewRegion.Enabled = true;
                btnAddRegion.Enabled = true;
            }
        }

        private void lbRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbRegions.Enabled)
            {
                cmbCustomer.Enabled = false;
                DataTable customers = Global.GetData("usp_FC_SelectSetup @selection=3, @input=" + lbRegions.SelectedValue.ToString()).Tables[0];
                cmbCustomer.DataSource = customers;
                cmbCustomer.DisplayMember = "companyName";
                cmbCustomer.ValueMember = "Id";

                int index = -1;
                int rownumber = 0;
                foreach (DataRow r in customers.Rows)
                {
                    if (Convert.ToInt32(r["selected"].ToString()) > 0)
                        index = rownumber;
                    rownumber++;
                }
                cmbCustomer.Enabled = true;
                cmbCustomer.SelectedIndex = index;

                cbAssignedPlans.Enabled = false;
                DataTable plans = Global.GetData("usp_FC_SelectSetup @selection=5, @input=" + lbRegions.SelectedValue.ToString()).Tables[0];
                cbAssignedPlans.DataSource = plans;
                cbAssignedPlans.DisplayMember = "Description";
                cbAssignedPlans.ValueMember = "Id";
                
                bool selected = false;
                string id = "";
                index = 0;
                foreach (DataRow r in plans.Rows)
                {
                    selected = Convert.ToBoolean(r["Selected"]);
                    id = r["Id"].ToString();
                    index = cbAssignedPlans.Items.IndexOf(id);
                    for (int i = 0; i < cbAssignedPlans.Items.Count; i++)
                    {
                        if (((System.Data.DataRowView)(cbAssignedPlans.Items[i])).Row.ItemArray[0].ToString() == id)
                            cbAssignedPlans.SetItemChecked(i, selected);
                    }
                }

                cbAssignedPlans.Enabled = true;
            }
        }

        private void lnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.grdInputLayout = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("Defaults set. Close and open application now.");
        }

        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            string newRegion = txtNewRegion.Text.Length>10 ? txtNewRegion.Text.Substring(0,10) : txtNewRegion.Text;
            string inputNameId = cmbInputName.SelectedValue.ToString();
            if (newRegion.Length>0)
            {
                Global.ExecuteQuery("usp_FC_UpdateRegions @description='"+newRegion+"', @nameId="+inputNameId);
                cmbInputName_SelectedIndexChanged(sender, e);
            }
            txtNewRegion.Text = "";
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.Enabled && cmbCustomer.SelectedIndex>=0)
            {
                lbSKURegions.Enabled = false;
                //Update the customer
                Global.ExecuteQuery("usp_FC_UpdateRegions @id="+lbRegions.SelectedValue.ToString()+", @customerId="+cmbCustomer.SelectedValue.ToString());

                DataTable skuLevels = Global.GetData("usp_FC_SelectSetup @selection=4, @input=" + lbRegions.SelectedValue.ToString() + ", @input2=" + cmbCustomer.SelectedValue.ToString()).Tables[0];
                lbSKURegions.DataSource = skuLevels;
                lbSKURegions.DisplayMember = "description";
                lbSKURegions.ValueMember = "Id";

                int index = -1;
                int rownumber = 0;
                foreach (DataRow r in skuLevels.Rows)
                {
                    if (Convert.ToInt32(r["selected"].ToString()) > 0)
                        index = rownumber;
                    rownumber++;
                }
                lbSKURegions.Enabled = true;
                lbSKURegions.SelectedIndex = index;
            }
        }

        private void lbSKURegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSKURegions.SelectedIndex >= 0 && lbSKURegions.Enabled)
            {
                Global.ExecuteQuery("usp_FC_UpdateRegions @id=" + lbRegions.SelectedValue.ToString() + ", @skuLevelId="+lbSKURegions.SelectedValue.ToString());
            }
        }

        private void cbAssignedPlans_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cbAssignedPlans.Enabled)
            {
                string planId = cbAssignedPlans.SelectedValue.ToString();
                string regionId = lbRegions.SelectedValue.ToString();
                string cbState = e.NewValue == CheckState.Checked ? "1" : "0";

                Global.ExecuteQuery("usp_FC_updateRegionplans @regionId="+regionId+", @planId="+planId+", @cbState=" + cbState);
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            string newGroupName = txtNewInputName.Text;
            string newYear = txtYear.Text;
            bool copyExisting = cbCopyFrom.Checked;

            if (newGroupName.Length > 0 && newYear.Length > 0)
            {
                if (copyExisting && cmbInputName.SelectedIndex == -1)
                    MessageBox.Show("You must select an existing group from the drop down to use the copy feature.");
                else
                {
                    string oldId = copyExisting ? cmbInputName.SelectedValue.ToString() : "0";
                    Global.ExecuteQuery("usp_FC_InsertNewGroup @newGroupName="+newGroupName+", @newYear="+newYear+", @oldInputId=" + oldId);
                    txtNewInputName.Text = "";
                }
            } else
                MessageBox.Show("Please enter a group name and year to continue.");
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && txtYear.Text.Length <= 4;
        }
    }
}
