using OpenScienceProjects.API.Controllers.Reponses.Users;

namespace OpenScienceProjects.API.Services.Users.ListByEmail;

public interface IUserListByEmailService
{
    Task<UserListByEmailResponse> GetUserListByEmail(string email);
}