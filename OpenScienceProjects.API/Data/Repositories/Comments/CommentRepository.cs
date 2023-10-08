using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Comments;

public class CommentRepository : ICommentRepository
{
    private readonly DatabaseContext _context;
    private readonly DbSet<Comment> _entity;

    public CommentRepository(DatabaseContext context)
    {
        _context = context;
        _entity = _context.Set<Comment>();
    }

    public Task<List<Comment>> GetCommentListByProjectId(int discussionId)
    {
        return _entity
            .Where(x => x.DiscussionId == discussionId)
            .Select(x => new Comment
            {
                Id = x.Id,
                Description = x.Description,
            }).ToListAsync();
    }
}