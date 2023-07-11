using System.Diagnostics.CodeAnalysis;
using Application.Interfaces;
using Infrastructure.Repositories.Job;
using WebApi.Services.Job;

namespace WebApi.Configuration;

[ExcludeFromCodeCoverage]
public static class DependencyInjection
{
    public static IServiceCollection ConfigureEndpoints(this IServiceCollection services)
    {
        services.AddScoped(typeof(IJobService), typeof(JobService));
        return services;
    }
    
}