using OpenScienceProjects.API.Controllers.Models;
using OpenScienceProjects.API.Controllers.Reponses.Projects;
using OpenScienceProjects.API.Data.Repositories.Projects;

namespace OpenScienceProjects.API.Services.Projects.List;

public class ProjectListService : IProjectListService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectListService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
    
    public async Task<ProjectListResponse> GetProjectList(IList<int> userTagsListModel)
    {
        var projects  = await _projectRepository.GetProjectList(userTagsListModel);

        return new ProjectListResponse
        {
            Projects = projects
        };
    }
}