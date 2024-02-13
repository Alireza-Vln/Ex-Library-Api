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
           var author=_context.Authors.FirstOrDefault(_=>_.Id==i);
            if (author == null)
            {
                throw new Exception("Not found");
            }
            book.AuthorId = author.Id;
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }
}
