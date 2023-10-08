using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Organizations;

public interface IOrganizationRepository
{
    Task InsertOne(Organization organization);
    Task<Organization> GetOrganizationListById(int id);
}