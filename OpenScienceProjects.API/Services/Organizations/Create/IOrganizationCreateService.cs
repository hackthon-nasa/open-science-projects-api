using OpenScienceProjects.API.Controllers.Models.Organizations;

namespace OpenScienceProjects.API.Services.Organizations.Create;

public interface IOrganizationCreateService
{
    Task CreateOrganization(OrganizationCreateModel model);
}