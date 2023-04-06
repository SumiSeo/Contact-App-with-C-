using System;


namespace MySuperFlight
{
	public class Flight
	{

		public string Owner { get; }
		public string PassportNumber { get; }

        private static decimal ReservationNumberSeed = 1234567890;

		public decimal ReservationNumber
		{
			get => ReservationNumberSeed;
			set
			{
				ReservationNumberSeed = value;
			}
		}

        private string Status = "none";
        public string ReservationStatus
		{
			get => Status;
			set
			{
				Status = value;
			}
		}
      

		private List<Reservation> AllReservations = new List<Reservation>();


        public Flight(string name, string number)
			
		{
            Console.WriteLine("user made an account successfully");
			Owner = name;
			PassportNumber = number;

        }



        public void BookFlight(string number, string destination)
		{
			ReservationStatus = "Booked";
			Reservation Booking = new Reservation(DateTime.Now, destination, ReservationNumber);
			Console.WriteLine("User booked a flight.");
            ReservationNumberSeed++;
			AllReservations.Add(Booking);
			Console.WriteLine($"This is for check reservation lists {AllReservations[0].Destination}");
			Console.WriteLine($"This is for check reservation lists {AllReservations[0].Date}");
			Console.WriteLine($"This is for check reservation lists {AllReservations[0].ReservationNumber}");
        }


        public void CancelFlight(string Owner, decimal reservNum)
		{
            ReservationStatus = "Canceled";
            Console.WriteLine("User canceled a flight.");
            Reservation Canceling = new Reservation(DateTime.Now, "placeholder", ReservationNumber);
            AllReservations.Add(Canceling);

            //find the reservation number and cancel it
            Console.WriteLine($"This is for check reservvation lists {AllReservations}");

        }

        public void ModifyFlight(string Owner, decimal reservNum, string destination)
		{
            ReservationStatus = "Modified";
            Console.WriteLine("User modified a flight.");
			Reservation Modifying = new Reservation(DateTime.Now,destination, ReservationNumber);
            AllReservations.Add(Modifying);

            //find the reservation number and modify it
            Console.WriteLine($"This is for check reservvation lists {AllReservations[0]}");

        }
    }
}

