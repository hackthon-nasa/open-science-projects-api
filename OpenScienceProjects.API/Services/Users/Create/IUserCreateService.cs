using OpenScienceProjects.API.Controllers.Models.Users;

namespace OpenScienceProjects.API.Services.Users.Create;

public interface IUserCreateService
{
    Task CreateUser(UserCreateModel model);
}