using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public required string FlightID { get; set; } = string.Empty;

        public string Destination { get; set; } = string.Empty;
        public string departure { get; set; } = string.Empty;
        public DateTime FlightDate { get; set; }

        public string EffectiveArrival { get; set; } = string.Empty;

        public int EstimatedDuration { get; set; }

        public int PlaneId { get; set; }
        public Plane plane { get; set; } = new Plane();
        public ICollection<Passenger> Passengers { get; set; } = new List<Passenger>();
    }
}