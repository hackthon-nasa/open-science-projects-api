using OpenScienceProjects.API.Controllers.Reponses;
using OpenScienceProjects.API.Data.Repositories.Projects;

namespace OpenScienceProjects.API.Services.Projects.List;

public class ProjectListService : IProjectListService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectListService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
    
    public async Task<ProjectListResponse> GetProjectList()
    {
        return await _projectRepository.GetProjectList();
    }
}