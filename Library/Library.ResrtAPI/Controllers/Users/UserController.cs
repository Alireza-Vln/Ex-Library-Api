using Library.DTO;
using Library.Services.User.Cantract;
using Microsoft.AspNetCore.Mvc;

namespace Library.ResrtAPI.Controllers.Users
{
    [ApiController]
    [Route("api/User")]
    public class UserController : Controller
    {
     readonly UserService _service;
        public UserController(UserService service)
        {
            _service = service;
        }
        [HttpPost("AddUser")]
        public async Task AddUser(AddUserDto dto)
        {
           await _service.AddUser(dto);
        }
    }
}
