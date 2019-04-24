using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RentalApp.Data;
using RentalApp.Dtos;
using RentalApp.Models;

namespace RentalApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthRepository _repo;
		private readonly IConfiguration _config;
		public AuthController(IAuthRepository repo, IConfiguration config)
		{
			_config = config;
			_repo = repo;
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register(RegisterUserDto registerUserDto)
		{
			registerUserDto.Username = registerUserDto.Username.ToLower();

			if (await _repo.UserExists(registerUserDto.Username))
			
				return BadRequest("Username already exists");
			
			var userToCreate = new User
			{
				Username = registerUserDto.Username
			};

			var createdUser = await _repo.Register(userToCreate, registerUserDto.Password);

			return StatusCode(201);
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginUserDto loginUserDto)
		{
			var userFromRepo = await _repo.Login(loginUserDto.Username, loginUserDto.Password);

			if (userFromRepo == null)
				return Unauthorized();

			var claims = new[]
			{
				new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
				new Claim(ClaimTypes.Name, userFromRepo.Username)
			};

			var key = new SymmetricSecurityKey(Encoding.UTF8
				.GetBytes(_config.GetSection("AppSettings:Token").Value));

			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(claims),
				Expires = DateTime.Now.AddDays(1),
				SigningCredentials = creds
			};

			var tokenHandler = new JwtSecurityTokenHandler();

			var token = tokenHandler.CreateToken(tokenDescriptor);

			return Ok(new
			{
				token = tokenHandler.WriteToken(token)
			});
		}
	}

}