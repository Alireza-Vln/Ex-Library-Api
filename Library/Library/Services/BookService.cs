using Library.DTO;
using Library.Entites;
using Library.EntityMaps;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public class BookService
    {
        private readonly EfDataContext _context;
        public BookService()
        {
            _context = new EfDataContext();
        }
        public int AddBook(int i,AddBookDto dto)
        {
           
            var author = _context.Authors.FirstOrDefault(_ => _.Id == i);
            var book = new Book
            {
                Name = dto.Name,
                Count = dto.Count,
                AuthorId = author.Id,
                Author=author,
            };
            _context.Books.Add(book);
            _context.SaveChanges();
            return book.Id;
        }
        public List<Book> GetBook()
        {
            return (from bo in _context.Set<Book>()
                    join ath in _context.Authors
                    on bo.AuthorId equals ath.Id
                    select new Book
                    {
                        Id=bo.Id,
                        Name=bo.Name,
                        Count=bo.Count,
                        RentBook=bo.RentBook,
                       

                    }).ToList();

        }
        public void DeletBook(int id)
        {
            var delete = _context.Books.Where(_ => _.Id == id).First();
            _context.Books.Remove(delete);
        }
    }
}

