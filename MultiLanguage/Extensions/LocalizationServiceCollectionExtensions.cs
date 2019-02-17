using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace MultiLanguage.Extensions
{
    public static class LocalizationServiceCollectionExtensions
    {
        public static IServiceCollection AddRequestLocalization(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // 指定全球化资源文件存储位置
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            // 配置支持的区域性列表
            services.Configure<RequestLocalizationOptions>(options =>
            {
                // 从配置文件读取区域性列表，并配置给应用。
                var supportedCultures = configuration.GetCultures();

                options.DefaultRequestCulture = new RequestCulture(CultureInfo.CurrentCulture);
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            return services;
        }

    }
}
