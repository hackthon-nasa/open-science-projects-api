using OpenScienceProjects.API.Controllers.Models.Projects;

namespace OpenScienceProjects.API.Services.Projects.Create;

public interface IProjectCreateService
{
    Task CreateProject(ProjectCreateModel model);
}