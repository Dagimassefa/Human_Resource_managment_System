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
    public partial class Employee_reg : Form
    {
        public Employee_reg()
        {
            InitializeComponent();
        }
    
       
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nav Nav = new Admin_Nav();
            Nav.Show();
        }

        private void combodid_SelectedIndexChanged(object sender, EventArgs e)
        {
        
           
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
          //  string query2;
           // string query3;
            string emp_id = txt_eid.Text;
            string dep_id = combodid.Text;
            string dep_name = combodname.Text;
            string position = txtposition.Text;
            float salary = float.Parse(txtsalary.Text);
            string password = txtpassword.Text;
            SqlConnection con = new SqlConnection("Data Source=KUKU-PC\\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into assign(Emp_ID,Dep_ID,Dep_name,position,salary,password_) values ('" + emp_id + "','" + dep_id + "','" + dep_name + "','" + position + "','" + salary + "','" + password + "')", con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("insert into salary(Emp_ID, salary, Effective_date) values('" + emp_id + "', '" + salary + "', GetDate())", con);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand("insert into salary(Emp_ID, salary, Effective_date) values('" + emp_id + "', '" + salary + "', GetDate())", con);
            cmd3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Employee has been assigned to a department successfully!");
           

        }

        private void Employee_reg_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=KUKU-PC\\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select dep_ID from department",conn);
            SqlCommand cmd2 = new SqlCommand("select Dep_name from department", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlDataAdapter da1 = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da1.SelectCommand = cmd2;
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            da.Fill(table1);
            da1.Fill(table2);
            combodid.DataSource = table1;
            combodname.DataSource = table2;
            combodid.DisplayMember = "dep_ID";
            combodname.DisplayMember = "Dep_name";
        }

        private void txt_eid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtposition_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
