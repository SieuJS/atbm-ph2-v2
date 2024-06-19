namespace WinFormsProject
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            button_clear = new Button();
            button_close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 71);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 147);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 205);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(269, 144);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(302, 27);
            txt_username.TabIndex = 3;
            txt_username.Text = "DBAUSER";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(269, 203);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(302, 27);
            txt_password.TabIndex = 4;
            txt_password.Text = "aaa123";
            txt_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Location = new Point(434, 252);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(309, 252);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_close
            // 
            button_close.Location = new Point(685, 401);
            button_close.Name = "button_close";
            button_close.Size = new Size(94, 29);
            button_close.TabIndex = 7;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button_close);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button button_login;
        private Button button_clear;
        private Button button_close;
    }
}
