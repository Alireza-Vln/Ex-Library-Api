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
        [HttpGet("Get-AllUser")]
        public async Task<List<GetUserDto>> GetAllUser()
        {
            return await _service.GetAllUsers();
        }
        [HttpPatch("RentBook")]
        public async Task RentBook([FromQuery]int BookId, [FromQuery]int UserId)
        {
            await _service.RentBook(BookId, UserId);
        }
        [HttpDelete("Delet-User")]
        public async void DeleteUser(int Id)
        {
            _service.DeleteUser(Id);
        }
    }
}
