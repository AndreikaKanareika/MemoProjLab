using Lab.SeedData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TeacherMemo.Identity.Entities;
using TeacherMemo.Persistence.Implementation;

namespace Lab.Controllers
{
    [ApiController]
    [Route("Account")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IDbSeeder _seeder;

        public AccountController(UserManager<UserEntity> userManager, IDbSeeder seeder)
        {
            _userManager = userManager;
            _seeder = seeder;
        }

        [HttpPost("Register")]
        [Authorize(AuthenticationSchemes = "Bearer", Roles = Roles.Admin)]
        public async Task<IActionResult> Register(string email, string password)
        {
            var user = new UserEntity
            {
                Email = email,
                UserName = email
            };

            var result = await _userManager.CreateAsync(user, password);
            await _userManager.AddToRoleAsync(user, Roles.Teacher);

            if (result.Succeeded)
            {
                return Ok();
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(string login, string password)
        {
            var user = await _userManager.FindByNameAsync(login);

            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                var role = await _userManager.GetRolesAsync(user);

                var claims = new List<Claim>
                {
                    new Claim("userId", user.Id.ToString()),
                    new Claim("role", role.FirstOrDefault())
                };

                var claimsIdentity = new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                var now = DateTime.UtcNow;

                var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: claimsIdentity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256)
                );

                var token = new JwtSecurityTokenHandler().WriteToken(jwt);
                return Ok(new { token });
            }
            else
            {
                return BadRequest(new { message = "Username or password is incorrect!" });
            }
        }

        [HttpPost("seed")]
        public async Task<IActionResult> SeedData()
        {
            await _seeder.SeedData();
            return Ok();
        }
    }
}
