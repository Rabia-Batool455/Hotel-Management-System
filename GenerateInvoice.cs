using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class GenerateInvoice : Form
    {
        public string Date,InvoiceID1,ReservationID1,TotalAmount1,IssueDate1,DueDate1,IsPaid1;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public GenerateInvoice()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender ,EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Print");
        }
        private void printDocument1_PrintPage(object sender , PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panel1.Width / 2),this.panel1.Location.Y);
        }
        private Bitmap memoryimg;

        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GenerateInvoice_Load(object sender, EventArgs e)
        {
            label14.Text = Date;
            labelInvoiceID.Text = InvoiceID1;
            labelReservationID.Text = ReservationID1;
            labelTotalAmount.Text = TotalAmount1;
            labelIssueDate.Text = IssueDate1;
            labelDueDate.Text = DueDate1;
            labelIsPaid.Text = IsPaid1;
        }
    }
}
