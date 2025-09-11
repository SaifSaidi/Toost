using Microsoft.Extensions.DependencyInjection;
using System;

namespace Toost;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddToost(this IServiceCollection services) =>
        services.AddToost(_ => { });

    public static IServiceCollection AddToost(this IServiceCollection services, Action<ToostOptions> options) 
    {

        ArgumentNullException.ThrowIfNull(services);

        services.Configure(options);
        services.AddSingleton(typeof(ToostService));

        return services; 
    }

}
