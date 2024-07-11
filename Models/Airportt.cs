using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Airportt
    {
        public int AirPortID { get; set; }
        public string Name { get; set; }
        public string City{ get; set; }
        public string Country{ get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
