using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseI18N(
            this IApplicationBuilder app,
            IConfiguration configuration)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            var cultures = configuration.GetSupportedCultures();

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(CultureInfo.CurrentUICulture),
                SupportedCultures = cultures,
                SupportedUICultures = cultures
            });

            return app;
        }
    }
}
