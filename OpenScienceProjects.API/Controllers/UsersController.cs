using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Models.Users;
using OpenScienceProjects.API.Controllers.Reponses.Users;
using OpenScienceProjects.API.Services.Users.Create;
using OpenScienceProjects.API.Services.Users.ListById;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserCreateService _userCreateService;
    private readonly IUserListByIdService _userListByIdService;

    public UsersController(
        IUserCreateService userCreateService,
        IUserListByIdService userListByIdService)
    {
        _userCreateService = userCreateService;
        _userListByIdService = userListByIdService;
    }

    [HttpPost]
    public Task CreateUser(UserCreateModel userCreateModel)
    {
        return _userCreateService.CreateUser(userCreateModel);
    }

    [HttpGet("{id}")]
    public Task<UserListByIdResponse> GetUserListById(int id)
    {
        return _userListByIdService.GetUserListById(id);
    }
}