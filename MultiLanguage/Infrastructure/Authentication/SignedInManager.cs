using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using MultiLanguage.ViewModels;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MultiLanguage.Infrastructure.Authentication
{
    public class SignedInManager
    {
        private readonly static string Scheme = CookieAuthenticationDefaults.AuthenticationScheme;

        private readonly HttpContext _httpContext;

        public SignedInManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor.HttpContext;
        }

        public bool IsSignedIn(ClaimsPrincipal principal)
        {
            return principal?.Identities != null &&
                principal.Identities.Any(i => i.AuthenticationType == Scheme);
        }

        public async Task SignInAsync(ApplicationUser user, bool persistentCookie = false)
        {
            if (user == null)
                await _httpContext.SignOutAsync(Scheme);

            var principal = new ClaimsPrincipal(CreateIdentity(user));
            var authProps = new AuthenticationProperties
            {
                IsPersistent = persistentCookie,
                ExpiresUtc = persistentCookie
                    ? DateTime.UtcNow.AddDays(1)
                    : DateTime.UtcNow.AddMinutes(20)
            };

            await _httpContext.SignInAsync(Scheme, principal, authProps);
        }

        private ClaimsIdentity CreateIdentity(ApplicationUser user)
        {
            var claimsIdentity = new ClaimsIdentity(Scheme);
            claimsIdentity.AddClaim(new Claim(nameof(user.Id), user.Id));
            claimsIdentity.AddClaim(new Claim(nameof(user.Name), user.Name));

            return claimsIdentity;
        }
    }
}
