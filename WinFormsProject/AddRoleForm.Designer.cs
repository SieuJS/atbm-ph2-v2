namespace WinFormsProject
{
    partial class AddRoleForm
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
            button_login = new Button();
            txt_rolename = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_login
            // 
            button_login.Location = new Point(91, 105);
            button_login.Margin = new Padding(3, 2, 3, 2);
            button_login.Name = "button_login";
            button_login.Size = new Size(82, 22);
            button_login.TabIndex = 19;
            button_login.Text = "OK";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // txt_username
            // 
            txt_rolename.Location = new Point(91, 63);
            txt_rolename.Margin = new Padding(3, 2, 3, 2);
            txt_rolename.Name = "txt_username";
            txt_rolename.Size = new Size(265, 23);
            txt_rolename.TabIndex = 17;
            txt_rolename.Text = "TEST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 15;
            label2.Text = "RoleName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 14;
            label1.Text = "ADD NEW ROLE";
            // 
            // button1
            // 
            button1.Location = new Point(186, 105);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 20;
            button1.Text = "Cancle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddRoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 144);
            Controls.Add(button1);
            Controls.Add(button_login);
            Controls.Add(txt_rolename);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddRoleForm";
            Text = "AddRoleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_login;
        private TextBox txt_rolename;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}