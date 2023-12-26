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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Reservation Values(@ReservationID,@RoomID,@GuestID,@StaffID,@ServiceID,@CheckInDate,@CheckOutDate,@TotalAmount)", con);

            cnn.Parameters.AddWithValue("@ReservationID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomID", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@GuestID", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@StaffID", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@ServiceID", int.Parse(textBox5.Text));
            // Convert date strings to DateTime
            cnn.Parameters.AddWithValue("@CheckInDate", DateTime.Parse(textBox6.Text));
            cnn.Parameters.AddWithValue("@CheckOutDate", DateTime.Parse(textBox7.Text));

            cnn.Parameters.AddWithValue("@TotalAmount", decimal.Parse(textBox8.Text));


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from Reservation", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Reservation set ReservationID=@ReservationID, RoomID=@RoomID, GuestID=@GuestID, StaffID=@StaffID, ServiceID=@ServiceID, CheckInDate=@CheckInDate, CheckOutDate=@CheckOutDate, TotalAmount=@TotalAmount where ReservationID=@ReservationID", con);

            cnn.Parameters.AddWithValue("@ReservationID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomID", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("@GuestID", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@StaffID", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@ServiceID", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@CheckInDate", textBox6.Text);
            cnn.Parameters.AddWithValue("@CheckOutDate", textBox7.Text);
            cnn.Parameters.AddWithValue("@TotalAmount", textBox8.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Reservation where ReservationID=@ReservationID", con);
            cmd.Parameters.AddWithValue("@ReservationID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("select * from Reservation", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void Reservation_Load(object sender, EventArgs e)
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
