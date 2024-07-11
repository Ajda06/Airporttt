using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Passenger
    {
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender{ get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PassportNumber { get; set; }
        public string Nationality { get; set; }
    }
}
