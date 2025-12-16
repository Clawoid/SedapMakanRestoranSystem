namespace AdminRole6
{
    partial class SalesReportForm
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
            this.returnToDashboardBtn = new System.Windows.Forms.Button();
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chefIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet7 = new SedapMakanRestoranSystem.SedapMakanDBDataSet7();
            this.salesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet1 = new SedapMakanRestoranSystem.SedapMakanDBDataSet1();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userIDSearchBox = new System.Windows.Forms.TextBox();
            this.saleTypeSearchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.salesTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet1TableAdapters.SalesTableAdapter();
            this.salesTableAdapter1 = new SedapMakanRestoranSystem.SedapMakanDBDataSet7TableAdapters.SalesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.salesreportLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnToDashboardBtn
            // 
            this.returnToDashboardBtn.BackColor = System.Drawing.Color.DimGray;
            this.returnToDashboardBtn.FlatAppearance.BorderSize = 0;
            this.returnToDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToDashboardBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.returnToDashboardBtn.ForeColor = System.Drawing.Color.White;
            this.returnToDashboardBtn.Location = new System.Drawing.Point(648, 398);
            this.returnToDashboardBtn.Name = "returnToDashboardBtn";
            this.returnToDashboardBtn.Size = new System.Drawing.Size(140, 40);
            this.returnToDashboardBtn.TabIndex = 1;
            this.returnToDashboardBtn.Text = "Back to Dashboard";
            this.returnToDashboardBtn.UseVisualStyleBackColor = false;
            this.returnToDashboardBtn.Click += new System.EventHandler(this.returnToDashboardBtn_Click);
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AllowUserToAddRows = false;
            this.salesDataGrid.AllowUserToDeleteRows = false;
            this.salesDataGrid.AllowUserToResizeColumns = false;
            this.salesDataGrid.AllowUserToResizeRows = false;
            this.salesDataGrid.AutoGenerateColumns = false;
            this.salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salesDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.chefIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.saleTimeDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.salesDataGrid.DataSource = this.salesBindingSource3;
            this.salesDataGrid.GridColor = System.Drawing.Color.DarkGray;
            this.salesDataGrid.Location = new System.Drawing.Point(12, 53);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.ReadOnly = true;
            this.salesDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.salesDataGrid.Size = new System.Drawing.Size(776, 262);
            this.salesDataGrid.TabIndex = 2;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            this.saleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chefIDDataGridViewTextBoxColumn
            // 
            this.chefIDDataGridViewTextBoxColumn.DataPropertyName = "ChefID";
            this.chefIDDataGridViewTextBoxColumn.HeaderText = "ChefID";
            this.chefIDDataGridViewTextBoxColumn.Name = "chefIDDataGridViewTextBoxColumn";
            this.chefIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleTimeDataGridViewTextBoxColumn
            // 
            this.saleTimeDataGridViewTextBoxColumn.DataPropertyName = "SaleTime";
            this.saleTimeDataGridViewTextBoxColumn.HeaderText = "SaleTime";
            this.saleTimeDataGridViewTextBoxColumn.Name = "saleTimeDataGridViewTextBoxColumn";
            this.saleTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesBindingSource3
            // 
            this.salesBindingSource3.DataMember = "Sales";
            this.salesBindingSource3.DataSource = this.sedapMakanDBDataSet7;
            // 
            // sedapMakanDBDataSet7
            // 
            this.sedapMakanDBDataSet7.DataSetName = "SedapMakanDBDataSet7";
            this.sedapMakanDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource2
            // 
            this.salesBindingSource2.DataMember = "Sales";
            this.salesBindingSource2.DataSource = this.sedapMakanDBDataSet1;
            // 
            // sedapMakanDBDataSet1
            // 
            this.sedapMakanDBDataSet1.DataSetName = "SedapMakanDBDataSet1";
            this.sedapMakanDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            // 
            // salesDatePicker
            // 
            this.salesDatePicker.Location = new System.Drawing.Point(134, 404);
            this.salesDatePicker.Name = "salesDatePicker";
            this.salesDatePicker.ShowCheckBox = true;
            this.salesDatePicker.Size = new System.Drawing.Size(200, 20);
            this.salesDatePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(31, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(31, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sale Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Expo M", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(31, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chef\'s ID:";
            // 
            // userIDSearchBox
            // 
            this.userIDSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIDSearchBox.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIDSearchBox.Location = new System.Drawing.Point(134, 339);
            this.userIDSearchBox.Name = "userIDSearchBox";
            this.userIDSearchBox.Size = new System.Drawing.Size(191, 20);
            this.userIDSearchBox.TabIndex = 7;
            // 
            // saleTypeSearchBox
            // 
            this.saleTypeSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saleTypeSearchBox.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saleTypeSearchBox.Location = new System.Drawing.Point(134, 371);
            this.saleTypeSearchBox.Name = "saleTypeSearchBox";
            this.saleTypeSearchBox.Size = new System.Drawing.Size(168, 20);
            this.saleTypeSearchBox.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DimGray;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(371, 398);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(140, 40);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter1
            // 
            this.salesTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.salesreportLbl);
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
            // salesreportLbl
            // 
            this.salesreportLbl.AutoSize = true;
            this.salesreportLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.salesreportLbl.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.salesreportLbl.ForeColor = System.Drawing.Color.White;
            this.salesreportLbl.Location = new System.Drawing.Point(0, 0);
            this.salesreportLbl.Name = "salesreportLbl";
            this.salesreportLbl.Size = new System.Drawing.Size(293, 32);
            this.salesreportLbl.TabIndex = 26;
            this.salesreportLbl.Text = "View Sales Report";
            this.salesreportLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.saleTypeSearchBox);
            this.Controls.Add(this.userIDSearchBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salesDatePicker);
            this.Controls.Add(this.salesDataGrid);
            this.Controls.Add(this.returnToDashboardBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReportForm";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnToDashboardBtn;
        private System.Windows.Forms.DataGridView salesDataGrid;
        private System.Windows.Forms.DateTimePicker salesDatePicker;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userIDSearchBox;
        private System.Windows.Forms.TextBox saleTypeSearchBox;
        private System.Windows.Forms.Button searchBtn;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet1 sedapMakanDBDataSet1;
        private System.Windows.Forms.BindingSource salesBindingSource2;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet1TableAdapters.SalesTableAdapter salesTableAdapter;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet7 sedapMakanDBDataSet7;
        private System.Windows.Forms.BindingSource salesBindingSource3;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet7TableAdapters.SalesTableAdapter salesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chefIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label salesreportLbl;
    }
}