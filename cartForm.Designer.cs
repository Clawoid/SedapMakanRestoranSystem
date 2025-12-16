namespace OOP_Assignment_Customer_
{
    partial class cartForm
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
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.menuItemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet12 = new SedapMakanRestoranSystem.SedapMakanDBDataSet12();
            this.removeBtn = new System.Windows.Forms.Button();
            this.updateQtyBtn = new System.Windows.Forms.Button();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.numericUpDownUpdateQty = new System.Windows.Forms.NumericUpDown();
            this.backBtn = new System.Windows.Forms.Button();
            this.menuTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet12TableAdapters.MenuTableAdapter();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.cartLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateQty)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToResizeColumns = false;
            this.dataGridViewCart.AllowUserToResizeRows = false;
            this.dataGridViewCart.AutoGenerateColumns = false;
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuItemIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.availabilityDataGridViewCheckBoxColumn});
            this.dataGridViewCart.DataSource = this.menuBindingSource;
            this.dataGridViewCart.GridColor = System.Drawing.Color.Black;
            this.dataGridViewCart.Location = new System.Drawing.Point(96, 61);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(601, 303);
            this.dataGridViewCart.TabIndex = 0;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            // 
            // menuItemIDDataGridViewTextBoxColumn
            // 
            this.menuItemIDDataGridViewTextBoxColumn.DataPropertyName = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn.HeaderText = "MenuItemID";
            this.menuItemIDDataGridViewTextBoxColumn.Name = "menuItemIDDataGridViewTextBoxColumn";
            this.menuItemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // availabilityDataGridViewCheckBoxColumn
            // 
            this.availabilityDataGridViewCheckBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewCheckBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewCheckBoxColumn.Name = "availabilityDataGridViewCheckBoxColumn";
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.sedapMakanDBDataSet12;
            // 
            // sedapMakanDBDataSet12
            // 
            this.sedapMakanDBDataSet12.DataSetName = "SedapMakanDBDataSet12";
            this.sedapMakanDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.DimGray;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(338, 382);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(103, 38);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove Item";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // updateQtyBtn
            // 
            this.updateQtyBtn.BackColor = System.Drawing.Color.DimGray;
            this.updateQtyBtn.FlatAppearance.BorderSize = 0;
            this.updateQtyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateQtyBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updateQtyBtn.ForeColor = System.Drawing.Color.White;
            this.updateQtyBtn.Location = new System.Drawing.Point(96, 382);
            this.updateQtyBtn.Name = "updateQtyBtn";
            this.updateQtyBtn.Size = new System.Drawing.Size(103, 38);
            this.updateQtyBtn.TabIndex = 3;
            this.updateQtyBtn.Text = "Update Quantity";
            this.updateQtyBtn.UseVisualStyleBackColor = false;
            this.updateQtyBtn.Click += new System.EventHandler(this.updateQtyBtn_Click);
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.BackColor = System.Drawing.Color.DimGray;
            this.checkoutBtn.FlatAppearance.BorderSize = 0;
            this.checkoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.checkoutBtn.Location = new System.Drawing.Point(561, 397);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(136, 23);
            this.checkoutBtn.TabIndex = 4;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = false;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTotal.Location = new System.Drawing.Point(561, 382);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(37, 12);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // numericUpDownUpdateQty
            // 
            this.numericUpDownUpdateQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownUpdateQty.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDownUpdateQty.Location = new System.Drawing.Point(217, 384);
            this.numericUpDownUpdateQty.Name = "numericUpDownUpdateQty";
            this.numericUpDownUpdateQty.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownUpdateQty.TabIndex = 6;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(452, 382);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(103, 38);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Black;
            this.headerPanel.Controls.Add(this.exitButton);
            this.headerPanel.Controls.Add(this.cartLbl);
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
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cartLbl
            // 
            this.cartLbl.AutoSize = true;
            this.cartLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartLbl.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cartLbl.ForeColor = System.Drawing.Color.White;
            this.cartLbl.Location = new System.Drawing.Point(0, 0);
            this.cartLbl.Name = "cartLbl";
            this.cartLbl.Size = new System.Drawing.Size(240, 32);
            this.cartLbl.TabIndex = 26;
            this.cartLbl.Text = "Shopping Cart";
            this.cartLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.numericUpDownUpdateQty);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.checkoutBtn);
            this.Controls.Add(this.updateQtyBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.dataGridViewCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cartForm";
            this.Load += new System.EventHandler(this.cartForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateQty)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button updateQtyBtn;
        private System.Windows.Forms.Button checkoutBtn;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownUpdateQty;
        private System.Windows.Forms.Button backBtn;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet12 sedapMakanDBDataSet12;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet12TableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availabilityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label cartLbl;
    }
}