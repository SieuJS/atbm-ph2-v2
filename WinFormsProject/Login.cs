using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsProject
{
    public partial class Login : Form
    {

        public static OracleConnection con = new();
        public Login()
        {
            InitializeComponent();
        }


        private void button_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
            {
                MessageBox.Show("Username can't be empty.");
                return;
            }
            if (txt_password.Text.Length == 0)
            {
                MessageBox.Show("Password can't be empty.");
                return;
            }
            if (txt_role.Text.Length == 0)
            {
                MessageBox.Show("Role can't be empty.");
                return;
            }
            //Connect to Oracle database using OracleConnection and save connection to use in MenuForm
            string conString = "User Id=" + txt_username.Text + ";Password=" + txt_password.Text + ";Data Source=localhost:1521/xe;";

            //if txtusername.text is sys, connect as sysdba
            
            try
            {
                if (txt_role.Text == "SYSDBA")
                {
                    conString += "DBA Privilege=SYSDBA;";
                }
                con = new OracleConnection(conString);
                con.Open();
                MessageBox.Show("Connected successfully!");
                Menuform form2 = new Menuform();
                form2.Show();
                this.Hide();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_role.ResetText();
            txt_username.Focus();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

