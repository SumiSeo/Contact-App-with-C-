﻿using System;


namespace MySuperFlight
{
	public class Flight
	{

		public String UserName { get; set; }
		public String UserPhoneNumber { get; set; }
		public String UserPassport { get; set; }

        //contstruct function
        public Flight(string name, string number, string address)

		{
			UserName = name;
			UserPhoneNumber = number;
			UserPassport = address;
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

