using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Airport
{
    public partial class Form1 : Form
    {
        private MySqlConnection connetion;
        public Form1()
        {
            InitializeComponent();
            InitializeDataBaseConnection();
        }
        private void InitializeDataBaseConnection()
        {
            string connectionString = "Server=localhost; Database = airportdb; user ID=root;Charset=utf8;";
            connetion = new MySqlConnection(connectionString);
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //string connectionString = "Server=localhost;Database=airportdb;User=root;Password=";
            //string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@Username", textBoxUsername.Text);
            //    command.Parameters.AddWithValue("@Password", textBoxPassword.Text);

            //    connection.Open();
            //    int count = Convert.ToInt32(command.ExecuteScalar());

            //    if (count == 1)
            //    {
            //        MessageBox.Show("Login successful!");
            //        this.Hide();
            //        MainForm mainForm = new MainForm();
            //        mainForm.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid username or password.");
            //    }
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (Users(username, password))
            {
                MessageBox.Show("Login successful!");
                MainForm menu = new MainForm();
                menu.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private bool Users(string username, string password)
        {
            try
            {
                connetion.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connetion);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())

                {
                    reader.Close();
                    return true;
                }

                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connetion.Close();
            }
        }

    }
}
