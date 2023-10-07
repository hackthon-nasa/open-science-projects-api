using OpenScienceProjects.API.Controllers.Reponses;
using OpenScienceProjects.API.Data.Repositories.Projects;

namespace OpenScienceProjects.API.Services.Projects.ListById;

public class ProjectListByIdService : IProjectListByIdService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectListByIdService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<ProjectListByIdResponse> GetProjectListById(int id)
    {
        var projects = await _projectRepository.GetProjectListById(id);

        return new ProjectListByIdResponse
        {
            Id = projects.Id,
            Description = projects.Description,
            OrganizationId = projects.OrganizationId,
            TagIds = new List<int>(),
        };
    }
}