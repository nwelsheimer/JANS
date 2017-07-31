using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using General;
using System.Windows.Forms;

namespace Nursery_Production_Software
{
    public partial class usrPref : MetroForm
    {
        DataSet userList = new DataSet(); //Global dataset that we can use for filtering and stuffs

        public usrPref()
        {
            InitializeComponent();

            tabPrefs.SelectedTab = menus;
            Global.connectToDB(); //connect to the JANS DB
        }

        private void cmbMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenus.Enabled == true)
            {
                DataSet modules = new DataSet();
                modules = Global.GetData("select id, formName from SYS_MenuDetail where menuId = " + cmbMenus.SelectedValue + " order by formName");
                lbApps.DataSource = modules.Tables[0].DefaultView;
                lbApps.DisplayMember = "formName";
                lbApps.ValueMember = "id";
            }
        }

        private void usrPref_Load(object sender, EventArgs e)
        {
            //Load in menu items
            DataSet parentMenus = new DataSet();
            parentMenus = Global.GetData("select id,name from SYS_Menu order by name");
            cmbMenus.DataSource = parentMenus.Tables[0].DefaultView;
            cmbMenus.DisplayMember = "name";
            cmbMenus.ValueMember = "id";
            cmbMenus.SelectedIndex = -1;
            cmbMenus.Enabled = true;

            refreshUsers();
        }

        private void refreshUsers()
        {
            userList = Global.GetData("select id,username from SYS_Users order by username");
            lbUsers.DataSource = userList.Tables[0].DefaultView;
            lbUsers.DisplayMember = "username";
            lbUsers.ValueMember = "id";
        }

        private void lbApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet appDetail = new DataSet();
            string query = "select formCode,formName,assmName from SYS_MenuDetail where id=" + 
                (lbApps.SelectedItem as DataRowView)["id"].ToString();
            appDetail = Global.GetData(query);
            lblDescription.Text = appDetail.Tables[0].Rows[0]["formName"].ToString();
            lblAssembly.Text = appDetail.Tables[0].Rows[0]["assmName"].ToString();
            lblModule.Text = appDetail.Tables[0].Rows[0]["formCode"].ToString();

            RefreshMenuGroups();
        }

        private void RefreshMenuGroups()
        {
            cbGroups2.Enabled = false;

            string query = @"select sg.id,sg.description
	                    ,case when smg.menuDetailId is null then 0 else 1 end as Member
                        from SYS_Groups sg left join SYS_MenuGroups smg on smg.groupId = sg.id and smg.menuDetailId =" +
                (lbApps.SelectedItem as DataRowView)["id"].ToString();
            DataSet mnuGroups = Global.GetData(query);
            cbGroups2.DataSource = mnuGroups.Tables[0].DefaultView;
            cbGroups2.DisplayMember = "description";
            cbGroups2.ValueMember = "id";
            
            bool selected = false;
            string id = "";
            int index = 0;
            foreach (DataRow r in mnuGroups.Tables[0].Rows)
            {
                selected = Convert.ToBoolean(r["Member"]);
                id = r["id"].ToString();
                index = cbGroups2.Items.IndexOf(id);
                for (int i = 0; i < cbGroups2.Items.Count; i++)
                {
                    if (((System.Data.DataRowView)(cbGroups2.Items[i])).Row.ItemArray[0].ToString() == id)
                        cbGroups2.SetItemChecked(i, selected);
                }
            }
            btnAddGroup_2.Enabled = true;
            btnRemove2.Enabled = true;
            cbGroups2.Enabled = true;
        }

        private void btnAddGroup_2_Click(object sender, EventArgs e)
        {
            string newGroup = txtAddGroup_2.Text;
            if (newGroup.Length >3)
            {
                string query = "insert into sys_groups (description) values ('" + newGroup +"')";
                Global.ExecuteQuery(query);
                RefreshMenuGroups();
                txtAddGroup_2.Text = "";
            } else
            {
                MessageBox.Show("Please enter a group name of 4 or more letters.");
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            string id = cbGroups2.SelectedValue.ToString();
            string query = "delete from sys_groups where id=" + id;
            if (MessageBox.Show("Are you sure you want to delete group?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Global.ExecuteQuery(query);
                RefreshMenuGroups();
            }
        }

        private void tabPrefs_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove2.Enabled = false;
            btnAddGroup_2.Enabled = false;
            btnAddGroup.Enabled = false;
            cbGroups2.DataSource = null;
            cbGroups2.Items.Clear();
        }

        private void cbGroups2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (cbGroups2.Enabled)
            {
                string menuId = lbApps.SelectedValue.ToString();
                string groupId = ((System.Data.DataRowView)(cbGroups2.Items[e.Index])).Row.ItemArray[0].ToString();
                string query = "";
                if (e.NewValue == CheckState.Checked)
                {
                    query = "insert into sys_menugroups (menuDetailId,groupId) values (" + menuId + "," + groupId + ")";
                }
                else
                {
                    query = "delete from sys_menugroups where menuDetailId=" + menuId + " and groupId=" + groupId;
                }
                Global.ExecuteQuery(query);
            }
        }

        private void txtFilterUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFilterUser.Text.Length > 2)
            {
                userList.Tables[0].DefaultView.RowFilter = "username like '" + txtFilterUser.Text + "*'";
            } else
            {
                userList.Tables[0].DefaultView.RowFilter = "";
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Text.Length >= 3)
            {
                string query = @"insert into sys_users (username,password,isadmin) values
                               ('"+txtNewUser.Text+"','changeme',0)";
                Global.ExecuteQuery(query);
                refreshUsers();
                txtNewUser.Text = "";
            } else
            {
                MessageBox.Show("Please enter a user name with a length greater than 3 to continue.");
            }
        }
    }
}
