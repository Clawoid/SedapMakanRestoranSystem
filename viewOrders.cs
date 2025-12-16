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

namespace OOP_Assignment__Chef_
{
    public partial class viewOrders : Form
    {
        public viewOrders()
        {
            InitializeComponent();
        }

        private void LoadOrders()
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Orders";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable ordersTable = new DataTable();
                adapter.Fill(ordersTable);
                dataGridViewOrders.DataSource = ordersTable;
            }
        }


        private void viewOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet14.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.sedapMakanDBDataSet14.Orders);
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet4.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.sedapMakanDBDataSet4.Orders);
            LoadOrders();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            chefDash chefDash = new chefDash();
            chefDash.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateStatus_btn_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to update.", "No Order Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(statusDropdown.Text))
            {
                MessageBox.Show("Please select a status to update.", "No Status Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
            int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);
            string newStatus = statusDropdown.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate   =True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Orders SET Status = @Status WHERE OrderID = @OrderID", conn);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order status updated successfully!");
                        LoadOrders();
                    }
                    else
                    {
                        MessageBox.Show("No rows updated. Please check the OrderID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application when the exit button is clicked
        }
    }
}
