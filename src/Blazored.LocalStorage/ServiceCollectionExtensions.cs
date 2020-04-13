using Blazored.LocalStorage;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazoredLocalStorage(this IServiceCollection services)
        {
            return services
                .AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped<ISyncLocalStorageService, LocalStorageService>();
        }
    }
}
