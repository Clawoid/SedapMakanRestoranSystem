using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace OOP_Assignment__Chef_
{
    public partial class manageMenu : Form
    {
        public manageMenu()
        {
            InitializeComponent();
        }
        public void RefreshMenuItems()
        {
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            string connStr = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Menu", conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewMenu.AutoGenerateColumns = true;
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

        private void manage_menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet13.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter1.Fill(this.sedapMakanDBDataSet13.Menu);
            // TODO: This line of code loads data into the 'sedapMakanDBDataSet3.Menu' table. You can move, or remove it, as needed.  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMenu.Columns["MenuItemID"].ReadOnly = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            chefDash chefForm = new chefDash();
            chefForm.Show();
            this.Hide(); // Hide the current form
        }

        private void addItem_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMenu.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridViewMenu.SelectedRows[0];

                    OOP_Assignment_Customer_.MenuItems selected = new OOP_Assignment_Customer_.MenuItems()
                    {
                        MenuItemID = Convert.ToInt32(row.Cells[0].Value),
                        Name = row.Cells[1].Value.ToString(),
                        Category = row.Cells[2].Value.ToString(),
                        Price = Convert.ToDecimal(row.Cells[3].Value),
                        Availability = Convert.ToBoolean(row.Cells[4].Value)
                    };

                    addMenu form = new addMenu(this, selected); // Fix: Ensure the second argument matches the expected type  
                    form.Show();
                }
                else
                {
                    addMenu form = new addMenu(this);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open menu form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
