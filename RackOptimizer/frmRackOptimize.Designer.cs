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
      this.cmbSession = new System.Windows.Forms.ComboBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.lblTotalStores = new System.Windows.Forms.Label();
      this.lblPartialShelves = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
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
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.lblPartialShelves);
      this.panel1.Controls.Add(this.lblTotalStores);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(393, 28);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(370, 135);
      this.panel1.TabIndex = 1;
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
      // lblTotalStores
      // 
      this.lblTotalStores.AutoSize = true;
      this.lblTotalStores.Location = new System.Drawing.Point(25, 32);
      this.lblTotalStores.Name = "lblTotalStores";
      this.lblTotalStores.Size = new System.Drawing.Size(13, 13);
      this.lblTotalStores.TabIndex = 1;
      this.lblTotalStores.Text = "0";
      // 
      // lblPartialShelves
      // 
      this.lblPartialShelves.AutoSize = true;
      this.lblPartialShelves.Location = new System.Drawing.Point(25, 45);
      this.lblPartialShelves.Name = "lblPartialShelves";
      this.lblPartialShelves.Size = new System.Drawing.Size(13, 13);
      this.lblPartialShelves.TabIndex = 2;
      this.lblPartialShelves.Text = "0";
      // 
      // frmRackOptimize
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(850, 549);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.cmbSession);
      this.Name = "frmRackOptimize";
      this.Text = "Rack Optimization";
      this.Load += new System.EventHandler(this.frmRackOptimize_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbSession;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblPartialShelves;
    private System.Windows.Forms.Label lblTotalStores;
  }
}

