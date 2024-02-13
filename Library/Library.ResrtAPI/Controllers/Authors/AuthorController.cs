using Library.DTO;
using Library.Services.Author.Cantract;
using Library.Services.Authors.Cantract.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Library.ResrtAPI.Controllers.Author
{
    [ApiController]
    [Route("api/Author")]
    public class AuthorController : Controller
    {
        private readonly AuthorService _service;
        public AuthorController(AuthorService service)
        {
            _service = service;
        }
        [HttpPost("Add-Author")]
        public async Task AddAuthor([FromBody] AddAuthorDto dto) 
        {
            await _service.AddAuthor(dto);
        }
        [HttpGet("Get-AllAuthor")]
        public async Task<List<GetAuthorDto>> GetAllAuthor()
        {
            return await _service.GetAllAuthor();
        }
        [HttpDelete("Delete-Author")]
        public async Task DeleteAuthor([FromQuery] int id)
        {
            _service.DeleteAuthor(id);
        }
        
            

    }
}
