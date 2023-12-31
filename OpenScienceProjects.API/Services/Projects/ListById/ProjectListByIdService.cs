﻿using OpenScienceProjects.API.Controllers.Reponses.Projects;
using OpenScienceProjects.API.Data.Repositories.Projects;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Services.Projects.ListById;

public class ProjectListByIdService : IProjectListByIdService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectListByIdService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<ProjectListByIdResponse> GetProjectListById(int id)
    {
        var projects = await _projectRepository.GetProjectListById(id);

        return new ProjectListByIdResponse
        {
            Id = projects.Id,
            Title = projects.Title,
            Description = projects.Description,
            Link = projects.Link,
            OrganizationId = projects.OrganizationId,
            TagDescriptions = projects.ProjectTags.Select(x => x.Tag.Description).ToList()
        };
    }

    public async Task<List<ProjectListByIdResponse>> GetProjectListByOrganizationId(int organizationId)
    {
        var projects = await _projectRepository.GetProjectListByOrganizationId(organizationId);

        return projects.Select(p => 
            new ProjectListByIdResponse
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Link = p.Link,
                OrganizationId = p.OrganizationId
            }).ToList();
    }

    public async Task<List<ProjectListByIdResponse>> GetProjectListByName(string name)
    {
        var projects = await _projectRepository.GetProjectListByName(name);

        return projects.Select(p => new ProjectListByIdResponse
        {
            Id = p.Id,
            Title = p.Title,
            Description = p.Description,
            Link = p.Link,
            OrganizationId = p.OrganizationId
        }).ToList();
    }

    public async Task<List<int>> GetProjectTagByIdProjectId(int id)
    {
        var projectTags = await _projectRepository.GetProjectTagsByIdProjectId(id);
        return projectTags.Select(x => x.TagId).ToList();
    }
}