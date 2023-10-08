using OpenScienceProjects.API.Controllers.Reponses.Organizations;

namespace OpenScienceProjects.API.Services.Organizations;

public interface IOrganizationListTagsByIdService
{
    Task<OrganizationListTagsByIdResponse> GetOrganizationListTagsById(int organizationId);
}