namespace Forecast
{
    partial class frmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
            this.cmbInputName = new MetroFramework.Controls.MetroComboBox();
            this.cmbCustomer = new MetroFramework.Controls.MetroComboBox();
            this.lbRegions = new System.Windows.Forms.ListBox();
            this.cbAssignedPlans = new System.Windows.Forms.CheckedListBox();
            this.btnAddRegion = new MetroFramework.Controls.MetroButton();
            this.txtNewRegion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lbSKURegions = new System.Windows.Forms.ListBox();
            this.lnReset = new MetroFramework.Controls.MetroLink();
            this.cbCopyFrom = new System.Windows.Forms.CheckBox();
            this.txtNewInputName = new MetroFramework.Controls.MetroTextBox();
            this.btnAddGroup = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtYear = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbInputName
            // 
            this.cmbInputName.FormattingEnabled = true;
            this.cmbInputName.ItemHeight = 23;
            this.cmbInputName.Location = new System.Drawing.Point(30, 95);
            this.cmbInputName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbInputName.Name = "cmbInputName";
            this.cmbInputName.Size = new System.Drawing.Size(275, 29);
            this.cmbInputName.TabIndex = 0;
            this.cmbInputName.UseSelectable = true;
            this.cmbInputName.SelectedIndexChanged += new System.EventHandler(this.cmbInputName_SelectedIndexChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.ItemHeight = 23;
            this.cmbCustomer.Location = new System.Drawing.Point(341, 95);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(278, 29);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.UseSelectable = true;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // lbRegions
            // 
            this.lbRegions.FormattingEnabled = true;
            this.lbRegions.Location = new System.Drawing.Point(30, 360);
            this.lbRegions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbRegions.Name = "lbRegions";
            this.lbRegions.Size = new System.Drawing.Size(275, 212);
            this.lbRegions.TabIndex = 3;
            this.lbRegions.SelectedIndexChanged += new System.EventHandler(this.lbRegions_SelectedIndexChanged);
            // 
            // cbAssignedPlans
            // 
            this.cbAssignedPlans.CheckOnClick = true;
            this.cbAssignedPlans.FormattingEnabled = true;
            this.cbAssignedPlans.Location = new System.Drawing.Point(341, 408);
            this.cbAssignedPlans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAssignedPlans.Name = "cbAssignedPlans";
            this.cbAssignedPlans.Size = new System.Drawing.Size(275, 199);
            this.cbAssignedPlans.TabIndex = 4;
            this.cbAssignedPlans.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbAssignedPlans_ItemCheck);
            // 
            // btnAddRegion
            // 
            this.btnAddRegion.Location = new System.Drawing.Point(212, 618);
            this.btnAddRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRegion.Name = "btnAddRegion";
            this.btnAddRegion.Size = new System.Drawing.Size(91, 23);
            this.btnAddRegion.TabIndex = 6;
            this.btnAddRegion.Text = "Add Region";
            this.btnAddRegion.UseSelectable = true;
            this.btnAddRegion.Click += new System.EventHandler(this.btnAddRegion_Click);
            // 
            // txtNewRegion
            // 
            // 
            // 
            // 
            this.txtNewRegion.CustomButton.Image = null;
            this.txtNewRegion.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtNewRegion.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewRegion.CustomButton.Name = "";
            this.txtNewRegion.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtNewRegion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewRegion.CustomButton.TabIndex = 1;
            this.txtNewRegion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewRegion.CustomButton.UseSelectable = true;
            this.txtNewRegion.CustomButton.Visible = false;
            this.txtNewRegion.Lines = new string[0];
            this.txtNewRegion.Location = new System.Drawing.Point(30, 582);
            this.txtNewRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewRegion.MaxLength = 32767;
            this.txtNewRegion.Name = "txtNewRegion";
            this.txtNewRegion.PasswordChar = '\0';
            this.txtNewRegion.PromptText = "New Region";
            this.txtNewRegion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewRegion.SelectedText = "";
            this.txtNewRegion.SelectionLength = 0;
            this.txtNewRegion.SelectionStart = 0;
            this.txtNewRegion.ShortcutsEnabled = true;
            this.txtNewRegion.Size = new System.Drawing.Size(273, 23);
            this.txtNewRegion.TabIndex = 8;
            this.txtNewRegion.UseSelectable = true;
            this.txtNewRegion.WaterMark = "New Region";
            this.txtNewRegion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewRegion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(30, 68);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Input Sheet Group";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(30, 333);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Regions";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(339, 380);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Assigned Plans";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(341, 129);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "SKU / Regions";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(341, 68);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Assigned Customer";
            // 
            // lbSKURegions
            // 
            this.lbSKURegions.FormattingEnabled = true;
            this.lbSKURegions.Location = new System.Drawing.Point(341, 157);
            this.lbSKURegions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSKURegions.Name = "lbSKURegions";
            this.lbSKURegions.Size = new System.Drawing.Size(275, 212);
            this.lbSKURegions.TabIndex = 16;
            this.lbSKURegions.SelectedIndexChanged += new System.EventHandler(this.lbSKURegions_SelectedIndexChanged);
            // 
            // lnReset
            // 
            this.lnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnReset.Location = new System.Drawing.Point(469, 619);
            this.lnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lnReset.Name = "lnReset";
            this.lnReset.Size = new System.Drawing.Size(145, 21);
            this.lnReset.TabIndex = 17;
            this.lnReset.Text = "Reset Defaults";
            this.lnReset.UseSelectable = true;
            this.lnReset.Click += new System.EventHandler(this.lnReset_Click);
            // 
            // cbCopyFrom
            // 
            this.cbCopyFrom.AutoSize = true;
            this.cbCopyFrom.Location = new System.Drawing.Point(158, 111);
            this.cbCopyFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCopyFrom.Name = "cbCopyFrom";
            this.cbCopyFrom.Size = new System.Drawing.Size(111, 17);
            this.cbCopyFrom.TabIndex = 18;
            this.cbCopyFrom.Text = "Copy from existing";
            this.cbCopyFrom.UseVisualStyleBackColor = true;
            // 
            // txtNewInputName
            // 
            // 
            // 
            // 
            this.txtNewInputName.CustomButton.Image = null;
            this.txtNewInputName.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtNewInputName.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewInputName.CustomButton.Name = "";
            this.txtNewInputName.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtNewInputName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewInputName.CustomButton.TabIndex = 1;
            this.txtNewInputName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewInputName.CustomButton.UseSelectable = true;
            this.txtNewInputName.CustomButton.Visible = false;
            this.txtNewInputName.Lines = new string[0];
            this.txtNewInputName.Location = new System.Drawing.Point(7, 132);
            this.txtNewInputName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewInputName.MaxLength = 32767;
            this.txtNewInputName.Name = "txtNewInputName";
            this.txtNewInputName.PasswordChar = '\0';
            this.txtNewInputName.PromptText = "New Input Group Name";
            this.txtNewInputName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewInputName.SelectedText = "";
            this.txtNewInputName.SelectionLength = 0;
            this.txtNewInputName.SelectionStart = 0;
            this.txtNewInputName.ShortcutsEnabled = true;
            this.txtNewInputName.Size = new System.Drawing.Size(262, 23);
            this.txtNewInputName.TabIndex = 19;
            this.txtNewInputName.UseSelectable = true;
            this.txtNewInputName.WaterMark = "New Input Group Name";
            this.txtNewInputName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewInputName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(178, 159);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(91, 23);
            this.btnAddGroup.TabIndex = 20;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.UseSelectable = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(7, 5);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(194, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Add new input sheet group:";
            this.metroLabel6.WrapToLine = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(7, 22);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(257, 95);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = resources.GetString("metroLabel7.Text");
            this.metroLabel7.WrapToLine = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtYear);
            this.metroPanel1.Controls.Add(this.cbCopyFrom);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.btnAddGroup);
            this.metroPanel1.Controls.Add(this.txtNewInputName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 5;
            this.metroPanel1.Location = new System.Drawing.Point(30, 135);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(274, 186);
            this.metroPanel1.TabIndex = 23;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 5;
            // 
            // txtYear
            // 
            // 
            // 
            // 
            this.txtYear.CustomButton.Image = null;
            this.txtYear.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.txtYear.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.CustomButton.Name = "";
            this.txtYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYear.CustomButton.TabIndex = 1;
            this.txtYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYear.CustomButton.UseSelectable = true;
            this.txtYear.CustomButton.Visible = false;
            this.txtYear.Lines = new string[0];
            this.txtYear.Location = new System.Drawing.Point(7, 159);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.MaxLength = 32767;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PromptText = "Year (2015)";
            this.txtYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYear.SelectedText = "";
            this.txtYear.SelectionLength = 0;
            this.txtYear.SelectionStart = 0;
            this.txtYear.ShortcutsEnabled = true;
            this.txtYear.Size = new System.Drawing.Size(77, 23);
            this.txtYear.TabIndex = 23;
            this.txtYear.UseSelectable = true;
            this.txtYear.WaterMark = "Year (2015)";
            this.txtYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 670);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lnReset);
            this.Controls.Add(this.lbSKURegions);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNewRegion);
            this.Controls.Add(this.btnAddRegion);
            this.Controls.Add(this.cbAssignedPlans);
            this.Controls.Add(this.lbRegions);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.cmbInputName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmSetup";
            this.Padding = new System.Windows.Forms.Padding(11, 60, 11, 11);
            this.Resizable = false;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.frmSetup_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbInputName;
        private MetroFramework.Controls.MetroComboBox cmbCustomer;
        private System.Windows.Forms.ListBox lbRegions;
        private System.Windows.Forms.CheckedListBox cbAssignedPlans;
        private MetroFramework.Controls.MetroButton btnAddRegion;
        private MetroFramework.Controls.MetroTextBox txtNewRegion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ListBox lbSKURegions;
        private MetroFramework.Controls.MetroLink lnReset;
        private System.Windows.Forms.CheckBox cbCopyFrom;
        private MetroFramework.Controls.MetroTextBox txtNewInputName;
        private MetroFramework.Controls.MetroButton btnAddGroup;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtYear;
    }
}