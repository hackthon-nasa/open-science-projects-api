using OpenScienceProjects.API.Controllers.Reponses.Users;

namespace OpenScienceProjects.API.Services.Users.ListTagsById;

public interface IUserListTagsByIdService
{
    Task<UserListTagsByIdResponse> GetUserListTagsByUserId(int userId);
}