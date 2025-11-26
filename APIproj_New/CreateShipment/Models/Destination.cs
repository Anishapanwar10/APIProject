namespace CreateShipment.Models
{
	public class Destination
	{
		public Receiver Receiver { get; set; }
		public Address Address { get; set; }
		public Contact Contact { get; set; }
		public string ReferenceNumber { get; set; }
		public string Instructions { get; set; }
	}
}

public class Receiver
{
	public string Name { get; set; }
}

public class Address
{
	public string Premises { get; set; }
	public string StreetNumber { get; set; }
	public string Address1 { get; set; }
	public string Address2 { get; set; }
	public bool Residential { get; set; }
	public string Suburb { get; set; }
	public string PostCode { get; set; }
	public string Town { get; set; }
	public string City { get; set; }
	public string StateCode { get; set; }
	public string CountryCode { get; set; }
	public Geometry Geometry { get; set; }
}

public class Geometry
{
	public Location Location { get; set; }
}

public class Location
{
	public double Latitude { get; set; }
	public double Longitude { get; set; }
}

public class Contact
{
	public string Name { get; set; }
	public string Phone { get; set; }
	public string PhoneExtension { get; set; }
	public string EmailAddress { get; set; }
}
