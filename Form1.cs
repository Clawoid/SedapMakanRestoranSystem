using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedapMakanRestoranSystem;

namespace AdminRole6
{
    public partial class AdminForm : Form
    {
        private int userId; // Store the userId for later use, e.g., in UpdateProfileForm
        public AdminForm(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Store the userId for later use, e.g., in UpdateProfileForm
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming 'User' is a type and you need to pass an instance of it to the UsersForm constructor.  
            // Replace 'userInstance' with the actual instance of 'User' you want to pass.  
            var userInstance = GetCurrentUser(); // Replace this with the actual method or logic to get the User instance.  
            var form = new UsersForm(userInstance);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new EWalletUsageForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new SalesReportForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Assuming 'User' is a type and you need to pass an instance of it to the UsersForm constructor.  
            var userInstance = GetCurrentUser(); // Replace this with the actual method or logic to get the User instance.  
            var form = new UsersForm(userInstance);
            form.Show();
        }

        // Example method to retrieve the current user instance. Replace this with your actual implementation.  
        private User GetCurrentUser()
        {
            // Logic to retrieve the current user instance.  
            return new User(); // Replace with actual user retrieval logic.  
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
            UpdateProfileForm profileForm = new UpdateProfileForm(userId);
            profileForm.Show();

        }
    }
}
