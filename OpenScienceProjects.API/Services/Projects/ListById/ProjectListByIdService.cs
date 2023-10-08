using OpenScienceProjects.API.Controllers.Reponses.Projects;
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
            Link = projects.Link,
            OrganizationId = projects.OrganizationId,
            TagIds = new List<int>(),
        };
    }

    public async Task<ProjectListByIdResponse> GetProjectListByOrganizationId(int organizationId)
    {
        var projects = await _projectRepository.GetProjectListById(organizationId);

        return new ProjectListByIdResponse
        {
            Id = projects.Id,
            Description = projects.Description,
            Link = projects.Link,
            OrganizationId = projects.OrganizationId,
            TagIds = new List<int>(),
        };
    }

    public async Task<List<ProjectListByIdResponse>> GetProjectListByName(string name)
    {
        var projects = await _projectRepository.GetProjectListByName(name);

        return projects.Select(p => new ProjectListByIdResponse
        {
            Id = p.Id,
            Description = p.Description,
            Link = p.Link,
            OrganizationId = p.OrganizationId,
            TagIds = new List<int>(),
        }).ToList();
    }
}