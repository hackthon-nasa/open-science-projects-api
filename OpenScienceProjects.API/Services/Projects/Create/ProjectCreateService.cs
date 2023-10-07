using OpenScienceProjects.API.Controllers.Models;
using OpenScienceProjects.API.Data.Repositories.Projects;
using OpenScienceProjects.API.Data.Repositories.ProjectsTags;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Services.Projects.Create;

public class ProjectCreateService : IProjectCreateService
{
    private readonly IProjectRepository _projectRepository;
    private readonly IProjectTagRepository _projectTagRepository;

    public ProjectCreateService(
        IProjectRepository projectRepository,
        IProjectTagRepository projectTagRepository)
    {
        _projectRepository = projectRepository;
        _projectTagRepository = projectTagRepository;
    }

    public async Task CreateProject(ProjectCreateModel model)
    {
        var project = new Project
        {
            Description = model.Description,
            OrganizationId = model.OrganizationId,
        };

        await _projectRepository.InsertOne(project);

        var projectTags = model.TagIds.Select(x => new ProjectTag
        {
            Project = project,
            TagId = x,
        });

        await _projectTagRepository.InsertMany(projectTags);
    }
}