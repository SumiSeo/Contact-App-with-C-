using System;


namespace MySuperFlight
{
	public class Flight
	{

		public string Owner { get; }
		public string PassportNumber { get; }
		private string Status = "none";
		public string ReservationStatus
		{
			get => Status;
			set
			{
				Status = value;
			}
		}
		//I need to keep track of reservation info
		public object ReservationInfo { get; set; }

        private static int ReservationNumber = 1234567890;

        //contstruct function

        public Flight(string name, string number)
			
		{
			Owner = name;
			PassportNumber = number;
		}



        public void BookFlight(string number, string country)
		{
			ReservationStatus = "Booked";
			Reservation Reservation1 = new Reservation(DateTime.Now, country);
			Console.WriteLine("User booked a flight.");
		}


        public void CancelFlight()
		{
            ReservationStatus = "Canceled";
            Console.WriteLine("User canceled a flight.");

        }

        public void ModifyFlight()
		{
            ReservationStatus = "Modified";
            Console.WriteLine("User modified a flight.");

        }
    }
}

