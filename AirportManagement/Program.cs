// See https://aka.ms/new-console-template for more information
using AirportManagement.Domain;
using AirportManagement.Services;

//Flight Germany = new Flight();
Plane plane1 = new Plane(PlaneType.Airbus,50, new DateTime(2022,10,15) );    
Console.WriteLine(plane1);
//Console.WriteLine(Germany.ToString()); 

Passenger baha = new Passenger();
baha.passengerType(); 
Passenger Dhia = new Traveller();
Dhia.passengerType();   
Passenger jihed = new Staff();  
jihed.passengerType();
ServiceFlight serviceFlight = new ServiceFlight
{
    Flights = TestData.listFlights 
};
