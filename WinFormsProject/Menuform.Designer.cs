using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WinFormsProject
{
    partial class Menuform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvUsers = new DataGridView();
            Users = new DataGridViewTextBoxColumn();
            Roles = new DataGridViewTextBoxColumn();
            Priveleges = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            dgvRoles = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel5 = new Panel();
            button8 = new Button();
            button9 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { Users, Roles, Priveleges });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Margin = new Padding(2, 1, 2, 1);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 82;
            dgvUsers.RowTemplate.Height = 41;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(952, 382);
            dgvUsers.TabIndex = 0;
            // 
            // Users
            // 
            Users.FillWeight = 212.7972F;
            Users.HeaderText = "Users";
            Users.MinimumWidth = 10;
            Users.Name = "Users";
            // 
            // Roles
            // 
            Roles.FillWeight = 212.7972F;
            Roles.HeaderText = "Roles";
            Roles.MinimumWidth = 10;
            Roles.Name = "Roles";
            // 
            // Priveleges
            // 
            Priveleges.FillWeight = 212.7972F;
            Priveleges.HeaderText = "Priveleges";
            Priveleges.MinimumWidth = 10;
            Priveleges.Name = "Priveleges";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgvUsers);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 382);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 332);
            panel3.Name = "panel3";
            panel3.Size = new Size(952, 50);
            panel3.TabIndex = 1;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Left;
            button6.Location = new Point(606, 0);
            button6.Name = "button6";
            button6.Size = new Size(85, 50);
            button6.TabIndex = 4;
            button6.Text = "Modify User";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Location = new Point(521, 0);
            button5.Name = "button5";
            button5.Size = new Size(85, 50);
            button5.TabIndex = 3;
            button5.Text = "Delete User";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(410, 0);
            button4.Name = "button4";
            button4.Size = new Size(111, 50);
            button4.TabIndex = 2;
            button4.Text = "Add New User";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(218, 0);
            button2.Name = "button2";
            button2.Size = new Size(192, 50);
            button2.TabIndex = 1;
            button2.Text = "Add/Remove roles to Users";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(218, 50);
            button1.TabIndex = 0;
            button1.Text = "Add/Remove privileges to Users";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvRoles);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 382);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 281);
            panel2.TabIndex = 2;
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRoles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRoles.Dock = DockStyle.Fill;
            dgvRoles.Location = new Point(0, 0);
            dgvRoles.Margin = new Padding(2, 1, 2, 1);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowHeadersWidth = 82;
            dgvRoles.RowTemplate.Height = 41;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new Size(952, 231);
            dgvRoles.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 212.7972F;
            dataGridViewTextBoxColumn2.HeaderText = "Roles";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 212.7972F;
            dataGridViewTextBoxColumn3.HeaderText = "Priveleges";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button3);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(952, 50);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button9);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(218, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(734, 50);
            panel5.TabIndex = 2;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Left;
            button8.Location = new Point(111, 0);
            button8.Name = "button8";
            button8.Size = new Size(85, 50);
            button8.TabIndex = 3;
            button8.Text = "Delete Role";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Left;
            button9.Location = new Point(0, 0);
            button9.Name = "button9";
            button9.Size = new Size(111, 50);
            button9.TabIndex = 2;
            button9.Text = "Add New Role";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(218, 50);
            button3.TabIndex = 1;
            button3.Text = "Add/Remove privileges to Roles";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Menuform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 663);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menuform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menuform";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private Panel panel1;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel4;
        private Button button3;
        private DataGridViewTextBoxColumn Users;
        private DataGridViewTextBoxColumn Roles;
        private DataGridViewTextBoxColumn Priveleges;
        private DataGridView dgvRoles;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Panel panel5;
        private Button button8;
        private Button button9;
    }
}