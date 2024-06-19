namespace WinFormsProject
{
    partial class AddRemovePrivilegeForm
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
            trackBar1 = new TrackBar();
            panel1 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            dgv = new DataGridView();
            Table = new DataGridViewTextBoxColumn();
            Column = new DataGridViewTextBoxColumn();
            Privelege = new DataGridViewTextBoxColumn();
            WithGrantOption = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(409, 163);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgv);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 400);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 50);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(218, 0);
            button2.Name = "button2";
            button2.Size = new Size(192, 50);
            button2.TabIndex = 1;
            button2.Text = "Remove privileges";
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
            button1.Text = "Add privileges";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Table, Column, Privelege, WithGrantOption });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.DefaultCellStyle = dataGridViewCellStyle1;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 0);
            dgv.Margin = new Padding(2, 1, 2, 1);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidth = 82;
            dgv.RowTemplate.Height = 41;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(800, 450);
            dgv.TabIndex = 0;
            // 
            // Table
            // 
            Table.FillWeight = 163.592117F;
            Table.HeaderText = "Table";
            Table.MinimumWidth = 10;
            Table.Name = "Table";
            // 
            // Column
            // 
            Column.FillWeight = 163.592117F;
            Column.HeaderText = "Column";
            Column.MinimumWidth = 10;
            Column.Name = "Column";
            // 
            // Privelege
            // 
            Privelege.FillWeight = 163.592117F;
            Privelege.HeaderText = "Privelege";
            Privelege.MinimumWidth = 10;
            Privelege.Name = "Privelege";
            // 
            // WithGrantOption
            // 
            WithGrantOption.FillWeight = 141.1383F;
            WithGrantOption.HeaderText = "WithGrantOption";
            WithGrantOption.MinimumWidth = 10;
            WithGrantOption.Name = "WithGrantOption";
            // 
            // AddRemovePrivilegeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(trackBar1);
            Name = "AddRemovePrivilegeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddRemovePrivilegeForm";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Panel panel1;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Table;
        private DataGridViewTextBoxColumn Column;
        private DataGridViewTextBoxColumn Privelege;
        private DataGridViewTextBoxColumn WithGrantOption;
    }
}