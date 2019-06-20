using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MultiLanguage.Infrastructure.Authentication
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddAuthT(this IServiceCollection services)
        {
            services.AddScoped<SignedInManager, SignedInManager>();

            return services;
        }
    }
}
