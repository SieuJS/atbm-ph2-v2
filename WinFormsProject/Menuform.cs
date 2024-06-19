using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static WinFormsProject.Menuform;
namespace WinFormsProject
{

    public partial class Menuform : Form
    {
        //Create User Class, Role Class and Privelege Class to store data from Oracle database
        //User Class has properties: UserName as string, Roles as list of Role, Priveleges as list of Privelege
        //Role Class has properties: RoleName as string, Priveleges as list of Privelege
        //Privelege Class has properties: PrivelegeName as string

        List<User> users = new List<User>();
        List<Role> roles = new List<Role>();
        List<Privelege> priveleges = new List<Privelege>();
        public Menuform()
        {
            InitializeComponent();
            //Use OracleConnection from Login form to connect to Oracle database and display data in DataGridView

            //Get data of user from Oracle database using "SELECT * FROM DBA_USERS;" query where the account authentication_type is 'PASSWORD' and not the default account
            string query = "SELECT * FROM DBA_USERS WHERE AUTHENTICATION_TYPE = 'PASSWORD' AND DEFAULT_TABLESPACE NOT IN ('SYSTEM', 'SYSAUX', 'TEMP') AND USERNAME NOT IN ('SYS', 'SYSTEM')";
            OracleCommand cmd = new OracleCommand(query, Login.con);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            //add data to users object using loop
            foreach (DataRow row in dt.Rows)
            {
                User user = new User();
                user.UserName = row["USERNAME"].ToString();
                users.Add(user);
            }
            //Get roles of each user from Oracle database using "SELECT * FROM DBA_ROLE_PRIVS;" query
            query = "SELECT * FROM DBA_ROLE_PRIVS";
            cmd = new OracleCommand(query, Login.con);
            oda = new OracleDataAdapter(cmd);
            dt = new DataTable();
            oda.Fill(dt);
            //assign roles to each user using loop
            foreach (DataRow row in dt.Rows)
            {
                string userName = row["GRANTEE"].ToString();
                string roleName = row["GRANTED_ROLE"].ToString();
                User user = users.Find(u => u.UserName == userName);
                if (user != null)
                {
                    Role role = new Role();
                    role.RoleName = roleName;
                    user.Roles.Add(role);
                }
            }
            //Get all priveleges associated with each user from Oracle database using SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = 'username' query 
            //with username is the user name of each user
            // Get all table privileges for all users in one query
            query = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE IN ('" + string.Join("','", users.Select(u => u.UserName)) + "')";
            cmd = new OracleCommand(query, Login.con);
            oda = new OracleDataAdapter(cmd);
            dt = new DataTable();
            oda.Fill(dt);

            // Distribute the table privileges to the appropriate User objects
            foreach (DataRow row in dt.Rows)
            {
                string userName = row["GRANTEE"].ToString();
                User user = users.Find(u => u.UserName == userName);
                if (user != null)
                {
                    Privelege privelege = new Privelege();
                    privelege.TableName = row["TABLE_NAME"].ToString();
                    privelege.PrivelegeName = row["PRIVILEGE"].ToString();
                    privelege.WithGrantOption = row["GRANTABLE"].ToString() == "YES";
                    user.Priveleges.Add(privelege);
                }
            }

            //Get columns priveleges associated with each user from Oracle database using SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = 'username' query
            //with username is the user name of each user, then add it to user.Priveleges object by grouping it by table name and privelege name
            // Get all column privileges for all users in one query
            query = "SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE IN ('" + string.Join("','", users.Select(u => u.UserName)) + "')";
            cmd = new OracleCommand(query, Login.con);
            oda = new OracleDataAdapter(cmd);
            dt = new DataTable();
            oda.Fill(dt);

            // Distribute the column privileges to the appropriate User objects
            foreach (DataRow row in dt.Rows)
            {
                string userName = row["GRANTEE"].ToString();
                User user = users.Find(u => u.UserName == userName);
                if (user != null)
                {
                    Privelege privelege = user.Priveleges.Find(p => p.TableName == row["TABLE_NAME"].ToString() && p.PrivelegeName == row["PRIVILEGE"].ToString());
                    if (privelege == null)
                    {
                        privelege = new Privelege();
                        privelege.TableName = row["TABLE_NAME"].ToString();
                        privelege.PrivelegeName = row["PRIVILEGE"].ToString();
                        privelege.WithGrantOption = row["GRANTABLE"].ToString() == "YES";
                        user.Priveleges.Add(privelege);
                    }
                    privelege.ColumnNames.Add(row["COLUMN_NAME"].ToString());
                }
            }



            //View Users in DataGridView by add row to DataGridView using loop
            foreach (User user in users)
            {
                dgvUsers.Rows.Add(user.UserName, PrivilegeHelper.GetRolesString(user.Roles), PrivilegeHelper.GetPrivilegesString(user.Priveleges));
            }

            //Get all ueser-created roles where authentication_type is 'PASSWORD' from Oracle database using "SELECT * FROM DBA_ROLES;" query
            //query = "SELECT * FROM DBA_ROLES WHERE ROLE NOT " +
            //    "IN ('CONNECT', 'RESOURCE', 'DBA', 'SELECT_CATALOG_ROLE', 'EXECUTE_CATALOG_ROLE'," +
            //    " 'DELETE_CATALOG_ROLE', 'EXP_FULL_DATABASE', 'IMP_FULL_DATABASE', 'RECOVERY_CATALOG_OWNER', 'HS_ADMIN_SELECT_ROLE'," +
            //    " 'HS_ADMIN_EXECUTE_ROLE', 'GATHER_SYSTEM_STATISTICS', 'LOGSTDBY_ADMINISTRATOR', 'AQ_ADMINISTRATOR_ROLE', 'AQ_USER_ROLE', " +
            //    "'DATAPUMP_EXP_FULL_DATABASE', 'DATAPUMP_IMP_FULL_DATABASE', 'ADM_PARALLEL_EXECUTE_TASK', 'GSMADMIN_ROLE', 'GSMUSER_ROLE'," +
            //    " 'GSMPOOLADMIN_ROLE', 'WLM_ADMIN_ROLE', 'JAVA_ADMIN', 'JAVA_DEPLOY', 'JAVADEBUGPRIV', 'JAVASYSPRIV', 'JAVAUSERPRIV', 'OEM_ADVISOR', " +
            //    "'OEM_MONITOR', 'WM_ADMIN_ROLE')"; 
            query = "SELECT * FROM DBA_ROLES";
            cmd = new OracleCommand(query, Login.con);
            oda = new OracleDataAdapter(cmd);
            dt = new DataTable();
            oda.Fill(dt);
            //add data to roles object using loop
            foreach (DataRow row in dt.Rows)
            {
                Role role = new Role();
                role.RoleName = row["ROLE"].ToString();
                roles.Add(role);
            }
            roles.Reverse();
            //Get all priveleges associated with each role from Oracle database using SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE
            //is the role name of each role

            query = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE IN ('" + string.Join("','", roles.Select(r => r.RoleName)) + "')";
            cmd = new OracleCommand(query, Login.con);
            oda = new OracleDataAdapter(cmd);
            dt = new DataTable();
            oda.Fill(dt);

            // Distribute the privileges to the appropriate Role objects
            foreach (DataRow row in dt.Rows)
            {
                string roleName = row["GRANTEE"].ToString();
                Role role = roles.Find(r => r.RoleName == roleName);
                if (role != null)
                {
                    if (role.Priveleges.Count > 3) continue;
                    Privelege privelege = new Privelege();
                    privelege.TableName = row["TABLE_NAME"].ToString();
                    privelege.PrivelegeName = row["PRIVILEGE"].ToString();
                    privelege.WithGrantOption = row["GRANTABLE"].ToString() == "YES";
                    role.Priveleges.Add(privelege);
                }
            }



            //Get columns priveleges associated with each role from Oracle database using SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = 'rolename' query
            //with rolename is the role name of each role, then add it to role.Priveleges object by grouping it by table name and privelege name
            // Get all column privileges for all roles in one query
            query = "SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE IN ('" + string.Join("','", roles.Select(r => r.RoleName)) + "')";
            cmd = new OracleCommand(query, Login.con);
            oda = new OracleDataAdapter(cmd);
            dt = new DataTable();
            oda.Fill(dt);

            // Distribute the column privileges to the appropriate Role objects
            foreach (DataRow row in dt.Rows)
            {
                string roleName = row["GRANTEE"].ToString();
                Role role = roles.Find(r => r.RoleName == roleName);
                if (role != null)
                {
                    Privelege privelege = role.Priveleges.Find(p => p.TableName == row["TABLE_NAME"].ToString() && p.PrivelegeName == row["PRIVILEGE"].ToString());
                    if (privelege == null)
                    {
                        privelege = new Privelege();
                        privelege.TableName = row["TABLE_NAME"].ToString();
                        privelege.PrivelegeName = row["PRIVILEGE"].ToString();
                        privelege.WithGrantOption = row["GRANTABLE"].ToString() == "YES";
                        role.Priveleges.Add(privelege);
                    }
                    privelege.ColumnNames.Add(row["COLUMN_NAME"].ToString());
                }
            }

            //View Roles in DataGridView by add row to DataGridView using loop
            foreach (Role role in roles)
            {
                dgvRoles.Rows.Add(role.RoleName, PrivilegeHelper.GetPrivilegesString(role.Priveleges));
            }






        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Add new user to Oracle database using "CREATE USER username IDENTIFIED BY password;" query
            //First it will open a new form to input username and password
            AddUserForm form = new AddUserForm();
            form.SetLabel("Create User");
            form.ShowDialog();
            if (form.OK)
            {
                string username = form.GetUsername();
                string password = form.GetPassword();
                string query = "CREATE USER " + username + " IDENTIFIED BY " + password;
                ExecuteAlterSessionQuery();
                OracleCommand cmd = new OracleCommand(query, Login.con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User " + username + " created successfully!");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Failed to create user: " + ex.Message);
                }
                //Add this to local users object and DataGridView
                User user = new User();
                user.UserName = username;
                users.Add(user);
                dgvUsers.Rows.Add(username, "", "");
            }

        }

