using Castle.Core.Internal;
using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Extensions;

public static class ProjectFilterExtension
{
    public static IQueryable<ProjectTag> FilterTags(this DbSet<ProjectTag> projectTags, IList<int> tags)
    {
        return tags.IsNullOrEmpty() ? projectTags.Where(x => true) : projectTags.Where(x => tags.Contains(x.TagId));
    }
}