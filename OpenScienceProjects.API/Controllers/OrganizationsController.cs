using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Models.Organizations;
using OpenScienceProjects.API.Controllers.Reponses.Organizations;
using OpenScienceProjects.API.Services.Organizations.Create;
using OpenScienceProjects.API.Services.Organizations.ListById;
using OpenScienceProjects.API.Services.Organizations.ListTagsById;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrganizationsController : ControllerBase
{
    private readonly IOrganizationCreateService _organizationCreateService;
    private readonly IOrganizationListByIdService _organizationListByIdService;
    private readonly IOrganizationListTagsByIdService _organizationListTagsByIdService;

    public OrganizationsController(
        IOrganizationCreateService organizationCreateService,
        IOrganizationListByIdService organizationListByIdService,
        IOrganizationListTagsByIdService organizationListTagsByIdService)
    {
        _organizationCreateService = organizationCreateService;
        _organizationListByIdService = organizationListByIdService;
        _organizationListTagsByIdService = organizationListTagsByIdService;
    }

    [HttpPost]
    public Task<int> CreateUser(OrganizationCreateModel organizationCreateModel)
    {
        return _organizationCreateService.CreateOrganization(organizationCreateModel);
    }

    [HttpGet("{id}")]
    public Task<OrganizationListByIdResponse> GetOrganizationListById(int id)
    {
        return _organizationListByIdService.GetOrganizationListById(id);
    }

    [HttpGet("{id}/tags")]
    public Task<OrganizationListTagsByIdResponse> GetOrganizationListTagsById(int id)
    {
        return _organizationListTagsByIdService.GetOrganizationListTagsById(id);
    }
}