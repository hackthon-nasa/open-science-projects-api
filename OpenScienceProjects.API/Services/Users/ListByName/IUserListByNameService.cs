using OpenScienceProjects.API.Controllers.Reponses.Users;

namespace OpenScienceProjects.API.Services.Users.ListByName;

public interface IUserListByNameService
{
    Task<UserListByNameResponse> GetUserListByName(string name);
}