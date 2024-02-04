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
        public DbSet<Author> GetAuthors()
        {
            return _service.GetAuthors();
        }
        [HttpDelete("delete-Author")]
        public void DeleteAuthor([FromRoute]int i)
        {
            _service.DeletAuthor(i);
        }



       

    }
}
