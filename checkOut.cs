using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_Assignment_Customer_
{
    public partial class checkOut : Form
    {
        private List<CartItem> cartItems;
        private int userID;
        private decimal ewalletBalance;

        public checkOut(List<CartItem> items, int userID, decimal ewalletBalance)
        {
            InitializeComponent();
            this.cartItems = items;
            this.userID = userID;
            this.ewalletBalance = ewalletBalance;

            this.Load += checkOut_Load;
        }

        private void checkOut_Load(object sender, EventArgs e)
        {
            decimal total = 0;
            StringBuilder summary = new StringBuilder();
            summary.AppendLine("Items in your order:\n");

            foreach (var item in cartItems)
            {
                decimal itemTotal = item.Price * item.Quantity;
                summary.AppendLine($"{item.Name} - Qty: {item.Quantity} @ RM{item.Price:0.00} = RM{itemTotal:0.00}");
                total += itemTotal;
            }

            summary.AppendLine($"\nTotal Amount: RM{total:0.00}");
            richTextBoxSummary.Text = summary.ToString();
            labelEwalletBalance.Text = $"E-wallet Balance: RM{ewalletBalance:0.00}";
            labelEwalletBalance.Tag = ewalletBalance; // Store in Tag for later use
        }

        // Fix for CS7036: Pass the required 'balance' parameter when creating the 'customer' instance.  
        private void confirmpurchaseBtn_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            decimal currentBalance = (decimal)labelEwalletBalance.Tag;
            decimal totalAmount = cartItems.Sum(i => i.Price * i.Quantity);

            if (totalAmount > currentBalance)
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Insert orders  
                        foreach (var item in cartItems)
                        {
                            string orderQuery = "INSERT INTO Orders (CustomerID, MenuItemID, Quantity, Status, OrderTime) " +
                                                "VALUES (@CustomerID, @MenuItemID, @Quantity, @Status, @OrderTime)";
                            SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction);
                            orderCmd.Parameters.AddWithValue("@CustomerID", userID);
                            orderCmd.Parameters.AddWithValue("@MenuItemID", item.MenuItemID);
                            orderCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                            orderCmd.Parameters.AddWithValue("@Status", "Pending");
                            orderCmd.Parameters.AddWithValue("@OrderTime", DateTime.Now);
                            orderCmd.ExecuteNonQuery();
                        }

                        // Update e-wallet balance  
                        decimal newBalance = currentBalance - totalAmount;
                        string updateBalanceQuery = "UPDATE Users SET EwalletBalance = @NewBalance WHERE UserID = @UserID";
                        SqlCommand balanceCmd = new SqlCommand(updateBalanceQuery, conn, transaction);
                        balanceCmd.Parameters.AddWithValue("@NewBalance", newBalance);
                        balanceCmd.Parameters.AddWithValue("@UserID", userID);
                        balanceCmd.ExecuteNonQuery();

                        // Insert e-wallet transaction  
                        string walletTxnQuery = "INSERT INTO EwalletTransactions (CustomerId, Amount, TransactionType, TransactionDate) " +
                                                "VALUES (@CustomerId, @Amount, @Type, @TransactionDate)";
                        SqlCommand txnCmd = new SqlCommand(walletTxnQuery, conn, transaction);
                        txnCmd.Parameters.AddWithValue("@CustomerId", userID);
                        txnCmd.Parameters.AddWithValue("@Amount", -totalAmount);
                        txnCmd.Parameters.AddWithValue("@Type", "Purchase");
                        txnCmd.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                        txnCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Purchase successful!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Transaction failed: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during checkout: " + ex.Message);
            }

            // Pass the required userID and ewalletBalance parameters to the customer constructor  
            customer cust = new customer(userID, currentBalance - totalAmount);
            cust.Show();
        }

        private void labelEwalletBalance_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            cartForm cartForm = new cartForm(cartItems, userID, ewalletBalance);
            cartForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }
    }
}
