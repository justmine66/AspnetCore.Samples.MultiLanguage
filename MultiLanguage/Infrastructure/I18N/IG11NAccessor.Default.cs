using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public class G11NAccessor : IG11NAccessor
    {
        private readonly RequestLocalizationOptions _options;
        public G11NAccessor(IOptions<RequestLocalizationOptions> options)
        {
            _options = options.Value;
        }

        public IList<CultureInfo> SupportedCultures => _options.SupportedCultures;

        public IList<CultureInfo> SupportedUICultures => _options.SupportedUICultures;
    }
}
