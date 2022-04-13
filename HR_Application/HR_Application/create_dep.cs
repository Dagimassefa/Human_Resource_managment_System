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
    public partial class create_dep : Form
    {
        public create_dep()
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nav Nav = new Admin_Nav();
            Nav.Show();
        }

        private void btncreatedep_Click(object sender, EventArgs e)
        {
            if (txtdepid.Text != "" && txtdepname.Text != "" && txtadmin_name.Text != "" && txtadmin_id.Text != "" && txtdate.Text != "")
            {
                string dep_id = txtdepid.Text;
                string dep_name = txtdepname.Text;
                string admin_name = txtadmin_name.Text;
                string admin_id = txtadmin_id.Text;
                string date_ = txtdate.Text;
                query = "insert into department(dep_ID,Dep_name,Administror_name,Administror_ID,effective_date) values('" + dep_id + "','" + dep_name + "','" + admin_name + "','" + admin_id + "','" + date_ + "')";
                fn.setData(query, "Department has been created successfully!");
                txtdepid.Clear();
                txtdepname.Clear();
                txtadmin_name.Clear();
                txtadmin_id.Clear();
                txtdate.Text = "";
            }
            else
            {
                MessageBox.Show("All items are mandatory!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
