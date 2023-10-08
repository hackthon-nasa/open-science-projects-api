using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Services.Comment;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentsController : ControllerBase
{
    private readonly ICommentListByDiscussionIdService _listByDiscussionIdService;

    public CommentsController(ICommentListByDiscussionIdService listByDiscussionIdService)
    {
        _listByDiscussionIdService = listByDiscussionIdService;
    }
    
    [HttpGet("{discussionId}")]
    public async Task<List<Entities.Comment>> GetCommentListByProjectId([FromRoute] int discussionId)
    {
        return await _listByDiscussionIdService.GetCommentListByProjectId(discussionId);
    }
}