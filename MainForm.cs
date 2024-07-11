using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cancellation flight = new Cancellation();
            flight.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ticket flight = new Ticket();
            flight.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           ViewFlights flight = new ViewFlights();
            flight.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
