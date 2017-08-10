using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using MetroFramework.Forms;
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
            grdInputDetail.DisplayLayout.Bands[0].Columns["regionId"].Hidden = true;

            grdInputDetail.DisplayLayout.Bands[1].Columns["prodId"].Hidden = true;
            grdInputDetail.DisplayLayout.Bands[1].Columns["SKUKey"].Hidden = true;
            grdInputDetail.DisplayLayout.Bands[1].Columns["regionId"].Hidden = true;
            grdInputDetail.DisplayLayout.Bands[1].Columns["siteId"].Hidden = true;
            grdInputDetail.DisplayLayout.Bands[1].Columns["startWeek"].Hidden = true;
            grdInputDetail.DisplayLayout.Bands[1].Columns["endWeek"].Hidden = true;

            grdInputDetail.DisplayLayout.Bands[0].Columns["prodId"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUKey"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKU"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUDescription"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUSize"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["Region"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["Cost"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["Price"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["regionId"].CellActivation = Activation.Disabled;

            grdInputDetail.DisplayLayout.Bands[0].Columns["Cost"].Format = "c";
            grdInputDetail.DisplayLayout.Bands[0].Columns["Price"].Format = "c";

            grdInputDetail.DisplayLayout.Bands[1].Columns["prodId"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["SKUKey"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["ProductID"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["ItemDescription"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["SizeDescription"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["Site"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["Cost"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["Price"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["regionId"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["siteId"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["startWeek"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["endWeek"].CellActivation = Activation.Disabled;

            grdInputDetail.DisplayLayout.Bands[1].Columns["Cost"].Format = "c";
            grdInputDetail.DisplayLayout.Bands[1].Columns["Price"].Format = "c";

            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUDescription"].Header.Caption = "SKU Description";
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUSize"].Header.Caption = "Size";
            grdInputDetail.DisplayLayout.Bands[0].Columns["TotalRequested"].Header.Caption = "Input";

            grdInputDetail.DisplayLayout.Bands[1].Columns["ItemDescription"].Header.Caption = "Item Description";
            grdInputDetail.DisplayLayout.Bands[1].Columns["SizeDescription"].Header.Caption = "Size";
            grdInputDetail.DisplayLayout.Bands[1].Columns["TotalRequested"].Header.Caption = "Input";
            grdInputDetail.DisplayLayout.Bands[1].Columns["ProductID"].Header.Caption = "Product ID";

            toggleInputLY(false); //Hide the LY inputs and make them read only
        }

        private void toggleInputLY(bool visible)
        {
            string columnHeader = "";

            foreach (UltraGridColumn uc in grdInputDetail.DisplayLayout.Bands[0].Columns)
            {
                columnHeader = uc.Key;
                if(columnHeader.Length>=8 && columnHeader.Substring(columnHeader.Length-8)=="Input LY")
                {
                    uc.CellActivation = Activation.Disabled;
                    uc.Hidden = !visible;
                }
            }

            foreach (UltraGridColumn uc in grdInputDetail.DisplayLayout.Bands[1].Columns)
            {
                columnHeader = uc.Key;
                if (columnHeader.Length >= 8 && columnHeader.Substring(columnHeader.Length - 8) == "Input LY")
                {
                    uc.CellActivation = Activation.Disabled;
                    uc.Hidden = !visible;
                }
            }
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

        private void grdInputDetail_InitializeRow(object sender, InitializeRowEventArgs e)
        {
            string skukey = "";

            skukey = e.Row.Cells["SKUKey"].Text;
            string columnHeader = "";
            int week = 0;
            int startWeek = 0;
            int endWeek = 0;
            int n;
            int rowTotal = 0;

            if (e.Row.Band.Index==0)
            {
                startWeek = Convert.ToInt32(inDetail.Compute("min([startWeek])", "SKUKey = '" + skukey + "'"));
                endWeek = Convert.ToInt32(inDetail.Compute("max([endWeek])", "SKUKey = '" + skukey + "'"));
            } else
            {
                startWeek = Convert.ToInt32(e.Row.Cells["startWeek"].Text);
                endWeek = Convert.ToInt32(e.Row.Cells["endWeek"].Text);
            }

            foreach (UltraGridCell c in e.Row.Cells) //Loop through the cells and see if the detail total matches the summary line
            {
                columnHeader = c.Column.Key.Length>=4 ? c.Column.Key : "xxxx";
                if (int.TryParse(columnHeader.Substring(0,4), out n))
                {
                    week = Convert.ToInt32(columnHeader.Substring(2,2));
                    rowTotal += Convert.ToInt32(c.Text.Length>0 ? c.Text : "0");
                    //Highlight non growing weeks
                    if (week < startWeek || week > endWeek)
                        c.Appearance.BackColor = Color.Pink;

                    if (e.Row.Band.Index == 0) //This is a mother row
                    {
                        n = Convert.ToInt32(inDetail.Compute("sum([" + columnHeader + "])", "SKUKey = '" + skukey + "'"));

                        if (n != Convert.ToInt32(c.Text.Length>0 ? c.Text : "0"))
                        {
                            c.Appearance.ForeColor = Color.Red;
                            c.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True;
                        }
                        else
                        {
                            c.Appearance.ForeColor = Color.Black;
                            c.Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.False;
                        }
                    } 
                }
            }

            //Check the horizontal totals now.
            if (rowTotal != Convert.ToInt32(e.Row.Cells["TotalRequested"].Text))
            {
                e.Row.Cells["TotalRequested"].Appearance.ForeColor = Color.Red;
                e.Row.Cells["TotalRequested"].Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True;
            } else
            {
                e.Row.Cells["TotalRequested"].Appearance.ForeColor = Color.Black;
                e.Row.Cells["TotalRequested"].Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.False;
            }
            
        }

        private void grdInputDetail_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.CellAppearance.BackColor = Color.White;
            e.Layout.Override.CellAppearance.ForeColorDisabled = Color.Black;
        }

        private void lnSetup_Click(object sender, EventArgs e)
        {
            frmSetup f = new frmSetup();
            f.ShowDialog();
            f.Close();
        }

        private void grdInputDetail_KeyDown(object sender, KeyEventArgs e)
        {
            Global.GridNavigation(grdInputDetail, e);
        }

        private void cbInputLY_CheckedChanged(object sender, EventArgs e)
        {
            toggleInputLY(cbInputLY.Checked);
        }
    }
}
