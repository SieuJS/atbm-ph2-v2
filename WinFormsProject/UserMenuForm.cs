using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject
{
    public partial class UserMenuForm : Form
    {
        public UserMenuForm()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    // Tat cac bang khong co quyen truy cap
                    pHANCONGToolStripMenuItem.Enabled = false;
                    dANGKYToolStripMenuItem.Enabled = false;
                    break;
                case "Giảng viên":

                    break;
                case "Giáo vụ":
                    break;
                case "Trưởng đơn vị":

                    break;
                case "Trưởng khoa":

                    break;
                case "Sinh viên":

                    break;

            }
        }

        void EditData()
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lbName.Text = "NHANSU";
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_NVCB_XEMTTCN";
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        oda.Fill(dataTable);
                        dtgvData.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Giảng viên":

                    break;
                case "Giáo vụ":
                    break;
                case "Trưởng đơn vị":

                    break;
                case "Trưởng khoa":

                    break;
                case "Sinh viên":

                    break;

            }
        }

        private void sINHVIENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbName.Text = "SINHVIEN";
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_NVCB_XEMTT_SV";
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        oda.Fill(dataTable);
                        dtgvData.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Giảng viên":

                    break;
                case "Giáo vụ":
                    break;
                case "Trưởng đơn vị":

                    break;
                case "Trưởng khoa":

                    break;
                case "Sinh viên":

                    break;

            }
        }

        private void dONVIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbName.Text = "DONVI";
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_NVCB_XEMTT_DV";
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        oda.Fill(dataTable);
                        dtgvData.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Giảng viên":

                    break;
                case "Giáo vụ":
                    break;
                case "Trưởng đơn vị":

                    break;
                case "Trưởng khoa":

                    break;
                case "Sinh viên":

                    break;

            }
        }

        private void hOCPHANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbName.Text = "HOCPHAN";
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_NVCB_XEMTT_HOCPHAN";
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        oda.Fill(dataTable);
                        dtgvData.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Giảng viên":

                    break;
                case "Giáo vụ":
                    break;
                case "Trưởng đơn vị":

                    break;
                case "Trưởng khoa":

                    break;
                case "Sinh viên":

                    break;

            }
        }

        private void kHMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbName.Text = "KHMO";
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_NVCB_XEMTT_KHMO";
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        OracleDataAdapter oda = new OracleDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        oda.Fill(dataTable);
                        dtgvData.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Giảng viên":

                    break;
                case "Giáo vụ":
                    break;
                case "Trưởng đơn vị":

                    break;
                case "Trưởng khoa":

                    break;
                case "Sinh viên":

                    break;

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            if (dtgvData.DataSource == null)
            {
                MessageBox.Show("No data to edit");
                return;
            }
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    try
                    {
                        EditForm edit = new EditForm();
                        edit.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Giảng viên":

                    break;
                case "Giáo vụ":
                    break;
                case "Trưởng đơn vị":

                    break;
                case "Trưởng khoa":

                    break;
                case "Sinh viên":

                    break;

            }
        }
    }

}

