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
    public partial class Employee_login : Form
    {
        public Employee_login()
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

        private void btnmlogin_Click(object sender, EventArgs e)
        {
            query = "select Emp_ID,password_ from assign where Emp_ID='" + txtmuser.Text + "' and password_='" + txtmpass.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                Employee_nav emp = new Employee_nav();
                this.Hide();
                emp.Show();
            }


            else
            {
                labelError.Visible = true;
                txtmpass.Clear();
            }
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
