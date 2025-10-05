// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

// --- Partie déjà existante (ne rien changer) ---
Plane plane = new Plane();
plane.Capacity = 100;
plane.ManufactureDate = new DateTime(2025, 09, 15, 13, 10, 20);

PlaneType boeing = PlaneType.boeing;
plane.PlaneType = boeing;

Plane plane2 = new Plane { Capacity = 100, ManufactureDate = DateTime.Now };

Console.WriteLine(plane2);
Console.WriteLine(plane);

//question 3)
Console.WriteLine("\n=== Test de la méthode PassengerType ===");
//creation des instances
Passenger passenger = new Passenger();
Staff staff = new Staff();
Traveller traveller = new Traveller();


//appel des methodes pour chaque instance
Console. WriteLine("\n-- Appel de PassengerType pour passenger--");
passenger.PassengerType();

Console.WriteLine("\n-- Appel de PassengerType pour staff--");
staff.PassengerType();

Console.WriteLine("\n-- Appel de PassengerType pour traveller--");
traveller.PassengerType();
