using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;

namespace WinFormsProject
{
    public partial class SelectPrivilegeForm : Form
    {
        // Variable to store the table name with get and set methods
        public string QueryString { get; set; }
        public string QueryString2 { get; set; }
        // Variable to store the user role name with get and set methods
        public string UserRoleName { get; set; }
        //Variable to store the new created privilege with get and set methods
        public Privelege NewPrivilege { get; set; }

        


        public SelectPrivilegeForm()
        {
            InitializeComponent();
            // Set the default value of the privilege to SELECT
            //Add privileges SELECT, INSERT, UPDATE, DELETE to the combo box #comboBoxPrivilege
            //and set the default value to SELECT
            comboBoxPrivilege.Items.Add("INSERT");
            comboBoxPrivilege.Items.Add("DELETE");
            comboBoxPrivilege.Items.Add("SELECT");
            comboBoxPrivilege.Items.Add("UPDATE");
            comboBoxPrivilege.SelectedIndex = 0;
            //Add tables STUDENT,COURSE,SECTION,GRADE_REPORT,PREREQUISITE to the combo box #comboBoxTable
            //and set the default value to STUDENT
            comboBoxTable.Items.Add("STUDENT");
            comboBoxTable.Items.Add("COURSE");
            comboBoxTable.Items.Add("SECTION");
            comboBoxTable.Items.Add("GRADE_REPORT");
            comboBoxTable.Items.Add("PREREQUISITE");
            comboBoxTable.SelectedIndex = 0;







        }
        //Disable the checkbox #checkBoxGrantOption
        public void DisableCheckBoxGrantOption()
        {
            checkBoxGrantOption.Checked = false;
            checkBoxGrantOption.Enabled = false;
        }
        //Enable the checkbox #checkBoxGrantOption
        public void EnableCheckBoxGrantOption()
        {
            checkBoxGrantOption.Checked = true;
            checkBoxGrantOption.Enabled = true;
        }
        
        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Event handler for the combo box #comboBoxTable when the selected index is changed
            //It will first clear the items in #flowLayoutPanelColumns
            //Then it will add the columns(get from database) of the selected table to the #flowLayoutPanelColumns
            //The columns are added as checkboxes

            //Then if the selected privilege is SELECT, UPDATE, it will enable the radio button #radioButtonCustom
            //to choose custom columns, otherwise it will disable it
            //The default would set the #radioButtonAll to be checked
            flowLayoutPanelColumns.Controls.Clear();
            string tableName = comboBoxTable.SelectedItem.ToString();
            string query = "SELECT * FROM " + tableName;
            OracleCommand cmd = new OracleCommand(query, Login.con);
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            oda.Fill(dt);

            foreach (DataColumn column in dt.Columns)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = column.ColumnName;
                checkBox.Checked = true;
                flowLayoutPanelColumns.Controls.Add(checkBox);
            }

