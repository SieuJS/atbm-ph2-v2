using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsProject
{
    public partial class EditForm : Form
    {
        string tableNamePublic = "";
        DataGridViewRow selectedRowPublic;
        public EditForm(string tableName, DataGridViewRow row)
        {
            tableNamePublic = tableName;
            selectedRowPublic = row;
            InitializeComponent();
            LoadComboBox();
        }

        

        void LoadComboBox()
        {
            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    if (tableNamePublic == "NHANSU")
                        comboBox1.Items.Add("DT");
                    break;
                case "Giảng viên":
                    if (tableNamePublic == "NHANSU")
                        comboBox1.Items.Add("DT");
                    if (tableNamePublic == "DANGKY")
                    {
                        comboBox1.Items.Add("DIEMTH");
                        comboBox1.Items.Add("DIEMQT");
                        comboBox1.Items.Add("DIEMCK");
                        comboBox1.Items.Add("DIEMTK");
                    }                 
                    break;
                case "Giáo vụ":
                    
                    if (tableNamePublic == "NHANSU")
                        comboBox1.Items.Add("DT");
                    if (tableNamePublic == "SINHVIEN")
                    {
                        comboBox1.Items.Add("MASV");
                        comboBox1.Items.Add("HOTEN");
                        comboBox1.Items.Add("PHAI");
                        comboBox1.Items.Add("DIEMTK");
                        comboBox1.Items.Add("NGSINH");
                        comboBox1.Items.Add("DCHI");
                        comboBox1.Items.Add("DT");
                        comboBox1.Items.Add("MACT");
                        comboBox1.Items.Add("MANGANH");
                        comboBox1.Items.Add("SOTCTL");
                        comboBox1.Items.Add("DTBTL");
                    }
                    if (tableNamePublic == "DONVI")
                    {
                        comboBox1.Items.Add("MADV");
                        comboBox1.Items.Add("TENDV");
                        comboBox1.Items.Add("TRGDV");
                    }
                    if (tableNamePublic == "HOCPHAN")
                    {
                        comboBox1.Items.Add("MAHP");
                        comboBox1.Items.Add("TENHP");
                        comboBox1.Items.Add("SOTC");
                        comboBox1.Items.Add("STLT");
                        comboBox1.Items.Add("STTH");
                        comboBox1.Items.Add("SOSVTD");
                        comboBox1.Items.Add("MADV");
                    }
                    if (tableNamePublic == "KHMO")
                    {
                        comboBox1.Items.Add("MAHP");
                        comboBox1.Items.Add("HK");
                        comboBox1.Items.Add("NAM");
                        comboBox1.Items.Add("MACT");

                    }
                    if (tableNamePublic == "PHANCONG")
                    {
                        comboBox1.Items.Add("MAHP");
                        comboBox1.Items.Add("HK");
                        comboBox1.Items.Add("NAM");
                        comboBox1.Items.Add("MACT");
                        comboBox1.Items.Add("MAGV");

                    }
                    if (tableNamePublic == "DANGKY")
                    {
                        comboBox1.Items.Add("MAHP");
                        comboBox1.Items.Add("HK");
                        comboBox1.Items.Add("NAM");
                        comboBox1.Items.Add("MACT");

                    }
                    break;
                case "Trưởng đơn vị":
                    if (tableNamePublic == "NHANSU")
                        comboBox1.Items.Add("DT");
                    if (tableNamePublic == "PHANCONG")
                    {
                        comboBox1.Items.Add("MAHP");
                        comboBox1.Items.Add("HK");
                        comboBox1.Items.Add("NAM");
                        comboBox1.Items.Add("MACT");
                        comboBox1.Items.Add("MAGV");
                    }    
                    if (tableNamePublic == "DANGKY")
                    {
                        comboBox1.Items.Add("MAHP");
                        comboBox1.Items.Add("HK");
                        comboBox1.Items.Add("NAM");
                        comboBox1.Items.Add("MACT");
                    }
                    break;
                case "Trưởng khoa":
                    if (tableNamePublic == "NHANSU")
                    {
                        comboBox1.Items.Add("MANV");
                        comboBox1.Items.Add("HOTEN");
                        comboBox1.Items.Add("PHAI");
                        comboBox1.Items.Add("NGSINH");
                        comboBox1.Items.Add("PHUCAP");
                        comboBox1.Items.Add("DT");
                        comboBox1.Items.Add("VAITRO");
                        comboBox1.Items.Add("MADV");
                        comboBox1.Items.Add("COSO");
                    }
                        
                    if (tableNamePublic == "PHANCONG")
                    {
                        comboBox1.Items.Add("MAHP");
                        comboBox1.Items.Add("HK");
                        comboBox1.Items.Add("NAM");
                        comboBox1.Items.Add("MACT");
                        comboBox1.Items.Add("MAGV");
                    }
                    break;
                case "Sinh viên":

                    break;

            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string userView = "";
            if (tableNamePublic == "NHANSU")
                userView = "QLDLNB.UV_NVCB_XEMTTCN";
            if (tableNamePublic == "SINHVIEN" && Login.roleUser == "Giáo vụ")
                userView = "QLDLNB.UV_GIAOVU_XEMTT_SINHVIEN";
            if (tableNamePublic == "DONVI" && Login.roleUser == "Giáo vụ")
                userView = "QLDLNB.UV_GIAOVU_XEMTT_DONVI";
            if (tableNamePublic == "HOCPHAN" && Login.roleUser == "Giáo vụ")
                userView = "QLDLNB.UV_GIAOVU_XEMTT_HOCPHAN";
            if (tableNamePublic == "KHMO" && Login.roleUser == "Giáo vụ")
                userView = "QLDLNB.UV_GIAOVU_XEMTT_KHMO";
            if (tableNamePublic == "PHANCONG" && Login.roleUser == "Giáo vụ")
                userView = "QLDLNB.UV_GIAOVU_XEMTT_PHANCONG";
            if (tableNamePublic == "DANGKY" && Login.roleUser == "Giảng viên")
                userView = "QLDLNB.UV_GV_XEMTT_DANGKY";
            if (tableNamePublic == "DANGKY" && Login.roleUser == "Trưởng đơn vị")
                userView = "QLDLNB.UV_GV_XEMTT_DANGKY";
            if (tableNamePublic == "PHANCONG" && Login.roleUser == "Trưởng đơn vị")
                userView = "QLDLNB.UV_TDV_XEMTT_PHANCONG";
            if (tableNamePublic == "PHANCONG" && Login.roleUser == "Trưởng khoa")
                userView = "QLDLNB.UV_TK_XEMTT_PHANCONG";
            if (tableNamePublic == "NHANSU" && Login.roleUser == "Trưởng khoa")
                userView = "QLDLNB.UV_TK_XEMTT_NHANSU";


            switch (Login.roleUser)
            {
                case "Nhân viên cơ bản":
                    
                    try
                    { 
                        if (txt_editData.Text == "" || comboBox1.Text == "") {
                            MessageBox.Show("Can't leave field(s) empty!");
                            return;
                        }
                        string query = "UPDATE " + userView + " SET " + comboBox1.Text + " = " + "'" + txt_editData.Text + "'";
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Giảng viên":
                    try
                    {
                        if (txt_editData.Text == "" || comboBox1.Text == "")
                        {
                            MessageBox.Show("Can't leave field(s) empty!");
                            return;
                        }
                        string query = "UPDATE " + userView + " SET " + comboBox1.Text + " = " + "'" + txt_editData.Text + "'";
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Giáo vụ":
                    try
                    {
                        if (txt_editData.Text == "" || comboBox1.Text == "")
                        {
                            MessageBox.Show("Can't leave field(s) empty!");
                            return;
                        }
                        List<object> rowData = new List<object>();
                        foreach (DataGridViewCell cell in selectedRowPublic.Cells)
                        {
                            rowData.Add(cell.Value);
                        }
                        string keyCompare = "";
                        switch(tableNamePublic)
                        {
                            case "NHANSU":
                                keyCompare = "MANV = " + rowData[0];
                                break;
                            case "SINHVIEN":
                                keyCompare = "MASV = " + rowData[0];
                                break;
                            case "DONVI":
                                keyCompare = "MADV = " + rowData[0];
                                break;
                            case "HOCPHAN":
                                keyCompare = "MAHP = " + rowData[0];
                                break;
                            case "KHMO":
                                keyCompare = "MAHP = " + rowData[0] + "AND HK = " + rowData[1] 
                                    + "AND NAM = " + rowData[2] + "AND MACT = '" + rowData[3] + "'";
                                break;
                            case "PHANCONG":
                                keyCompare = "MAHP = " + rowData[0] + "AND HK = " + rowData[1]
                                    + "AND NAM = " + rowData[2] + "AND MACT = '" 
                                    + rowData[3] + "' AND MAGV = " + rowData[4];
                                break;
                            //case "DANGKY":
                                //keyCompare = "MAHP = " + rowData[0] + "HK = " + rowData[1]
                                    //+ "NAM = " + rowData[2] + "MACT = " + rowData[3];
                                //break;
                        }
                        string query = "UPDATE " + userView + " SET " + comboBox1.Text + " = " + "'" + txt_editData.Text + "' WHERE " + keyCompare;
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Trưởng đơn vị":
                    try
                    {
                        if (txt_editData.Text == "" || comboBox1.Text == "")
                        {
                            MessageBox.Show("Can't leave field(s) empty!");
                            return;
                        }
                        List<object> rowData = new List<object>();
                        foreach (DataGridViewCell cell in selectedRowPublic.Cells)
                        {
                            rowData.Add(cell.Value);
                        }
                        string keyCompare = "";
                        switch (tableNamePublic)
                        {
                            case "PHANCONG":
                                keyCompare = "MAGV = " + rowData[0] + " AND MAHP = " + rowData[1]
                                    + " AND HK = " + rowData[2] + " AND NAM = "
                                    + rowData[3] + " AND MACT = '" + rowData[4] + "'";
                                break;
                        }
                        string query = "UPDATE " + userView + " SET " + comboBox1.Text + " = " + "'" + txt_editData.Text + "' WHERE " + keyCompare;
                        MessageBox.Show(query);
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        cmd.ExecuteNonQuery();
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Trưởng khoa":
                    try
                    {
                        if (txt_editData.Text == "" || comboBox1.Text == "")
                        {
                            MessageBox.Show("Can't leave field(s) empty!");
                            return;
                        }
                        List<object> rowData = new List<object>();
                        foreach (DataGridViewCell cell in selectedRowPublic.Cells)
                        {
                            rowData.Add(cell.Value);
                        }
                        string keyCompare = "";
                        switch (tableNamePublic)
                        {
                            case "PHANCONG":
                                keyCompare = "MAGV = " + rowData[0] + " AND MAHP = " + rowData[1]
                                    + " AND HK = " + rowData[2] + " AND NAM = "
                                    + rowData[3] + " AND MACT = '" + rowData[4] + "'";
                                break;
                            case "NHANSU":
                                keyCompare = "MANV = " + rowData[0];
                                break;
                        }
                        string query = "";
                        if (comboBox1.Text == "NGSINH")
                        {
                            query = "UPDATE " + userView + " SET " + comboBox1.Text + " = " + "TO_DATE('" + txt_editData.Text + "', 'DD-MM-YYYY') WHERE " + keyCompare;
                        }
                        else
                        {
                            query = "UPDATE " + userView + " SET " + comboBox1.Text + " = " + "'" + txt_editData.Text + "' WHERE " + keyCompare;
                        }
                        MessageBox.Show(query);
                        OracleCommand cmd = new OracleCommand(query, Login.con);
                        cmd.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Sinh viên":

                    break;

            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
