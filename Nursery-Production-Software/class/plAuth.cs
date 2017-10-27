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
            
            dbSettings();
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

            if (Global.mySql)
            { Global.SetConnectionString(txtHost.Text, txtDb.Text, txtPort.Text, username, password); }
            else { Global.SetConnectionString(txtHost.Text, txtDb.Text, txtPort.Text, txtDBUser.Text, txtDBPass.Text); }

            try
            {
                //doLogin = Convert.ToInt16(Global.GetData("usp_SYS_Login @username='" + username + "', @password='" + password + "'").Tables[0].Rows[0][0]);
                doLogin = Convert.ToInt16(Global.GetData("call usp_SYS_Login('" + username + "','" + password + "')").Tables[0].Rows[0][0]);
            }
            catch { }

            //raise loginsuccess if we won
            if (doLogin > 0)
            {
                userId = doLogin;
                EventHandler handler = LogInSuccess;
                if (handler != null) handler(this, e);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn_Click(sender,e);
            }
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }
    }
}
