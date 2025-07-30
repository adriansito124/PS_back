using Application.Repositories;
using Application.Repositories.Primitives;

namespace API.Extensions;

public static class RepositoriesExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IStationRepository, StationRepository>();
        services.AddScoped<IPartRepository, PartRepository>();

        return services;
    }
}