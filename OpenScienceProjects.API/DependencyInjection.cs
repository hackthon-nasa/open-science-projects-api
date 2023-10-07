using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Data;
using OpenScienceProjects.API.Data.Repositories.Projects;
using OpenScienceProjects.API.Data.Repositories.ProjectsTags;
using OpenScienceProjects.API.Data.Repositories.ProjectsUsers;
using OpenScienceProjects.API.Services.Projects.AddUser;
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
            var connectionString = "ConnectionString";
            options.UseSqlServer(connectionString!);
        });
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddTransient<IProjectRepository, ProjectRepository>();
        services.AddTransient<IProjectTagRepository, ProjectTagRepository>();
        services.AddTransient<IProjectUserRepository, ProjectUserRepository>();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IProjectCreateService, ProjectCreateService>();
        services.AddTransient<IProjectListService, ProjectListService>();
        services.AddTransient<IProjectAddUserService, ProjectAddUserService>();
    }
}