namespace OpenScienceProjects.API.Services.Comment;

public interface ICommentListByDiscussionIdService
{
    Task<List<Entities.Comment>> GetCommentListByProjectId(int discussionId);
}