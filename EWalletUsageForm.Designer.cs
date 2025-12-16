namespace AdminRole6
{
    partial class EWalletUsageForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eWalletTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet8 = new SedapMakanRestoranSystem.SedapMakanDBDataSet8();
            this.eWalletBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet2 = new SedapMakanRestoranSystem.SedapMakanDBDataSet2();
            this.eWalletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerSearchBox = new System.Windows.Forms.TextBox();
            this.ewalletDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.backToDashboardBtn = new System.Windows.Forms.Button();
            this.ewalletSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eWalletTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet2TableAdapters.EWalletTableAdapter();
            this.eWalletTransactionsTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet8TableAdapters.EWalletTransactionsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ewalletLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWalletTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWalletBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWalletBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eWalletTransactionsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(776, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            this.transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eWalletTransactionsBindingSource
            // 
            this.eWalletTransactionsBindingSource.DataMember = "EWalletTransactions";
            this.eWalletTransactionsBindingSource.DataSource = this.sedapMakanDBDataSet8;
            // 
            // sedapMakanDBDataSet8
            // 
            this.sedapMakanDBDataSet8.DataSetName = "SedapMakanDBDataSet8";
            this.sedapMakanDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eWalletBindingSource1
            // 
            this.eWalletBindingSource1.DataMember = "EWallet";
            this.eWalletBindingSource1.DataSource = this.sedapMakanDBDataSet2;
            // 
            // sedapMakanDBDataSet2
            // 
            this.sedapMakanDBDataSet2.DataSetName = "SedapMakanDBDataSet2";
            this.sedapMakanDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eWalletBindingSource
            // 
            this.eWalletBindingSource.DataMember = "EWallet";
            // 
            // customerSearchBox
            // 
            this.customerSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerSearchBox.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customerSearchBox.Location = new System.Drawing.Point(111, 287);
            this.customerSearchBox.Name = "customerSearchBox";
            this.customerSearchBox.Size = new System.Drawing.Size(100, 20);
            this.customerSearchBox.TabIndex = 1;
            // 
            // ewalletDateTimePicker
            // 
            this.ewalletDateTimePicker.CustomFormat = "MM/yyyy";
            this.ewalletDateTimePicker.Location = new System.Drawing.Point(60, 330);
            this.ewalletDateTimePicker.Name = "ewalletDateTimePicker";
            this.ewalletDateTimePicker.ShowCheckBox = true;
            this.ewalletDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ewalletDateTimePicker.TabIndex = 2;
            // 
            // backToDashboardBtn
            // 
            this.backToDashboardBtn.BackColor = System.Drawing.Color.DimGray;
            this.backToDashboardBtn.FlatAppearance.BorderSize = 0;
            this.backToDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToDashboardBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backToDashboardBtn.ForeColor = System.Drawing.Color.White;
            this.backToDashboardBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.backToDashboardBtn.Location = new System.Drawing.Point(631, 374);
            this.backToDashboardBtn.Name = "backToDashboardBtn";
            this.backToDashboardBtn.Size = new System.Drawing.Size(157, 48);
            this.backToDashboardBtn.TabIndex = 3;
            this.backToDashboardBtn.Text = "Back to Dashboard";
            this.backToDashboardBtn.UseVisualStyleBackColor = false;
            this.backToDashboardBtn.Click += new System.EventHandler(this.backToDashboardBtn_Click);
            // 
            // ewalletSearchBtn
            // 
            this.ewalletSearchBtn.BackColor = System.Drawing.Color.DimGray;
            this.ewalletSearchBtn.FlatAppearance.BorderSize = 0;
            this.ewalletSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ewalletSearchBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ewalletSearchBtn.ForeColor = System.Drawing.Color.White;
            this.ewalletSearchBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ewalletSearchBtn.Location = new System.Drawing.Point(12, 374);
            this.ewalletSearchBtn.Name = "ewalletSearchBtn";
            this.ewalletSearchBtn.Size = new System.Drawing.Size(157, 48);
            this.ewalletSearchBtn.TabIndex = 4;
            this.ewalletSearchBtn.Text = "Search";
            this.ewalletSearchBtn.UseVisualStyleBackColor = false;
            this.ewalletSearchBtn.Click += new System.EventHandler(this.ewalletSearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "CustomerID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // eWalletTableAdapter
            // 
            this.eWalletTableAdapter.ClearBeforeFill = true;
            // 
            // eWalletTransactionsTableAdapter
            // 
            this.eWalletTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ewalletLbl);
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
            // ewalletLbl
            // 
            this.ewalletLbl.AutoSize = true;
            this.ewalletLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ewalletLbl.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ewalletLbl.ForeColor = System.Drawing.Color.White;
            this.ewalletLbl.Location = new System.Drawing.Point(0, 0);
            this.ewalletLbl.Name = "ewalletLbl";
            this.ewalletLbl.Size = new System.Drawing.Size(250, 32);
            this.ewalletLbl.TabIndex = 26;
            this.ewalletLbl.Text = "E-Wallet Usage";
            this.ewalletLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EWalletUsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ewalletSearchBtn);
            this.Controls.Add(this.backToDashboardBtn);
            this.Controls.Add(this.ewalletDateTimePicker);
            this.Controls.Add(this.customerSearchBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EWalletUsageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EWalletUsageForm";
            this.Load += new System.EventHandler(this.EWalletUsageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWalletTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWalletBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eWalletBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox customerSearchBox;
        private System.Windows.Forms.DateTimePicker ewalletDateTimePicker;
        private System.Windows.Forms.Button backToDashboardBtn;
        private System.Windows.Forms.Button ewalletSearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource eWalletBindingSource;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet2 sedapMakanDBDataSet2;
        private System.Windows.Forms.BindingSource eWalletBindingSource1;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet2TableAdapters.EWalletTableAdapter eWalletTableAdapter;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet8 sedapMakanDBDataSet8;
        private System.Windows.Forms.BindingSource eWalletTransactionsBindingSource;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet8TableAdapters.EWalletTransactionsTableAdapter eWalletTransactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ewalletLbl;
    }
}