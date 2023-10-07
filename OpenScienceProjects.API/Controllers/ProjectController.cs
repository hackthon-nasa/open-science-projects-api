using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Services.Projects.List;
using OpenScienceProjects.API.ViewModels;

namespace OpenScienceProjects.API.Controllers;

public class ProjectController : Controller
{
    private readonly IProjectListService _projectListService;

    public ProjectController(IProjectListService projectListService)
    {
        _projectListService = projectListService;
    }

    [HttpGet]
    public async Task<ProjectListViewModel> GetProjectList()
    {
        return await _projectListService.GetProjectList();
    }
}