using OpenScienceProjects.API.Controllers.Reponses.Organizations;

namespace OpenScienceProjects.API.Services.Organizations.ListById;

public interface IOrganizationListByIdService
{
    Task<OrganizationListByIdResponse> GetOrganizationListById(int id);
}