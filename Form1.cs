using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form1_Load() called...");  try
            {
                /* 
                System.Diagnostics.Debug.WriteLine("within the try"); 
                SqlConnection connection = new SqlConnection(@"Data 
Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");                 connection.Open(); 
                txtMessageText.Text = "Connection Successful";                 connection.Close(); 
                */
                var datasource = @"DESKTOP-O31QORP\SQLEXPRESS"; // Note: Removed unnecessary semicolon
                var database = "HMS2";
                var thisUsername = login.username; // Make sure login.username is a valid variable.
                var thisPassword = login.password; // Make sure login.password is a valid variable.
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" + thisPassword;


                var userRole = login.username;  // Assuming you have a variable that stores the user's role

                // Enable or disable buttons based on the user's role
                
            
                SqlConnection conn = new SqlConnection(connString); conn.Open();
                conn.Close();

            }

            catch (Exception ex)
            {
               
            }
        }

       

        

       

        


        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void db_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                Guest gues = new Guest();
                gues.Show();
            }
            else if (login.username == "User_ADMIN1")
            {
                Guest gues = new Guest();
                gues.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                Guest gues = new Guest();
                gues.Show();
            }
            //Guest Guestinfo = new Guest();
            //Guestinfo.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                Reservation Reservationinfo = new Reservation();
                Reservationinfo.Show();
            }
            else if (login.username == "User_ADMIN1")
            {
                Reservation Reservationinfo = new Reservation();
                Reservationinfo.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                Reservation Reservationinfo = new Reservation();
                Reservationinfo.Show();
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                button5.Enabled = false;
            }
            else if (login.username == "User_ADMIN1")
            {
                Payment Paymentinfo = new Payment();
                Paymentinfo.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                Payment Paymentinfo = new Payment();
                Paymentinfo.Show();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                button6.Enabled = false;
            }
            else if (login.username == "User_ADMIN1")
            {
                Invoice Invoiceinfo = new Invoice();
                Invoiceinfo.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                Invoice Invoiceinfo = new Invoice();
                Invoiceinfo.Show();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (login.username == "User_Staff1")
            {
                button7.Enabled = false;
            }
            else if (login.username == "User_ADMIN1")
            {
                Staff staffinfo = new Staff();
                staffinfo.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                button7.Enabled = false;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                button2.Enabled = false;
            }
            else if (login.username == "User_ADMIN1")
            {
                Service Serviceinfo = new Service();
                Serviceinfo.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                Service Serviceinfo = new Service();
                Serviceinfo.Show();
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                button8.Enabled = false;
            }
            else if (login.username == "User_ADMIN1")
            {
                RoomType RoomTypeinfo = new RoomType();
                RoomTypeinfo.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                button8.Enabled = false;
            }
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                button9.Enabled = false;
            }
            else if (login.username == "User_ADMIN1")
            {
                Room room = new Room();
                room.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                Room room = new Room();
                room.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                RoomService room2 = new RoomService();
                room2.Show();
            }
            else if (login.username == "User_ADMIN1")
            {
                RoomService room2 = new RoomService();
                room2.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                button3.Enabled = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (login.username == "User_Staff1")
            {
                button10.Enabled = false;
            }
            else if (login.username == "User_ADMIN1")
            {
                RoomBooking room1 = new RoomBooking();
                room1.Show();
            }
            else if (login.username == "User_MANAGER1")
            {
                button10.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {


                login frm = new login();
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
