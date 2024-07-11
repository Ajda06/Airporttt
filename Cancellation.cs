using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using MySql.Data.MySqlClient;

namespace Airport
{
    public partial class Cancellation : Form
    {
        //public override DbConnection CreateConnection()
        //{
        //    var dbConnection = new MySqlConnection();
        //    dbConnection.ConnectionString = MySqlBaseConnectionStringBuilder;
        //    dbConnection.Open();
        //    return dbConnection;
        //}
        private MySqlConnection connection;

        public Cancellation()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=localhost; Database=airportdb; user ID=root;Charset=utf8;";
            connection = new MySqlConnection(connectionString);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Cancellation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FlightNumber= textBox2.Text;
            string FlightID = textBox1.Text;


            if (CancelFlight(FlightNumber,FlightID))
            {
                MessageBox.Show("Flight cancelled successfully.");
            }
            else
            {
                MessageBox.Show("Failed to cancel flight.");
            }
        }
        private bool CancelFlight(string FlightNumber, string FlightID)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Flights WHERE flight_number = @flightNumber";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@flightNumber", FlightNumber);
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
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
        private System.Windows.Forms.TextBox FlightNumberTextBox;
        private System.Windows.Forms.Button cancelButton;

        private void button2_Click(object sender, EventArgs e)
        {
            
            
                MainForm form = new MainForm();
                form.Show();
                this.Hide();
            
        }
    }
}
