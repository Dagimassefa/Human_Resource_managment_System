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
    public partial class Personal_information : Form
    {
        public Personal_information()
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
        private void Personal_information_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nav Nav = new Admin_Nav();
            Nav.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_reg assign = new Employee_reg();
            assign.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_eid.Text != "" && txt_fname.Text != ""&& txt_lname.Text != "" && txt_email.Text != ""&& combosex.SelectedIndex!=-1 && txt_city.Text != ""&& txt_subcity.Text != ""&& txt_wereda.Text != ""&& txtdate.Text != ""&& txt_kifle.Text != ""&&pictureBox1!=null) {
                Image pimg = pictureBox1.Image;
                ImageConverter converter = new ImageConverter();
                var ImageConvert = converter.ConvertTo(pimg, typeof(byte[]));
                string id = txt_eid.Text;
                string fname = txt_fname.Text;
                string lname = txt_lname.Text;
                string email = txt_email.Text;
                string gender = combosex.Text;
                string city = txt_city.Text;
                string subcity = txt_subcity.Text;
                string wereda = txt_wereda.Text;
                string date_ = txtdate.Text;
                string kifle_ketema = txt_kifle.Text;
                query = "insert into personal_info (Employee_ID,Firstname,Lastname,Email,Gender,City,Subcity,Wereda,Date_,picture,kifle_ketema) values ('" + id + "','" + fname + "','" + lname + "','" + email + "','" + gender + "','" + city + "','" + subcity + "','" + wereda + "','" + date_ + "','" + ImageConvert + "','" + kifle_ketema + "')";
                fn.setData(query, "Employee information has been recorded successfully!");
                txt_eid.Clear();
                txt_fname.Clear();
                txt_lname.Clear();
                txt_email.Clear();
                combosex.SelectedIndex = -1;
                txt_city.Clear();
                txt_subcity.Clear();
                txt_wereda.Clear();
                txt_kifle.Clear();
            }
            else
            {
                MessageBox.Show("All items are mandatory!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Title = "Open Image";
            ofdlg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofdlg.FileName);
            }
        }
    }
}
