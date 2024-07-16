using B3.CdbCalc.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace B3.CdbCalc.DepencyInjection;

public static class DependencyInjectionConfig
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<ICdbCalc, B3.CdbCalc.Application.CdbCalc>();

        return services;
    }
}
