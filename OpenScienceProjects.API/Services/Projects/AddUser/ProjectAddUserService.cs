using OpenScienceProjects.API.Controllers.Models.Projects;
using OpenScienceProjects.API.Data.Repositories.ProjectsUsers;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Services.Projects.AddUser;

public class ProjectAddUserService : IProjectAddUserService
{
    private readonly IProjectUserRepository _projectUserRepository;

    public ProjectAddUserService(IProjectUserRepository projectUserRepository)
    {
        _projectUserRepository = projectUserRepository;
    }

    public Task AddUserToProject(ProjectAddUserModel model)
    {
        var projectUser = new ProjectUser
        {
            ProjectId = model.ProjectId,
            UserId = model.UserId,
        };

        return _projectUserRepository.InsertOne(projectUser);
    }
}