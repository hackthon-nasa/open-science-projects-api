using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Projects;

public interface IProjectRepository
{
    Task<List<Project>> GetProjectList();
    Task<Project> GetProjectListById(int id);
    Task InsertOne(Project project);
}