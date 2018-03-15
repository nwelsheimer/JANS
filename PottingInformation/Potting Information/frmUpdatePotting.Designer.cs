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
      this.lblLotId = new System.Windows.Forms.Label();
      this.lblItemName = new System.Windows.Forms.Label();
      this.pIPottingLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.grdDriverLog = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.grdInputItems = new System.Windows.Forms.DataGridView();
      this.btnClose = new System.Windows.Forms.Button();
      this.lblFromSize = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pIPottingLogBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdDriverLog)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdInputItems)).BeginInit();
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
      // grdDriverLog
      // 
      this.grdDriverLog.AllowUserToOrderColumns = true;
      this.grdDriverLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdDriverLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.grdDriverLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdDriverLog.Location = new System.Drawing.Point(12, 72);
      this.grdDriverLog.Name = "grdDriverLog";
      this.grdDriverLog.Size = new System.Drawing.Size(641, 252);
      this.grdDriverLog.TabIndex = 3;
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
      this.label2.Location = new System.Drawing.Point(13, 339);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(153, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Select locations for input items:";
      // 
      // grdInputItems
      // 
      this.grdInputItems.AllowUserToOrderColumns = true;
      this.grdInputItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdInputItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.grdInputItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdInputItems.Location = new System.Drawing.Point(12, 359);
      this.grdInputItems.Name = "grdInputItems";
      this.grdInputItems.Size = new System.Drawing.Size(641, 144);
      this.grdInputItems.TabIndex = 6;
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(12, 523);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(116, 23);
      this.btnClose.TabIndex = 7;
      this.btnClose.Text = "Save and close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // lblFromSize
      // 
      this.lblFromSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblFromSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFromSize.Location = new System.Drawing.Point(279, 9);
      this.lblFromSize.Name = "lblFromSize";
      this.lblFromSize.Size = new System.Drawing.Size(374, 20);
      this.lblFromSize.TabIndex = 8;
      this.lblFromSize.Text = "From Size: 38 cell std";
      this.lblFromSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // frmUpdatePotting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(665, 558);
      this.Controls.Add(this.lblFromSize);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.grdInputItems);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.grdDriverLog);
      this.Controls.Add(this.lblItemName);
      this.Controls.Add(this.lblLotId);
      this.Name = "frmUpdatePotting";
      this.Text = "Update Potting Detail";
      this.Load += new System.EventHandler(this.frmUpdatePotting_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pIPottingLogBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdDriverLog)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdInputItems)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblLotId;
    private System.Windows.Forms.Label lblItemName;
    private System.Windows.Forms.BindingSource pIPottingLogBindingSource;
    private System.Windows.Forms.DataGridView grdDriverLog;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView grdInputItems;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblFromSize;
  }
}