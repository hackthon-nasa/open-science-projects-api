using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Services.Discussion.List;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DiscussionsController : ControllerBase
{
    private readonly IDiscussionListByProjectIdService _discussionListByProjectIdService;

    public DiscussionsController(IDiscussionListByProjectIdService discussionListByProjectIdService)
    {
        _discussionListByProjectIdService = discussionListByProjectIdService;
    }

    [HttpGet("{projectId}")]
    public async Task<List<Entities.Discussion>> GetDiscussionByProjectId([FromRoute] int projectId)
    {
        return await _discussionListByProjectIdService.GetDiscussionByProjectId(projectId);
    }
}