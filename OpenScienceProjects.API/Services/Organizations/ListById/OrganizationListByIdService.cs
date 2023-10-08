using OpenScienceProjects.API.Controllers.Reponses.Organizations;
using OpenScienceProjects.API.Data.Repositories.Organizations;

namespace OpenScienceProjects.API.Services.Organizations.ListById;

public class OrganizationListByIdService : IOrganizationListByIdService
{
    private readonly IOrganizationRepository _organizationRepository;

    public OrganizationListByIdService(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }

    public async Task<OrganizationListByIdResponse> GetOrganizationListById(int id)
    {
        var organization = await _organizationRepository.GetOrganizationListById(id);

        return new OrganizationListByIdResponse
        {
            Name = organization.Name,
            Description = organization.Description,
            Location = organization.Location,
            OfficialSite = organization.OfficialSite,
            Email = organization.Email,
            Phone = organization.Phone,
        };
    }
}