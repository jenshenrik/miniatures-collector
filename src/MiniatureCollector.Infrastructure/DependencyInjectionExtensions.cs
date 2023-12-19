using Microsoft.Extensions.DependencyInjection;
using MiniatureCollector.Application.Miniatures.List;
using MiniatureCollector.Infrastructure.Data.Queries;

namespace MiniatureCollector.Infrastructure;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IListMiniaturesQueryService, FakeListMiniaturesQueryService>();

        return services;
    }
}