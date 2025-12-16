using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminRole6;
using SedapMakanRestoranSystem;

namespace OOP_Assignment__Chef_
{
    public partial class chefDash : Form
    {
        private int userId;

        public chefDash(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Store the user ID for later use, e.g., in UpdateProfileForm
        }

        public chefDash()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); // Ensure LoginForm exists in the correct namespace  
            loginForm.Show(); // Corrected reference to LoginForm instance  
            this.Close();
        }

        private void manageMenu_btn_Click(object sender, EventArgs e)
        {
            manageMenu manageForm = new manageMenu();
            manageForm.Show();
            this.Hide();
        }

        private void viewOrder_btn_Click(object sender, EventArgs e)
        {
            viewOrders viewOrders = new viewOrders();
            viewOrders.Show();
            this.Hide();
        }

        private void chefDash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
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
