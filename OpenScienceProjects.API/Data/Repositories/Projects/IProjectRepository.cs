using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Projects;

public interface IProjectRepository
{
    Task<Project> GetProjectListById(int id);
    Task<List<Project>> GetProjectList(IList<int> userTagsListModel);
    Task InsertOne(Project project);
}