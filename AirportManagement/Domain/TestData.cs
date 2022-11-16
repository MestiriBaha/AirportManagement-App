using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Domain
{
    public static class TestData
    {
        // Initializing Planes !! 
        public static Plane BoingPlane = new Plane(PlaneType.Boing, 150, new DateTime(2015, 02, 03));
        public static Plane AirbusPlane = new Plane(PlaneType.Airbus, 250, new DateTime(2020, 11, 11));

        // Initializing Staff Members !! 
        //using OBJECT INITIALIZER  !! 
        public static Staff captain = new Staff
        {
            firstName = "captain",
            lastName = "captain",
            emailAddress = "Captain.captain@gmail.com",
            birthDate = new DateTime(01, 01, 1965),
            employementDate = new DateTime(01, 01, 1999),
            Salary = 99999

        };

        public static Staff hostess1 = new Staff
        {
            firstName = "hostess1",
            lastName = "hostess1",
            emailAddress = "hostess1.hostess1@gmail.com",
            birthDate = new DateTime(01, 01, 1995),
            employementDate = new DateTime(01, 01, 2020),
            Salary = 999
        };

        public static Staff hostess2 = new Staff
        {
            firstName = "hostess2",
            lastName = "hostess2",
            emailAddress = "hostess2.hostess2@gmail.com",
            birthDate = new DateTime(01, 01, 1996),
            employementDate = new DateTime(01, 01, 2020),
            Salary = 999
        };
        public static Traveller traveller1 = new Traveller
            {
            firstName = "Traveller1",
            lastName = "Traveller1",
            emailAddress = "Traveller1.Traveller1@gmail.com",
            birthDate = new DateTime(01,01,1980) ,
            healthInformation = "No troubles",
            Nationality = "American" 
        };

        public static Traveller traveller2 = new Traveller
        {
            firstName = "Traveller2",
            lastName = "Traveller2",
            emailAddress = "Traveller2.Traveller2@gmail.com",
            birthDate = new DateTime(01,01,1981),
            healthInformation = "Some troubles",
            Nationality = "French"
        };

        public static Traveller traveller3 = new Traveller
        {
            firstName = "Traveller3",
            lastName = "Traveller3",
            emailAddress = "Traveller3.Traveller3@gmail.com",
            birthDate = new DateTime(01, 01, 1982),
            healthInformation = "No troubles",
            Nationality = "Tunisian"
        };

        public static Traveller traveller4 = new Traveller
        {
            firstName = "Traveller4",
            lastName = "Traveller4",
            emailAddress = "Traveller4.Traveller4@gmail.com",
            birthDate = new DateTime(01, 01, 1983),
            healthInformation = "Some troubles",
            Nationality = "American"
        };

        public static Traveller traveller5 = new Traveller
        {
            firstName = "Traveller5",
            lastName = "Traveller5",
            emailAddress = "Traveller5.Traveller5@gmail.com",
            birthDate = new DateTime(01, 01, 1984),
            healthInformation = "Some troubles",
            Nationality = "Spanish"
        };

        // Initializing Flights : 
        public static Flight paris1 = new Flight
        {
            flightDate = new DateTime(2022, 01, 01, 15, 10, 10),
            Destination = "Paris",
            plane = AirbusPlane,
            estimatedDuration = 110,
            effectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10),
            passengers = new List<Passenger> { traveller1, traveller2, traveller3, traveller4, traveller5 }

        };
        public static Flight paris2 = new Flight
        {
            flightDate = new DateTime(2022, 01, 02, 21, 10, 10),
            Destination = "Paris",
            plane = BoingPlane,
            estimatedDuration = 105,
            effectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10),
             passengers = new List<Passenger>() 

    };

        public static Flight paris3= new Flight
        {
            flightDate = new DateTime(2022, 01, 03, 5, 10, 10),
            Destination = "Paris",
            plane = BoingPlane,
            estimatedDuration = 100,
            effectiveArrival = new DateTime(2022, 03, 01, 6, 40, 10),
            passengers = new List<Passenger>()

        };

        public static Flight madrid1 = new Flight
        {
            flightDate = new DateTime(2022, 01, 04, 6, 10, 10),
            Destination = "Madrid",
            plane = BoingPlane,
            estimatedDuration = 130,
            effectiveArrival = new DateTime(2022, 04, 01, 23, 10, 10),
            passengers = new List<Passenger>()

        };
        //coppied from correction ( waste of time ) 
        public static Flight madrid2 = new Flight
        {
            flightDate = new DateTime(2022, 05, 01, 17, 10, 10),
            Destination ="Madrid",
            effectiveArrival = new DateTime(2022, 05, 01, 18, 50, 10),
            passengers = new List<Passenger>(),

            estimatedDuration = 105,
            plane = BoingPlane
        };

        public static Flight lisbonne = new Flight
        {
            flightDate = new DateTime(2022, 06, 01, 20, 10, 10),
            Destination ="Lisbonne",
            effectiveArrival = new DateTime(2022, 06, 01, 22, 30, 10),
            estimatedDuration = 200,
            plane = AirbusPlane ,
            passengers = new List<Passenger>()

        };
        // we finished inserting static DATA  !! 

       public static  List<Flight> listFlights = new List<Flight> { paris1, paris2,paris3,madrid1,madrid2,lisbonne };





    }
}
