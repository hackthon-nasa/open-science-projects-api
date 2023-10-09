using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Controllers.Reponses.Projects;
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

    public IEnumerable<ProjectList> GetProjectList(IList<int> userTagsListModel)
    {
        var projectsWithTags = (
            from project in _entity
            join projectTag in _context.ProjectTags on project.Id equals projectTag.ProjectId
            join tag in _context.Tags on projectTag.TagId equals tag.Id
            where userTagsListModel.Contains(projectTag.TagId)
            select new
            {
                ProjectId = project.Id,
                ProjectTittle = project.Title,
                ProjectDescription = project.Description,
                ProjectLink = project.Link,
                ProjectOrganizationId = project.OrganizationId,
                ProjectTagDescription = tag.Description
            }
        );

        var projectsWithoutTags = (
            from project in _entity
            join projectTag in _context.ProjectTags
                on project.Id equals projectTag.ProjectId
                into projectTagJoined
            from projectTag in projectTagJoined.DefaultIfEmpty()
            join tag in _context.Tags on projectTag.TagId equals tag.Id
            where !userTagsListModel.Contains(projectTag.TagId)
            select new
            {
                ProjectId = project.Id,
                ProjectTittle = project.Title,
                ProjectDescription = project.Description,
                ProjectLink = project.Link,
                ProjectOrganizationId = project.OrganizationId,
                ProjectTagDescription = tag.Description
            }
        );

        var projectsGrouping = projectsWithTags.Concat(projectsWithoutTags);

        var projects = new Dictionary<int, ProjectList>();
        foreach (var projectGrouped in projectsGrouping)
        {
            if (!projects.ContainsKey(projectGrouped.ProjectId))
            {
                projects[projectGrouped.ProjectId] = new ProjectList
                {
                    Id = projectGrouped.ProjectId,
                    Description = projectGrouped.ProjectDescription,
                    Title = projectGrouped.ProjectTittle,
                    Link = projectGrouped.ProjectLink,
                    OrganizationId = projectGrouped.ProjectOrganizationId,
                    TagDescriptions = new List<string>()
                };
            }

            projects[projectGrouped.ProjectId].TagDescriptions.Add(projectGrouped.ProjectTagDescription);
        }

        return projects.Values;
    }

    public Task<List<ProjectList>> GetProjectListIfTagsIsEmpty()
    {
        return _entity
            .Include(x => x.ProjectTags)
            .ThenInclude(x => x.Tag)
            .Select(x => new ProjectList
            {
                Id = x.Id,
                Description = x.Description,
                Title = x.Title,
                Link = x.Link,
                OrganizationId = x.OrganizationId,
                TagDescriptions = x.ProjectTags.Select(y => y.Tag.Description).ToList()
            }).ToListAsync();
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
            .Where(x => x.Title == name)
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

    public async Task<List<ProjectTag>> GetProjectTagsByIdProjectId(int id)
    {
        return await _entity
            .Include(x => x.ProjectTags)
            .Where(x => x.Id == id)
            .SelectMany(x => x.ProjectTags)
            .ToListAsync();
    }
}