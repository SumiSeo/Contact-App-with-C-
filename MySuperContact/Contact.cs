using System;
namespace MySuperContact
{
	public class Contact
	{

		//name
		public String ContactName { get; set; }
		//phone number
		public String ContactNumber { get; set; }
		//address
		public String ContactAddress { get; set; }

		//add contact info

		//modify contact info

		//delete contact info
		public Contact(string name, string number, string address)
		{
			//contstruct function
			ContactName = name;
			ContactNumber = number;
			ContactAddress = address;
		}

		public void AddContact()
		{

		}

		public void DeleteContact()
		{

		}

		public void ModifyContact()
		{

		}
	}
}

