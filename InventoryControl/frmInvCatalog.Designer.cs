namespace InventoryControl
{
    partial class frmInvCatalog
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
            this.nmsDataSet2 = new InventoryControl.NMSDataSet();
            this.iC_exposureTableAdapter2 = new InventoryControl.NMSDataSetTableAdapters.IC_exposureTableAdapter();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tabsICInventory = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabICItems = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabConfig = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabCatalog = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabSizes = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabLocations = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.grdExposure = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdZone = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdSoil = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabsICInventory)).BeginInit();
            this.tabsICInventory.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // nmsDataSet2
            // 
            this.nmsDataSet2.DataSetName = "NMSDataSet";
            this.nmsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iC_exposureTableAdapter2
            // 
            this.iC_exposureTableAdapter2.ClearBeforeFill = true;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Dark";
            // 
            // tabsICInventory
            // 
            this.tabsICInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsICInventory.Controls.Add(this.tabICItems);
            this.tabsICInventory.Controls.Add(this.tabConfig);
            this.tabsICInventory.Controls.Add(this.tabCatalog);
            this.tabsICInventory.Controls.Add(this.tabSizes);
            this.tabsICInventory.Controls.Add(this.tabLocations);
            this.tabsICInventory.Location = new System.Drawing.Point(12, 12);
            this.tabsICInventory.Name = "tabsICInventory";
            this.tabsICInventory.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabICItems,
            this.tabCatalog,
            this.tabSizes,
            this.tabLocations,
            this.tabConfig});
            this.tabsICInventory.RegularSize = new System.Drawing.Size(1181, 718);
            this.tabsICInventory.SelectedPage = this.tabICItems;
            this.tabsICInventory.Size = new System.Drawing.Size(1181, 718);
            this.tabsICInventory.TabIndex = 3;
            this.tabsICInventory.Text = "tabPane1";
            // 
            // tabICItems
            // 
            this.tabICItems.Caption = "Inventory Items";
            this.tabICItems.Name = "tabICItems";
            this.tabICItems.Size = new System.Drawing.Size(1163, 674);
            // 
            // tabConfig
            // 
            this.tabConfig.Caption = "Inventory Configuration";
            this.tabConfig.Controls.Add(this.panelControl2);
            this.tabConfig.Controls.Add(this.panelControl1);
            this.tabConfig.Controls.Add(this.sidePanel1);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(1163, 674);
            // 
            // tabCatalog
            // 
            this.tabCatalog.Caption = "Item Master";
            this.tabCatalog.Name = "tabCatalog";
            this.tabCatalog.Size = new System.Drawing.Size(1181, 689);
            // 
            // tabSizes
            // 
            this.tabSizes.Caption = "Size Master";
            this.tabSizes.Name = "tabSizes";
            this.tabSizes.Size = new System.Drawing.Size(1181, 689);
            // 
            // tabLocations
            // 
            this.tabLocations.Caption = "Location Master";
            this.tabLocations.Name = "tabLocations";
            this.tabLocations.Size = new System.Drawing.Size(1163, 674);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.gridControl1);
            this.sidePanel1.Controls.Add(this.grdSoil);
            this.sidePanel1.Controls.Add(this.grdZone);
            this.sidePanel1.Controls.Add(this.grdExposure);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(759, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(404, 674);
            this.sidePanel1.TabIndex = 5;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // grdExposure
            // 
            this.grdExposure.DataMember = "IC_exposure";
            this.grdExposure.DataSource = this.nmsDataSet2;
            this.grdExposure.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdExposure.Location = new System.Drawing.Point(1, 0);
            this.grdExposure.MainView = this.gridView1;
            this.grdExposure.Name = "grdExposure";
            this.grdExposure.Size = new System.Drawing.Size(403, 168);
            this.grdExposure.TabIndex = 2;
            this.grdExposure.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescription,
            this.colsort});
            this.gridView1.GridControl = this.grdExposure;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.AllowShowHide = false;
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Exposure";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 0;
            this.coldescription.Width = 220;
            // 
            // colsort
            // 
            this.colsort.Caption = "Sort";
            this.colsort.FieldName = "sort";
            this.colsort.Name = "colsort";
            this.colsort.Visible = true;
            this.colsort.VisibleIndex = 1;
            this.colsort.Width = 48;
            // 
            // grdZone
            // 
            this.grdZone.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdZone.Location = new System.Drawing.Point(1, 168);
            this.grdZone.MainView = this.gridView2;
            this.grdZone.Name = "grdZone";
            this.grdZone.Size = new System.Drawing.Size(403, 168);
            this.grdZone.TabIndex = 3;
            this.grdZone.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdZone;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // grdSoil
            // 
            this.grdSoil.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdSoil.Location = new System.Drawing.Point(1, 336);
            this.grdSoil.MainView = this.gridView3;
            this.grdSoil.Name = "grdSoil";
            this.grdSoil.Size = new System.Drawing.Size(403, 169);
            this.grdSoil.TabIndex = 4;
            this.grdSoil.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grdSoil;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 504);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(759, 170);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl3);
            this.panelControl2.Controls.Add(this.gridControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 334);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(759, 170);
            this.panelControl2.TabIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(1, 505);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(403, 169);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl2.Location = new System.Drawing.Point(2, 2);
            this.gridControl2.MainView = this.gridView5;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(403, 166);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControl2;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(405, 2);
            this.gridControl3.MainView = this.gridView6;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(352, 166);
            this.gridControl3.TabIndex = 5;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridControl3;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl4
            // 
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.Location = new System.Drawing.Point(2, 2);
            this.gridControl4.MainView = this.gridView7;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(755, 166);
            this.gridControl4.TabIndex = 6;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.gridControl4;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // frmInvCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 742);
            this.Controls.Add(this.tabsICInventory);
            this.Name = "frmInvCatalog";
            this.Text = "Inventory Catalog";
            this.Load += new System.EventHandler(this.frmInvCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabsICInventory)).EndInit();
            this.tabsICInventory.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSoil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NMSDataSet nmsDataSet2;
        private NMSDataSetTableAdapters.IC_exposureTableAdapter iC_exposureTableAdapter2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Navigation.TabPane tabsICInventory;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabICItems;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabConfig;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabCatalog;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabSizes;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabLocations;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl grdSoil;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl grdZone;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdExposure;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colsort;
    }
}