using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MultiLanguage.Infrastructure.I18N
{
    public static class ConfigurationExtensions
    {
        public static IList<CultureInfo> GetSupportedCultures(this IConfiguration configuration, string key = "SupportedCultures")
        {
            var section = configuration.GetSection(key);
            var cultures = new List<CultureInfo>();
            foreach (var culture in section.AsEnumerable())
                if (!string.IsNullOrEmpty(culture.Value))
                    cultures.Add(new CultureInfo(culture.Value));

            return cultures;
        }
    }

}
