using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Assignment_Customer_
{

    public partial class orderStatus : Form
    {
        private int selectedOrderIdForRefund = -1;

        private int currentUserID;
        public orderStatus(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
        }

        private void LoadOrderAndRefundData()
        {
            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Load Orders
                SqlDataAdapter orderAdapter = new SqlDataAdapter(
                    @"SELECT o.OrderID, o.MenuItemID, m.Name, m.Price, o.Quantity, o.Status, o.OrderTime 
                    FROM Orders o 
                    INNER JOIN Menu m ON o.MenuItemID = m.MenuItemID 
                    WHERE o.CustomerID = @UserID", conn);
                orderAdapter.SelectCommand.Parameters.AddWithValue("@UserID", currentUserID);

                DataTable orderTable = new DataTable();
                orderAdapter.Fill(orderTable);
                dataGridViewOrderStatus.DataSource = orderTable;

                // Load Refunds
                SqlDataAdapter refundAdapter = new SqlDataAdapter(
                    "SELECT RefundId, OrderId, Amount, Reason, RequestDate, Status, ManagerComment FROM Refunds WHERE CustomerId = @UserID", conn);
                refundAdapter.SelectCommand.Parameters.AddWithValue("@UserID", currentUserID);

                DataTable refundTable = new DataTable();
                refundAdapter.Fill(refundTable);
                dataGridViewRefundStatus.DataSource = refundTable;
            }

            dataGridViewOrderStatus.ClearSelection();
            dataGridViewRefundStatus.ClearSelection();
        }

        private void orderStatus_Load(object sender, EventArgs e)
        {
            LoadOrderAndRefundData();
            LoadRefundStatus();
            refundTextLabel.Visible = false;
            refundReasonTxt.Visible = false;
            submitRefundBtn.Visible = false;
        }

        private void dataGridViewOrderStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewRefundStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refundBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to request a refund.");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewOrderStatus.SelectedRows[0];
            string orderStatus = selectedRow.Cells["Status"].Value.ToString();

            if (orderStatus != "Completed")
            {
                MessageBox.Show("Refunds can only be requested for completed orders.");
                return;
            }

            selectedOrderIdForRefund = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);

            refundLabel.Visible = true;
            refundTextLabel.Visible = true;
            refundReasonTxt.Visible = true;
            submitRefundBtn.Visible = true;
            refundReasonTxt.Text = ""; // clear any previous text
        }


        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to cancel.");
                return;
            }

            int selectedOrderId = Convert.ToInt32(dataGridViewOrderStatus.SelectedRows[0].Cells["OrderID"].Value);
            string currentStatus = dataGridViewOrderStatus.SelectedRows[0].Cells["Status"].Value.ToString();

            if (currentStatus != "Pending")
            {
                MessageBox.Show("Only pending orders can be cancelled.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancellation", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string updateQuery = "UPDATE Orders SET Status = @Status WHERE OrderID = @OrderID AND CustomerID = @CustomerID";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Status", "Cancelled");
                    cmd.Parameters.AddWithValue("@OrderID", selectedOrderId);
                    cmd.Parameters.AddWithValue("@CustomerID", currentUserID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order cancelled successfully.");
                        LoadOrderAndRefundData(); // Refresh
                    }
                    else
                    {
                        MessageBox.Show("Order cancellation failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling order: " + ex.Message);
            }
        }

        private void refundReasonTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadRefundStatus()
        {
            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT RefundId, OrderId, Amount, Reason, RequestDate, Status, ManagerComment " +
                                   "FROM Refunds WHERE CustomerId = @CustomerId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerId", currentUserID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable refundTable = new DataTable();
                    adapter.Fill(refundTable);

                    dataGridViewRefundStatus.DataSource = refundTable;

                    // Optional formatting
                    dataGridViewRefundStatus.ReadOnly = true;
                    dataGridViewRefundStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading refund status: " + ex.Message);
            }
        }


        private void submitRefundBtn_Click(object sender, EventArgs e)
        {
            if (selectedOrderIdForRefund == -1)
            {
                MessageBox.Show("No order selected for refund.");
                return;
            }

            string reason = refundReasonTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show("Please enter a reason for the refund.");
                return;
            }

            decimal refundAmount = 0;

            // Find the selected order's quantity and price
            foreach (DataGridViewRow row in dataGridViewOrderStatus.Rows)
            {
                if (row.Cells["OrderID"].Value != null && Convert.ToInt32(row.Cells["OrderID"].Value) == selectedOrderIdForRefund)
                {
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    refundAmount = quantity * price;
                    break;
                }
            }

            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    //Check if refund already exists
                    string checkQuery = "SELECT COUNT(*) FROM Refunds WHERE OrderId = @OrderId AND CustomerId = @CustomerId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@OrderId", selectedOrderIdForRefund);
                    checkCmd.Parameters.AddWithValue("@CustomerId", currentUserID);

                    int existingRefunds = (int)checkCmd.ExecuteScalar();
                    if (existingRefunds > 0)
                    {
                        MessageBox.Show("You have already requested a refund for this order.");
                        return;
                    }

                    //Insert refund request
                    string insertQuery = "INSERT INTO Refunds (OrderId, CustomerId, Amount, Reason, RequestDate, Status) " +
                                         "VALUES (@OrderId, @CustomerId, @Amount, @Reason, @RequestDate, @Status)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@OrderId", selectedOrderIdForRefund);
                    insertCmd.Parameters.AddWithValue("@CustomerId", currentUserID);
                    insertCmd.Parameters.AddWithValue("@Amount", refundAmount);
                    insertCmd.Parameters.AddWithValue("@Reason", reason);
                    insertCmd.Parameters.AddWithValue("@RequestDate", DateTime.Now);
                    insertCmd.Parameters.AddWithValue("@Status", "Pending");

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Refund request submitted.");

                    //Refresh Refund grid
                    LoadRefundStatus();
                    LoadOrderAndRefundData(); //also refresh orders

                    //Hide refund inputs
                    refundTextLabel.Visible = false;
                    refundReasonTxt.Visible = false;
                    submitRefundBtn.Visible = false;
                    refundReasonTxt.Text = "";

                    selectedOrderIdForRefund = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting refund: " + ex.Message);
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            // Assuming the 'customer' class requires both 'userID' and 'balance' as parameters,  
            // you need to pass the 'balance' value along with 'currentUserID'.  
            // If 'balance' is not available in this context, you need to retrieve it or ask for clarification.  

            decimal ewalletBalance = GetEwalletBalance(currentUserID); // Replace with actual method to fetch balance.  
            customer cust = new customer(currentUserID, ewalletBalance); // Pass both required parameters.  
            cust.Show();
            this.Hide();
        }

        private decimal GetEwalletBalance(int userID)
        {
            // Example method to fetch e-wallet balance. Replace with actual implementation.  
            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";
            decimal balance = 0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT EwalletBalance FROM Customers WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", userID);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    balance = Convert.ToDecimal(result);
                }
            }

            return balance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }
    }
}
