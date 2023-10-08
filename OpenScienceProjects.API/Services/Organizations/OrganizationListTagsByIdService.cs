using OpenScienceProjects.API.Controllers.Reponses.Organizations;
using OpenScienceProjects.API.Data.Repositories.Projects;

namespace OpenScienceProjects.API.Services.Organizations;

public class OrganizationListTagsByIdService : IOrganizationListTagsByIdService
{
    private readonly IProjectRepository _projectRepository;

    public OrganizationListTagsByIdService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<OrganizationListTagsByIdResponse> GetOrganizationListTagsById(int organizationId)
    {
        var tags = await _projectRepository.GetTagsByOrganizationId(organizationId);

        return new OrganizationListTagsByIdResponse
        {
            Tags = tags
                .Select(x => new OrganizationListTagsByIdResponse.OrganizationListTagsResponse
                {
                    Id = x.TagId,
                    Description = x.Tag.Description,
                })
                .ToList(),
        };
    }
}