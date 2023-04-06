
//What is using ? It is like import statement;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

//What is namespace , group and organize code
namespace MySuperFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight Passenger1 = new Flight("Sumi Seo", "M31994828");
            Console.WriteLine(Passenger1.Owner);
            Console.WriteLine(Passenger1.PassportNumber);
            Console.WriteLine(Passenger1.ReservationStatus);
            Passenger1.BookFlight(Passenger1.PassportNumber, "Korea");
            Console.WriteLine($"{Passenger1.Owner} : Passport Number {Passenger1.PassportNumber} made a reservation for the destination {Passenger1.ReservationStatus}");
            Console.ReadLine();
        }
    }

}