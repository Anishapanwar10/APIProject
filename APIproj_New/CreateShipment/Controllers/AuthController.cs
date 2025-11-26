using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace CreateShipment.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController : ControllerBase
	{
		[HttpPost("token")]
		public IActionResult GetToken()
		{
			// Use the same key as in Program.cs
			var key = Encoding.ASCII.GetBytes("YourSuperSecretKey123!");
			var creds = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

			// Create the token
			var token = new JwtSecurityToken(
				expires: DateTime.UtcNow.AddHours(1),
				signingCredentials: creds
			);

			// Return token as JSON
			return Ok(new
			{
				token = new JwtSecurityTokenHandler().WriteToken(token)
			});
		}
	}
}
