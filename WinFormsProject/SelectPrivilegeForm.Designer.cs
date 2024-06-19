namespace WinFormsProject
{
    partial class SelectPrivilegeForm
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
            button_cancle = new Button();
            button_OK = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxTable = new ComboBox();
            comboBoxPrivilege = new ComboBox();
            label4 = new Label();
            radioButtonAll = new RadioButton();
            radioButtonCustom = new RadioButton();
            flowLayoutPanelColumns = new FlowLayoutPanel();
            checkBoxGrantOption = new CheckBox();
            SuspendLayout();
            // 
            // button_cancle
            // 
            button_cancle.Location = new Point(357, 106);
            button_cancle.Margin = new Padding(3, 2, 3, 2);
            button_cancle.Name = "button_cancle";
            button_cancle.Size = new Size(82, 22);
            button_cancle.TabIndex = 20;
            button_cancle.Text = "Cancle";
            button_cancle.UseVisualStyleBackColor = true;
            button_cancle.Click += button_cancle_Click;
            // 
            // button_OK
            // 
            button_OK.Location = new Point(357, 68);
            button_OK.Margin = new Padding(3, 2, 3, 2);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(82, 22);
            button_OK.TabIndex = 19;
            button_OK.Text = "OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 71);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 16;
            label3.Text = "Privilege";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 109);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 15;
            label2.Text = "Table";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 21);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 14;
            label1.Text = "ADD NEW PRIVILEGE";
            // 
            // comboBoxTable
            // 
            comboBoxTable.FormattingEnabled = true;
            comboBoxTable.Location = new Point(81, 106);
            comboBoxTable.Name = "comboBoxTable";
            comboBoxTable.Size = new Size(257, 23);
            comboBoxTable.TabIndex = 21;
            comboBoxTable.SelectedIndexChanged += comboBoxTable_SelectedIndexChanged;
            // 
            // comboBoxPrivilege
            // 
            comboBoxPrivilege.FormattingEnabled = true;
            comboBoxPrivilege.Location = new Point(81, 68);
            comboBoxPrivilege.Name = "comboBoxPrivilege";
            comboBoxPrivilege.Size = new Size(257, 23);
            comboBoxPrivilege.TabIndex = 22;
            comboBoxPrivilege.SelectedIndexChanged += comboBoxPrivilege_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 146);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 23;
            label4.Text = "Columns";
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Checked = true;
            radioButtonAll.Location = new Point(81, 144);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(39, 19);
            radioButtonAll.TabIndex = 24;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "All";
            radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.Location = new Point(81, 169);
            radioButtonCustom.Name = "radioButtonCustom";
            radioButtonCustom.Size = new Size(67, 19);
            radioButtonCustom.TabIndex = 25;
            radioButtonCustom.Text = "Custom";
            radioButtonCustom.UseVisualStyleBackColor = true;
            radioButtonCustom.CheckedChanged += radioButtonCustom_CheckedChanged;
            // 
            // flowLayoutPanelColumns
            // 
            flowLayoutPanelColumns.Location = new Point(81, 194);
            flowLayoutPanelColumns.Name = "flowLayoutPanelColumns";
            flowLayoutPanelColumns.Size = new Size(257, 100);
            flowLayoutPanelColumns.TabIndex = 26;
            // 
            // checkBoxGrantOption
            // 
            checkBoxGrantOption.AutoSize = true;
            checkBoxGrantOption.Checked = true;
            checkBoxGrantOption.CheckState = CheckState.Checked;
            checkBoxGrantOption.Location = new Point(81, 302);
            checkBoxGrantOption.Name = "checkBoxGrantOption";
            checkBoxGrantOption.Size = new Size(123, 19);
            checkBoxGrantOption.TabIndex = 27;
            checkBoxGrantOption.Text = "With Grant Option";
            checkBoxGrantOption.UseVisualStyleBackColor = true;
            // 
            // SelectPrivilegeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 333);
            Controls.Add(checkBoxGrantOption);
            Controls.Add(flowLayoutPanelColumns);
            Controls.Add(radioButtonCustom);
            Controls.Add(radioButtonAll);
            Controls.Add(label4);
            Controls.Add(comboBoxPrivilege);
            Controls.Add(comboBoxTable);
            Controls.Add(button_cancle);
            Controls.Add(button_OK);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SelectPrivilegeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectPrivilegeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancle;
        private Button button_OK;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxTable;
        private ComboBox comboBoxPrivilege;
        private Label label4;
        private RadioButton radioButtonAll;
        private RadioButton radioButtonCustom;
        private FlowLayoutPanel flowLayoutPanelColumns;
        private CheckBox checkBoxGrantOption;
    }
}