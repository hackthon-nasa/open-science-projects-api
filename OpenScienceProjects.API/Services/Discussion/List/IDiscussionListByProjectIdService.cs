namespace OpenScienceProjects.API.Services.Discussion.List;

public interface IDiscussionListByProjectIdService
{
    Task<List<Entities.Discussion>> GetDiscussionByProjectId(int projectId);
}