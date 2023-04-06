
//What is using ? It is like import statement;
using System;
using System.Collections.Generic;
using System.Globalization;


//What is namespace , group and organize code
namespace MySuperFlight
{
    class Program
    {
        static void Main(string[] args)
        {


            Flight Passenger1 = new Flight("Sumi Seo", "M31994828");
            //Console.WriteLine($"*************Reservation number: {Passenger1.ReservationNumber + "xxxx"} {fl:C3}");
            Console.WriteLine(Passenger1.ReservationNumber);
            Console.WriteLine(Passenger1.Owner);
            Console.WriteLine(Passenger1.PassportNumber);
            Console.WriteLine(Passenger1.ReservationStatus);
            Passenger1.BookFlight(Passenger1.PassportNumber, "Korea");
            Console.WriteLine($"{Passenger1.Owner} holding Passport Number {Passenger1.PassportNumber} just {Passenger1.ReservationStatus}.");




        }
    }

}