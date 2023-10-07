using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Services.Projects.List;
using OpenScienceProjects.API.ViewModels;

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
    public async Task<ProjectListViewModel> GetProjectList()
    {
        return await _projectListService.GetProjectList();
    }
}