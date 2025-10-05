using System;
using System.Collections.Generic;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        // Planes
        public static Plane BoingPlane = new Plane
        {
            PlaneType = PlaneType.boeing,
            Capacity = 150,
            ManufactureDate = new DateTime(2015, 02, 03)
        };

        public static Plane AirbusPlane = new Plane
        {
            PlaneType = PlaneType.airbus,
            Capacity = 250,
            ManufactureDate = new DateTime(2020, 11, 11)
        };

        // Travellers
        public static Traveller traveller1 = new Traveller
        {
            FirstName = "traveller1",
            LastName = "traveller1",
            EmailAddress = "traveller1.traveller1@gmail.com",
            BirthDate = new DateTime(1980, 01, 01).ToString("yyyy-MM-dd"),
            HealthInformation = "no troubles",
            Nationality = "American"
        };

        public static Traveller traveller2 = new Traveller
        {
            FirstName = "traveller2",
            LastName = "traveller2",
            EmailAddress = "traveller2.traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01).ToString("yyyy-MM-dd"),
            HealthInformation = "Some troubles",
            Nationality = "French"
        };

        public static Traveller traveller3 = new Traveller
        {
            FirstName = "traveller3",
            LastName = "traveller3",
            EmailAddress = "traveller3.traveller3@gmail.com",
            BirthDate = new DateTime(1982, 01, 01).ToString("yyyy-MM-dd"),
            HealthInformation = "no troubles",
            Nationality = "Tunisian"
        };

        public static Traveller traveller4 = new Traveller
        {
            FirstName = "traveller4",
            LastName = "traveller4",
            EmailAddress = "traveller4.traveller4@gmail.com",
            BirthDate = new DateTime(1983, 01, 01).ToString("yyyy-MM-dd"),
            HealthInformation = "Some troubles",
            Nationality = "American"
        };

        public static Traveller traveller5 = new Traveller
        {
            FirstName = "traveller5",
            LastName = "traveller5",
            EmailAddress = "traveller5.traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01).ToString("yyyy-MM-dd"),
            HealthInformation = "Some troubles",
            Nationality = "Spanish"
        };

        // Flights
        public static Flight flight1 = new Flight
        {
            FlightID = "F1",
            FlightDate = new DateTime(2022, 01, 01, 15, 10, 10),
            Destination = "Paris",
            departure = "Paris Airport",
            EffectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10).ToString(),
            EstimatedDuration = 110,
            PlaneId = 1,
            plane = AirbusPlane,
            Passengers = new List<Passenger> { traveller1, traveller2, traveller3, traveller4, traveller5 }
        };

        public static Flight flight2 = new Flight
        {
            FlightID = "F2",
            FlightDate = new DateTime(2022, 02, 01, 21, 10, 10),
            Destination = "Paris",
            departure = "Paris Airport",
            EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10).ToString(),
            EstimatedDuration = 105,
            PlaneId = 2,
            plane = BoingPlane
        };

        public static Flight flight3 = new Flight
        {
            FlightID = "F3",
            FlightDate = new DateTime(2022, 03, 01, 5, 10, 10),
            Destination = "Paris",
            departure = "Paris Airport",
            EffectiveArrival = new DateTime(2022, 03, 01, 6, 40, 10).ToString(),
            EstimatedDuration = 100,
            PlaneId = 2,
            plane = BoingPlane
        };

        public static Flight flight4 = new Flight
        {
            FlightID = "F4",
            FlightDate = new DateTime(2022, 04, 01, 6, 10, 10),
            Destination = "Madrid",
            departure = "Madrid Airport",
            EffectiveArrival = new DateTime(2022, 04, 01, 8, 10, 10).ToString(),
            EstimatedDuration = 130,
            PlaneId = 2,
            plane = BoingPlane
        };

        public static Flight flight5 = new Flight
        {
            FlightID = "F5",
            FlightDate = new DateTime(2022, 05, 01, 17, 10, 10),
            Destination = "Madrid",
            departure = "Madrid Airport",
            EffectiveArrival = new DateTime(2022, 05, 01, 18, 50, 10).ToString(),
            EstimatedDuration = 105,
            PlaneId = 2,
            plane = BoingPlane
        };

        public static Flight flight6 = new Flight
        {
            FlightID = "F6",
            FlightDate = new DateTime(2022, 06, 01, 20, 10, 10),
            Destination = "Lisbonne",
            departure = "Lisbonne Airport",
            EffectiveArrival = new DateTime(2022, 06, 01, 22, 30, 10).ToString(),
            EstimatedDuration = 200,
            PlaneId = 1,
            plane = AirbusPlane
        };

        // Liste globale pour tests
        public static List<Flight> listFlights = new List<Flight>
        {
            flight1, flight2, flight3, flight4, flight5, flight6
        };
    }
}
