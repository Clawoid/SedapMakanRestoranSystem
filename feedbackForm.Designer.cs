namespace OOP_Assignment_Customer_
{
    partial class feedbackForm
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
            this.enterFeedbackLabel = new System.Windows.Forms.Label();
            this.feedbackMessageTxt = new System.Windows.Forms.TextBox();
            this.submitFeedbackBtn = new System.Windows.Forms.Button();
            this.dataGridViewFeedbacks = new System.Windows.Forms.DataGridView();
            this.feedbackIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRespondedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.responseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbacksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet5 = new SedapMakanRestoranSystem.SedapMakanDBDataSet5();
            this.previousFeedbackLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.feedbacksTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet5TableAdapters.FeedbacksTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.feedbackLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedbacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterFeedbackLabel
            // 
            this.enterFeedbackLabel.AutoSize = true;
            this.enterFeedbackLabel.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enterFeedbackLabel.Location = new System.Drawing.Point(334, 54);
            this.enterFeedbackLabel.Name = "enterFeedbackLabel";
            this.enterFeedbackLabel.Size = new System.Drawing.Size(134, 12);
            this.enterFeedbackLabel.TabIndex = 1;
            this.enterFeedbackLabel.Text = "Enter Your Feedback:";
            // 
            // feedbackMessageTxt
            // 
            this.feedbackMessageTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedbackMessageTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackMessageTxt.Location = new System.Drawing.Point(187, 69);
            this.feedbackMessageTxt.Multiline = true;
            this.feedbackMessageTxt.Name = "feedbackMessageTxt";
            this.feedbackMessageTxt.Size = new System.Drawing.Size(424, 81);
            this.feedbackMessageTxt.TabIndex = 2;
            // 
            // submitFeedbackBtn
            // 
            this.submitFeedbackBtn.BackColor = System.Drawing.Color.DimGray;
            this.submitFeedbackBtn.FlatAppearance.BorderSize = 0;
            this.submitFeedbackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitFeedbackBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.submitFeedbackBtn.ForeColor = System.Drawing.Color.White;
            this.submitFeedbackBtn.Location = new System.Drawing.Point(187, 156);
            this.submitFeedbackBtn.Name = "submitFeedbackBtn";
            this.submitFeedbackBtn.Size = new System.Drawing.Size(112, 37);
            this.submitFeedbackBtn.TabIndex = 3;
            this.submitFeedbackBtn.Text = "Submit Feedback";
            this.submitFeedbackBtn.UseVisualStyleBackColor = false;
            this.submitFeedbackBtn.Click += new System.EventHandler(this.submitFeedbackBtn_Click_1);
            // 
            // dataGridViewFeedbacks
            // 
            this.dataGridViewFeedbacks.AllowUserToAddRows = false;
            this.dataGridViewFeedbacks.AllowUserToDeleteRows = false;
            this.dataGridViewFeedbacks.AllowUserToResizeColumns = false;
            this.dataGridViewFeedbacks.AllowUserToResizeRows = false;
            this.dataGridViewFeedbacks.AutoGenerateColumns = false;
            this.dataGridViewFeedbacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFeedbacks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFeedbacks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFeedbacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeedbacks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedbackIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.submissionDateDataGridViewTextBoxColumn,
            this.isRespondedDataGridViewCheckBoxColumn,
            this.responseDataGridViewTextBoxColumn,
            this.responseDateDataGridViewTextBoxColumn});
            this.dataGridViewFeedbacks.DataSource = this.feedbacksBindingSource;
            this.dataGridViewFeedbacks.GridColor = System.Drawing.Color.Black;
            this.dataGridViewFeedbacks.Location = new System.Drawing.Point(30, 228);
            this.dataGridViewFeedbacks.Name = "dataGridViewFeedbacks";
            this.dataGridViewFeedbacks.ReadOnly = true;
            this.dataGridViewFeedbacks.Size = new System.Drawing.Size(740, 194);
            this.dataGridViewFeedbacks.TabIndex = 4;
            this.dataGridViewFeedbacks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFeedbacks_CellContentClick);
            // 
            // feedbackIDDataGridViewTextBoxColumn
            // 
            this.feedbackIDDataGridViewTextBoxColumn.DataPropertyName = "FeedbackID";
            this.feedbackIDDataGridViewTextBoxColumn.HeaderText = "FeedbackID";
            this.feedbackIDDataGridViewTextBoxColumn.Name = "feedbackIDDataGridViewTextBoxColumn";
            this.feedbackIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // submissionDateDataGridViewTextBoxColumn
            // 
            this.submissionDateDataGridViewTextBoxColumn.DataPropertyName = "SubmissionDate";
            this.submissionDateDataGridViewTextBoxColumn.HeaderText = "SubmissionDate";
            this.submissionDateDataGridViewTextBoxColumn.Name = "submissionDateDataGridViewTextBoxColumn";
            this.submissionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isRespondedDataGridViewCheckBoxColumn
            // 
            this.isRespondedDataGridViewCheckBoxColumn.DataPropertyName = "IsResponded";
            this.isRespondedDataGridViewCheckBoxColumn.HeaderText = "IsResponded";
            this.isRespondedDataGridViewCheckBoxColumn.Name = "isRespondedDataGridViewCheckBoxColumn";
            this.isRespondedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // responseDataGridViewTextBoxColumn
            // 
            this.responseDataGridViewTextBoxColumn.DataPropertyName = "Response";
            this.responseDataGridViewTextBoxColumn.HeaderText = "Response";
            this.responseDataGridViewTextBoxColumn.Name = "responseDataGridViewTextBoxColumn";
            this.responseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responseDateDataGridViewTextBoxColumn
            // 
            this.responseDateDataGridViewTextBoxColumn.DataPropertyName = "ResponseDate";
            this.responseDateDataGridViewTextBoxColumn.HeaderText = "ResponseDate";
            this.responseDateDataGridViewTextBoxColumn.Name = "responseDateDataGridViewTextBoxColumn";
            this.responseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feedbacksBindingSource
            // 
            this.feedbacksBindingSource.DataMember = "Feedbacks";
            this.feedbacksBindingSource.DataSource = this.sedapMakanDBDataSet5;
            // 
            // sedapMakanDBDataSet5
            // 
            this.sedapMakanDBDataSet5.DataSetName = "SedapMakanDBDataSet5";
            this.sedapMakanDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // previousFeedbackLabel
            // 
            this.previousFeedbackLabel.AutoSize = true;
            this.previousFeedbackLabel.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.previousFeedbackLabel.Location = new System.Drawing.Point(345, 213);
            this.previousFeedbackLabel.Name = "previousFeedbackLabel";
            this.previousFeedbackLabel.Size = new System.Drawing.Size(122, 12);
            this.previousFeedbackLabel.TabIndex = 5;
            this.previousFeedbackLabel.Text = "Previous Feedbacks";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DimGray;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(499, 156);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(112, 37);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // feedbacksTableAdapter
            // 
            this.feedbacksTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.feedbackLbl);
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
            // feedbackLbl
            // 
            this.feedbackLbl.AutoSize = true;
            this.feedbackLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.feedbackLbl.Font = new System.Drawing.Font("Expo M", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.feedbackLbl.ForeColor = System.Drawing.Color.White;
            this.feedbackLbl.Location = new System.Drawing.Point(0, 0);
            this.feedbackLbl.Name = "feedbackLbl";
            this.feedbackLbl.Size = new System.Drawing.Size(272, 32);
            this.feedbackLbl.TabIndex = 26;
            this.feedbackLbl.Text = "View Feedbacks";
            this.feedbackLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.previousFeedbackLabel);
            this.Controls.Add(this.dataGridViewFeedbacks);
            this.Controls.Add(this.submitFeedbackBtn);
            this.Controls.Add(this.feedbackMessageTxt);
            this.Controls.Add(this.enterFeedbackLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "feedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "feedbackForm";
            this.Load += new System.EventHandler(this.feedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedbacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label enterFeedbackLabel;
        private System.Windows.Forms.TextBox feedbackMessageTxt;
        private System.Windows.Forms.Button submitFeedbackBtn;
        private System.Windows.Forms.DataGridView dataGridViewFeedbacks;
        private System.Windows.Forms.Label previousFeedbackLabel;
        private System.Windows.Forms.Button backBtn;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet5 sedapMakanDBDataSet5;
        private System.Windows.Forms.BindingSource feedbacksBindingSource;
        private SedapMakanRestoranSystem.SedapMakanDBDataSet5TableAdapters.FeedbacksTableAdapter feedbacksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRespondedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label feedbackLbl;
    }
}