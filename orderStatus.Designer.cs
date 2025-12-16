namespace OOP_Assignment_Customer_
{
    partial class orderStatus
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
            this.orderStatusLabel = new System.Windows.Forms.Label();
            this.dataGridViewOrderStatus = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet10 = new SedapMakanRestoranSystem.SedapMakanDBDataSet10();
            this.dataGridViewRefundStatus = new System.Windows.Forms.DataGridView();
            this.refundIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet11 = new SedapMakanRestoranSystem.SedapMakanDBDataSet11();
            this.refundLabel = new System.Windows.Forms.Label();
            this.refundReasonTxt = new System.Windows.Forms.TextBox();
            this.refundBtn = new System.Windows.Forms.Button();
            this.submitRefundBtn = new System.Windows.Forms.Button();
            this.refundTextLabel = new System.Windows.Forms.Label();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.ordersTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet10TableAdapters.OrdersTableAdapter();
            this.refundsTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet11TableAdapters.RefundsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.orderandrefundstatusLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRefundStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderStatusLabel
            // 
            this.orderStatusLabel.AutoSize = true;
            this.orderStatusLabel.Font = new System.Drawing.Font("Expo M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderStatusLabel.Location = new System.Drawing.Point(322, 71);
            this.orderStatusLabel.Name = "orderStatusLabel";
            this.orderStatusLabel.Size = new System.Drawing.Size(152, 23);
            this.orderStatusLabel.TabIndex = 0;
            this.orderStatusLabel.Text = "Order Status";
            // 
            // dataGridViewOrderStatus
            // 
            this.dataGridViewOrderStatus.AllowUserToAddRows = false;
            this.dataGridViewOrderStatus.AllowUserToDeleteRows = false;
            this.dataGridViewOrderStatus.AllowUserToResizeColumns = false;
            this.dataGridViewOrderStatus.AllowUserToResizeRows = false;
            this.dataGridViewOrderStatus.AutoGenerateColumns = false;
            this.dataGridViewOrderStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderStatus.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.menuItemIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.chefIDDataGridViewTextBoxColumn});
            this.dataGridViewOrderStatus.DataSource = this.ordersBindingSource;
            this.dataGridViewOrderStatus.GridColor = System.Drawing.Color.Black;
            this.dataGridViewOrderStatus.Location = new System.Drawing.Point(49, 97);
            this.dataGridViewOrderStatus.Name = "dataGridViewOrderStatus";
            this.dataGridViewOrderStatus.ReadOnly = true;
            this.dataGridViewOrderStatus.Size = new System.Drawing.Size(694, 124);
            this.dataGridViewOrderStatus.TabIndex = 1;
            this.dataGridViewOrderStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderStatus_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuItemIDDataGridViewTextBoxColumn
            // 
            this.menuItemIDDataGridViewTextBoxColumn.DataPropertyName = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn.HeaderText = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn.Name = "menuItemIDDataGridViewTextBoxColumn";
            this.menuItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chefIDDataGridViewTextBoxColumn
            // 
            this.chefIDDataGridViewTextBoxColumn.DataPropertyName = "ChefID";
            this.chefIDDataGridViewTextBoxColumn.HeaderText = "ChefID";
            this.chefIDDataGridViewTextBoxColumn.Name = "chefIDDataGridViewTextBoxColumn";
            this.chefIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.sedapMakanDBDataSet10;
            // 
            // sedapMakanDBDataSet10
            // 
            this.sedapMakanDBDataSet10.DataSetName = "SedapMakanDBDataSet10";
            this.sedapMakanDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewRefundStatus
            // 
            this.dataGridViewRefundStatus.AllowUserToAddRows = false;
            this.dataGridViewRefundStatus.AllowUserToDeleteRows = false;
            this.dataGridViewRefundStatus.AllowUserToResizeColumns = false;
            this.dataGridViewRefundStatus.AllowUserToResizeRows = false;
            this.dataGridViewRefundStatus.AutoGenerateColumns = false;
            this.dataGridViewRefundStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRefundStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewRefundStatus.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRefundStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRefundStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refundIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn1,
            this.customerIDDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1,
            this.managerCommentDataGridViewTextBoxColumn});
            this.dataGridViewRefundStatus.DataSource = this.refundsBindingSource;
            this.dataGridViewRefundStatus.GridColor = System.Drawing.Color.Black;
            this.dataGridViewRefundStatus.Location = new System.Drawing.Point(49, 314);
            this.dataGridViewRefundStatus.Name = "dataGridViewRefundStatus";
            this.dataGridViewRefundStatus.ReadOnly = true;
            this.dataGridViewRefundStatus.Size = new System.Drawing.Size(694, 124);
            this.dataGridViewRefundStatus.TabIndex = 2;
            this.dataGridViewRefundStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRefundStatus_CellContentClick);
            // 
            // refundIDDataGridViewTextBoxColumn
            // 
            this.refundIDDataGridViewTextBoxColumn.DataPropertyName = "RefundID";
            this.refundIDDataGridViewTextBoxColumn.HeaderText = "RefundID";
            this.refundIDDataGridViewTextBoxColumn.Name = "refundIDDataGridViewTextBoxColumn";
            this.refundIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // managerCommentDataGridViewTextBoxColumn
            // 
            this.managerCommentDataGridViewTextBoxColumn.DataPropertyName = "ManagerComment";
            this.managerCommentDataGridViewTextBoxColumn.HeaderText = "ManagerComment";
            this.managerCommentDataGridViewTextBoxColumn.Name = "managerCommentDataGridViewTextBoxColumn";
            this.managerCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refundsBindingSource
            // 
            this.refundsBindingSource.DataMember = "Refunds";
            this.refundsBindingSource.DataSource = this.sedapMakanDBDataSet11;
            // 
            // sedapMakanDBDataSet11
            // 
            this.sedapMakanDBDataSet11.DataSetName = "SedapMakanDBDataSet11";
            this.sedapMakanDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // refundLabel
            // 
            this.refundLabel.AutoSize = true;
            this.refundLabel.Font = new System.Drawing.Font("Expo M", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refundLabel.Location = new System.Drawing.Point(322, 288);
            this.refundLabel.Name = "refundLabel";
            this.refundLabel.Size = new System.Drawing.Size(165, 23);
            this.refundLabel.TabIndex = 3;
            this.refundLabel.Text = "Refund Status";
            // 
            // refundReasonTxt
            // 
            this.refundReasonTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.refundReasonTxt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundReasonTxt.Location = new System.Drawing.Point(567, 242);
            this.refundReasonTxt.Multiline = true;
            this.refundReasonTxt.Name = "refundReasonTxt";
            this.refundReasonTxt.Size = new System.Drawing.Size(176, 26);
            this.refundReasonTxt.TabIndex = 4;
            this.refundReasonTxt.TextChanged += new System.EventHandler(this.refundReasonTxt_TextChanged);
            // 
            // refundBtn
            // 
            this.refundBtn.BackColor = System.Drawing.Color.DimGray;
            this.refundBtn.FlatAppearance.BorderSize = 0;
            this.refundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refundBtn.ForeColor = System.Drawing.Color.White;
            this.refundBtn.Location = new System.Drawing.Point(177, 227);
            this.refundBtn.Name = "refundBtn";
            this.refundBtn.Size = new System.Drawing.Size(111, 41);
            this.refundBtn.TabIndex = 5;
            this.refundBtn.Text = "Request Refund";
            this.refundBtn.UseVisualStyleBackColor = false;
            this.refundBtn.Click += new System.EventHandler(this.refundBtn_Click);
            // 
            // submitRefundBtn
            // 
            this.submitRefundBtn.BackColor = System.Drawing.Color.DimGray;
            this.submitRefundBtn.FlatAppearance.BorderSize = 0;
            this.submitRefundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitRefundBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.submitRefundBtn.ForeColor = System.Drawing.Color.White;
            this.submitRefundBtn.Location = new System.Drawing.Point(437, 227);
            this.submitRefundBtn.Name = "submitRefundBtn";
            this.submitRefundBtn.Size = new System.Drawing.Size(111, 41);
            this.submitRefundBtn.TabIndex = 6;
            this.submitRefundBtn.Text = "Submit Refund Request";
            this.submitRefundBtn.UseVisualStyleBackColor = false;
            this.submitRefundBtn.Click += new System.EventHandler(this.submitRefundBtn_Click);
            // 
            // refundTextLabel
            // 
            this.refundTextLabel.AutoSize = true;
            this.refundTextLabel.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refundTextLabel.Location = new System.Drawing.Point(565, 227);
            this.refundTextLabel.Name = "refundTextLabel";
            this.refundTextLabel.Size = new System.Drawing.Size(178, 12);
            this.refundTextLabel.TabIndex = 7;
            this.refundTextLabel.Text = "Write your reason for Refund:";
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.BackColor = System.Drawing.Color.DimGray;
            this.cancelOrderBtn.FlatAppearance.BorderSize = 0;
            this.cancelOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOrderBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelOrderBtn.ForeColor = System.Drawing.Color.White;
            this.cancelOrderBtn.Location = new System.Drawing.Point(49, 227);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(111, 41);
            this.cancelOrderBtn.TabIndex = 8;
            this.cancelOrderBtn.Text = "Cancel Order";
            this.cancelOrderBtn.UseVisualStyleBackColor = false;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(309, 227);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(110, 41);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // refundsTableAdapter
            // 
            this.refundsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.orderandrefundstatusLbl);
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
            // orderandrefundstatusLbl
            // 
            this.orderandrefundstatusLbl.AutoSize = true;
            this.orderandrefundstatusLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderandrefundstatusLbl.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderandrefundstatusLbl.ForeColor = System.Drawing.Color.White;
            this.orderandrefundstatusLbl.Location = new System.Drawing.Point(0, 0);
            this.orderandrefundstatusLbl.Name = "orderandrefundstatusLbl";
            this.orderandrefundstatusLbl.Size = new System.Drawing.Size(445, 32);
            this.orderandrefundstatusLbl.TabIndex = 26;
            this.orderandrefundstatusLbl.Text = "Order and Refund Stasuses";
            this.orderandrefundstatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.refundTextLabel);
            this.Controls.Add(this.submitRefundBtn);
            this.Controls.Add(this.refundBtn);
            this.Controls.Add(this.refundReasonTxt);
            this.Controls.Add(this.refundLabel);
            this.Controls.Add(this.dataGridViewRefundStatus);
            this.Controls.Add(this.dataGridViewOrderStatus);
            this.Controls.Add(this.orderStatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderStatus";
            this.Load += new System.EventHandler(this.orderStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRefundStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderStatusLabel;
        private System.Windows.Forms.DataGridView dataGridViewOrderStatus;
        private System.Windows.Forms.DataGridView dataGridViewRefundStatus;
        private System.Windows.Forms.Label refundLabel;
        private System.Windows.Forms.TextBox refundReasonTxt;
        private System.Windows.Forms.Button refundBtn;
        private System.Windows.Forms.Button submitRefundBtn;
        private System.Windows.Forms.Label refundTextLabel;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.Button backBtn;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet10 sedapMakanDBDataSet10;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet10TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chefIDDataGridViewTextBoxColumn;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet11 sedapMakanDBDataSet11;
        private System.Windows.Forms.BindingSource refundsBindingSource;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet11TableAdapters.RefundsTableAdapter refundsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label orderandrefundstatusLbl;
    }
}