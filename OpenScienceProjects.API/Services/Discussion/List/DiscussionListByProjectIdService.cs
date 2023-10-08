using OpenScienceProjects.API.Data.Repositories.Discussions;

namespace OpenScienceProjects.API.Services.Discussion.List;

public class DiscussionListByProjectIdService : IDiscussionListByProjectIdService
{
     private readonly IDiscussionRepository _discussionRepository;

     public DiscussionListByProjectIdService(IDiscussionRepository discussionRepository)
     {
          _discussionRepository = discussionRepository;
     }

     public async Task<List<Entities.Discussion>> GetDiscussionByProjectId(int projectId)
     {
          return await _discussionRepository.GetDiscutissionListByProjectId(projectId);
     }
}