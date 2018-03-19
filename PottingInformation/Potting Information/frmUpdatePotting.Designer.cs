namespace Potting_Information
{
  partial class frmUpdatePotting
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
      this.lblLotId = new System.Windows.Forms.Label();
      this.lblItemName = new System.Windows.Forms.Label();
      this.pIPottingLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.grdInputItems = new System.Windows.Forms.DataGridView();
      this.btnClose = new System.Windows.Forms.Button();
      this.lblFromSize = new System.Windows.Forms.Label();
      this.grdPottingDetail = new Infragistics.Win.UltraWinGrid.UltraGrid();
      ((System.ComponentModel.ISupportInitialize)(this.pIPottingLogBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdInputItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdPottingDetail)).BeginInit();
      this.SuspendLayout();
      // 
      // lblLotId
      // 
      this.lblLotId.AutoSize = true;
      this.lblLotId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLotId.Location = new System.Drawing.Point(12, 9);
      this.lblLotId.Name = "lblLotId";
      this.lblLotId.Size = new System.Drawing.Size(116, 20);
      this.lblLotId.TabIndex = 0;
      this.lblLotId.Text = "Lot Id: 12345";
      // 
      // lblItemName
      // 
      this.lblItemName.AutoSize = true;
      this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblItemName.Location = new System.Drawing.Point(12, 29);
      this.lblItemName.Name = "lblItemName";
      this.lblItemName.Size = new System.Drawing.Size(142, 20);
      this.lblItemName.TabIndex = 2;
      this.lblItemName.Text = "Item Information";
      // 
      // pIPottingLogBindingSource
      // 
      this.pIPottingLogBindingSource.DataMember = "PI_PottingLog";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 56);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(158, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Input driver log information here:";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 232);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(153, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Select locations for input items:";
      // 
      // grdInputItems
      // 
      this.grdInputItems.AllowUserToAddRows = false;
      this.grdInputItems.AllowUserToDeleteRows = false;
      this.grdInputItems.AllowUserToOrderColumns = true;
      this.grdInputItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdInputItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.grdInputItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdInputItems.Location = new System.Drawing.Point(12, 252);
      this.grdInputItems.Name = "grdInputItems";
      this.grdInputItems.Size = new System.Drawing.Size(635, 144);
      this.grdInputItems.TabIndex = 6;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnClose.Location = new System.Drawing.Point(12, 416);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(116, 23);
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "Save and close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblFromSize
      // 
      this.lblFromSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblFromSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFromSize.Location = new System.Drawing.Point(273, 228);
      this.lblFromSize.Name = "lblFromSize";
      this.lblFromSize.Size = new System.Drawing.Size(374, 20);
      this.lblFromSize.TabIndex = 8;
      this.lblFromSize.Text = "From Size: 38 cell std";
      this.lblFromSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // grdPottingDetail
      // 
      this.grdPottingDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      appearance1.BackColor = System.Drawing.SystemColors.Window;
      appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
      this.grdPottingDetail.DisplayLayout.Appearance = appearance1;
      this.grdPottingDetail.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
      this.grdPottingDetail.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      this.grdPottingDetail.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
      appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
      appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
      appearance2.BorderColor = System.Drawing.SystemColors.Window;
      this.grdPottingDetail.DisplayLayout.GroupByBox.Appearance = appearance2;
      appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdPottingDetail.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
      this.grdPottingDetail.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      this.grdPottingDetail.DisplayLayout.GroupByBox.Hidden = true;
      appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
      appearance4.BackColor2 = System.Drawing.SystemColors.Control;
      appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdPottingDetail.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
      this.grdPottingDetail.DisplayLayout.MaxColScrollRegions = 1;
      this.grdPottingDetail.DisplayLayout.MaxRowScrollRegions = 1;
      appearance5.BackColor = System.Drawing.SystemColors.Window;
      appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.grdPottingDetail.DisplayLayout.Override.ActiveCellAppearance = appearance5;
      appearance6.BackColor = System.Drawing.SystemColors.Highlight;
      appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.grdPottingDetail.DisplayLayout.Override.ActiveRowAppearance = appearance6;
      this.grdPottingDetail.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
      this.grdPottingDetail.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
      this.grdPottingDetail.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
      this.grdPottingDetail.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
      this.grdPottingDetail.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
      this.grdPottingDetail.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
      appearance7.BackColor = System.Drawing.SystemColors.Window;
      this.grdPottingDetail.DisplayLayout.Override.CardAreaAppearance = appearance7;
      appearance8.BorderColor = System.Drawing.Color.Silver;
      appearance8.ForeColorDisabled = System.Drawing.Color.Black;
      appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
      this.grdPottingDetail.DisplayLayout.Override.CellAppearance = appearance8;
      this.grdPottingDetail.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
      this.grdPottingDetail.DisplayLayout.Override.CellPadding = 0;
      this.grdPottingDetail.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Hidden;
      this.grdPottingDetail.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains;
      this.grdPottingDetail.DisplayLayout.Override.FilterOperatorLocation = Infragistics.Win.UltraWinGrid.FilterOperatorLocation.Hidden;
      appearance9.BackColor = System.Drawing.SystemColors.Control;
      appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
      appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance9.BorderColor = System.Drawing.SystemColors.Window;
      this.grdPottingDetail.DisplayLayout.Override.GroupByRowAppearance = appearance9;
      appearance10.TextHAlignAsString = "Left";
      this.grdPottingDetail.DisplayLayout.Override.HeaderAppearance = appearance10;
      this.grdPottingDetail.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
      this.grdPottingDetail.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
      appearance11.BackColor = System.Drawing.SystemColors.Window;
      appearance11.BorderColor = System.Drawing.Color.Silver;
      this.grdPottingDetail.DisplayLayout.Override.RowAppearance = appearance11;
      this.grdPottingDetail.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
      appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
      this.grdPottingDetail.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
      this.grdPottingDetail.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
      this.grdPottingDetail.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
      this.grdPottingDetail.Location = new System.Drawing.Point(12, 72);
      this.grdPottingDetail.Name = "grdPottingDetail";
      this.grdPottingDetail.Size = new System.Drawing.Size(635, 157);
      this.grdPottingDetail.TabIndex = 9;
      this.grdPottingDetail.Text = "ultraGrid1";
      // 
      // frmUpdatePotting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(659, 451);
      this.Controls.Add(this.grdPottingDetail);
      this.Controls.Add(this.lblFromSize);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.grdInputItems);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblItemName);
      this.Controls.Add(this.lblLotId);
      this.Name = "frmUpdatePotting";
      this.Text = "Update Potting Detail";
      this.Load += new System.EventHandler(this.frmUpdatePotting_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pIPottingLogBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdInputItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdPottingDetail)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblLotId;
    private System.Windows.Forms.Label lblItemName;
    private System.Windows.Forms.BindingSource pIPottingLogBindingSource;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView grdInputItems;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblFromSize;
    private Infragistics.Win.UltraWinGrid.UltraGrid grdPottingDetail;
  }
}