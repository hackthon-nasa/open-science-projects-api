using OpenScienceProjects.API.Controllers.Reponses;

namespace OpenScienceProjects.API.Services.Projects.List;

public interface IProjectListService
{
    Task<ProjectListResponse> GetProjectList();
}