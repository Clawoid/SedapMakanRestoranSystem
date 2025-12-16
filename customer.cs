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
using AdminRole6;
using SedapMakanRestoranSystem;

namespace OOP_Assignment_Customer_
{
    public partial class customer : Form
    {
        private int userID;
        private decimal ewalletBalance;

        public customer(int userID, decimal balance)
        {
            InitializeComponent();
            this.userID = userID;
            this.ewalletBalance = balance;
            LoadEwalletBalance(); // Load the e-wallet balance when the form is initialized  
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            custMenu menu = new custMenu(userID, ewalletBalance); // <-- pass both  
            menu.Show();
            this.Hide();
        }
        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            feedbackForm feedbackForm = new feedbackForm(userID); // <-- Fix: Replace 'currentUserID' with 'userID'  
            feedbackForm.Show();
            this.Hide();
        }
        private void LoadEwalletBalance()
        {
            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT EwalletBalance FROM Users WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID); // <-- Fix: Replace 'currentUserID' with 'userID'  

                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        throw new Exception("No EwalletBalance found for UserID: " + userID); // <-- Fix: Replace 'currentUserID' with 'userID'  
                    }

                    if (result != null)
                    {
                        ewalletBalance = Convert.ToDecimal(result); // <-- Fix: Replace 'currentEwalletBalance' with 'ewalletBalance'  
                        labelEwalletBalance.Text = $"E-wallet Balance: RM{ewalletBalance}"; // <-- Fix: Replace 'currentEwalletBalance' with 'ewalletBalance'  
                        label1.Text = $"Hey, User No. {userID}!"; // <-- Fix: Replace 'currentUserID' with 'userID'
                    }
                    else
                    {
                        MessageBox.Show("UserID not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching e-wallet balance: " + ex.Message);
            }
        }

        private void orderstatBtn_Click(object sender, EventArgs e)
        {
            // Fix: Ensure the correct type name is used for the form  
            orderStatus orderStatusFormInstance = new orderStatus(userID);
            orderStatusFormInstance.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Or this.Close(); if you prefer to fully close the form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            UpdateProfileForm profileForm = new UpdateProfileForm(userID);
            profileForm.Show();
        }
    }
}