namespace Nursery_Production_Software.sysForms
{
  partial class frmRFIDRead
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
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.txtTimerInt = new DevExpress.XtraEditors.TextEdit();
      this.btnStart = new DevExpress.XtraEditors.SimpleButton();
      this.lblOutput = new DevExpress.XtraEditors.LabelControl();
      this.lbxOutput = new DevExpress.XtraEditors.ListBoxControl();
      this.txtURL = new DevExpress.XtraEditors.MemoEdit();
      this.txtURL2 = new DevExpress.XtraEditors.TextEdit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTimerInt.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lbxOutput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtURL2.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // labelControl1
      // 
      this.labelControl1.Location = new System.Drawing.Point(14, 17);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(74, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Update interval";
      // 
      // txtTimerInt
      // 
      this.txtTimerInt.EditValue = "10";
      this.txtTimerInt.Location = new System.Drawing.Point(100, 14);
      this.txtTimerInt.Name = "txtTimerInt";
      this.txtTimerInt.Size = new System.Drawing.Size(100, 20);
      this.txtTimerInt.TabIndex = 1;
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(227, 12);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 2;
      this.btnStart.Text = "Start Timer";
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lblOutput
      // 
      this.lblOutput.Location = new System.Drawing.Point(319, 17);
      this.lblOutput.Name = "lblOutput";
      this.lblOutput.Size = new System.Drawing.Size(68, 13);
      this.lblOutput.TabIndex = 3;
      this.lblOutput.Text = "Not running...";
      // 
      // lbxOutput
      // 
      this.lbxOutput.Location = new System.Drawing.Point(12, 117);
      this.lbxOutput.MultiColumn = true;
      this.lbxOutput.Name = "lbxOutput";
      this.lbxOutput.Size = new System.Drawing.Size(789, 485);
      this.lbxOutput.TabIndex = 4;
      // 
      // txtURL
      // 
      this.txtURL.EditValue = "http://10.10.2.7/rfcode_reader/tagevents?_sid=1&_init=true&_group=CCUSAA&_group=C" +
    "CUSAB&_group=CCUSAC&_group=CCUSAD&_group=CCUSAE&_group=CCUSAF&_group=CCUSAG&_gro" +
    "up=CCUSAH&_group=CCUSAI&_group=CCUSAJ";
      this.txtURL.Location = new System.Drawing.Point(12, 41);
      this.txtURL.Name = "txtURL";
      this.txtURL.Size = new System.Drawing.Size(789, 70);
      this.txtURL.TabIndex = 5;
      // 
      // txtURL2
      // 
      this.txtURL2.EditValue = "http://10.10.2.7/rfcode_reader/tagevents?_sid=1";
      this.txtURL2.Location = new System.Drawing.Point(442, 15);
      this.txtURL2.Name = "txtURL2";
      this.txtURL2.Size = new System.Drawing.Size(359, 20);
      this.txtURL2.TabIndex = 6;
      // 
      // frmRFIDRead
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(980, 614);
      this.Controls.Add(this.txtURL2);
      this.Controls.Add(this.txtURL);
      this.Controls.Add(this.lbxOutput);
      this.Controls.Add(this.lblOutput);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.txtTimerInt);
      this.Controls.Add(this.labelControl1);
      this.Name = "frmRFIDRead";
      this.Text = "frmRFIDRead";
      ((System.ComponentModel.ISupportInitialize)(this.txtTimerInt.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lbxOutput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtURL2.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.TextEdit txtTimerInt;
    private DevExpress.XtraEditors.SimpleButton btnStart;
    private DevExpress.XtraEditors.LabelControl lblOutput;
    private DevExpress.XtraEditors.ListBoxControl lbxOutput;
    private DevExpress.XtraEditors.MemoEdit txtURL;
    private DevExpress.XtraEditors.TextEdit txtURL2;
  }
}