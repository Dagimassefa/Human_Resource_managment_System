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

namespace HR_Application
{
    public partial class Update_salary : Form
    {
        public Update_salary()
        {
            InitializeComponent();
        }
       
        private void Update_salary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string txtid = txteid.Text;
            float salary = float.Parse(txtsalary.Text);
            SqlConnection con = new SqlConnection("Data Source=KUKU-PC\\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update assign set salary='" + salary + "' where Emp_ID='" + txtid + "'", con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("insert into salary(Emp_ID,salary,Effective_date) values ('" + txtid + "','" + salary + "',GetDate())", con);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("the salary of the employee has been updated successfully!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_salary salary = new Show_salary();
            salary.Show();
        }

        private void btnregisteremp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nav Nav = new Admin_Nav();
            Nav.Show();
        }
    }
}
