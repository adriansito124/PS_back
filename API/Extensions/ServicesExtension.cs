namespace API.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

        return services;
    }
}