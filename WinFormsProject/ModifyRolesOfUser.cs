using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject
{
    public partial class ModifyRolesOfUser : Form
    {
        //Variable to check if user pressed OK button
        public bool OK = false;

        //Variable to store the username with get and set methods
        public string Username { get; set; } = "";
        //Variable to return the list of roles assigned to the user
        public List<string> Roles { get; set; } = new List<string>();

        public ModifyRolesOfUser()
        {
            InitializeComponent();
        }
        //list of roles save before modification, have two columns, one for role name and one for check state
        List<Tuple<string, bool>> saveRoles = new List<Tuple<string, bool>>();

        private void ModifyRolesOfUser_Load(object sender, EventArgs e)
        {
            //Get the list of roles from the database using query "SELECT ROLE FROM DBA_ROLES"
            //and add them to the flow layout panel as checkboxes
            //Set the text of the checkboxes to the role name
            //Get the list of roles assigned to the user using query "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GR
            //ANTED_ROLE = 'username'"
            //and check the checkboxes for the roles assigned to the user
            OK = false;
            string query = "SELECT ROLE FROM DBA_ROLES";
            string query2 = "SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + Username + "'";
            OracleCommand cmd = new OracleCommand(query, Login.con);
            OracleCommand cmd2 = new OracleCommand(query2, Login.con);
            OracleDataReader reader = cmd.ExecuteReader();
            OracleDataReader reader2 = cmd2.ExecuteReader();
            List<CheckBox> checks = new List<CheckBox>();
            while (reader.Read())
            {
                CheckBox cb = new CheckBox();
                cb.Text = reader.GetString(0);
                checks.Add(cb);
                while (reader2.Read())
                {
                    if (cb.Text == reader2.GetString(0))
                    {
                        cb.Checked = true;
                    }
                }
                reader2.Close();
                reader2 = cmd2.ExecuteReader();
            }
            checks.Reverse();
            foreach (CheckBox cb in checks)
            {
                flowLayoutPanelColumns.Controls.Add(cb);
            }
            reader.Close();
            //save to the #saveRoles list the role name and the check state of the checkboxes
            foreach (CheckBox cb in flowLayoutPanelColumns.Controls)
            {
                saveRoles.Add(new Tuple<string, bool>(cb.Text, cb.Checked));
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //Get the list of new roles assigned and list of roles being remove from the users by compare the current #flowLayoutPanelColumns
            //with the #saveRoles list
            //If the check state of the checkbox is changed, add the role to the list of new roles assigned or list of roles being removed
            //If the check state of the checkbox is not changed, do nothing
            //If the role is in the list of new roles assigned, add the role to the user using query "GRANT role TO username"
            //If the role is in the list of roles being removed, remove the role from the user using query "REVOKE role FROM username"
            OK = true;
            List<string> newRoles = new List<string>();
            List<string> removeRoles = new List<string>();
            Roles.Clear();
            foreach (CheckBox cb in flowLayoutPanelColumns.Controls)
            {
                if (cb.Checked)
                {
                    Roles.Add(cb.Text);
                }
                foreach (Tuple<string, bool> t in saveRoles)
                {
                    if (cb.Text == t.Item1 && cb.Checked != t.Item2)
                    {
                        if (cb.Checked)
                        {
                            newRoles.Add(cb.Text);
                        }
                        else
                        {
                            removeRoles.Add(cb.Text);
                        }
                    }
                }
            }
            foreach (string role in newRoles)
            {
                string query = "GRANT " + role + " TO " + Username;
                OracleCommand cmd = new OracleCommand(query, Login.con);
                cmd.ExecuteNonQuery();
            }
            foreach (string role in removeRoles)
            {
                string query = "REVOKE " + role + " FROM " + Username;
                OracleCommand cmd = new OracleCommand(query, Login.con);
                cmd.ExecuteNonQuery();
            }
            //Show message box "Roles modified successfully", the new roles assigned and the roles being removed
            MessageBox.Show("Roles modified successfully\nNew roles assigned: " + string.Join(", ", newRoles) + "\nRoles being removed: " + string.Join(", ", removeRoles));

            
            this.Close();

        }
    }
}
