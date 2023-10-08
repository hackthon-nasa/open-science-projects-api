using OpenScienceProjects.API.Controllers.Reponses.Users;
using OpenScienceProjects.API.Data.Repositories.UserTags;

namespace OpenScienceProjects.API.Services.Users.ListTagsById;

public class UserListTagsByIdService : IUserListTagsByIdService
{
    private readonly IUserTagRepository _userTagRepository;

    public UserListTagsByIdService(IUserTagRepository userTagRepository)
    {
        _userTagRepository = userTagRepository;
    }

    public async Task<UserListTagsByIdResponse> GetUserListTagsByUserId(int userId)
    {
        var tags = await _userTagRepository.GetTagsByUserId(userId);

        return new UserListTagsByIdResponse
        {
            Tags = tags
                .Select(x => new UserListTagsByIdResponse.UserListTagsResponse
                {
                    Id = x.TagId,
                    Description = x.Tag.Description,
                })
                .ToList(),
        };
    }
}