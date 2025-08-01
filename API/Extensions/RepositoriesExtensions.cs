using Domain.Interfaces;
using Domain.Repositories.Primitives;
using Infrastructure.Repositories;

namespace API.Extensions;

public static class RepositoriesExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        
        services.AddScoped<IStationRepository, StationRepository>();
        services.AddScoped<IPartRepository, PartRepository>();
        services.AddScoped<IRegisterRepository, RegisterRepository>();

        return services;
    }
}