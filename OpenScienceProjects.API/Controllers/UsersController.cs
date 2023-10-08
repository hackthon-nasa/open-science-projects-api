using Microsoft.AspNetCore.Mvc;
using OpenScienceProjects.API.Controllers.Models.Users;
using OpenScienceProjects.API.Services.Users.Create;

namespace OpenScienceProjects.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserCreateService _userCreateService;

    public UsersController()
    {
    }

    [HttpPost]
    public Task CreateUser(UserCreateModel userCreateModel)
    {
        return _userCreateService.CreateUser(userCreateModel);
    }
}