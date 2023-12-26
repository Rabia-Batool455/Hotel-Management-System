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
    public partial class RoomService : Form
    {
        public RoomService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();
            SqlCommand cnn = new SqlCommand("INSERT INTO RoomService (ServiceID, ReservationID, ServiceName, Quantity, Price, Subtotal) VALUES (@ServiceID, @ReservationID, @ServiceName, @Quantity, @Price, @Subtotal)", con);

            cnn.Parameters.AddWithValue("@ServiceID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@ReservationID", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@ServiceName", textBox3.Text);
            cnn.Parameters.AddWithValue("@Quantity", int.Parse(textBox4.Text));  // Assuming Quantity is an integer
            cnn.Parameters.AddWithValue("@Price", decimal.Parse(textBox5.Text));  // Assuming Price is a decimal
            cnn.Parameters.AddWithValue("@Subtotal", decimal.Parse(textBox6.Text));  // Assuming Subtotal is a decimal



            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from RoomService", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update RoomService set ServiceID=@ServiceID,ReservationID=@ReservationID,ServiceName=@ServiceName,Quantity=@Quantity,Price=@Price,Subtotal=@Subtotal where ServiceID=@ServiceID", con);


            cnn.Parameters.AddWithValue("@ServiceID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@ReservationID", int.Parse(textBox2.Text));

            
            cnn.Parameters.AddWithValue("@Quantity", textBox4.Text);
            cnn.Parameters.AddWithValue("@Price", textBox5.Text);
            cnn.Parameters.AddWithValue("@Subtotal", textBox6.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete RoomService where ServiceID=@ServiceID", con);
            cmd.Parameters.AddWithValue("@ServiceID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("select * from RoomService", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void RoomService_Load(object sender, EventArgs e)
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
