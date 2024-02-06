using Library.DTO;
using Library.Entites;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    [ApiController]
    [Route("Api/Book")]
    public class BookController : Controller
    {
        private readonly BookService _service;
        public BookController()
        {
            _service = new BookService();

        }

        [HttpPost("Add-Book")]

        public int AddBook([FromBody] AddBookDto dto)
        {
            return _service.AddBook(dto);

        }
        [HttpGet("Get-book")]
       public List<GetBooksDto> GetBooks()
        {
            return _service.GetBook();
        }
        [HttpDelete("delete-Book/{i}")]
        public void Deletebook([FromRoute] int i)
        {
            _service.DeletBook(i);
        }





    }
}   

