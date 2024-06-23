namespace WinFormsProject
{
    partial class UserMenuForm
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
            menuStrip1 = new MenuStrip();
            nHANSUToolStripMenuItem = new ToolStripMenuItem();
            sINHVIENToolStripMenuItem = new ToolStripMenuItem();
            dONVIToolStripMenuItem = new ToolStripMenuItem();
            hOCPHANToolStripMenuItem = new ToolStripMenuItem();
            kHMOToolStripMenuItem = new ToolStripMenuItem();
            pHANCONGToolStripMenuItem = new ToolStripMenuItem();
            dANGKYToolStripMenuItem = new ToolStripMenuItem();
            dtgvData = new DataGridView();
            lbName = new Label();
            btnAddData = new Button();
            btnEditData = new Button();
            btnDeleteData = new Button();
            btnLogout = new Button();
            btnCloseApp = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvData).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nHANSUToolStripMenuItem, sINHVIENToolStripMenuItem, dONVIToolStripMenuItem, hOCPHANToolStripMenuItem, kHMOToolStripMenuItem, pHANCONGToolStripMenuItem, dANGKYToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // nHANSUToolStripMenuItem
            // 
            nHANSUToolStripMenuItem.Name = "nHANSUToolStripMenuItem";
            nHANSUToolStripMenuItem.Size = new Size(84, 24);
            nHANSUToolStripMenuItem.Text = "NHANSU";
            nHANSUToolStripMenuItem.Click += nHANSUToolStripMenuItem_Click;
            // 
            // sINHVIENToolStripMenuItem
            // 
            sINHVIENToolStripMenuItem.Name = "sINHVIENToolStripMenuItem";
            sINHVIENToolStripMenuItem.Size = new Size(89, 24);
            sINHVIENToolStripMenuItem.Text = "SINHVIEN";
            sINHVIENToolStripMenuItem.Click += sINHVIENToolStripMenuItem_Click;
            // 
            // dONVIToolStripMenuItem
            // 
            dONVIToolStripMenuItem.Name = "dONVIToolStripMenuItem";
            dONVIToolStripMenuItem.Size = new Size(69, 24);
            dONVIToolStripMenuItem.Text = "DONVI";
            dONVIToolStripMenuItem.Click += dONVIToolStripMenuItem_Click;
            // 
            // hOCPHANToolStripMenuItem
            // 
            hOCPHANToolStripMenuItem.Name = "hOCPHANToolStripMenuItem";
            hOCPHANToolStripMenuItem.Size = new Size(94, 24);
            hOCPHANToolStripMenuItem.Text = "HOCPHAN";
            hOCPHANToolStripMenuItem.Click += hOCPHANToolStripMenuItem_Click;
            // 
            // kHMOToolStripMenuItem
            // 
            kHMOToolStripMenuItem.Name = "kHMOToolStripMenuItem";
            kHMOToolStripMenuItem.Size = new Size(67, 24);
            kHMOToolStripMenuItem.Text = "KHMO";
            kHMOToolStripMenuItem.Click += kHMOToolStripMenuItem_Click;
            // 
            // pHANCONGToolStripMenuItem
            // 
            pHANCONGToolStripMenuItem.Name = "pHANCONGToolStripMenuItem";
            pHANCONGToolStripMenuItem.Size = new Size(104, 24);
            pHANCONGToolStripMenuItem.Text = "PHANCONG";
            pHANCONGToolStripMenuItem.Click += pHANCONGToolStripMenuItem_Click;
            // 
            // dANGKYToolStripMenuItem
            // 
            dANGKYToolStripMenuItem.Name = "dANGKYToolStripMenuItem";
            dANGKYToolStripMenuItem.Size = new Size(82, 24);
            dANGKYToolStripMenuItem.Text = "DANGKY";
            dANGKYToolStripMenuItem.Click += dANGKYToolStripMenuItem_Click;
            // 
            // dtgvData
            // 
            dtgvData.Anchor = AnchorStyles.None;
            dtgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvData.Location = new Point(12, 82);
            dtgvData.Name = "dtgvData";
            dtgvData.RowHeadersWidth = 51;
            dtgvData.RowTemplate.Height = 29;
            dtgvData.Size = new Size(649, 364);
            dtgvData.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(12, 39);
            lbName.Name = "lbName";
            lbName.Size = new Size(154, 31);
            lbName.TabIndex = 2;
            lbName.Text = "TABLE NAME";
            // 
            // btnAddData
            // 
            btnAddData.Anchor = AnchorStyles.None;
            btnAddData.Location = new Point(678, 82);
            btnAddData.Name = "btnAddData";
            btnAddData.Size = new Size(110, 29);
            btnAddData.TabIndex = 4;
            btnAddData.Text = "Add data";
            btnAddData.UseVisualStyleBackColor = true;
            btnAddData.Click += btnAddData_Click;
            // 
            // btnEditData
            // 
            btnEditData.Anchor = AnchorStyles.None;
            btnEditData.Location = new Point(678, 117);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(110, 29);
            btnEditData.TabIndex = 5;
            btnEditData.Text = "Edit data";
            btnEditData.UseVisualStyleBackColor = true;
            btnEditData.Click += btnEditData_Click;
            // 
            // btnDeleteData
            // 
            btnDeleteData.Anchor = AnchorStyles.None;
            btnDeleteData.Location = new Point(678, 152);
            btnDeleteData.Name = "btnDeleteData";
            btnDeleteData.Size = new Size(110, 29);
            btnDeleteData.TabIndex = 6;
            btnDeleteData.Text = "Delete Data";
            btnDeleteData.UseVisualStyleBackColor = true;
            btnDeleteData.Click += btnDeleteData_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.Location = new Point(678, 374);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCloseApp
            // 
            btnCloseApp.Anchor = AnchorStyles.None;
            btnCloseApp.Location = new Point(678, 409);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(110, 29);
            btnCloseApp.TabIndex = 8;
            btnCloseApp.Text = "Close app";
            btnCloseApp.UseVisualStyleBackColor = true;
            btnCloseApp.Click += btnCloseApp_Click;
            // 
            // UserMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCloseApp);
            Controls.Add(btnLogout);
            Controls.Add(btnDeleteData);
            Controls.Add(btnEditData);
            Controls.Add(btnAddData);
            Controls.Add(lbName);
            Controls.Add(dtgvData);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UserMenuForm";
            Text = "LesserMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nHANSUToolStripMenuItem;
        private ToolStripMenuItem sINHVIENToolStripMenuItem;
        private ToolStripMenuItem dONVIToolStripMenuItem;
        private ToolStripMenuItem hOCPHANToolStripMenuItem;
        private ToolStripMenuItem kHMOToolStripMenuItem;
        private ToolStripMenuItem pHANCONGToolStripMenuItem;
        private ToolStripMenuItem dANGKYToolStripMenuItem;
        private DataGridView dtgvData;
        private Label lbName;
        private Button btnAddData;
        private Button btnEditData;
        private Button btnDeleteData;
        private Button btnLogout;
        private Button btnCloseApp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}