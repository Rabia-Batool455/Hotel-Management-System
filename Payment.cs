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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Payment Values(@PaymentID,@ReservationID,@AmountPaid,@PaymentDate)", con);

            cnn.Parameters.AddWithValue("@PaymentID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@ReservationID", textBox2.Text);

            cnn.Parameters.AddWithValue("@AmountPaid", textBox3.Text);
            cnn.Parameters.AddWithValue("@PaymentDate", textBox4.Text);
 

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from Payment", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Payment set ReservationID=@ReservationID,AmountPaid=@AmountPaid,PaymentDate=@PaymentDate where PaymentID=@PaymentID", con);

            cnn.Parameters.AddWithValue("@PaymentID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@ReservationID", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@AmountPaid", textBox3.Text);
            cnn.Parameters.AddWithValue("@PaymentDate", textBox4.Text);
            

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Payment where PaymentID=@PaymentID", con);
            cmd.Parameters.AddWithValue("@PaymentID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("select * from Payment", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
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
