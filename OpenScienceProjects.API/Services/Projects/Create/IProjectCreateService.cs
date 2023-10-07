using OpenScienceProjects.API.Controllers.Models;

namespace OpenScienceProjects.API.Services.Projects.Create;

public interface IProjectCreateService
{
    Task CreateProject(ProjectCreateModel model);
}