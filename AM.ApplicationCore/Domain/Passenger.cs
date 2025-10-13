using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;
        public string TelNumber { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        public string PassportNumber { get; set; } = string.Empty;

        public ICollection<Flight> flights { get; set; } = new List<Flight>();
        public override string ToString()
        {
            return "FirstName" + FirstName + "LastName" + LastName;
        }
        ////question 1)a)
        //public bool CheckProfile(string Nom, string Prenom)
        //{
        //return (FirstName.Equals(Prenom, StringComparison.OrdinalIgnoreCase)
        //    && LastName.Equals(Nom, StringComparison.OrdinalIgnoreCase));
        //}
        ////question 1)b)

        //public bool CheckProfile(string Nom, string Prenom, string email)
        //{
        //    return FirstName.Equals(Prenom, StringComparison.OrdinalIgnoreCase)
        //        && LastName.Equals(Nom, StringComparison.OrdinalIgnoreCase)
        //        && EmailAddress.Equals(email, StringComparison.OrdinalIgnoreCase);
        //}


        //Question 1)c)

        public bool CheckProfile(string Nom, string Prenom, string email = null)
        {
            if (email == null)
                return (FirstName.Equals(Prenom, StringComparison.OrdinalIgnoreCase)
        && LastName.Equals(Nom, StringComparison.OrdinalIgnoreCase));
            //return CheckProfile(Nom, Prenom); // Appel de la 1ère méthode
            else
                return FirstName.Equals(Prenom, StringComparison.OrdinalIgnoreCase)
           && LastName.Equals(Nom, StringComparison.OrdinalIgnoreCase)
           && EmailAddress.Equals(email, StringComparison.OrdinalIgnoreCase);
           // return CheckProfile(Nom, Prenom, email); // Appel de la 2ème méthode
        }
        //question 2)a)
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

    }
}
