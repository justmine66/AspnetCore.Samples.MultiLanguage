using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddI18N(this IServiceCollection services,
            IConfiguration config)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var cultures = config.GetSupportedCultures();
                var uiCultures = config.GetSupportedUICultures();

                options.DefaultRequestCulture = new RequestCulture(CultureInfo.CurrentUICulture);
                options.SupportedCultures = cultures;
                options.SupportedUICultures = uiCultures;
            });

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddScoped<IG11NAccessor, G11NAccessor>();
            services.AddScoped<IL10NAccessor, L10NAccessor>();

            return services;
        }
    }
}
