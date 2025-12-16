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
    public partial class EWalletUsageForm : Form
    {
        public EWalletUsageForm()
        {
            InitializeComponent();

        }

        private void ewalletSearchBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
        SELECT 
            e.TransactionId,
            e.CustomerId AS UserID,
            u.Name AS CustomerName,
            e.TransactionType,
            e.Amount,
            e.TransactionDate
        FROM EWalletTransactions e
        JOIN Users u ON e.CustomerId = u.UserID
        WHERE
            (@UserID IS NULL OR e.CustomerId = @UserID) AND
            (@MonthYear IS NULL OR FORMAT(e.TransactionDate, 'yyyy-MM') = @MonthYear)
        ORDER BY e.TransactionDate DESC;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Validate CustomerID
                    object userIDParam;
                    if (string.IsNullOrWhiteSpace(customerSearchBox.Text))
                    {
                        userIDParam = DBNull.Value;
                    }
                    else if (int.TryParse(customerSearchBox.Text, out int parsedUserID))
                    {
                        userIDParam = parsedUserID;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid numeric Customer ID (UserID).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cmd.Parameters.AddWithValue("@UserID", userIDParam);
                    cmd.Parameters.AddWithValue("@MonthYear", ewalletDateTimePicker.Checked ? ewalletDateTimePicker.Value.ToString("yyyy-MM") : (object)DBNull.Value);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void backToDashboardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EWalletUsageForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}