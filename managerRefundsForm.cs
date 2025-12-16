using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminRole6;

namespace SedapMakanRestoranSystem
{
    public partial class managerRefundsForm : Form
    {
        private int userId;
        public managerRefundsForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void RefreshRefunds()
        {
            this.refundsTableAdapter.Fill(this.sedapMakanDBDataSet16.Refunds);
        }

        private void managerRefundsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet16.Refunds' table. You can move, or remove it, as needed.
            this.refundsTableAdapter.Fill(this.sedapMakanDBDataSet16.Refunds);

        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(refundIDlbl.Text, out int refundId))
            {
                string connStr = "Data Source=localhost;Initial Catalog=SedapMakanDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Get Refund Amount and Customer ID
                    SqlCommand getDetails = new SqlCommand("SELECT CustomerID, Amount FROM Refunds WHERE RefundID = @RefundID", conn);
                    getDetails.Parameters.AddWithValue("@RefundID", refundId);
                    SqlDataReader reader = getDetails.ExecuteReader();

                    if (reader.Read())
                    {
                        int customerId = Convert.ToInt32(reader["CustomerID"]);
                        decimal amount = Convert.ToDecimal(reader["RefundAmount"]);
                        reader.Close();

                        // 1. Approve Refund
                        SqlCommand approveRefund = new SqlCommand("UPDATE RefundRequests SET Status = 'Approved' WHERE RefundID = @RefundID", conn);
                        approveRefund.Parameters.AddWithValue("@RefundID", refundId);
                        approveRefund.ExecuteNonQuery();

                        // 2. Add to Wallet
                        SqlCommand topUpWallet = new SqlCommand("UPDATE Users SET WalletBalance = WalletBalance + @Amount WHERE UserID = @CustomerID", conn);
                        topUpWallet.Parameters.AddWithValue("@Amount", amount);
                        topUpWallet.Parameters.AddWithValue("@CustomerID", customerId);
                        topUpWallet.ExecuteNonQuery();

                        MessageBox.Show("Refund approved and amount returned to customer.");
                    }
                    else
                    {
                        MessageBox.Show("Refund not found.");
                    }
                }

                RefreshRefunds();
            }
            else
            {
                MessageBox.Show("Select a valid Refund ID.");
            }
        }


        private void rejectBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(refundIDlbl.Text, out int refundId))
            {
                string connStr = "Data Source=localhost;Initial Catalog=SedapMakanDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand rejectCmd = new SqlCommand("UPDATE Refunds SET Status = 'Rejected' WHERE RefundID = @RefundID", conn);
                    rejectCmd.Parameters.AddWithValue("@RefundID", refundId);
                    rejectCmd.ExecuteNonQuery();

                    MessageBox.Show("Refund rejected.");
                }

                RefreshRefunds();
            }
            else
            {
                MessageBox.Show("Select a valid Refund ID.");
            }
        }


        private void backToManagerDashboardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRefunds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRefunds.Rows[e.RowIndex];
                refundIDlbl.Text = row.Cells["RefundID"].Value.ToString();
            }
        }

        private void saveCommentsBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(refundIDlbl.Text, out int refundId))
            {
                string comment = managerCommentBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(comment))
                {
                    MessageBox.Show("Comment cannot be empty.");
                    return;
                }

                string connectionString = "Data Source=localhost;Initial Catalog=SedapMakanDB;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Refunds SET ManagerComment = @Comment WHERE RefundID = @RefundID", conn);
                    cmd.Parameters.AddWithValue("@Comment", comment);
                    cmd.Parameters.AddWithValue("@RefundID", refundId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Comment saved successfully.");
                RefreshRefunds(); // Optional: reload DataGridView
            }
            else
            {
                MessageBox.Show("Please select or enter a valid Refund ID.");
            }
        }

        private void LoadRefunds()
        {
            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT RefundID FROM Refunds WHERE RefundID = @RefundID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Fix: Define 'refundID' variable and assign a valid value
                    int refundID = int.Parse(refundIDlbl.Text); // Assuming 'refundIDlbl' contains the RefundID value
                    cmd.Parameters.AddWithValue("@RefundID", refundID);

                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        throw new Exception("No RefundID found for RefundID: " + refundID);
                    }

                    if (result != null)
                    {
                        decimal ewalletBalance = Convert.ToDecimal(result);
                        refundIDlbl.Text = $"Refund ID= {refundID}";
                    }
                    else
                    {
                        MessageBox.Show("RefundID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching RefundID balance: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
