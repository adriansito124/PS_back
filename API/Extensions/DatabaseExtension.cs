namespace API.Extensions;

using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public static class DatabaseExtension
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, ConfigurationManager configuration)
    {
        var connectionString = configuration.GetConnectionString("SqlServer");

        services.AddDbContext<PSDbContext>(options =>
            options.UseSqlServer(connectionString));

        return services;
    }
}