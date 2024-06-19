namespace WinFormsProject
{
    partial class AddUserForm
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
            txt_password = new TextBox();
            txt_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_login
            // 
            button_login.Location = new Point(135, 159);
            button_login.Margin = new Padding(3, 2, 3, 2);
            button_login.Name = "button_login";
            button_login.Size = new Size(82, 22);
            button_login.TabIndex = 12;
            button_login.Text = "OK";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(112, 122);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(265, 23);
            txt_password.TabIndex = 11;
            txt_password.Text = "a123";
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(112, 78);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(265, 23);
            txt_username.TabIndex = 10;
            txt_username.Text = "TEST";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 124);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 23);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 7;
            label1.Text = "ADD NEW USER";
            // 
            // button1
            // 
            button1.Location = new Point(247, 159);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 13;
            button1.Text = "Cancle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 217);
            Controls.Add(button1);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_login;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}