namespace SedapMakanRestoranSystem
{
    partial class managerRefundsForm
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
            this.backToManagerDashboardBtn = new System.Windows.Forms.Button();
            this.rejectBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.refundIDlbl = new System.Windows.Forms.Label();
            this.dgvRefunds = new System.Windows.Forms.DataGridView();
            this.refundIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet16 = new SedapMakanRestoranSystem.SedapMakanDBDataSet16();
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.refundsTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet16TableAdapters.RefundsTableAdapter();
            this.managerCommentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveCommentsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet16)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToManagerDashboardBtn
            // 
            this.backToManagerDashboardBtn.BackColor = System.Drawing.Color.DimGray;
            this.backToManagerDashboardBtn.FlatAppearance.BorderSize = 0;
            this.backToManagerDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToManagerDashboardBtn.Font = new System.Drawing.Font("Expo M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backToManagerDashboardBtn.ForeColor = System.Drawing.Color.White;
            this.backToManagerDashboardBtn.Location = new System.Drawing.Point(617, 354);
            this.backToManagerDashboardBtn.Name = "backToManagerDashboardBtn";
            this.backToManagerDashboardBtn.Size = new System.Drawing.Size(118, 62);
            this.backToManagerDashboardBtn.TabIndex = 32;
            this.backToManagerDashboardBtn.Text = "Back";
            this.backToManagerDashboardBtn.UseVisualStyleBackColor = false;
            this.backToManagerDashboardBtn.Click += new System.EventHandler(this.backToManagerDashboardBtn_Click);
            // 
            // rejectBtn
            // 
            this.rejectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rejectBtn.FlatAppearance.BorderSize = 0;
            this.rejectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectBtn.Font = new System.Drawing.Font("Expo M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rejectBtn.ForeColor = System.Drawing.Color.White;
            this.rejectBtn.Location = new System.Drawing.Point(192, 353);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(118, 62);
            this.rejectBtn.TabIndex = 31;
            this.rejectBtn.Text = "Reject Refund";
            this.rejectBtn.UseVisualStyleBackColor = false;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Expo M", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 41);
            this.label3.TabIndex = 30;
            this.label3.Text = "Refunds";
            // 
            // refundIDlbl
            // 
            this.refundIDlbl.AutoSize = true;
            this.refundIDlbl.Font = new System.Drawing.Font("Expo M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.refundIDlbl.Location = new System.Drawing.Point(65, 73);
            this.refundIDlbl.Name = "refundIDlbl";
            this.refundIDlbl.Size = new System.Drawing.Size(94, 18);
            this.refundIDlbl.TabIndex = 29;
            this.refundIDlbl.Text = "Refund ID:";
            // 
            // dgvRefunds
            // 
            this.dgvRefunds.AutoGenerateColumns = false;
            this.dgvRefunds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRefunds.BackgroundColor = System.Drawing.Color.White;
            this.dgvRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefunds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refundIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.managerCommentDataGridViewTextBoxColumn});
            this.dgvRefunds.DataSource = this.refundsBindingSource;
            this.dgvRefunds.GridColor = System.Drawing.Color.Black;
            this.dgvRefunds.Location = new System.Drawing.Point(68, 94);
            this.dgvRefunds.Name = "dgvRefunds";
            this.dgvRefunds.RowHeadersWidth = 62;
            this.dgvRefunds.RowTemplate.Height = 28;
            this.dgvRefunds.Size = new System.Drawing.Size(667, 228);
            this.dgvRefunds.TabIndex = 28;
            this.dgvRefunds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefunds_CellClick);
            // 
            // refundIDDataGridViewTextBoxColumn
            // 
            this.refundIDDataGridViewTextBoxColumn.DataPropertyName = "RefundID";
            this.refundIDDataGridViewTextBoxColumn.HeaderText = "RefundID";
            this.refundIDDataGridViewTextBoxColumn.Name = "refundIDDataGridViewTextBoxColumn";
            this.refundIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // managerCommentDataGridViewTextBoxColumn
            // 
            this.managerCommentDataGridViewTextBoxColumn.DataPropertyName = "ManagerComment";
            this.managerCommentDataGridViewTextBoxColumn.HeaderText = "ManagerComment";
            this.managerCommentDataGridViewTextBoxColumn.Name = "managerCommentDataGridViewTextBoxColumn";
            // 
            // refundsBindingSource
            // 
            this.refundsBindingSource.DataMember = "Refunds";
            this.refundsBindingSource.DataSource = this.sedapMakanDBDataSet16;
            // 
            // sedapMakanDBDataSet16
            // 
            this.sedapMakanDBDataSet16.DataSetName = "SedapMakanDBDataSet16";
            this.sedapMakanDBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ApproveBtn.FlatAppearance.BorderSize = 0;
            this.ApproveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveBtn.Font = new System.Drawing.Font("Expo M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ApproveBtn.ForeColor = System.Drawing.Color.White;
            this.ApproveBtn.Location = new System.Drawing.Point(68, 354);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(118, 62);
            this.ApproveBtn.TabIndex = 33;
            this.ApproveBtn.Text = "Approve Refund";
            this.ApproveBtn.UseVisualStyleBackColor = false;
            this.ApproveBtn.Click += new System.EventHandler(this.ApproveBtn_Click);
            // 
            // refundsTableAdapter
            // 
            this.refundsTableAdapter.ClearBeforeFill = true;
            // 
            // managerCommentBox
            // 
            this.managerCommentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.managerCommentBox.Location = new System.Drawing.Point(316, 371);
            this.managerCommentBox.Multiline = true;
            this.managerCommentBox.Name = "managerCommentBox";
            this.managerCommentBox.Size = new System.Drawing.Size(190, 45);
            this.managerCommentBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(316, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "Additional Comments:";
            // 
            // saveCommentsBtn
            // 
            this.saveCommentsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.saveCommentsBtn.FlatAppearance.BorderSize = 0;
            this.saveCommentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCommentsBtn.Font = new System.Drawing.Font("Expo M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveCommentsBtn.ForeColor = System.Drawing.Color.White;
            this.saveCommentsBtn.Location = new System.Drawing.Point(512, 354);
            this.saveCommentsBtn.Name = "saveCommentsBtn";
            this.saveCommentsBtn.Size = new System.Drawing.Size(99, 62);
            this.saveCommentsBtn.TabIndex = 36;
            this.saveCommentsBtn.Text = "Save Comment";
            this.saveCommentsBtn.UseVisualStyleBackColor = false;
            this.saveCommentsBtn.Click += new System.EventHandler(this.saveCommentsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 37;
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
            // managerRefundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveCommentsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managerCommentBox);
            this.Controls.Add(this.ApproveBtn);
            this.Controls.Add(this.backToManagerDashboardBtn);
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.refundIDlbl);
            this.Controls.Add(this.dgvRefunds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "managerRefundsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "managerRefundsForm";
            this.Load += new System.EventHandler(this.managerRefundsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet16)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToManagerDashboardBtn;
        private System.Windows.Forms.Button rejectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label refundIDlbl;
        private System.Windows.Forms.DataGridView dgvRefunds;
        private System.Windows.Forms.Button ApproveBtn;
        private SedapMakanDBDataSet16 sedapMakanDBDataSet16;
        private System.Windows.Forms.BindingSource refundsBindingSource;
        private SedapMakanDBDataSet16TableAdapters.RefundsTableAdapter refundsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox managerCommentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveCommentsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}