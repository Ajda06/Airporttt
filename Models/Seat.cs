using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Seat
    {
        public int SeatID { get; set; }
        public int FlightID { get; set; }
        public int SeatNumber { get; set; }
        public int PassengerID { get; set; }
        
    }
}
