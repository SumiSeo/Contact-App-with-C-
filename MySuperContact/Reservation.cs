using System;

namespace MySuperFlight;

public class Reservation
{
	public DateTime Date { get; }
	public string? Destination { get; }
	public decimal ReservationNumber { get; }

	public Reservation(DateTime date, string country, decimal number)
	{
		Date = date;
		Destination = country;
		ReservationNumber = number;
	}
}

