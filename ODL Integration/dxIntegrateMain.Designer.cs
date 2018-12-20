
namespace ODL_Integration
{
  partial class dxIntegrateMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxIntegrateMain));
      this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
      this.btnExport = new DevExpress.XtraEditors.SimpleButton();
      this.btnImport = new DevExpress.XtraEditors.SimpleButton();
      this.txtNextLoad = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.grdOrderSelect = new Nursery_Production_Software.etc.NBSGrid();
      this.logOrdObjBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      this.gvOrderSelect = new Nursery_Production_Software.etc.NBSGridView();
      this.colorderId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colorderNumber = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colcompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colcustomerPO = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colshipDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colshipToName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colediStoreNumber = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colshipToaddress = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colshipTocity = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colshipTostate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colshipTozip = new DevExpress.XtraGrid.Columns.GridColumn();
      this.coltotalRacks = new DevExpress.XtraGrid.Columns.GridColumn();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.txtNextLoad.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdOrderSelect)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.logOrdObjBindingSource2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvOrderSelect)).BeginInit();
      this.SuspendLayout();
      // 
      // defaultLookAndFeel1
      // 
      this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
      // 
      // btnExport
      // 
      this.btnExport.Location = new System.Drawing.Point(27, 12);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new System.Drawing.Size(104, 35);
      this.btnExport.TabIndex = 0;
      this.btnExport.Text = "Export Orders";
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // btnImport
      // 
      this.btnImport.Location = new System.Drawing.Point(163, 12);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(104, 35);
      this.btnImport.TabIndex = 1;
      this.btnImport.Text = "Import Loads";
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // txtNextLoad
      // 
      this.txtNextLoad.Location = new System.Drawing.Point(163, 67);
      this.txtNextLoad.Name = "txtNextLoad";
      this.txtNextLoad.Size = new System.Drawing.Size(100, 20);
      this.txtNextLoad.TabIndex = 2;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(64, 70);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(93, 13);
      this.labelControl1.TabIndex = 3;
      this.labelControl1.Text = "Next Load Number:";
      // 
      // grdOrderSelect
      // 
      this.grdOrderSelect.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
      this.grdOrderSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdOrderSelect.DataSource = this.logOrdObjBindingSource2;
      this.grdOrderSelect.Location = new System.Drawing.Point(12, 105);
      this.grdOrderSelect.MainView = this.gvOrderSelect;
      this.grdOrderSelect.Name = "grdOrderSelect";
      this.grdOrderSelect.Size = new System.Drawing.Size(1144, 512);
      this.grdOrderSelect.TabIndex = 4;
      this.grdOrderSelect.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderSelect});
      // 
      // logOrdObjBindingSource2
      // 
      this.logOrdObjBindingSource2.DataSource = typeof(NBSio.etc.dbobj.logOrdObj);
      // 
      // gvOrderSelect
      // 
      this.gvOrderSelect.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colorderId,
            this.colorderNumber,
            this.colcompanyName,
            this.colcustomerPO,
            this.colshipDate,
            this.colshipToName,
            this.colediStoreNumber,
            this.colshipToaddress,
            this.colshipTocity,
            this.colshipTostate,
            this.colshipTozip,
            this.coltotalRacks});
      this.gvOrderSelect.GridControl = this.grdOrderSelect;
      this.gvOrderSelect.Name = "gvOrderSelect";
      this.gvOrderSelect.OptionsBehavior.Editable = false;
      this.gvOrderSelect.OptionsSelection.MultiSelect = true;
      this.gvOrderSelect.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
      this.gvOrderSelect.OptionsView.ShowAutoFilterRow = true;
      this.gvOrderSelect.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
      this.gvOrderSelect.OptionsView.ShowGroupPanel = false;
      // 
      // colorderId
      // 
      this.colorderId.FieldName = "orderId";
      this.colorderId.Name = "colorderId";
      // 
      // colorderNumber
      // 
      this.colorderNumber.Caption = "Order #";
      this.colorderNumber.FieldName = "orderNumber";
      this.colorderNumber.Name = "colorderNumber";
      this.colorderNumber.Visible = true;
      this.colorderNumber.VisibleIndex = 1;
      // 
      // colcompanyName
      // 
      this.colcompanyName.Caption = "Bill To";
      this.colcompanyName.FieldName = "companyName";
      this.colcompanyName.Name = "colcompanyName";
      this.colcompanyName.Visible = true;
      this.colcompanyName.VisibleIndex = 2;
      // 
      // colcustomerPO
      // 
      this.colcustomerPO.Caption = "PO Number";
      this.colcustomerPO.FieldName = "customerPO";
      this.colcustomerPO.Name = "colcustomerPO";
      this.colcustomerPO.Visible = true;
      this.colcustomerPO.VisibleIndex = 3;
      // 
      // colshipDate
      // 
      this.colshipDate.Caption = "Ship Date";
      this.colshipDate.FieldName = "shipDate";
      this.colshipDate.Name = "colshipDate";
      this.colshipDate.Visible = true;
      this.colshipDate.VisibleIndex = 4;
      // 
      // colshipToName
      // 
      this.colshipToName.Caption = "Ship To";
      this.colshipToName.FieldName = "shipToName";
      this.colshipToName.Name = "colshipToName";
      this.colshipToName.Visible = true;
      this.colshipToName.VisibleIndex = 5;
      // 
      // colediStoreNumber
      // 
      this.colediStoreNumber.Caption = "Store #";
      this.colediStoreNumber.FieldName = "ediStoreNumber";
      this.colediStoreNumber.Name = "colediStoreNumber";
      this.colediStoreNumber.Visible = true;
      this.colediStoreNumber.VisibleIndex = 6;
      // 
      // colshipToaddress
      // 
      this.colshipToaddress.Caption = "Adress";
      this.colshipToaddress.FieldName = "shipToAddress";
      this.colshipToaddress.Name = "colshipToaddress";
      this.colshipToaddress.Visible = true;
      this.colshipToaddress.VisibleIndex = 7;
      // 
      // colshipTocity
      // 
      this.colshipTocity.Caption = "City";
      this.colshipTocity.FieldName = "shipToCity";
      this.colshipTocity.Name = "colshipTocity";
      this.colshipTocity.Visible = true;
      this.colshipTocity.VisibleIndex = 8;
      // 
      // colshipTostate
      // 
      this.colshipTostate.Caption = "State";
      this.colshipTostate.FieldName = "shipToState";
      this.colshipTostate.Name = "colshipTostate";
      this.colshipTostate.Visible = true;
      this.colshipTostate.VisibleIndex = 9;
      // 
      // colshipTozip
      // 
      this.colshipTozip.Caption = "Zip";
      this.colshipTozip.FieldName = "shipToZip";
      this.colshipTozip.Name = "colshipTozip";
      this.colshipTozip.Visible = true;
      this.colshipTozip.VisibleIndex = 10;
      // 
      // coltotalRacks
      // 
      this.coltotalRacks.Caption = "Racks";
      this.coltotalRacks.FieldName = "totalRacks";
      this.coltotalRacks.Name = "coltotalRacks";
      this.coltotalRacks.Visible = true;
      this.coltotalRacks.VisibleIndex = 11;
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Appearance.Options.UseTextOptions = true;
      this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl2.Location = new System.Drawing.Point(273, 4);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(883, 95);
      this.labelControl2.TabIndex = 5;
      this.labelControl2.Text = resources.GetString("labelControl2.Text");
      // 
      // dxIntegrateMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1168, 629);
      this.Controls.Add(this.labelControl2);
      this.Controls.Add(this.grdOrderSelect);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.txtNextLoad);
      this.Controls.Add(this.btnImport);
      this.Controls.Add(this.btnExport);
      this.Name = "dxIntegrateMain";
      this.Text = "Import / Export from Routing Software";
      this.Load += new System.EventHandler(this.dxIntegrateMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.txtNextLoad.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdOrderSelect)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.logOrdObjBindingSource2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvOrderSelect)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    private DevExpress.XtraEditors.SimpleButton btnExport;
    private DevExpress.XtraEditors.SimpleButton btnImport;
    private DevExpress.XtraEditors.TextEdit txtNextLoad;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private Nursery_Production_Software.etc.NBSGrid grdOrderSelect;
    private Nursery_Production_Software.etc.NBSGridView gvOrderSelect;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private System.Windows.Forms.BindingSource logOrdObjBindingSource2;
    private DevExpress.XtraGrid.Columns.GridColumn colorderId;
    private DevExpress.XtraGrid.Columns.GridColumn colorderNumber;
    private DevExpress.XtraGrid.Columns.GridColumn colcompanyName;
    private DevExpress.XtraGrid.Columns.GridColumn colcustomerPO;
    private DevExpress.XtraGrid.Columns.GridColumn colshipDate;
    private DevExpress.XtraGrid.Columns.GridColumn colshipToName;
    private DevExpress.XtraGrid.Columns.GridColumn colediStoreNumber;
    private DevExpress.XtraGrid.Columns.GridColumn colshipToaddress;
    private DevExpress.XtraGrid.Columns.GridColumn colshipTocity;
    private DevExpress.XtraGrid.Columns.GridColumn colshipTostate;
    private DevExpress.XtraGrid.Columns.GridColumn colshipTozip;
    private DevExpress.XtraGrid.Columns.GridColumn coltotalRacks;
  }
}