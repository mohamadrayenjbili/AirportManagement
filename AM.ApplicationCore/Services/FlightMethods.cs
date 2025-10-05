using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        // Délégués
        public Action<Plane> FlightDetailsDel { get; set; }
        public Func<string, double> DurationAverageDel { get; set; }

        // Constructeur : on peut affecter les méthodes aux délégués
        public FlightMethods()
        {
            FlightDetailsDel = ShowFlightDetails;
            DurationAverageDel = DurationAverage;
        }

        // 1️⃣ Récupérer les dates de vols pour une destination
        public List<DateTime> GetFLightDates(string destination)
        {
            return Flights
                   .Where(f => f.Destination == destination)
                   .Select(f => f.FlightDate)
                   .ToList();
        }

        // 2️⃣ Afficher les détails des vols pour un avion
        public void GetFlightDetails(Plane p)
        {
            var req = from f in Flights
                      where f.plane == p
                      select new { f.FlightDate, f.Destination };

            foreach (var f in req)
            {
                Console.WriteLine(f);
            }
        }

        // Méthode pour assigner au délégué
        private void ShowFlightDetails(Plane p)
        {
            GetFlightDetails(p);
        }

        // 3️⃣ Nombre de vols programmés pour une semaine
        public int GetFlightsNumber(DateTime startDate)
        {
            DateTime endDate = startDate.AddDays(7);
            var req = from f in Flights
                      where f.FlightDate >= startDate && f.FlightDate <= endDate
                      select f;
            return req.Count();
        }

        // 4️⃣ Affichage par filtres
        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var f in Flights.Where(f => f.Destination == filterValue))
                        Console.WriteLine(f);
                    break;

                case "EstimatedDuration":
                    foreach (var f in Flights.Where(f => f.EstimatedDuration == Int32.Parse(filterValue)))
                        Console.WriteLine(f);
                    break;

                case "FlightDate":
                    foreach (var f in Flights.Where(f => f.FlightDate.ToString("yyyy-MM-dd") == filterValue))
                        Console.WriteLine(f);
                    break;

                case "PlaneId":
                    foreach (var f in Flights.Where(f => f.PlaneId == Int32.Parse(filterValue)))
                        Console.WriteLine(f);
                    break;

                default:
                    Console.WriteLine("Filtre non reconnu !");
                    break;
            }
        }

        // 5️⃣ Moyenne des durées estimées
        public double DurationAverage(string destination)
        {
            var req = from f in Flights
                      where f.Destination == destination
                      select f.EstimatedDuration;

            return req.Any() ? req.Average() : 0;
        }

        // 6️⃣ Vols ordonnés par durée
        public IEnumerable<Flight> OrderedFlights()
        {
            var req = from f in Flights
                      orderby f.EstimatedDuration descending
                      select f;

            return req;
        }

        // 7️⃣ Les 3 passagers les plus âgés d’un vol
        public IEnumerable<Passenger> SeniorTravellers(Flight flight)
        {
            var req = from p in flight.Passengers.OfType<Traveller>()
                      orderby p.BirthDate ascending
                      select p;

            return req.Take(3);
        }

        // 8️⃣ Groupement des vols par destination avec affichage
        public IEnumerable<IGrouping<string, Flight>> GroupeDEstination()
        {
            var req = from f in Flights
                      group f by f.Destination;

            foreach (var group in req)
            {
                Console.WriteLine($"Destination : {group.Key}");
                foreach (var flight in group)
                {
                    Console.WriteLine($"Décollage : {flight.FlightDate:dd/MM/yyyy HH:mm:ss}");
                }
            }

            return req;
        }
    }
}
