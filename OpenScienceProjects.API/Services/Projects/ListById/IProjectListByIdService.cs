using OpenScienceProjects.API.Controllers.Reponses.Projects;

namespace OpenScienceProjects.API.Services.Projects.ListById;

public interface IProjectListByIdService
{
    Task<ProjectListByIdResponse> GetProjectListById(int id);

    Task<List<ProjectListByIdResponse>> GetProjectListByOrganizationId(int organizationId);

    Task<List<ProjectListByIdResponse>> GetProjectListByName(string name);
    Task<List<int>> GetProjectTagByIdProjectId(int id);
}