using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AdminRole6;
using SedapMakanRestoranSystem;

namespace SedapMakanManagementSystem
{
    public partial class ManagerDashboard : Form
    {
        private int userId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public ManagerDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }
        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            var feedbackForm = new managerFeedbackForm(userId);
            feedbackForm.Show();
        }

        private void refundsBtn_Click(object sender, EventArgs e)
        {
            var refundForm = new managerRefundsForm(userId);
            refundForm.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            UpdateProfileForm profileForm = new UpdateProfileForm(userId);
            profileForm.Show();
        }

        private void topupBtn_Click(object sender, EventArgs e)
        {
            var topUpForm = new managerCustomerTopUpForm();
            topUpForm.Show();
        }
    }
}
