using OpenScienceProjects.API.ViewModels;

namespace OpenScienceProjects.API.Data.Repositories.Projects;

public interface IProjectRepository
{
    Task<ProjectListViewModel> GetProjectList();
}