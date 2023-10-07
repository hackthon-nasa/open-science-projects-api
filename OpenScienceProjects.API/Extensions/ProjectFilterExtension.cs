using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Extensions;

public static class ProjectFilterExtension
{
    public static IQueryable<ProjectTag> FilterTags(this DbSet<ProjectTag> projectTags, IList<int> tags)
    {
        return !tags.Any() ? projectTags : projectTags.Where(x => tags.Contains(x.TagId));
    }
    
    public static IQueryable<ProjectTag> FilterSkills(this DbSet<ProjectTag> projectTags, IList<int> tags)
    {
        return !tags.Any() ? projectTags : projectTags.Where(x => tags.Contains(x.TagId));
    }
    
    public static IQueryable<ProjectTag> FilterInterests(this DbSet<ProjectTag> projectTags, IList<int> tags)
    {
        return !tags.Any() ? projectTags : projectTags.Where(x => tags.Contains(x.TagId));
    }
}