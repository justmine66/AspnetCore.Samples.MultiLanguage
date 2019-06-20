using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MultiLanguage.Controllers
{
    public class SettingsController : AbstractAppController
    {
        [HttpPost]
        public IActionResult Language(string culture, string returnUrl = null)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true });

            return RedirectToLocal(returnUrl);
        }
    }
}