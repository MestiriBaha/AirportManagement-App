using AirportManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AirportManagement.Services
{
    public delegate void FlightDetailsDel (Plane plane);
    public delegate double  DurationAverageDel(string parameter);

    public class ServiceFlight  : Interfaces.IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public ICollection<DateTime> GetFlightDates(string destination)
        {
            ICollection<DateTime> dates = new List<DateTime>(); 
            for ( int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination ==destination) { dates.Add(Flights[i].flightDate) ; }
            }
            return dates; 
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination" :
                        foreach (Flight var in Flights)
                    { if (filterValue == var.Destination) { Console.WriteLine(var); } }
                        break;

                case "flightDate":
                        foreach ( Flight var in Flights)    
                        if (DateTime.Parse(filterValue) == var.flightDate) { Console.WriteLine(var); }
                    break; 

                case "effectiveArrival":
                    foreach ( Flight var in Flights)
                        if ( var.effectiveArrival.Equals(DateTime.Parse(filterValue))) { Console.WriteLine(var); }
                    break; 


            }
           
        }
        //LINQ sub-language manipulation
       public  List<DateTime> GetFlightAllDates(string destination)
        { // return Flights.Where(f => f.Destination == destination);
          // correction :
            IEnumerable<DateTime> result = from f in Flights where (f.Destination == destination) select (f.flightDate);
            return result.ToList();
        }

        public void  showFlightDetails ( Plane variable)
        {
            //  foreach ( Flight var in Flights)
            // correction : 
            var result=  from Flight var in Flights where var.plane.Equals(variable) select new { var.Destination, var.effectiveArrival } ;
            //var x =  from Flight var in Flights where var.plane.Equals(variable) select ;
           foreach (var r in result )
            Console.WriteLine(" searched destination is \n "+ r.Destination+ " searched effectiveArrival is \n " + r.effectiveArrival);
        }
        public int programmedFlightNumber ( DateTime startdate)
        {
            var result = from Flight var in Flights
                         where DateTime.Compare(startdate, var.flightDate) > 0 && (var.flightDate - startdate).TotalDays < 7
                         select var;
          return result.Count();    
          ;
        }
        public double DurationAverage ( string destination )
        {
            return (from Flight var in Flights
            where var.Destination.Equals(destination)
            select var.estimatedDuration).Average();    
        }
        public IEnumerable<Flight> OrderedDurationFlights ()
        {
            // we can use from with the need to specify the type of variable !! 
            var result = from var in Flights
                         orderby var.estimatedDuration descending
                         select var;
            return result; 
                        
        }
        public IEnumerable<Passenger> SeniorTravellers ( Flight flight)
        {
            IEnumerable<Passenger> result = from var in Flights
                                                            from search  in var.passengers
                                                            where  var.passengers.Count() > 0    
                                                            orderby  search.birthDate descending
                                                            select search ;
            return result.Take(3);
            
        }

        public IEnumerable<IGrouping<string, DateTime>> DestinationGroupedFlights()
        {
            var result = from flight in Flights
                         group flight.flightDate by flight.Destination;
            return result;
            foreach (var search in result)
            {
                Console.WriteLine(" Destination :  " + search.Key);
                foreach (var grouped in search)
                    Console.WriteLine(" FlightDates " + grouped.ToString("MM/dd/yyyy HH:mm:ss"));
            }
        }
        public ServiceFlight ()
        {
            FlightDetailsDel FlightDetailDel = showFlightDetails;
            DurationAverageDel durationAverageDel = DurationAverage;

        }

    }
}

