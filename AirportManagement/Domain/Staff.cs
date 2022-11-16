using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AirportManagement.Domain
{
    public  class Staff : Passenger
    {
        public DateTime employementDate { get; set; }
        public string Function { get; set;  }

        [DataType(DataType.Currency)]
        public int Salary { get; set; }
        public override string ToString()
        {
            return " Staff  " + employementDate + "   " + Function + " " + Salary;  
        }
        public override void passengerType()
        {
            Console.WriteLine("I am a Staff Member");
        }
    }
}
