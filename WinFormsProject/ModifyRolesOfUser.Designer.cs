namespace WinFormsProject
{
    partial class ModifyRolesOfUser
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
            flowLayoutPanelColumns = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            button_OK = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanelColumns
            // 
            flowLayoutPanelColumns.AutoScroll = true;
            flowLayoutPanelColumns.Location = new Point(12, 75);
            flowLayoutPanelColumns.Name = "flowLayoutPanelColumns";
            flowLayoutPanelColumns.Size = new Size(231, 262);
            flowLayoutPanelColumns.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 27;
            label1.Text = "MODIFY ROLES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 30;
            label2.Text = "User";
            // 
            // button_OK
            // 
            button_OK.Location = new Point(86, 349);
            button_OK.Margin = new Padding(3, 2, 3, 2);
            button_OK.Name = "button_OK";
            button_OK.Size = new Size(82, 22);
            button_OK.TabIndex = 31;
            button_OK.Text = "OK";
            button_OK.UseVisualStyleBackColor = true;
            button_OK.Click += button_OK_Click;
            // 
            // ModifyRolesOfUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 382);
            Controls.Add(button_OK);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanelColumns);
            Controls.Add(label1);
            Name = "ModifyRolesOfUser";
            Text = "ModifyRolesOfUser";
            Load += ModifyRolesOfUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelColumns;
        private Label label1;
        private Label label2;
        private Button button_OK;
    }
}