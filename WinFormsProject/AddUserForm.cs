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
    public partial class AddUserForm : Form
    {
        //Variable to check if user pressed OK button
        public bool OK = false;
        //Public function to get Username and Password from Login form
        public string GetUsername()
        {
            return txt_username.Text;
        }
        public string GetPassword()
        {
            return txt_password.Text;
        }
        //Public function to set Username and Password in Login form
        public void SetUsername(string username)
        {
            txt_username.Text = username;
        }
        public void SetPassword(string password)
        {
            txt_password.Text = password;
        }
        //set the label text
        public void SetLabel(string label)
        {
            label1.Text = label;
        }
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //Close the form
            OK = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OK = false;
            this.Close();
        }
    }
}
