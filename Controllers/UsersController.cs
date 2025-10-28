using Microsoft.AspNetCore.Mvc;
using TuProject.Services;

namespace TuProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;

    public UsersController(UserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var users = await _userService.GetAllUsers();
        return Ok(users);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        var user = await _userService.GetUserById(id);
        return Ok(user);
    }
}