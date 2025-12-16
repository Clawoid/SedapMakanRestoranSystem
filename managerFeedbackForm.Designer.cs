namespace SedapMakanRestoranSystem
{
    partial class managerFeedbackForm
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
            this.btnRespond = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.feedbackIDlbl = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.feedbackIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRespondedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.responseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbacksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedapMakanDBDataSet15 = new SedapMakanRestoranSystem.SedapMakanDBDataSet15();
            this.feedbacksTableAdapter = new SedapMakanRestoranSystem.SedapMakanDBDataSet15TableAdapters.FeedbacksTableAdapter();
            this.backToManagerDashboardBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet15)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRespond
            // 
            this.btnRespond.BackColor = System.Drawing.Color.DimGray;
            this.btnRespond.FlatAppearance.BorderSize = 0;
            this.btnRespond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRespond.Font = new System.Drawing.Font("Expo M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRespond.ForeColor = System.Drawing.Color.White;
            this.btnRespond.Location = new System.Drawing.Point(495, 343);
            this.btnRespond.Name = "btnRespond";
            this.btnRespond.Size = new System.Drawing.Size(118, 47);
            this.btnRespond.TabIndex = 26;
            this.btnRespond.Text = "Respond";
            this.btnRespond.UseVisualStyleBackColor = false;
            this.btnRespond.Click += new System.EventHandler(this.btnRespond_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Expo M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(67, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Response:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Expo M", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(253, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 53);
            this.label3.TabIndex = 23;
            this.label3.Text = "Feedbacks";
            // 
            // feedbackIDlbl
            // 
            this.feedbackIDlbl.AutoSize = true;
            this.feedbackIDlbl.Font = new System.Drawing.Font("Expo M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.feedbackIDlbl.Location = new System.Drawing.Point(67, 88);
            this.feedbackIDlbl.Name = "feedbackIDlbl";
            this.feedbackIDlbl.Size = new System.Drawing.Size(118, 18);
            this.feedbackIDlbl.TabIndex = 22;
            this.feedbackIDlbl.Text = "Feedback ID:";
            // 
            // txtResponse
            // 
            this.txtResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponse.Font = new System.Drawing.Font("Expo M", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtResponse.Location = new System.Drawing.Point(165, 343);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(324, 63);
            this.txtResponse.TabIndex = 20;
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.AutoGenerateColumns = false;
            this.dgvFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedbackIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.submissionDateDataGridViewTextBoxColumn,
            this.isRespondedDataGridViewCheckBoxColumn,
            this.responseDataGridViewTextBoxColumn,
            this.responseDateDataGridViewTextBoxColumn});
            this.dgvFeedback.DataSource = this.feedbacksBindingSource;
            this.dgvFeedback.Location = new System.Drawing.Point(70, 109);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 62;
            this.dgvFeedback.RowTemplate.Height = 28;
            this.dgvFeedback.Size = new System.Drawing.Size(667, 228);
            this.dgvFeedback.TabIndex = 18;
            this.dgvFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedback_CellContentClick);
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
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // submissionDateDataGridViewTextBoxColumn
            // 
            this.submissionDateDataGridViewTextBoxColumn.DataPropertyName = "SubmissionDate";
            this.submissionDateDataGridViewTextBoxColumn.HeaderText = "SubmissionDate";
            this.submissionDateDataGridViewTextBoxColumn.Name = "submissionDateDataGridViewTextBoxColumn";
            // 
            // isRespondedDataGridViewCheckBoxColumn
            // 
            this.isRespondedDataGridViewCheckBoxColumn.DataPropertyName = "IsResponded";
            this.isRespondedDataGridViewCheckBoxColumn.HeaderText = "IsResponded";
            this.isRespondedDataGridViewCheckBoxColumn.Name = "isRespondedDataGridViewCheckBoxColumn";
            // 
            // responseDataGridViewTextBoxColumn
            // 
            this.responseDataGridViewTextBoxColumn.DataPropertyName = "Response";
            this.responseDataGridViewTextBoxColumn.HeaderText = "Response";
            this.responseDataGridViewTextBoxColumn.Name = "responseDataGridViewTextBoxColumn";
            // 
            // responseDateDataGridViewTextBoxColumn
            // 
            this.responseDateDataGridViewTextBoxColumn.DataPropertyName = "ResponseDate";
            this.responseDateDataGridViewTextBoxColumn.HeaderText = "ResponseDate";
            this.responseDateDataGridViewTextBoxColumn.Name = "responseDateDataGridViewTextBoxColumn";
            // 
            // feedbacksBindingSource
            // 
            this.feedbacksBindingSource.DataMember = "Feedbacks";
            this.feedbacksBindingSource.DataSource = this.sedapMakanDBDataSet15;
            // 
            // sedapMakanDBDataSet15
            // 
            this.sedapMakanDBDataSet15.DataSetName = "SedapMakanDBDataSet15";
            this.sedapMakanDBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbacksTableAdapter
            // 
            this.feedbacksTableAdapter.ClearBeforeFill = true;
            // 
            // backToManagerDashboardBtn
            // 
            this.backToManagerDashboardBtn.BackColor = System.Drawing.Color.DimGray;
            this.backToManagerDashboardBtn.FlatAppearance.BorderSize = 0;
            this.backToManagerDashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToManagerDashboardBtn.Font = new System.Drawing.Font("Expo M", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.backToManagerDashboardBtn.ForeColor = System.Drawing.Color.White;
            this.backToManagerDashboardBtn.Location = new System.Drawing.Point(619, 343);
            this.backToManagerDashboardBtn.Name = "backToManagerDashboardBtn";
            this.backToManagerDashboardBtn.Size = new System.Drawing.Size(118, 47);
            this.backToManagerDashboardBtn.TabIndex = 27;
            this.backToManagerDashboardBtn.Text = "Back";
            this.backToManagerDashboardBtn.UseVisualStyleBackColor = false;
            this.backToManagerDashboardBtn.Click += new System.EventHandler(this.backToManagerDashboardBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
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
            // managerFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backToManagerDashboardBtn);
            this.Controls.Add(this.btnRespond);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feedbackIDlbl);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.dgvFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "managerFeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "managerFeedbackForm";
            this.Load += new System.EventHandler(this.managerFeedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedapMakanDBDataSet15)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRespond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label feedbackIDlbl;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private SedapMakanDBDataSet15 sedapMakanDBDataSet15;
        private System.Windows.Forms.BindingSource feedbacksBindingSource;
        private SedapMakanDBDataSet15TableAdapters.FeedbacksTableAdapter feedbacksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submissionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRespondedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backToManagerDashboardBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}