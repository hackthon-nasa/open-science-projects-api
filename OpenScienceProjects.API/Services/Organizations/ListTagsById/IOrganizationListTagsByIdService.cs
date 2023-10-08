using OpenScienceProjects.API.Controllers.Reponses.Organizations;

namespace OpenScienceProjects.API.Services.Organizations.ListTagsById;

public interface IOrganizationListTagsByIdService
{
    Task<OrganizationListTagsByIdResponse> GetOrganizationListTagsById(int organizationId);
}