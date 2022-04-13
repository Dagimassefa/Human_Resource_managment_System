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
    
    public partial class Manager_Login : Form
    {
     
        public Manager_Login()
        {
            InitializeComponent();
        }
        class Function
        {
            protected SqlConnection getConnection()
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=KUKU-PC\\SQLEXPRESS;Initial Catalog=HumanResource;Integrated Security=True";
                return con;
            }
            public DataSet getData(string query)
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            public void setData(string query, string message)
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" '" + message + "' ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            public SqlDataReader getForCombo(string query)
            {
                SqlConnection con = getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                return sdr;
            }
        }
        Function fn = new Function();
        string query;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnmlogin_Click(object sender, EventArgs e)
        {
            query = "select username,password from manager where username='" + txtmuser.Text+ "' and password='" + txtmpass.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                Admin_Nav admin = new Admin_Nav();
                this.Hide();
                admin.Show();
            }


            else
            {
                labelError.Visible = true;
                txtmpass.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_login employee = new Employee_login();
            employee.Show();
        }

        private void txtmpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnmlogin.PerformClick();
            }
        }
    }
}
