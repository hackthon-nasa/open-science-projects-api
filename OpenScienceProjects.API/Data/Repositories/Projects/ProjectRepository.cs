using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;
using OpenScienceProjects.API.Extensions;

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

    public Task<List<Project>> GetProjectList(IList<int> userTagsListModel)
    {
        var query =
            from project in _entity
            join projectTag in _context.ProjectTags.FilterTags(userTagsListModel) on project.Id equals projectTag.ProjectId
            select project;

        return query.ToListAsync();
    }

    public Task<Project> GetProjectListById(int id)
    {
        return _entity
            .Where(x => x.Id == id)
            .Select(x => new Project
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Link = x.Link,
                OrganizationId = x.OrganizationId,
                Organization = x.Organization,
                ProjectTags = x.ProjectTags
            }).FirstOrDefaultAsync();
    }

    public Task<List<Project>> GetProjectListByName(string name)
    {
        return _entity
            .Where(x => x.Description == name)
            .Select(x => new Project
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Link = x.Link,
                OrganizationId = x.OrganizationId,
                Organization = x.Organization,
                ProjectTags = x.ProjectTags
            }).ToListAsync();
    }

    public Task<List<Project>> GetProjectListByOrganizationId(int organizationId)
    {
        return _entity
            .Where(x => x.OrganizationId == organizationId)
            .Select(x => new Project
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Link = x.Link,
                OrganizationId = x.OrganizationId,
                Organization = x.Organization,
                ProjectTags = x.ProjectTags
            }).ToListAsync();
    }

    public async Task InsertOne(Project project)
    {
        await _entity.AddAsync(project);
        await _context.SaveChangesAsync();
    }

    public async Task<IList<ProjectTag>> GetTagsByOrganizationId(int organizationId)
    {
        return await _entity
            .Include(x => x.ProjectTags)
            .Where(x => x.OrganizationId == organizationId)
            .SelectMany(x => x.ProjectTags)
            .ToListAsync();
    }
}