using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MultiLanguage.Controllers
{
    public abstract class AbstractAppController : Controller
    {
        protected IStringLocalizer L;

        protected AbstractAppController()
        {
        }

        protected AbstractAppController(IStringLocalizer l10n)
        {
            L = l10n;
        }

        protected IActionResult RedirectToLocal(string returnUrl)
        {
            return Redirect(Url.IsLocalUrl(returnUrl) ? returnUrl : "/");
        }

        protected void AddErrors(string message)
        {
            ModelState.AddModelError(string.Empty, message);
        }
    }
}
