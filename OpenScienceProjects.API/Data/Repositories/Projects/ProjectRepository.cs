using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Controllers.Models;
using OpenScienceProjects.API.Controllers.Reponses;
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
        var query = from project in _entity
            join projectTag in _context.ProjectTags.FilterTags(userTagsListModel) on project.Id equals projectTag.ProjectId
            select project;

        return query.ToListAsync();
    }

    public async Task InsertOne(Project project)
    {
        await _entity.AddAsync(project);
        await _context.SaveChangesAsync();
    }
}