            ResetRadioButtonsToAll();
        }

        private void comboBoxPrivilege_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetRadioButtonsToAll();
        }

        private void ResetRadioButtonsToAll()
        {
            radioButtonAll.Checked = true;
            DisableListColumns();
            if (comboBoxPrivilege.SelectedItem.ToString() == "SELECT" || comboBoxPrivilege.SelectedItem.ToString() == "UPDATE")
            {
                radioButtonCustom.Enabled = true;
            }
            else
            {
                radioButtonCustom.Enabled = false;
            }
        }
        //Function to disable #radioButtonCustom and all the checkboxes in #flowLayoutPanelColumns
        private void DisableListColumns()
        {
            foreach (CheckBox checkBox in flowLayoutPanelColumns.Controls)
            {
                checkBox.Enabled = false;
            }
        }
        //Function to enable #radioButtonCustom and all the checkboxes in #flowLayoutPanelColumns
        private void EnableListColumns()
        {
            foreach (CheckBox checkBox in flowLayoutPanelColumns.Controls)
            {
                checkBox.Enabled = true;
            }
        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustom.Checked)
            {
                EnableListColumns();
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //When the OK button is clicked, it will set the QueryString to execute in other form
            //The QueryString would be like GRANT @PRIVILEGE ON @TABLE TO @USER WITH GRANT OPTION
            //The Privilege would be the selected privilege in the combo box #comboBoxPrivilege
            //The Table would be the selected table in the combo box #comboBoxTable
            //The grant option would be checked if the check box #checkBoxGrantOption is checked
            //If the radio button #radioButtonCustom is checked, then the columns would be added to the QueryString
            //The columns would be the selected columns in the checkboxes in #flowLayoutPanelColumns
            //The QueryString would be like GRANT @PRIVILEGE(@COLUMNS) ON @TABLE TO @USER WITH GRANT OPTION
            //If the Privilege is SELECT and the radio button #radioButtonAll is not checked, then the QueryString would be like
            //CREATE VIEW COL1_COL2 AS SELECT COL1, COL2 FROM STUDENT;
            //GRANT SELECT ON COL1_COL2 TO UserRoleName;
            QueryString = "GRANT " + comboBoxPrivilege.SelectedItem.ToString();
            if (radioButtonCustom.Checked)
            {
                QueryString += "(";
                foreach (CheckBox checkBox in flowLayoutPanelColumns.Controls)
                {
                    if (checkBox.Checked)
                    {
                        QueryString += checkBox.Text + ",";
                    }
                }
                QueryString = QueryString.TrimEnd(',');
                QueryString += ")";
            }
            QueryString += " ON " + comboBoxTable.SelectedItem.ToString() + " TO " + UserRoleName;
            if (checkBoxGrantOption.Checked)
            {
                QueryString += " WITH GRANT OPTION";
            }
            QueryString2 = "";
            string viewName = "";
            if (comboBoxPrivilege.SelectedItem.ToString() == "SELECT" && !radioButtonAll.Checked)
            {
                QueryString = "CREATE VIEW ";
                foreach (CheckBox checkBox in flowLayoutPanelColumns.Controls)
                {
                    if (checkBox.Checked)
                    {
                        viewName += checkBox.Text + "_";
                    }
                }
                viewName = viewName.TrimEnd('_');
                QueryString += viewName + " AS SELECT ";
                foreach (CheckBox checkBox in flowLayoutPanelColumns.Controls)
                {
                    if (checkBox.Checked)
                    {
                        QueryString += checkBox.Text + ",";
                    }
                }
                QueryString = QueryString.TrimEnd(',');
                QueryString += " FROM " + comboBoxTable.SelectedItem.ToString();
                QueryString2 = "GRANT SELECT ON " + viewName + " TO " + UserRoleName;
            }
            //Set the selected values to the NewPrivilege object
            NewPrivilege = new Privelege();
            NewPrivilege.TableName = comboBoxTable.SelectedItem.ToString();
            NewPrivilege.PrivelegeName = comboBoxPrivilege.SelectedItem.ToString();
            NewPrivilege.WithGrantOption = checkBoxGrantOption.Checked;
            //if the radio button #radioButtonAll is checked, then add nothing to the columns (mean all columns)
            //Otherwise add the selected columns to the NewPrivilege object
            if (radioButtonCustom.Checked)
            {
                foreach (CheckBox checkBox in flowLayoutPanelColumns.Controls)
                {
                    if (checkBox.Checked)
                    {
                        NewPrivilege.ColumnNames.Add(checkBox.Text);
                    }
                }
            }
            if (comboBoxPrivilege.SelectedItem.ToString() == "SELECT" && !radioButtonAll.Checked)
            {
                NewPrivilege.TableName = viewName;
                NewPrivilege.ColumnNames.Clear();
            }
            this.Close();
            




        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            QueryString = "";
            this.Close();
        }
    }
}
