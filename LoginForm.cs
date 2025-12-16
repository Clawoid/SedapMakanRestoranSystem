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
using OOP_Assignment__Chef_;
using OOP_Assignment_Customer_;
using SedapMakanManagementSystem;

namespace AdminRole6
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT UserID, Name, Role, EwalletBalance FROM Users WHERE Email = @Email AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["UserID"]);
                        string name = reader["Name"].ToString();
                        string role = reader["Role"].ToString().ToLower();

                        MessageBox.Show($"Welcome, {name}!", "Login Successful");

                        this.Hide(); // Hide login form  

                        Form nextform = null;

                        if (role == "admin")
                        {
                            nextform = new AdminForm(userId);
                        }
                        else if (role == "chef")
                        {
                            nextform = new chefDash(userId); // Change this to `ChefDashboardForm(userId)` if you have it  
                        }
                        else if (role == "customer")
                        {
                            reader.Close(); // Close the current reader before executing another command  

                            // Fetch e-wallet balance  
                            string balanceQuery = "SELECT EwalletBalance FROM Users WHERE UserID = @UserID";
                            SqlCommand balanceCmd = new SqlCommand(balanceQuery, conn);
                            balanceCmd.Parameters.AddWithValue("@UserID", userId);
                            decimal ewalletBalance = (decimal)balanceCmd.ExecuteScalar();

                            nextform = new customer(userId, ewalletBalance); // <-- update constructor  
                        }
                        else if (role == "manager")
                        {
                            nextform = new ManagerDashboard(userId); // ✅ if your constructor only needs userId

                        }
                        else
                        {
                            MessageBox.Show("Unknown role. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        nextform.Show(); // ✅ Don't forget this line  
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
    
}