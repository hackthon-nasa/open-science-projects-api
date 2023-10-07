using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.ProjectsUsers;

public class ProjectUserRepository : IProjectUserRepository
{
    private readonly DatabaseContext _context;
    private readonly DbSet<ProjectUser> _entity;

    public ProjectUserRepository(DatabaseContext context)
    {
        _context = context;
        _entity = _context.Set<ProjectUser>();
    }

    public async Task InsertOne(ProjectUser projectUser)
    {
        await _entity.AddAsync(projectUser);
        await _context.SaveChangesAsync();
    }
}