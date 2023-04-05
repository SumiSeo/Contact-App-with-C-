using System;
namespace MySuperContact
{
	public class Reservation
	{
		public DateTime Date { get; }
		public String? Destination { get; }
		public String Notes { get; }

		public Reservation(DateTime date, String country, String note)
		{
			Date = date;
			Destination = country;
			Notes = note;
		}
	}
}

