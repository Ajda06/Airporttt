using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Airport.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Airport.Data
{
    public class AirportdbDBContext : DbContext
    {
        public DbSet <Aircrafttype> Aircrafttypes { get; set; }
        public DbSet <Airline> Airlines{ get; set; }
        public DbSet <Passenger> Passengers { get; set; }
        public DbSet <Airportt> Airports { get; set; }
        public DbSet <Flight> Flights { get; set; }
        public DbSet <Ticket> Tickets { get; set; }
        public DbSet <Seat> Seats { get; set; }
        public DbSet <User> Users { get; set; }
        public DbSet <Flightaircraft> Flightaircrafts { get; set; }//mant to many
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = "server=localhost; database=airportdb; user=root; password=";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 27));
            optionsBuilder.UseMySql(connectionString, serverVersion);
              
        }
        
    }
}
