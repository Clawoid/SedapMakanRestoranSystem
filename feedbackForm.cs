using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP_Assignment_Customer_
{
    public partial class feedbackForm : Form
    {
        private int currentUserId;
        private string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

        public feedbackForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }

        private void feedbackForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet5.Feedbacks' table. You can move, or remove it, as needed.
            this.feedbacksTableAdapter.Fill(this.sedapMakanDBDataSet5.Feedbacks);
            LoadFeedbackHistory();
        }


        private void LoadFeedbackHistory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT Message, SubmissionDate, IsResponded, Response, ResponseDate FROM Feedbacks WHERE CustomerId = @CustomerId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerId", currentUserId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewFeedbacks.DataSource = dt;
                    dataGridViewFeedbacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewFeedbacks.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback history: " + ex.Message);
            }
        }
        private void dataGridViewFeedbacks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Assuming the 'customer' class requires both 'userID' and 'balance' as parameters,  
            // you need to provide a valid 'balance' value.  
            // If 'balance' is stored in the database or calculated elsewhere, retrieve it accordingly.  
            decimal balance = GetEwalletBalance(currentUserId); // Replace with actual logic to fetch balance.  
            customer cust = new customer(currentUserId, balance);
            cust.Show();
            this.Hide();
        }

        private decimal GetEwalletBalance(int userId)
        {
            // Example logic to fetch e-wallet balance from the database.  
            decimal balance = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT EwalletBalance FROM Customers WHERE CustomerId = @CustomerId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerId", userId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        balance = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching e-wallet balance: " + ex.Message);
            }
            return balance;
        }

        private void submitFeedbackBtn_Click_1(object sender, EventArgs e)
        {
            string message = feedbackMessageTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please enter your feedback message.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO Feedbacks (CustomerId, Message, SubmissionDate, IsResponded)
                                           VALUES (@CustomerId, @Message, @SubmissionDate, 0)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@CustomerId", currentUserId);
                    cmd.Parameters.AddWithValue("@Message", message);
                    cmd.Parameters.AddWithValue("@SubmissionDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Feedback submitted successfully!");
                feedbackMessageTxt.Clear();
                LoadFeedbackHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting feedback: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }
    }
}