        //private void to execute the query alter session set "_ORACLE_SCRIPT"=true; before creating user to avoid ORA-65096 error
        private void ExecuteAlterSessionQuery()
        {
            OracleCommand cmd;
            cmd = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", Login.con);
            cmd.ExecuteNonQuery();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Delete user from Oracle database using "DROP USER username;" query
            //First it will get the selected user from DataGridView
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string username = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DROP USER " + username;
                ExecuteAlterSessionQuery();
                OracleCommand cmd = new OracleCommand(query, Login.con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User " + username + " deleted successfully!");
                    //Remove this from local users object and DataGridView
                    User user = users.Find(u => u.UserName == username);
                    users.Remove(user);
                    dgvUsers.Rows.Remove(dgvUsers.SelectedRows[0]);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Failed to delete user: " + ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Modify user password in Oracle database using "ALTER USER username IDENTIFIED BY password;" query
            //First it will open a new form with autofill username and input new password
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string username = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                AddUserForm form = new AddUserForm();
                form.SetLabel("Modify Password");
                form.SetUsername(username);
                form.SetPassword("");
                form.ShowDialog();
                if (form.OK)
                {
                    string password = form.GetPassword();
                    string query = "ALTER USER " + username + " IDENTIFIED BY " + password;
                    OracleCommand cmd = new OracleCommand(query, Login.con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password of user " + username + " modified successfully!");
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Failed to modify password: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add or remove priveleges to user in Oracle database using "GRANT/REVOKE privelege ON table TO username;" query
            //This is done by opening a new form fill with a list of priveleges and two buttons to add or remove priveleges
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string username = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                AddRemovePrivilegeForm form = new AddRemovePrivilegeForm();
                form.privilegeType = PrivilegeType.User;
                form.user = users.Find(u => u.UserName == username);
                form.AddRemovePrivilegeForm_Load();
                form.ShowDialog();
                //Reload the DataGridView after adding or removing priveleges
                dgvUsers.Rows.Clear();
                foreach (User user in users)
                {
                    dgvUsers.Rows.Add(user.UserName, PrivilegeHelper.GetRolesString(user.Roles), PrivilegeHelper.GetPrivilegesString(user.Priveleges));
                }



            }

        }

        //Make role as reference type

        private void AddPrivelegesToRole(Role role)
        {
            //Get priveleges from Oracle database using "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = 'rolename';" query
            //Then add it to the role.Priveleges object
            string query = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + role.RoleName + "'";
            OracleCommand cmd = new OracleCommand(query, Login.con);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Privelege privelege = new Privelege();
                privelege.TableName = row["TABLE_NAME"].ToString();
                privelege.PrivelegeName = row["PRIVILEGE"].ToString();
                privelege.WithGrantOption = row["GRANTABLE"].ToString() == "YES";
                role.Priveleges.Add(privelege);
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            //Add or remove priveleges to user in Oracle database using "GRANT/REVOKE privelege ON table TO username;" query
            //This is done by opening a new form fill with a list of priveleges and two buttons to add or remove priveleges
            if (dgvRoles.SelectedRows.Count > 0)
            {
                string roleName = dgvRoles.SelectedRows[0].Cells[0].Value.ToString();
                AddRemovePrivilegeForm form = new AddRemovePrivilegeForm();
                form.privilegeType = PrivilegeType.Role;
                form.role = roles.Find(r => r.RoleName == roleName);
                AddPrivelegesToRole(form.role);
                form.AddRemovePrivilegeForm_Load();
                form.ShowDialog();
                //Reload the DataGridView after adding or removing priveleges
                dgvRoles.Rows.Clear();
                foreach (Role role in roles)
                {
                    dgvRoles.Rows.Add(role.RoleName, PrivilegeHelper.GetPrivilegesString(role.Priveleges));
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExecuteAlterSessionQuery();


            //Add new role to Oracle database using "CREATE ROLE rolename;" query
            //First it will open a new form to input role name
            AddRoleForm form = new AddRoleForm();
            form.ShowDialog();
            if (form.OK)
            {
                string roleName = form.GetRoleName();
                string query = "CREATE ROLE " + roleName;
                OracleCommand cmd = new OracleCommand(query, Login.con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Role " + roleName + " created successfully!");
                    //Add this to local roles object and DataGridView
                    Role role = new Role();
                    role.RoleName = roleName;
                    roles.Insert(0,role);
                    dgvRoles.Rows.Insert(0,roleName, "");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Failed to create role: " + ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Delete role from Oracle database using "DROP ROLE rolename;" query
            //First it will get the selected role from DataGridView
            if (dgvRoles.SelectedRows.Count > 0)
            {
                string roleName = dgvRoles.SelectedRows[0].Cells[0].Value.ToString();
                string query = "DROP ROLE " + roleName;
                OracleCommand cmd = new OracleCommand(query, Login.con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Role " + roleName + " deleted successfully!");
                    //Remove this from local roles object and DataGridView
                    Role role = roles.Find(r => r.RoleName == roleName);
                    roles.Remove(role);
                    dgvRoles.Rows.Remove(dgvRoles.SelectedRows[0]);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Failed to delete role: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Add or remove roles to user in Oracle database using "GRANT/REVOKE role TO username;" query
            //This is done by opening #ModifyRolesOfUser form with the selected user
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string username = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
                ModifyRolesOfUser form = new ModifyRolesOfUser();
                form.Username = username;
                form.ShowDialog();
                //Assign the return roles to the user
                if (form.OK)
                {
                    User user = users.Find(u => u.UserName == username);
                    user.Roles.Clear();
                    foreach (string role in form.Roles)
                    {
                        user.Roles.Add(new Role() { RoleName = role });
                    }
                    //Reload the DataGridView after adding or removing roles
                    dgvUsers.Rows.Clear();
                    foreach (User _user in users)
                    {
                        dgvUsers.Rows.Add(_user.UserName, PrivilegeHelper.GetRolesString(_user.Roles), PrivilegeHelper.GetPrivilegesString(_user.Priveleges));
                    }
                }
            }
        }

    }
}
