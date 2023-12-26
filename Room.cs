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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Room Values(@RoomID,@RoomNumber,@RoomTypeID,@IsOccupied)", con);

            cnn.Parameters.AddWithValue("@RoomID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomNumber", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@RoomTypeID", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@IsOccupied", textBox4.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            SqlCommand cnn = new SqlCommand("select * from Room", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView2.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("update Room set RoomNumber=@RoomNumber,RoomTypeID=@RoomTypeID,IsOccupied=@IsOccupied where RoomID=@RoomID", con);

            cnn.Parameters.AddWithValue("@RoomID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@RoomNumber", int.Parse(textBox2.Text));

            cnn.Parameters.AddWithValue("@RoomTypeID", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@IsOccupied", textBox4.Text);


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Room where RoomID=@RoomID", con);
            cmd.Parameters.AddWithValue("@RoomID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O31QORP\SQLEXPRESS;Initial Catalog=HMS2;Integrated Security=True");

            SqlCommand cnn = new SqlCommand("select * from Room", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView2.DataSource = table;
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
