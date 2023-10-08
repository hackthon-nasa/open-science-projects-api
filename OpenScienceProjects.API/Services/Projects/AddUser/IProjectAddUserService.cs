using OpenScienceProjects.API.Controllers.Models.Projects;

namespace OpenScienceProjects.API.Services.Projects.AddUser;

public interface IProjectAddUserService
{
    Task AddUserToProject(ProjectAddUserModel model);
}