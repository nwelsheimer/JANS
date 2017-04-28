using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using MetroFramework.Controls;
using MetroFramework;
using MetroFramework.Forms;
using General;

namespace Nursery_Production_Software.Class
{
    public partial class plAuth : plSlider
    {
        public event EventHandler SettingClosed;
        public event EventHandler LogInSuccess;
        public int userId = 0;

        RegistryKey jans = Global.get_reg_key("JANS", true);

        public plAuth(Form owner)
                : base(owner)
        {
            InitializeComponent();
            
            for (int i = 3; i < 13; i++)
            {
                //create the color tiles in the theme selector
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flpSettings.Controls.Add(_tile);
            }
            dbSettings();
        }

        void _tile_Click(object sender, EventArgs e)
        {
            //if you click the tiles, change the selected color scheme then save to reg
            ((MetroForm)this.Parent).StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
            jans.SetValue("metroStyle", ((MetroTile)sender).Tag);
        }
        
        public void ShowSettings()
        {
            //display preferances, disable the login box
            plPrefs.Visible = true;
            plPrefs.BringToFront();
            plPrefs.Select();
            plBanner.Enabled = false;
        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            //hide settings, enable login, raise the settingsclosed event
            plPrefs.Visible = false;
            plBanner.Enabled = true;

            EventHandler handler = SettingClosed;
            if (handler != null) handler(this, e);
        }

        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Dark;
                jans.SetValue("metroTheme", 2);
            }
        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Light;
                jans.SetValue("metroTheme", 1);
            }
        }

        #region Default settings
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        private void txtHost_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        private void txtPort_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        private void txtDb_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        private void txtDBUser_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        private void txtDBPass_Leave(object sender, EventArgs e)
        {
            dbSettings(true);
        }
        public void dbSettings(bool isSave = false)
        {
            //Code to handle the loading and saving of the dbtab in preferances
            if (isSave)
            {
                //Save the settings to the registry
                Properties.Settings.Default.dbAddress = txtHost.Text;
                jans.SetValue("dbHost", txtHost.Text);
                Properties.Settings.Default.dbName = txtDb.Text;
                jans.SetValue("dbName", txtDb.Text);
                Properties.Settings.Default.dbPort = txtPort.Text;
                jans.SetValue("dbPort", txtPort.Text);
                Properties.Settings.Default.dbUser = txtDBUser.Text;
                jans.SetValue("dbUser", txtDBUser.Text);
                Properties.Settings.Default.dbPass = txtDBPass.Text;
                jans.SetValue("dbPass", txtDBPass.Text);
                Properties.Settings.Default.sysUser = txtUsername.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                //Fill in the text boxes
                txtHost.Text = Properties.Settings.Default.dbAddress;
                txtDb.Text = Properties.Settings.Default.dbName;
                txtPort.Text = Properties.Settings.Default.dbPort;
                txtDBUser.Text = Properties.Settings.Default.dbUser;
                txtDBPass.Text = Properties.Settings.Default.dbPass;
                txtUsername.Text = Properties.Settings.Default.sysUser;
            }
        }
        #endregion

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //do work to verify username and password
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int doLogin = 0;

            Global.SetConnectionString(txtHost.Text, txtDb.Text, txtPort.Text, txtDBUser.Text, txtDBPass.Text);

            try
            {
                doLogin = Convert.ToInt16(Global.GetData("usp_SYS_Login @username='" + username + "', @password='" + password + "'").Tables[0].Rows[0][0]);
            } catch
            {
                MetroMessageBox.Show(this, "There was an issue connecting to the server. Please check your connection settings.");
            }

            //raise loginsuccess if we won
            if (doLogin > 0)
            {
                userId = doLogin;
                EventHandler handler = LogInSuccess;
                if (handler != null) handler(this, e);
            } else
            {
                MetroMessageBox.Show(this,"Invalid username or password provided. Please try again.");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(sender,e);
            }
        }
    }
}
