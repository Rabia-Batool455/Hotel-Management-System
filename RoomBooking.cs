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
    public partial class RoomBooking : Form
    {
        public RoomBooking()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("select * from RoomBooking", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into RoomBooking Values(@BookingID,@RoomID,@GuestID,@StaffID,@CheckInDate,@CheckOutDate,@TotalAmount)", con);

            cnn.Parameters.AddWithValue("@BookingID", textBox1.Text);
            cnn.Parameters.AddWithValue("@RoomID", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@GuestID", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@StaffID", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@CheckInDate", textBox5.Text);
            cnn.Parameters.AddWithValue("@CheckOutDate", textBox6.Text);
            cnn.Parameters.AddWithValue("@TotalAmount", textBox7.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from RoomBooking", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update RoomBooking set BookingID=@BookingID,RoomID=@RoomID,GuestID=@GuestID,StaffID=@StaffID,CheckInDate=@CheckInDate,CheckOutDate=@CheckOutDate,TotalAmount=@TotalAmount where BookingID=@BookingID", con);

            cnn.Parameters.AddWithValue("@BookingID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomID", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@GuestID", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@StaffID", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("@CheckInDate", textBox5.Text);
            cnn.Parameters.AddWithValue("@CheckOutDate", textBox6.Text);
            cnn.Parameters.AddWithValue("@TotalAmount", textBox7.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete RoomBooking where BookingID=@BookingID", con);
            cmd.Parameters.AddWithValue("@BookingID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");
        }

        private void RoomBooking_Load(object sender, EventArgs e)
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
