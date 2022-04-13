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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace HR_Application
{
    public partial class report : Form
    {
        public report()
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
        private void report_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nav Nav = new Admin_Nav();
            Nav.Show();
        }

        private void txtsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtsearchby.SelectedIndex == 0)
            {

                query = "select personal_info.Employee_ID,personal_info.Firstname,personal_info.Lastname,personal_info.Email,personal_info.Gender,personal_info.City,personal_info.Subcity,personal_info.Wereda,personal_info.Date_,personal_info.kifle_ketema,assign.Dep_ID,assign.Dep_name,assign.position,assign.salary,assign.password_ from personal_info inner join assign on personal_info.Employee_ID=assign.Emp_ID ";
               DataSet ds = fn.getData(query);
               dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 1)
            {
                query = "select * from department";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtsearchby.SelectedIndex == 2)
            {
                Report_new rep = new Report_new();
                this.Hide();
                rep.Show();
            }
            else if (txtsearchby.SelectedIndex == 3)
            {
                report_position re = new report_position();
                this.Hide();
                re.Show();
            }
        }

        private void report_Leave(object sender, EventArgs e)
        {

            txtsearchby.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF(*.pdf)|*.pdf";
                save.FileName = "result.pdf";
                bool ErroMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErroMessage = true;
                            MessageBox.Show("unable to wride data in disk" + ex.Message);

                        }
                    }
                    if (!ErroMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pcell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("data export succefully", "info");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error while exporting data" + ex.Message);
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("no record foun", "info");
            }

        }
    }
}
    

