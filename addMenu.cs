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

namespace OOP_Assignment__Chef_
{

    public partial class addMenu : Form
    {
        private OOP_Assignment_Customer_.MenuItems currentMenu = null;
        private manageMenu parentForm;

        public addMenu(manageMenu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            addBtn.Enabled = true;
            updBtn.Enabled = false;
            removeBtn.Enabled = false;
            currentMenu = null;
        }

        public addMenu(manageMenu parent, OOP_Assignment_Customer_.MenuItems menu)
        {
            InitializeComponent();
            this.parentForm = parent;
            currentMenu = menu;

            itmName.Text = menu.Name;
            itmCategory.Text = menu.Category;
            itmPrice.Text = menu.Price.ToString();
            itmAvailability.Checked = menu.Availability;
            addBtn.Enabled = false;
            updBtn.Enabled = true;
            removeBtn.Enabled = true;
        }

        private void addMenu_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    string query = "INSERT INTO Menu (Name, Category, Price, Availability) VALUES (@Name, @Category, @Price, @Availability)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", itmName.Text);
                        cmd.Parameters.AddWithValue("@Category", itmCategory.Text);
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(itmPrice.Text));
                        cmd.Parameters.AddWithValue("@Availability", itmAvailability.Checked);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Menu item added successfully!");
                        parentForm.RefreshMenuItems();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding menu item: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (currentMenu == null)
            {
                MessageBox.Show("No menu item selected to remove.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this menu item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Menu WHERE MenuItemID = @MenuItemID", conn);
                        cmd.Parameters.AddWithValue("@MenuItemID", currentMenu.MenuItemID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Menu item deleted successfully!");
                        parentForm.RefreshMenuItems();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting menu item: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void itmName_TextChanged(object sender, EventArgs e)
        {

        }

        private void updBtn_Click(object sender, EventArgs e)
        {
            if (currentMenu == null) return;

            // Validate price input  
            if (!decimal.TryParse(itmPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price (numbers only).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Menu SET Name = @Name, Category = @Category, Price = @Price, Availability = @Availability WHERE MenuItemID = @MenuItemID", conn);
                    cmd.Parameters.AddWithValue("@MenuItemID", currentMenu.MenuItemID);
                    cmd.Parameters.AddWithValue("@Name", itmName.Text);
                    cmd.Parameters.AddWithValue("@Category", itmCategory.Text);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Availability", itmAvailability.Checked);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Menu item updated successfully!");
                }

                parentForm.RefreshMenuItems();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating menu: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
