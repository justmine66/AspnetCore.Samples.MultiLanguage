using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public class CultureAccessor : ICultureAccessor
    {
        private readonly RequestLocalizationOptions _options;
        private readonly IHttpContextAccessor _accessor;
        public CultureAccessor(
            IHttpContextAccessor _accessor,
            IOptions<RequestLocalizationOptions> options)
        {
            _options = options.Value;
        }

        public IList<CultureInfo> SupportedCultures => _options.SupportedCultures;

        public IList<CultureInfo> SupportedUICultures => _options.SupportedUICultures;

        public RequestCulture RequestCulture => _accessor.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture;
    }
}
