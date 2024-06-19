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
    public partial class AddRoleForm : Form
    {
        //Variable to check if user pressed OK button with get and set
        //Public function to get Username and Password from Login form
        public string GetRoleName()
        {
            return txt_rolename.Text;
        }
        public bool OK { get; set; }
        public AddRoleForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
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
