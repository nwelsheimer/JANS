namespace Nursery_Production_Software.sysForms
{
  partial class frmWwwUsers
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWwwUsers));
      this.dxFrmAssitant = new DevExpress.XtraBars.FormAssistant();
      this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
      this.wwwUserObjBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.grdWwwUsers = new Nursery_Production_Software.etc.MyGridControl();
      this.gridView1 = new Nursery_Production_Software.etc.MyGridView();
      this.coluserId = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colemailAddress = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colfirstName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.collastName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colphoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colvendorName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
      this.colisApproved = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colcreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.popGrid1 = new DevExpress.XtraBars.PopupMenu(this.components);
      this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
      this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
      this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
      this.barMan1 = new DevExpress.XtraBars.BarManager(this.components);
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      ((System.ComponentModel.ISupportInitialize)(this.wwwUserObjBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdWwwUsers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.popGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barMan1)).BeginInit();
      this.SuspendLayout();
      // 
      // defaultLookAndFeel1
      // 
      this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
      // 
      // wwwUserObjBindingSource
      // 
      this.wwwUserObjBindingSource.DataSource = typeof(NBSio.etc.dbobj.wwwUserObj);
      // 
      // grdWwwUsers
      // 
      this.grdWwwUsers.DataSource = this.wwwUserObjBindingSource;
      this.grdWwwUsers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.grdWwwUsers.Location = new System.Drawing.Point(18, 104);
      this.grdWwwUsers.MainView = this.gridView1;
      this.grdWwwUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.grdWwwUsers.Name = "grdWwwUsers";
      this.grdWwwUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
      this.grdWwwUsers.Size = new System.Drawing.Size(1221, 674);
      this.grdWwwUsers.TabIndex = 0;
      this.grdWwwUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluserId,
            this.colusername,
            this.colemailAddress,
            this.colfirstName,
            this.collastName,
            this.colphoneNumber,
            this.colvendorName,
            this.colisApproved,
            this.colcreatedDate});
      this.gridView1.GridControl = this.grdWwwUsers;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.MultiSelect = true;
      this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
      this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridView1.OptionsView.ShowAutoFilterRow = true;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
      // 
      // coluserId
      // 
      this.coluserId.FieldName = "userId";
      this.coluserId.Name = "coluserId";
      this.coluserId.OptionsColumn.AllowEdit = false;
      // 
      // colusername
      // 
      this.colusername.Caption = "Username";
      this.colusername.FieldName = "username";
      this.colusername.Name = "colusername";
      this.colusername.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      this.colusername.Visible = true;
      this.colusername.VisibleIndex = 1;
      // 
      // colemailAddress
      // 
      this.colemailAddress.Caption = "Email Address";
      this.colemailAddress.FieldName = "emailAddress";
      this.colemailAddress.Name = "colemailAddress";
      this.colemailAddress.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      this.colemailAddress.Visible = true;
      this.colemailAddress.VisibleIndex = 2;
      // 
      // colfirstName
      // 
      this.colfirstName.Caption = "First Name";
      this.colfirstName.FieldName = "firstName";
      this.colfirstName.Name = "colfirstName";
      this.colfirstName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      this.colfirstName.Visible = true;
      this.colfirstName.VisibleIndex = 3;
      // 
      // collastName
      // 
      this.collastName.Caption = "Last Name";
      this.collastName.FieldName = "lastName";
      this.collastName.Name = "collastName";
      this.collastName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
      this.collastName.Visible = true;
      this.collastName.VisibleIndex = 4;
      // 
      // colphoneNumber
      // 
      this.colphoneNumber.Caption = "Phone Number";
      this.colphoneNumber.FieldName = "phoneNumber";
      this.colphoneNumber.Name = "colphoneNumber";
      this.colphoneNumber.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      this.colphoneNumber.Visible = true;
      this.colphoneNumber.VisibleIndex = 5;
      // 
      // colvendorName
      // 
      this.colvendorName.Caption = "Assigned Vendor";
      this.colvendorName.ColumnEdit = this.repositoryItemComboBox1;
      this.colvendorName.FieldName = "vendorName";
      this.colvendorName.Name = "colvendorName";
      this.colvendorName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      this.colvendorName.Visible = true;
      this.colvendorName.VisibleIndex = 6;
      // 
      // repositoryItemComboBox1
      // 
      this.repositoryItemComboBox1.AutoHeight = false;
      this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
      this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      // 
      // colisApproved
      // 
      this.colisApproved.Caption = "Approved";
      this.colisApproved.FieldName = "isApproved";
      this.colisApproved.Name = "colisApproved";
      this.colisApproved.Visible = true;
      this.colisApproved.VisibleIndex = 7;
      // 
      // colcreatedDate
      // 
      this.colcreatedDate.Caption = "Date Added";
      this.colcreatedDate.FieldName = "createdDate";
      this.colcreatedDate.Name = "colcreatedDate";
      this.colcreatedDate.OptionsColumn.AllowEdit = false;
      this.colcreatedDate.Visible = true;
      this.colcreatedDate.VisibleIndex = 8;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(18, 61);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(141, 34);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "Delete Selected";
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl1.Location = new System.Drawing.Point(18, 18);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(1221, 35);
      this.labelControl1.TabIndex = 3;
      this.labelControl1.Text = "Add or modify website users";
      // 
      // popGrid1
      // 
      this.popGrid1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barLargeButtonItem3)});
      this.popGrid1.Manager = this.barMan1;
      this.popGrid1.Name = "popGrid1";
      // 
      // barLargeButtonItem1
      // 
      this.barLargeButtonItem1.Caption = "Change Password";
      this.barLargeButtonItem1.Id = 1;
      this.barLargeButtonItem1.Name = "barLargeButtonItem1";
      // 
      // barLargeButtonItem2
      // 
      this.barLargeButtonItem2.Caption = "Delete User";
      this.barLargeButtonItem2.Id = 2;
      this.barLargeButtonItem2.Name = "barLargeButtonItem2";
      // 
      // barLargeButtonItem3
      // 
      this.barLargeButtonItem3.Caption = "Open Details";
      this.barLargeButtonItem3.Id = 3;
      this.barLargeButtonItem3.Name = "barLargeButtonItem3";
      // 
      // barMan1
      // 
      this.barMan1.DockControls.Add(this.barDockControlTop);
      this.barMan1.DockControls.Add(this.barDockControlBottom);
      this.barMan1.DockControls.Add(this.barDockControlLeft);
      this.barMan1.DockControls.Add(this.barDockControlRight);
      this.barMan1.Form = this;
      this.barMan1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3});
      this.barMan1.MaxItemId = 4;
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barMan1;
      this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.barDockControlTop.Size = new System.Drawing.Size(1257, 0);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 795);
      this.barDockControlBottom.Manager = this.barMan1;
      this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.barDockControlBottom.Size = new System.Drawing.Size(1257, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
      this.barDockControlLeft.Manager = this.barMan1;
      this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 795);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(1257, 0);
      this.barDockControlRight.Manager = this.barMan1;
      this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 795);
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "barSubItem1";
      this.barSubItem1.Id = 0;
      this.barSubItem1.Name = "barSubItem1";
      // 
      // frmWwwUsers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1257, 795);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.grdWwwUsers);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "frmWwwUsers";
      this.Text = "Website User Setup";
      this.Load += new System.EventHandler(this.frmWwwUsers_Load);
      ((System.ComponentModel.ISupportInitialize)(this.wwwUserObjBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdWwwUsers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.popGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barMan1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.FormAssistant dxFrmAssitant;
    private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    private System.Windows.Forms.BindingSource wwwUserObjBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn coluserId;
    private DevExpress.XtraGrid.Columns.GridColumn colusername;
    private DevExpress.XtraGrid.Columns.GridColumn colemailAddress;
    private DevExpress.XtraGrid.Columns.GridColumn colfirstName;
    private DevExpress.XtraGrid.Columns.GridColumn collastName;
    private DevExpress.XtraGrid.Columns.GridColumn colphoneNumber;
    private DevExpress.XtraGrid.Columns.GridColumn colvendorName;
    private DevExpress.XtraGrid.Columns.GridColumn colisApproved;
    private DevExpress.XtraGrid.Columns.GridColumn colcreatedDate;
    private etc.MyGridControl grdWwwUsers;
    private etc.MyGridView gridView1;
    private DevExpress.XtraEditors.SimpleButton btnDelete;
    private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraBars.PopupMenu popGrid1;
    private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
    private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
    private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
    private DevExpress.XtraBars.BarManager barMan1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
  }
}