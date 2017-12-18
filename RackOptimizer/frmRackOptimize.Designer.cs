namespace RackOptimizer
{
  partial class frmRackOptimize
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
      Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRackOptimize));
      Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance24 = new Infragistics.Win.Appearance();
      this.cmbSession = new System.Windows.Forms.ComboBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblPartialShelves = new System.Windows.Forms.Label();
      this.lblTotalStores = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.grdPartialShelves = new Infragistics.Win.UltraWinGrid.UltraGrid();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.chkFullShelves = new System.Windows.Forms.CheckBox();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnApply = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.grdRackRound = new Infragistics.Win.UltraWinGrid.UltraGrid();
      this.lvRackRound = new System.Windows.Forms.ListView();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdPartialShelves)).BeginInit();
      this.tabPage2.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdRackRound)).BeginInit();
      this.SuspendLayout();
      // 
      // cmbSession
      // 
      this.cmbSession.FormattingEnabled = true;
      this.cmbSession.Location = new System.Drawing.Point(12, 28);
      this.cmbSession.Name = "cmbSession";
      this.cmbSession.Size = new System.Drawing.Size(253, 21);
      this.cmbSession.TabIndex = 0;
      this.cmbSession.SelectedIndexChanged += new System.EventHandler(this.cmbSession_SelectedIndexChanged);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.lblPartialShelves);
      this.panel1.Controls.Add(this.lblTotalStores);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(747, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(308, 84);
      this.panel1.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(279, 50);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(13, 13);
      this.label7.TabIndex = 8;
      this.label7.Text = "0";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(279, 32);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(13, 13);
      this.label6.TabIndex = 7;
      this.label6.Text = "0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.Color.Lime;
      this.label5.Location = new System.Drawing.Point(180, 50);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(71, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Round down:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.Color.Red;
      this.label4.Location = new System.Drawing.Point(180, 32);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(57, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Round up:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(23, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Total Stores:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Olive;
      this.label2.Location = new System.Drawing.Point(23, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Partial Shelves:";
      // 
      // lblPartialShelves
      // 
      this.lblPartialShelves.AutoSize = true;
      this.lblPartialShelves.Location = new System.Drawing.Point(122, 50);
      this.lblPartialShelves.Name = "lblPartialShelves";
      this.lblPartialShelves.Size = new System.Drawing.Size(13, 13);
      this.lblPartialShelves.TabIndex = 2;
      this.lblPartialShelves.Text = "0";
      // 
      // lblTotalStores
      // 
      this.lblTotalStores.AutoSize = true;
      this.lblTotalStores.Location = new System.Drawing.Point(122, 32);
      this.lblTotalStores.Name = "lblTotalStores";
      this.lblTotalStores.Size = new System.Drawing.Size(13, 13);
      this.lblTotalStores.TabIndex = 1;
      this.lblTotalStores.Text = "0";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Rack Analysis";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(12, 9);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(174, 13);
      this.label8.TabIndex = 9;
      this.label8.Text = "Replenishment Session Name";
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 79);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1047, 571);
      this.tabControl1.TabIndex = 10;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.grdPartialShelves);
      this.tabPage1.Controls.Add(this.panel2);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1039, 545);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Partial Shelves";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // grdPartialShelves
      // 
      appearance1.BackColor = System.Drawing.SystemColors.Window;
      appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
      this.grdPartialShelves.DisplayLayout.Appearance = appearance1;
      this.grdPartialShelves.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
      this.grdPartialShelves.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      this.grdPartialShelves.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
      appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
      appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
      appearance2.BorderColor = System.Drawing.SystemColors.Window;
      this.grdPartialShelves.DisplayLayout.GroupByBox.Appearance = appearance2;
      appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdPartialShelves.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
      this.grdPartialShelves.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      this.grdPartialShelves.DisplayLayout.GroupByBox.Hidden = true;
      appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
      appearance4.BackColor2 = System.Drawing.SystemColors.Control;
      appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdPartialShelves.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
      this.grdPartialShelves.DisplayLayout.MaxColScrollRegions = 1;
      this.grdPartialShelves.DisplayLayout.MaxRowScrollRegions = 1;
      appearance5.BackColor = System.Drawing.SystemColors.Window;
      appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.grdPartialShelves.DisplayLayout.Override.ActiveCellAppearance = appearance5;
      appearance6.BackColor = System.Drawing.SystemColors.Highlight;
      appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.grdPartialShelves.DisplayLayout.Override.ActiveRowAppearance = appearance6;
      this.grdPartialShelves.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
      this.grdPartialShelves.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
      this.grdPartialShelves.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
      appearance7.BackColor = System.Drawing.SystemColors.Window;
      this.grdPartialShelves.DisplayLayout.Override.CardAreaAppearance = appearance7;
      appearance8.BorderColor = System.Drawing.Color.Silver;
      appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
      this.grdPartialShelves.DisplayLayout.Override.CellAppearance = appearance8;
      this.grdPartialShelves.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
      this.grdPartialShelves.DisplayLayout.Override.CellPadding = 0;
      this.grdPartialShelves.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Row;
      this.grdPartialShelves.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange;
      this.grdPartialShelves.DisplayLayout.Override.FilterOperandStyle = Infragistics.Win.UltraWinGrid.FilterOperandStyle.Combo;
      this.grdPartialShelves.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains;
      this.grdPartialShelves.DisplayLayout.Override.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden;
      this.grdPartialShelves.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
      appearance9.BackColor = System.Drawing.SystemColors.Control;
      appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
      appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance9.BorderColor = System.Drawing.SystemColors.Window;
      this.grdPartialShelves.DisplayLayout.Override.GroupByRowAppearance = appearance9;
      appearance10.TextHAlignAsString = "Left";
      this.grdPartialShelves.DisplayLayout.Override.HeaderAppearance = appearance10;
      this.grdPartialShelves.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
      this.grdPartialShelves.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
      appearance11.BackColor = System.Drawing.SystemColors.Window;
      appearance11.BorderColor = System.Drawing.Color.Silver;
      this.grdPartialShelves.DisplayLayout.Override.RowAppearance = appearance11;
      this.grdPartialShelves.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
      appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
      this.grdPartialShelves.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
      this.grdPartialShelves.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
      this.grdPartialShelves.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
      this.grdPartialShelves.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdPartialShelves.Location = new System.Drawing.Point(3, 43);
      this.grdPartialShelves.Name = "grdPartialShelves";
      this.grdPartialShelves.Size = new System.Drawing.Size(1033, 499);
      this.grdPartialShelves.TabIndex = 0;
      this.grdPartialShelves.Text = "ultraGrid1";
      this.grdPartialShelves.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.grdPartialShelves_InitializeRow);
      this.grdPartialShelves.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdPartialShelves_KeyDown);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.grdRackRound);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(1039, 545);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Partial Racks";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // chkFullShelves
      // 
      this.chkFullShelves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.chkFullShelves.AutoSize = true;
      this.chkFullShelves.Location = new System.Drawing.Point(825, 6);
      this.chkFullShelves.Name = "chkFullShelves";
      this.chkFullShelves.Size = new System.Drawing.Size(121, 17);
      this.chkFullShelves.TabIndex = 11;
      this.chkFullShelves.Text = "Filter out full shelves";
      this.chkFullShelves.UseVisualStyleBackColor = true;
      this.chkFullShelves.CheckedChanged += new System.EventHandler(this.chkFullShelves_CheckedChanged);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(289, 26);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(90, 23);
      this.btnRefresh.TabIndex = 12;
      this.btnRefresh.Text = "Refresh Data";
      this.btnRefresh.UseVisualStyleBackColor = true;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.label9);
      this.panel2.Controls.Add(this.btnApply);
      this.panel2.Controls.Add(this.chkFullShelves);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1033, 40);
      this.panel2.TabIndex = 1;
      // 
      // btnApply
      // 
      this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnApply.Location = new System.Drawing.Point(952, 6);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(75, 31);
      this.btnApply.TabIndex = 12;
      this.btnApply.Text = "Apply";
      this.btnApply.UseVisualStyleBackColor = true;
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(3, 6);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(751, 32);
      this.label9.TabIndex = 13;
      this.label9.Text = resources.GetString("label9.Text");
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.lvRackRound);
      this.panel3.Location = new System.Drawing.Point(433, 12);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(308, 84);
      this.panel3.TabIndex = 13;
      // 
      // grdRackRound
      // 
      appearance13.BackColor = System.Drawing.SystemColors.Window;
      appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption;
      this.grdRackRound.DisplayLayout.Appearance = appearance13;
      this.grdRackRound.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      this.grdRackRound.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
      appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder;
      appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
      appearance14.BorderColor = System.Drawing.SystemColors.Window;
      this.grdRackRound.DisplayLayout.GroupByBox.Appearance = appearance14;
      appearance15.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdRackRound.DisplayLayout.GroupByBox.BandLabelAppearance = appearance15;
      this.grdRackRound.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight;
      appearance16.BackColor2 = System.Drawing.SystemColors.Control;
      appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance16.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdRackRound.DisplayLayout.GroupByBox.PromptAppearance = appearance16;
      this.grdRackRound.DisplayLayout.MaxColScrollRegions = 1;
      this.grdRackRound.DisplayLayout.MaxRowScrollRegions = 1;
      appearance17.BackColor = System.Drawing.SystemColors.Window;
      appearance17.ForeColor = System.Drawing.SystemColors.ControlText;
      this.grdRackRound.DisplayLayout.Override.ActiveCellAppearance = appearance17;
      appearance18.BackColor = System.Drawing.SystemColors.Highlight;
      appearance18.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.grdRackRound.DisplayLayout.Override.ActiveRowAppearance = appearance18;
      this.grdRackRound.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
      this.grdRackRound.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
      appearance19.BackColor = System.Drawing.SystemColors.Window;
      this.grdRackRound.DisplayLayout.Override.CardAreaAppearance = appearance19;
      appearance20.BorderColor = System.Drawing.Color.Silver;
      appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
      this.grdRackRound.DisplayLayout.Override.CellAppearance = appearance20;
      this.grdRackRound.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
      this.grdRackRound.DisplayLayout.Override.CellPadding = 0;
      appearance21.BackColor = System.Drawing.SystemColors.Control;
      appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
      appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance21.BorderColor = System.Drawing.SystemColors.Window;
      this.grdRackRound.DisplayLayout.Override.GroupByRowAppearance = appearance21;
      appearance22.TextHAlignAsString = "Left";
      this.grdRackRound.DisplayLayout.Override.HeaderAppearance = appearance22;
      this.grdRackRound.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
      this.grdRackRound.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
      appearance23.BackColor = System.Drawing.SystemColors.Window;
      appearance23.BorderColor = System.Drawing.Color.Silver;
      this.grdRackRound.DisplayLayout.Override.RowAppearance = appearance23;
      this.grdRackRound.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
      appearance24.BackColor = System.Drawing.SystemColors.ControlLight;
      this.grdRackRound.DisplayLayout.Override.TemplateAddRowAppearance = appearance24;
      this.grdRackRound.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
      this.grdRackRound.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
      this.grdRackRound.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
      this.grdRackRound.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdRackRound.Location = new System.Drawing.Point(3, 3);
      this.grdRackRound.Name = "grdRackRound";
      this.grdRackRound.Size = new System.Drawing.Size(1033, 539);
      this.grdRackRound.TabIndex = 0;
      this.grdRackRound.Text = "ultraGrid1";
      // 
      // lvRackRound
      // 
      this.lvRackRound.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lvRackRound.Location = new System.Drawing.Point(0, 0);
      this.lvRackRound.Name = "lvRackRound";
      this.lvRackRound.Size = new System.Drawing.Size(308, 84);
      this.lvRackRound.TabIndex = 0;
      this.lvRackRound.UseCompatibleStateImageBehavior = false;
      // 
      // frmRackOptimize
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1071, 662);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.cmbSession);
      this.Name = "frmRackOptimize";
      this.Text = "Rack Optimization";
      this.Load += new System.EventHandler(this.frmRackOptimize_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdPartialShelves)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdRackRound)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbSession;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblPartialShelves;
    private System.Windows.Forms.Label lblTotalStores;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private Infragistics.Win.UltraWinGrid.UltraGrid grdPartialShelves;
    private System.Windows.Forms.CheckBox chkFullShelves;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button btnApply;
    private Infragistics.Win.UltraWinGrid.UltraGrid grdRackRound;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.ListView lvRackRound;
  }
}

