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
    public partial class update_position : Form
    {
        public update_position()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
          
            string txtid = txteid.Text;
            string position = txtposition.Text;
            SqlConnection con = new SqlConnection("Data Source=KUKU-PC\\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update assign set position='" + position + "' where Emp_ID='" + txtid + "'", con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("insert into position(Emp_ID,position,Effective_date) values ('" + txtid + "','" + position + "',GetDate())",con);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("the position of the employee has been updated successfully!");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Show_position position = new Show_position();
            position.Show();
        }

        private void btnregisteremp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nav Nav = new Admin_Nav();
            Nav.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txteid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtposition_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
