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
        bool loading = true;

#region Startup routines
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

        private void grdInputDetail_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.CellAppearance.BackColor = Color.White;
            //e.Layout.Override.CellAppearance.ForeColorDisabled = Color.Black;
            e.Layout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True;
            e.Layout.Bands[0].ColHeaderLines = 2;
            e.Layout.Bands[1].ColHeaderLines = 2;
        }
#endregion
#region Grid building
        private void buildGrid(string query) //Fills the tables and creates the dataset relationships
        {

            inDetail.Clear();
            inHeader.Clear();

            string columnHeader = "";
            int n;
            var weekColumns = new List<string>();

            foreach (DataColumn dc in inHeader.Columns)
            {
                columnHeader = dc.ColumnName.Length >= 4 ? dc.ColumnName : "xxxx"; //Sanity check to make sure we have enough spaces to parse
                if (int.TryParse(columnHeader.Substring(0, 4), out n)) //It's a number so it must be a week
                {
                    weekColumns.Add(columnHeader);
                }
            }

            foreach (var week in weekColumns)
            {
                inHeader.Columns.Remove(week);
                inDetail.Columns.Remove(week);
            }

            Global.FillData(query + '1').Fill(inHeader);
            Global.FillData(query + '0').Fill(inDetail);

            TotalInputs();

            if (loading)
            {            
                //Set up data tables
                inHeader.TableName = "Header";
                inDetail.TableName = "Detail";
                inputDetail.Tables.Add(inHeader);
                inputDetail.Tables.Add(inDetail);
                DataRelation dr = new DataRelation("DR", inHeader.Columns["SKUKey"], inDetail.Columns["SKUKey"], true);
                inputDetail.Relations.Add(dr);
                loading = false;
            }
        }

        private void GridLayout() //Disables certain columns for editing, changes header names, hides columns, etc.
        {
            //Load user preferances
            Global.GridLayout(grdInputDetail, 2, Properties.Settings.Default.grdInputLayout);

            //Now override any weird adjustments the user might have done if we want it to look a certain way
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
            grdInputDetail.DisplayLayout.Bands[0].Columns["TotalInput"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["TotalInputLY"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[0].Columns["TotalShippedLY"].CellActivation = Activation.Disabled;

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
            grdInputDetail.DisplayLayout.Bands[1].Columns["TotalInput"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["TotalInputLY"].CellActivation = Activation.Disabled;
            grdInputDetail.DisplayLayout.Bands[1].Columns["TotalShippedLY"].CellActivation = Activation.Disabled;

            grdInputDetail.DisplayLayout.Bands[1].Columns["Cost"].Format = "c";
            grdInputDetail.DisplayLayout.Bands[1].Columns["Price"].Format = "c";

            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUDescription"].Header.Caption = "SKU Description";
            grdInputDetail.DisplayLayout.Bands[0].Columns["SKUSize"].Header.Caption = "Size";
            grdInputDetail.DisplayLayout.Bands[0].Columns["TotalRequested"].Header.Caption = "Input";
            grdInputDetail.DisplayLayout.Bands[0].Columns["TotalInput"].Header.Caption = "Total Input";
            grdInputDetail.DisplayLayout.Bands[0].Columns["TotalInputLY"].Header.Caption = "Total Input LY";
            grdInputDetail.DisplayLayout.Bands[0].Columns["TotalShippedLY"].Header.Caption = "Total Ship LY";

            grdInputDetail.DisplayLayout.Bands[1].Columns["ItemDescription"].Header.Caption = "Item Description";
            grdInputDetail.DisplayLayout.Bands[1].Columns["SizeDescription"].Header.Caption = "Size";
            grdInputDetail.DisplayLayout.Bands[1].Columns["TotalRequested"].Header.Caption = "Input";
            grdInputDetail.DisplayLayout.Bands[1].Columns["ProductID"].Header.Caption = "Product ID";
            grdInputDetail.DisplayLayout.Bands[1].Columns["TotalInput"].Header.Caption = "Total Input";
            grdInputDetail.DisplayLayout.Bands[1].Columns["TotalInputLY"].Header.Caption = "Total Input LY";
            grdInputDetail.DisplayLayout.Bands[1].Columns["TotalShippedLY"].Header.Caption = "Total Ship LY";

            string columnHeader = "";
            int n;

            foreach (UltraGridColumn uc in grdInputDetail.DisplayLayout.Bands[0].Columns)
            {
                columnHeader = uc.Key.Length >= 4 ? uc.Key : "xxxx"; //Sanity check to make sure we have enough spaces to parse
                if (int.TryParse(columnHeader.Substring(0, 4), out n)) //It's a number so it must be a week
                {
                    grdInputDetail.DisplayLayout.Bands[0].Columns[columnHeader].Width = 55;
                    grdInputDetail.DisplayLayout.Bands[1].Columns[columnHeader].Width = 55;
                    if (columnHeader.Substring(5) != "Input")
                    {
                        grdInputDetail.DisplayLayout.Bands[0].Columns[columnHeader].CellActivation = Activation.Disabled;
                        grdInputDetail.DisplayLayout.Bands[1].Columns[columnHeader].CellActivation = Activation.Disabled;
                    }
                }
            }

            toggleInputLY(false); //Hide the LY values and make them read only
            togglePlannedLY(false);
            toggleShippedLY(false);
        }

        private void grdInputDetail_InitializeRow(object sender, InitializeRowEventArgs e) //Occurs whenever rows are updated, heavy lifting happens here.
        {
            if (grdInputDetail.Enabled)
            {
                string skukey = "";

                skukey = e.Row.Cells["SKUKey"].Text;
                string columnHeader = "";
                string columnSource = "";
                int week = 0;
                int startWeek = 0;
                int endWeek = 0;
                int n;
                int rowTotal = 0;

                //Establish grow weeks for SKU/item row to use later in the code
                if (e.Row.Band.Index == 0)
                {
                    startWeek = Convert.ToInt32(inDetail.Compute("min([startWeek])", "SKUKey = '" + skukey + "'"));
                    endWeek = Convert.ToInt32(inDetail.Compute("max([endWeek])", "SKUKey = '" + skukey + "'"));
                }
                else
                {
                    startWeek = Convert.ToInt32(e.Row.Cells["startWeek"].Text);
                    endWeek = Convert.ToInt32(e.Row.Cells["endWeek"].Text);
                }

                foreach (UltraGridCell c in e.Row.Cells) //Loop through the cells and see if the detail total matches the summary line
                {
                    columnHeader = c.Column.Key.Length >= 4 ? c.Column.Key : "xxxx"; //Sanity check to make sure we have enough spaces to parse
                    if (int.TryParse(columnHeader.Substring(0, 4), out n)) //It's a number so it must be a week
                    {
                        week = Convert.ToInt32(columnHeader.Substring(2, 2));
                        columnSource = columnHeader.Substring(5);

                        if (columnSource == "Input")
                            rowTotal += Convert.ToInt32(c.Text.Length > 0 ? c.Text : "0");
                        
                        if (week < startWeek || week > endWeek) //Highlight non growing weeks
                            c.Appearance.BackColor = Color.Pink;

                        if (e.Row.Band.Index == 0 && columnSource == "Input") //This is a mother row
                        {
                            n = Convert.ToInt32(inDetail.Compute("sum([" + columnHeader + "])", "SKUKey = '" + skukey + "'"));

                            if (n != Convert.ToInt32(c.Text.Length > 0 ? c.Text : "0"))
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

                //Check the horizontal totals now. Highlight non matching ones
                if (rowTotal != Convert.ToInt32(e.Row.Cells["TotalRequested"].Text))
                {
                    e.Row.Cells["TotalRequested"].Appearance.ForeColor = Color.Red;
                    e.Row.Cells["TotalRequested"].Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True;
                }
                else
                {
                    e.Row.Cells["TotalRequested"].Appearance.ForeColor = Color.Black;
                    e.Row.Cells["TotalRequested"].Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.False;
                }

            }
        }
        #endregion
#region Math section
        private void TotalInputs(string prodId = "")
        {
            int totalInput = 0;
            string columnHeader = "";
            int n;

            if (prodId.Length > 0) //A product ID was specified, only update the specific row in the datatable.
            {
                string searchExp = "prodId = " + prodId;
                DataRow[] headerRows = inHeader.Select(searchExp);
                DataRow[] detailRows = inDetail.Select(searchExp);

                foreach (DataRow dr in headerRows)
                {
                    for (int c = 0; c < inHeader.Columns.Count; c++)
                    {
                        columnHeader = inHeader.Columns[c].ColumnName.Length > 5 ? inHeader.Columns[c].ColumnName : "xxxxx";
                        if (int.TryParse(columnHeader.Substring(0, 4), out n) && inHeader.Columns[c].ColumnName.Substring(inHeader.Columns[c].ColumnName.Length - 5) == "Input")
                            totalInput += Convert.ToInt32(dr[c].ToString());
                    }
                    dr["TotalInput"] = totalInput.ToString();
                    totalInput = 0;
                }

                foreach (DataRow dr in detailRows)
                {
                    for (int c = 0; c < inDetail.Columns.Count; c++)
                    {
                        columnHeader = inDetail.Columns[c].ColumnName.Length > 5 ? inDetail.Columns[c].ColumnName : "xxxxx";
                        if (int.TryParse(columnHeader.Substring(0, 4), out n) && inDetail.Columns[c].ColumnName.Substring(inDetail.Columns[c].ColumnName.Length - 5) == "Input")
                            totalInput += Convert.ToInt32(dr[c].ToString());
                    }
                    dr["TotalInput"] = totalInput.ToString();
                    totalInput = 0;
                }
            }
            else //No product id, probably the initial load, so calculate the whole table.
            {
                foreach (DataRow dr in inHeader.Rows)
                {
                    for (int c = 0; c < inHeader.Columns.Count; c++)
                    {
                        columnHeader = inHeader.Columns[c].ColumnName.Length > 5 ? inHeader.Columns[c].ColumnName : "xxxxx";
                        if (int.TryParse(columnHeader.Substring(0, 4), out n) && inHeader.Columns[c].ColumnName.Substring(inHeader.Columns[c].ColumnName.Length - 5) == "Input")
                            totalInput += Convert.ToInt32(dr[c].ToString());
                    }
                    dr["TotalInput"] = totalInput.ToString();
                    totalInput = 0;
                }

                foreach (DataRow dr in inDetail.Rows)
                {
                    for (int c = 0; c < inDetail.Columns.Count; c++)
                    {
                        columnHeader = inDetail.Columns[c].ColumnName.Length > 5 ? inDetail.Columns[c].ColumnName : "xxxxx";
                        if (int.TryParse(columnHeader.Substring(0, 4), out n) && inDetail.Columns[c].ColumnName.Substring(inDetail.Columns[c].ColumnName.Length - 5) == "Input")
                            totalInput += Convert.ToInt32(dr[c].ToString());
                    }
                    dr["TotalInput"] = totalInput.ToString();
                    totalInput = 0;
                }
            }
        }
#endregion
#region Column toggles
        private void toggleInputLY(bool visible)
        {
            string columnHeader = "";

            foreach (UltraGridColumn uc in grdInputDetail.DisplayLayout.Bands[0].Columns)
            {
                columnHeader = uc.Key;
                if (columnHeader.Length >= 8 && columnHeader.Substring(columnHeader.Length - 8) == "Input LY")
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
        private void togglePlannedLY(bool visible)
        {
            string columnHeader = "";

            foreach (UltraGridColumn uc in grdInputDetail.DisplayLayout.Bands[0].Columns)
            {
                columnHeader = uc.Key;
                if (columnHeader.Length >= 8 && columnHeader.Substring(columnHeader.Length - 8) == "Planned LY")
                {
                    uc.CellActivation = Activation.Disabled;
                    uc.Hidden = !visible;
                }
            }

            foreach (UltraGridColumn uc in grdInputDetail.DisplayLayout.Bands[1].Columns)
            {
                columnHeader = uc.Key;
                if (columnHeader.Length >= 8 && columnHeader.Substring(columnHeader.Length - 8) == "Planned LY")
                {
                    uc.CellActivation = Activation.Disabled;
                    uc.Hidden = !visible;
                }
            }
        }
        private void toggleShippedLY(bool visible)
        {
            string columnHeader = "";

            foreach (UltraGridColumn uc in grdInputDetail.DisplayLayout.Bands[0].Columns)
            {
                columnHeader = uc.Key;
                if (columnHeader.Length >= 7 && columnHeader.Substring(columnHeader.Length - 7) == "Ship LY")
                {
                    uc.CellActivation = Activation.Disabled;
                    uc.Hidden = !visible;
                }
            }

            foreach (UltraGridColumn uc in grdInputDetail.DisplayLayout.Bands[1].Columns)
            {
                columnHeader = uc.Key;
                if (columnHeader.Length >= 7 && columnHeader.Substring(columnHeader.Length - 7) == "Ship LY")
                {
                    uc.CellActivation = Activation.Disabled;
                    uc.Hidden = !visible;
                }
            }
        }
        #endregion
#region Comboboxes
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
        #endregion
#region BS Button pushing stuff

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string startWeek = txtStartWeek.Text;
            string endWeek = txtEndWeek.Text;
            if (startWeek.Length > 0 && endWeek.Length > 0 && cbRegions.CheckedItems.Count > 0)
            {
                List<string> nameIds = new List<string>();
                foreach (DataRowView dv in cbRegions.CheckedItems)
                {
                    nameIds.Add(dv[cbRegions.ValueMember].ToString());
                }

                string regions = string.Join(",", nameIds.ToArray());
                string query = "usp_FC_SelectInputDetail @startWeek='" + startWeek + "', @endWeek='" + endWeek + "', @nameIds='" + regions + "', @band=";
                loadingSpinner.Spinning = true;
                loadingSpinner.Visible = true;
                pnLoading.Visible = true;

                grdInputDetail.Enabled = false;
                bgLoading.RunWorkerAsync(query);
            }
            else
            {
                MessageBox.Show("Please select one or more regions and enter valid start/end weeks to continue.");
            }
        }

        private void lnSetup_Click(object sender, EventArgs e)
        {
            frmSetup f = new frmSetup();
            f.ShowDialog();
            f.Close();
        }

        private void lnSaveLayout_Click(object sender, EventArgs e)
        {
            //Save the grid layout
            Properties.Settings.Default.grdInputLayout = Global.GridLayout(grdInputDetail, 1);
            Properties.Settings.Default.Save();
            MessageBox.Show("Grid settings saved.");
        }

        private void grdInputDetail_KeyDown(object sender, KeyEventArgs e)
        {
            Global.GridNavigation(grdInputDetail, e);
        }

        private void cbInputLY_CheckedChanged(object sender, EventArgs e)
        {
            toggleInputLY(cbInputLY.Checked);
        }

        private void cbPlannedLY_CheckedChanged(object sender, EventArgs e)
        {
            togglePlannedLY(cbPlannedLY.Checked);
        }

        private void cbShippedLY_CheckedChanged(object sender, EventArgs e)
        {
            toggleShippedLY(cbShippedLY.Checked);
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
        #endregion
#region Background loader
        private void bgLoading_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            loadingSpinner.Spinning = false;
            loadingSpinner.Visible = false;
            pnLoading.Visible = false;
            grdInputDetail.Enabled = true;

            grdInputDetail.DataSource = inputDetail;

            GridLayout();//Set up the display of the grid
        }

        private void bgLoading_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            buildGrid((string)e.Argument);
        }
        #endregion
#region Update region
        private void grdInputDetail_AfterCellUpdate(object sender, CellEventArgs e)
        {
            TotalInputs(e.Cell.Row.Cells["prodId"].Text);
        }
#endregion
    }
}
