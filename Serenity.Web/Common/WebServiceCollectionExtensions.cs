#if ASPNETCORE

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Serenity.Abstractions;
using Serenity.Caching;
using Serenity.Configuration;

namespace Serenity.Extensions.DependencyInjection
{
    public static class WebServiceCollectionExtensions
    {
        public static void AddConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.TryAddSingleton<IConfiguration>(configuration);
            services.TryAddSingleton<IConfigurationRepository, AppSettingsJsonConfigRepository>();
            services.TryAddSingleton<IConfigurationManager, ConfigurationManagerWrapper>();
        }
    }
}
#endif