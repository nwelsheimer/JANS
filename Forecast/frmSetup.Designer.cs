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
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.lbSKURegions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbInputName
            // 
            this.cmbInputName.FormattingEnabled = true;
            this.cmbInputName.ItemHeight = 23;
            this.cmbInputName.Location = new System.Drawing.Point(30, 95);
            this.cmbInputName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbInputName.Name = "cmbInputName";
            this.cmbInputName.Size = new System.Drawing.Size(227, 29);
            this.cmbInputName.TabIndex = 0;
            this.cmbInputName.UseSelectable = true;
            this.cmbInputName.SelectedIndexChanged += new System.EventHandler(this.cmbInputName_SelectedIndexChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.ItemHeight = 23;
            this.cmbCustomer.Location = new System.Drawing.Point(389, 95);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(231, 29);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.UseSelectable = true;
            // 
            // lbRegions
            // 
            this.lbRegions.FormattingEnabled = true;
            this.lbRegions.Location = new System.Drawing.Point(30, 157);
            this.lbRegions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbRegions.Name = "lbRegions";
            this.lbRegions.Size = new System.Drawing.Size(227, 212);
            this.lbRegions.TabIndex = 3;
            this.lbRegions.SelectedIndexChanged += new System.EventHandler(this.lbRegions_SelectedIndexChanged);
            // 
            // cbAssignedPlans
            // 
            this.cbAssignedPlans.FormattingEnabled = true;
            this.cbAssignedPlans.Location = new System.Drawing.Point(30, 464);
            this.cbAssignedPlans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAssignedPlans.Name = "cbAssignedPlans";
            this.cbAssignedPlans.Size = new System.Drawing.Size(231, 199);
            this.cbAssignedPlans.TabIndex = 4;
            // 
            // btnAddRegion
            // 
            this.btnAddRegion.Location = new System.Drawing.Point(165, 411);
            this.btnAddRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRegion.Name = "btnAddRegion";
            this.btnAddRegion.Size = new System.Drawing.Size(91, 23);
            this.btnAddRegion.TabIndex = 6;
            this.btnAddRegion.Text = "Add Region";
            this.btnAddRegion.UseSelectable = true;
            // 
            // txtNewRegion
            // 
            // 
            // 
            // 
            this.txtNewRegion.CustomButton.Image = null;
            this.txtNewRegion.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtNewRegion.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewRegion.CustomButton.Name = "";
            this.txtNewRegion.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtNewRegion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewRegion.CustomButton.TabIndex = 1;
            this.txtNewRegion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewRegion.CustomButton.UseSelectable = true;
            this.txtNewRegion.CustomButton.Visible = false;
            this.txtNewRegion.Lines = new string[0];
            this.txtNewRegion.Location = new System.Drawing.Point(30, 379);
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
            this.txtNewRegion.Size = new System.Drawing.Size(229, 23);
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
            this.metroLabel1.Size = new System.Drawing.Size(158, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Input Sheet Group";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(30, 130);
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
            this.metroLabel3.Location = new System.Drawing.Point(30, 437);
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
            this.metroLabel4.Location = new System.Drawing.Point(389, 130);
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
            this.metroLabel5.Location = new System.Drawing.Point(389, 68);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Assigned Customer";
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(261, 104);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(52, 12);
            this.metroLink1.TabIndex = 15;
            this.metroLink1.Text = "+ ADD";
            this.metroLink1.UseSelectable = true;
            // 
            // lbSKURegions
            // 
            this.lbSKURegions.FormattingEnabled = true;
            this.lbSKURegions.Location = new System.Drawing.Point(389, 157);
            this.lbSKURegions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSKURegions.Name = "lbSKURegions";
            this.lbSKURegions.Size = new System.Drawing.Size(227, 212);
            this.lbSKURegions.TabIndex = 16;
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 702);
            this.Controls.Add(this.lbSKURegions);
            this.Controls.Add(this.metroLink1);
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
            this.Name = "frmSetup";
            this.Padding = new System.Windows.Forms.Padding(11, 33, 11, 11);
            this.Resizable = false;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.frmSetup_Load);
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
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.ListBox lbSKURegions;
    }
}