using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SedapMakanRestoranSystem
{
    public partial class managerFeedbackForm : Form
    {
        // Connection string field
        private readonly string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";
        private int userId;

        public managerFeedbackForm(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Fixed syntax error and corrected variable name
            LoadFeedback(); // Load feedbacks on form load
        }

        private void managerFeedbackForm_Load(object sender, EventArgs e)
        {
            // Load feedbacks from dataset (can be replaced with LoadFeedback if preferred)
            this.feedbacksTableAdapter.Fill(this.sedapMakanDBDataSet15.Feedbacks);
        }

        private void btnRespond_Click(object sender, EventArgs e)
        {
            if (int.TryParse(feedbackIDlbl.Text, out int feedbackId) && !string.IsNullOrWhiteSpace(txtResponse.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Feedback SET ManagerResponse=@Response, IsRead=1 WHERE FeedbackID=@FeedbackID", conn);
                    cmd.Parameters.AddWithValue("@Response", txtResponse.Text);
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Response submitted.");
                LoadFeedback();
            }
            else
            {
                MessageBox.Show("Enter a valid Feedback ID and response.");
            }
        }

        private void backToManagerDashboardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvFeedback.Rows[e.RowIndex];

                // Automatically fill Feedback ID label
                feedbackIDlbl.Text = selectedRow.Cells[0].Value.ToString();

                // Optional: fill response textbox if ManagerResponse exists
                txtResponse.Text = selectedRow.Cells["ManagerResponse"].Value?.ToString();
            }
        }

        private void LoadFeedback()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Feedbacks", conn);
                DataTable feedbacksTable = new DataTable();
                adapter.Fill(feedbacksTable);
                dgvFeedback.DataSource = feedbacksTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }
    }
}
