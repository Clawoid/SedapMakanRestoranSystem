namespace OOP_Assignment_Customer_
{
    partial class customer
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
            this.menuBtn = new System.Windows.Forms.Button();
            this.orderstatBtn = new System.Windows.Forms.Button();
            this.feedbackBtn = new System.Windows.Forms.Button();
            this.labelEwalletBalance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.updateProfileBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Gray;
            this.menuBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuBtn.ForeColor = System.Drawing.Color.White;
            this.menuBtn.Location = new System.Drawing.Point(36, 30);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(640, 49);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "View Menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // orderstatBtn
            // 
            this.orderstatBtn.BackColor = System.Drawing.Color.Gray;
            this.orderstatBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.orderstatBtn.FlatAppearance.BorderSize = 0;
            this.orderstatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderstatBtn.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderstatBtn.ForeColor = System.Drawing.Color.White;
            this.orderstatBtn.Location = new System.Drawing.Point(36, 110);
            this.orderstatBtn.Name = "orderstatBtn";
            this.orderstatBtn.Size = new System.Drawing.Size(640, 49);
            this.orderstatBtn.TabIndex = 1;
            this.orderstatBtn.Text = "Check Order Status";
            this.orderstatBtn.UseVisualStyleBackColor = false;
            this.orderstatBtn.Click += new System.EventHandler(this.orderstatBtn_Click);
            // 
            // feedbackBtn
            // 
            this.feedbackBtn.BackColor = System.Drawing.Color.Gray;
            this.feedbackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.feedbackBtn.FlatAppearance.BorderSize = 0;
            this.feedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackBtn.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.feedbackBtn.ForeColor = System.Drawing.Color.White;
            this.feedbackBtn.Location = new System.Drawing.Point(36, 190);
            this.feedbackBtn.Name = "feedbackBtn";
            this.feedbackBtn.Size = new System.Drawing.Size(640, 49);
            this.feedbackBtn.TabIndex = 3;
            this.feedbackBtn.Text = "Send Feedbacks";
            this.feedbackBtn.UseVisualStyleBackColor = false;
            this.feedbackBtn.Click += new System.EventHandler(this.feedbackBtn_Click);
            // 
            // labelEwalletBalance
            // 
            this.labelEwalletBalance.AutoSize = true;
            this.labelEwalletBalance.Font = new System.Drawing.Font("Expo M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEwalletBalance.ForeColor = System.Drawing.Color.White;
            this.labelEwalletBalance.Location = new System.Drawing.Point(32, 265);
            this.labelEwalletBalance.Name = "labelEwalletBalance";
            this.labelEwalletBalance.Size = new System.Drawing.Size(188, 21);
            this.labelEwalletBalance.TabIndex = 8;
            this.labelEwalletBalance.Text = "E-wallet Balance:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Controls.Add(this.labelEwalletBalance);
            this.panel1.Controls.Add(this.orderstatBtn);
            this.panel1.Controls.Add(this.feedbackBtn);
            this.panel1.Location = new System.Drawing.Point(40, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 295);
            this.panel1.TabIndex = 9;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Black;
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Controls.Add(this.updateProfileBtn);
            this.panelheader.Controls.Add(this.logoutBtn);
            this.panelheader.Controls.Add(this.button6);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Margin = new System.Windows.Forms.Padding(1);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(800, 35);
            this.panelheader.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Expo M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hey, !";
            // 
            // updateProfileBtn
            // 
            this.updateProfileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.updateProfileBtn.FlatAppearance.BorderSize = 0;
            this.updateProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateProfileBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updateProfileBtn.ForeColor = System.Drawing.Color.White;
            this.updateProfileBtn.Location = new System.Drawing.Point(159, 5);
            this.updateProfileBtn.Name = "updateProfileBtn";
            this.updateProfileBtn.Size = new System.Drawing.Size(69, 25);
            this.updateProfileBtn.TabIndex = 25;
            this.updateProfileBtn.Text = "Profile";
            this.updateProfileBtn.UseVisualStyleBackColor = false;
            this.updateProfileBtn.Click += new System.EventHandler(this.updateProfileBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(232, 5);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(1);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(69, 25);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Expo M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(772, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button orderstatBtn;
        private System.Windows.Forms.Button feedbackBtn;
        private System.Windows.Forms.Label labelEwalletBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button updateProfileBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
    }
}

