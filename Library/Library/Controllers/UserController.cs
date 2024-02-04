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
        [HttpPost("user-rent-Book")]
        public void RentBooks([FromRoute]string username,[FromRoute] string Bookname)
        {
            _service.RentBook(username, Bookname);
        }
    }

}
