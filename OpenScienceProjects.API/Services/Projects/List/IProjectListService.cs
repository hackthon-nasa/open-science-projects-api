using OpenScienceProjects.API.Controllers.Models;
using OpenScienceProjects.API.Controllers.Reponses;

namespace OpenScienceProjects.API.Services.Projects.List;

public interface IProjectListService
{
    Task<ProjectListResponse> GetProjectList(IList<int> userTagsListModel);
}