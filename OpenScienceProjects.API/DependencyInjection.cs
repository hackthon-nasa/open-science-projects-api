using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Data;
using OpenScienceProjects.API.Data.Repositories.Projects;
using OpenScienceProjects.API.Data.Repositories.ProjectsTags;
using OpenScienceProjects.API.Data.Repositories.ProjectsUsers;
using OpenScienceProjects.API.Data.Repositories.Users;
using OpenScienceProjects.API.Data.Repositories.UserTags;
using OpenScienceProjects.API.Services.Projects.AddUser;
using OpenScienceProjects.API.Services.Projects.Create;
using OpenScienceProjects.API.Services.Projects.List;
using OpenScienceProjects.API.Services.Projects.ListById;
using OpenScienceProjects.API.Services.Users.Create;
using OpenScienceProjects.API.Services.Users.ListByEmail;
using OpenScienceProjects.API.Services.Users.ListById;
using OpenScienceProjects.API.Services.Users.ListByName;

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
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUserTagRepository, UserTagRepository>();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IProjectAddUserService, ProjectAddUserService>();
        services.AddTransient<IProjectCreateService, ProjectCreateService>();
        services.AddTransient<IProjectListService, ProjectListService>();
        services.AddTransient<IProjectListByIdService, ProjectListByIdService>();

        services.AddTransient<IUserCreateService, UserCreateService>();
        services.AddTransient<IUserListByEmailService, UserListByEmailService>();
        services.AddTransient<IUserListByIdService, UserListByIdService>();
        services.AddTransient<IUserListByNameService, UserListByNameService>();
    }
}