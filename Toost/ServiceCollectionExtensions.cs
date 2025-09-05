using Microsoft.Extensions.DependencyInjection;

namespace Toost;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddToostServices(this IServiceCollection services)
    {

        ArgumentNullException.ThrowIfNull(services);

        services.AddSingleton(typeof(ToostService));

        return services; 
    }

}
