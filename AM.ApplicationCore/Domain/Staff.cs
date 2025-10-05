using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public string EmployementDate { get; set; } = string.Empty;
        public string Function { get; set; } = string.Empty;
        public string salary { get; set; } = string.Empty;

        //question 2)b)
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I am a Staff Member");
        }
    }
}
