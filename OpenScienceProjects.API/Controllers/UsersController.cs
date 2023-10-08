using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Models.Users;
using OpenScienceProjects.API.Controllers.Reponses.Users;
using OpenScienceProjects.API.Services.Users.Create;
using OpenScienceProjects.API.Services.Users.ListByEmail;
using OpenScienceProjects.API.Services.Users.ListById;
using OpenScienceProjects.API.Services.Users.ListByName;
using OpenScienceProjects.API.Services.Users.ListTagsById;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserCreateService _userCreateService;
    private readonly IUserListByIdService _userListByIdService;
    private readonly IUserListByNameService _userListByNameService;
    private readonly IUserListByEmailService _userListByEmailService;
    private readonly IUserListTagsByIdService _userListTagsByIdService;

    public UsersController(
        IUserCreateService userCreateService,
        IUserListByIdService userListByIdService,
        IUserListByNameService userListByNameService,
        IUserListByEmailService userListByEmailService,
        IUserListTagsByIdService userListTagsByIdService)
    {
        _userCreateService = userCreateService;
        _userListByIdService = userListByIdService;
        _userListByNameService = userListByNameService;
        _userListByEmailService = userListByEmailService;
        _userListTagsByIdService = userListTagsByIdService;
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

    [HttpGet("name/{name}")]
    public Task<UserListByNameResponse> GetUserListByName(string name)
    {
        return _userListByNameService.GetUserListByName(name);
    }

    [HttpGet("email/{email}")]
    public Task<UserListByEmailResponse> GetUserListByEmail(string email)
    {
        return _userListByEmailService.GetUserListByEmail(email);
    }

    [HttpGet("{id}/tags")]
    public Task<UserListTagsByIdResponse> GetUserListTagsByUserId(int id)
    {
        return _userListTagsByIdService.GetUserListTagsByUserId(id);
    }
}