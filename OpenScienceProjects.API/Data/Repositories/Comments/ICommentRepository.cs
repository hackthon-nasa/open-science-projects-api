using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Comments;

public interface ICommentRepository
{
    Task<List<Comment>> GetCommentListByProjectId(int discussionId);
}