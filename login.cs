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
using System.Diagnostics;


namespace WindowsFormsApp2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static string username = "";
        public static string password = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-O31QORP\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True");
            username = textBox1.Text;
            password = textBox2.Text; if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else
            {
                var datasource = @"DESKTOP-O31QORP\SQLEXPRESS"; var database = "HMS2"; var thisUsername = username; var thisPassword = password;

                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                SqlConnection conn = new SqlConnection(connString);




                try
                {
                    conn.Open();

                    Form1 frm1 = new Form1();
                    frm1.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
               
            
        
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}





 