using System;
namespace MySuperContact
{
	public class Reservation
	{
		public DateTime Date { get; }
		public String? Destination { get; }
		public Decimal ReservNumber { get; }

		public Reservation(DateTime date, String country, Decimal number)
		{
			Date = date;
			ReservNumber = number;
			Destination = country;
		}
	}
}

