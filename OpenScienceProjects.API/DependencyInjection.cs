using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using OpenScienceProjects.API.Data;
using OpenScienceProjects.API.Data.Repositories.Projects;
using OpenScienceProjects.API.Data.Repositories.ProjectsTags;
using OpenScienceProjects.API.Services.Projects.Create;
using OpenScienceProjects.API.Services.Projects.List;

namespace OpenScienceProjects.API;

public static class DependencyInjection
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddDatabase();
        services.AddRepositories();
        services.AddServices();
    }

    private static void AddDatabase(this IServiceCollection services)
    {
        services.AddDbContext<DatabaseContext>(options =>
        {
            var connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
            options.UseSqlServer(connectionString!);
        });
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IProjectRepository, ProjectRepository>();
        services.AddTransient<IProjectTagRepository, ProjectTagRepository>();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IProjectCreateService, ProjectCreateService>();
        services.AddTransient<IProjectListService, ProjectListService>();
    }
}