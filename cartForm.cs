using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Assignment_Customer_
{
    public partial class cartForm : Form
    {
        private List<CartItem> cartItems;
        private int currentUserID;
        private decimal currentEwalletBalance;

        public cartForm(List<CartItem> items, int userID, decimal ewalletBalance)
        {
            InitializeComponent();
            cartItems = items;
            currentUserID = userID;
            currentEwalletBalance = ewalletBalance;
            this.Load += cartForm_Load;
        }

        private void cartForm_Load(object sender, EventArgs e)
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = cartItems;
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RefreshCartGrid();
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshCartGrid()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = cartItems;
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            labelTotal.Text = $"Total: RM{cartItems.Sum(i => i.Quantity * i.Price):0.00}";
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            int selectedIndex = dataGridViewCart.SelectedRows[0].Index;
            cartItems.RemoveAt(selectedIndex);
            RefreshCartGrid();
        }

        private void updateQtyBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }

            int newQty = (int)numericUpDownUpdateQty.Value;
            if (newQty <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.");
                return;
            }

            CartItem selectedItem = (CartItem)dataGridViewCart.SelectedRows[0].DataBoundItem;
            selectedItem.Quantity = newQty;
            RefreshCartGrid();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            custMenu custMenu = new custMenu(currentUserID, currentEwalletBalance);
            custMenu.Show();
            this.Hide();
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            checkOut checkoutForm = new checkOut(cartItems, currentUserID, currentEwalletBalance);
            checkoutForm.ShowDialog();
            this.Hide();
        }

        private void cartForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet12.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.sedapMakanDBDataSet12.Menu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }
    }
}
