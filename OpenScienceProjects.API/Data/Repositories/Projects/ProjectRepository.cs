using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;
using OpenScienceProjects.API.ViewModels;

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

    public async Task<ProjectListViewModel> GetProjectList()
    {
        return await _entity
            .Select(x => new ProjectListViewModel
            {
                Projects = new List<Project>
                {
                    new ()
                    {
                        Id = x .Id,
                        Description = x.Description,
                        OrganizationId = x.OrganizationId,
                        Organization = x.Organization,
                        ProjectTags = x.ProjectTags
                    }
                }
            }).FirstOrDefaultAsync();
    }
}