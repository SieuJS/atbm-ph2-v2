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

        public static String usernameUser;
        public static String passUser;
        public static String roleUser;

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
            // Connect to Oracle database using OracleConnection and save connection to use in MenuForm
            string conString = "User Id=" + txt_username.Text + ";Password=" + txt_password.Text + ";Data Source=localhost:1521/xe;";
            
            try
            {
                if (txt_role.Text == "SYSDBA")
                    conString += "DBA Privilege=SYSDBA;";

                con = new OracleConnection(conString);
                con.Open();

                usernameUser = txt_username.Text;
                passUser = txt_password.Text;


                if (txt_role.Text == "SYSDBA")
                {
                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Connected successfully!");
                    Menuform form2 = new Menuform();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    command.ExecuteNonQuery();

                    string sqlRole = "";
                    bool isStudent = false;

                    // Check if user is a student
                    sqlRole = "SELECT MASV FROM QLDLNB.SINHVIEN WHERE MASV = :masv";
                    OracleCommand commandRole = new OracleCommand(sqlRole, con);
                    commandRole.Parameters.Add(new OracleParameter("masv", txt_username.Text));

                    OracleDataReader dr = commandRole.ExecuteReader();
                    if (dr.Read())
                    {
                        roleUser = "Sinh viên";
                        isStudent = true;
                    }
                    dr.Close();

                    // If not a student, check if user is HR
                    if (!isStudent)
                    {
                        sqlRole = "SELECT VAITRO FROM QLDLNB.NHANSU WHERE MANV = :manv";
                        commandRole = new OracleCommand(sqlRole, con);
                        commandRole.Parameters.Add(new OracleParameter("manv", txt_username.Text));

                        dr = commandRole.ExecuteReader();
                        if (dr.Read())
                        {
                            roleUser = dr.GetString(0);
                        }
                        dr.Close();

                        if (string.IsNullOrEmpty(roleUser))
                        {
                            MessageBox.Show("User not found");
                            con.Dispose();
                            con.Close();
                            OracleConnection.ClearPool(con);
                            return;
                        }

                        if (txt_role.Text != roleUser)
                        {
                            MessageBox.Show("Role doesn't match with user");
                            con.Dispose();
                            con.Close();
                            OracleConnection.ClearPool(con);
                            return;
                        }
                    }

                    MessageBox.Show("Connected successfully!");
                    LesserMenuForm lmf= new LesserMenuForm();
                    switch (roleUser)
                    {
                        case "Nhân viên cơ bản":
                            lmf.Text = "NHÂN VIÊN CƠ BẢN";
                            break;
                        case "Giảng viên":
                            lmf.Text = "GIẢNG VIÊN";
                            break;
                        case "Giáo vụ":
                            lmf.Text = "GIÁO VỤ";
                            break;
                        case "Trưởng đơn vị":
                            lmf.Text = "TRƯỞNG ĐƠN VỊ";
                            break;
                        case "Trưởng khoa":
                            lmf.Text = "TRƯỞNG KHOA";
                            break;
                        case "Sinh viên":
                            lmf.Text = "SINH VIÊN";
                            break;
                    }

                    lmf.Show();
                    dr.Close();
                }

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

