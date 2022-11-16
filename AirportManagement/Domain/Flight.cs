using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirportManagement.Domain
{
    public  class Flight
    {
        public string Airline { get; set; } 
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime  flightDate { get; set;  }

        public int FlightId { get; set;  }
        public DateTime effectiveArrival { get; set;  }
        public int estimatedDuration { get; set; }
        //many to one relation ( flights to plane ) 
        [ForeignKey("Plane")]

        public Plane plane { get; set; }
        // many to many relation 
        public ICollection<Passenger> passengers { get; set; }


        //tostring oveeride : 

        public override string ToString()
        {
            return "Flight Informations :  " + " " + Destination + "  " + Departure + " \n" + flightDate + "  " + FlightId + " \n" + effectiveArrival + "  " + estimatedDuration + " \n" + plane;
        }

        
    }
}
