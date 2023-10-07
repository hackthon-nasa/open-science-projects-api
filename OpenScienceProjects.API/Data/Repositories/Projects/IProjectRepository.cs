using OpenScienceProjects.API.Controllers.Reponses;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Projects;

public interface IProjectRepository
{
    Task<List<Project>> GetProjectList();
    Task InsertOne(Project project);
}