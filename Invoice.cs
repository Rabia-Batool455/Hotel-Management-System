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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Invoice Values(@InvoiceID,@ReservationID,@TotalAmount,@IssueDate,@IssueDate,@IsPaid)", con);

            cnn.Parameters.AddWithValue("@InvoiceID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@ReservationID", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@TotalAmount", textBox3.Text);
            cnn.Parameters.AddWithValue("@IssueDate", textBox4.Text);
            cnn.Parameters.AddWithValue("@DueDate", textBox5.Text);
            cnn.Parameters.AddWithValue("@IsPaid", textBox6.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from Invoice", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Invoice set InvoiceID=@InvoiceID,ReservationID=@ReservationID,TotalAmount=@TotalAmount,IssueDate=@IssueDate,DueDate=@DueDate,IsPaid=@IsPaid where InvoiceID=@InvoiceID", con);
            cnn.Parameters.AddWithValue("@InvoiceID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@ReservationID", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@TotalAmount", textBox3.Text);
            cnn.Parameters.AddWithValue("@IssueDate", textBox4.Text);
            cnn.Parameters.AddWithValue("@DueDate", textBox5.Text);
            cnn.Parameters.AddWithValue("@IsPaid", textBox6.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Invoice where InvoiceID=@InvoiceID", con);
            cmd.Parameters.AddWithValue("@InvoiceID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("select * from Invoice", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GenerateInvoice gn = new GenerateInvoice();
            gn.InvoiceID1 = textBox1.Text;
            gn.ReservationID1 = textBox2.Text;
            gn.TotalAmount1 = textBox3.Text;
            gn.IssueDate1 = textBox4.Text;
            gn.DueDate1 = textBox5.Text;
            gn.IsPaid1= textBox6.Text;
            gn.ShowDialog();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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
