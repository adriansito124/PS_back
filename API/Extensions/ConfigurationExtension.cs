namespace API.Extensions;

public static class ConfigurationExtension
{
    public static IServiceCollection AddMainConfigs(this IServiceCollection services)
    {
        services.AddCors();

        services.AddControllers();

        services.AddAuthorization();
        services.AddProblemDetails();
        services.AddEndpointsApiExplorer();

        return services;
    }
}