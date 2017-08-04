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
using Infragistics.Win.UltraWinGrid;
using General;

namespace Forecast
{
    public partial class frmForecast : MetroForm
    {
        DataSet inputDetail = new DataSet();
        DataTable inHeader = new DataTable();
        DataTable inDetail = new DataTable();

        public frmForecast()
        {
            InitializeComponent();
            Global.connectToDB();
        }

        private void frmForecast_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Load the input sheet names
            cmbInputGroup.DataSource = Global.GetData("usp_FC_SelectInputNames").Tables[0].DefaultView;
            cmbInputGroup.ValueMember = "id";
            cmbInputGroup.DisplayMember = "description";
            cmbInputGroup.SelectedIndex = -1;
            cmbInputGroup.Enabled = true;
        }

        private void cmbInputGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInputGroup.Enabled)
            {
                int inputId = Convert.ToInt32(cmbInputGroup.SelectedValue);
                cmbCustomer.DataSource = Global.GetData("usp_FC_SelectCompanies @inputNameId=" + inputId).Tables[0].DefaultView;
                cmbCustomer.ValueMember = "Id";
                cmbCustomer.DisplayMember = "companyName";
                cmbCustomer.SelectedIndex = -1;
                cmbCustomer.Enabled = true;
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.Enabled)
            {
                int nameId = Convert.ToInt32(cmbInputGroup.SelectedValue);
                int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                cbRegions.DataSource = Global.GetData("usp_FC_SelectRegions @nameId=" + nameId + ", @customerId=" + customerId).Tables[0].DefaultView;
                cbRegions.ValueMember = "id";
                cbRegions.DisplayMember = "description";
                btnRefresh.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string startWeek = txtStartWeek.Text;
            string endWeek = txtEndWeek.Text;
            if(startWeek.Length>0 && endWeek.Length>0 && cbRegions.CheckedItems.Count>0)
            {
                List<string> nameIds = new List<string>();
                foreach(DataRowView dv in cbRegions.CheckedItems)
                {
                    nameIds.Add(dv[cbRegions.ValueMember].ToString());
                }

                string regions = string.Join(",", nameIds.ToArray());
                string query = "usp_FC_SelectInputDetail @startWeek='" + startWeek + "', @endWeek='" + endWeek + "', @nameIds='" + regions + "', @band=";

                buildGrid(query);
            } else
            {
                MessageBox.Show("Please select one or more regions and enter valid start/end weeks to continue.");
            }
        }

        private void buildGrid(string query)
        {
            inDetail.Clear();
            inHeader.Clear();

            Global.FillData(query + '1').Fill(inHeader);
            Global.FillData(query + '0').Fill(inDetail);

            if (!grdInputDetail.Enabled)
            {
                //Set up data tables
                inHeader.TableName = "Header";
                inDetail.TableName = "Detail";
                inputDetail.Tables.Add(inHeader);
                inputDetail.Tables.Add(inDetail);
                DataRelation dr = new DataRelation("DR", inHeader.Columns["SKUKey"], inDetail.Columns["SKUKey"], true);
                inputDetail.Relations.Add(dr);
                grdInputDetail.DataSource = inputDetail;
                GridLayout();//Set up the display of the grid
                grdInputDetail.Enabled = true;
            }
            
        }

        private void GridLayout()
        {
            //Global settings to enable/disable hide etc.
            Global.GridLayout(grdInputDetail, 2, Properties.Settings.Default.grdInputLayout);

            grdInputDetail.DisplayLayout.Bands[0].Columns["prodId"].Hidden = true;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUKey"].Hidden = true;

            grdInputDetail.DisplayLayout.Bands[1].Columns["prodId"].Hidden = true;
            grdInputDetail.DisplayLayout.Bands[1].Columns["SKUKey"].Hidden = true;

            grdInputDetail.DisplayLayout.Bands[0].Columns["prodId"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUKey"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKU"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUDescription"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUSize"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["Region"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["Cost"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["Price"].CellActivation = Activation.Disabled;

            grdInputDetail.DisplayLayout.Bands[1].Columns["prodId"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["SKUKey"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["ProductID"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["ItemDescription"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["SizeDescription"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["Site"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["Cost"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["Price"].CellActivation = Activation.Disabled;


            //grdInputDetail.DisplayLayout.Bands[0].Columns["qtyRequested"].Header.Caption = "Quantity";

        }

        private void txtStartWeek_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEndWeek_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lnChooseColumns_Click(object sender, EventArgs e)
        {
            grdInputDetail.ShowColumnChooser();
        }

        private void lnSaveLayout_Click(object sender, EventArgs e)
        {
            //Save the grid layout
            Properties.Settings.Default.grdInputLayout = Global.GridLayout(grdInputDetail, 1);
            Properties.Settings.Default.Save();
            MessageBox.Show("Grid settings saved.");
        }
    }
}
