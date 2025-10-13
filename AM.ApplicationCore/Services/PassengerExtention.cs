using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static void UpperFullName(this Domain.Passenger p)
        {
            if (p.FirstName != null && p.FirstName.Length > 0)
                p.FirstName = char.ToUpper(p.FirstName[0]) + p.FirstName.Substring(1).ToLower();

            if (p.LastName != null && p.LastName.Length > 0)
                p.LastName = char.ToUpper(p.LastName[0]) + p.LastName.Substring(1).ToLower();
        }
    }


}
