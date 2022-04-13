using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Application
{
    public partial class Employee_nav : Form
    {
        public Employee_nav()
        {
            InitializeComponent();
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            change_password pass = new change_password();
            this.Hide();
            pass.Show();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_login login = new Employee_login();
            login.Show();
        }
    }
}
