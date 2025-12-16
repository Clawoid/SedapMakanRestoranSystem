namespace OOP_Assignment_Customer_
{
    partial class checkOut
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
            this.confirmpurchaseBtn = new System.Windows.Forms.Button();
            this.richTextBoxSummary = new System.Windows.Forms.RichTextBox();
            this.labelEwalletBalance = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkoutLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmpurchaseBtn
            // 
            this.confirmpurchaseBtn.BackColor = System.Drawing.Color.DimGray;
            this.confirmpurchaseBtn.FlatAppearance.BorderSize = 0;
            this.confirmpurchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmpurchaseBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.confirmpurchaseBtn.ForeColor = System.Drawing.Color.White;
            this.confirmpurchaseBtn.Location = new System.Drawing.Point(589, 379);
            this.confirmpurchaseBtn.Name = "confirmpurchaseBtn";
            this.confirmpurchaseBtn.Size = new System.Drawing.Size(141, 59);
            this.confirmpurchaseBtn.TabIndex = 1;
            this.confirmpurchaseBtn.Text = "Confirm Purchase";
            this.confirmpurchaseBtn.UseVisualStyleBackColor = false;
            this.confirmpurchaseBtn.Click += new System.EventHandler(this.confirmpurchaseBtn_Click);
            // 
            // richTextBoxSummary
            // 
            this.richTextBoxSummary.BackColor = System.Drawing.Color.White;
            this.richTextBoxSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxSummary.Location = new System.Drawing.Point(62, 112);
            this.richTextBoxSummary.Name = "richTextBoxSummary";
            this.richTextBoxSummary.ReadOnly = true;
            this.richTextBoxSummary.Size = new System.Drawing.Size(668, 261);
            this.richTextBoxSummary.TabIndex = 3;
            this.richTextBoxSummary.Text = "";
            // 
            // labelEwalletBalance
            // 
            this.labelEwalletBalance.AutoSize = true;
            this.labelEwalletBalance.Font = new System.Drawing.Font("Expo M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEwalletBalance.Location = new System.Drawing.Point(58, 86);
            this.labelEwalletBalance.Name = "labelEwalletBalance";
            this.labelEwalletBalance.Size = new System.Drawing.Size(203, 23);
            this.labelEwalletBalance.TabIndex = 6;
            this.labelEwalletBalance.Text = "E-wallet Balance:";
            this.labelEwalletBalance.Click += new System.EventHandler(this.labelEwalletBalance_Click);
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Expo M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIDLabel.Location = new System.Drawing.Point(600, 86);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(84, 23);
            this.userIDLabel.TabIndex = 8;
            this.userIDLabel.Text = "UserID:";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(62, 379);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(141, 59);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkoutLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 28;
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
            // checkoutLbl
            // 
            this.checkoutLbl.AutoSize = true;
            this.checkoutLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkoutLbl.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkoutLbl.ForeColor = System.Drawing.Color.White;
            this.checkoutLbl.Location = new System.Drawing.Point(0, 0);
            this.checkoutLbl.Name = "checkoutLbl";
            this.checkoutLbl.Size = new System.Drawing.Size(166, 32);
            this.checkoutLbl.TabIndex = 26;
            this.checkoutLbl.Text = "Checkout";
            this.checkoutLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.labelEwalletBalance);
            this.Controls.Add(this.richTextBoxSummary);
            this.Controls.Add(this.confirmpurchaseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkOut";
            this.Load += new System.EventHandler(this.checkOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmpurchaseBtn;
        private System.Windows.Forms.RichTextBox richTextBoxSummary;
        private System.Windows.Forms.Label labelEwalletBalance;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label checkoutLbl;
    }
}