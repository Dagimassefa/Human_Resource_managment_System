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
using System.Configuration;
namespace HR_Application
{
    public partial class change_password : Form
    {
        public change_password()
        {
            InitializeComponent();
        }
       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtmuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmlogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_nav Nav = new Employee_nav();
            Nav.Show();
        }

        private void txtold_Leave(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KUKU-PC\\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from assign where Emp_ID='" + txtid.Text + "' and password_='" + txtold.Text + "'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                panel1.Visible = true;
                btnback.Visible = false;
                button2.Visible = false;
            }
            else
            {
                MessageBox.Show("The password and username that you provide did not match!");
                txtid.Text = "";
                txtold.Text = "";
            }
            dr.Close();
            con.Close();
        }

        private void change_password_Load(object sender, EventArgs e)
        {

        }

        private void txtold_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmlogin_Click_1(object sender, EventArgs e)
        {
            if (txtnew.Text == txtverify.Text)
            {
                if (txtnew.Text!= txtold.Text)
                {
                    SqlConnection con = new SqlConnection("Data Source=KUKU-PC\\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update assign set password_='" + txtnew.Text + "' where Emp_ID='" + txtid.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password has been updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Password is not changed because the new password is the same with the old password ");
                    txtnew.Text = "";
                    txtverify.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Verification failed the new password did not match!");
                txtnew.Text = "";
                txtverify.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Employee_nav nav = new Employee_nav();
            this.Hide();
            nav.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_nav nav = new Employee_nav();
            this.Hide();
            nav.Show();
        }
    }
}
