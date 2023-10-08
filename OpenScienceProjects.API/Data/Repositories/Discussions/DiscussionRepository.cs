using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Discussions;

public class DiscussionRepository : IDiscussionRepository
{
    private readonly DatabaseContext _context;
    private readonly DbSet<Discussion> _entity;

    public DiscussionRepository(DatabaseContext context)
    {
        _context = context;
        _entity = _context.Set<Discussion>();
    }

    public Task<List<Discussion>> GetDiscussionListByProjectId(int projectId)
    {
        return _entity
            .Where(x => x.ProjectId == projectId)
            .Select(x => new Discussion
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
            }).ToListAsync();
    }
}