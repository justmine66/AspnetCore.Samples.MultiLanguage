using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;

namespace MultiLanguage.Extensions
{
    public static class LocalizationMiddlewareExtensions
    {
        public static IApplicationBuilder UseLocalization(
            this IApplicationBuilder app,
            IConfiguration configuration)
        {
            if (app == null)
                throw new ArgumentNullException(nameof(app));

            var supportedCultures = configuration.GetCultures();

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(CultureInfo.CurrentCulture),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            return app;
        }
    }

}
