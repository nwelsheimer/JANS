namespace Nursery_Production_Software
{
    partial class frmMain
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
      Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.mnuMain = new System.Windows.Forms.MenuStrip();
      this.pnlHeader = new Infragistics.Win.Misc.UltraPanel();
      this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
      this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
      this.ultraPanel2 = new Infragistics.Win.Misc.UltraPanel();
      this.ultraSplitter1 = new Infragistics.Win.Misc.UltraSplitter();
      this.ultraTilePanel1 = new Infragistics.Win.Misc.UltraTilePanel();
      this.tilePatchNotes = new Infragistics.Win.Misc.UltraTile();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.ultraPanel1.ClientArea.SuspendLayout();
      this.pnlHeader.SuspendLayout();
      this.ultraPanel1.ClientArea.SuspendLayout();
      this.ultraPanel1.SuspendLayout();
      this.ultraPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).BeginInit();
      this.ultraTilePanel1.SuspendLayout();
      this.tilePatchNotes.SuspendLayout();
      this.SuspendLayout();
      // 
      // mnuMain
      // 
      this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.mnuMain.Location = new System.Drawing.Point(0, 0);
      this.mnuMain.Name = "mnuMain";
      this.mnuMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.mnuMain.Size = new System.Drawing.Size(1846, 24);
      this.mnuMain.TabIndex = 18;
      this.mnuMain.Text = "menuStrip1";
      // 
      // pnlHeader
      // 
      // 
      // pnlHeader.ClientArea
      // 
      this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel1);
      this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlHeader.Location = new System.Drawing.Point(0, 24);
      this.pnlHeader.Name = "pnlHeader";
      this.pnlHeader.Size = new System.Drawing.Size(1846, 62);
      this.pnlHeader.TabIndex = 19;
      // 
      // ultraLabel1
      // 
      appearance2.ForeColor = System.Drawing.Color.White;
      this.ultraLabel1.Appearance = appearance2;
      this.ultraLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ultraLabel1.Location = new System.Drawing.Point(3, 3);
      this.ultraLabel1.Name = "ultraLabel1";
      this.ultraLabel1.Size = new System.Drawing.Size(426, 42);
      this.ultraLabel1.TabIndex = 0;
      this.ultraLabel1.Text = "Just Another Nursery System";
      // 
      // ultraPanel1
      // 
      // 
      // ultraPanel1.ClientArea
      // 
      this.ultraPanel1.ClientArea.Controls.Add(this.ultraTilePanel1);
      this.ultraPanel1.ClientArea.Controls.Add(this.ultraSplitter1);
      this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.ultraPanel1.Location = new System.Drawing.Point(425, 86);
      this.ultraPanel1.Name = "ultraPanel1";
      this.ultraPanel1.Size = new System.Drawing.Size(1421, 1056);
      this.ultraPanel1.TabIndex = 20;
      // 
      // ultraPanel2
      // 
      this.ultraPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ultraPanel2.Location = new System.Drawing.Point(0, 86);
      this.ultraPanel2.Name = "ultraPanel2";
      this.ultraPanel2.Size = new System.Drawing.Size(425, 1056);
      this.ultraPanel2.TabIndex = 21;
      // 
      // ultraSplitter1
      // 
      this.ultraSplitter1.Location = new System.Drawing.Point(0, 0);
      this.ultraSplitter1.Name = "ultraSplitter1";
      this.ultraSplitter1.RestoreExtent = 0;
      this.ultraSplitter1.Size = new System.Drawing.Size(6, 1056);
      this.ultraSplitter1.TabIndex = 0;
      // 
      // ultraTilePanel1
      // 
      this.ultraTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ultraTilePanel1.Location = new System.Drawing.Point(6, 0);
      this.ultraTilePanel1.Name = "ultraTilePanel1";
      this.ultraTilePanel1.NormalModeDimensions = new System.Drawing.Size(1, 1);
      this.ultraTilePanel1.Size = new System.Drawing.Size(1415, 1056);
      this.ultraTilePanel1.TabIndex = 1;
      this.ultraTilePanel1.Tiles.Add(this.tilePatchNotes);
      // 
      // tilePatchNotes
      // 
      this.tilePatchNotes.Caption = "Patch Notes";
      this.tilePatchNotes.Control = this.textBox1;
      this.tilePatchNotes.Controls.Add(this.textBox1);
      this.tilePatchNotes.Name = "tilePatchNotes";
      this.tilePatchNotes.PositionInNormalMode = new System.Drawing.Point(0, 0);
      appearance1.AlphaLevel = ((short)(100));
      this.tilePatchNotes.Settings.Appearance = appearance1;
      this.tilePatchNotes.TabIndex = 0;
      // 
      // textBox1
      // 
      this.textBox1.Enabled = false;
      this.textBox1.Location = new System.Drawing.Point(0, 19);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(1395, 1017);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = "Patch Notes ";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ClientSize = new System.Drawing.Size(1846, 1142);
      this.Controls.Add(this.ultraPanel2);
      this.Controls.Add(this.ultraPanel1);
      this.Controls.Add(this.pnlHeader);
      this.Controls.Add(this.mnuMain);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MainMenuStrip = this.mnuMain;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "frmMain";
      this.Text = "JANS";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Shown += new System.EventHandler(this.frmMain_Shown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
      this.ultraPanel1.ClientArea.ResumeLayout(false);
      this.pnlHeader.ResumeLayout(false);
      this.ultraPanel1.ClientArea.ResumeLayout(false);
      this.ultraPanel1.ResumeLayout(false);
      this.ultraPanel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ultraTilePanel1)).EndInit();
      this.ultraTilePanel1.ResumeLayout(false);
      this.tilePatchNotes.ResumeLayout(false);
      this.tilePatchNotes.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
    private Infragistics.Win.Misc.UltraPanel pnlHeader;
    private Infragistics.Win.Misc.UltraLabel ultraLabel1;
    private Infragistics.Win.Misc.UltraPanel ultraPanel1;
    private Infragistics.Win.Misc.UltraTilePanel ultraTilePanel1;
    private Infragistics.Win.Misc.UltraTile tilePatchNotes;
    private System.Windows.Forms.TextBox textBox1;
    private Infragistics.Win.Misc.UltraSplitter ultraSplitter1;
    private Infragistics.Win.Misc.UltraPanel ultraPanel2;
  }
}