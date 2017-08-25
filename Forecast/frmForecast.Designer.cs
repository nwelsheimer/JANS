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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.grdInputDetail = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.lnSetup = new MetroFramework.Controls.MetroLink();
            this.lnChooseColumns = new MetroFramework.Controls.MetroLink();
            this.lnSaveLayout = new MetroFramework.Controls.MetroLink();
            this.bgHeader = new System.ComponentModel.BackgroundWorker();
            this.bgDetail = new System.ComponentModel.BackgroundWorker();
            this.pnLoading = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMainMenu = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.grdSummary = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraSplitter2 = new Infragistics.Win.Misc.UltraSplitter();
            this.ultraSplitter1 = new Infragistics.Win.Misc.UltraSplitter();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPlannedLY = new System.Windows.Forms.CheckBox();
            this.cbInputLY = new System.Windows.Forms.CheckBox();
            this.cbShippedLY = new System.Windows.Forms.CheckBox();
            this.btnSumHorizontal = new MetroFramework.Controls.MetroButton();
            this.btnSumVertical = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdRetail = new System.Windows.Forms.RadioButton();
            this.rdUnits = new System.Windows.Forms.RadioButton();
            this.rdCost = new System.Windows.Forms.RadioButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lnExport = new MetroFramework.Controls.MetroLink();
            this.pnColapse = new MetroFramework.Controls.MetroPanel();
            this.pnExpand = new MetroFramework.Controls.MetroPanel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbCustomer = new MetroFramework.Controls.MetroComboBox();
            this.cbRegions = new System.Windows.Forms.CheckedListBox();
            this.cmbInputGroup = new MetroFramework.Controls.MetroComboBox();
            this.txtStartWeek = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtEndWeek = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.exportExcel = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdInputDetail)).BeginInit();
            this.pnLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnMainMenu.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSummary)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.grdInputDetail.Location = new System.Drawing.Point(7, 175);
            this.grdInputDetail.Name = "grdInputDetail";
            this.grdInputDetail.Size = new System.Drawing.Size(704, 265);
            this.grdInputDetail.TabIndex = 16;
            this.grdInputDetail.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.grdInputDetail_AfterCellUpdate);
            this.grdInputDetail.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grdInputDetail_InitializeLayout);
            this.grdInputDetail.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.grdInputDetail_InitializeRow);
            this.grdInputDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdInputDetail_KeyDown);
            // 
            // lnSetup
            // 
            this.lnSetup.Location = new System.Drawing.Point(3, 58);
            this.lnSetup.Name = "lnSetup";
            this.lnSetup.Size = new System.Drawing.Size(54, 23);
            this.lnSetup.TabIndex = 17;
            this.lnSetup.Text = "Setup";
            this.lnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnSetup.UseSelectable = true;
            this.lnSetup.Click += new System.EventHandler(this.lnSetup_Click);
            // 
            // lnChooseColumns
            // 
            this.lnChooseColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnChooseColumns.AutoSize = true;
            this.lnChooseColumns.Location = new System.Drawing.Point(7, 446);
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
            this.lnSaveLayout.Location = new System.Drawing.Point(113, 446);
            this.lnSaveLayout.Name = "lnSaveLayout";
            this.lnSaveLayout.Size = new System.Drawing.Size(75, 23);
            this.lnSaveLayout.TabIndex = 20;
            this.lnSaveLayout.Text = "Save Layout";
            this.lnSaveLayout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnSaveLayout.UseSelectable = true;
            this.lnSaveLayout.Click += new System.EventHandler(this.lnSaveLayout_Click);
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
            this.pnLoading.Location = new System.Drawing.Point(184, 209);
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
            // pnMainMenu
            // 
            this.pnMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMainMenu.Controls.Add(this.metroPanel4);
            this.pnMainMenu.Controls.Add(this.ultraSplitter2);
            this.pnMainMenu.Controls.Add(this.ultraSplitter1);
            this.pnMainMenu.Controls.Add(this.metroPanel3);
            this.pnMainMenu.Controls.Add(this.metroPanel1);
            this.pnMainMenu.HorizontalScrollbarBarColor = true;
            this.pnMainMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMainMenu.HorizontalScrollbarSize = 5;
            this.pnMainMenu.Location = new System.Drawing.Point(7, 51);
            this.pnMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMainMenu.Name = "pnMainMenu";
            this.pnMainMenu.Size = new System.Drawing.Size(705, 120);
            this.pnMainMenu.TabIndex = 28;
            this.pnMainMenu.VerticalScrollbarBarColor = true;
            this.pnMainMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnMainMenu.VerticalScrollbarSize = 5;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.grdSummary);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 5;
            this.metroPanel4.Location = new System.Drawing.Point(493, 0);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(0, 118);
            this.metroPanel4.TabIndex = 32;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 5;
            // 
            // grdSummary
            // 
            appearance7.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.grdSummary.DisplayLayout.Appearance = appearance7;
            this.grdSummary.DisplayLayout.InterBandSpacing = 10;
            appearance8.BackColor = System.Drawing.Color.Transparent;
            this.grdSummary.DisplayLayout.Override.CardAreaAppearance = appearance8;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.grdSummary.DisplayLayout.Override.CellAppearance = appearance9;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.grdSummary.DisplayLayout.Override.HeaderAppearance = appearance10;
            appearance11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdSummary.DisplayLayout.Override.RowSelectorAppearance = appearance11;
            appearance12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance12.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.grdSummary.DisplayLayout.Override.SelectedRowAppearance = appearance12;
            this.grdSummary.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdSummary.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Dashed;
            this.grdSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSummary.Enabled = false;
            this.grdSummary.Location = new System.Drawing.Point(0, 0);
            this.grdSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdSummary.Name = "grdSummary";
            this.grdSummary.Size = new System.Drawing.Size(0, 118);
            this.grdSummary.TabIndex = 2;
            this.grdSummary.Text = "Summary Information";
            // 
            // ultraSplitter2
            // 
            this.ultraSplitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ultraSplitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.ultraSplitter2.Location = new System.Drawing.Point(431, 0);
            this.ultraSplitter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ultraSplitter2.Name = "ultraSplitter2";
            this.ultraSplitter2.RestoreExtent = 471;
            this.ultraSplitter2.Size = new System.Drawing.Size(15, 118);
            this.ultraSplitter2.TabIndex = 31;
            // 
            // ultraSplitter1
            // 
            this.ultraSplitter1.Location = new System.Drawing.Point(478, 0);
            this.ultraSplitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ultraSplitter1.Name = "ultraSplitter1";
            this.ultraSplitter1.RestoreExtent = 719;
            this.ultraSplitter1.Size = new System.Drawing.Size(15, 118);
            this.ultraSplitter1.TabIndex = 30;
            // 
            // metroPanel3
            // 
            this.metroPanel3.AutoScroll = true;
            this.metroPanel3.Controls.Add(this.panel1);
            this.metroPanel3.Controls.Add(this.btnSumHorizontal);
            this.metroPanel3.Controls.Add(this.btnSumVertical);
            this.metroPanel3.Controls.Add(this.groupBox1);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel3.HorizontalScrollbar = true;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 8;
            this.metroPanel3.Location = new System.Drawing.Point(446, 0);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(257, 118);
            this.metroPanel3.TabIndex = 29;
            this.metroPanel3.VerticalScrollbar = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbPlannedLY);
            this.panel1.Controls.Add(this.cbInputLY);
            this.panel1.Controls.Add(this.cbShippedLY);
            this.panel1.Location = new System.Drawing.Point(134, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 65);
            this.panel1.TabIndex = 22;
            // 
            // cbPlannedLY
            // 
            this.cbPlannedLY.AutoSize = true;
            this.cbPlannedLY.Enabled = false;
            this.cbPlannedLY.Location = new System.Drawing.Point(3, 23);
            this.cbPlannedLY.Name = "cbPlannedLY";
            this.cbPlannedLY.Size = new System.Drawing.Size(111, 17);
            this.cbPlannedLY.TabIndex = 11;
            this.cbPlannedLY.Text = "Show Planned LY";
            this.cbPlannedLY.UseVisualStyleBackColor = true;
            this.cbPlannedLY.CheckedChanged += new System.EventHandler(this.cbPlannedLY_CheckedChanged);
            // 
            // cbInputLY
            // 
            this.cbInputLY.AutoSize = true;
            this.cbInputLY.Enabled = false;
            this.cbInputLY.Location = new System.Drawing.Point(3, 3);
            this.cbInputLY.Name = "cbInputLY";
            this.cbInputLY.Size = new System.Drawing.Size(96, 17);
            this.cbInputLY.TabIndex = 14;
            this.cbInputLY.Text = "Show Input LY";
            this.cbInputLY.UseVisualStyleBackColor = true;
            this.cbInputLY.CheckedChanged += new System.EventHandler(this.cbInputLY_CheckedChanged);
            // 
            // cbShippedLY
            // 
            this.cbShippedLY.AutoSize = true;
            this.cbShippedLY.Enabled = false;
            this.cbShippedLY.Location = new System.Drawing.Point(3, 42);
            this.cbShippedLY.Name = "cbShippedLY";
            this.cbShippedLY.Size = new System.Drawing.Size(111, 17);
            this.cbShippedLY.TabIndex = 12;
            this.cbShippedLY.Text = "Show Shipped LY";
            this.cbShippedLY.UseVisualStyleBackColor = true;
            this.cbShippedLY.CheckedChanged += new System.EventHandler(this.cbShippedLY_CheckedChanged);
            // 
            // btnSumHorizontal
            // 
            this.btnSumHorizontal.Location = new System.Drawing.Point(134, 79);
            this.btnSumHorizontal.Name = "btnSumHorizontal";
            this.btnSumHorizontal.Size = new System.Drawing.Size(120, 30);
            this.btnSumHorizontal.TabIndex = 10;
            this.btnSumHorizontal.Text = "Sum horizontally";
            this.btnSumHorizontal.UseSelectable = true;
            // 
            // btnSumVertical
            // 
            this.btnSumVertical.Location = new System.Drawing.Point(5, 79);
            this.btnSumVertical.Name = "btnSumVertical";
            this.btnSumVertical.Size = new System.Drawing.Size(122, 30);
            this.btnSumVertical.TabIndex = 9;
            this.btnSumVertical.Text = "Sum vertically";
            this.btnSumVertical.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdRetail);
            this.groupBox1.Controls.Add(this.rdUnits);
            this.groupBox1.Controls.Add(this.rdCost);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 70);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display historical";
            // 
            // rdRetail
            // 
            this.rdRetail.AutoSize = true;
            this.rdRetail.Location = new System.Drawing.Point(5, 51);
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
            this.rdUnits.Location = new System.Drawing.Point(5, 14);
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
            this.rdCost.Location = new System.Drawing.Point(5, 32);
            this.rdCost.Name = "rdCost";
            this.rdCost.Size = new System.Drawing.Size(93, 17);
            this.rdCost.TabIndex = 0;
            this.rdCost.Text = "Customer Cost";
            this.rdCost.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.lnExport);
            this.metroPanel1.Controls.Add(this.lnSetup);
            this.metroPanel1.Controls.Add(this.pnColapse);
            this.metroPanel1.Controls.Add(this.pnExpand);
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cmbCustomer);
            this.metroPanel1.Controls.Add(this.cbRegions);
            this.metroPanel1.Controls.Add(this.cmbInputGroup);
            this.metroPanel1.Controls.Add(this.txtStartWeek);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtEndWeek);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(478, 118);
            this.metroPanel1.TabIndex = 28;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 5;
            // 
            // lnExport
            // 
            this.lnExport.Location = new System.Drawing.Point(216, 82);
            this.lnExport.Name = "lnExport";
            this.lnExport.Size = new System.Drawing.Size(97, 23);
            this.lnExport.TabIndex = 27;
            this.lnExport.Text = "Export to Excel";
            this.lnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnExport.UseSelectable = true;
            this.lnExport.Click += new System.EventHandler(this.lnExport_Click);
            // 
            // pnColapse
            // 
            this.pnColapse.BackgroundImage = global::Forecast.Properties.Resources.delete;
            this.pnColapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnColapse.Enabled = false;
            this.pnColapse.HorizontalScrollbarBarColor = true;
            this.pnColapse.HorizontalScrollbarHighlightOnWheel = false;
            this.pnColapse.HorizontalScrollbarSize = 5;
            this.pnColapse.Location = new System.Drawing.Point(21, 90);
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
            this.pnExpand.Location = new System.Drawing.Point(3, 90);
            this.pnExpand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnExpand.Name = "pnExpand";
            this.pnExpand.Size = new System.Drawing.Size(14, 14);
            this.pnExpand.TabIndex = 25;
            this.pnExpand.VerticalScrollbarBarColor = true;
            this.pnExpand.VerticalScrollbarHighlightOnWheel = false;
            this.pnExpand.VerticalScrollbarSize = 5;
            this.pnExpand.Click += new System.EventHandler(this.pnExpand_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(383, 62);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 36);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Location = new System.Drawing.Point(75, 62);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 17);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Filter Weeks";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Enabled = false;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.ItemHeight = 23;
            this.cmbCustomer.Location = new System.Drawing.Point(150, 23);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(185, 29);
            this.cmbCustomer.TabIndex = 5;
            this.cmbCustomer.UseSelectable = true;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cbRegions
            // 
            this.cbRegions.CheckOnClick = true;
            this.cbRegions.FormattingEnabled = true;
            this.cbRegions.Location = new System.Drawing.Point(341, 3);
            this.cbRegions.Name = "cbRegions";
            this.cbRegions.Size = new System.Drawing.Size(133, 49);
            this.cbRegions.TabIndex = 6;
            // 
            // cmbInputGroup
            // 
            this.cmbInputGroup.Enabled = false;
            this.cmbInputGroup.FormattingEnabled = true;
            this.cmbInputGroup.ItemHeight = 23;
            this.cmbInputGroup.Location = new System.Drawing.Point(3, 23);
            this.cmbInputGroup.Name = "cmbInputGroup";
            this.cmbInputGroup.Size = new System.Drawing.Size(141, 29);
            this.cmbInputGroup.TabIndex = 4;
            this.cmbInputGroup.UseSelectable = true;
            this.cmbInputGroup.SelectedIndexChanged += new System.EventHandler(this.cmbInputGroup_SelectedIndexChanged);
            // 
            // txtStartWeek
            // 
            // 
            // 
            // 
            this.txtStartWeek.CustomButton.Image = null;
            this.txtStartWeek.CustomButton.Location = new System.Drawing.Point(16, 1);
            this.txtStartWeek.CustomButton.Name = "";
            this.txtStartWeek.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtStartWeek.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStartWeek.CustomButton.TabIndex = 1;
            this.txtStartWeek.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStartWeek.CustomButton.UseSelectable = true;
            this.txtStartWeek.CustomButton.Visible = false;
            this.txtStartWeek.Lines = new string[] {
        "10"};
            this.txtStartWeek.Location = new System.Drawing.Point(76, 82);
            this.txtStartWeek.MaxLength = 2;
            this.txtStartWeek.Name = "txtStartWeek";
            this.txtStartWeek.PasswordChar = '\0';
            this.txtStartWeek.PromptText = "01";
            this.txtStartWeek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStartWeek.SelectedText = "";
            this.txtStartWeek.SelectionLength = 0;
            this.txtStartWeek.SelectionStart = 0;
            this.txtStartWeek.ShortcutsEnabled = true;
            this.txtStartWeek.Size = new System.Drawing.Size(51, 23);
            this.txtStartWeek.TabIndex = 7;
            this.txtStartWeek.Text = "10";
            this.txtStartWeek.UseSelectable = true;
            this.txtStartWeek.WaterMark = "01";
            this.txtStartWeek.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStartWeek.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStartWeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartWeek_KeyPress);
            this.txtStartWeek.Leave += new System.EventHandler(this.txtStartWeek_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(150, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Customer";
            // 
            // txtEndWeek
            // 
            // 
            // 
            // 
            this.txtEndWeek.CustomButton.Image = null;
            this.txtEndWeek.CustomButton.Location = new System.Drawing.Point(16, 1);
            this.txtEndWeek.CustomButton.Name = "";
            this.txtEndWeek.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtEndWeek.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEndWeek.CustomButton.TabIndex = 1;
            this.txtEndWeek.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEndWeek.CustomButton.UseSelectable = true;
            this.txtEndWeek.CustomButton.Visible = false;
            this.txtEndWeek.Lines = new string[] {
        "30"};
            this.txtEndWeek.Location = new System.Drawing.Point(141, 82);
            this.txtEndWeek.MaxLength = 2;
            this.txtEndWeek.Name = "txtEndWeek";
            this.txtEndWeek.PasswordChar = '\0';
            this.txtEndWeek.PromptText = "52";
            this.txtEndWeek.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEndWeek.SelectedText = "";
            this.txtEndWeek.SelectionLength = 0;
            this.txtEndWeek.SelectionStart = 0;
            this.txtEndWeek.ShortcutsEnabled = true;
            this.txtEndWeek.Size = new System.Drawing.Size(51, 23);
            this.txtEndWeek.TabIndex = 8;
            this.txtEndWeek.Text = "30";
            this.txtEndWeek.UseSelectable = true;
            this.txtEndWeek.WaterMark = "52";
            this.txtEndWeek.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEndWeek.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEndWeek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndWeek_KeyPress);
            this.txtEndWeek.Leave += new System.EventHandler(this.txtEndWeek_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Input Group";
            // 
            // exportExcel
            // 
            this.exportExcel.BandSpacing = Infragistics.Win.UltraWinGrid.ExcelExport.BandSpacing.None;
            this.exportExcel.ExportStarted += new Infragistics.Win.UltraWinGrid.ExcelExport.ExportStartedEventHandler(this.exportExcel_ExportStarted);
            // 
            // frmForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 472);
            this.Controls.Add(this.pnMainMenu);
            this.Controls.Add(this.pnLoading);
            this.Controls.Add(this.lnSaveLayout);
            this.Controls.Add(this.lnChooseColumns);
            this.Controls.Add(this.grdInputDetail);
            this.Name = "frmForecast";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "Forecast";
            this.Load += new System.EventHandler(this.frmForecast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInputDetail)).EndInit();
            this.pnLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnMainMenu.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSummary)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Infragistics.Win.UltraWinGrid.UltraGrid grdInputDetail;
        private MetroFramework.Controls.MetroLink lnSetup;
        private MetroFramework.Controls.MetroLink lnChooseColumns;
        private MetroFramework.Controls.MetroLink lnSaveLayout;
        private MetroFramework.Controls.MetroPanel pnLoading;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.ComponentModel.BackgroundWorker bgHeader;
        private System.ComponentModel.BackgroundWorker bgDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel pnMainMenu;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private Infragistics.Win.Misc.UltraSplitter ultraSplitter2;
        private Infragistics.Win.Misc.UltraSplitter ultraSplitter1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbPlannedLY;
        private System.Windows.Forms.CheckBox cbInputLY;
        private System.Windows.Forms.CheckBox cbShippedLY;
        private MetroFramework.Controls.MetroButton btnSumHorizontal;
        private MetroFramework.Controls.MetroButton btnSumVertical;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdRetail;
        private System.Windows.Forms.RadioButton rdUnits;
        private System.Windows.Forms.RadioButton rdCost;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel pnColapse;
        private MetroFramework.Controls.MetroPanel pnExpand;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbCustomer;
        private System.Windows.Forms.CheckedListBox cbRegions;
        private MetroFramework.Controls.MetroComboBox cmbInputGroup;
        private MetroFramework.Controls.MetroTextBox txtStartWeek;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtEndWeek;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Infragistics.Win.UltraWinGrid.UltraGrid grdSummary;
        private MetroFramework.Controls.MetroLink lnExport;
        private Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter exportExcel;
    }
}

