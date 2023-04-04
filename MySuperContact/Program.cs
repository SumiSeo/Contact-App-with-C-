
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
          Flight Passenger = new Flight("Sum Seo", "+33767234982", "M31994828");
            Console.WriteLine(Passenger.UserName);
        }
    }
    
}