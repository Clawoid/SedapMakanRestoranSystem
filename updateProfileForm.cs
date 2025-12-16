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
using System.Xml.Linq;

namespace SedapMakanRestoranSystem
{

    public partial class UpdateProfileForm : Form
    {

        private int userId;
        private string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

        public UpdateProfileForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Name, Email, Password FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get the current email from the database
                string currentEmail = "";
                string getEmailQuery = "SELECT Email FROM Users WHERE UserID = @UserID";
                SqlCommand getEmailCmd = new SqlCommand(getEmailQuery, conn);
                getEmailCmd.Parameters.AddWithValue("@UserID", userId);
                object emailResult = getEmailCmd.ExecuteScalar();
                if (emailResult != null)
                    currentEmail = emailResult.ToString();

                // If email was changed, check if it's already taken
                if (txtEmail.Text != currentEmail)
                {
                    string checkEmail = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    SqlCommand checkCmd = new SqlCommand(checkEmail, conn);
                    checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This email is already in use by another account.");
                        return;
                    }
                }

                // Update profile
                string updateQuery = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password WHERE UserID = @UserID";
                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@Name", txtName.Text);
                updateCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                updateCmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                updateCmd.Parameters.AddWithValue("@UserID", userId);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Profile updated successfully.");
                this.Close(); // Close form after save
            }
        }

    }
}
