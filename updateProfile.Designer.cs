namespace OOP_Assignment__Chef_
{
    partial class updateProfile
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
            this.updProfile_label = new System.Windows.Forms.Label();
            this.fullName_label = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.saveChanges_btn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.fullName_box = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updProfile_label
            // 
            this.updProfile_label.AutoSize = true;
            this.updProfile_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.updProfile_label.Location = new System.Drawing.Point(322, 61);
            this.updProfile_label.Name = "updProfile_label";
            this.updProfile_label.Size = new System.Drawing.Size(150, 26);
            this.updProfile_label.TabIndex = 0;
            this.updProfile_label.Text = "Update Profile";
            // 
            // fullName_label
            // 
            this.fullName_label.AutoSize = true;
            this.fullName_label.Location = new System.Drawing.Point(135, 143);
            this.fullName_label.Name = "fullName_label";
            this.fullName_label.Size = new System.Drawing.Size(57, 13);
            this.fullName_label.TabIndex = 1;
            this.fullName_label.Text = "Full Name:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(135, 212);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(135, 287);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordBtn_Click);
            // 
            // saveChanges_btn
            // 
            this.saveChanges_btn.Location = new System.Drawing.Point(196, 367);
            this.saveChanges_btn.Name = "saveChanges_btn";
            this.saveChanges_btn.Size = new System.Drawing.Size(132, 44);
            this.saveChanges_btn.TabIndex = 4;
            this.saveChanges_btn.Text = "Save Changes";
            this.saveChanges_btn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(452, 367);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(132, 44);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // fullName_box
            // 
            this.fullName_box.Location = new System.Drawing.Point(301, 136);
            this.fullName_box.Name = "fullName_box";
            this.fullName_box.Size = new System.Drawing.Size(235, 20);
            this.fullName_box.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(301, 209);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(235, 20);
            this.emailBox.TabIndex = 7;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(301, 280);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(235, 20);
            this.passwordBox.TabIndex = 8;
            // 
            // updateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.fullName_box);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveChanges_btn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fullName_label);
            this.Controls.Add(this.updProfile_label);
            this.Name = "updateProfile";
            this.Text = "updateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updProfile_label;
        private System.Windows.Forms.Label fullName_label;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button saveChanges_btn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox fullName_box;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
    }
}