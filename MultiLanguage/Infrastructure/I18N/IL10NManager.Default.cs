using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public class L10NManager : IL10NManager
    {
        private readonly RequestCulture _requestCulture;
        public L10NManager(IHttpContextAccessor accessor)
        {
            _requestCulture = accessor.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture;
        }

        public CultureInfo UiCulture => _requestCulture.UICulture;
        public CultureInfo Culture => _requestCulture.Culture;
    }
}
