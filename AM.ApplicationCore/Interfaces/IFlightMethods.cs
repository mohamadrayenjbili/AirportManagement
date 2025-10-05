using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethods
    {
        // Méthodes classiques
        List<DateTime> GetFLightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void GetFlightDetails(Plane p);
        int GetFlightsNumber(DateTime startDate);
        double DurationAverage(string destination);
        IEnumerable<Flight> OrderedFlights();
        IEnumerable<Passenger> SeniorTravellers(Flight flight);
        IEnumerable<IGrouping<string, Flight>> GroupeDEstination();

        // Délégués
        Action<Plane> FlightDetailsDel { get; set; }
        Func<string, double> DurationAverageDel { get; set; }
    }
}
