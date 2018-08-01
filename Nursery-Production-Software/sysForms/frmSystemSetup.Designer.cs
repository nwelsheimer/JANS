namespace Nursery_Production_Software.sysForms
{
  partial class frmSystemSetup
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tbSites = new System.Windows.Forms.TabPage();
      this.GLAccounts = new System.Windows.Forms.TabPage();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.chkDefault = new System.Windows.Forms.CheckBox();
      this.cmbSelectSite = new System.Windows.Forms.ComboBox();
      this.txtState = new System.Windows.Forms.TextBox();
      this.chkManaged = new System.Windows.Forms.CheckBox();
      this.txtCity = new System.Windows.Forms.TextBox();
      this.txtAddress1 = new System.Windows.Forms.TextBox();
      this.txtZip = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.txtAddress2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tbPeriod = new System.Windows.Forms.TabPage();
      this.tabControl1.SuspendLayout();
      this.tbSites.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tbSites);
      this.tabControl1.Controls.Add(this.GLAccounts);
      this.tabControl1.Controls.Add(this.tbPeriod);
      this.tabControl1.Location = new System.Drawing.Point(12, 22);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(770, 482);
      this.tabControl1.TabIndex = 10;
      // 
      // tbSites
      // 
      this.tbSites.Controls.Add(this.label3);
      this.tbSites.Controls.Add(this.label4);
      this.tbSites.Controls.Add(this.label2);
      this.tbSites.Controls.Add(this.label1);
      this.tbSites.Controls.Add(this.txtDescription);
      this.tbSites.Controls.Add(this.chkDefault);
      this.tbSites.Controls.Add(this.cmbSelectSite);
      this.tbSites.Controls.Add(this.txtState);
      this.tbSites.Controls.Add(this.chkManaged);
      this.tbSites.Controls.Add(this.txtCity);
      this.tbSites.Controls.Add(this.txtAddress1);
      this.tbSites.Controls.Add(this.txtZip);
      this.tbSites.Controls.Add(this.txtPhone);
      this.tbSites.Controls.Add(this.txtAddress2);
      this.tbSites.Location = new System.Drawing.Point(4, 29);
      this.tbSites.Name = "tbSites";
      this.tbSites.Padding = new System.Windows.Forms.Padding(3);
      this.tbSites.Size = new System.Drawing.Size(762, 449);
      this.tbSites.TabIndex = 0;
      this.tbSites.Text = "Sites";
      this.tbSites.UseVisualStyleBackColor = true;
      // 
      // GLAccounts
      // 
      this.GLAccounts.Location = new System.Drawing.Point(4, 29);
      this.GLAccounts.Name = "GLAccounts";
      this.GLAccounts.Padding = new System.Windows.Forms.Padding(3);
      this.GLAccounts.Size = new System.Drawing.Size(762, 449);
      this.GLAccounts.TabIndex = 1;
      this.GLAccounts.Text = "GL Accounts";
      this.GLAccounts.UseVisualStyleBackColor = true;
      // 
      // txtDescription
      // 
      this.txtDescription.Location = new System.Drawing.Point(116, 104);
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Size = new System.Drawing.Size(290, 26);
      this.txtDescription.TabIndex = 11;
      // 
      // chkDefault
      // 
      this.chkDefault.AutoSize = true;
      this.chkDefault.Location = new System.Drawing.Point(116, 276);
      this.chkDefault.Name = "chkDefault";
      this.chkDefault.Size = new System.Drawing.Size(87, 24);
      this.chkDefault.TabIndex = 19;
      this.chkDefault.Text = "Default";
      this.chkDefault.UseVisualStyleBackColor = true;
      // 
      // cmbSelectSite
      // 
      this.cmbSelectSite.FormattingEnabled = true;
      this.cmbSelectSite.Location = new System.Drawing.Point(19, 51);
      this.cmbSelectSite.Name = "cmbSelectSite";
      this.cmbSelectSite.Size = new System.Drawing.Size(387, 28);
      this.cmbSelectSite.TabIndex = 10;
      // 
      // txtState
      // 
      this.txtState.Location = new System.Drawing.Point(294, 200);
      this.txtState.Name = "txtState";
      this.txtState.Size = new System.Drawing.Size(40, 26);
      this.txtState.TabIndex = 15;
      // 
      // chkManaged
      // 
      this.chkManaged.AutoSize = true;
      this.chkManaged.Location = new System.Drawing.Point(272, 276);
      this.chkManaged.Name = "chkManaged";
      this.chkManaged.Size = new System.Drawing.Size(134, 24);
      this.chkManaged.TabIndex = 18;
      this.chkManaged.Text = "Managed Site";
      this.chkManaged.UseVisualStyleBackColor = true;
      // 
      // txtCity
      // 
      this.txtCity.Location = new System.Drawing.Point(116, 200);
      this.txtCity.Name = "txtCity";
      this.txtCity.Size = new System.Drawing.Size(172, 26);
      this.txtCity.TabIndex = 14;
      // 
      // txtAddress1
      // 
      this.txtAddress1.Location = new System.Drawing.Point(116, 136);
      this.txtAddress1.Name = "txtAddress1";
      this.txtAddress1.Size = new System.Drawing.Size(290, 26);
      this.txtAddress1.TabIndex = 12;
      // 
      // txtZip
      // 
      this.txtZip.Location = new System.Drawing.Point(340, 200);
      this.txtZip.Name = "txtZip";
      this.txtZip.Size = new System.Drawing.Size(66, 26);
      this.txtZip.TabIndex = 16;
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(116, 232);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(290, 26);
      this.txtPhone.TabIndex = 17;
      // 
      // txtAddress2
      // 
      this.txtAddress2.Location = new System.Drawing.Point(116, 168);
      this.txtAddress2.Name = "txtAddress2";
      this.txtAddress2.Size = new System.Drawing.Size(290, 26);
      this.txtAddress2.TabIndex = 13;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 107);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 20);
      this.label1.TabIndex = 20;
      this.label1.Text = "Description";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(42, 136);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 20);
      this.label2.TabIndex = 21;
      this.label2.Text = "Address";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(55, 232);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 20);
      this.label4.TabIndex = 23;
      this.label4.Text = "Phone";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 28);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 20);
      this.label3.TabIndex = 24;
      this.label3.Text = "Select Site";
      // 
      // tbPeriod
      // 
      this.tbPeriod.Location = new System.Drawing.Point(4, 29);
      this.tbPeriod.Name = "tbPeriod";
      this.tbPeriod.Size = new System.Drawing.Size(762, 449);
      this.tbPeriod.TabIndex = 2;
      this.tbPeriod.Text = "GL Period";
      this.tbPeriod.UseVisualStyleBackColor = true;
      // 
      // frmSystemSetup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(792, 509);
      this.Controls.Add(this.tabControl1);
      this.Name = "frmSystemSetup";
      this.Text = "Company Setup";
      this.Load += new System.EventHandler(this.frmSystemSetup_Load);
      this.tabControl1.ResumeLayout(false);
      this.tbSites.ResumeLayout(false);
      this.tbSites.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tbSites;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.CheckBox chkDefault;
    private System.Windows.Forms.ComboBox cmbSelectSite;
    private System.Windows.Forms.TextBox txtState;
    private System.Windows.Forms.CheckBox chkManaged;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.TextBox txtAddress1;
    private System.Windows.Forms.TextBox txtZip;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.TextBox txtAddress2;
    private System.Windows.Forms.TabPage GLAccounts;
    private System.Windows.Forms.TabPage tbPeriod;
  }
}