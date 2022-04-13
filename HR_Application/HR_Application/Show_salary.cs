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
    public partial class Show_salary : Form
    {
        public Show_salary()
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
        private void Show_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eid = txt_eid.Text;
            query = "select * from salary where Emp_ID='"+eid+"'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            txt_eid.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nav Nav = new Admin_Nav();
            Nav.Show();
        }
    }
}
