using OpenScienceProjects.API.Controllers.Reponses;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Projects;

public interface IProjectRepository
{
    Task<List<Project>> GetProjectList(IList<int> userTagsListModel);
    Task InsertOne(Project project);
}