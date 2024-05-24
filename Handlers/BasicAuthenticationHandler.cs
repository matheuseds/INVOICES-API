using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace INVOICES_API.Utils
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing Authorization Header");
            }

            var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);

            if (authHeader.Scheme != "Basic")
            {
                return AuthenticateResult.Fail("Invalid Authorization Scheme");
            }

            var credentials = Encoding.UTF8
                .GetString(Convert.FromBase64String(authHeader.Parameter ?? string.Empty))
                .Split(':', 2);

            if (credentials.Length != 2 || !IsAuthorized(credentials[0], credentials[1]))
            {
                return AuthenticateResult.Fail("Invalid Username or Password");
            }

            var claims = new[] { new Claim(ClaimTypes.Name, credentials[0]) };
            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }

        private bool IsAuthorized(string username, string password)
        {
            string user = AppConfig.Configuration["UserInt"];
            string pass = AppConfig.Configuration["PswInt"];

            var appSettings = OptionsMonitor.Get("Authentication");
            //var basicAuthSettings = appSettings?.GetValue("Basic");

            return username == user//basicAuthSettings?.GetValue("Username")
                && password == pass;//basicAuthSettings?.GetValue("Password");
        }
    }
}
