using Microsoft.Extensions.DependencyInjection;
using System;

namespace Toost;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddToostServices(this IServiceCollection services) =>
        services.AddToostServices(_ => { });

    public static IServiceCollection AddToostServices(this IServiceCollection services, Action<ToostOptions> options) 
    {

        ArgumentNullException.ThrowIfNull(services);

        services.Configure(options);
        services.AddSingleton(typeof(ToostService));

        return services; 
    }

}
