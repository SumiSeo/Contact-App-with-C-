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
            ReservationNumberSeed++;

        }



        public void BookFlight(string number, string country)
		{
			ReservationStatus = "Booked";
			Reservation Reservation1 = new Reservation(DateTime.Now, country, ReservationNumber);
			Console.WriteLine("User booked a flight.");
		
		}


        public void CancelFlight()
		{
            ReservationStatus = "Canceled";
            Console.WriteLine("User canceled a flight.");

			//find the reservation number and cancel it

        }

        public void ModifyFlight()
		{
            ReservationStatus = "Modified";
            Console.WriteLine("User modified a flight.");
            Console.WriteLine("User canceled a flight.");

            //find the reservation number and modify it

        }
    }
}

