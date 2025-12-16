using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Assignment_Customer_
{
    public partial class custMenu : Form
    {
        List<CartItem> cartItems = new List<CartItem>();

        private int currentUserID;
        private decimal currentEwalletBalance;

        public custMenu(int userID, decimal ewalletBalance)
        {
            InitializeComponent();
            currentUserID = userID;
            currentEwalletBalance = ewalletBalance;

            dataGridViewMenu.CellContentClick += dataGridView1_CellContentClick;
        }


        // Load menu items on form load
        private void custMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet9.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.sedapMakanDBDataSet9.Menu);
            LoadMenuItems();

            dataGridViewMenu.ReadOnly = true;
            dataGridViewMenu.AllowUserToAddRows = false;
            dataGridViewMenu.AllowUserToDeleteRows = false;
            dataGridViewMenu.AllowUserToResizeRows = false;
            dataGridViewMenu.AllowUserToResizeColumns = false;

            dataGridViewMenu.CellClick += dataGridViewMenu_CellClick;
        }

        private void LoadMenuItems()
        {
            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        "SELECT MenuItemID, Name, Category, Price, Availability FROM Menu", conn);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewMenu.DataSource = table;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        // Prevent selecting unavailable items
        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewMenu.Rows[e.RowIndex];
                var cellValue = selectedRow.Cells[4].Value;

                if (cellValue != null && cellValue is bool available && !available)
                {
                    MessageBox.Show("This item is not available.", "Unavailable Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridViewMenu.ClearSelection();
                }
            }
        }

        private void addtocartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a menu item first.");
                return;
            }

            var selectedRow = dataGridViewMenu.SelectedRows[0];
            bool available = Convert.ToBoolean(selectedRow.Cells[4].Value);

            if (!available)
            {
                MessageBox.Show("This item is not available.");
                return;
            }

            int menuItemID = Convert.ToInt32(selectedRow.Cells[0].Value);
            string name = selectedRow.Cells[1].Value.ToString();
            decimal price = Convert.ToDecimal(selectedRow.Cells[3].Value); 
            int quantity = (int)numericUpDownQuantity.Value;


            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            // Check if item already in cart
            var existingItem = cartItems.Find(x => x.MenuItemID == menuItemID);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                MessageBox.Show($"Updated {name} quantity to {existingItem.Quantity}.");
            }
            else
            {
                CartItem item = new CartItem
                {
                    MenuItemID = menuItemID,
                    Name = name,
                    Quantity = quantity,
                    Price = price
                };

                cartItems.Add(item);
                MessageBox.Show($"{name} added to cart with quantity {quantity}.");
            }

            //clears selection and resets quantity to 1
            dataGridViewMenu.ClearSelection();
            numericUpDownQuantity.Value = 1;
        }


        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void viewCartBtn_Click(object sender, EventArgs e)
        {
            cartForm cartForm = new cartForm(cartItems,currentUserID,currentEwalletBalance);
            cartForm.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            customer cust = new customer(currentUserID, currentEwalletBalance);
            cust.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }
    }
}
