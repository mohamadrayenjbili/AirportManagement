using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public string HealthInformation { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        //question 2)b)
        public override void PassengerType()
        {
            base.PassengerType(); // Appel de la méthode de la classe mère
            Console.WriteLine("I am a Traveller");
        }
    }
}


