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
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet7.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter1.Fill(this.sedapMakanDBDataSet7.Sales);
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet1.Sales' table. You can move, or remove it, as needed.
        }

        private void returnToDashboardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Validate ChefID input
            int parsedChefID;
            object chefIDParam;
            if (string.IsNullOrWhiteSpace(userIDSearchBox.Text))
            {
                chefIDParam = DBNull.Value;
            }
            else if (int.TryParse(userIDSearchBox.Text, out parsedChefID))
            {
                chefIDParam = parsedChefID;
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Chef ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Category filter (previously called SaleType)
            object categoryParam = string.IsNullOrWhiteSpace(saleTypeSearchBox.Text) ? (object)DBNull.Value : saleTypeSearchBox.Text;

            // Filter by Month and Year
            object monthYearParam = salesDatePicker.Checked ? salesDatePicker.Value.ToString("yyyy-MM") : (object)DBNull.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                SaleID,
                OrderID,
                ChefID,
                SaleDate,
                FORMAT(SaleDate, 'yyyy-MM') AS MonthYear,
                SaleTime,
                TotalAmount,
                Category
            FROM Sales
            WHERE
                (@ChefID IS NULL OR ChefID = @ChefID) AND
                (@Category IS NULL OR Category = @Category) AND
                (@MonthYear IS NULL OR FORMAT(SaleDate, 'yyyy-MM') = @MonthYear)
            ORDER BY SaleDate DESC;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ChefID", chefIDParam);
                    cmd.Parameters.AddWithValue("@Category", categoryParam);
                    cmd.Parameters.AddWithValue("@MonthYear", monthYearParam);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    salesDataGrid.DataSource = table;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}