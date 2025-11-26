using CreateShipment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreateShipment.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CreateOrderController : ControllerBase
	{
		[HttpPost]
		public IActionResult CreateOrder([FromBody] ShipmentRequest request)
		{
			// For now, just return the request as JSON to test
			return Ok(new
			{
				Message = "Shipment received successfully",
				Data = request
			});
		}
	}
}
