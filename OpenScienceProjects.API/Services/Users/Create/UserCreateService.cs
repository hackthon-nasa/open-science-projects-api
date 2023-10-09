using OpenScienceProjects.API.Controllers.Models.Users;
using OpenScienceProjects.API.Data.Repositories.Users;
using OpenScienceProjects.API.Data.Repositories.UserTags;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Services.Users.Create;

public class UserCreateService : IUserCreateService
{
    private readonly IUserRepository _userRepository;
    private readonly IUserTagRepository _userTagRepository;

    public UserCreateService(
        IUserRepository userRepository,
        IUserTagRepository userTagRepository)
    {
        _userRepository = userRepository;
        _userTagRepository = userTagRepository;
    }

    public async Task CreateUser(UserCreateModel model)
    {
        var user = new User
        {
            Name = model.Name,
            Email = model.Email,
            BirthDate = model.BirthDate,
            Password = model.Password,
            Description = model.Description,
        };

        await _userRepository.InsertOne(user);

        var userTags = model.UserTags.Select(x => new UserTag
        {
            User = user,
            TagId = x,
        });

        await _userTagRepository.InsertMany(userTags);
    }
}