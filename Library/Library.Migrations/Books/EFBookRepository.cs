using Library.DTO;
using Library.Entites;
using Library.EntityMaps;
using Library.Services.Book.Cantract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.EFBookReposittory
{
    public class EFBookRepository : BookRepository
    {
        readonly EfDataContext _context;
        public EFBookRepository(EfDataContext context)
        {
            _context = context;
        }
        public void AddBook(Book book, int i)
        {
            var author = _context.Authors.FirstOrDefault(_ => _.Id == i);
            if (author == null)
            {
                throw new Exception("Not found");
            }
            book.AuthorId = author.Id;
            _context.Books.Add(book);
        }

        public void DeleteBook(int id)
        {
            var delete = _context.Books.Where(_ => _.Id == id).First();
            if (delete == null)
            {
                throw new Exception("Not Found");
            }
            _context.Books.Remove(delete);

        }

        public List<GetBooksDto> GetAllBooks()
        {

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
        }
    }
}

