using OpenScienceProjects.API.ViewModels;

namespace OpenScienceProjects.API.Services.Projects.List;

public interface IProjectListService
{
    Task<ProjectListViewModel> GetProjectList();
}