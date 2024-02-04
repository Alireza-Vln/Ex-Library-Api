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

        [HttpPost("Add-Book/{i}")]

        public int AddBook([FromRoute] int i,[FromBody] AddBookDto dto)
        {
            return _service.AddBook(i,dto);

        }
        [HttpGet("Get-book")]
       public List<Book> GetBooks()
        {
            return _service.GetBook();
        }
        [HttpDelete("delete-Book")]
        public void Deletebook([FromQuery] int i)
        {
            _service.DeletBook(i);
        }





    }
}   

