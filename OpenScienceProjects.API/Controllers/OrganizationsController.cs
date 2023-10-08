using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Reponses.Organizations;
using OpenScienceProjects.API.Services.Organizations;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrganizationsController : ControllerBase
{
    private readonly IOrganizationListTagsByIdService _organizationListTagsByIdService;

    public OrganizationsController(IOrganizationListTagsByIdService organizationListTagsByIdService)
    {
        _organizationListTagsByIdService = organizationListTagsByIdService;
    }

    [HttpGet("{id}/tags")]
    public Task<OrganizationListTagsByIdResponse> GetOrganizationListTagsById(int id)
    {
        return _organizationListTagsByIdService.GetOrganizationListTagsById(id);
    }
}