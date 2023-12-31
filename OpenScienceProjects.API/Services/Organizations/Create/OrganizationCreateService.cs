﻿using OpenScienceProjects.API.Controllers.Models.Organizations;
using OpenScienceProjects.API.Data.Repositories.Organizations;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Services.Organizations.Create;

public class OrganizationCreateService : IOrganizationCreateService
{
    private readonly IOrganizationRepository _organizationRepository;

    public OrganizationCreateService(IOrganizationRepository organizationRepository)
    {
        _organizationRepository = organizationRepository;
    }

    public Task<int> CreateOrganization(OrganizationCreateModel model)
    {
        var organization = new Organization
        {
            Name = model.Name,
            Description = model.Description,
            Location = model.Location,
            OfficialSite = model.OfficialSite,
            Email = model.Email,
            Phone = model.Phone,
        };

        return _organizationRepository.InsertOne(organization);
    }
}