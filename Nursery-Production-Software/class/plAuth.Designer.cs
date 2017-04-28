namespace Nursery_Production_Software.Class
{
    partial class plAuth
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plAuth));
            this.plBanner = new MetroFramework.Controls.MetroPanel();
            this.btnLogIn = new MetroFramework.Controls.MetroButton();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plPrefs = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpConnection = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDBPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDBUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblPort = new MetroFramework.Controls.MetroLabel();
            this.lblHost = new MetroFramework.Controls.MetroLabel();
            this.lblDb = new MetroFramework.Controls.MetroLabel();
            this.txtDb = new MetroFramework.Controls.MetroTextBox();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.txtHost = new MetroFramework.Controls.MetroTextBox();
            this.mtpTheme = new MetroFramework.Controls.MetroTabPage();
            this.mrbLight = new MetroFramework.Controls.MetroRadioButton();
            this.mrbDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.flpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.plBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plPrefs.SuspendLayout();
            this.mtcSettings.SuspendLayout();
            this.mtpConnection.SuspendLayout();
            this.mtpTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBanner
            // 
            this.plBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plBanner.Controls.Add(this.btnLogIn);
            this.plBanner.Controls.Add(this.txtPassword);
            this.plBanner.Controls.Add(this.txtUsername);
            this.plBanner.Controls.Add(this.pictureBox1);
            this.plBanner.HorizontalScrollbarBarColor = true;
            this.plBanner.HorizontalScrollbarHighlightOnWheel = false;
            this.plBanner.HorizontalScrollbarSize = 10;
            this.plBanner.Location = new System.Drawing.Point(0, 115);
            this.plBanner.Name = "plBanner";
            this.plBanner.Size = new System.Drawing.Size(812, 247);
            this.plBanner.TabIndex = 1;
            this.plBanner.VerticalScrollbarBarColor = true;
            this.plBanner.VerticalScrollbarHighlightOnWheel = false;
            this.plBanner.VerticalScrollbarSize = 10;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.Location = new System.Drawing.Point(449, 164);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(97, 33);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "&Login";
            this.btnLogIn.UseSelectable = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(267, 130);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(279, 28);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtUsername.Icon")));
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(267, 96);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(279, 28);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // plPrefs
            // 
            this.plPrefs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plPrefs.Controls.Add(this.panel1);
            this.plPrefs.Controls.Add(this.mtcSettings);
            this.plPrefs.Controls.Add(this.lnkBack);
            this.plPrefs.HorizontalScrollbarBarColor = true;
            this.plPrefs.HorizontalScrollbarHighlightOnWheel = false;
            this.plPrefs.HorizontalScrollbarSize = 10;
            this.plPrefs.Location = new System.Drawing.Point(559, 0);
            this.plPrefs.Name = "plPrefs";
            this.plPrefs.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.plPrefs.Size = new System.Drawing.Size(253, 444);
            this.plPrefs.TabIndex = 2;
            this.plPrefs.VerticalScrollbarBarColor = true;
            this.plPrefs.VerticalScrollbarHighlightOnWheel = false;
            this.plPrefs.VerticalScrollbarSize = 10;
            this.plPrefs.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 444);
            this.panel1.TabIndex = 4;
            // 
            // mtcSettings
            // 
            this.mtcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtcSettings.Controls.Add(this.mtpConnection);
            this.mtcSettings.Controls.Add(this.mtpTheme);
            this.mtcSettings.Location = new System.Drawing.Point(13, 45);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 0;
            this.mtcSettings.Size = new System.Drawing.Size(237, 402);
            this.mtcSettings.TabIndex = 3;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpConnection
            // 
            this.mtpConnection.Controls.Add(this.metroLabel5);
            this.mtpConnection.Controls.Add(this.txtDBPass);
            this.mtpConnection.Controls.Add(this.metroLabel4);
            this.mtpConnection.Controls.Add(this.txtDBUser);
            this.mtpConnection.Controls.Add(this.metroLabel3);
            this.mtpConnection.Controls.Add(this.lblPort);
            this.mtpConnection.Controls.Add(this.lblHost);
            this.mtpConnection.Controls.Add(this.lblDb);
            this.mtpConnection.Controls.Add(this.txtDb);
            this.mtpConnection.Controls.Add(this.txtPort);
            this.mtpConnection.Controls.Add(this.txtHost);
            this.mtpConnection.HorizontalScrollbarBarColor = true;
            this.mtpConnection.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpConnection.HorizontalScrollbarSize = 10;
            this.mtpConnection.Location = new System.Drawing.Point(4, 38);
            this.mtpConnection.Name = "mtpConnection";
            this.mtpConnection.Size = new System.Drawing.Size(229, 360);
            this.mtpConnection.TabIndex = 0;
            this.mtpConnection.Text = "&connection";
            this.mtpConnection.VerticalScrollbarBarColor = true;
            this.mtpConnection.VerticalScrollbarHighlightOnWheel = false;
            this.mtpConnection.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(3, 293);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 25);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Password:";
            // 
            // txtDBPass
            // 
            this.txtDBPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDBPass.CustomButton.Image = null;
            this.txtDBPass.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.txtDBPass.CustomButton.Name = "";
            this.txtDBPass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDBPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBPass.CustomButton.TabIndex = 1;
            this.txtDBPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBPass.CustomButton.UseSelectable = true;
            this.txtDBPass.CustomButton.Visible = false;
            this.txtDBPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDBPass.Lines = new string[0];
            this.txtDBPass.Location = new System.Drawing.Point(3, 321);
            this.txtDBPass.MaxLength = 32767;
            this.txtDBPass.Name = "txtDBPass";
            this.txtDBPass.PasswordChar = '*';
            this.txtDBPass.PromptText = "Optional";
            this.txtDBPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBPass.SelectedText = "";
            this.txtDBPass.SelectionLength = 0;
            this.txtDBPass.SelectionStart = 0;
            this.txtDBPass.ShortcutsEnabled = true;
            this.txtDBPass.Size = new System.Drawing.Size(209, 30);
            this.txtDBPass.TabIndex = 21;
            this.txtDBPass.UseSelectable = true;
            this.txtDBPass.WaterMark = "Optional";
            this.txtDBPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDBPass.Leave += new System.EventHandler(this.txtDBPass_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(3, 232);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Username:";
            // 
            // txtDBUser
            // 
            this.txtDBUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDBUser.CustomButton.Image = null;
            this.txtDBUser.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.txtDBUser.CustomButton.Name = "";
            this.txtDBUser.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDBUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBUser.CustomButton.TabIndex = 1;
            this.txtDBUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBUser.CustomButton.UseSelectable = true;
            this.txtDBUser.CustomButton.Visible = false;
            this.txtDBUser.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDBUser.Lines = new string[0];
            this.txtDBUser.Location = new System.Drawing.Point(3, 260);
            this.txtDBUser.MaxLength = 32767;
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.PasswordChar = '\0';
            this.txtDBUser.PromptText = "Optional";
            this.txtDBUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBUser.SelectedText = "";
            this.txtDBUser.SelectionLength = 0;
            this.txtDBUser.SelectionStart = 0;
            this.txtDBUser.ShortcutsEnabled = true;
            this.txtDBUser.Size = new System.Drawing.Size(209, 30);
            this.txtDBUser.TabIndex = 19;
            this.txtDBUser.UseSelectable = true;
            this.txtDBUser.WaterMark = "Optional";
            this.txtDBUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDBUser.Leave += new System.EventHandler(this.txtDBUser_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(0, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(226, 39);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "System Database Setup";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPort
            // 
            this.lblPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPort.AutoSize = true;
            this.lblPort.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPort.Location = new System.Drawing.Point(3, 110);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 25);
            this.lblPort.TabIndex = 17;
            this.lblPort.Text = "Port:";
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHost.AutoSize = true;
            this.lblHost.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHost.Location = new System.Drawing.Point(3, 49);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(65, 25);
            this.lblHost.TabIndex = 16;
            this.lblHost.Text = "Server:";
            // 
            // lblDb
            // 
            this.lblDb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDb.AutoSize = true;
            this.lblDb.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDb.Location = new System.Drawing.Point(3, 171);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(86, 25);
            this.lblDb.TabIndex = 15;
            this.lblDb.Text = "Database:";
            // 
            // txtDb
            // 
            this.txtDb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtDb.CustomButton.Image = null;
            this.txtDb.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.txtDb.CustomButton.Name = "";
            this.txtDb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDb.CustomButton.TabIndex = 1;
            this.txtDb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDb.CustomButton.UseSelectable = true;
            this.txtDb.CustomButton.Visible = false;
            this.txtDb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDb.Lines = new string[0];
            this.txtDb.Location = new System.Drawing.Point(3, 199);
            this.txtDb.MaxLength = 32767;
            this.txtDb.Name = "txtDb";
            this.txtDb.PasswordChar = '\0';
            this.txtDb.PromptText = "JANS";
            this.txtDb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDb.SelectedText = "";
            this.txtDb.SelectionLength = 0;
            this.txtDb.SelectionStart = 0;
            this.txtDb.ShortcutsEnabled = true;
            this.txtDb.Size = new System.Drawing.Size(209, 30);
            this.txtDb.TabIndex = 14;
            this.txtDb.UseSelectable = true;
            this.txtDb.WaterMark = "JANS";
            this.txtDb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDb.Leave += new System.EventHandler(this.txtDb_Leave);
            // 
            // txtPort
            // 
            this.txtPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(66, 2);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(3, 138);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PromptText = "1433";
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(94, 30);
            this.txtPort.TabIndex = 13;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMark = "1433";
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPort.Leave += new System.EventHandler(this.txtPort_Leave);
            // 
            // txtHost
            // 
            this.txtHost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtHost.CustomButton.Image = null;
            this.txtHost.CustomButton.Location = new System.Drawing.Point(181, 2);
            this.txtHost.CustomButton.Name = "";
            this.txtHost.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHost.CustomButton.TabIndex = 1;
            this.txtHost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHost.CustomButton.UseSelectable = true;
            this.txtHost.CustomButton.Visible = false;
            this.txtHost.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHost.Lines = new string[0];
            this.txtHost.Location = new System.Drawing.Point(3, 77);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.PromptText = "sql.domain.com";
            this.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHost.SelectedText = "";
            this.txtHost.SelectionLength = 0;
            this.txtHost.SelectionStart = 0;
            this.txtHost.ShortcutsEnabled = true;
            this.txtHost.Size = new System.Drawing.Size(209, 30);
            this.txtHost.TabIndex = 12;
            this.txtHost.UseSelectable = true;
            this.txtHost.WaterMark = "sql.domain.com";
            this.txtHost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHost.Leave += new System.EventHandler(this.txtHost_Leave);
            // 
            // mtpTheme
            // 
            this.mtpTheme.Controls.Add(this.mrbLight);
            this.mtpTheme.Controls.Add(this.mrbDark);
            this.mtpTheme.Controls.Add(this.metroLabel2);
            this.mtpTheme.Controls.Add(this.metroLabel1);
            this.mtpTheme.Controls.Add(this.flpSettings);
            this.mtpTheme.HorizontalScrollbarBarColor = true;
            this.mtpTheme.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpTheme.HorizontalScrollbarSize = 10;
            this.mtpTheme.Location = new System.Drawing.Point(4, 38);
            this.mtpTheme.Name = "mtpTheme";
            this.mtpTheme.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.mtpTheme.Size = new System.Drawing.Size(229, 360);
            this.mtpTheme.TabIndex = 1;
            this.mtpTheme.Text = "&theme";
            this.mtpTheme.VerticalScrollbarBarColor = true;
            this.mtpTheme.VerticalScrollbarHighlightOnWheel = false;
            this.mtpTheme.VerticalScrollbarSize = 10;
            // 
            // mrbLight
            // 
            this.mrbLight.AutoSize = true;
            this.mrbLight.Checked = true;
            this.mrbLight.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbLight.Location = new System.Drawing.Point(72, 33);
            this.mrbLight.Name = "mrbLight";
            this.mrbLight.Size = new System.Drawing.Size(56, 19);
            this.mrbLight.TabIndex = 6;
            this.mrbLight.TabStop = true;
            this.mrbLight.Text = "&Light";
            this.mrbLight.UseSelectable = true;
            this.mrbLight.CheckedChanged += new System.EventHandler(this.mrbLight_CheckedChanged);
            // 
            // mrbDark
            // 
            this.mrbDark.AutoSize = true;
            this.mrbDark.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbDark.Location = new System.Drawing.Point(3, 33);
            this.mrbDark.Name = "mrbDark";
            this.mrbDark.Size = new System.Drawing.Size(54, 19);
            this.mrbDark.TabIndex = 5;
            this.mrbDark.Text = "&Dark";
            this.mrbDark.UseSelectable = true;
            this.mrbDark.CheckedChanged += new System.EventHandler(this.mrbDark_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Style";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Theme";
            // 
            // flpSettings
            // 
            this.flpSettings.BackColor = System.Drawing.Color.Transparent;
            this.flpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSettings.Location = new System.Drawing.Point(0, 80);
            this.flpSettings.Name = "flpSettings";
            this.flpSettings.Size = new System.Drawing.Size(229, 280);
            this.flpSettings.TabIndex = 2;
            // 
            // lnkBack
            // 
            this.lnkBack.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkBack.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.lnkBack.Image = ((System.Drawing.Image)(resources.GetObject("lnkBack.Image")));
            this.lnkBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkBack.ImageSize = 32;
            this.lnkBack.Location = new System.Drawing.Point(5, 3);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.NoFocusImage = ((System.Drawing.Image)(resources.GetObject("lnkBack.NoFocusImage")));
            this.lnkBack.Size = new System.Drawing.Size(138, 36);
            this.lnkBack.TabIndex = 2;
            this.lnkBack.Text = "&Settings";
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // plAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plPrefs);
            this.Controls.Add(this.plBanner);
            this.Name = "plAuth";
            this.Size = new System.Drawing.Size(812, 444);
            this.plBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plPrefs.ResumeLayout(false);
            this.mtcSettings.ResumeLayout(false);
            this.mtpConnection.ResumeLayout(false);
            this.mtpConnection.PerformLayout();
            this.mtpTheme.ResumeLayout(false);
            this.mtpTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel plBanner;
        private MetroFramework.Controls.MetroButton btnLogIn;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel plPrefs;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroTabPage mtpConnection;
        private MetroFramework.Controls.MetroTabPage mtpTheme;
        private MetroFramework.Controls.MetroRadioButton mrbLight;
        private MetroFramework.Controls.MetroRadioButton mrbDark;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel flpSettings;
        private MetroFramework.Controls.MetroLink lnkBack;
        private MetroFramework.Controls.MetroLabel lblPort;
        private MetroFramework.Controls.MetroLabel lblHost;
        private MetroFramework.Controls.MetroLabel lblDb;
        private MetroFramework.Controls.MetroTextBox txtDb;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroTextBox txtHost;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDBPass;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDBUser;
    }
}
