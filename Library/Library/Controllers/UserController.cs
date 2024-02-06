using Library.DTO;
using Library.Entites;
using Library.EntityMaps;
using Library.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _service;
            public UserController()
        {
                _service= new UserService();
        }

        [HttpPost("Add-User")]
        public int addUser([FromBody]AddUserDto dto)
        {
            return _service.AddUser(dto);
        }
        [HttpGet("Uer-rent-Book/{bookid}/{userid}")]
        public void RentBooks([FromRoute] int bookid, [FromRoute]int userid)
        {
            _service.RentBook(bookid,userid);
        }
        [HttpGet("Get-All-User")]
        public List<GetUserDto> getUserDtos()
        {
            return _service.GetUsers();
        }
        [HttpDelete("Delete-User/{i}")]
        public void DeleteUser([FromRoute] int i)
        {
            _service.DeleteUser(i);
        }
    }

}
