using System;
using System.Windows.Forms;

namespace SedapMakanManagementSystem
{
    partial class ManagerDashboard
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
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.updateProfileBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.chefDash1 = new System.Windows.Forms.Label();
            this.refundsBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.topupBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditProfile.Location = new System.Drawing.Point(842, 328);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(103, 57);
            this.btnEditProfile.TabIndex = 21;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.updateProfileBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.chefDash1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Expo M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(772, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateProfileBtn
            // 
            this.updateProfileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.updateProfileBtn.FlatAppearance.BorderSize = 0;
            this.updateProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProfileBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updateProfileBtn.ForeColor = System.Drawing.Color.White;
            this.updateProfileBtn.Location = new System.Drawing.Point(342, 8);
            this.updateProfileBtn.Name = "updateProfileBtn";
            this.updateProfileBtn.Size = new System.Drawing.Size(69, 25);
            this.updateProfileBtn.TabIndex = 24;
            this.updateProfileBtn.Text = "Profile";
            this.updateProfileBtn.UseVisualStyleBackColor = false;
            this.updateProfileBtn.Click += new System.EventHandler(this.updateProfileBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(417, 7);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(69, 25);
            this.logoutBtn.TabIndex = 25;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // chefDash1
            // 
            this.chefDash1.AutoSize = true;
            this.chefDash1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chefDash1.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chefDash1.ForeColor = System.Drawing.Color.White;
            this.chefDash1.Location = new System.Drawing.Point(0, 0);
            this.chefDash1.Name = "chefDash1";
            this.chefDash1.Size = new System.Drawing.Size(336, 32);
            this.chefDash1.TabIndex = 26;
            this.chefDash1.Text = "Manager Dashboard";
            this.chefDash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // refundsBtn
            // 
            this.refundsBtn.BackColor = System.Drawing.Color.Gray;
            this.refundsBtn.FlatAppearance.BorderSize = 0;
            this.refundsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundsBtn.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refundsBtn.ForeColor = System.Drawing.Color.White;
            this.refundsBtn.Location = new System.Drawing.Point(36, 210);
            this.refundsBtn.Name = "refundsBtn";
            this.refundsBtn.Size = new System.Drawing.Size(640, 60);
            this.refundsBtn.TabIndex = 23;
            this.refundsBtn.Text = "View Refunds";
            this.refundsBtn.UseVisualStyleBackColor = false;
            this.refundsBtn.Click += new System.EventHandler(this.refundsBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.Gray;
            this.feedbackBtn.FlatAppearance.BorderSize = 0;
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackBtn.Font = new System.Drawing.Font("Expo M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.White;
            this.feedbackBtn.Location = new System.Drawing.Point(36, 30);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(640, 60);
            this.feedbackBtn.TabIndex = 22;
            this.feedbackBtn.Text = "View Feedbacks";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.topupBtn);
            this.panel2.Controls.Add(this.feedbackBtn);
            this.panel2.Controls.Add(this.refundsBtn);
            this.panel2.Location = new System.Drawing.Point(40, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 295);
            this.panel2.TabIndex = 28;
            // 
            // topupBtn
            // 
            this.topupBtn.BackColor = System.Drawing.Color.Gray;
            this.topupBtn.FlatAppearance.BorderSize = 0;
            this.topupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topupBtn.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.topupBtn.ForeColor = System.Drawing.Color.White;
            this.topupBtn.Location = new System.Drawing.Point(36, 120);
            this.topupBtn.Name = "topupBtn";
            this.topupBtn.Size = new System.Drawing.Size(640, 60);
            this.topupBtn.TabIndex = 24;
            this.topupBtn.Text = "Top Up for Customers";
            this.topupBtn.UseVisualStyleBackColor = false;
            this.topupBtn.Click += new System.EventHandler(this.topupBtn_Click);
            // 
            // ManagerDashboard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.Button btnEditProfile;
        private Panel panel1;
        private Button button1;
        private Label chefDash1;
        private Button logoutBtn;
        private Button updateProfileBtn;
        private Button refundsBtn;
        private Button feedbackBtn;
        private Panel panel2;
        private Button topupBtn;
    }
}

