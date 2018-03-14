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
      ((System.ComponentModel.ISupportInitialize)(this.pIPottingLogBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdDriverLog)).BeginInit();
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
      this.grdDriverLog.Location = new System.Drawing.Point(12, 52);
      this.grdDriverLog.Name = "grdDriverLog";
      this.grdDriverLog.Size = new System.Drawing.Size(551, 389);
      this.grdDriverLog.TabIndex = 3;
      this.grdDriverLog.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDriverLog_RowLeave);
      this.grdDriverLog.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdDriverLog_RowsAdded);
      // 
      // frmUpdatePotting
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(575, 453);
      this.Controls.Add(this.grdDriverLog);
      this.Controls.Add(this.lblItemName);
      this.Controls.Add(this.lblLotId);
      this.Name = "frmUpdatePotting";
      this.Text = "Update Potting Detail";
      this.Load += new System.EventHandler(this.frmUpdatePotting_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pIPottingLogBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grdDriverLog)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblLotId;
    private System.Windows.Forms.Label lblItemName;
    private System.Windows.Forms.BindingSource pIPottingLogBindingSource;
    private System.Windows.Forms.DataGridView grdDriverLog;
  }
}