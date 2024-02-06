using Library.DTO;
using Library.Entites;
using Library.EntityMaps;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    [ApiController]
    [Route("Api/Author")]
    public class AuthorController : Controller
    {
        private readonly AuthorService _service;
        public AuthorController()
        {
            _service = new AuthorService();
            
        }

        [HttpPost("Add-Author")]
        public int AddAuthor([FromQuery] AddAuthorDto dto)
        {
            return _service.AddAuthor(dto);

        }
        [HttpGet("Get-Author")]
        public List<GetAothorDto> GetAuthors()
        {
            return _service.GetAuthor();
        }
        [HttpDelete("delete-Author/{i}")]
        public void DeleteAuthor([FromRoute]int i)
        {
            _service.DeletAuthor(i);
        }



       

    }
}
