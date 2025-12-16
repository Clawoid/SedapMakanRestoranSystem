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
    public partial class updateProfile : Form
    {
        public updateProfile()
        {
            InitializeComponent();
        }

        private void passwordBtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            chefDash chefDash = new chefDash();
            chefDash.Show();
            this.Hide();
        }
    }
}
