using Library.DTO;
using Library.Entites;
using Library.EntityMaps;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;

namespace Library.Services
{
    public class BookService
    {
        private readonly EfDataContext _context;
        public BookService()
        {
            _context = new EfDataContext();
        }
        public int AddBook(AddBookDto dto)
        {


            var author = _context.Authors.FirstOrDefault(_ => _.Id == dto.AuthorId);

            var book = new Book
            {
                Name = dto.Name,
                Count = dto.Count,
                AuthorId = author.Id,

            };

            _context.Books.Add(book);
            _context.SaveChanges();
            return book.Id;
        }
        public List<GetBooksDto> GetBook()
        {
            return (from bo in _context.Set<Book>()
                    join ath in _context.Authors
                    on bo.AuthorId equals ath.Id
                    into temp
                    from ath in temp.DefaultIfEmpty()
                    select new GetBooksDto
                    {
                        BookId = bo.Id,
                        Name = bo.Name,
                        Authorname = ath.Name,
                        Count = bo.Count,
                        RentBook = bo.RentBook,

                    }).ToList();

        }
        public void DeletBook(int id)
        {
            var delete = _context.Books.Where(_ => _.Id == id).First();
            if (delete == null)
            {
                throw new Exception();
            }
            _context.Books.Remove(delete);
            _context.SaveChanges();
        }
    }
}

