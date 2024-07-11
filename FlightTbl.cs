using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airport
{
    public partial class FlightTbl : Form
    {
        private MySqlConnection connection;
        public FlightTbl()
        {
            InitializeComponent();
            InitializeDataBaseConnection();
        }
        private void InitializeDataBaseConnection()
        {
            string connectionString = "Server = localhost; Database=airportdb; user ID=root; Charset=utf8;";
            connection = new MySqlConnection(connectionString);
        }


        private void FlightTbl_Load(object sender, EventArgs e)
        {

        }
        private bool AddFlight(string flight_id, string airline, string flightNumber, string departureAirport, string arrivalAirport, DateTime departureDatetime, DateTime arrivalDatetime, string status)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Flights (airline, flight_number, departure_airport, arrival_airport, departure_datetime, arrival_datetime, status, created_at, updated_at) " +
                               "VALUES (@airline, @flightNumber, @departureAirport, @arrivalAirport, @departureDatetime, @arrivalDatetime, @status, @createdAt, @updatedAt)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@airline", airline);
                cmd.Parameters.AddWithValue("@flightNumber", flightNumber);
                cmd.Parameters.AddWithValue("@departureAirport", departureAirport);
                cmd.Parameters.AddWithValue("@arrivalAirport", arrivalAirport);
                cmd.Parameters.AddWithValue("@departureDatetime", departureDatetime);
                cmd.Parameters.AddWithValue("@arrivalDatetime", arrivalDatetime);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@updatedAt", DateTime.Now);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        private void record_Click(object sender, EventArgs e)
        {
            string flight_id = textBox1.Text;
            string airline = textBox3.Text;
            string flightNumber = textBox2.Text;
            string departureAirport = comboBox2.Text;
            string arrivalAirport = comboBox1.Text;
            DateTime departureDatetime = dateTimePicker2.Value;
            DateTime arrivalDatetime = dateTimePicker1.Value;
            string status = comboBox2.Text;

            if (AddFlight(flight_id, airline, flightNumber, departureAirport, arrivalAirport, departureDatetime, arrivalDatetime, status))
            {
                MessageBox.Show("Flight added successfully.");
            }
            else
            {
                MessageBox.Show("Failed to add flight.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}

