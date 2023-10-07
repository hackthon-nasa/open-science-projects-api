using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Projects;

public class ProjectRepository : IProjectRepository
{
    private readonly DatabaseContext _context;
    private readonly DbSet<Project> _entity;

    public ProjectRepository(DatabaseContext context)
    {
        _context = context;
        _entity = _context.Set<Project>();
    }

    public Task<List<Project>> GetProjectList()
    {
        return _entity
            .Select(x => new Project
            {
                Id = x.Id,
                Description = x.Description,
                OrganizationId = x.OrganizationId,
                Organization = x.Organization,
                ProjectTags = x.ProjectTags
            }).ToListAsync();
    }

    public Task<Project> GetProjectListById(int id)
    {
        return _entity
            .Where(x => x.Id == id)
            .Select(x => new Project
            {
                Id = x.Id,
                Description = x.Description,
                OrganizationId = x.OrganizationId,
                Organization = x.Organization,
                ProjectTags = x.ProjectTags
            }).FirstOrDefaultAsync();
    }

    public async Task InsertOne(Project project)
    {
        await _entity.AddAsync(project);
        await _context.SaveChangesAsync();
    }
}