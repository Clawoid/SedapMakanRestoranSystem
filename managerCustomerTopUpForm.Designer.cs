namespace SedapMakanRestoranSystem
{
    partial class managerCustomerTopUpForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.customettopupLbl = new System.Windows.Forms.Label();
            this.dgvTopUp = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eWalletBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet18 = new SedapMakanRestoranSystem.SedapMakanDBDataSet18();
            this.topupButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customeridLabel = new System.Windows.Forms.Label();
            this.backToDashboardBtn = new System.Windows.Forms.Button();
            this.sedapMakanDBDataSet17 = new SedapMakanRestoranSystem.SedapMakanDBDataSet17();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet17TableAdapters.CustomersTableAdapter();
            this.usersTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet18TableAdapters.UsersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.customettopupLbl);
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
            // customettopupLbl
            // 
            this.customettopupLbl.AutoSize = true;
            this.customettopupLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.customettopupLbl.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customettopupLbl.ForeColor = System.Drawing.Color.White;
            this.customettopupLbl.Location = new System.Drawing.Point(0, 0);
            this.customettopupLbl.Name = "customettopupLbl";
            this.customettopupLbl.Size = new System.Drawing.Size(285, 32);
            this.customettopupLbl.TabIndex = 26;
            this.customettopupLbl.Text = "Customer Top Up";
            this.customettopupLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTopUp
            // 
            this.dgvTopUp.AllowUserToAddRows = false;
            this.dgvTopUp.AllowUserToDeleteRows = false;
            this.dgvTopUp.AllowUserToResizeColumns = false;
            this.dgvTopUp.AllowUserToResizeRows = false;
            this.dgvTopUp.AutoGenerateColumns = false;
            this.dgvTopUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopUp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTopUp.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.eWalletBalanceDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn});
            this.dgvTopUp.DataSource = this.usersBindingSource;
            this.dgvTopUp.GridColor = System.Drawing.Color.Black;
            this.dgvTopUp.Location = new System.Drawing.Point(13, 42);
            this.dgvTopUp.Name = "dgvTopUp";
            this.dgvTopUp.ReadOnly = true;
            this.dgvTopUp.RowHeadersWidth = 102;
            this.dgvTopUp.Size = new System.Drawing.Size(775, 238);
            this.dgvTopUp.TabIndex = 29;
            this.dgvTopUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopUp_CellClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eWalletBalanceDataGridViewTextBoxColumn
            // 
            this.eWalletBalanceDataGridViewTextBoxColumn.DataPropertyName = "EWalletBalance";
            this.eWalletBalanceDataGridViewTextBoxColumn.HeaderText = "EWalletBalance";
            this.eWalletBalanceDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.eWalletBalanceDataGridViewTextBoxColumn.Name = "eWalletBalanceDataGridViewTextBoxColumn";
            this.eWalletBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.sedapMakanDBDataSet18;
            // 
            // sedapMakanDBDataSet18
            // 
            this.sedapMakanDBDataSet18.DataSetName = "SedapMakanDBDataSet18";
            this.sedapMakanDBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topupButton
            // 
            this.topupButton.BackColor = System.Drawing.Color.DimGray;
            this.topupButton.FlatAppearance.BorderSize = 0;
            this.topupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topupButton.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.topupButton.ForeColor = System.Drawing.Color.White;
            this.topupButton.Location = new System.Drawing.Point(13, 347);
            this.topupButton.Name = "topupButton";
            this.topupButton.Size = new System.Drawing.Size(148, 61);
            this.topupButton.TabIndex = 30;
            this.topupButton.Text = "Top Up";
            this.topupButton.UseVisualStyleBackColor = false;
            this.topupButton.Click += new System.EventHandler(this.topupButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountTextBox.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.amountTextBox.Location = new System.Drawing.Point(118, 319);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "Top Up Amount:";
            // 
            // customeridLabel
            // 
            this.customeridLabel.AutoSize = true;
            this.customeridLabel.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customeridLabel.Location = new System.Drawing.Point(12, 294);
            this.customeridLabel.Name = "customeridLabel";
            this.customeridLabel.Size = new System.Drawing.Size(168, 12);
            this.customeridLabel.TabIndex = 33;
            this.customeridLabel.Text = "Top up for the Customer ID:";
            // 
            // backToDashboardBtn
            // 
            this.backToDashboardBtn.BackColor = System.Drawing.Color.DimGray;
            this.backToDashboardBtn.FlatAppearance.BorderSize = 0;
            this.backToDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToDashboardBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backToDashboardBtn.ForeColor = System.Drawing.Color.White;
            this.backToDashboardBtn.Location = new System.Drawing.Point(640, 347);
            this.backToDashboardBtn.Name = "backToDashboardBtn";
            this.backToDashboardBtn.Size = new System.Drawing.Size(148, 61);
            this.backToDashboardBtn.TabIndex = 34;
            this.backToDashboardBtn.Text = "Back";
            this.backToDashboardBtn.UseVisualStyleBackColor = false;
            this.backToDashboardBtn.Click += new System.EventHandler(this.backToDashboardBtn_Click);
            // 
            // sedapMakanDBDataSet17
            // 
            this.sedapMakanDBDataSet17.DataSetName = "SedapMakanDBDataSet17";
            this.sedapMakanDBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.sedapMakanDBDataSet17;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // managerCustomerTopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToDashboardBtn);
            this.Controls.Add(this.customeridLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.topupButton);
            this.Controls.Add(this.dgvTopUp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "managerCustomerTopUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "managerCustomerTopUpForm";
            this.Load += new System.EventHandler(this.managerCustomerTopUpForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label customettopupLbl;
        private System.Windows.Forms.DataGridView dgvTopUp;
        private System.Windows.Forms.Button topupButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customeridLabel;
        private System.Windows.Forms.Button backToDashboardBtn;
        private SedapMakanDBDataSet17 sedapMakanDBDataSet17;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SedapMakanDBDataSet17TableAdapters.CustomersTableAdapter customersTableAdapter;
        private SedapMakanDBDataSet18 sedapMakanDBDataSet18;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private SedapMakanDBDataSet18TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eWalletBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    }
}