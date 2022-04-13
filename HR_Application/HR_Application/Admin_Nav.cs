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
    public partial class Admin_Nav : Form
    {
        public Admin_Nav()
        {
            InitializeComponent();
        }

        private void btnregisteremp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personal_information info = new Personal_information();
            info.Show();
        }

        private void btnmanageemp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_salary salary = new Update_salary();
            salary.Show();
        }

        private void btnassigndep_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_reg reg = new Employee_reg();
            reg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            create_dep dep= new create_dep();
            dep.Show();
        }

        private void btngeneraterep_Click(object sender, EventArgs e)
        {
            this.Hide();
            report re = new report();
            re.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager_Login login = new Manager_Login();
            login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
             Show_position position = new Show_position();
            position.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_salary salary = new Show_salary();
            salary.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_position position = new update_position();
            position.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
