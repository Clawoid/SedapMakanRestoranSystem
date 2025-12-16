using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Assignment__Chef_
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            chefDash chef_Dashboard = new chefDash();
            chef_Dashboard.FormClosed += (s, args) => this.Close();
            chef_Dashboard.Show();
        }
    }
}
