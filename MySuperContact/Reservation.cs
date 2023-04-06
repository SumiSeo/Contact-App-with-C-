using System;

namespace MySuperFlight;

public class Reservation
{
	public DateTime Date { get; }
	public String? Destination { get; }

	public Reservation(DateTime date, String country)
	{
		Date = date;
		Destination = country;

	}
}

