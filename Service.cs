using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            
            int serid=int.Parse(textBox1.Text);
            string sername = textBox2.Text; 
            string des = textBox3.Text;
            decimal pric = decimal.Parse(textBox4.Text);
            SqlCommand cnn = new SqlCommand("Servicessinsert", con);
            cnn.CommandType = CommandType.StoredProcedure;
            cnn.Parameters.Add("@ServiceName", sername);
            cnn.Parameters.Add("@ServiceID", serid);

            cnn.Parameters.Add("@Description", des);

            cnn.Parameters.Add("@Price", pric);

            con.Open();

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from Servicess", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Servicess set ServiceName=@ServiceName,Description=@Description,Price=@Price where ServiceID=@ServiceID", con);

            cnn.Parameters.AddWithValue("@ServiceID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@ServiceName", textBox2.Text);

            cnn.Parameters.AddWithValue("@Description", textBox3.Text);
            cnn.Parameters.AddWithValue("@Price", textBox3.Text);



            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Servicess where ServiceID=@ServiceID", con);
            cmd.Parameters.AddWithValue("@ServiceID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("select * from Servicess", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Service_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {


                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
    }
}
