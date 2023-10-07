using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Reponses;
using OpenScienceProjects.API.Services.Projects.List;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectListService _projectListService;

    public ProjectsController(IProjectListService projectListService)
    {
        _projectListService = projectListService;
    }

    [HttpGet]
    public async Task<ProjectListResponse> GetProjectList()
    {
        return await _projectListService.GetProjectList();
    }
}