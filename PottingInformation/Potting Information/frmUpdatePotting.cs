﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using General;

namespace Potting_Information
{
  public partial class frmUpdatePotting : Form
  {
    string lotId;
    string siteId;
    string fromItemId;
    bool loaded = false;
    DataTable locations;
    DataTable pottingLog;
    DataTable inputDetail;
    DataTable inputLocations;

    public frmUpdatePotting(string LOTID)
    {
      InitializeComponent();
      lotId = LOTID;
    }

    private void frmUpdatePotting_Load(object sender, EventArgs e)
    {
      lblLotId.Text = "Lot ID: " + lotId;

      DataTable itemName = Global.GetData("usp_PI_SelectUpdateSummary @lotId=" + lotId).Tables[0];
      lblItemName.Text = itemName.Rows[0]["itemDesc"].ToString() + " " + itemName.Rows[0]["sizeDesc"].ToString();
      lblFromSize.Text = "From Size: " + itemName.Rows[0]["fromSize"].ToString();
      siteId = itemName.Rows[0]["siteId"].ToString();
      fromItemId = itemName.Rows[0]["iFrom"].ToString();
      setupLogGrid();
      setupInputGrid();
      loaded = true;
    }

    private void setupLogGrid()
    {
      locations = Global.GetData("usp_PI_SelectLocations @siteId=" + siteId).Tables[0];
      pottingLog = Global.GetData("usp_PI_SelectPottingLog @lotId=" + lotId).Tables[0];

      DataGridViewComboBoxColumn cmbLocations = new DataGridViewComboBoxColumn();
      cmbLocations.DataSource = locations;
      cmbLocations.DisplayMember = "locationCode";
      cmbLocations.HeaderText = "Set down location";
      cmbLocations.DataPropertyName = "locId";
      cmbLocations.ValueMember = "locId";
      cmbLocations.Name = "locId";

      grdDriverLog.Columns.Add(cmbLocations);
      grdDriverLog.DataSource = pottingLog;

      grdDriverLog.Columns["id"].Visible = false;
      
      grdDriverLog.Columns["qty"].HeaderText = "Quantity";

      pottingLog.RowChanged += new DataRowChangeEventHandler(recordChanged);
    }

    private void setupInputGrid()
    {
      inputDetail = Global.GetData("usp_PI_SelectPottingInputDetail @lotId=" + lotId).Tables[0];
      inputLocations = Global.GetData("usp_PI_SelectInputLocations @prodId=" + fromItemId + " , @siteId=" + siteId).Tables[0];

      //TODO input location combo box
      DataGridViewComboBoxColumn cmbInputs = new DataGridViewComboBoxColumn();
      cmbInputs.DataSource = inputLocations;
      cmbInputs.DisplayMember = "Description";
      cmbInputs.HeaderText = "Input Location";
      cmbInputs.DataPropertyName = "inputLocId";
      cmbInputs.ValueMember = "inputLocId";
      cmbInputs.Name = "inputLocId";

      grdInputItems.Columns.Add(cmbInputs);
      grdInputItems.DataSource = inputDetail;

      grdInputItems.Columns["id"].Visible = false;
      grdInputItems.Columns["qty"].HeaderText = "Quantity";

      inputDetail.RowChanged += new DataRowChangeEventHandler(inputRecordChanged);
    }

    private void inputRecordChanged(object sender, DataRowChangeEventArgs e)
    {

    }

    private void recordChanged(object sender, DataRowChangeEventArgs e)
    {
      string rowIndex = e.Row["id"].ToString(); //grdDriverLog.Rows[e.RowIndex].Cells["id"].Value.ToString();
      string locId = e.Row["locId"].ToString(); //grdDriverLog.Rows[e.RowIndex].Cells["locId"].Value.ToString();
      string qty = e.Row["qty"].ToString(); //grdDriverLog.Rows[e.RowIndex].Cells["qty"].Value.ToString();

      if (locId.Length > 0 && qty.Length > 0)
      {
        if (rowIndex.Length > 0)
        {
          Global.ExecuteQuery("usp_PI_UpdatePottingLog @lotId=" + lotId + ",@locId=" + locId + ", @qty=" + qty + ",@counted=0,@logIndex=" + rowIndex);
        }
        else
        {
          string newIndex = Global.ExecuteQueryGetId("exec usp_PI_UpdatePottingLog @lotId=" + lotId + ",@locId=" + locId + ",@qty=" + qty);
          e.Row["id"] = newIndex;
          //grdDriverLog.Rows[e.RowIndex].Cells["id"].Value = newIndex;
        }
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
