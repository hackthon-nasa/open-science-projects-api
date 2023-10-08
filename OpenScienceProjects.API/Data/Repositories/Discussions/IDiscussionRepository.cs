using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Discussions;

public interface IDiscussionRepository
{
    Task<List<Discussion>> GetDiscutissionListByProjectId(int projectId);
}