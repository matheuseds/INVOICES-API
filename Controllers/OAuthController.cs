using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace INVOICES_API.Controllers
{
    [ApiController]
    [Route("oauth2/[action]")]
    public class OAuthController : Controller
    {
        [HttpPost]
        [Authorize(AuthenticationSchemes = "BasicAuthentication")]
        public IActionResult token()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("B2F-c@av!-secret4908764321503215"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddMinutes(30);

            var token = new JwtSecurityToken(
                issuer: "B2FinanceIIS",
                audience: "B2FinanceAUD",
                expires: expires,
                signingCredentials: creds);

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            var response = new
            {
                access_token = tokenString,
                token_type = "Bearer",
                expires_in = (int)(expires - DateTime.Now).TotalSeconds 
            };

            return Ok(response);
        }
    }
}
