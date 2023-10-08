using OpenScienceProjects.API.Controllers.Reponses.Users;

namespace OpenScienceProjects.API.Services.Users.ListById;

public interface IUserListByIdService
{
    Task<UserListByIdResponse> GetUserListById(int id);
}