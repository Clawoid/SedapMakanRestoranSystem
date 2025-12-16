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

namespace AdminRole6
{
    public partial class AddRemoveUpdateUsersForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public AddRemoveUpdateUsersForm()
        {
            InitializeComponent();
            UpdateBtn.Text = "Add New User";
            DeleteBtn.Visible = false;
            lblID.Text = "New User";
        }

        public AddRemoveUpdateUsersForm(User user)
        {
            InitializeComponent();
            UpdateBtn.Text = "Update User";
            DeleteBtn.Visible = true;
            lblID.Text = user.UserID.ToString();
            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password; // Optionally show password for editing
            roleComboBox.SelectedItem = user.Role;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "New User")
            {
                MessageBox.Show("No user selected to delete.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserId = @UserId", connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", lblID.Text);
                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "New User")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Name, Email, Password, Role) VALUES (@Name, @Email, @Password, @Role)", connection);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Role", roleComboBox.SelectedItem?.ToString());
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New User added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Users SET Name = @Name, Email = @Email, Password = @Password, Role = @Role WHERE UserId = @UserId", connection);
                cmd.Parameters.AddWithValue("@UserId", lblID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Role", roleComboBox.SelectedItem.ToString());
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void returnToUsersBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
