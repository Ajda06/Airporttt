using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int FlightID { get; set; }
        public int CustomerID { get; set; }
        public decimal Price { get; set; }
        public Flight Flight { get; set; }
        
    }
}
