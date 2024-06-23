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
        public void LoadData()
        {
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    lbName.Text = "NHANSU";
                    // Tat cac bang khong co quyen truy cap
                    pHANCONGToolStripMenuItem.Enabled = false;
                    dANGKYToolStripMenuItem.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    lbName.Text = "NHANSU";
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
                case "Giáo vụ":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    lbName.Text = "NHANSU";
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
                case "Trưởng đơn vị":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    lbName.Text = "NHANSU";
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
                case "Trưởng khoa":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    lbName.Text = "NHANSU";
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
                case "Sinh viên":

                    break;

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Do nothing
            return;
        }

        private void nHANSUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbName.Text = "NHANSU";
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    // Tat cac chuc nang khong co quyen
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    lbName.Text = "NHANSU";
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
                case "Giáo vụ":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
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
                case "Trưởng đơn vị":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    lbName.Text = "NHANSU";
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
                case "Trưởng khoa":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    lbName.Text = "NHANSU";
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Giáo vụ":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Trưởng đơn vị":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Trưởng khoa":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Giáo vụ":
                    btnAddData.Enabled = true;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_GIAOVU_XEMTT_DONVI";
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
                case "Trưởng đơn vị":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Trưởng khoa":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Giáo vụ":
                    btnAddData.Enabled = true;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
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
                case "Trưởng đơn vị":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Trưởng khoa":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Giáo vụ":
                    btnAddData.Enabled = true;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_GIAOVU_XEMTT_KHMO";
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
                case "Trưởng đơn vị":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
                case "Trưởng khoa":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
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
            DataGridViewRow selectedRow = dtgvData.SelectedRows[0];

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
                        EditForm edit = new EditForm(lbName.Text, selectedRow);
                        edit.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Giảng viên":
                    try
                    {
                        EditForm edit = new EditForm(lbName.Text, selectedRow);
                        edit.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Giáo vụ":
                    try
                    {
                        EditForm edit = new EditForm(lbName.Text, selectedRow);
                        edit.ShowDialog();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Trưởng đơn vị":
                    try
                    {
                        EditForm edit = new EditForm(lbName.Text, selectedRow);
                        edit.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Trưởng khoa":
                    try
                    {
                        EditForm edit = new EditForm(lbName.Text, selectedRow);
                        edit.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                    break;
                case "Sinh viên":

                    break;

            }
        }



        private void pHANCONGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbName.Text = "PHANCONG";
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    // Khong co quyen
                    break;
                case "Giảng viên":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = false;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_GV_XEMTT_PHANCONG";
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
                case "Giáo vụ":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_GIAOVU_XEMTT_PHANCONG";
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
                case "Trưởng đơn vị":
                    btnAddData.Enabled = true;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = true;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_TDV_XEMTT_PHANCONG";
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
                case "Trưởng khoa":
                    btnAddData.Enabled = true;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = true;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_TK_XEMTT_PHANCONG";
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
                case "Sinh viên":

                    break;

            }
        }

        private void dANGKYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbName.Text = "DANGKY";
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    // Nhan vien co ban khong co quyen xem bang nay
                    break;
                case "Giảng viên":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_GV_XEMTT_DANGKY";
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
                case "Giáo vụ":
                    btnAddData.Enabled = true;
                    btnEditData.Enabled = false;
                    btnDeleteData.Enabled = true;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_GV_XEMTT_DANGKY";
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
                case "Trưởng đơn vị":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_GV_XEMTT_DANGKY";
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
                case "Trưởng khoa":
                    btnAddData.Enabled = false;
                    btnEditData.Enabled = true;
                    btnDeleteData.Enabled = false;
                    try
                    {
                        string query = "SELECT * FROM QLDLNB.UV_GV_XEMTT_DANGKY";
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
                case "Sinh viên":

                    break;

            }
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(lbName.Text);
            addForm.ShowDialog();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dtgvData.SelectedRows[0];

            if (dtgvData.DataSource == null)
            {
                MessageBox.Show("No data to delete");
                return;
            }
            switch (Login.roleUser)
            {
                case "Giáo vụ":
                    try
                    {
                        dtgvData.Rows.Remove(selectedRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Trưởng đơn vị":
                    try
                    {
                        dtgvData.Rows.Remove(selectedRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Trưởng khoa":
                    try
                    {
                        dtgvData.Rows.Remove(selectedRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Sinh viên":

                    break;

            }
        }
    }

}

