using System.Collections.Generic;

namespace CreateShipment.Models
{
	public class Notification
	{
		public string EventTypeCode { get; set; }
		public Transport Transport { get; set; }
		public List<Event> Events { get; set; }
	}

	public class Transport
	{
		public string Code { get; set; }
		public string Destination { get; set; }
	}

	public class Event
	{
		public string Code { get; set; }
	}
}
