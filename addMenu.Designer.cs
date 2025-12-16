namespace OOP_Assignment__Chef_
{
    partial class addMenu
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
            this.itmAvailability = new System.Windows.Forms.CheckBox();
            this.label_menuitem = new System.Windows.Forms.Label();
            this.itmName = new System.Windows.Forms.TextBox();
            this.itmCategory = new System.Windows.Forms.TextBox();
            this.itmPrice = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itmAvailability
            // 
            this.itmAvailability.AutoSize = true;
            this.itmAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itmAvailability.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itmAvailability.Location = new System.Drawing.Point(342, 288);
            this.itmAvailability.Name = "itmAvailability";
            this.itmAvailability.Size = new System.Drawing.Size(97, 18);
            this.itmAvailability.TabIndex = 0;
            this.itmAvailability.Text = "Availability";
            this.itmAvailability.UseVisualStyleBackColor = true;
            // 
            // label_menuitem
            // 
            this.label_menuitem.AutoSize = true;
            this.label_menuitem.BackColor = System.Drawing.Color.Transparent;
            this.label_menuitem.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_menuitem.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_menuitem.ForeColor = System.Drawing.Color.White;
            this.label_menuitem.Location = new System.Drawing.Point(0, 0);
            this.label_menuitem.Name = "label_menuitem";
            this.label_menuitem.Size = new System.Drawing.Size(457, 32);
            this.label_menuitem.TabIndex = 1;
            this.label_menuitem.Text = "Add or Update a Menu Item";
            // 
            // itmName
            // 
            this.itmName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itmName.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itmName.Location = new System.Drawing.Point(342, 152);
            this.itmName.Name = "itmName";
            this.itmName.Size = new System.Drawing.Size(158, 20);
            this.itmName.TabIndex = 2;
            this.itmName.TextChanged += new System.EventHandler(this.itmName_TextChanged);
            // 
            // itmCategory
            // 
            this.itmCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itmCategory.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itmCategory.Location = new System.Drawing.Point(342, 244);
            this.itmCategory.Name = "itmCategory";
            this.itmCategory.Size = new System.Drawing.Size(158, 20);
            this.itmCategory.TabIndex = 3;
            // 
            // itmPrice
            // 
            this.itmPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itmPrice.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itmPrice.Location = new System.Drawing.Point(342, 198);
            this.itmPrice.Name = "itmPrice";
            this.itmPrice.Size = new System.Drawing.Size(158, 20);
            this.itmPrice.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(290, 158);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 14);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryLabel.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.categoryLabel.Location = new System.Drawing.Point(265, 250);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(71, 14);
            this.categoryLabel.TabIndex = 6;
            this.categoryLabel.Text = "Category";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceLabel.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.priceLabel.Location = new System.Drawing.Point(296, 204);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 14);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "Price";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(435, 379);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 40);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Menu Item";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.DimGray;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(635, 379);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(128, 40);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // updBtn
            // 
            this.updBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.updBtn.FlatAppearance.BorderSize = 0;
            this.updBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updBtn.ForeColor = System.Drawing.Color.White;
            this.updBtn.Location = new System.Drawing.Point(35, 379);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(128, 40);
            this.updBtn.TabIndex = 10;
            this.updBtn.Text = "Update Menu Item";
            this.updBtn.UseVisualStyleBackColor = false;
            this.updBtn.Click += new System.EventHandler(this.updBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(235, 379);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(128, 40);
            this.removeBtn.TabIndex = 11;
            this.removeBtn.Text = "Remove Menu Item";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Black;
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.label_menuitem);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 35);
            this.headerPanel.TabIndex = 28;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Expo M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(772, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 32);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "x";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // addMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.itmPrice);
            this.Controls.Add(this.itmCategory);
            this.Controls.Add(this.itmName);
            this.Controls.Add(this.itmAvailability);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addMenu";
            this.Text = "addMenu";
            this.Load += new System.EventHandler(this.addMenu_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox itmAvailability;
        private System.Windows.Forms.Label label_menuitem;
        private System.Windows.Forms.TextBox itmName;
        private System.Windows.Forms.TextBox itmCategory;
        private System.Windows.Forms.TextBox itmPrice;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button exitButton;
    }
}