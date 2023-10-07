using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.ProjectsTags;

public interface IProjectTagRepository
{
    Task InsertMany(IEnumerable<ProjectTag> projectTags);
}