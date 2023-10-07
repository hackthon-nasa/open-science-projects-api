using OpenScienceProjects.API.Controllers.Reponses;

namespace OpenScienceProjects.API.Data.Repositories.Projects;

public interface IProjectRepository
{
    Task<ProjectListResponse> GetProjectList();
}