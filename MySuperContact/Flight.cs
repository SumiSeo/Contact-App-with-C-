using System;


namespace MySuperFlight
{
	public class Flight
	{

		public string Owner { get; }
		public string PassportNumber { get; }
		public string ReservationStatus
		{
			get; set;
		} = "nonbooked";

        private static int ReservationNumber = 1234567890;

        //contstruct function

        public Flight(string name, string number)

		{
			Owner = name;
			PassportNumber = number;
		}



        public void BookFlight()
		{

		}


        public void CancelFlight()
		{

		}

        public void ModifyFlight()
		{

		}
	}
}

