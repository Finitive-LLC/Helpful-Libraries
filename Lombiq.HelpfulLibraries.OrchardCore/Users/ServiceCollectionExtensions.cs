using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Lombiq.HelpfulLibraries.OrchardCore.Users;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCachingUserServer(this IServiceCollection services) =>
        services.AddScoped<ICachingUserManager, CachingUserManager>();
}
