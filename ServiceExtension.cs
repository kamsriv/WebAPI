using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentAPI;
public static class ServiceExtension
{
    public static void DBConfig(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<APIConnectionString>(config.GetSection("DevDBConstr"));
    }
}