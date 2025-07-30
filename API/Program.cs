using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDatabase(builder.Configuration)
    .AddRepositories()
    .AddMainConfigs()
    .AddServices();

var app = builder.Build();

string environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Development";
Console.WriteLine($"Environment: {environment}");

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());

app.UseAuthorization();

app.MapControllers();

app.Run();