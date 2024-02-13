using Library.DTO;
using Library.Services.Author.Cantract;
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
        [HttpPost("Add-Aothur")]
        public async Task AddAuthor([FromBody] AddAuthorDto dto) 
        {
            await _service.AddAuthor(dto);
        }
    }
}
