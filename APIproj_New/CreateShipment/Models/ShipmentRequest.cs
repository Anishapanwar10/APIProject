using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace CreateShipment.Models
{
	public class ShipmentRequest
	{
		public Origin Origin { get; set; }
		public Destination Destination { get; set; }
		public List<FreightDetail> FreightDetails { get; set; }
		public List<Reference> References { get; set; }
		public DangerousGoodsSignatory DangerousGoodsSignatory { get; set; }
		public Cover Cover { get; set; }
		public List<Notification> Notifications { get; set; }
	}
}
