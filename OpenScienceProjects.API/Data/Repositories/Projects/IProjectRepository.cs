using OpenScienceProjects.API.Controllers.Reponses.Projects;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Projects;

public interface IProjectRepository
{
    Task<Project> GetProjectListById(int id);
    Task<List<Project>> GetProjectListByName(string name);
    Task<List<Project>> GetProjectListByOrganizationId(int organizationId);
    IEnumerable<ProjectList> GetProjectList(IList<int> userTagsListModel);
    Task InsertOne(Project project);
    Task<IList<ProjectTag>> GetTagsByOrganizationId(int organizationId);
    Task<List<ProjectTag>> GetProjectTagsByIdProjectId(int id);
    Task<List<ProjectList>> GetProjectListIfTagsIsEmpty();
}