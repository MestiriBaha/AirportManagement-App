using AirportManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Interfaces
{
    public interface IServiceFlight
    {
        public ICollection<DateTime> GetFlightDates(string destination);

        public void GetFlights(string filterType, string filterValue);

        public List<DateTime> GetFlightAllDates(string destination);

        public void showFlightDetails(Plane variable) ;
        public int programmedFlightNumber(DateTime startdate);
        public double DurationAverage(string destination);
        public IEnumerable<Flight> OrderedDurationFlights();
        public IEnumerable<Passenger> SeniorTravellers(Flight flight);

        public IEnumerable<IGrouping<string, DateTime>> DestinationGroupedFlights();






    }
}
