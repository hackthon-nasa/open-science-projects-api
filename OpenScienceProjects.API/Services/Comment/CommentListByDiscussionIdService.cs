using OpenScienceProjects.API.Data.Repositories.Comments;

namespace OpenScienceProjects.API.Services.Comment;

public class CommentListByDiscussionIdService : ICommentListByDiscussionIdService
{
    private readonly ICommentRepository _commentRepository;

    public CommentListByDiscussionIdService(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    public async Task<List<Entities.Comment>> GetCommentListByProjectId(int discussionId)
    {
        return await _commentRepository.GetCommentListByProjectId(discussionId);
    }
}