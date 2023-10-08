using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Models.Projects;
using OpenScienceProjects.API.Controllers.Models.Users;
using OpenScienceProjects.API.Controllers.Reponses.Projects;
using OpenScienceProjects.API.Services.Projects.AddUser;
using OpenScienceProjects.API.Services.Projects.Create;
using OpenScienceProjects.API.Services.Projects.List;
using OpenScienceProjects.API.Services.Projects.ListById;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectListService _projectListService;
    private readonly IProjectListByIdService _projectListByIdService;
    private readonly IProjectCreateService _projectCreateService;
    private readonly IProjectAddUserService _projectAddUserService;

    public ProjectsController(
        IProjectListService projectListService,
        IProjectCreateService projectCreateService,
        IProjectAddUserService projectAddUserService,
        IProjectListByIdService projectListByIdService)
    {
        _projectListService = projectListService;
        _projectCreateService = projectCreateService;
        _projectAddUserService = projectAddUserService;
        _projectListByIdService = projectListByIdService;
    }

    [HttpGet]
    public Task<ProjectListResponse> GetProjectList([FromQuery] UserTagsListModel userTagsListModel)
    {
        return _projectListService.GetProjectList(userTagsListModel.TagIds);
    }

    [HttpGet("organization/{organizationId}")]
    public Task<ProjectListByIdResponse> GetProjectByOrganizationId(int organizationId)
    {
        return _projectListByIdService.GetProjectListByOrganizationId(organizationId);
    }

    [HttpGet("/name/{name}")]
    public Task<List<ProjectListByIdResponse>> GetProjectByName(string name)
    {
        return _projectListByIdService.GetProjectListByName(name);
    }

    [HttpGet("{id}")]
    public Task<ProjectListByIdResponse> GetProjectListById(int id)
    {
        return _projectListByIdService.GetProjectListById(id);
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