using OpenScienceProjects.API.Controllers.Reponses;

namespace OpenScienceProjects.API.Services.Projects.ListById;

public interface IProjectListByIdService
{
    Task<ProjectListByIdResponse> GetProjectListById(int id);
}