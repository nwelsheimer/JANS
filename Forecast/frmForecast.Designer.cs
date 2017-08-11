namespace Forecast
{
    partial class frmForecast
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbInputGroup = new MetroFramework.Controls.MetroComboBox();
            this.cmbCustomer = new MetroFramework.Controls.MetroComboBox();
            this.cbRegions = new System.Windows.Forms.CheckedListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtStartWeek = new MetroFramework.Controls.MetroTextBox();
            this.txtEndWeek = new MetroFramework.Controls.MetroTextBox();
            this.btnSumVertical = new MetroFramework.Controls.MetroButton();
            this.btnSumHorizontal = new MetroFramework.Controls.MetroButton();
            this.cbPlannedLY = new System.Windows.Forms.CheckBox();
            this.cbShippedLY = new System.Windows.Forms.CheckBox();
            this.cbInputLY = new System.Windows.Forms.CheckBox();
            this.grdInputDetail = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.lnSetup = new MetroFramework.Controls.MetroLink();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.lnChooseColumns = new MetroFramework.Controls.MetroLink();
            this.lnSaveLayout = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdRetail = new System.Windows.Forms.RadioButton();
            this.rdUnits = new System.Windows.Forms.RadioButton();
            this.rdCost = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.bgLoading = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.grdInputDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 111);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Input Group";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 203);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Customer";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(473, 111);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Overlay Regions";
            // 
            // cmbInputGroup
            // 
            this.cmbInputGroup.Enabled = false;
            this.cmbInputGroup.FormattingEnabled = true;
            this.cmbInputGroup.ItemHeight = 23;
            this.cmbInputGroup.Location = new System.Drawing.Point(42, 151);
            this.cmbInputGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbInputGroup.Name = "cmbInputGroup";
            this.cmbInputGroup.Size = new System.Drawing.Size(409, 29);
            this.cmbInputGroup.TabIndex = 4;
            this.cmbInputGroup.UseSelectable = true;
            this.cmbInputGroup.SelectedIndexChanged += new System.EventHandler(this.cmbInputGroup_SelectedIndexChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Enabled = false;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.ItemHeight = 23;
            this.cmbCustomer.Location = new System.Drawing.Point(42, 244);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(409, 29);
            this.cmbCustomer.TabIndex = 5;
            this.cmbCustomer.UseSelectable = true;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cbRegions
            // 
            this.cbRegions.CheckOnClick = true;
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(473, 151);
            this.cbRegions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(418, 124);
            this.cbRegions.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(906, 111);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(185, 35);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Filter Weeks";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtStartWeek
            // 
            // 
            // 
            // 
            this.txtStartWeek.CustomButton.Image = null;
            this.txtStartWeek.CustomButton.Location = new System.Drawing.Point(84, 4);
            this.txtStartWeek.CustomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStartWeek.CustomButton.Name = "";
            this.txtStartWeek.CustomButton.Size = new System.Drawing.Size(68, 68);
            this.txtStartWeek.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStartWeek.CustomButton.TabIndex = 1;
            this.txtStartWeek.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStartWeek.CustomButton.UseSelectable = true;
            this.txtStartWeek.CustomButton.Visible = false;
            this.txtStartWeek.Lines = new string[] {
        "10"};
            this.txtStartWeek.Location = new System.Drawing.Point(906, 151);
            this.txtStartWeek.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStartWeek.MaxLength = 2;
            this.txtStartWeek.Name = "txtStartWeek";
            this.txtStartWeek.PasswordChar = '\0';
            this.txtStartWeek.PromptText = "01";
            this.txtStartWeek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStartWeek.SelectedText = "";
            this.txtStartWeek.SelectionLength = 0;
            this.txtStartWeek.SelectionStart = 0;
            this.txtStartWeek.ShortcutsEnabled = true;
            this.txtStartWeek.Size = new System.Drawing.Size(86, 42);
            this.txtStartWeek.TabIndex = 7;
            this.txtStartWeek.Text = "10";
            this.txtStartWeek.UseSelectable = true;
            this.txtStartWeek.WaterMark = "01";
            this.txtStartWeek.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStartWeek.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStartWeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartWeek_KeyPress);
            // 
            // txtEndWeek
            // 
            // 
            // 
            // 
            this.txtEndWeek.CustomButton.Image = null;
            this.txtEndWeek.CustomButton.Location = new System.Drawing.Point(84, 4);
            this.txtEndWeek.CustomButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEndWeek.CustomButton.Name = "";
            this.txtEndWeek.CustomButton.Size = new System.Drawing.Size(68, 68);
            this.txtEndWeek.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndWeek.CustomButton.TabIndex = 1;
            this.txtEndWeek.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndWeek.CustomButton.UseSelectable = true;
            this.txtEndWeek.CustomButton.Visible = false;
            this.txtEndWeek.Lines = new string[] {
        "30"};
            this.txtEndWeek.Location = new System.Drawing.Point(1005, 151);
            this.txtEndWeek.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEndWeek.MaxLength = 2;
            this.txtEndWeek.Name = "txtEndWeek";
            this.txtEndWeek.PasswordChar = '\0';
            this.txtEndWeek.PromptText = "52";
            this.txtEndWeek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndWeek.SelectedText = "";
            this.txtEndWeek.SelectionLength = 0;
            this.txtEndWeek.SelectionStart = 0;
            this.txtEndWeek.ShortcutsEnabled = true;
            this.txtEndWeek.Size = new System.Drawing.Size(86, 42);
            this.txtEndWeek.TabIndex = 8;
            this.txtEndWeek.Text = "30";
            this.txtEndWeek.UseSelectable = true;
            this.txtEndWeek.WaterMark = "52";
            this.txtEndWeek.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndWeek.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndWeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndWeek_KeyPress);
            // 
            // btnSumVertical
            // 
            this.btnSumVertical.Location = new System.Drawing.Point(1579, 257);
            this.btnSumVertical.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSumVertical.Name = "btnSumVertical";
            this.btnSumVertical.Size = new System.Drawing.Size(185, 42);
            this.btnSumVertical.TabIndex = 9;
            this.btnSumVertical.Text = "Sum vertically";
            this.btnSumVertical.UseSelectable = true;
            // 
            // btnSumHorizontal
            // 
            this.btnSumHorizontal.Location = new System.Drawing.Point(1579, 205);
            this.btnSumHorizontal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSumHorizontal.Name = "btnSumHorizontal";
            this.btnSumHorizontal.Size = new System.Drawing.Size(185, 42);
            this.btnSumHorizontal.TabIndex = 10;
            this.btnSumHorizontal.Text = "Sum horizontally";
            this.btnSumHorizontal.UseSelectable = true;
            // 
            // cbPlannedLY
            // 
            this.cbPlannedLY.AutoSize = true;
            this.cbPlannedLY.Location = new System.Drawing.Point(6, 61);
            this.cbPlannedLY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbPlannedLY.Name = "cbPlannedLY";
            this.cbPlannedLY.Size = new System.Drawing.Size(194, 29);
            this.cbPlannedLY.TabIndex = 11;
            this.cbPlannedLY.Text = "Show Planned LY";
            this.cbPlannedLY.UseVisualStyleBackColor = true;
            this.cbPlannedLY.CheckedChanged += new System.EventHandler(this.cbPlannedLY_CheckedChanged);
            // 
            // cbShippedLY
            // 
            this.cbShippedLY.AutoSize = true;
            this.cbShippedLY.Location = new System.Drawing.Point(6, 103);
            this.cbShippedLY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbShippedLY.Name = "cbShippedLY";
            this.cbShippedLY.Size = new System.Drawing.Size(195, 29);
            this.cbShippedLY.TabIndex = 12;
            this.cbShippedLY.Text = "Show Shipped LY";
            this.cbShippedLY.UseVisualStyleBackColor = true;
            this.cbShippedLY.CheckedChanged += new System.EventHandler(this.cbShippedLY_CheckedChanged);
            // 
            // cbInputLY
            // 
            this.cbInputLY.AutoSize = true;
            this.cbInputLY.Location = new System.Drawing.Point(6, 18);
            this.cbInputLY.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbInputLY.Name = "cbInputLY";
            this.cbInputLY.Size = new System.Drawing.Size(165, 29);
            this.cbInputLY.TabIndex = 14;
            this.cbInputLY.Text = "Show Input LY";
            this.cbInputLY.UseVisualStyleBackColor = true;
            this.cbInputLY.CheckedChanged += new System.EventHandler(this.cbInputLY_CheckedChanged);
            // 
            // grdInputDetail
            // 
            this.grdInputDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance1.ForeColorDisabled = System.Drawing.Color.Black;
            this.grdInputDetail.DisplayLayout.Appearance = appearance1;
            this.grdInputDetail.DisplayLayout.GroupByBox.Hidden = true;
            this.grdInputDetail.DisplayLayout.InterBandSpacing = 10;
            this.grdInputDetail.DisplayLayout.MaxColScrollRegions = 1;
            this.grdInputDetail.DisplayLayout.MaxRowScrollRegions = 1;
            this.grdInputDetail.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Synchronized;
            this.grdInputDetail.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.grdInputDetail.DisplayLayout.Override.CardAreaAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.Control;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.grdInputDetail.DisplayLayout.Override.CellAppearance = appearance3;
            this.grdInputDetail.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance4.BackColor = System.Drawing.SystemColors.Control;
            appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.grdInputDetail.DisplayLayout.Override.HeaderAppearance = appearance4;
            this.grdInputDetail.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdInputDetail.DisplayLayout.Override.RowSelectorAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance6.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.grdInputDetail.DisplayLayout.Override.SelectedRowAppearance = appearance6;
            this.grdInputDetail.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdInputDetail.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Dashed;
            this.grdInputDetail.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grdInputDetail.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grdInputDetail.Enabled = false;
            this.grdInputDetail.Location = new System.Drawing.Point(42, 308);
            this.grdInputDetail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdInputDetail.Name = "grdInputDetail";
            this.grdInputDetail.Size = new System.Drawing.Size(1852, 476);
            this.grdInputDetail.TabIndex = 16;
            this.grdInputDetail.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grdInputDetail_InitializeLayout);
            this.grdInputDetail.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.grdInputDetail_InitializeRow);
            this.grdInputDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdInputDetail_KeyDown);
            // 
            // lnSetup
            // 
            this.lnSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnSetup.Location = new System.Drawing.Point(1795, 255);
            this.lnSetup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lnSetup.Name = "lnSetup";
            this.lnSetup.Size = new System.Drawing.Size(99, 42);
            this.lnSetup.TabIndex = 17;
            this.lnSetup.Text = "Setup";
            this.lnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnSetup.UseSelectable = true;
            this.lnSetup.Click += new System.EventHandler(this.lnSetup_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(906, 212);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(185, 85);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lnChooseColumns
            // 
            this.lnChooseColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnChooseColumns.AutoSize = true;
            this.lnChooseColumns.Location = new System.Drawing.Point(42, 796);
            this.lnChooseColumns.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lnChooseColumns.Name = "lnChooseColumns";
            this.lnChooseColumns.Size = new System.Drawing.Size(183, 42);
            this.lnChooseColumns.TabIndex = 19;
            this.lnChooseColumns.Text = "Choose Columns";
            this.lnChooseColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnChooseColumns.UseSelectable = true;
            this.lnChooseColumns.Click += new System.EventHandler(this.lnChooseColumns_Click);
            // 
            // lnSaveLayout
            // 
            this.lnSaveLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnSaveLayout.Location = new System.Drawing.Point(237, 796);
            this.lnSaveLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lnSaveLayout.Name = "lnSaveLayout";
            this.lnSaveLayout.Size = new System.Drawing.Size(138, 42);
            this.lnSaveLayout.TabIndex = 20;
            this.lnSaveLayout.Text = "Save Layout";
            this.lnSaveLayout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnSaveLayout.UseSelectable = true;
            this.lnSaveLayout.Click += new System.EventHandler(this.lnSaveLayout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdRetail);
            this.groupBox1.Controls.Add(this.rdUnits);
            this.groupBox1.Controls.Add(this.rdCost);
            this.groupBox1.Location = new System.Drawing.Point(1344, 142);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(224, 157);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display historical";
            // 
            // rdRetail
            // 
            this.rdRetail.AutoSize = true;
            this.rdRetail.Location = new System.Drawing.Point(11, 114);
            this.rdRetail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdRetail.Name = "rdRetail";
            this.rdRetail.Size = new System.Drawing.Size(85, 29);
            this.rdRetail.TabIndex = 2;
            this.rdRetail.Text = "Retail";
            this.rdRetail.UseVisualStyleBackColor = true;
            // 
            // rdUnits
            // 
            this.rdUnits.AutoSize = true;
            this.rdUnits.Checked = true;
            this.rdUnits.Location = new System.Drawing.Point(11, 30);
            this.rdUnits.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdUnits.Name = "rdUnits";
            this.rdUnits.Size = new System.Drawing.Size(81, 29);
            this.rdUnits.TabIndex = 1;
            this.rdUnits.TabStop = true;
            this.rdUnits.Text = "Units";
            this.rdUnits.UseVisualStyleBackColor = true;
            // 
            // rdCost
            // 
            this.rdCost.AutoSize = true;
            this.rdCost.Location = new System.Drawing.Point(11, 72);
            this.rdCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdCost.Name = "rdCost";
            this.rdCost.Size = new System.Drawing.Size(168, 29);
            this.rdCost.TabIndex = 0;
            this.rdCost.Text = "Customer Cost";
            this.rdCost.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbPlannedLY);
            this.panel1.Controls.Add(this.cbInputLY);
            this.panel1.Controls.Add(this.cbShippedLY);
            this.panel1.Location = new System.Drawing.Point(1109, 153);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 142);
            this.panel1.TabIndex = 22;
            // 
            // loadingSpinner
            // 
            this.loadingSpinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingSpinner.BackColor = System.Drawing.Color.DarkGray;
            this.loadingSpinner.Location = new System.Drawing.Point(944, 503);
            this.loadingSpinner.Maximum = 100;
            this.loadingSpinner.Name = "loadingSpinner";
            this.loadingSpinner.Size = new System.Drawing.Size(49, 47);
            this.loadingSpinner.Speed = 2F;
            this.loadingSpinner.Spinning = false;
            this.loadingSpinner.TabIndex = 23;
            this.loadingSpinner.UseSelectable = true;
            this.loadingSpinner.Value = 50;
            this.loadingSpinner.Visible = false;
            // 
            // bgLoading
            // 
            this.bgLoading.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLoading_DoWork);
            this.bgLoading.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLoading_RunWorkerCompleted);
            // 
            // frmForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1936, 846);
            this.Controls.Add(this.loadingSpinner);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lnSaveLayout);
            this.Controls.Add(this.lnChooseColumns);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lnSetup);
            this.Controls.Add(this.grdInputDetail);
            this.Controls.Add(this.btnSumHorizontal);
            this.Controls.Add(this.btnSumVertical);
            this.Controls.Add(this.txtEndWeek);
            this.Controls.Add(this.txtStartWeek);
            this.Controls.Add(this.cbRegions);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.cmbInputGroup);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmForecast";
            this.Padding = new System.Windows.Forms.Padding(37, 111, 37, 37);
            this.Text = "Forecasting";
            this.Load += new System.EventHandler(this.frmForecast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInputDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbInputGroup;
        private MetroFramework.Controls.MetroComboBox cmbCustomer;
        private System.Windows.Forms.CheckedListBox cbRegions;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtStartWeek;
        private MetroFramework.Controls.MetroTextBox txtEndWeek;
        private MetroFramework.Controls.MetroButton btnSumVertical;
        private MetroFramework.Controls.MetroButton btnSumHorizontal;
        private System.Windows.Forms.CheckBox cbPlannedLY;
        private System.Windows.Forms.CheckBox cbShippedLY;
        private System.Windows.Forms.CheckBox cbInputLY;
        private Infragistics.Win.UltraWinGrid.UltraGrid grdInputDetail;
        private MetroFramework.Controls.MetroLink lnSetup;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroLink lnChooseColumns;
        private MetroFramework.Controls.MetroLink lnSaveLayout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdUnits;
        private System.Windows.Forms.RadioButton rdCost;
        private System.Windows.Forms.RadioButton rdRetail;
        private MetroFramework.Controls.MetroProgressSpinner loadingSpinner;
        private System.ComponentModel.BackgroundWorker bgLoading;
    }
}

