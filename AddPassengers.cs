using Airport.Data;
using Airport.Models;
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
    public partial class AddPassengers : Form
    {
        private readonly AirportdbDBContext _context;
        public AddPassengers()
        {
            InitializeComponent();
            _context = new AirportdbDBContext();
        }

        private void AddPassengers_Load(object sender, EventArgs e)
        {

        }

        private void record_Click(object sender, EventArgs e)
        {
            try
            {
                var passenger = new Passenger
                {
                    FirstName = textBox3.Text,
                    LastName = textBox2.Text,
                   // PassportNumber = textBox5.Text,
                    Nationality = dateTimePicker1.Text,
                    
                    Gender = comboBox3.Text,
                    
                };
                _context.Passengers.Add(passenger);
                _context.SaveChanges();

                MessageBox.Show("Passenger added successfully!");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            textBox3.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = "";

            comboBox3.Text = "";

        }
    }
}

    

