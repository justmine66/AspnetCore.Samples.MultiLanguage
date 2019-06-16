using MultiLanguage.ViewModels;
using System.Security.Claims;

namespace MultiLanguage.Infrastructure.Authentication
{
    public class UserManager
    {
        public static ApplicationUser GetApplicationUser(ClaimsPrincipal principal)
        {
            if (principal == null) return null;

            var id = principal.FindFirstValue(nameof(ApplicationUser.Id));
            var name = principal.FindFirstValue(nameof(ApplicationUser.Name));
            var avatar = principal.FindFirstValue(nameof(ApplicationUser.Avatar));

            return new ApplicationUser
            {
                Id = id,
                Name = name,
                Avatar = avatar
            };
        }
    }
}
