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

namespace WindowsFormsApp2
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Guest Values(@GuestID,@FirstName,@LastName,@Email,@PhoneNumber,@Nationality)", con);

            cnn.Parameters.AddWithValue("@GuestID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@FirstName", textBox2.Text);

            cnn.Parameters.AddWithValue("@LastName", textBox3.Text);
            cnn.Parameters.AddWithValue("@Email", textBox4.Text);
            cnn.Parameters.AddWithValue("@PhoneNumber", textBox5.Text);
            cnn.Parameters.AddWithValue("@Nationality", textBox6.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from Guest", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Guest set FirstName=@FirstName,LastName=@LastName,Email=@Email,PhoneNumber=@PhoneNumber,Nationality=@Nationality where GuestID=@GuestID", con);

            cnn.Parameters.AddWithValue("@GuestID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@FirstName", textBox2.Text);

            cnn.Parameters.AddWithValue("@LastName", textBox3.Text);
            cnn.Parameters.AddWithValue("@Email", textBox4.Text);
            cnn.Parameters.AddWithValue("@PhoneNumber", textBox5.Text);
            cnn.Parameters.AddWithValue("@Nationality", textBox6.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Guest where GuestID=@GuestID", con);
            cmd.Parameters.AddWithValue("@GuestID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("select * from Guest", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
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
