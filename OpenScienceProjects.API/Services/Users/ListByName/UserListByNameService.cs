using OpenScienceProjects.API.Controllers.Reponses.Users;
using OpenScienceProjects.API.Data.Repositories.Users;

namespace OpenScienceProjects.API.Services.Users.ListByName;

public class UserListByNameService : IUserListByNameService
{
    private readonly IUserRepository _userRepository;

    public UserListByNameService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserListByNameResponse> GetUserListByName(string name)
    {
        var users = await _userRepository.GetUserListByName(name);

        return new UserListByNameResponse
        {
            Name = users.Name,
            Email = users.Email,
            Password = users.Password,
            BirthDate = users.BirthDate,
            Description = users.Description,
        };
    }
}