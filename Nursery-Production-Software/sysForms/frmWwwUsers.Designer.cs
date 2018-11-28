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
      this.colisApproved = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colcreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.wwwUserObjBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdWwwUsers)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // defaultLookAndFeel1
      // 
      this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
      // 
      // wwwUserObjBindingSource
      // 
      this.wwwUserObjBindingSource.DataSource = typeof(NBSio.etc.dbobj.wwwUserObj);
      // 
      // grdWwwUsers
      // 
      this.grdWwwUsers.DataSource = this.wwwUserObjBindingSource;
      this.grdWwwUsers.Location = new System.Drawing.Point(12, 71);
      this.grdWwwUsers.MainView = this.gridView1;
      this.grdWwwUsers.Name = "grdWwwUsers";
      this.grdWwwUsers.Size = new System.Drawing.Size(814, 461);
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
      this.colvendorName.FieldName = "vendorName";
      this.colvendorName.Name = "colvendorName";
      this.colvendorName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
      this.colvendorName.Visible = true;
      this.colvendorName.VisibleIndex = 6;
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
      // frmWwwUsers
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(838, 544);
      this.Controls.Add(this.grdWwwUsers);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmWwwUsers";
      this.Text = "Website User Setup";
      this.Load += new System.EventHandler(this.frmWwwUsers_Load);
      ((System.ComponentModel.ISupportInitialize)(this.wwwUserObjBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdWwwUsers)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      this.ResumeLayout(false);

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
  }
}