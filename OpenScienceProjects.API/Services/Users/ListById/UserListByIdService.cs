using OpenScienceProjects.API.Controllers.Reponses.Users;
using OpenScienceProjects.API.Data.Repositories.Users;

namespace OpenScienceProjects.API.Services.Users.ListById;

public class UserListByIdService : IUserListByIdService
{
    private readonly IUserRepository _userRepository;

    public UserListByIdService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserListByIdResponse> GetUserListById(int id)
    {
        var users = await _userRepository.GetUserListById(id);

        return new UserListByIdResponse
        {
            Id = users.Id,
            Name = users.Name,
            Email = users.Email,
            Password = users.Password,
            BirthDate = users.BirthDate,
            Description = users.Description,
        };
    }
}