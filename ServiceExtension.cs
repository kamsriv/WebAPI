using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentAPI;
using StudentAPI.Interfaces;
using StudentAPI.Services;
using StudentAPI.Repositories;
public static class ServiceExtension
{
    public static void DBConfig(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<APIConnectionString>(config.GetSection("DevDBConstr"));
    }
    public static void ConfigureRepoServices(this IServiceCollection services)
    {
        services.AddScoped<IStudentRepository,StudentRepository>();
        services.AddTransient<IStudentService,StudentService>();
        services.AddTransient<ICourseService,CourseService>();
    }
}