using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MultiLanguage.ViewComponents
{
    public class MenuList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ClaimsPrincipal principal)
        {
            return View();
        }
    }
}
