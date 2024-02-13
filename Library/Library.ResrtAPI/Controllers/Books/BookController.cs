using Library.DTO;
using Library.Services.Book.Cantract;
using Microsoft.AspNetCore.Mvc;

namespace Library.ResrtAPI.Controllers.Books
{
    [ApiController]
    [Route("Api/Books")]
    public class BookController : Controller
    {
       private readonly BookService _service;
        public BookController(BookService service)
        {
            _service = service;
        }

        [HttpPost("Add-Book")]
        public async Task AddBook([FromBody]AddBookDto dto,[FromQuery]int id)
        {
           await _service.AddBook(dto, id);
        }
    }
}
