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
using System.Windows.Forms.VisualStyles;

namespace AdminRole6
{
    public partial class UsersForm : Form
    {
        public void LoadUsers()
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS01;Initial Catalog=SedapMakanDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        public UsersForm(User user)
        {
            InitializeComponent();
            LoadUsers();
        }
        private void returnToDashboardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddUpdateDataBtn_Click(object sender, EventArgs e)
        {
            Form form;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                User selectedUser = new User()
                {
                    UserID = Convert.ToInt32(selectedRow.Cells[0].Value),
                    Name = selectedRow.Cells[1].Value.ToString(),
                    Email = selectedRow.Cells[2].Value.ToString(),
                    Password = selectedRow.Cells[3].Value.ToString(),
                    Role = selectedRow.Cells[4].Value.ToString(),
                    EWalletBalance = selectedRow.Cells[5].Value.ToString(),
                };


                form = new AddRemoveUpdateUsersForm(selectedUser);
            }
            else
            {
                form = new AddRemoveUpdateUsersForm();
            }
            form.FormClosed += (s, args) => LoadUsers();
            form.ShowDialog();
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadUsers();


        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
