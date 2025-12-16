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

namespace SedapMakanRestoranSystem
{

    public partial class managerCustomerTopUpForm : Form
    {
        // Define the connection string as a private field  
        private readonly string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

        public managerCustomerTopUpForm()
        {
            InitializeComponent();
            this.dgvTopUp.CellClick += new DataGridViewCellEventHandler(this.dgvTopUp_CellClick);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void managerCustomerTopUpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet18.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.sedapMakanDBDataSet18.Users);
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet17.Customers' table. You can move, or remove it, as needed.  
        }

        private void topupButton_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId != -1 && decimal.TryParse(amountTextBox.Text, out decimal amount))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET EWalletBalance = EWalletBalance + @Amount WHERE UserID = @CustomerID", conn);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Top-up successful.");
            }
            else
            {
                MessageBox.Show("Please select a customer and enter a valid amount.");
            }
        }


        private int selectedCustomerId = -1;

        private void dgvTopUp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTopUp.Rows[e.RowIndex];
                if (int.TryParse(row.Cells[0].Value.ToString(), out int customerId))
                {
                    selectedCustomerId = customerId;
                    customeridLabel.Text = $"Selected Customer ID: {selectedCustomerId}";

                    // DEBUGGING LINE
                    MessageBox.Show($"Customer ID selected: {selectedCustomerId}");
                }
            }
        }

        private void backToDashboardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
