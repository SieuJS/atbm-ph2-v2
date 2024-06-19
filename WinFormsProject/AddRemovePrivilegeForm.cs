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
    //Enum to check if this is from a user or a role
    public enum PrivilegeType
    {
        User,
        Role
    }
    public partial class AddRemovePrivilegeForm : Form
    {
        //Public variable to check if this is from a user or a role
        public PrivilegeType privilegeType { get; set; } = PrivilegeType.User;

        //Public variable to store the User and Role objects
        public User user { get; set; } = new User();
        public Role role { get; set; } = new Role();
        public AddRemovePrivilegeForm()
        {
            InitializeComponent();
        }
        //Function to load the privileges of the user or role to the data grid view
        //It would set the form text to the username or role name
        public void AddRemovePrivilegeForm_Load()
        {
            if (privilegeType == PrivilegeType.User)
            {
                this.Text = user.UserName;
                //Load the privileges of the user to the data grid view
                foreach (Privelege privilege in user.Priveleges)
                {
                    AddPrivilegeToRow(privilege);
                }
            }
            else
            {
                this.Text = role.RoleName;
                //Load the privileges of the role to the data grid view
                foreach (Privelege privilege in role.Priveleges)
                {
                    AddPrivilegeToRow(privilege);
                }
            }
        }
        //Function to add privilege to data grid view row
        private void AddPrivilegeToRow(Privelege privilege)
        {
            string columns = privilege.ColumnNames.Count > 0 ? privilege.ColumnNames.Aggregate((i, j) => i + ", " + j) : "all";
            dgv.Rows.Add(privilege.TableName, columns, privilege.PrivelegeName, privilege.WithGrantOption == true ? "Yes" : "No");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Add privilege to the user or role
            //It will open a new form to add privilege #SelectPrivilegeForm, that form would return the privilege object
            //Then it would add the privilege to the user or role by using the query #QueryString from #SelectPrivilegeForm
            SelectPrivilegeForm selectPrivilegeForm = new SelectPrivilegeForm();
            selectPrivilegeForm.UserRoleName = this.Text;
            if (privilegeType == PrivilegeType.User)
            {
                selectPrivilegeForm.EnableCheckBoxGrantOption();
            }
            else
            {
                selectPrivilegeForm.DisableCheckBoxGrantOption();
            }
            selectPrivilegeForm.ShowDialog();
            if (selectPrivilegeForm.QueryString != "")
            {
                //Execute the query to add the privilege to the user or role
                OracleCommand cmd = new OracleCommand(selectPrivilegeForm.QueryString, Login.con);
                //Check if the querystring is to create a view, if it is, then
                //check if the name of the view created is not be used, if it is used, it would drop the view
                if (selectPrivilegeForm.QueryString.Contains("CREATE VIEW"))
                {
                    OracleCommand cmdCheck = new OracleCommand("SELECT * FROM user_views WHERE view_name = '" + selectPrivilegeForm.NewPrivilege.TableName + "'", Login.con);
                    OracleDataReader reader = cmdCheck.ExecuteReader();
                    if (reader.Read())
                    {
                        OracleCommand cmdDrop = new OracleCommand("DROP VIEW " + selectPrivilegeForm.NewPrivilege.TableName, Login.con);
                        cmdDrop.ExecuteNonQuery();
                    }
                }

                try
                {
                    cmd.ExecuteNonQuery();
                    //if queryString2 is not empty, execute it
                    if (selectPrivilegeForm.QueryString2 != "")
                    {
                        OracleCommand cmd2 = new OracleCommand(selectPrivilegeForm.QueryString2, Login.con);
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Privilege added successfully!");
                    //Add the privilege to the user or role
                    Privelege newPrivilege = selectPrivilegeForm.NewPrivilege;
                    if (privilegeType == PrivilegeType.User)
                    {
                        user.Priveleges.Add(newPrivilege);
                    }
                    else
                    {
                        role.Priveleges.Add(newPrivilege);
                    }
                    //Add the privilege to the data grid view
                    AddPrivilegeToRow(newPrivilege);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Failed to add privilege: " + ex.Message);
                }


            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Remove privilege from the user or role
            //It would remove the selected privilege from the data grid from the database
            //and also remove from the view and the user or role
            if (dgv.SelectedRows.Count > 0)
            {
                string tableName = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string columns = dgv.SelectedRows[0].Cells[1].Value.ToString();
                string privilegeName = dgv.SelectedRows[0].Cells[2].Value.ToString();
                string withGrantOption = dgv.SelectedRows[0].Cells[3].Value.ToString();
                string query = "REVOKE " + privilegeName + " ON " + tableName + " FROM " + this.Text;
                //if (columns != "all")
                //{
                //    query += " (" + columns + ")";
                //}
                OracleCommand cmd = new OracleCommand(query, Login.con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Privilege removed successfully!");
                    //Remove the privilege from the user or role
                    Privelege removedPrivilege = new Privelege();
                    removedPrivilege.TableName = tableName;
                    removedPrivilege.ColumnNames = columns == "all" ? new List<string>() : columns.Split(',').ToList();
                    removedPrivilege.PrivelegeName = privilegeName;
                    removedPrivilege.WithGrantOption = withGrantOption == "Yes" ? true : false;
                    if (privilegeType == PrivilegeType.User)
                    {
                        //Find the privilege in the user and remove it
                        foreach (Privelege privilege in user.Priveleges)
                        {
                            if (privilege.TableName == removedPrivilege.TableName && privilege.PrivelegeName == removedPrivilege.PrivelegeName)
                            {
                                user.Priveleges.Remove(privilege);
                                break;
                            }
                        }
                    }
                    else
                    {
                        //Find the privilege in the role and remove it
                        foreach (Privelege privilege in role.Priveleges)
                        {
                            if (privilege.TableName == removedPrivilege.TableName && privilege.PrivelegeName == removedPrivilege.PrivelegeName)
                            {
                                role.Priveleges.Remove(privilege);
                                break;
                            }
                        }
                    }
                    //Remove the privilege from the data grid view
                    dgv.Rows.Remove(dgv.SelectedRows[0]);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Failed to remove privilege: " + ex.Message);
                }
            }
        }
    }
}
