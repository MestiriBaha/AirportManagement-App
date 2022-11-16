using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Services
{
    public  class PassengerExtension : Domain.Passenger
    {
        public  static void UpperFullName(PassengerExtension passenger )
        {
            passenger.firstName=passenger.firstName.First().ToString().ToUpper() + passenger.firstName.Substring(1);
            passenger.lastName = passenger.lastName.First().ToString().ToUpper() + passenger.lastName.Substring(1);

        }
    }
}
