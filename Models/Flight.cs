using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Flight
    {
        public int FlightID { get; set; }
        public string FlightNumber { get; set; }
        public int AirlineID { get; set; }
        public int DepartureCityID { get; set; }
        public int ArrivalCityID { get; set; }
        public int AircraftTypeID { get; set; }
        public string Status { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
