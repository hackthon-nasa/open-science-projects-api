using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Models;
using OpenScienceProjects.API.Controllers.Reponses;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    public ProjectsController()
    {
    }

    [HttpPost]
    public async Task<CreateProjectResponse> CreateProject(CreateProjectModel model)
    {
        return null;
    }
}