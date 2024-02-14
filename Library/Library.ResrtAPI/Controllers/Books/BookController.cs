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

        [HttpPost("Add-Book/{Id}")]
        public async Task AddBook([FromBody]AddBookDto dto,[FromRoute]int id)
        {
           await _service.AddBook(dto, id);
        }
        [HttpGet("Get-AllBooks")]
        public async Task<List<GetBooksDto>> GetAllBooks()
        {
            return await _service.GetAllBooks();
        }
        [HttpDelete("Delete-Book/{id}")]
        public async Task DeleteBook([FromRoute] int id)
        {
           _service.DeleteBook(id);
        }
    }
}
