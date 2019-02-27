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
      this.grdWwwUsers = new Nursery_Production_Software.etc.NBSGrid();
      this.gvWWWUsers = new Nursery_Production_Software.etc.NBSGridView();
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
      this.btnChangePassword = new DevExpress.XtraBars.BarLargeButtonItem();
      this.btnDeleteUser = new DevExpress.XtraBars.BarLargeButtonItem();
      this.barMan1 = new DevExpress.XtraBars.BarManager(this.components);
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      this.btnOpenDetails = new DevExpress.XtraBars.BarLargeButtonItem();
      this.popStoreList = new DevExpress.XtraEditors.PopupContainerControl();
      this.lblStoreNum = new System.Windows.Forms.Label();
      this.grdShipTos = new DevExpress.XtraGrid.GridControl();
      this.gvShipTos = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.btnExport = new DevExpress.XtraEditors.SimpleButton();
      this.btnImport = new DevExpress.XtraEditors.SimpleButton();
      this.loadingBar = new DevExpress.XtraWaitForm.ProgressPanel();
      this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
      this.txtSearch = new DevExpress.XtraEditors.TextEdit();
      this.bgWorkUpload = new System.ComponentModel.BackgroundWorker();
      ((System.ComponentModel.ISupportInitialize)(this.wwwUserObjBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdWwwUsers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvWWWUsers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.popGrid1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barMan1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.popStoreList)).BeginInit();
      this.popStoreList.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdShipTos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvShipTos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
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
      this.grdWwwUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdWwwUsers.DataSource = this.wwwUserObjBindingSource;
      this.grdWwwUsers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grdWwwUsers.Location = new System.Drawing.Point(12, 72);
      this.grdWwwUsers.MainView = this.gvWWWUsers;
      this.grdWwwUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grdWwwUsers.Name = "grdWwwUsers";
      this.grdWwwUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
      this.grdWwwUsers.Size = new System.Drawing.Size(814, 462);
      this.grdWwwUsers.TabIndex = 0;
      this.grdWwwUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWWWUsers});
      this.grdWwwUsers.MouseUp += new System.Windows.Forms.MouseEventHandler(this.grdWwwUsers_MouseUp);
      // 
      // gvWWWUsers
      // 
      this.gvWWWUsers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gvWWWUsers.Appearance.HeaderPanel.Options.UseFont = true;
      this.gvWWWUsers.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gvWWWUsers.Appearance.Row.Options.UseFont = true;
      this.gvWWWUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coluserId,
            this.colusername,
            this.colemailAddress,
            this.colfirstName,
            this.collastName,
            this.colphoneNumber,
            this.colvendorName,
            this.colisApproved,
            this.colcreatedDate});
      this.gvWWWUsers.GridControl = this.grdWwwUsers;
      this.gvWWWUsers.Name = "gvWWWUsers";
      this.gvWWWUsers.OptionsSelection.MultiSelect = true;
      this.gvWWWUsers.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
      this.gvWWWUsers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gvWWWUsers.OptionsView.ShowAutoFilterRow = true;
      this.gvWWWUsers.OptionsView.ShowGroupPanel = false;
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
      this.btnDelete.Location = new System.Drawing.Point(12, 41);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(94, 24);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "Delete Selected";
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl1.Location = new System.Drawing.Point(12, 12);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(242, 24);
      this.labelControl1.TabIndex = 3;
      this.labelControl1.Text = "Add or modify website users";
      // 
      // popGrid1
      // 
      this.popGrid1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangePassword),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteUser)});
      this.popGrid1.Manager = this.barMan1;
      this.popGrid1.Name = "popGrid1";
      // 
      // btnChangePassword
      // 
      this.btnChangePassword.Caption = "Change Password";
      this.btnChangePassword.Id = 1;
      this.btnChangePassword.Name = "btnChangePassword";
      this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
      // 
      // btnDeleteUser
      // 
      this.btnDeleteUser.Caption = "Delete User";
      this.btnDeleteUser.Id = 2;
      this.btnDeleteUser.Name = "btnDeleteUser";
      this.btnDeleteUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteUser_ItemClick);
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
            this.btnChangePassword,
            this.btnDeleteUser,
            this.btnOpenDetails});
      this.barMan1.MaxItemId = 4;
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barMan1;
      this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.barDockControlTop.Size = new System.Drawing.Size(838, 0);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 544);
      this.barDockControlBottom.Manager = this.barMan1;
      this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.barDockControlBottom.Size = new System.Drawing.Size(838, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
      this.barDockControlLeft.Manager = this.barMan1;
      this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 544);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(838, 0);
      this.barDockControlRight.Manager = this.barMan1;
      this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 544);
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "barSubItem1";
      this.barSubItem1.Id = 0;
      this.barSubItem1.Name = "barSubItem1";
      // 
      // btnOpenDetails
      // 
      this.btnOpenDetails.Caption = "Open Details";
      this.btnOpenDetails.Id = 3;
      this.btnOpenDetails.Name = "btnOpenDetails";
      // 
      // popStoreList
      // 
      this.popStoreList.Controls.Add(this.lblStoreNum);
      this.popStoreList.Controls.Add(this.grdShipTos);
      this.popStoreList.Location = new System.Drawing.Point(280, 181);
      this.popStoreList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.popStoreList.Name = "popStoreList";
      this.popStoreList.Size = new System.Drawing.Size(546, 284);
      this.popStoreList.TabIndex = 8;
      this.popStoreList.Paint += new System.Windows.Forms.PaintEventHandler(this.popStoreList_Paint);
      // 
      // lblStoreNum
      // 
      this.lblStoreNum.AutoSize = true;
      this.lblStoreNum.Location = new System.Drawing.Point(3, 5);
      this.lblStoreNum.Name = "lblStoreNum";
      this.lblStoreNum.Size = new System.Drawing.Size(91, 13);
      this.lblStoreNum.TabIndex = 1;
      this.lblStoreNum.Text = "Editing user : nick";
      // 
      // grdShipTos
      // 
      this.grdShipTos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdShipTos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grdShipTos.Location = new System.Drawing.Point(0, 22);
      this.grdShipTos.MainView = this.gvShipTos;
      this.grdShipTos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grdShipTos.MenuManager = this.barMan1;
      this.grdShipTos.Name = "grdShipTos";
      this.grdShipTos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
      this.grdShipTos.Size = new System.Drawing.Size(546, 262);
      this.grdShipTos.TabIndex = 0;
      this.grdShipTos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvShipTos});
      // 
      // gvShipTos
      // 
      this.gvShipTos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gvShipTos.Appearance.HeaderPanel.Options.UseFont = true;
      this.gvShipTos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gvShipTos.Appearance.Row.Options.UseFont = true;
      this.gvShipTos.GridControl = this.grdShipTos;
      this.gvShipTos.Name = "gvShipTos";
      this.gvShipTos.OptionsCustomization.AllowGroup = false;
      this.gvShipTos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
      this.gvShipTos.OptionsView.ShowAutoFilterRow = true;
      this.gvShipTos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
      this.gvShipTos.OptionsView.ShowGroupPanel = false;
      this.gvShipTos.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvShipTos_CellValueChanging);
      // 
      // repositoryItemCheckEdit1
      // 
      this.repositoryItemCheckEdit1.AutoHeight = false;
      this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
      // 
      // btnExport
      // 
      this.btnExport.Location = new System.Drawing.Point(260, 41);
      this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new System.Drawing.Size(94, 24);
      this.btnExport.TabIndex = 13;
      this.btnExport.Text = "Export to Excel";
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // btnImport
      // 
      this.btnImport.Location = new System.Drawing.Point(360, 41);
      this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(94, 24);
      this.btnImport.TabIndex = 14;
      this.btnImport.Text = "Import from Excel";
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // loadingBar
      // 
      this.loadingBar.Appearance.BackColor = System.Drawing.Color.Transparent;
      this.loadingBar.Appearance.Options.UseBackColor = true;
      this.loadingBar.BarAnimationElementThickness = 2;
      this.loadingBar.Caption = "Please wait";
      this.loadingBar.Description = "Importing ";
      this.loadingBar.Location = new System.Drawing.Point(-1, 479);
      this.loadingBar.Name = "loadingBar";
      this.loadingBar.Size = new System.Drawing.Size(246, 66);
      this.loadingBar.TabIndex = 19;
      this.loadingBar.Text = "progressPanel1";
      this.loadingBar.Visible = false;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(751, 41);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 24;
      this.btnSearch.Text = "Search";
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtSearch
      // 
      this.txtSearch.Location = new System.Drawing.Point(520, 43);
      this.txtSearch.MenuManager = this.barMan1;
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Properties.NullValuePrompt = "Search by store name";
      this.txtSearch.Size = new System.Drawing.Size(225, 20);
      this.txtSearch.TabIndex = 25;
      // 
      // bgWorkUpload
      // 
      this.bgWorkUpload.WorkerReportsProgress = true;
      this.bgWorkUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkUpload_DoWork);
      this.bgWorkUpload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkUpload_ProgressChanged);
      this.bgWorkUpload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkUpload_RunWorkerCompleted);
      // 
      // frmWwwUsers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(838, 544);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.loadingBar);
      this.Controls.Add(this.btnImport);
      this.Controls.Add(this.btnExport);
      this.Controls.Add(this.popStoreList);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.grdWwwUsers);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "frmWwwUsers";
      this.Text = "Website User Setup";
      this.Load += new System.EventHandler(this.frmWwwUsers_Load);
      ((System.ComponentModel.ISupportInitialize)(this.wwwUserObjBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdWwwUsers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvWWWUsers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.popGrid1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barMan1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.popStoreList)).EndInit();
      this.popStoreList.ResumeLayout(false);
      this.popStoreList.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdShipTos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gvShipTos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
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
    private etc.NBSGrid grdWwwUsers;
    private etc.NBSGridView gvWWWUsers;
    private DevExpress.XtraEditors.SimpleButton btnDelete;
    private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraBars.PopupMenu popGrid1;
    private DevExpress.XtraBars.BarLargeButtonItem btnChangePassword;
    private DevExpress.XtraBars.BarLargeButtonItem btnDeleteUser;
    private DevExpress.XtraBars.BarLargeButtonItem btnOpenDetails;
    private DevExpress.XtraBars.BarManager barMan1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarSubItem barSubItem1;
    private DevExpress.XtraEditors.PopupContainerControl popStoreList;
    private DevExpress.XtraGrid.GridControl grdShipTos;
    private DevExpress.XtraGrid.Views.Grid.GridView gvShipTos;
    private System.Windows.Forms.Label lblStoreNum;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    private DevExpress.XtraEditors.SimpleButton btnImport;
    private DevExpress.XtraEditors.SimpleButton btnExport;
    private DevExpress.XtraWaitForm.ProgressPanel loadingBar;
    private DevExpress.XtraEditors.TextEdit txtSearch;
    private DevExpress.XtraEditors.SimpleButton btnSearch;
    private System.ComponentModel.BackgroundWorker bgWorkUpload;
  }
}