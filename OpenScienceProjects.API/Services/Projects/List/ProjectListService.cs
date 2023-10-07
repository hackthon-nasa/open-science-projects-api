using OpenScienceProjects.API.Data.Repositories.Projects;
using OpenScienceProjects.API.ViewModels;

namespace OpenScienceProjects.API.Services.Projects.List;

public class ProjectListService : IProjectListService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectListService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
    
    public async Task<ProjectListViewModel> GetProjectList()
    {
        return await _projectRepository.GetProjectList();
    }
    
}