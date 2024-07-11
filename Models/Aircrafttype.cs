using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Aircrafttype
    {
        public int AircraftTypeID { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Capacity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
