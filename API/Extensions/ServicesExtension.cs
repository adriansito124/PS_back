using Application.Interfaces.Services;
using Application.Services;
using Application.Services.Primitives;
using Domain.Services;
using Domain.Services.Primitives;

namespace API.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

        services.AddScoped<IStationService, StationService>();
        services.AddScoped<IPartService, PartService>();
        services.AddScoped<IRegisterService, RegisterService>();

        return services;
    }
}