using System;


namespace MySuperFlight
{
	public class Flight
	{

		public string Owner { get; }
		public string PassportNumber { get; }
		public string ReservationStatus
		{
			get;set; 
		}
		private string ReservationNumber { get; }

        //contstruct function
        public Flight(string name, string number, string status)

		{
			Owner = name;
			PassportNumber = number;
			ReservationStatus = status;
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

