using System.Diagnostics.CodeAnalysis;

namespace WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection ConfigureEndpoints(this IServiceCollection services)
    {
        
        return services;
    }
    
}