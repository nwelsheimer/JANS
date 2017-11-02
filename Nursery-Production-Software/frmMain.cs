using System;
using System.Data;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Reflection;
using Microsoft.Win32;
using Nursery_Production_Software.Class;
using General;
using System.Drawing;
using System.IO;


namespace Nursery_Production_Software
{
    public partial class frmMain : Form
    {
        plAuth _Auth = null;
        int userId = 0;
        ConsoleCtl.frmConsole console = new ConsoleCtl.frmConsole();

        RegistryKey jans = Global.get_reg_key("JANS", true); //Getting settings from registry now.

        public frmMain()
        {
            InitializeComponent();
            string version = System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed ?
                ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() : Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "JANS Login - " + version;
            this.Shown += frmMain_Shown;

            showLogin();
        }

        private void setStyles(MetroFramework.Components.MetroStyleManager sm)
        {
            int style = 0;
            int theme = 0;

            style = jans.GetValue("metroStyle") == null ? 0 : Convert.ToInt16(jans.GetValue("metroStyle"));
            theme = jans.GetValue("metroTheme") == null ? 0 : Convert.ToInt16(jans.GetValue("metroTheme"));

            sm.Style = (MetroFramework.MetroColorStyle)style;
            sm.Theme = (MetroFramework.MetroThemeStyle)theme;
        }

        private void showLogin()
        {
            _Auth = new plAuth(this);
            _Auth.LogInSuccess += _AuthLoginSuccess;
            _Auth.swipe();
        }

        void _AuthLoginSuccess(object sender, EventArgs e)
        {
            //Whole mess of things to build the menu system when you log in.
            userId = _Auth.userId;
            fileMnu();

            //This table contains the complete menu system for this user
            DataTable menuSystem = Global.GetData("usp_SYS_MenuBuilder @userId=" + userId).Tables[0];
            //DataTable menuSystem = Global.GetData("call usp_SYS_MenuBuilder(" + userId + ")").Tables[0];

            //filter a distinct list of parent menus
            DataView temp = menuSystem.DefaultView;
            DataTable parents = temp.ToTable(true, "MenuName", "MenuTitle");

            //create one tab for each distinct menu
            foreach (DataRow dr in parents.Rows)
            {
                ToolStripMenuItem parent = new ToolStripMenuItem(dr["MenuName"].ToString());

                //now fetch a list of the submenus from the orignal table that have the same name
                DataView subTemp = menuSystem.DefaultView;
                subTemp.RowFilter = "MenuName = '" + dr["MenuName"].ToString() +"'";

                foreach (DataRow subdr in subTemp.ToTable().Rows)
                {
                    ToolStripMenuItem subitem = new ToolStripMenuItem(subdr["formName"].ToString());
                    subitem.Name = subdr["assmName"].ToString();
                    subitem.Tag = subdr["formCode"].ToString();

                    try
                    {
                        Byte[] tileImage = new Byte[0];
                        tileImage = (Byte[])(subdr["image"]);
                        MemoryStream mem = new MemoryStream(tileImage);
                        subitem.Image = Image.FromStream(mem);
                    }
                    catch { }
                    subitem.Click += new EventHandler(DynamicButton_Click);
                    
                    parent.DropDownItems.Add(subitem);
                }

                mnuMain.Items.Add(parent);
            }
            _Auth.swipe(false);
            userId = _Auth.userId;
        }
#region dynaminc button clicking
        private void DynamicMouseOver(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void DynamicMouseOut(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void DynamicButton_Click(object sender, EventArgs e)
        {
            string assemblyname = ((ToolStripMenuItem)sender).Name;
            string formname = ((ToolStripMenuItem)sender).Tag.ToString();
            try
            {
                Assembly myAssembly = Assembly.Load(assemblyname);
                Form myForm = (Form)myAssembly.CreateInstance(formname);

                myForm.Show();
            }
            catch (Exception x)
            {
                MessageBox.Show("There was an error loading the application. Please contact technical support.  " +x, "Error");
            }
        }
#endregion
        
        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void fileMnu()
        {
            ToolStripMenuItem fileMN = new ToolStripMenuItem("FILE");
            fileMN.DropDownItems.Add("LOGOUT", null, lnLogout_Click);
            fileMN.DropDownItems.Add("EXIT", null, lnExit_Click);
            mnuMain.Items.Add(fileMN);
        }

        private void lnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnLogout_Click(object sender, EventArgs e)
        {
            mnuMain.Items.Clear();
            showLogin();
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F11)
            {
                console.Show();
            }
        }
    }
}
