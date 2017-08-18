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
            this.bgHeader = new System.ComponentModel.BackgroundWorker();
            this.bgDetail = new System.ComponentModel.BackgroundWorker();
            this.pnColapse = new MetroFramework.Controls.MetroPanel();
            this.pnExpand = new MetroFramework.Controls.MetroPanel();
            this.pnLoading = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdInputDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Input Group";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(58, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Customer";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(258, 60);
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
            this.cmbInputGroup.Location = new System.Drawing.Point(58, 82);
            this.cmbInputGroup.Name = "cmbInputGroup";
            this.cmbInputGroup.Size = new System.Drawing.Size(191, 29);
            this.cmbInputGroup.TabIndex = 4;
            this.cmbInputGroup.UseSelectable = true;
            this.cmbInputGroup.SelectedIndexChanged += new System.EventHandler(this.cmbInputGroup_SelectedIndexChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Enabled = false;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.ItemHeight = 23;
            this.cmbCustomer.Location = new System.Drawing.Point(58, 132);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(191, 29);
            this.cmbCustomer.TabIndex = 5;
            this.cmbCustomer.UseSelectable = true;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cbRegions
            // 
            this.cbRegions.CheckOnClick = true;
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(258, 82);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(230, 49);
            this.cbRegions.TabIndex = 6;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(494, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 18);
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
            this.txtStartWeek.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.txtStartWeek.CustomButton.Name = "";
            this.txtStartWeek.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtStartWeek.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStartWeek.CustomButton.TabIndex = 1;
            this.txtStartWeek.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStartWeek.CustomButton.UseSelectable = true;
            this.txtStartWeek.CustomButton.Visible = false;
            this.txtStartWeek.Lines = new string[] {
        "10"};
            this.txtStartWeek.Location = new System.Drawing.Point(494, 82);
            this.txtStartWeek.MaxLength = 2;
            this.txtStartWeek.Name = "txtStartWeek";
            this.txtStartWeek.PasswordChar = '\0';
            this.txtStartWeek.PromptText = "01";
            this.txtStartWeek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStartWeek.SelectedText = "";
            this.txtStartWeek.SelectionLength = 0;
            this.txtStartWeek.SelectionStart = 0;
            this.txtStartWeek.ShortcutsEnabled = true;
            this.txtStartWeek.Size = new System.Drawing.Size(47, 23);
            this.txtStartWeek.TabIndex = 7;
            this.txtStartWeek.Text = "10";
            this.txtStartWeek.UseSelectable = true;
            this.txtStartWeek.WaterMark = "01";
            this.txtStartWeek.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStartWeek.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStartWeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartWeek_KeyPress);
            this.txtStartWeek.Leave += new System.EventHandler(this.txtStartWeek_Leave);
            // 
            // txtEndWeek
            // 
            // 
            // 
            // 
            this.txtEndWeek.CustomButton.Image = null;
            this.txtEndWeek.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.txtEndWeek.CustomButton.Name = "";
            this.txtEndWeek.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtEndWeek.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndWeek.CustomButton.TabIndex = 1;
            this.txtEndWeek.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndWeek.CustomButton.UseSelectable = true;
            this.txtEndWeek.CustomButton.Visible = false;
            this.txtEndWeek.Lines = new string[] {
        "30"};
            this.txtEndWeek.Location = new System.Drawing.Point(548, 82);
            this.txtEndWeek.MaxLength = 2;
            this.txtEndWeek.Name = "txtEndWeek";
            this.txtEndWeek.PasswordChar = '\0';
            this.txtEndWeek.PromptText = "52";
            this.txtEndWeek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndWeek.SelectedText = "";
            this.txtEndWeek.SelectionLength = 0;
            this.txtEndWeek.SelectionStart = 0;
            this.txtEndWeek.ShortcutsEnabled = true;
            this.txtEndWeek.Size = new System.Drawing.Size(47, 23);
            this.txtEndWeek.TabIndex = 8;
            this.txtEndWeek.Text = "30";
            this.txtEndWeek.UseSelectable = true;
            this.txtEndWeek.WaterMark = "52";
            this.txtEndWeek.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndWeek.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndWeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndWeek_KeyPress);
            this.txtEndWeek.Leave += new System.EventHandler(this.txtEndWeek_Leave);
            // 
            // btnSumVertical
            // 
            this.btnSumVertical.Location = new System.Drawing.Point(861, 139);
            this.btnSumVertical.Name = "btnSumVertical";
            this.btnSumVertical.Size = new System.Drawing.Size(101, 23);
            this.btnSumVertical.TabIndex = 9;
            this.btnSumVertical.Text = "Sum vertically";
            this.btnSumVertical.UseSelectable = true;
            // 
            // btnSumHorizontal
            // 
            this.btnSumHorizontal.Location = new System.Drawing.Point(861, 112);
            this.btnSumHorizontal.Name = "btnSumHorizontal";
            this.btnSumHorizontal.Size = new System.Drawing.Size(101, 23);
            this.btnSumHorizontal.TabIndex = 10;
            this.btnSumHorizontal.Text = "Sum horizontally";
            this.btnSumHorizontal.UseSelectable = true;
            // 
            // cbPlannedLY
            // 
            this.cbPlannedLY.AutoSize = true;
            this.cbPlannedLY.Enabled = false;
            this.cbPlannedLY.Location = new System.Drawing.Point(3, 34);
            this.cbPlannedLY.Name = "cbPlannedLY";
            this.cbPlannedLY.Size = new System.Drawing.Size(111, 17);
            this.cbPlannedLY.TabIndex = 11;
            this.cbPlannedLY.Text = "Show Planned LY";
            this.cbPlannedLY.UseVisualStyleBackColor = true;
            this.cbPlannedLY.CheckedChanged += new System.EventHandler(this.cbPlannedLY_CheckedChanged);
            // 
            // cbShippedLY
            // 
            this.cbShippedLY.AutoSize = true;
            this.cbShippedLY.Enabled = false;
            this.cbShippedLY.Location = new System.Drawing.Point(3, 56);
            this.cbShippedLY.Name = "cbShippedLY";
            this.cbShippedLY.Size = new System.Drawing.Size(111, 17);
            this.cbShippedLY.TabIndex = 12;
            this.cbShippedLY.Text = "Show Shipped LY";
            this.cbShippedLY.UseVisualStyleBackColor = true;
            this.cbShippedLY.CheckedChanged += new System.EventHandler(this.cbShippedLY_CheckedChanged);
            // 
            // cbInputLY
            // 
            this.cbInputLY.AutoSize = true;
            this.cbInputLY.Enabled = false;
            this.cbInputLY.Location = new System.Drawing.Point(3, 10);
            this.cbInputLY.Name = "cbInputLY";
            this.cbInputLY.Size = new System.Drawing.Size(96, 17);
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
            appearance1.ForeColorDisabled = System.Drawing.Color.DimGray;
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
            this.grdInputDetail.Location = new System.Drawing.Point(23, 167);
            this.grdInputDetail.Name = "grdInputDetail";
            this.grdInputDetail.Size = new System.Drawing.Size(1004, 252);
            this.grdInputDetail.TabIndex = 16;
            this.grdInputDetail.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.grdInputDetail_AfterCellUpdate);
            this.grdInputDetail.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grdInputDetail_InitializeLayout);
            this.grdInputDetail.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.grdInputDetail_InitializeRow);
            this.grdInputDetail.BeforeCellUpdate += new Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventHandler(this.grdInputDetail_BeforeCellUpdate);
            this.grdInputDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdInputDetail_KeyDown);
            // 
            // lnSetup
            // 
            this.lnSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnSetup.Location = new System.Drawing.Point(980, 138);
            this.lnSetup.Name = "lnSetup";
            this.lnSetup.Size = new System.Drawing.Size(54, 23);
            this.lnSetup.TabIndex = 17;
            this.lnSetup.Text = "Setup";
            this.lnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnSetup.UseSelectable = true;
            this.lnSetup.Click += new System.EventHandler(this.lnSetup_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(494, 115);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 47);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lnChooseColumns
            // 
            this.lnChooseColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnChooseColumns.AutoSize = true;
            this.lnChooseColumns.Location = new System.Drawing.Point(23, 427);
            this.lnChooseColumns.Name = "lnChooseColumns";
            this.lnChooseColumns.Size = new System.Drawing.Size(100, 23);
            this.lnChooseColumns.TabIndex = 19;
            this.lnChooseColumns.Text = "Choose Columns";
            this.lnChooseColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnChooseColumns.UseSelectable = true;
            this.lnChooseColumns.Click += new System.EventHandler(this.lnChooseColumns_Click);
            // 
            // lnSaveLayout
            // 
            this.lnSaveLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnSaveLayout.Location = new System.Drawing.Point(129, 427);
            this.lnSaveLayout.Name = "lnSaveLayout";
            this.lnSaveLayout.Size = new System.Drawing.Size(75, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(733, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 86);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display historical";
            // 
            // rdRetail
            // 
            this.rdRetail.AutoSize = true;
            this.rdRetail.Location = new System.Drawing.Point(6, 62);
            this.rdRetail.Name = "rdRetail";
            this.rdRetail.Size = new System.Drawing.Size(52, 17);
            this.rdRetail.TabIndex = 2;
            this.rdRetail.Text = "Retail";
            this.rdRetail.UseVisualStyleBackColor = true;
            // 
            // rdUnits
            // 
            this.rdUnits.AutoSize = true;
            this.rdUnits.Checked = true;
            this.rdUnits.Location = new System.Drawing.Point(6, 16);
            this.rdUnits.Name = "rdUnits";
            this.rdUnits.Size = new System.Drawing.Size(49, 17);
            this.rdUnits.TabIndex = 1;
            this.rdUnits.TabStop = true;
            this.rdUnits.Text = "Units";
            this.rdUnits.UseVisualStyleBackColor = true;
            // 
            // rdCost
            // 
            this.rdCost.AutoSize = true;
            this.rdCost.Location = new System.Drawing.Point(6, 39);
            this.rdCost.Name = "rdCost";
            this.rdCost.Size = new System.Drawing.Size(93, 17);
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
            this.panel1.Location = new System.Drawing.Point(605, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 78);
            this.panel1.TabIndex = 22;
            // 
            // bgHeader
            // 
            this.bgHeader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgHeader_DoWork);
            this.bgHeader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgHeader_RunWorkerCompleted);
            // 
            // bgDetail
            // 
            this.bgDetail.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgDetail_DoWork);
            this.bgDetail.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgDetail_RunWorkerCompleted);
            // 
            // pnColapse
            // 
            this.pnColapse.BackgroundImage = global::Forecast.Properties.Resources.delete;
            this.pnColapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnColapse.Enabled = false;
            this.pnColapse.HorizontalScrollbarBarColor = true;
            this.pnColapse.HorizontalScrollbarHighlightOnWheel = false;
            this.pnColapse.HorizontalScrollbarSize = 5;
            this.pnColapse.Location = new System.Drawing.Point(40, 149);
            this.pnColapse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnColapse.Name = "pnColapse";
            this.pnColapse.Size = new System.Drawing.Size(14, 14);
            this.pnColapse.TabIndex = 26;
            this.pnColapse.VerticalScrollbarBarColor = true;
            this.pnColapse.VerticalScrollbarHighlightOnWheel = false;
            this.pnColapse.VerticalScrollbarSize = 5;
            this.pnColapse.Click += new System.EventHandler(this.pnColapse_Click);
            // 
            // pnExpand
            // 
            this.pnExpand.BackgroundImage = global::Forecast.Properties.Resources.add;
            this.pnExpand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnExpand.Enabled = false;
            this.pnExpand.HorizontalScrollbarBarColor = true;
            this.pnExpand.HorizontalScrollbarHighlightOnWheel = false;
            this.pnExpand.HorizontalScrollbarSize = 5;
            this.pnExpand.Location = new System.Drawing.Point(23, 149);
            this.pnExpand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnExpand.Name = "pnExpand";
            this.pnExpand.Size = new System.Drawing.Size(14, 14);
            this.pnExpand.TabIndex = 25;
            this.pnExpand.VerticalScrollbarBarColor = true;
            this.pnExpand.VerticalScrollbarHighlightOnWheel = false;
            this.pnExpand.VerticalScrollbarSize = 5;
            this.pnExpand.Click += new System.EventHandler(this.pnExpand_Click);
            // 
            // pnLoading
            // 
            this.pnLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLoading.Controls.Add(this.metroLabel5);
            this.pnLoading.Controls.Add(this.pictureBox1);
            this.pnLoading.HorizontalScrollbarBarColor = true;
            this.pnLoading.HorizontalScrollbarHighlightOnWheel = false;
            this.pnLoading.HorizontalScrollbarSize = 5;
            this.pnLoading.Location = new System.Drawing.Point(352, 138);
            this.pnLoading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnLoading.Name = "pnLoading";
            this.pnLoading.Size = new System.Drawing.Size(347, 170);
            this.pnLoading.TabIndex = 24;
            this.pnLoading.VerticalScrollbarBarColor = true;
            this.pnLoading.VerticalScrollbarHighlightOnWheel = false;
            this.pnLoading.VerticalScrollbarSize = 5;
            this.pnLoading.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(83, 2);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(179, 30);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Loading Input Data...";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forecast.Properties.Resources.trumperpillar2;
            this.pictureBox1.Location = new System.Drawing.Point(2, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 134);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frmForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 453);
            this.Controls.Add(this.pnColapse);
            this.Controls.Add(this.pnExpand);
            this.Controls.Add(this.pnLoading);
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
            this.Name = "frmForecast";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 21);
            this.Text = "Forecasting";
            this.Load += new System.EventHandler(this.frmForecast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInputDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MetroFramework.Controls.MetroPanel pnLoading;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel pnExpand;
        private MetroFramework.Controls.MetroPanel pnColapse;
        private System.ComponentModel.BackgroundWorker bgHeader;
        private System.ComponentModel.BackgroundWorker bgDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

