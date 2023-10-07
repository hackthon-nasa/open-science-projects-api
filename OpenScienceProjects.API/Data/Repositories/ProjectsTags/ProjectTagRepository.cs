using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.ProjectsTags;

public class ProjectTagRepository : IProjectTagRepository
{
    private readonly DatabaseContext _context;
    private readonly DbSet<ProjectTag> _entity;

    public ProjectTagRepository(DatabaseContext context)
    {
        _context = context;
        _entity = _context.Set<ProjectTag>();
    }

    public async Task InsertMany(IEnumerable<ProjectTag> projectTags)
    {
        await _entity.AddRangeAsync(projectTags);
        await _context.SaveChangesAsync();
    }
}