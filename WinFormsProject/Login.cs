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
            //Connect to Oracle database using OracleConnection and save connection to use in MenuForm
            string conString = "User Id=" + txt_username.Text + ";Password=" + txt_password.Text + ";Data Source=localhost:1521/xe;";
           
            //if txtusername.text is sys, connect as sysdba
            if (txt_username.Text == "sys")
            {
                conString += "DBA Privilege=SYSDBA;";
            }
            con = new OracleConnection(conString);
            try
            {
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
            txt_username.Focus();
        }

    }
}

