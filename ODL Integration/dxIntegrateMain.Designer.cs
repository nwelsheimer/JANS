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
      this.grdOrderSelect = new DevExpress.XtraGrid.GridControl();
      this.gvOrderSelect = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.txtNextLoad.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdOrderSelect)).BeginInit();
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
      // 
      // btnImport
      // 
      this.btnImport.Location = new System.Drawing.Point(163, 12);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(104, 35);
      this.btnImport.TabIndex = 1;
      this.btnImport.Text = "Import Loads";
      // 
      // txtNextLoad
      // 
      this.txtNextLoad.Location = new System.Drawing.Point(167, 53);
      this.txtNextLoad.Name = "txtNextLoad";
      this.txtNextLoad.Size = new System.Drawing.Size(100, 20);
      this.txtNextLoad.TabIndex = 2;
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(68, 56);
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
      this.grdOrderSelect.Location = new System.Drawing.Point(12, 88);
      this.grdOrderSelect.MainView = this.gvOrderSelect;
      this.grdOrderSelect.Name = "grdOrderSelect";
      this.grdOrderSelect.Size = new System.Drawing.Size(1144, 529);
      this.grdOrderSelect.TabIndex = 4;
      this.grdOrderSelect.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderSelect});
      // 
      // gvOrderSelect
      // 
      this.gvOrderSelect.GridControl = this.grdOrderSelect;
      this.gvOrderSelect.Name = "gvOrderSelect";
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
      this.labelControl2.Size = new System.Drawing.Size(883, 78);
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
    private DevExpress.XtraGrid.GridControl grdOrderSelect;
    private DevExpress.XtraGrid.Views.Grid.GridView gvOrderSelect;
    private DevExpress.XtraEditors.LabelControl labelControl2;
  }
}