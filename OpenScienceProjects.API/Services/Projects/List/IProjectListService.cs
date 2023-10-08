using OpenScienceProjects.API.Controllers.Reponses.Projects;

namespace OpenScienceProjects.API.Services.Projects.List;

public interface IProjectListService
{
    Task<ProjectListResponse> GetProjectList(IList<int> userTagsListModel);
}