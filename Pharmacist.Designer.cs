namespace PharmacyManagementSystem
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.SideMenu = new System.Windows.Forms.Panel();
            this.MainDashboardPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnValidityCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.SideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.SideMenu.Controls.Add(this.btnLogout);
            this.SideMenu.Controls.Add(this.btnSellMedicine);
            this.SideMenu.Controls.Add(this.btnValidityCheck);
            this.SideMenu.Controls.Add(this.btnModifyMedicine);
            this.SideMenu.Controls.Add(this.btnViewMedicine);
            this.SideMenu.Controls.Add(this.btnAddMedicine);
            this.SideMenu.Controls.Add(this.btnDashboard);
            this.SideMenu.Controls.Add(this.label1);
            this.SideMenu.Controls.Add(this.pictureBox1);
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(290, 768);
            this.SideMenu.TabIndex = 1;
            // 
            // MainDashboardPanel
            // 
            this.MainDashboardPanel.BackColor = System.Drawing.Color.White;
            this.MainDashboardPanel.Location = new System.Drawing.Point(290, 0);
            this.MainDashboardPanel.Name = "MainDashboardPanel";
            this.MainDashboardPanel.Size = new System.Drawing.Size(1076, 768);
            this.MainDashboardPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmacist";
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.Location = new System.Drawing.Point(25, 272);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(265, 44);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddMedicine.Location = new System.Drawing.Point(25, 332);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(265, 44);
            this.btnAddMedicine.TabIndex = 3;
            this.btnAddMedicine.Text = "Add Medicine";
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnViewMedicine.Location = new System.Drawing.Point(25, 392);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(265, 44);
            this.btnViewMedicine.TabIndex = 4;
            this.btnViewMedicine.Text = "View Medicine";
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifyMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifyMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnModifyMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnModifyMedicine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedicine.Image")));
            this.btnModifyMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModifyMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnModifyMedicine.Location = new System.Drawing.Point(25, 452);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Size = new System.Drawing.Size(265, 44);
            this.btnModifyMedicine.TabIndex = 5;
            this.btnModifyMedicine.Text = "Modify Medicine";
            // 
            // btnValidityCheck
            // 
            this.btnValidityCheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnValidityCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValidityCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValidityCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValidityCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValidityCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnValidityCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidityCheck.ForeColor = System.Drawing.Color.White;
            this.btnValidityCheck.HoverState.FillColor = System.Drawing.Color.White;
            this.btnValidityCheck.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnValidityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnValidityCheck.Image")));
            this.btnValidityCheck.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnValidityCheck.ImageSize = new System.Drawing.Size(25, 25);
            this.btnValidityCheck.Location = new System.Drawing.Point(25, 512);
            this.btnValidityCheck.Name = "btnValidityCheck";
            this.btnValidityCheck.Size = new System.Drawing.Size(265, 44);
            this.btnValidityCheck.TabIndex = 6;
            this.btnValidityCheck.Text = "Medicine Validity Check";
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSellMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSellMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSellMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSellMedicine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSellMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSellMedicine.Location = new System.Drawing.Point(25, 572);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(265, 44);
            this.btnSellMedicine.TabIndex = 7;
            this.btnSellMedicine.Text = "Sell Medicine";
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Location = new System.Drawing.Point(25, 632);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(265, 44);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.MainDashboardPanel);
            this.Controls.Add(this.SideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Panel MainDashboardPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private Guna.UI2.WinForms.Guna2Button btnValidityCheck;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
    }
}