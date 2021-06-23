using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AccountManagement.Model;
using AccountManagement.WebAPI.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace AccountManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AccountManagementContext _context;
        public AuthController(AccountManagementContext context)
        {
            _context = context;
        }

        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] AuthenticateRequest user)
        {
            if (user == null)
            {
                return BadRequest("Invalid client request");
            }

            //sZvCGwX5J5o2utdVHMhINAdMxws=
            var pass = Helpers.PasswordGenerator.GenerateHash(user.Password);

            var chech = _context.Users.FirstOrDefault(l => l.UserName == user.Username && l.Password == pass);
            if (chech != null)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:62368/",
                    audience: "http://localhost:62368/",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString, User = chech });
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost, Route("changepassword")]
        public IActionResult ChangePassword([FromBody] ChangePasswordUpsertRequest request)
        {

            var user = _context.Users.Find(request.UserId);

            if (Helpers.PasswordGenerator.GenerateHash(request.OldPassword) == user.Password || request.OldPassword == user.Password)
            {
                user.Password = Helpers.PasswordGenerator.GenerateHash(request.NewPassword);

                _context.Users.Attach(user);
                _context.Users.Update(user);

                _context.SaveChanges();
            }
            else
            {
                return null;
            }


            return Ok();
        }

    }

}