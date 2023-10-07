using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Models;
using OpenScienceProjects.API.Controllers.Reponses;
using OpenScienceProjects.API.Services.Projects.AddUser;
using OpenScienceProjects.API.Services.Projects.Create;
using OpenScienceProjects.API.Services.Projects.List;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectListService _projectListService;
    private readonly IProjectCreateService _projectCreateService;
    private readonly IProjectAddUserService _projectAddUserService;

    public ProjectsController(
        IProjectListService projectListService,
        IProjectCreateService projectCreateService,
        IProjectAddUserService projectAddUserService)
    {
        _projectListService = projectListService;
        _projectCreateService = projectCreateService;
        _projectAddUserService = projectAddUserService;
    }

    [HttpGet]
    public Task<ProjectListResponse> GetProjectList()
    {
        return _projectListService.GetProjectList();
    }

    [HttpPost]
    public Task CreateProject(ProjectCreateModel projectCreateModel)
    {
        return _projectCreateService.CreateProject(projectCreateModel);
    }

    [HttpPost("users")]
    public Task AddUserToProject(ProjectAddUserModel projectAddUserModel)
    {
        return _projectAddUserService.AddUserToProject(projectAddUserModel);
    }
}