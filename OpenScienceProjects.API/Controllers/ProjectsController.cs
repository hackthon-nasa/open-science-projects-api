using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Models;
using OpenScienceProjects.API.Controllers.Reponses;
using OpenScienceProjects.API.Services.Projects.Create;
using OpenScienceProjects.API.Services.Projects.List;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectListService _projectListService;
    private readonly IProjectCreateService _projectCreateService;

    public ProjectsController(
        IProjectListService projectListService,
        IProjectCreateService projectCreateService)
    {
        _projectListService = projectListService;
        _projectCreateService = projectCreateService;
    }

    [HttpGet]
    public Task<ProjectListResponse> GetProjectList(UserInterestListModel interestsListModel, UserSkillsListModel userSkillsListModel, UserTagsListModel userTagsListModel)
    {
        return _projectListService.GetProjectList();
    }

    [HttpPost]
    public Task CreateProject(ProjectCreateModel projectCreateModel)
    {
        return _projectCreateService.CreateProject(projectCreateModel);
    }
}