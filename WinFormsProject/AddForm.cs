using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsProject
{
    public partial class AddForm : Form
    {

        string tableNamePublic = "";
        string userView = "";
        string keyCondition = "";
        public AddForm(string tableName)
        {
            InitializeComponent();
            tableNamePublic = tableName;
            LoadAddForm();       
        }

        void LoadAddForm()
        {
            switch (tableNamePublic)
            {
                case "NHANSU":
                    label1.Text = "Mã nhân viên";
                    label2.Text = "Phái";
                    label3.Text = "Ngày sinh";
                    label4.Text = "Phụ cấp";
                    label5.Text = "Địa chỉ";
                    label6.Text = "Điện thoại";
                    label7.Text = "Vai trò";
                    label8.Text = "Mã đơn vị";
                    label9.Text = "Cơ sở";

                    textBox10.Visible = false;
                    label10.Visible = false;

                    break;
                case "SINHVIEN":
                    label1.Text = "Mã sinh viên";
                    label2.Text = "Họ tên";
                    label3.Text = "Phái";
                    label4.Text = "Ngày sinh";
                    label5.Text = "Địa chỉ";
                    label6.Text = "Điện thoại";
                    label7.Text = "Mã chương trình";
                    label8.Text = "Mã ngành";
                    label9.Text = "Số tín chỉ tích lũy";
                    label10.Text = "Điểm tb tích lũy";
                    break;
                case "DONVI":
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;

                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;

                    label1.Text = "Mã đơn vị";
                    label2.Text = "Tên đơn vị";
                    label3.Text = "Trưởng đơn vị";
                    break;
                case "HOCPHAN":
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;

                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;

                    label1.Text = "Mã học phần";
                    label2.Text = "Tên học phần";
                    label3.Text = "Số tín chỉ";
                    label4.Text = "Số tiết LT";
                    label5.Text = "Số tiết TH";
                    label6.Text = "Sô SVTĐ";
                    label7.Text = "Mã đơn vị";

                    break;
                case "KHMO":
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;

                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;

                    label1.Text = "Mã học phần";
                    label2.Text = "Học kì";
                    label3.Text = "Năm";
                    label4.Text = "Mã chương trình";
                    break;
                case "PHANCONG":
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;

                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;

                    label1.Text = "Mã giảng viên";
                    label2.Text = "Mã học phần";
                    label3.Text = "Học kì";
                    label4.Text = "Năm";
                    label5.Text = "Mã chương trình";
                    break;
                    //case "DANGKY":
                    //userView = "QLDLNB.UV_GIAOVU_XEMTT_PHANCONG";
                    //break;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            switch (Login.roleUser)
            {
                case "Giáo vụ":
                    switch (tableNamePublic)
                    {
                        case "SINHVIEN":
                            userView = "QLDLNB.UV_GIAOVU_XEMTT_SINHVIEN";
                            keyCondition =
                                textBox1.Text +
                                ", '" + textBox2.Text + "'" +
                                ", '" + textBox3.Text + "'" +
                                ", TO_DATE('" + textBox4.Text + "', 'YYYY-MM-DD')" +
                                ", '" + textBox5.Text + "'" +
                                ", " + textBox6.Text +
                                ", '" + textBox7.Text + "'" +
                                ", "+ textBox8.Text +
                                ", " + textBox9.Text +
                                ", " + textBox10.Text;
                            break;
                        case "DONVI":
                            userView = "QLDLNB.UV_GIAOVU_XEMTT_DONVI";
                            keyCondition =
                                textBox1.Text +
                                ", '" + textBox2.Text + "'" +
                                ", " + textBox3.Text;
                            textBox4.Visible = false;
                            textBox5.Visible = false;
                            textBox6.Visible = false;
                            textBox7.Visible = false;
                            textBox8.Visible = false;
                            textBox9.Visible = false;
                            textBox10.Visible = false;
                            break;
                        case "HOCPHAN":
                            userView = "QLDLNB.UV_GIAOVU_XEMTT_HOCPHAN";
                            keyCondition =
                                textBox1.Text +
                                ", " + textBox2.Text +
                                ", '" + textBox3.Text + "'" +
                                ", " + textBox4.Text +
                                ", " + textBox5.Text +
                                ", " + textBox6.Text +
                                ", " + textBox7.Text;
                            textBox8.Visible = false;
                            textBox9.Visible = false;
                            textBox10.Visible = false;
                            break;
                        case "KHMO":
                            userView = "QLDLNB.UV_GIAOVU_XEMTT_KHMO";
                            keyCondition =
                                textBox1.Text +
                                ", " + textBox2.Text +
                                ", " + textBox3.Text +
                                ", '" + textBox4.Text + "'";
                            textBox5.Visible = false;
                            textBox6.Visible = false;
                            textBox7.Visible = false;
                            textBox8.Visible = false;
                            textBox9.Visible = false;
                            textBox10.Visible = false;
                            break;
                        //case "DANGKY":
                            //userView = "QLDLNB.UV_GIAOVU_XEMTT_DANGKY";
                            //break;
                    }
                    break;
                case "Trưởng đơn vị":
                    userView = "QLDLNB.UV_TDV_XEMTT_PHANCONG";
                    keyCondition =
                        textBox1.Text +
                        ", " + textBox2.Text +
                        ", " + textBox3.Text +
                        ", " + textBox4.Text +
                        ",  '" + textBox5.Text + "'";              
                    textBox6.Visible = false;
                    textBox7.Visible = false;
                    textBox8.Visible = false;
                    textBox9.Visible = false;
                    textBox10.Visible = false;
                    break;;
                case "Trưởng khoa":
                    switch (tableNamePublic)
                    {
                        case "PHANCONG":
                            userView = "QLDLNB.UV_TK_XEMTT_PHANCONG";
                            keyCondition =
                                textBox1.Text +
                                ", " + textBox2.Text +
                                ", " + textBox3.Text +
                                ", " + textBox4.Text +
                                ",  '" + textBox5.Text + "'";
                            textBox6.Visible = false;
                            textBox7.Visible = false;
                            textBox8.Visible = false;
                            textBox9.Visible = false;
                            textBox10.Visible = false;
                            break;
                        case "NHANSU":
                            userView = "QLDLNB.UV_TK_XEMTT_NHANSU";
                            keyCondition =
                                textBox1.Text +
                                ", '" + textBox2.Text + "'" +
                                ", '" + textBox3.Text + "'" +
                                ", TO_DATE('" + textBox4.Text + "')" +
                                ", " + textBox5.Text + "'" +
                                ", " + textBox6.Text +
                                ", '" + textBox7.Text + "'" +
                                ", " + textBox8.Text +
                                ", '" + textBox9.Text + "'";
                            textBox10.Visible = false;
                            break;
                    }
                   
                    break;
                case "Sinh viên":
                    break;

            }
            string values = "";
            switch(tableNamePublic)
            {
                case "NHANSU":
                    values = "MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV, COSO";
                    break;
                case "SINHVIEN":
                    values = "MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL";
                    break;
                case "DONVI":
                    values = "MADV, TENDV, TRGDV";
                    break;
                case "HOCPHAN":
                    values = "MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV";
                    break;
                case "KHMO":
                    values = "MAHP, HK, NAM, MACT";
                    break;
                case "PHANCONG":
                    values = "MAGV, MAHP, HK, NAM, MACT";
                    break;
                //case "DANGKY":
                    //userView = "QLDLNB.UV_GIAOVU_XEMTT_DANGKY";
                    //break;
            }

            
            string query = "INSERT INTO " + userView + " (" + values + ") VALUES (" + keyCondition + ")";
            MessageBox.Show(query);
            OracleCommand cmd = new OracleCommand(query, Login.con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Succeeded!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
