using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//When you create a custom class or struct, you should override the ToString method in order to provide information about your type to client code.
namespace AirportManagement.Domain
{
    public  class Traveller : Passenger
    {
        public string healthInformation { get; set; }
        public string Nationality { get; set;  }
        //reimplement the tostring method 
        public override string ToString()
        {
            //Passenger.ToString() +
            return "Traveller" + " " +  "  " +  healthInformation + "  " + Nationality ;
        }
        public override void passengerType()
        {
            Console.WriteLine("I am a Traveller");
        }
    }
}
