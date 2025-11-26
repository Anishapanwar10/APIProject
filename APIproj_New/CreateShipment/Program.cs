using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Secret key for signing JWT tokens
var key = Encoding.ASCII.GetBytes("YourSuperSecretKey123!");

// Add authentication services
builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
	options.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuer = false,           // Skip issuer validation for now
		ValidateAudience = false,         // Skip audience validation
		ValidateLifetime = true,          // Validate token expiration
		ValidateIssuerSigningKey = true,  // Validate the signing key
		IssuerSigningKey = new SymmetricSecurityKey(key)
	};
});


var app = builder.Build();
app.UseAuthentication(); // This checks the JWT token in requests
app.UseAuthorization();  // This enforces [Authorize] on controllers


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
