namespace InventoryControl
{
    partial class frmInvDim
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
      this.grdDIM = new Infragistics.Win.UltraWinGrid.UltraGrid();
      this.cmbSelectSite = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.grdDIM)).BeginInit();
      this.SuspendLayout();
      // 
      // grdDIM
      // 
      this.grdDIM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      appearance1.BackColor = System.Drawing.SystemColors.Window;
      appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
      this.grdDIM.DisplayLayout.Appearance = appearance1;
      this.grdDIM.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
      this.grdDIM.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      this.grdDIM.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
      appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
      appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
      appearance2.BorderColor = System.Drawing.SystemColors.Window;
      this.grdDIM.DisplayLayout.GroupByBox.Appearance = appearance2;
      appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdDIM.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
      this.grdDIM.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      this.grdDIM.DisplayLayout.GroupByBox.Hidden = true;
      appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
      appearance4.BackColor2 = System.Drawing.SystemColors.Control;
      appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdDIM.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
      this.grdDIM.DisplayLayout.MaxColScrollRegions = 1;
      this.grdDIM.DisplayLayout.MaxRowScrollRegions = 1;
      appearance5.BackColor = System.Drawing.SystemColors.Window;
      appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.grdDIM.DisplayLayout.Override.ActiveCellAppearance = appearance5;
      appearance6.BackColor = System.Drawing.SystemColors.Highlight;
      appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.grdDIM.DisplayLayout.Override.ActiveRowAppearance = appearance6;
      this.grdDIM.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
      this.grdDIM.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
      this.grdDIM.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
      appearance7.BackColor = System.Drawing.SystemColors.Window;
      this.grdDIM.DisplayLayout.Override.CardAreaAppearance = appearance7;
      appearance8.BorderColor = System.Drawing.Color.Silver;
      appearance8.ForeColorDisabled = System.Drawing.Color.Black;
      appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
      this.grdDIM.DisplayLayout.Override.CellAppearance = appearance8;
      this.grdDIM.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
      this.grdDIM.DisplayLayout.Override.CellPadding = 0;
      this.grdDIM.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Hidden;
      this.grdDIM.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains;
      this.grdDIM.DisplayLayout.Override.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden;
      this.grdDIM.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
      appearance9.BackColor = System.Drawing.SystemColors.Control;
      appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
      appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance9.BorderColor = System.Drawing.SystemColors.Window;
      this.grdDIM.DisplayLayout.Override.GroupByRowAppearance = appearance9;
      appearance10.TextHAlignAsString = "Left";
      this.grdDIM.DisplayLayout.Override.HeaderAppearance = appearance10;
      this.grdDIM.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
      this.grdDIM.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
      appearance11.BackColor = System.Drawing.SystemColors.Window;
      appearance11.BorderColor = System.Drawing.Color.Silver;
      this.grdDIM.DisplayLayout.Override.RowAppearance = appearance11;
      this.grdDIM.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
      appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
      this.grdDIM.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
      this.grdDIM.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
      this.grdDIM.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
      this.grdDIM.Location = new System.Drawing.Point(18, 51);
      this.grdDIM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grdDIM.Name = "grdDIM";
      this.grdDIM.Size = new System.Drawing.Size(1524, 926);
      this.grdDIM.TabIndex = 3;
      this.grdDIM.Text = "ultraGrid1";
      this.grdDIM.AfterRowUpdate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.grdDIM_AfterRowUpdate);
      // 
      // cmbSelectSite
      // 
      this.cmbSelectSite.FormattingEnabled = true;
      this.cmbSelectSite.Location = new System.Drawing.Point(130, 9);
      this.cmbSelectSite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmbSelectSite.Name = "cmbSelectSite";
      this.cmbSelectSite.Size = new System.Drawing.Size(180, 28);
      this.cmbSelectSite.TabIndex = 4;
      this.cmbSelectSite.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSite_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 14);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(90, 20);
      this.label1.TabIndex = 5;
      this.label1.Text = "Select Site:";
      // 
      // frmInvDim
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1560, 995);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbSelectSite);
      this.Controls.Add(this.grdDIM);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "frmInvDim";
      this.Text = "Inventory Dimension Control";
      ((System.ComponentModel.ISupportInitialize)(this.grdDIM)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private Infragistics.Win.UltraWinGrid.UltraGrid grdDIM;
    private System.Windows.Forms.ComboBox cmbSelectSite;
    private System.Windows.Forms.Label label1;
  }
}

