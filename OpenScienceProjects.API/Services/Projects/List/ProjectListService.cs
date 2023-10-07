using OpenScienceProjects.API.Controllers.Models;
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
    
    public async Task<ProjectListResponse> GetProjectList(UserInterestListModel interestsListModel, UserSkillsListModel userSkillsListModel, UserTagsListModel userTagsListModel)
    {
        var projects  = await _projectRepository.GetProjectList();

        return new ProjectListResponse
        {
            Projects = projects
        };
    }
}