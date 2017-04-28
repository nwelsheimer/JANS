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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lnkSystem = new MetroFramework.Controls.MetroLink();
            this.lnkSettings = new MetroFramework.Controls.MetroLink();
            this.plSystem = new MetroFramework.Controls.MetroPanel();
            this.lnLogout = new MetroFramework.Controls.MetroLink();
            this.lnLock = new MetroFramework.Controls.MetroLink();
            this.lnExit = new MetroFramework.Controls.MetroLink();
            this.mtcMainMenu = new MetroFramework.Controls.MetroTabControl();
            this.stylMan = new MetroFramework.Components.MetroStyleManager(this.components);
            this.plSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stylMan)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkSystem
            // 
            this.lnkSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSystem.Image = ((System.Drawing.Image)(resources.GetObject("lnkSystem.Image")));
            this.lnkSystem.ImageSize = 32;
            this.lnkSystem.Location = new System.Drawing.Point(1186, 8);
            this.lnkSystem.Name = "lnkSystem";
            this.lnkSystem.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkSystem.NoFocusImage")));
            this.lnkSystem.Size = new System.Drawing.Size(42, 39);
            this.lnkSystem.TabIndex = 13;
            this.lnkSystem.UseSelectable = true;
            this.lnkSystem.Click += new System.EventHandler(this.lnkSystem_Click);
            // 
            // lnkSettings
            // 
            this.lnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSettings.Image = ((System.Drawing.Image)(resources.GetObject("lnkSettings.Image")));
            this.lnkSettings.ImageSize = 32;
            this.lnkSettings.Location = new System.Drawing.Point(1138, 8);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkSettings.NoFocusImage")));
            this.lnkSettings.Size = new System.Drawing.Size(42, 39);
            this.lnkSettings.TabIndex = 14;
            this.lnkSettings.UseSelectable = true;
            this.lnkSettings.Click += new System.EventHandler(this.lnkSettings_Click);
            // 
            // plSystem
            // 
            this.plSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSystem.Controls.Add(this.lnLogout);
            this.plSystem.Controls.Add(this.lnLock);
            this.plSystem.Controls.Add(this.lnExit);
            this.plSystem.HorizontalScrollbarBarColor = true;
            this.plSystem.HorizontalScrollbarHighlightOnWheel = false;
            this.plSystem.HorizontalScrollbarSize = 10;
            this.plSystem.Location = new System.Drawing.Point(1105, 53);
            this.plSystem.Name = "plSystem";
            this.plSystem.Size = new System.Drawing.Size(123, 92);
            this.plSystem.TabIndex = 15;
            this.plSystem.VerticalScrollbarBarColor = true;
            this.plSystem.VerticalScrollbarHighlightOnWheel = false;
            this.plSystem.VerticalScrollbarSize = 10;
            this.plSystem.Visible = false;
            this.plSystem.Leave += new System.EventHandler(this.plSystem_Leave);
            // 
            // lnLogout
            // 
            this.lnLogout.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnLogout.Image = ((System.Drawing.Image)(resources.GetObject("lnLogout.Image")));
            this.lnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnLogout.ImageSize = 24;
            this.lnLogout.Location = new System.Drawing.Point(10, 32);
            this.lnLogout.Name = "lnLogout";
            this.lnLogout.Size = new System.Drawing.Size(110, 23);
            this.lnLogout.TabIndex = 4;
            this.lnLogout.Text = "LOGOUT";
            this.lnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnLogout.UseSelectable = true;
            this.lnLogout.Click += new System.EventHandler(this.lnLogout_Click);
            // 
            // lnLock
            // 
            this.lnLock.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnLock.Image = ((System.Drawing.Image)(resources.GetObject("lnLock.Image")));
            this.lnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnLock.ImageSize = 24;
            this.lnLock.Location = new System.Drawing.Point(4, 3);
            this.lnLock.Name = "lnLock";
            this.lnLock.Size = new System.Drawing.Size(112, 23);
            this.lnLock.TabIndex = 3;
            this.lnLock.Text = "LOCK";
            this.lnLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnLock.UseSelectable = true;
            this.lnLock.Click += new System.EventHandler(this.lnLock_Click);
            // 
            // lnExit
            // 
            this.lnExit.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnExit.Image = ((System.Drawing.Image)(resources.GetObject("lnExit.Image")));
            this.lnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnExit.ImageSize = 24;
            this.lnExit.Location = new System.Drawing.Point(6, 60);
            this.lnExit.Name = "lnExit";
            this.lnExit.Size = new System.Drawing.Size(112, 26);
            this.lnExit.TabIndex = 2;
            this.lnExit.Text = "EXIT";
            this.lnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnExit.UseSelectable = true;
            this.lnExit.Click += new System.EventHandler(this.lnExit_Click);
            // 
            // mtcMainMenu
            // 
            this.mtcMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcMainMenu.Location = new System.Drawing.Point(13, 57);
            this.mtcMainMenu.Name = "mtcMainMenu";
            this.mtcMainMenu.Size = new System.Drawing.Size(1195, 674);
            this.mtcMainMenu.TabIndex = 16;
            this.mtcMainMenu.UseSelectable = true;
            // 
            // stylMan
            // 
            this.stylMan.Owner = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 742);
            this.ControlBox = false;
            this.Controls.Add(this.mtcMainMenu);
            this.Controls.Add(this.plSystem);
            this.Controls.Add(this.lnkSettings);
            this.Controls.Add(this.lnkSystem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "JANS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            this.plSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stylMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLink lnkSettings;
        private MetroFramework.Controls.MetroLink lnkSystem;
        private MetroFramework.Controls.MetroPanel plSystem;
        private MetroFramework.Controls.MetroLink lnExit;
        private MetroFramework.Controls.MetroLink lnLogout;
        private MetroFramework.Controls.MetroLink lnLock;
        private MetroFramework.Controls.MetroTabControl mtcMainMenu;
        private MetroFramework.Components.MetroStyleManager stylMan;
    }
}