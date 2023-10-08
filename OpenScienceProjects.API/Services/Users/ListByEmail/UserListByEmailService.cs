using OpenScienceProjects.API.Controllers.Reponses.Users;
using OpenScienceProjects.API.Data.Repositories.Users;

namespace OpenScienceProjects.API.Services.Users.ListByEmail;

public class UserListByEmailService : IUserListByEmailService
{
    private readonly IUserRepository _userRepository;

    public UserListByEmailService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserListByEmailResponse> GetUserListByEmail(string email)
    {
        var users = await _userRepository.GetUserListByEmail(email);

        return new UserListByEmailResponse
        {
            Name = users.Name,
            Email = users.Email,
            Password = users.Password,
            BirthDate = users.BirthDate,
            Description = users.Description,
        };
    }
}